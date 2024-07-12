namespace loteria
{
    partial class normal_desig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 28);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 50);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 102);
            label2.Name = "label2";
            label2.Size = new Size(389, 37);
            label2.TabIndex = 2;
            label2.Text = "Inserte el numero a jugar";
            // 
            // button1
            // 
            button1.Location = new Point(166, 333);
            button1.Name = "button1";
            button1.Size = new Size(166, 55);
            button1.TabIndex = 3;
            button1.Text = "Jugar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 220);
            label3.Name = "label3";
            label3.Size = new Size(401, 37);
            label3.TabIndex = 4;
            label3.Text = "Inserte la cantidad a jugar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 45);
            textBox2.TabIndex = 5;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 166);
            label4.Name = "label4";
            label4.Size = new Size(189, 37);
            label4.TabIndex = 6;
            label4.Text = "Usted gano:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 232);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 7;
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 290);
            label6.Name = "label6";
            label6.Size = new Size(197, 37);
            label6.TabIndex = 8;
            label6.Text = "Mala suerte ";
            label6.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(625, 354);
            button2.Name = "button2";
            button2.Size = new Size(120, 48);
            button2.TabIndex = 9;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(475, 34);
            label7.Name = "label7";
            label7.Size = new Size(270, 31);
            label7.TabIndex = 10;
            label7.Text = "Numeros ganadores: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(544, 89);
            label8.Name = "label8";
            label8.Size = new Size(0, 31);
            label8.TabIndex = 11;
            // 
            // normal_desig
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 414);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "normal_desig";
            Text = "loteria normal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;
        private Label label8;
    }
}