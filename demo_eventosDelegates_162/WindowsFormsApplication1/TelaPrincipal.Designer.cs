namespace WindowsFormsApplication1
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.cmdAcende = new System.Windows.Forms.Button();
            this.cmdApaga = new System.Windows.Forms.Button();
            this.cmdQueima = new System.Windows.Forms.Button();
            this.cmdNova = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAcende
            // 
            this.cmdAcende.Location = new System.Drawing.Point(49, 187);
            this.cmdAcende.Name = "cmdAcende";
            this.cmdAcende.Size = new System.Drawing.Size(75, 23);
            this.cmdAcende.TabIndex = 0;
            this.cmdAcende.Text = "Acende";
            this.cmdAcende.UseVisualStyleBackColor = true;
            this.cmdAcende.Visible = false;
            this.cmdAcende.Click += new System.EventHandler(this.cmdAcende_Click);
            // 
            // cmdApaga
            // 
            this.cmdApaga.Location = new System.Drawing.Point(187, 187);
            this.cmdApaga.Name = "cmdApaga";
            this.cmdApaga.Size = new System.Drawing.Size(75, 23);
            this.cmdApaga.TabIndex = 1;
            this.cmdApaga.Text = "Apaga";
            this.cmdApaga.UseVisualStyleBackColor = true;
            this.cmdApaga.Visible = false;
            this.cmdApaga.Click += new System.EventHandler(this.cmdApaga_Click);
            // 
            // cmdQueima
            // 
            this.cmdQueima.Location = new System.Drawing.Point(87, 234);
            this.cmdQueima.Name = "cmdQueima";
            this.cmdQueima.Size = new System.Drawing.Size(75, 23);
            this.cmdQueima.TabIndex = 2;
            this.cmdQueima.Text = "Queima";
            this.cmdQueima.UseVisualStyleBackColor = true;
            this.cmdQueima.Visible = false;
          
            // 
            // cmdNova
            // 
            this.cmdNova.Location = new System.Drawing.Point(168, 234);
            this.cmdNova.Name = "cmdNova";
            this.cmdNova.Size = new System.Drawing.Size(75, 23);
            this.cmdNova.TabIndex = 3;
            this.cmdNova.Text = "Nova";
            this.cmdNova.UseVisualStyleBackColor = true;
            this.cmdNova.Click += new System.EventHandler(this.cmdNova_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.LampadaApagada;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdNova);
            this.Controls.Add(this.cmdQueima);
            this.Controls.Add(this.cmdApaga);
            this.Controls.Add(this.cmdAcende);
            this.Name = "TelaPrincipal";
            this.Text = "Lampada";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAcende;
        private System.Windows.Forms.Button cmdApaga;
        private System.Windows.Forms.Button cmdQueima;
        private System.Windows.Forms.Button cmdNova;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

