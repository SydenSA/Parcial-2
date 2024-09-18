namespace Libros.Views
{
    partial class frm_Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lst_Libros = new ListBox();
            label3 = new Label();
            Lista = new Label();
            label1 = new Label();
            txt_Detalle_Libros = new TextBox();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_eliminar = new Button();
            btn_editar_editoriales = new Button();
            btn_Guardar_editoriales = new Button();
            SuspendLayout();
            // 
            // lst_Libros
            // 
            lst_Libros.FormattingEnabled = true;
            lst_Libros.ItemHeight = 15;
            lst_Libros.Location = new Point(411, 87);
            lst_Libros.Name = "lst_Libros";
            lst_Libros.Size = new Size(209, 184);
            lst_Libros.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 131);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 28;
            label3.Text = "Nombre libros";
            // 
            // Lista
            // 
            Lista.AutoSize = true;
            Lista.Location = new Point(448, 66);
            Lista.Name = "Lista";
            Lista.Size = new Size(63, 15);
            Lista.TabIndex = 27;
            Lista.Text = "Lista libros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 66);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 26;
            label1.Text = "Datos libros";
            // 
            // txt_Detalle_Libros
            // 
            txt_Detalle_Libros.Location = new Point(200, 165);
            txt_Detalle_Libros.Name = "txt_Detalle_Libros";
            txt_Detalle_Libros.Size = new Size(167, 23);
            txt_Detalle_Libros.TabIndex = 25;
            txt_Detalle_Libros.TextChanged += txt_Detalle_Libros_TextChanged;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(537, 287);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(83, 98);
            btn_Salir.TabIndex = 24;
            btn_Salir.Text = "Regresar/Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(448, 287);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(83, 98);
            btn_Cancelar.TabIndex = 23;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(359, 287);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(83, 98);
            btn_eliminar.TabIndex = 22;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_editar_editoriales
            // 
            btn_editar_editoriales.Location = new Point(270, 287);
            btn_editar_editoriales.Name = "btn_editar_editoriales";
            btn_editar_editoriales.Size = new Size(83, 98);
            btn_editar_editoriales.TabIndex = 21;
            btn_editar_editoriales.Text = "Editar";
            btn_editar_editoriales.UseVisualStyleBackColor = true;
            btn_editar_editoriales.Click += btn_editar_editoriales_Click;
            // 
            // btn_Guardar_editoriales
            // 
            btn_Guardar_editoriales.Location = new Point(181, 287);
            btn_Guardar_editoriales.Name = "btn_Guardar_editoriales";
            btn_Guardar_editoriales.Size = new Size(83, 98);
            btn_Guardar_editoriales.TabIndex = 20;
            btn_Guardar_editoriales.Text = "Guardar";
            btn_Guardar_editoriales.UseVisualStyleBackColor = true;
            btn_Guardar_editoriales.Click += btn_Guardar_editoriales_Click;
            // 
            // frm_Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_Libros);
            Controls.Add(label3);
            Controls.Add(Lista);
            Controls.Add(label1);
            Controls.Add(txt_Detalle_Libros);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar_editoriales);
            Controls.Add(btn_Guardar_editoriales);
            Name = "frm_Libros";
            Text = "frm";
            Load += frm_Libros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_Libros;
        private Label label3;
        private Label Lista;
        private Label label1;
        private TextBox txt_Detalle_Libros;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_eliminar;
        private Button btn_editar_editoriales;
        private Button btn_Guardar_editoriales;
    }
}