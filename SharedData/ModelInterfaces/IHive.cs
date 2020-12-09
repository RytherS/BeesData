using BeesData.SharedData.Enums;
using BeesData.SharedData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesData.SharedData.ModelInterfaces
{
    public interface IHive : IBaseModelInterface<IHive>
    {
        eHiveType HiveType { get; set; }
    }
}
