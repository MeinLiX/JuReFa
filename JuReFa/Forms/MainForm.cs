using JuReFa.Controls;
using JuReFa.Forms;
using JuReFa.Properties;
using JuReFa.Source;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JuReFa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            new TrainingFieldForm().ShowDialog(this);
            stopwatch.Stop();
            this.Visible = true;
            this.Text = $"JuReFa | Time: {stopwatch.Elapsed:%m' min. '%s' sec.'}";
        }

        private void SetTrackBar(int min, int max, int value, params TrackBar[] trackBars)
        {
            foreach (TrackBar TB in trackBars)
            {
                TB.Minimum = min;
                TB.Maximum = max;
                TB.Value = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetTrackBar(min: (int)Enumerations.DefautlSettings.MinFontSize,
                        max: (int)Enumerations.DefautlSettings.MaxFontSize,
                        value: Settings.Default.FontSize,
                        trackBarFontSize);

            SetTrackBar(min: (int)Math.Sqrt((int)Enumerations.DefautlSettings.MinFieldCount),
                        max: (int)Math.Sqrt((int)Enumerations.DefautlSettings.MaxFieldCount),
                        value: (int)Math.Sqrt(Settings.Default.FieldCount),
                        trackBarFieldCount);

            SetTrackBar(min: (int)Enumerations.DefautlSettings.MinFieldSize,
                        max: (int)Enumerations.DefautlSettings.MaxFieldSize,
                        value: Settings.Default.FieldSize,
                        trackBarFieldSize);

            SetTrackBar(min: (int)Enumerations.DefautlSettings.MinSpaceSize,
                        max: (int)Enumerations.DefautlSettings.MaxSpaceSize,
                        value: Settings.Default.SpaceSize,
                        trackBarSpaceSize);

            FieldControlO_Update();
        }

        private void TrackBarFontSize_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["FontSize"] = trackBarFontSize.Value;
            FieldControlO_Update();
        }

        private void TrackBarFieldCount_ValueChanged(object sender, EventArgs e) //FieldCount must be pow(number, 2);
        {
            Settings.Default["FieldCount"] = (int)Math.Pow(trackBarFieldCount.Value, 2);
            groupBoxFieldCount.Text = groupBoxFieldCount.Text.Substring(0, 11) + (int)Math.Pow(trackBarFieldCount.Value, 2);
            FieldControlO_Update();
        }

        private void TrackBarFieldSize_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["FieldSize"] = trackBarFieldSize.Value;
            FieldControlO_Update();
        }

        private void TrackBarSpaceSize_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["SpaceSize"] = trackBarSpaceSize.Value;
            FieldControlO_Update();
        }

        private void FieldControlO_Update()
        {
            Settings.Default.Save();

            FieldControlO FCO_Example = new FieldControlO(bc: IColors.Defautl, num: 0, fieldSize: Settings.Default.FieldSize, letterSize: Settings.Default.FontSize)
            {
                Location = new Point(Settings.Default.SpaceSize, Settings.Default.SpaceSize)
            };
            FCO_Example.Name = "FieldControlONew";

            Controls.Remove(Controls.Find("FieldControlONew", false).FirstOrDefault() as FieldControlO);
            Controls.Add(FCO_Example);
        }
    }
}
