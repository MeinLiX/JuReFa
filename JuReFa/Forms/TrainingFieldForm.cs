using JuReFa.Source;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuReFa.Forms
{
    public partial class TrainingFieldForm : Form
    {
        private List<Controls.FieldControlO> ListFieldControlO = new List<Controls.FieldControlO>();

        public TrainingFieldForm()
        {
            InitializeComponent();
            InitializeField();
        }

        private void InitializeField()
        {
            GenerateField.UpdateSettings();
            IWindowSize IWS = GenerateField.GetWindowSize();

            this.Width = IWS.Width;
            this.Height = IWS.Height;
            this.ClientSize = new Size(Width, Height);
            this.Size = new Size(Width, Height);

            GenerateField.InitializationField(ListFieldControlO);

            Controls.Clear();
            foreach (var i in ListFieldControlO)
            {
                Controls.Add(i);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            if (keyData == Keys.Enter)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                int titleHeight = this.RectangleToScreen(this.ClientRectangle).Top - this.Top - 7;
                Cursor.Position = new Point(this.Location.X + this.Width / 2, this.Top + (this.Height + titleHeight) / 2);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
