using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_POO2
{
    public partial class Form1 : Form
    {
        private double primero;
        private double segundo;
        private double resultado;
        private String operador;

        public Form1()
        {
            InitializeComponent();
            operador = "";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "2";
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txt1.Text);
            txt1.Clear();

        }

        private void bAC_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txtFact.Clear();
            list1.Items.Clear();

        }

        private void bSubs_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txt1.Text);
            txt1.Clear();

        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txt1.Text);
            txt1.Clear();

        }

        private void bMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txt1.Text);
            txt1.Clear();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txt1.Text);

            switch (operador)
            {

                case "+":

                    resultado = primero + segundo;
                    txt1.Text = resultado.ToString();
                break;

                case "-":

                    resultado = primero - segundo;
                    txt1.Text = resultado.ToString();

                    break;

                case "/":

                    resultado = primero / segundo;
                    txt1.Text = resultado.ToString();

                    break;

                case "*":

                    resultado = primero * segundo;
                    txt1.Text = resultado.ToString();

                    break;

            }
        }

        private void b3_Click_1(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "3";

        }

        private void b4_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "4";

        }

        private void b5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "5";

        }

        private void b6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "6";

        }

        private void b7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "7";

        }

        private void b8_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "8";

        }

        private void b9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "9";

        }

        private void b0_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "0";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {

        }

        private void menuFibo_Click(object sender, EventArgs e)
        {
            bFib.Visible = true;
            bFib.Enabled = true;
            list1.Visible = true;
        }

        private void menuFact_Click(object sender, EventArgs e)
        {

            bFact.Visible = true;
            bFact.Enabled = true;
            txtFact.Visible = true;

        }

        private void menuMulti_Click(object sender, EventArgs e)
        {

        }

        private void menuDiv_Click(object sender, EventArgs e)
        {

            bDivi.Visible = true;
            bDivi.Enabled = true;
            list1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void menuMultiUni_Click(object sender, EventArgs e)
        {

            operador = "1";
            bMulti.Visible = true;
            bMulti.Enabled = true;
            list1.Visible = true;
        }

        private void menuMultiSerie_Click(object sender, EventArgs e)
        {

            operador = "2";
            bMulti.Visible = true;
            bMulti.Enabled = true;
            list1.Visible = true;
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();

            int n;
            int a;

            a = int.Parse(txt1.Text);

            

            switch (operador)
            {


                case "1":

                    for (n = 0; n <= 10; n++)
                    {

                        int b = n * a;

                        list1.Items.Add(b.ToString());

                        

                    }


                    break;


                case "2":


                    for (n = 0; n <= a; n++)
                    {


                        double b = Math.Pow(n,2);

                        list1.Items.Add(b.ToString());



                    }

                    break;

            }

        }

        private void bFib_Click(object sender, EventArgs e)
        {
            int y = int.Parse(txt1.Text);

        
            list1.Items.Clear();


            int a = 0;
            int b = 1;
            int c = 1;

            for (int x = 0; x <= y; x++)
            {
                list1.Items.Add(a.ToString());

                a = b;
                b = c;
                c = a + b;


            }
            

        }

        private void bFact_Click(object sender, EventArgs e)
        {

            txtFact.Clear();

            int a = int.Parse(txt1.Text);

         

            int b = 1;

            int n;

            for (n = 1; n <=a ; n++)
            {

                b = n * b;

                txtFact.Text = b.ToString();

            }

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bFact.Visible = false;
            bFact.Enabled = false;
            bFib.Visible = false;
            bFib.Enabled = false;
            bDivi.Visible = false;
            bDivi.Enabled = false;
            bMulti.Visible = false;
            bMulti.Enabled = false;
            list1.Visible = false;
            txtFact.Visible = false;
        }

        private void bDivi_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();

            int a = int.Parse(txt1.Text);

            int n;

            for (n = 1; n <= a; n++ )
            {

                if ( a % n == 0)
                {

                    list1.Items.Add(n.ToString());

                }

            }

        }
    }
}
