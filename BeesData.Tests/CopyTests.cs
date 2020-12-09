using ClientModels = BeesData.ClientData.Models;
using ServerModels = BeesData.ServerData.Models;
using BeesData.SharedData.Enums;
using BeesData.SharedData.ModelInterfaces;
using NUnit.Framework;
using System;

namespace BeesData.Tests
{
    public class CopyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static bool CopiedCorrectly<TModelInterface>(TModelInterface A, TModelInterface B)
        {
            var props = typeof(TModelInterface).GetProperties();
            foreach (var prop in props)
            {
                if (!prop.GetValue(A).Equals(prop.GetValue(B)))
                {
                    return false;
                }
            }

            return true;
        }

        [Test]
        public void HiveCopy()
        {
            //Client to Server
            IHive clientHive = new ClientModels.Hive() 
            { 
                HiveType = eHiveType.Langstroth 
            };

            IHive serverHive = new ServerModels.Hive();
            serverHive.CopyFrom(clientHive);

            Assert.IsTrue(CopiedCorrectly(clientHive, serverHive));

            //Server to Client
            serverHive = new ServerModels.Hive()
            {
                HiveType = eHiveType.TopBar
            };
            clientHive.CopyFrom(serverHive);

            Assert.IsTrue(CopiedCorrectly(clientHive, serverHive));
        }
    }
}