namespace FormDB
{
    partial class Form1
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
            groupBoxPrincipal = new GroupBox();
            txtApellido = new TextBox();
            labelApellido = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            buttonAgregar = new Button();
            buttonMostrarUser = new Button();
            groupBoxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(txtApellido);
            groupBoxPrincipal.Controls.Add(labelApellido);
            groupBoxPrincipal.Controls.Add(txtNombre);
            groupBoxPrincipal.Controls.Add(labelNombre);
            groupBoxPrincipal.Location = new Point(16, 17);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(599, 213);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Options";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(55, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(188, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += textBox1_TextChanged;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(23, 98);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(23, 28);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            labelNombre.Click += label1_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(432, 253);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonMostrarUser
            // 
            buttonMostrarUser.Location = new Point(78, 251);
            buttonMostrarUser.Name = "buttonMostrarUser";
            buttonMostrarUser.Size = new Size(118, 25);
            buttonMostrarUser.TabIndex = 2;
            buttonMostrarUser.Text = "Mostrar Usuarios";
            buttonMostrarUser.UseVisualStyleBackColor = true;
            buttonMostrarUser.Click += buttonMostrarUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 322);
            Controls.Add(buttonMostrarUser);
            Controls.Add(buttonAgregar);
            Controls.Add(groupBoxPrincipal);
            Name = "Form1";
            Text = "Form1";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private Label labelNombre;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtNombre;
        private Button buttonAgregar;
        private Button buttonMostrarUser;
    }
}
