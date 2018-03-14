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
    class IndividuoGray
    {
        Cromosoma cromosoma;
        public IndividuoGray(int num_bits) //Declaracion del individuo Gray 
        {
            cromosoma = new Cromosoma(num_bits); //Declaracion del objeto Cromosoma el cual contiene los metodos a utilizar
            cromosoma.inicializa(); //Se manda a llamar la funcion que inicializara el proceso
        }

        public override string ToString() //Metodo para imprimir los datos que se necesitan
        {
            return string.Format("[Individuo Gray: " + cromosoma.getGeneGray() + "]" + "\t[Valor en Decimal: " + cromosoma.GetValue() + "]");
        }

    }
}
