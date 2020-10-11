using System;
using System.Drawing;
using System.Windows.Forms;
using JuReFa.Source;

namespace JuReFa.Controls
{
    public partial class FieldControlO : UserControl
    {
        public FieldControlO()
        {
            InitializeComponent();
        }

        public FieldControlO(Color bc, int num, int fieldSize = 60, int letterSize = 36) : this()
        {
            CheckNeg(ref num);

            BackColor = bc;

            this.Width = fieldSize;
            this.Height = fieldSize;

            ValidFont(num, ref letterSize);

            labelO.Text = num.ToString();
            labelO.Font = new Font("Arial", letterSize);

            UpdateTextPosition();
        }

        private void UpdateTextPosition() //recenter label position //todo: uncorrect reflection some numbers
        {
            int newW = (int)Math.Ceiling((Width - labelO.Width) / (decimal)Enumerations.Divider.two);
            int newH = (int)Math.Ceiling((Height - labelO.Height) / (decimal)Enumerations.Divider.two);

            labelO.Location = new Point(newW, newH);
        }

        private void ValidFont(int number, ref int letterSize)
        {
            if (number < (int)Enumerations.NumLen.ten)
                letterSize += (int)Enumerations.FontSizeCorrect.L;
            else if (number >= (int)Enumerations.NumLen.hundred &&
                     number < (int)Enumerations.NumLen.thousand)
                letterSize -= (int)Enumerations.FontSizeCorrect.L_M;
            else if (number >= (int)Enumerations.NumLen.thousand)
                letterSize -= (int)Enumerations.FontSizeCorrect.M;

            if (CheckNeg(ref letterSize) || letterSize * 1.2 > Width)
            {
                letterSize = Width / (int)Enumerations.Divider.two;
            }
        }

        private bool CheckNeg(ref int testedNum, int minValue = (int)Enumerations.NumLen.zero, int defaultValue = (int)Enumerations.NumLen.zero)
        {
            if (testedNum < minValue)
            {
                testedNum = defaultValue;
                return true;
            }
            return false;
        }
    }
}
