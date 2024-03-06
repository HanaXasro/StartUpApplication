using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace Application.Services
{
    public class PesonalInfo
    {


        public object Response { get; set; }

        public PesonalInfo()
        {

            // Name Users in folder local C:\Users\
            var ArrayUsername = WindowsIdentity.GetCurrent().Name;
            if (ArrayUsername!=null)
            {
                string[] user = ArrayUsername.Split("\\");
                string userName = user[1]; // or host name GetHostName()
                Response = new
                {
                    IpAddressV4 = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1)!.ToString()!,
                    userName = userName,
                    password = BC.HashPassword("1234")
                };
            }
        }
    }
}
