using BeesData.SharedData.Enums;
using BeesData.SharedData.ModelInterfaces;
using System;

namespace BeesData.ClientData.Models
{
    public class Hive : BaseModel<IHive>, IHive
    {
        public eHiveType HiveType { get; set; } = eHiveType.Warre;

        public override bool Validate()
        {
            return true;
        }
    }
}
