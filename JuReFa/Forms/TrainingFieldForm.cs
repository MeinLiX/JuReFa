using JuReFa.Source;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JuReFa.Forms
{
    public partial class TrainingFieldForm : Form
    {
        private List<Controls.FieldControlO> ListFieldControlO = new List<Controls.FieldControlO>();

        public TrainingFieldForm()
        {
            InitializeField();
            InitializeComponent();
        }

        private void InitializeField()
        {
            GenerateField.UpdateSettings();
            IWindowSize IWS = GenerateField.GetWindowSize();
            this.Width = IWS.Width;
            this.Height = IWS.Height;

            GenerateField.InitializationField(ListFieldControlO);

            Controls.Clear();
            foreach (var i in ListFieldControlO)
            {
                Controls.Add(i);
            }
        }
    }
}
