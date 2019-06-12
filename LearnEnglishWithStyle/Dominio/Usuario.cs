using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : Persona
    {
        public string Nivel { get; set; }

        public int Puntaje { get; set; }

        public bool Tipo { get; set; } // 1= Profesor , 0=Alumno 
    }
}
