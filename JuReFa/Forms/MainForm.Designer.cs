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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.trackBarFontSize = new System.Windows.Forms.TrackBar();
            this.trackBarSpaceSize = new System.Windows.Forms.TrackBar();
            this.trackBarFieldSize = new System.Windows.Forms.TrackBar();
            this.trackBarFieldCount = new System.Windows.Forms.TrackBar();
            this.groupBoxFontSize = new System.Windows.Forms.GroupBox();
            this.groupBoxFieldCount = new System.Windows.Forms.GroupBox();
            this.groupBoxFieldSize = new System.Windows.Forms.GroupBox();
            this.groupBoxSpaceSize = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpaceSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldCount)).BeginInit();
            this.groupBoxFontSize.SuspendLayout();
            this.groupBoxFieldCount.SuspendLayout();
            this.groupBoxFieldSize.SuspendLayout();
            this.groupBoxSpaceSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.Location = new System.Drawing.Point(7, 227);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(410, 43);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // trackBarFontSize
            // 
            this.trackBarFontSize.AutoSize = false;
            this.trackBarFontSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarFontSize.Location = new System.Drawing.Point(3, 17);
            this.trackBarFontSize.Name = "trackBarFontSize";
            this.trackBarFontSize.Size = new System.Drawing.Size(169, 20);
            this.trackBarFontSize.TabIndex = 1;
            this.trackBarFontSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFontSize.ValueChanged += new System.EventHandler(this.TrackBarFontSize_ValueChanged);
            // 
            // trackBarSpaceSize
            // 
            this.trackBarSpaceSize.AutoSize = false;
            this.trackBarSpaceSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarSpaceSize.Location = new System.Drawing.Point(3, 16);
            this.trackBarSpaceSize.Name = "trackBarSpaceSize";
            this.trackBarSpaceSize.Size = new System.Drawing.Size(169, 21);
            this.trackBarSpaceSize.TabIndex = 4;
            this.trackBarSpaceSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSpaceSize.ValueChanged += new System.EventHandler(this.TrackBarSpaceSize_ValueChanged);
            // 
            // trackBarFieldSize
            // 
            this.trackBarFieldSize.AutoSize = false;
            this.trackBarFieldSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarFieldSize.Location = new System.Drawing.Point(3, 16);
            this.trackBarFieldSize.Name = "trackBarFieldSize";
            this.trackBarFieldSize.Size = new System.Drawing.Size(169, 21);
            this.trackBarFieldSize.TabIndex = 3;
            this.trackBarFieldSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFieldSize.ValueChanged += new System.EventHandler(this.TrackBarFieldSize_ValueChanged);
            // 
            // trackBarFieldCount
            // 
            this.trackBarFieldCount.AutoSize = false;
            this.trackBarFieldCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarFieldCount.Location = new System.Drawing.Point(3, 16);
            this.trackBarFieldCount.Name = "trackBarFieldCount";
            this.trackBarFieldCount.Size = new System.Drawing.Size(169, 21);
            this.trackBarFieldCount.TabIndex = 2;
            this.trackBarFieldCount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFieldCount.ValueChanged += new System.EventHandler(this.TrackBarFieldCount_ValueChanged);
            // 
            // groupBoxFontSize
            // 
            this.groupBoxFontSize.Controls.Add(this.trackBarFontSize);
            this.groupBoxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFontSize.Location = new System.Drawing.Point(242, 21);
            this.groupBoxFontSize.Name = "groupBoxFontSize";
            this.groupBoxFontSize.Size = new System.Drawing.Size(175, 40);
            this.groupBoxFontSize.TabIndex = 9;
            this.groupBoxFontSize.TabStop = false;
            this.groupBoxFontSize.Text = "FontSize:";
            // 
            // groupBoxFieldCount
            // 
            this.groupBoxFieldCount.Controls.Add(this.trackBarFieldCount);
            this.groupBoxFieldCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFieldCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFieldCount.Location = new System.Drawing.Point(242, 69);
            this.groupBoxFieldCount.Name = "groupBoxFieldCount";
            this.groupBoxFieldCount.Size = new System.Drawing.Size(175, 40);
            this.groupBoxFieldCount.TabIndex = 10;
            this.groupBoxFieldCount.TabStop = false;
            this.groupBoxFieldCount.Text = "FieldCount:";
            // 
            // groupBoxFieldSize
            // 
            this.groupBoxFieldSize.Controls.Add(this.trackBarFieldSize);
            this.groupBoxFieldSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFieldSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFieldSize.Location = new System.Drawing.Point(242, 117);
            this.groupBoxFieldSize.Name = "groupBoxFieldSize";
            this.groupBoxFieldSize.Size = new System.Drawing.Size(175, 40);
            this.groupBoxFieldSize.TabIndex = 11;
            this.groupBoxFieldSize.TabStop = false;
            this.groupBoxFieldSize.Text = "FieldSize:";
            // 
            // groupBoxSpaceSize
            // 
            this.groupBoxSpaceSize.Controls.Add(this.trackBarSpaceSize);
            this.groupBoxSpaceSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSpaceSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpaceSize.Location = new System.Drawing.Point(242, 165);
            this.groupBoxSpaceSize.Name = "groupBoxSpaceSize";
            this.groupBoxSpaceSize.Size = new System.Drawing.Size(175, 40);
            this.groupBoxSpaceSize.TabIndex = 12;
            this.groupBoxSpaceSize.TabStop = false;
            this.groupBoxSpaceSize.Text = "SpaceSize:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 277);
            this.Controls.Add(this.groupBoxSpaceSize);
            this.Controls.Add(this.groupBoxFieldSize);
            this.Controls.Add(this.groupBoxFieldCount);
            this.Controls.Add(this.groupBoxFontSize);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuReFa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpaceSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFieldCount)).EndInit();
            this.groupBoxFontSize.ResumeLayout(false);
            this.groupBoxFieldCount.ResumeLayout(false);
            this.groupBoxFieldSize.ResumeLayout(false);
            this.groupBoxSpaceSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TrackBar trackBarSpaceSize;
        private System.Windows.Forms.TrackBar trackBarFieldSize;
        private System.Windows.Forms.TrackBar trackBarFieldCount;
        private System.Windows.Forms.TrackBar trackBarFontSize;
        private System.Windows.Forms.GroupBox groupBoxFontSize;
        private System.Windows.Forms.GroupBox groupBoxFieldCount;
        private System.Windows.Forms.GroupBox groupBoxFieldSize;
        private System.Windows.Forms.GroupBox groupBoxSpaceSize;
    }
}

