using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAbmDialogo3
{
    public class Propietario 
    {        
        public class DNIComparer : IComparer<Propietario>
        {
            public int Compare(Propietario obj1, Propietario obj2){
                return obj1.DNI.CompareTo(obj2.DNI);
            }
        }

        public class NombreComparer : IComparer<Propietario>
        {
            public int Compare(Propietario obj1, Propietario obj2){
                return obj1.Nombre.CompareTo(obj2.Nombre) == 0 ? 
                        obj1.Edad.CompareTo(obj2.Edad) : obj1.Nombre.CompareTo(obj2.Nombre);
            }
        }
      
        public string Nombre { get; set; }
        public int DNI { get; set;  }

        public int Edad {   get; set; }

        public Propietario(int dni, string nombre, int edad)
        {
            DNI = dni;
            Nombre = nombre;
            Edad = edad;
        }

    }
}


