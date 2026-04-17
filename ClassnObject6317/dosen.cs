using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassnObject6317
{
    internal class dosen
    {
        //atribut

        public string nik { get; set; }
        public string nama { get; set; }

        //
        public void Mengajar ()
        {
            Console.WriteLine("{0} mengajar kalkulus", nama);
        }
        public void Menulis ()
        {
            Console.Write("{0} menulis riset", nama);
        }
    
    
    }
    
}
