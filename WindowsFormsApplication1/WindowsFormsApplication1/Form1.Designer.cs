namespace WindowsFormsApplication1
{
    partial class frmSkaro
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
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnSkaro = new System.Windows.Forms.Button();
            this.btnDavros = new System.Windows.Forms.Button();
            this.btnEarth = new System.Windows.Forms.Button();
            this.btnGalifrey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // picSetting
            // 
            this.picSetting.Location = new System.Drawing.Point(12, 12);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(260, 86);
            this.picSetting.TabIndex = 0;
            this.picSetting.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(116, 101);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // btnSkaro
            // 
            this.btnSkaro.Location = new System.Drawing.Point(12, 129);
            this.btnSkaro.Name = "btnSkaro";
            this.btnSkaro.Size = new System.Drawing.Size(102, 60);
            this.btnSkaro.TabIndex = 2;
            this.btnSkaro.Text = "button1";
            this.btnSkaro.UseVisualStyleBackColor = true;
            this.btnSkaro.Click += new System.EventHandler(this.btnSkaro_Click);
            // 
            // btnDavros
            // 
            this.btnDavros.Location = new System.Drawing.Point(12, 195);
            this.btnDavros.Name = "btnDavros";
            this.btnDavros.Size = new System.Drawing.Size(102, 55);
            this.btnDavros.TabIndex = 3;
            this.btnDavros.Text = "button2";
            this.btnDavros.UseVisualStyleBackColor = true;
            this.btnDavros.Click += new System.EventHandler(this.btnDavros_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(150, 129);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(106, 60);
            this.btnEarth.TabIndex = 4;
            this.btnEarth.Text = "button3";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // btnGalifrey
            // 
            this.btnGalifrey.Location = new System.Drawing.Point(150, 195);
            this.btnGalifrey.Name = "btnGalifrey";
            this.btnGalifrey.Size = new System.Drawing.Size(106, 55);
            this.btnGalifrey.TabIndex = 5;
            this.btnGalifrey.Text = "button4";
            this.btnGalifrey.UseVisualStyleBackColor = true;
            this.btnGalifrey.Click += new System.EventHandler(this.btnGalifrey_Click);
            // 
            // frmSkaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGalifrey);
            this.Controls.Add(this.btnEarth);
            this.Controls.Add(this.btnDavros);
            this.Controls.Add(this.btnSkaro);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picSetting);
            this.Name = "frmSkaro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSkaro;
        private System.Windows.Forms.Button btnDavros;
        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.Button btnGalifrey;
    }
}

