namespace telaSimples
{
    partial class frmPrincipal
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
            this.btnExibe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibe
            // 
            this.btnExibe.Location = new System.Drawing.Point(221, 70);
            this.btnExibe.Name = "btnExibe";
            this.btnExibe.Size = new System.Drawing.Size(100, 24);
            this.btnExibe.TabIndex = 0;
            this.btnExibe.Text = "Clique aqui!!!";
            this.btnExibe.UseVisualStyleBackColor = true;
            this.btnExibe.Click += new System.EventHandler(this.btnExibe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 176);
            this.Controls.Add(this.btnExibe);
            this.Name = "frmPrincipal";
            this.Text = "Meu primeiro programa em C# com o gui";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibe;
    }
}

