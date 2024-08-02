namespace Mp3_player
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listtcanciones = new System.Windows.Forms.ListBox();
            this.Btnagregar = new System.Windows.Forms.PictureBox();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.Mstatus = new XComponent.SliderBar.MACTrackBar();
            this.Btnplay = new System.Windows.Forms.PictureBox();
            this.Btnstop = new System.Windows.Forms.PictureBox();
            this.Mvolumen = new XComponent.SliderBar.MACTrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Lblcancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listtcanciones
            // 
            this.listtcanciones.FormattingEnabled = true;
            this.listtcanciones.ItemHeight = 20;
            this.listtcanciones.Location = new System.Drawing.Point(12, 202);
            this.listtcanciones.Name = "listtcanciones";
            this.listtcanciones.Size = new System.Drawing.Size(338, 144);
            this.listtcanciones.TabIndex = 1;
            this.listtcanciones.SelectedIndexChanged += new System.EventHandler(this.listtcanciones_SelectedIndexChanged);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnagregar.Image = global::Mp3_player.Properties.Resources.Add;
            this.Btnagregar.Location = new System.Drawing.Point(18, 52);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(80, 62);
            this.Btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btnagregar.TabIndex = 2;
            this.Btnagregar.TabStop = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(356, 137);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(220, 90);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // Mstatus
            // 
            this.Mstatus.BackColor = System.Drawing.Color.Transparent;
            this.Mstatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mstatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Mstatus.IndentHeight = 6;
            this.Mstatus.Location = new System.Drawing.Point(12, 169);
            this.Mstatus.Maximum = 10;
            this.Mstatus.Minimum = 0;
            this.Mstatus.Name = "Mstatus";
            this.Mstatus.Size = new System.Drawing.Size(338, 27);
            this.Mstatus.TabIndex = 3;
            this.Mstatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Mstatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Mstatus.TickHeight = 4;
            this.Mstatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Mstatus.TrackerSize = new System.Drawing.Size(10, 10);
            this.Mstatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Mstatus.TrackLineHeight = 3;
            this.Mstatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Mstatus.Value = 0;
            // 
            // Btnplay
            // 
            this.Btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnplay.Image = global::Mp3_player.Properties.Resources.play;
            this.Btnplay.Location = new System.Drawing.Point(104, 52);
            this.Btnplay.Name = "Btnplay";
            this.Btnplay.Size = new System.Drawing.Size(78, 62);
            this.Btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btnplay.TabIndex = 4;
            this.Btnplay.TabStop = false;
            this.Btnplay.Click += new System.EventHandler(this.Btnplay_Click);
            // 
            // Btnstop
            // 
            this.Btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnstop.Image = global::Mp3_player.Properties.Resources.Stop;
            this.Btnstop.Location = new System.Drawing.Point(188, 52);
            this.Btnstop.Name = "Btnstop";
            this.Btnstop.Size = new System.Drawing.Size(75, 62);
            this.Btnstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btnstop.TabIndex = 6;
            this.Btnstop.TabStop = false;
            this.Btnstop.Click += new System.EventHandler(this.Btnstop_Click);
            // 
            // Mvolumen
            // 
            this.Mvolumen.BackColor = System.Drawing.Color.Transparent;
            this.Mvolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mvolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mvolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Mvolumen.IndentHeight = 6;
            this.Mvolumen.Location = new System.Drawing.Point(313, 88);
            this.Mvolumen.Maximum = 10;
            this.Mvolumen.Minimum = 0;
            this.Mvolumen.Name = "Mvolumen";
            this.Mvolumen.Size = new System.Drawing.Size(75, 27);
            this.Mvolumen.TabIndex = 7;
            this.Mvolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Mvolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Mvolumen.TickHeight = 4;
            this.Mvolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Mvolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.Mvolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Mvolumen.TrackLineHeight = 3;
            this.Mvolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Mvolumen.Value = 0;
            this.Mvolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Mvolumen_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mp3_player.Properties.Resources.Volumen;
            this.pictureBox4.Location = new System.Drawing.Point(269, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Lblcancion
            // 
            this.Lblcancion.AutoSize = true;
            this.Lblcancion.Location = new System.Drawing.Point(14, 18);
            this.Lblcancion.Name = "Lblcancion";
            this.Lblcancion.Size = new System.Drawing.Size(19, 20);
            this.Lblcancion.TabIndex = 9;
            this.Lblcancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 424);
            this.Controls.Add(this.Lblcancion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Mvolumen);
            this.Controls.Add(this.Btnstop);
            this.Controls.Add(this.Btnplay);
            this.Controls.Add(this.Mstatus);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.listtcanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.Btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox listtcanciones;
        private System.Windows.Forms.PictureBox Btnagregar;
        private XComponent.SliderBar.MACTrackBar Mstatus;
        private System.Windows.Forms.PictureBox Btnplay;
        private System.Windows.Forms.PictureBox Btnstop;
        private XComponent.SliderBar.MACTrackBar Mvolumen;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Lblcancion;
        private System.Windows.Forms.Timer timer1;
    }
}

