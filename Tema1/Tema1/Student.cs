using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Student
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta { get; set; }
        public List<Curs> cursuri { get; set; }

        public Student(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.cursuri = new List<Curs>();

        }

        public void addCurs(Curs curs)
        {
            cursuri.Add(curs);
        }

        public void afiseazaDetalii()
        {
            Console.WriteLine($"Date despre studentul");
            Console.WriteLine($"Nume: {this.nume}");
            Console.WriteLine($"Prenume: {this.prenume}");
            Console.WriteLine($"Varsta: {this.varsta}");
            Console.WriteLine("Materii");
            foreach (Curs curs in cursuri)
            {
                Console.WriteLine($"Nume curs: {curs.numeCurs}, Nume profesor: {curs.numeProfesor}");
            }
            Console.WriteLine();
        }
    }
}
