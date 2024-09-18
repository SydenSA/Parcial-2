using Libros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros.Views
{
    public partial class frm_Libros : Form
    {
        public frm_Libros()
        {
            InitializeComponent();
        }

        private void frm_Libros_Load(object sender, EventArgs e)
        {
            cargaLista();
         
        }

       LibrosController librosController = new LibrosController();
        public int codigoLibro = 0;
        private void txt_Detalle_Libros_TextChanged(object sender, EventArgs e)
        {

        }
        public void cargaLista()
        {
            lst_Libros.Items.Clear();
            lst_Libros.DataSource = librosController.todos();
            lst_Libros.DisplayMember = "titulo"; // muestra el título del libro en la lista        
            lst_Libros.ValueMember = "libro_id";
        }

        private void btn_Guardar_editoriales_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            LibrosModel Libro = new LibrosModel
            {
                libro_id = codigoLibro,
                titulo = txt_Detalle_Libros.Text,
                
            };
            try
            {
                if (codigoLibro == 0)
                {
                    respuesta = librosController.insertar(Libro);
                }
                else
                {
                    respuesta = librosController.actualizar(Libro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardó con éxito");
            codigoLibro = 0;
            txt_Detalle_Libros.Enabled = false;
            txt_Detalle_Libros.Text = "";
            
        }

        private void btn_editar_editoriales_Click(object sender, EventArgs e)
        {
            txt_Detalle_Libros.Enabled = true;
            codigoLibro = Convert.ToInt16(lst_Libros.SelectedValue);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LibrosModel libroModel = new LibrosModel { libro_id = codigoLibro };
            DialogResult result = MessageBox.Show("Desea eliminar el libro?", "Formulario de Libros", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (librosController.eliminar(libroModel) == "ok")
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
            txt_Detalle_Libros.Text = "";
            codigoLibro = 0;
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            codigoLibro = 0;
            this.Close();
        }
    }
}
