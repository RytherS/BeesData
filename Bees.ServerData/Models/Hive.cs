using Bees.SharedData.Enums;
using Bees.SharedData.ModelInterfaces;
using System;

namespace Bees.ServerData.Models
{
    public class Hive : IHive
    {
        public eHiveType HiveType { get => eHiveType.Langstroth; set => throw new NotImplementedException(); }

        public bool Validate()
        {
            return false;
        }
    }
}
