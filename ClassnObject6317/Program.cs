using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassnObject6317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dosen dosen1 = new dosen();
            //dosen dosen2 = new dosen();

            // mengisi nilai
            //dosen1.nik = "190302526";
            //dosen1.nama = "Novi";

            //dosen1.Mengajar();
            //dosen1.Menulis();

            //dosen2.nik = "190302526";
            //dosen2.nama = "Nova";

            //dosen2.Mengajar();
            //dosen2.Menulis();

            mahasiswa mahasiswa1 = new mahasiswa();
            mahasiswa mahasiswa2 = new mahasiswa();

            mahasiswa1.nama = "Danu";
            mahasiswa1.nim = "25.11.6317";
            mahasiswa1.ipk = 4;

            mahasiswa2.nama = "Danu";
            mahasiswa2.nim = "25.11.6317";
            mahasiswa2.ipk = 4;

            mahasiswa1.Registrasi();
            mahasiswa2.Registrasi();

            mahasiswa1.isiKrs();
            mahasiswa2.isiKrs();

        }
    }
}
