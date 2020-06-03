using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace pavel
{

    class manejador
    {

        private List<registro> transation = new List<registro>();


        public void agregar(registro trans)
        {
            transation.Add(trans);
        }

        public List<registro> obtener()
        {
            return transation;
        }
    
        public void borrar(int num)
        {
            transation.RemoveAt(num);
        }
        public int total()
        {
            return transation.Count;
        }
    }
  
    class registro
        {

            private double numTran;
            private string nombre;
            private double monto;
           



        public string Nombre { get => nombre; set => nombre = value; }
        public double Monto { get => monto; set => monto = value; }

      
          public double NumTran
        {


            get
            {

                return numTran;
            }
            set
            {
                
               numTran = value;


             

                 
            }


        }

        
    }
}
