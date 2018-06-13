using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();
            LBienvenido.Show();
            LBienvenido1.Show();
            LBienvenido2.Show();
            Application.DoEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
