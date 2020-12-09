using BeesData.SharedData.Enums;
using BeesData.SharedData.ModelInterfaces;
using System;

namespace BeesData.ClientData.Models
{
    public class Hive : BaseModel<IHive>, IHive
    {
        private string _hiveType = "Langstroth";
        public eHiveType HiveType
        {
            get
            {
                return (eHiveType)Enum.Parse(typeof(eHiveType), _hiveType);
            }

            set => _hiveType = Enum.GetName(typeof(eHiveType), value);
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
