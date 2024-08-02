using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3_player
{
    public partial class Form1 : Form
    {
        bool play = false;
        string[] ArchivoMP3;
        string[] rutaArchivosMP3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Multiselect = true;
            if (buscador.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ArchivoMP3 = buscador.SafeFileNames;
                rutaArchivosMP3 = buscador.FileNames;
                foreach (var ArchivoMP3 in ArchivoMP3)
                {
                    listtcanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutaArchivosMP3[0];
                listtcanciones.SelectedIndex = 0;
                Btnplay.Image = Properties.Resources.Pause;
            }
        }

        private void listtcanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutaArchivosMP3[listtcanciones.SelectedIndex];
            Lblcancion.Text = ArchivoMP3[listtcanciones.SelectedIndex];
        }

        private void Btnplay_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    Btnplay.Image = Properties.Resources.play;
                    play = false;
                    break;

                case false:
                    Reproductor.Ctlcontrols.play();
                    Btnplay.Image = Properties.Resources.Pause;
                    play = true;
                    break;

                   

            }
        }

        private void Btnstop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            Btnplay.Image = Properties.Resources.play;
            play = false;
        }
        public void Actualizar()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Mstatus.Maximum=(int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();   
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                Mstatus.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          Actualizar();
            Mstatus.Value= (int)Reproductor.Ctlcontrols.currentPosition;
            Mvolumen.Value = Reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            Actualizar();
        }

        private void Mvolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = Mvolumen.Value;
        }
    }
}
