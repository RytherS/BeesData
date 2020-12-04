using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BeesData.SharedData.Enums
{
    public enum eHiveType
    {
        [Description("Langstroth")]
        Langstroth,
        [Description("Top-Bar")]
        TopBar,
        [Description("Warre")]
        Warre
    }
}
