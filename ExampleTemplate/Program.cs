using MyCompany.MODULENAME.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MODULENAME
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPlaceHolderReplacements();

            ShowGuidReplacements();
        }

        private static void ShowPlaceHolderReplacements()
        {
            var url = "http://localhost:99999/index.html";
            var service = new MyMODULENAMEService(url);
            service.ProcessSomething();
        }

        private static void ShowGuidReplacements()
        {
            // CREATES A NEW GUID FOR EACH OCCURENCY
            var new_guid_01 = "00000000-1111-0000-1111-000000000000"; // 00000000 - 1111 - 0000 - 1111 - 000000000000
            var new_guid_02 = "00000000-1111-0000-1111-000000000000"; // 00000000 - 1111 - 0000 - 1111 - 000000000000

            // CREATES THE SAME GUID FOR EACH OCCURENCY            
            var cached_guid_01_01 = "00000000-1111-0000-1111-000000000001"; // 00000000 - 1111 - 0000 - 1111 - 000000000001
            var cached_guid_01_02 = "00000000-1111-0000-1111-000000000001"; // 00000000 - 1111 - 0000 - 1111 - 000000000001
            var cached_guid_01_03 = "00000000-1111-0000-1111-000000000001"; // 00000000 - 1111 - 0000 - 1111 - 000000000001
            
            var cached_guid_02_01 = "00000000-1111-0000-1111-000000000002"; // 00000000 - 1111 - 0000 - 1111 - 000000000002
            var cached_guid_02_02 = "00000000-1111-0000-1111-000000000002"; // 00000000 - 1111 - 0000 - 1111 - 000000000002
            var cached_guid_02_03 = "00000000-1111-0000-1111-000000000002"; // 00000000 - 1111 - 0000 - 1111 - 000000000002
        }
    }
}
