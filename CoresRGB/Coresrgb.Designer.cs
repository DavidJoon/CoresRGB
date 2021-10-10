
namespace CoresRGB
{
    partial class Coresrgb
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelNumRed = new System.Windows.Forms.Label();
            this.labelNumGreen = new System.Windows.Forms.Label();
            this.labelNumBlue = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.labelPainel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(249, 36);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(309, 49);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Paleta de Cores";
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRed.Location = new System.Drawing.Point(158, 114);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(60, 25);
            this.labelRed.TabIndex = 1;
            // 
            // labelGreen
            // 
            this.labelGreen.BackColor = System.Drawing.Color.Green;
            this.labelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGreen.Location = new System.Drawing.Point(158, 148);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(60, 25);
            this.labelGreen.TabIndex = 2;
            // 
            // labelBlue
            // 
            this.labelBlue.BackColor = System.Drawing.Color.Blue;
            this.labelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBlue.Location = new System.Drawing.Point(158, 182);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(60, 25);
            this.labelBlue.TabIndex = 3;
            // 
            // labelNumRed
            // 
            this.labelNumRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumRed.Location = new System.Drawing.Point(249, 114);
            this.labelNumRed.Name = "labelNumRed";
            this.labelNumRed.Size = new System.Drawing.Size(50, 25);
            this.labelNumRed.TabIndex = 4;
            this.labelNumRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumGreen
            // 
            this.labelNumGreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumGreen.Location = new System.Drawing.Point(249, 148);
            this.labelNumGreen.Name = "labelNumGreen";
            this.labelNumGreen.Size = new System.Drawing.Size(50, 25);
            this.labelNumGreen.TabIndex = 5;
            this.labelNumGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumBlue
            // 
            this.labelNumBlue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumBlue.Location = new System.Drawing.Point(249, 182);
            this.labelNumBlue.Name = "labelNumBlue";
            this.labelNumBlue.Size = new System.Drawing.Size(50, 25);
            this.labelNumBlue.TabIndex = 6;
            this.labelNumBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(327, 114);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Minimum = 1;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(231, 25);
            this.hScrollBarRed.TabIndex = 7;
            this.hScrollBarRed.Value = 1;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(327, 148);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Minimum = 1;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(231, 25);
            this.hScrollBarGreen.TabIndex = 8;
            this.hScrollBarGreen.Value = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(327, 182);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Minimum = 1;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(231, 24);
            this.hScrollBarBlue.TabIndex = 9;
            this.hScrollBarBlue.Value = 1;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // labelPainel
            // 
            this.labelPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPainel.Location = new System.Drawing.Point(158, 237);
            this.labelPainel.Name = "labelPainel";
            this.labelPainel.Size = new System.Drawing.Size(400, 52);
            this.labelPainel.TabIndex = 10;
            // 
            // Coresrgb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPainel);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.labelNumBlue);
            this.Controls.Add(this.labelNumGreen);
            this.Controls.Add(this.labelNumRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coresrgb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores RGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelNumRed;
        private System.Windows.Forms.Label labelNumGreen;
        private System.Windows.Forms.Label labelNumBlue;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label labelPainel;
    }
}

