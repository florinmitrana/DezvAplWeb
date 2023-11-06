using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Curs
    {
        public String numeCurs {  get; set; }
        public String numeProfesor {  get; set; }

        public Curs(String numeCurs, String numeProfesor) {
        this.numeCurs = numeCurs;
        this.numeProfesor = numeProfesor;

        }
    }
}
