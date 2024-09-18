namespace Autores
{
    partial class frm_Autores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Guardar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_Cancelar = new Button();
            btn_Salir = new Button();
            txt_Detalle = new TextBox();
            label1 = new Label();
            Lista = new Label();
            label3 = new Label();
            lst_Autores = new ListBox();
            menuStrip1 = new MenuStrip();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(23, 315);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(83, 98);
            btn_Guardar.TabIndex = 0;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(112, 315);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(83, 98);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(201, 315);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(83, 98);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(290, 315);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(83, 98);
            btn_Cancelar.TabIndex = 3;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(379, 315);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(83, 98);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Regresar/Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Detalle
            // 
            txt_Detalle.Location = new Point(42, 193);
            txt_Detalle.Name = "txt_Detalle";
            txt_Detalle.Size = new Size(167, 23);
            txt_Detalle.TabIndex = 5;
            txt_Detalle.TextChanged += txt_Detalle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Datos Autores";
            label1.Click += label1_Click;
            // 
            // Lista
            // 
            Lista.AutoSize = true;
            Lista.Location = new Point(290, 94);
            Lista.Name = "Lista";
            Lista.Size = new Size(38, 15);
            Lista.TabIndex = 7;
            Lista.Text = "label2";
            Lista.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 159);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre Autores";
            // 
            // lst_Autores
            // 
            lst_Autores.FormattingEnabled = true;
            lst_Autores.ItemHeight = 15;
            lst_Autores.Location = new Point(253, 115);
            lst_Autores.Name = "lst_Autores";
            lst_Autores.Size = new Size(209, 184);
            lst_Autores.TabIndex = 9;
            lst_Autores.SelectedIndexChanged += lst_Autores_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, editorialesToolStripMenuItem, librosToolStripMenuItem, prestamosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(60, 20);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(73, 20);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(74, 20);
            prestamosToolStripMenuItem.Text = "Prestamos";
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            // 
            // frm_Autores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_Autores);
            Controls.Add(label3);
            Controls.Add(Lista);
            Controls.Add(label1);
            Controls.Add(txt_Detalle);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Guardar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form";
            Text = "frm_Autores";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Guardar;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_Cancelar;
        private Button btn_Salir;
        private TextBox txt_Detalle;
        private Label label1;
        private Label Lista;
        private Label label3;
        private ListBox lst_Autores;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
    }
}
