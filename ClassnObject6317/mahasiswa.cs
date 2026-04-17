using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassnObject6317
{
    internal class mahasiswa
    {
        //properties
        public string nim { get; set; }
        public string nama { get; set; }
        public float ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("nama : {0}", nama);
            Console.WriteLine("NIM : {0}", nim);
            Console.WriteLine("IPK : {0}", ipk);
            Console.WriteLine("\nTelah melakukan registrasi : {0}");
        }

        public void isiKrs()
        {
            Console.WriteLine("{0} Sedang melakukan proses Krs");
        }
    }

}
