namespace JuReFa.Source
{
    static internal class Enumerations
    {
        public enum FieldCount
        {               //GAME MODE
            E = 4,      //easy
            E_M = 9,    //easy-medium
            M = 16,     //medium
            M_H = 25,   //medium-hard
            H = 36,     //hard
            H_U = 49,   //HARD Unreal 
            U = 64      //UNREAL
        }
        public enum NumLen
        {
            zero = 0,
            ten = 10,
            hundred = 100,
            thousand = 1000
        }
        public enum Divider // :)
        {
            two = 2
        }
         public enum FontSizeCorrect
        {
            L = 6,      //Little
            L_M = 12,   //Little-medium
            M = 18     //Medium
        }
        public enum DefautlSettings
        {
            MinFontSize=1,
            MaxFontSize=165,
            MinFieldCount=4,
            MaxFieldCount = 64,
            MinFieldSize=4,
            MaxFieldSize = 210,
            MinSpaceSize=0,
            MaxSpaceSize = 10,
        }
    }
}
