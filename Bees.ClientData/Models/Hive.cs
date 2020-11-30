using Bees.SharedData.Enums;
using Bees.SharedData.ModelInterfaces;
using System;

namespace Bees.ClientData.Models
{
    public class Hive : IHive
    {
        public eHiveType HiveType { get => eHiveType.Warre; set => throw new NotImplementedException(); }

        public bool Validate()
        {
            return true;
        }
    }
}
