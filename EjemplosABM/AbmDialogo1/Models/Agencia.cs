using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbmDialogo1.Models
{
    class Agencia
    {
        List<Propietario> usuarios = new List<Propietario>();

        public Propietario BuscarPorID(int dni)
        {
           foreach(Propietario usr in usuarios)
           {
               if(usr.DNI==dni)
                   return usr;
           }
               
           return null;
        }


        public Propietario AgregarUsuario(int DNI, string nombre, int edad)
        {
            Propietario us = new Propietario(DNI, nombre, edad);

            usuarios.Sort(new Propietario.DNIComparer());
            int idx=usuarios.BinarySearch(us, new Propietario.DNIComparer());

            if (idx >= 0)
            {
                throw new Exception("El DNI ya existe en el sistema!.");
            }
            else
            {
                usuarios.Add(us);
            }

            return us;
        }

        public List<Propietario> BuscarTodos()
        {
            return usuarios;
        }

        public List<Propietario> BuscarTodosAlternativa(Int32 dni, string nombre)
        {
            //metodo no recomendado - pero válido.
            //
            return usuarios.Where(
                         /*ver que la regla de comparación es la misma a la usada en la tradicional*/
                 usr => (usr.Nombre == nombre || nombre == null || nombre == "")
                        && (usr.DNI == dni || dni == 0)
                ).ToList<Propietario>();
        }

        public List<Propietario> BuscarTodos(Int32 dni, string nombre)
        {
            //usando expresiones regulares.
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
            //
            string expresion =  nombre ;
            System.Text.RegularExpressions.Regex regx = new System.Text.RegularExpressions.Regex(expresion);
                       
            //%tato%

            List<Propietario> filtrado = new List<Propietario>();

            foreach(Propietario usr in usuarios)
            {
              //  if ((usr.Nombre == nombre || nombre == null || nombre == "")
              //        && (usr.DNI == dni || dni == 0)   )
                if (regx.IsMatch(usr.Nombre) && (usr.DNI == dni || dni == 0) )
                {
                    filtrado.Add(usr);
                }
            }
            return filtrado;
        }
    }
}
