namespace practica_5_visual_studio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RebeccaPurple;
            label1.Location = new Point(240, 33);
            label1.Name = "label1";
            label1.Size = new Size(313, 22);
            label1.TabIndex = 0;
            label1.Text = "Introduce las Dimensiones del Cilindro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(240, 87);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(240, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(460, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 92);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(270, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(363, 214);
            button2.Name = "button2";
            button2.Size = new Size(76, 32);
            button2.TabIndex = 7;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(460, 214);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaShell;
            label4.Location = new Point(270, 269);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 9;
            label4.Text = "Base area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaShell;
            label5.Location = new Point(270, 303);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 10;
            label5.Text = "Lateral area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaShell;
            label6.Location = new Point(270, 332);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 11;
            label6.Text = "Total area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(270, 365);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 12;
            label7.Text = "Volumen";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(435, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(435, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(435, 332);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(435, 365);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.OldLace;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}