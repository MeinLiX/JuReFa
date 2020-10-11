namespace JuReFa
{
    partial class MainForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.trackBarFontSize = new System.Windows.Forms.TrackBar();
            this.trackBarSpaceSize = new System.Windows.Forms.TrackBar();
            this.trackBarFieldSize = new System.Windows.Forms.TrackBar();
            this.trackBarFieldCount = new System.Windows.Forms.TrackBar();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.labelFieldCount = new System.Windows.Forms.Label();
            this.labelFieldSize = new System.Windows.Forms.Label();
            this.labelSpaceSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpaceSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldCount)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(7, 227);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(410, 43);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // trackBarFontSize
            // 
            this.trackBarFontSize.AutoSize = false;
            this.trackBarFontSize.Location = new System.Drawing.Point(237, 29);
            this.trackBarFontSize.Name = "trackBarFontSize";
            this.trackBarFontSize.Size = new System.Drawing.Size(185, 31);
            this.trackBarFontSize.TabIndex = 1;
            this.trackBarFontSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFontSize.ValueChanged += new System.EventHandler(this.TrackBarFontSize_ValueChanged);
            // 
            // trackBarSpaceSize
            // 
            this.trackBarSpaceSize.AutoSize = false;
            this.trackBarSpaceSize.Location = new System.Drawing.Point(237, 183);
            this.trackBarSpaceSize.Name = "trackBarSpaceSize";
            this.trackBarSpaceSize.Size = new System.Drawing.Size(185, 33);
            this.trackBarSpaceSize.TabIndex = 2;
            this.trackBarSpaceSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSpaceSize.ValueChanged += new System.EventHandler(this.TrackBarSpaceSize_ValueChanged);
            // 
            // trackBarFieldSize
            // 
            this.trackBarFieldSize.AutoSize = false;
            this.trackBarFieldSize.Location = new System.Drawing.Point(237, 133);
            this.trackBarFieldSize.Name = "trackBarFieldSize";
            this.trackBarFieldSize.Size = new System.Drawing.Size(185, 31);
            this.trackBarFieldSize.TabIndex = 3;
            this.trackBarFieldSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFieldSize.ValueChanged += new System.EventHandler(this.TrackBarFieldSize_ValueChanged);
            // 
            // trackBarFieldCount
            // 
            this.trackBarFieldCount.AutoSize = false;
            this.trackBarFieldCount.Location = new System.Drawing.Point(237, 82);
            this.trackBarFieldCount.Name = "trackBarFieldCount";
            this.trackBarFieldCount.Size = new System.Drawing.Size(185, 31);
            this.trackBarFieldCount.TabIndex = 4;
            this.trackBarFieldCount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFieldCount.ValueChanged += new System.EventHandler(this.TrackBarFieldCount_ValueChanged);
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(361, 12);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(51, 13);
            this.labelFontSize.TabIndex = 5;
            this.labelFontSize.Text = "FontSize:";
            // 
            // labelFieldCount
            // 
            this.labelFieldCount.AutoSize = true;
            this.labelFieldCount.Location = new System.Drawing.Point(352, 63);
            this.labelFieldCount.Name = "labelFieldCount";
            this.labelFieldCount.Size = new System.Drawing.Size(60, 13);
            this.labelFieldCount.TabIndex = 6;
            this.labelFieldCount.Text = "FieldCount:";
            // 
            // labelFieldSize
            // 
            this.labelFieldSize.AutoSize = true;
            this.labelFieldSize.Location = new System.Drawing.Point(360, 116);
            this.labelFieldSize.Name = "labelFieldSize";
            this.labelFieldSize.Size = new System.Drawing.Size(52, 13);
            this.labelFieldSize.TabIndex = 7;
            this.labelFieldSize.Text = "FieldSize:";
            // 
            // labelSpaceSize
            // 
            this.labelSpaceSize.AutoSize = true;
            this.labelSpaceSize.Location = new System.Drawing.Point(351, 167);
            this.labelSpaceSize.Name = "labelSpaceSize";
            this.labelSpaceSize.Size = new System.Drawing.Size(61, 13);
            this.labelSpaceSize.TabIndex = 8;
            this.labelSpaceSize.Text = "SpaceSize:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 277);
            this.Controls.Add(this.labelSpaceSize);
            this.Controls.Add(this.labelFieldSize);
            this.Controls.Add(this.labelFieldCount);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.trackBarFieldCount);
            this.Controls.Add(this.trackBarFieldSize);
            this.Controls.Add(this.trackBarSpaceSize);
            this.Controls.Add(this.trackBarFontSize);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "JuReFa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpaceSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TrackBar trackBarSpaceSize;
        private System.Windows.Forms.TrackBar trackBarFieldSize;
        private System.Windows.Forms.TrackBar trackBarFieldCount;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label labelFieldCount;
        private System.Windows.Forms.Label labelFieldSize;
        private System.Windows.Forms.Label labelSpaceSize;
        private System.Windows.Forms.TrackBar trackBarFontSize;
    }
}

