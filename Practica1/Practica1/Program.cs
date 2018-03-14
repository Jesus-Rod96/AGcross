/////UNIVERSIDAD AUTÓNOMA DEL ESTADO DE MÉXICO/////
/////CENTRO UNIVERSITARIO UAEM ZUMPANGO//////
//------INGENIERÍA EN COMPUTACIÓN-------//
//------UA: ALGORITMOS GENETICOS 2018A-----//
//******ALUMNO: JESÚS RODOLFO RODRÍGUEZ BARRERA*******//
//******PROFESOR: ASDRÚBAL LÓPEZ CHAU*********//
//------FECHA: 16/FEBRERO/2018
/*DESCRIPCION: EL PROGRAMA A REALIZAR IMPLEMENTA LA
 REPRESENTACION ENTERA USANDO CODIGO GRAY. EL LENGUAJE UTILIZADO ES C#*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        public static void Main(string[] args) /*Metodo principal en el cual se declaran
            los objetos necesarios a usar junto con los metodos a utilizar*/ 
        {
            Individuo individuo = new Individuo(7); //Se declara el objeto del primer individuo 
            IndividuoGray indGray = new IndividuoGray(7); //Se declara el objeto del segundo individuo Gray

            Console.WriteLine("Hello World"); //Imprime en consola un mensaje 
            Console.WriteLine(individuo.ToString()); //Imprime en consola los datos del primer individuo
            Console.WriteLine(indGray.ToString()); //Imprime en consola los datos del individuo Gray

            for (int i = 0; true;) { } // Se utiliza para pausar la consola y que no se cierre
        }
    }
}
