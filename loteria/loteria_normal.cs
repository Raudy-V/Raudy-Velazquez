using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace loteria
{
   
    public partial class normal_desig : Form
    {
        private int[] numerosAleatorios; 

        public normal_desig()
        {
            InitializeComponent();
            numerosAleatorios = new int[3]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                int num = Convert.ToInt32(textBox1.Text);
             int dinero = Convert.ToInt32(textBox2.Text);

            if(num > 40)
            {
                MessageBox.Show("Recuerde son numeros del 0-40");
            }

                for (global::System.Int32 i = 0; i < 3;)
                {
                    Random rnd = new Random();
                    numerosAleatorios[i] = rnd.Next(0, 41);

                 
                    MessageBox.Show($"Números ganadores: {numerosAleatorios[i]}");
                i++;
            }
                textBox2.Clear();

            label8.Text = numerosAleatorios[0].ToString() + " - " + numerosAleatorios[1].ToString() + " - " + numerosAleatorios[2].ToString();

            if (num == numerosAleatorios[0])
                {
                    dinero *= 15;
                    label5.Text = dinero.ToString() + "$RD";
                    label4.Visible = true;
                    label5.Visible = true;
                }

                else if (num == numerosAleatorios[1])
                {
                    dinero *= 3;
                    label5.Text = dinero.ToString() + "$RD";
                    label4.Visible = true;
                    label5.Visible = true;
                }
                else if (num == numerosAleatorios[2])
                {
                    dinero *= 1;
                    label5.Text = dinero.ToString() + "$RD";
                    label4.Visible = true;
                    label5.Visible = true;
                }
else
            {
                label6.Visible = true;
            }
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); ;
        }
        }
}
