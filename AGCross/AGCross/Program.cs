/////UNIVERSIDAD AUTÓNOMA DEL ESTADO DE MÉXICO/////
/////CENTRO UNIVERSITARIO UAEM ZUMPANGO//////
//------INGENIERÍA EN COMPUTACIÓN-------//
//------UA: ALGORITMOS GENETICOS 2018A-----//
//******ALUMNO: JESÚS RODOLFO RODRÍGUEZ BARRERA*******//
//******PROFESOR: ASDRÚBAL LÓPEZ CHAU*********//
//------FECHA: 21/MARZO/2018
/*DESCRIPCION: EL PROGRAMA A REALIZAR IMPLEMENTA EN C#
LA OPERACION DE CRUZA POR UN PUNTO VISTA EN CLASES.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGCross
{
    class Program
    {
        public static void Main(string[] args)
        {
            Individuo individuo = new Individuo(7); //Se declara el objeto del primer individuo 
            
            Console.WriteLine(individuo + "\n"); //Imprime en consola los datos del primer individuo
            Individuo[] hijos = individuo.Cross(new Individuo(7));
            for (int j = 0 ;j < 2; j++) {
                Console.WriteLine("\n" + hijos[j]);        
            }
            Console.ReadLine();
            Console.WriteLine("");

            for (int i = 0; true;) { } // Se utiliza para pausar la consola y que no se cierre
        }
    }
}
