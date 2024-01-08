using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDB
{
    public partial class ListaUsuarios : Form
    {
        DataTable dt;

        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            dt = UserController.listarUser();
            grilla_usuarios.DataSource = dt;
        }
    }
}
