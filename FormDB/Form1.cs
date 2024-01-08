namespace FormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(Convert.ToString(txtNombre.Text), Convert.ToString(txtApellido.Text));
            UserController.AgregarUser(persona);
            txtNombre.Text = "";
            txtApellido.Text = "";

        }

        private void buttonMostrarUser_Click(object sender, EventArgs e)
        {
            //asocial el form Lista_Usuarios a un objeto manipulable
            //gracias al evento botón mostrarUsers
            Form formUsers = new ListaUsuarios();
            formUsers.Show();



        }
    }
}
