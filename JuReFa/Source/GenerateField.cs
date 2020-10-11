using JuReFa.Forms;
using JuReFa.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace JuReFa.Source
{
    static internal class GenerateField
    {
        public static Enumerations.FieldCount FieldCount { get; set; }
        public static int FieldSize { get; set; }
        public static int SpaceSize { get; set; }
        public static int LetterSize { get; set; }

        internal static void UpdateSettings()
        {
            LetterSize = Settings.Default.FontSize;
            SpaceSize = Settings.Default.SpaceSize;
            FieldSize = Settings.Default.FieldSize;
            FieldCount = (Enumerations.FieldCount)Settings.Default.FieldCount;
        }

        static GenerateField()
        {
            UpdateSettings();
        }

        private static Task ISwapList(List<(int number, Color color)> list)
        {
            Random rand = new Random(Seed: (FieldSize | (SpaceSize & LetterSize) ^ (int)FieldCount) * new Random().Next());

            for (int i = 1; i <= (int)FieldCount; i++)
                for (int j = 1; j <= (int)FieldCount; j++)
                {
                    int rri = (rand.Next() & (i + j) ^ (j * i)) % list.Count(); //right random index
                    int lri = (i == 1) ? j % list.Count() : (rand.Next() & (i + j) ^ (j * i)) % list.Count(); //left random index

                    (int number, Color color) temp = list[lri];
                    list[lri] = list[rri];
                    list[rri] = temp;
                }
            return Task.CompletedTask;
        }

        internal static async void InitializationField(List<Controls.FieldControlO> LFLO)
        {
            List<(int number, Color color)> fields = new List<(int number, Color color)>();
            for (int i = 0; i < (int)Math.Ceiling((decimal)FieldCount / (decimal)Enumerations.Divider.two); i++)
                for (int c = 0; c < 2; c++)
                    fields.Add((number: i + 1, color: (c == 0) ? IColors.Pink : IColors.Gray));

            await ISwapList(list: fields);

            int itter = 0;
            for (int h = 0; h < Math.Sqrt((double)FieldCount); h++) //set location
                for (int w = 0; w < Math.Sqrt((double)FieldCount); w++)
                {
                    LFLO.Add(new Controls.FieldControlO(fields[itter].color, fields[itter].number, FieldSize, LetterSize)
                    {
                        Location = GetPosElement(w, h)
                    });
                    ++itter;
                }
        }
        internal static IWindowSize GetWindowSize()
        {
            int fieldCounInLine = (int)Math.Sqrt((double)FieldCount);
            int spaceTotalSize = SpaceSize * fieldCounInLine + SpaceSize;
            int fieldTotalSize = FieldSize * fieldCounInLine;

            return new IWindowSize(spaceTotalSize + fieldTotalSize, spaceTotalSize + fieldTotalSize);
        }

        private static Point GetPosElement(int wCount, int hCount) => new Point(wCount * FieldSize + SpaceSize * wCount + SpaceSize, hCount * FieldSize + SpaceSize * hCount + SpaceSize);

    }
}
