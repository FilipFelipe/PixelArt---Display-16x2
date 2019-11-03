using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt___Display_16x2
{
    
    public partial class Main : Form
    {
        int[] numero1 = new int[5];
        int[] numero2 = new int[5];
        int[] numero3 = new int[5];
        int[] numero4 = new int[5];
        int[] numero5 = new int[5];
        int[] numero6 = new int[5];
        int[] numero7 = new int[5];
        int[] numero8 = new int[5];
        public Main()
        {
            
            InitializeComponent();

            clear();

        }
        public void clear() {
            //b1
            b11.BackColor = Color.White;
            b12.BackColor = Color.White;
            b13.BackColor = Color.White;
            b14.BackColor = Color.White;
            b15.BackColor = Color.White;
            numero1[0] = 0;
            numero1[1] = 0;
            numero1[2] = 0;
            numero1[3] = 0;
            numero1[4] = 0;
            //b2
            b21.BackColor = Color.White;
            b22.BackColor = Color.White;
            b23.BackColor = Color.White;
            b24.BackColor = Color.White;
            b25.BackColor = Color.White;
            numero2[0] = 0;
            numero2[1] = 0;
            numero2[2] = 0;
            numero2[3] = 0;
            numero2[4] = 0;
            //b3
            b31.BackColor = Color.White;
            b32.BackColor = Color.White;
            b33.BackColor = Color.White;
            b34.BackColor = Color.White;
            b35.BackColor = Color.White;
            numero3[0] = 0;
            numero3[1] = 0;
            numero3[2] = 0;
            numero3[3] = 0;
            numero3[4] = 0;
            //b4
            b41.BackColor = Color.White;
            b42.BackColor = Color.White;
            b43.BackColor = Color.White;
            b44.BackColor = Color.White;
            b45.BackColor = Color.White;
            numero4[0] = 0;
            numero4[1] = 0;
            numero4[2] = 0;
            numero4[3] = 0;
            numero4[4] = 0;
            //b5
            b51.BackColor = Color.White;
            b52.BackColor = Color.White;
            b53.BackColor = Color.White;
            b54.BackColor = Color.White;
            b55.BackColor = Color.White;
            numero5[0] = 0;
            numero5[1] = 0;
            numero5[2] = 0;
            numero5[3] = 0;
            numero5[4] = 0;
            //b6
            b61.BackColor = Color.White;
            b62.BackColor = Color.White;
            b63.BackColor = Color.White;
            b64.BackColor = Color.White;
            b65.BackColor = Color.White;
            numero6[0] = 0;
            numero6[1] = 0;
            numero6[2] = 0;
            numero6[3] = 0;
            numero6[4] = 0;
            //b7
            b71.BackColor = Color.White;
            b72.BackColor = Color.White;
            b73.BackColor = Color.White;
            b74.BackColor = Color.White;
            b75.BackColor = Color.White;
            numero7[0] = 0;
            numero7[1] = 0;
            numero7[2] = 0;
            numero7[3] = 0;
            numero7[4] = 0;
            //b8
            b81.BackColor = Color.White;
            b82.BackColor = Color.White;
            b83.BackColor = Color.White;
            b84.BackColor = Color.White;
            b85.BackColor = Color.White;
            numero8[0] = 0;
            numero8[1] = 0;
            numero8[2] = 0;
            numero8[3] = 0;
            numero8[4] = 0;

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            clear();
            textBox1.Text = null;
            nome.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (b15.BackColor == Color.White)
            {
                b15.BackColor = Color.Black;
                numero1[4] = 1;
            }
            else
            {
                b15.BackColor = Color.White;
                numero1[4] = 0;
               
            }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (b14.BackColor == Color.White)
            {
                b14.BackColor = Color.Black;
                numero1[3] = 1;
            }
            else
            {
                b14.BackColor = Color.White;
                numero1[3] = 0;
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.BackColor == Color.White)
            {
                b13.BackColor = Color.Black;
                numero1[2] = 1;
            }
            else
            {
                b13.BackColor = Color.White;
                numero1[2] = 0;
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.BackColor == Color.White)
            {
                b12.BackColor = Color.Black;
                numero1[1] = 1;
            }
            else
            {
                b12.BackColor = Color.White;
                numero1[1] = 0;
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.BackColor == Color.White)
            {
                b11.BackColor = Color.Black;
                numero1[0] = 1;
            }
            else
            {
                b11.BackColor = Color.White;
                numero1[0] = 0;
            }
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.BackColor == Color.White)
            {
                b21.BackColor = Color.Black;
                numero2[0] = 1;
            }
            else
            {
                b21.BackColor = Color.White;
                numero2[0] = 0;
            }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (b22.BackColor == Color.White)
            {
                b22.BackColor = Color.Black;
                numero2[1] = 1;
            }
            else
            {
                b22.BackColor = Color.White;
                numero2[1] = 0;
            }
        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (b23.BackColor == Color.White)
            {
                b23.BackColor = Color.Black;
                numero2[2] = 1;
            }
            else
            {
                b23.BackColor = Color.White;
                numero2[2] = 0;
            }
        }

        private void b24_Click(object sender, EventArgs e)
        {
            if (b24.BackColor == Color.White)
            {
                b24.BackColor = Color.Black;
                numero2[3] = 1;
            }
            else
            {
                b24.BackColor = Color.White;
                numero2[3] = 0;
            }
        }

        private void b25_Click(object sender, EventArgs e)
        {
            if (b25.BackColor == Color.White)
            {
                b25.BackColor = Color.Black;
                numero2[4] = 1;
            }
            else
            {
                b25.BackColor = Color.White;
                numero2[4] = 0;
            }
        }

        private void b31_Click(object sender, EventArgs e)
        {
            if (b31.BackColor == Color.White)
            {
                b31.BackColor = Color.Black;
                numero3[0] = 1;
            }
            else
            {
                b31.BackColor = Color.White;
                numero3[0] = 0;
            }
        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (b32.BackColor == Color.White)
            {
                b32.BackColor = Color.Black;
                numero3[1] = 1;
            }
            else
            {
                b32.BackColor = Color.White;
                numero3[1] = 0;
            }
        }

        private void b33_Click(object sender, EventArgs e)
        {
            if (b33.BackColor == Color.White)
            {
                b33.BackColor = Color.Black;
                numero3[2] = 1;
            }
            else
            {
                b33.BackColor = Color.White;
                numero3[2] = 0;
            }
        }

        private void b34_Click(object sender, EventArgs e)
        {
            if (b34.BackColor == Color.White)
            {
                b34.BackColor = Color.Black;
                numero3[3] = 1;
            }
            else
            {
                b34.BackColor = Color.White;
                numero3[3] = 0;
            }
        }

        private void b35_Click(object sender, EventArgs e)
        {
            if (b35.BackColor == Color.White)
            {
                b35.BackColor = Color.Black;
                numero3[4] = 1;
            }
            else
            {
                b35.BackColor = Color.White;
                numero3[4] = 0;
            }
        }

        private void b41_Click(object sender, EventArgs e)
        {
            if (b41.BackColor == Color.White)
            {
                b41.BackColor = Color.Black;
                numero4[0] = 1;
            }
            else
            {
                b41.BackColor = Color.White;
                numero4[0] = 0;
            }
        }

        private void b42_Click(object sender, EventArgs e)
        {
            if (b42.BackColor == Color.White)
            {
                b42.BackColor = Color.Black;
                numero4[1] = 1;
            }
            else
            {
                b42.BackColor = Color.White;
                numero4[1] = 0;
            }
        }

        private void b43_Click(object sender, EventArgs e)
        {
            if (b43.BackColor == Color.White)
            {
                b43.BackColor = Color.Black;
                numero4[2] = 1;
            }
            else
            {
                b43.BackColor = Color.White;
                numero4[2] = 0;
            }
        }

        private void b44_Click(object sender, EventArgs e)
        {
            if (b44.BackColor == Color.White)
            {
                b44.BackColor = Color.Black;
                numero4[3] = 1;
            }
            else
            {
                b44.BackColor = Color.White;
                numero4[3] = 0;
            }
        }

        private void b45_Click(object sender, EventArgs e)
        {
            if (b45.BackColor == Color.White)
            {
                b45.BackColor = Color.Black;
                numero4[4] = 1;
            }
            else
            {
                b45.BackColor = Color.White;
                numero4[4] = 0;
            }
        }


        private void b51_Click(object sender, EventArgs e)
        {
            if (b51.BackColor == Color.White)
            {
                b51.BackColor = Color.Black;
                numero5[0] = 1;
            }
            else
            {
                b51.BackColor = Color.White;
                numero5[0] = 0;
            }
        }

        private void b52_Click(object sender, EventArgs e)
        {
            if (b52.BackColor == Color.White)
            {
                b52.BackColor = Color.Black;
                numero5[1] = 1;
            }
            else
            {
                b52.BackColor = Color.White;
                numero5[1] = 0;
            }
        }

        private void b53_Click(object sender, EventArgs e)
        {
            if (b53.BackColor == Color.White)
            {
                b53.BackColor = Color.Black;
                numero5[2] = 1;
            }
            else
            {
                b53.BackColor = Color.White;
                numero5[2] = 0;
            }
        }

        private void b54_Click(object sender, EventArgs e)
        {
            if (b54.BackColor == Color.White)
            {
                b54.BackColor = Color.Black;
                numero5[3] = 1;
            }
            else
            {
                b54.BackColor = Color.White;
                numero5[3] = 0;
            }
        }

        private void b55_Click(object sender, EventArgs e)
        {
            if (b55.BackColor == Color.White)
            {
                b55.BackColor = Color.Black;
                numero5[4] = 1;
            }
            else
            {
                b55.BackColor = Color.White;
                numero5[4] = 0;
            }
        }

        private void b61_Click(object sender, EventArgs e)
        {
            if (b61.BackColor == Color.White)
            {
                b61.BackColor = Color.Black;
                numero6[0] = 1;
            }
            else
            {
                b61.BackColor = Color.White;
                numero6[0] = 0;
            }
        }

        private void b62_Click(object sender, EventArgs e)
        {
            if (b62.BackColor == Color.White)
            {
                b62.BackColor = Color.Black;
                numero6[1] = 1;
            }
            else
            {
                b62.BackColor = Color.White;
                numero6[1] = 0;
            }
        }

        private void b63_Click(object sender, EventArgs e)
        {
            if (b63.BackColor == Color.White)
            {
                b63.BackColor = Color.Black;
                numero6[2] = 1;
            }
            else
            {
                b63.BackColor = Color.White;
                numero6[2] = 0;
            }
        }

        private void b64_Click(object sender, EventArgs e)
        {
            if (b64.BackColor == Color.White)
            {
                b64.BackColor = Color.Black;
                numero6[3] = 1;
            }
            else
            {
                b64.BackColor = Color.White;
                numero6[3] = 0;
            }
        }

        private void b65_Click(object sender, EventArgs e)
        {
            if (b65.BackColor == Color.White)
            {
                b65.BackColor = Color.Black;
                numero6[4] = 1;
            }
            else
            {
                b65.BackColor = Color.White;
                numero6[4] = 0;
            }
        }

        private void b71_Click(object sender, EventArgs e)
        {
            if (b71.BackColor == Color.White)
            {
                b71.BackColor = Color.Black;
                numero7[0] = 1;
            }
            else
            {
                b71.BackColor = Color.White;
                numero7[0] = 0;
            }
        }

        private void b72_Click(object sender, EventArgs e)
        {
            if (b72.BackColor == Color.White)
            {
                b72.BackColor = Color.Black;
                numero7[1] = 1;
            }
            else
            {
                b72.BackColor = Color.White;
                numero7[1] = 0;
            }
        }

        private void b73_Click(object sender, EventArgs e)
        {
            if (b73.BackColor == Color.White)
            {
                b73.BackColor = Color.Black;
                numero7[2] = 1;
            }
            else
            {
                b73.BackColor = Color.White;
                numero7[2] = 0;
            }
        }

        private void b74_Click(object sender, EventArgs e)
        {
            if (b74.BackColor == Color.White)
            {
                b74.BackColor = Color.Black;
                numero7[3] = 1;
            }
            else
            {
                b74.BackColor = Color.White;
                numero7[3] = 0;
            }
        }

        private void b75_Click(object sender, EventArgs e)
        {
            if (b75.BackColor == Color.White)
            {
                b75.BackColor = Color.Black;
                numero7[4] = 1;
            }
            else
            {
                b75.BackColor = Color.White;
                numero7[4] = 0;
            }
        }

        private void b81_Click(object sender, EventArgs e)
        {
            if (b81.BackColor == Color.White)
            {
                b81.BackColor = Color.Black;
                numero8[0] = 1;
            }
            else
            {
                b81.BackColor = Color.White;
                numero8[0] = 0;
            }
        }

        private void b82_Click(object sender, EventArgs e)
        {
            if (b82.BackColor == Color.White)
            {
                b82.BackColor = Color.Black;
                numero8[1] = 1;
            }
            else
            {
                b82.BackColor = Color.White;
                numero8[1] = 0;
            }
        }

        private void b83_Click(object sender, EventArgs e)
        {
            if (b83.BackColor == Color.White)
            {
                b83.BackColor = Color.Black;
                numero8[2] = 1;
            }
            else
            {
                b83.BackColor = Color.White;
                numero8[2] = 0;
            }
        }

        private void b84_Click(object sender, EventArgs e)
        {
            if (b84.BackColor == Color.White)
            {
                b84.BackColor = Color.Black;
                numero8[3] = 1;
            }
            else
            {
                b84.BackColor = Color.White;
                numero8[3] = 0;
            }
        }

        private void b85_Click(object sender, EventArgs e)
        {
            if (b85.BackColor == Color.White)
            {
                b85.BackColor = Color.Black;
                numero8[4] = 1;
            }
            else
            {
                b85.BackColor = Color.White;
                numero8[4] = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           
            string coluna1 = " ";
            string coluna2 = " ";
            string coluna3 = " ";
            string coluna4 = " ";
            string coluna5 = " ";
            string coluna6 = "";
            string coluna7 = "";        
            string coluna8 = "";

           
           
            if (pic.Checked)
            {
                 coluna1 = "        0b" + Convert.ToString(numero1[0]) + Convert.ToString(numero1[1]) + Convert.ToString(numero1[2]) + Convert.ToString(numero1[3]) + Convert.ToString(numero1[4]) + ",";
                 coluna2 = "        0b" + Convert.ToString(numero2[0]) + Convert.ToString(numero2[1]) + Convert.ToString(numero2[2]) + Convert.ToString(numero2[3]) + Convert.ToString(numero2[4]) + ",";
                 coluna3 = "        0b" + Convert.ToString(numero3[0]) + Convert.ToString(numero3[1]) + Convert.ToString(numero3[2]) + Convert.ToString(numero3[3]) + Convert.ToString(numero3[4]) + ",";
                 coluna4 = "        0b" + Convert.ToString(numero4[0]) + Convert.ToString(numero4[1]) + Convert.ToString(numero4[2]) + Convert.ToString(numero4[3]) + Convert.ToString(numero4[4]) + ",";
                 coluna5 = "        0b" + Convert.ToString(numero5[0]) + Convert.ToString(numero5[1]) + Convert.ToString(numero5[2]) + Convert.ToString(numero5[3]) + Convert.ToString(numero5[4]) + ",";
                 coluna6 = "        0b" + Convert.ToString(numero6[0]) + Convert.ToString(numero6[1]) + Convert.ToString(numero6[2]) + Convert.ToString(numero6[3]) + Convert.ToString(numero6[4]) + ",";
                 coluna7 = "        0b" + Convert.ToString(numero7[0]) + Convert.ToString(numero7[1]) + Convert.ToString(numero7[2]) + Convert.ToString(numero7[3]) + Convert.ToString(numero7[4]) + ",";
                 coluna8 = "        0b" + Convert.ToString(numero8[0]) + Convert.ToString(numero8[1]) + Convert.ToString(numero8[2]) + Convert.ToString(numero8[3]) + Convert.ToString(numero8[4]) + ",";

            }
            if (arduino.Checked)
            {
                coluna1 = "        B" + Convert.ToString(numero1[0]) + Convert.ToString(numero1[1]) + Convert.ToString(numero1[2]) + Convert.ToString(numero1[3]) + Convert.ToString(numero1[4]) + ",";
                coluna2 = "        B" + Convert.ToString(numero2[0]) + Convert.ToString(numero2[1]) + Convert.ToString(numero2[2]) + Convert.ToString(numero2[3]) + Convert.ToString(numero2[4]) + ",";
                coluna3 = "        B" + Convert.ToString(numero3[0]) + Convert.ToString(numero3[1]) + Convert.ToString(numero3[2]) + Convert.ToString(numero3[3]) + Convert.ToString(numero3[4]) + ",";
                coluna4 = "        B" + Convert.ToString(numero4[0]) + Convert.ToString(numero4[1]) + Convert.ToString(numero4[2]) + Convert.ToString(numero4[3]) + Convert.ToString(numero4[4]) + ",";
                coluna5 = "        B" + Convert.ToString(numero5[0]) + Convert.ToString(numero5[1]) + Convert.ToString(numero5[2]) + Convert.ToString(numero5[3]) + Convert.ToString(numero5[4]) + ",";
                coluna6 = "        B" + Convert.ToString(numero6[0]) + Convert.ToString(numero6[1]) + Convert.ToString(numero6[2]) + Convert.ToString(numero6[3]) + Convert.ToString(numero6[4]) + ",";
                coluna7 = "        B" + Convert.ToString(numero7[0]) + Convert.ToString(numero7[1]) + Convert.ToString(numero7[2]) + Convert.ToString(numero7[3]) + Convert.ToString(numero7[4]) + ",";
                coluna8 = "        B" + Convert.ToString(numero8[0]) + Convert.ToString(numero8[1]) + Convert.ToString(numero8[2]) + Convert.ToString(numero8[3]) + Convert.ToString(numero8[4]) + ",";

            }
            if (nome.Text == "")
            {
                MessageBox.Show("Nome deve ser informado!!");
            }
            else {
                String inicial = "//" + nome.Text;
                String meio = "byte " + nome.Text + "[8] = {";
                String fim = "}; ";
                textBox1.Text = inicial + Environment.NewLine;
                textBox1.Text += meio + Environment.NewLine;

                textBox1.Text += coluna1 + Environment.NewLine;
                textBox1.Text += coluna2 + Environment.NewLine;
                textBox1.Text += coluna3 + Environment.NewLine;

                textBox1.Text += coluna4 + Environment.NewLine;
                textBox1.Text += coluna5 + Environment.NewLine;
                textBox1.Text += coluna6 + Environment.NewLine;
                textBox1.Text += coluna7 + Environment.NewLine;

                textBox1.Text += coluna8 + Environment.NewLine;
                textBox1.Text += fim;

            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Programa desenvolvido por Filip Junio Felipe\nGitHub: https://github.com/FilipFelipe");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pic.Checked)
            {
                arduino.Checked = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (arduino.Checked)
            {
                pic.Checked = false;
            }
            
            
        }

        private void esquemáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção");
        }

        private void arduinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção");
        }

        private void pICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
