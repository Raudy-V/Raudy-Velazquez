using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteria
{
    public partial class Pale : Form
    {
        private int[] numerosAleatorios;
        public Pale()
        {
            InitializeComponent();
            numerosAleatorios = new int[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int dinero = Convert.ToInt32(textBox2.Text);

            if (dinero < 10)
            {
                num1 = 0 ;
                num2 = 0;
                dinero = 0;
                MessageBox.Show("No se puede jugar menos de 10 $RD");
                MessageBox.Show("Vuelva a llenar los campos adecuadamente");
                return;
            }
            for (global::System.Int32 i = 0; i < 3;)
            {
                Random rnd = new Random();
                numerosAleatorios[i] = rnd.Next(0, 41);


                MessageBox.Show($"Números ganadores: {numerosAleatorios[i]}");
                i++;
            }
            label9.Text = numerosAleatorios[0].ToString() + " - " + numerosAleatorios[1].ToString() + " - " + numerosAleatorios[2].ToString();
           
            textBox2.Clear();

            BD_Program();

            if (num1 == numerosAleatorios[0] && num2 == numerosAleatorios[1])
            {
                dinero *= 1000;
                label5.Text = dinero.ToString() + "$RD";
                label4.Visible = true;
                label5.Visible = true;
            }
           else if (num1 == numerosAleatorios[0] && num2 == numerosAleatorios[2])
            {
                dinero *= 100;
                label5.Text = dinero.ToString() + "$RD";
                label4.Visible = true;
                label5.Visible = true;
            }

            else if (num1 == numerosAleatorios[1] && num2 == numerosAleatorios[2])
            {
                dinero *= 10;
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

        // Create your POCO class entity
        private class NLotery
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public int Primera { get; set; }
            public int Segunda { get; set; }
            public int Tercera { get; set; }


        }

        private void BD_Program()
        {
            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(@"C:\Users\Velaz\Documents\liteDB\Pale.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<NLotery>("NLotery");

                // Create your new customer instance
                var L_Normal = new NLotery
                {
                    Fecha = DateTime.Now,
                    Primera = numerosAleatorios[0],
                    Segunda = numerosAleatorios[1],
                    Tercera = numerosAleatorios[2]
                };
                // Insert new customer document (Id will be auto-incremented)
                col.Insert(L_Normal);
                col.EnsureIndex(x => x.Fecha);


            }
        }

    }
}
