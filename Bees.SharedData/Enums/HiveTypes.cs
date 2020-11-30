using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bees.SharedData.Enums
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
