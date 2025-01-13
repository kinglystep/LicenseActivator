using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    public class ActivationManager
    {
        private static ActivationManager instance;
        public static ActivationManager GetInstance()
        {
            if(instance == null)
                instance = new ActivationManager();
            return instance;
        }

        public string GetHardwareId()
        {
            ManagementObjectSearcher mgosch =
               new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject mgo in mgosch.Get())
            {
                string hardwareID = mgo["ProcessorID"].ToString();
                return hardwareID;
            }
            return "hardware_id";
        }
    }
}
