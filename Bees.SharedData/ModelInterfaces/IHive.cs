using Bees.SharedData.Enums;
using Bees.SharedData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bees.SharedData.ModelInterfaces
{
    public interface IHive : IValidatable
    {
        eHiveType HiveType { get; set; }
    }
}
