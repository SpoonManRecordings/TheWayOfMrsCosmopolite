namespace TheWayOfMrsCosmopolite
{
    partial class cosmopoliteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cosmopoliteForm));
            this.cosmopoliteText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cosmopoliteText
            // 
            this.cosmopoliteText.BackColor = System.Drawing.Color.FloralWhite;
            this.cosmopoliteText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cosmopoliteText.Enabled = false;
            this.cosmopoliteText.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosmopoliteText.Location = new System.Drawing.Point(0, 0);
            this.cosmopoliteText.Multiline = true;
            this.cosmopoliteText.Name = "cosmopoliteText";
            this.cosmopoliteText.ReadOnly = true;
            this.cosmopoliteText.Size = new System.Drawing.Size(284, 261);
            this.cosmopoliteText.TabIndex = 0;
            this.cosmopoliteText.MouseHover += new System.EventHandler(this.cosmopoliteForm_Load);
            // 
            // cosmopoliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cosmopoliteText);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cosmopoliteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Way of Mrs Cosmopolite";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.cosmopoliteForm_HelpButtonClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cosmopoliteForm_FormClosed);
            this.Load += new System.EventHandler(this.cosmopoliteForm_Load);
            this.Click += new System.EventHandler(this.cosmopoliteForm_Click);
            this.DoubleClick += new System.EventHandler(this.cosmopoliteForm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cosmopoliteText;
    }
}

