using Prestamos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autores.Views
{
    public partial class frm_Prestamo : Form
    {
        public frm_Prestamo()
        {
            InitializeComponent();
        }

        private void btn_Guardar_editoriales_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            PrestamosModel prestamo = new PrestamosModel
            {
                prestamo_id = codigoprestamo,
                libro_id = Convert.ToInt32(txt_Detalle_Prestamo.Text),
              
            };

            try
            {
                if (codigoprestamo == 0)
                {
                    respuesta = prestamosController.insertar(prestamo);
                }
                else
                {
                    respuesta = prestamosController.actualizar(prestamo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Se guardó con éxito");
            codigoprestamo = 0;
            txt_Detalle_Prestamo.Enabled = false;
          
            limpiarCampos();
        }

        private void btn_editar_editoriales_Click(object sender, EventArgs e)
        {
            txt_Detalle_Prestamo.Enabled = true;
    
            codigoprestamo = Convert.ToInt32(lst_Prestamo.SelectedValue);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            PrestamosModel prestamo = new PrestamosModel { prestamo_id = codigoprestamo };
            DialogResult result = MessageBox.Show("¿Desea eliminar el préstamo?", "Formulario de Préstamos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (prestamosController.eliminar(prestamo) == "ok")
                {
                    MessageBox.Show("Se eliminó con éxito");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la eliminación");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            codigoprestamo = 0;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            codigoprestamo = 0;
            this.Close();
        }

        private void txt_Detalle_Prestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_Prestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Prestamo_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        PrestamosController prestamosController = new PrestamosController();
        public int codigoprestamo = 0;

        public void cargaLista()
        {
            lst_Prestamo.Items.Clear();
            lst_Prestamo.DataSource = prestamosController.todos();
            lst_Prestamo.DisplayMember = "libro_id"; // Muestra el texto en la lista
            lst_Prestamo.ValueMember = "prestamo_id";
        }

        private void limpiarCampos()
        {
           txt_Detalle_Prestamo.Text = "";
          
        }

    }
}
