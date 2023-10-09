using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novacalculadora
{
    public partial class Novo : Form
    {


        decimal numero1 = 0, numero2 = 0 ;
        string op = "";
       
        

        public Novo()
         
           
        {

            InitializeComponent();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            texttela.Text = texttela.Text + "1";

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texttela.Text = texttela.Text + "2";

          

        }

        private void button3_Click(object sender, EventArgs e)
        {

            texttela.Text = texttela.Text + "3";

          

        }

        private void button4_Click(object sender, EventArgs e)
        {

            texttela.Text = texttela.Text + "4";

         

        }

        private void button5_Click(object sender, EventArgs e)
        {

            texttela.Text = texttela.Text + "5";

          

        }

        private void button6_Click(object sender, EventArgs e)
        {


            texttela.Text = texttela.Text + "6";

          


        }

        private void button7_Click(object sender, EventArgs e)
        {

            texttela.Text = texttela.Text + "7";

          

        }

        private void button8_Click(object sender, EventArgs e)
        {


            texttela.Text = texttela.Text + "8";

   

        }

        private void button9_Click(object sender, EventArgs e)
        {

            texttela.Text = texttela.Text + "9";

           
        

        }

        private void button12_Click(object sender, EventArgs e)
        {
            texttela.Text = "";

            label1.Text = "";

            

            
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            texttela.Text = texttela.Text + "0";

         
        }

        private void button13_Click(object sender, EventArgs e)
        {

           
          

            numero1 = decimal.Parse(texttela.Text);

            label1.Text = label1.Text += '+';

            op = "soma";

           texttela.Text = "";


            


        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            numero1 = decimal.Parse(texttela.Text);

          //  texttela.Text = texttela.Text += '-';
            label1.Text = label1.Text += '-';

            op = "menos";

            texttela.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {


            numero1 = decimal.Parse(texttela.Text);

            //texttela.Text = texttela.Text + " X ";
            label1.Text = label1.Text += 'X';


            op = "multiplicar";

            texttela.Text = "";



            

        }

        private void button16_Click(object sender, EventArgs e)
        {

            numero1 = decimal.Parse(texttela.Text);

            label1.Text = label1.Text += '/';
            //texttela.Text = texttela.Text + " / ";
            op = "div";

            texttela.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void texttela_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Novo_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {


            switch (op)
            {
                case "soma":

                    
                    numero2 = decimal.Parse(texttela.Text);


                    texttela.Text = Convert.ToString(numero1 + numero2);

                   

                    break;


                case "menos":

                    numero2 = decimal.Parse(texttela.Text);

                    texttela.Text = Convert.ToString(numero1 - numero2);


                    break;


                case "multiplicar":


                    numero2 = decimal.Parse(texttela.Text);

                    texttela.Text = Convert.ToString(numero1 * numero2);


                    break;


                case "div":

                    numero2 = decimal.Parse(texttela.Text);

                    texttela.Text = Convert.ToString(numero1 / numero2);


                    break;

            }
            

        }
        



    }
}
