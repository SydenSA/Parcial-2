using Autores.Models;
using Autores.Views;
using Editoriales.Views;
using Libros.Views;

namespace Autores
{
    public partial class frm_Autores : Form
    {
        public frm_Autores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lst_Autores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            AutoresModel Autor = new AutoresModel
            {
                autor_id = codigoautor,
                nombre = txt_Detalle.Text
            };
            try
            {
                if (codigoautor == 0)
                {
                    respuesta = autoresController.insertar(Autor);
                }
                else
                {
                    respuesta = autoresController.actualziar(Autor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardo con exito");
            codigoautor = 0;
            txt_Detalle.Enabled = false;
            txt_Detalle.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_Detalle.Enabled = true;
            codigoautor = Convert.ToInt16(lst_Autores.SelectedValue);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            AutoresModel autoresModel = new AutoresModel { autor_id = codigoautor };
            DialogResult result = MessageBox.Show("Desea Eliminar el Autor", "Formulario de Autores", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (autoresController.eliminar(autoresModel) == "ok")
                {
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la eliminacion");

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Detalle.Text = "";
            codigoautor = 0;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            codigoautor = 0;
            this.Close();
        }

        private void txt_Detalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        AutoresController autoresController = new AutoresController();
        public int codigoautor = 0;

        public void cargaLista()
        {
            lst_Autores.Items.Clear();
            lst_Autores.DataSource = autoresController.todos();
            lst_Autores.DisplayMember = "nombre"; //muestra el texto en la lista        
            lst_Autores.ValueMember = "autor_id";
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Editoriales _Editoriales = new frm_Editoriales();
            _Editoriales.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autores _Autores = new frm_Autores();
            _Autores.ShowDialog();

        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Libros _Libros = new frm_Libros();
            _Libros.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Prestamo _Prestamo = new frm_Prestamo();
            _Prestamo.ShowDialog();
        }

    }
}
