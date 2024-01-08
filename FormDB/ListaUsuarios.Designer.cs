namespace FormDB
{
    partial class ListaUsuarios
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
            grilla_usuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grilla_usuarios).BeginInit();
            SuspendLayout();
            // 
            // grilla_usuarios
            // 
            grilla_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla_usuarios.Location = new Point(43, 12);
            grilla_usuarios.Name = "grilla_usuarios";
            grilla_usuarios.Size = new Size(400, 190);
            grilla_usuarios.TabIndex = 0;
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 253);
            Controls.Add(grilla_usuarios);
            Name = "ListaUsuarios";
            Text = "ListaUsuarios";
            Load += ListaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grilla_usuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grilla_usuarios;
    }
}