using Editoriales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editoriales.Views
{
    public partial class frm_Editoriales : Form
    {
        public frm_Editoriales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        EditorialesController editorialesController = new EditorialesController();
        public int codigoeditorial = 0;

        public void cargaLista()
        {
            lst_Editoriales.Items.Clear();
            lst_Editoriales.DataSource = editorialesController.todos();
            lst_Editoriales.DisplayMember = "nombre"; // Muestra el texto en la lista        
            lst_Editoriales.ValueMember = "editorial_id";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EditorialesModel editorialModel = new EditorialesModel { editorial_id = codigoeditorial };
            DialogResult result = MessageBox.Show("¿Desea eliminar la editorial?", "Formulario de Editoriales", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (editorialModel.eliminar(editorialModel) == "ok")
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
            txt_Detalle_Editoriales.Text = "";
            codigoeditorial = 0;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            codigoeditorial = 0;
            this.Close();
        }

        private void lst_Editoriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Detalle_Editoriales_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_editoriales_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            EditorialesModel Editorial = new EditorialesModel
            {
                editorial_id = codigoeditorial,
                nombre = txt_Detalle_Editoriales.Text
            };
            try
            {
                if (codigoeditorial == 0)
                {
                    respuesta = editorialesController.insertar(Editorial);
                }
                else
                {
                    respuesta = editorialesController.actualizar(Editorial);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardó con éxito");
             codigoeditorial= 0;

            txt_Detalle_Editoriales.Enabled = false;
            txt_Detalle_Editoriales.Text = "";
        }
    }
}
