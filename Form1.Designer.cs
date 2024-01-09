namespace WinForms_240108_PictureBox
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
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.buttonNastepny = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNowy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.Location = new System.Drawing.Point(89, 373);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(75, 23);
            this.buttonPoprzedni.TabIndex = 0;
            this.buttonPoprzedni.Text = "poprzedni";
            this.buttonPoprzedni.UseVisualStyleBackColor = true;
            this.buttonPoprzedni.Click += new System.EventHandler(this.buttonPoprzedni_Click);
            // 
            // buttonNastepny
            // 
            this.buttonNastepny.Location = new System.Drawing.Point(358, 373);
            this.buttonNastepny.Name = "buttonNastepny";
            this.buttonNastepny.Size = new System.Drawing.Size(75, 23);
            this.buttonNastepny.TabIndex = 1;
            this.buttonNastepny.Text = "następny";
            this.buttonNastepny.UseVisualStyleBackColor = true;
            this.buttonNastepny.Click += new System.EventHandler(this.buttonNastepny_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(124, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNowy
            // 
            this.buttonNowy.Location = new System.Drawing.Point(222, 373);
            this.buttonNowy.Name = "buttonNowy";
            this.buttonNowy.Size = new System.Drawing.Size(75, 23);
            this.buttonNowy.TabIndex = 3;
            this.buttonNowy.Text = "nowy";
            this.buttonNowy.UseVisualStyleBackColor = true;
            this.buttonNowy.Click += new System.EventHandler(this.buttonNowy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 439);
            this.Controls.Add(this.buttonNowy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNastepny);
            this.Controls.Add(this.buttonPoprzedni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPoprzedni;
        private Button buttonNastepny;
        private PictureBox pictureBox1;
        private Button buttonNowy;
        private OpenFileDialog openFileDialog1;
    }
}