using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_5_Unidad_3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        int m, mx, my;
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            dgvResultados.Rows.Clear();

            int limite = int.Parse(txtLimite.Text);

            Stack<int> lista = new Stack<int>();
            Console.WriteLine(Fibonacci.CalcularRercursivo(limite));

            Fibonacci.CalcularCicloFor(limite, ref lista);
            int i = limite;

            foreach (int item in lista)
            {
                dgvResultados.Rows.Add($"{i}", $"{item}");
                i--;
                Console.WriteLine(item);
            }


            Console.WriteLine(Fibonacci.CalcularRercursivo(15));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }


    }
}
