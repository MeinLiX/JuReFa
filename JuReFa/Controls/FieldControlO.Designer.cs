namespace JuReFa.Controls
{
    partial class FieldControlO
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelO
            // 
            this.labelO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.ForeColor = System.Drawing.Color.White;
            this.labelO.Location = new System.Drawing.Point(6, 5);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(55, 55);
            this.labelO.TabIndex = 0;
            this.labelO.Text = "0";
            this.labelO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FieldControlO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(0,0,0);
            this.Controls.Add(this.labelO);
            this.Name = "FieldControlO";
            this.Size = new System.Drawing.Size(Width, Height);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelO;
    }
}
