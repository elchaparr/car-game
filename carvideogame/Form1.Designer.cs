namespace carvideogame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pantalla = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.monedas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.blo2 = new System.Windows.Forms.PictureBox();
            this.blo3 = new System.Windows.Forms.PictureBox();
            this.blo = new System.Windows.Forms.PictureBox();
            this.lambo = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pantalla
            // 
            this.pantalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pantalla.BackgroundImage")));
            this.pantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantalla.Controls.Add(this.button4);
            this.pantalla.Controls.Add(this.button3);
            this.pantalla.Controls.Add(this.label2);
            this.pantalla.Controls.Add(this.textBox1);
            this.pantalla.Controls.Add(this.button2);
            this.pantalla.Controls.Add(this.monedas);
            this.pantalla.Controls.Add(this.button1);
            this.pantalla.Controls.Add(this.label1);
            this.pantalla.Controls.Add(this.blo2);
            this.pantalla.Controls.Add(this.blo3);
            this.pantalla.Controls.Add(this.blo);
            this.pantalla.Controls.Add(this.lambo);
            this.pantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantalla.Location = new System.Drawing.Point(0, 0);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(289, 687);
            this.pantalla.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(106, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Registrar resultados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monedas
            // 
            this.monedas.BackColor = System.Drawing.Color.Transparent;
            this.monedas.Image = ((System.Drawing.Image)(resources.GetObject("monedas.Image")));
            this.monedas.Location = new System.Drawing.Point(80, 33);
            this.monedas.Name = "monedas";
            this.monedas.Size = new System.Drawing.Size(30, 32);
            this.monedas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monedas.TabIndex = 6;
            this.monedas.TabStop = false;
            this.monedas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.monedas_PreviewKeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(106, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Do you want to play again?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // blo2
            // 
            this.blo2.BackColor = System.Drawing.Color.Transparent;
            this.blo2.Image = ((System.Drawing.Image)(resources.GetObject("blo2.Image")));
            this.blo2.Location = new System.Drawing.Point(125, 0);
            this.blo2.Name = "blo2";
            this.blo2.Size = new System.Drawing.Size(50, 79);
            this.blo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blo2.TabIndex = 3;
            this.blo2.TabStop = false;
            this.blo2.Click += new System.EventHandler(this.blo2_Click);
            // 
            // blo3
            // 
            this.blo3.BackColor = System.Drawing.Color.Transparent;
            this.blo3.Image = ((System.Drawing.Image)(resources.GetObject("blo3.Image")));
            this.blo3.Location = new System.Drawing.Point(227, 0);
            this.blo3.Name = "blo3";
            this.blo3.Size = new System.Drawing.Size(50, 79);
            this.blo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blo3.TabIndex = 2;
            this.blo3.TabStop = false;
            // 
            // blo
            // 
            this.blo.BackColor = System.Drawing.Color.Transparent;
            this.blo.Image = ((System.Drawing.Image)(resources.GetObject("blo.Image")));
            this.blo.Location = new System.Drawing.Point(12, 0);
            this.blo.Name = "blo";
            this.blo.Size = new System.Drawing.Size(50, 79);
            this.blo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blo.TabIndex = 1;
            this.blo.TabStop = false;
            // 
            // lambo
            // 
            this.lambo.BackColor = System.Drawing.Color.Transparent;
            this.lambo.Image = ((System.Drawing.Image)(resources.GetObject("lambo.Image")));
            this.lambo.Location = new System.Drawing.Point(50, 586);
            this.lambo.Name = "lambo";
            this.lambo.Size = new System.Drawing.Size(52, 90);
            this.lambo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lambo.TabIndex = 0;
            this.lambo.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Mostrar resultados";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 687);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pantalla.ResumeLayout(false);
            this.pantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pantalla;
        private System.Windows.Forms.PictureBox lambo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox blo;
        private System.Windows.Forms.PictureBox blo3;
        private System.Windows.Forms.PictureBox blo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox monedas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

