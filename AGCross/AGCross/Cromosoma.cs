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
    public class Cromosoma
    {
        private int BITS_PER_GENE; /*Declaracion de la variable entera 
        la cual sera el numero de bits que tendra el gen*/
        private int[] gene; //Declaracion del arreglo gene

        // Declaracion de la funcion que recibira el numero de bits que tendra el gen
        public Cromosoma(int bits)
        {
            BITS_PER_GENE = bits; //Se pasa a la variable local
            gene = new int[BITS_PER_GENE];
        }

        public int[] getGene() /*Metodo get para poder usar el gen en otra clase*/
        {
            return gene;
        }

        public int getBits_Per_Gene() /*Metodo get para poder usar los Bits de cada gen en otra clase*/
        {
            return BITS_PER_GENE;
        }

        public double GetValue() /*Con esta funcion se devuelve 
            el valor decimal del gen*/
        {
            double value = 0;
            for (int i = 0; i < BITS_PER_GENE - 1; i++) /*Se recorre el tamaño 
                de los bits que tiene el gen*/
            {
                value += gene[BITS_PER_GENE - i - 1] * Math.Pow(2.0, i); /*Se eleva a la potencia correspondiente 
                cada uno de los valores del gen*/
            }
            if (gene[0] == 1) //Se realiza una condicional para saber que valor regresar 
            {
                value = -value;
            }
            return value; //Retorna el valor de gen en decimal

        }

        public void inicializa(Random random) //Con esta funcion se llena el gen con numeros aleatorios
        {
            //Random random = new Random();
            int n;
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                n = random.Next(1, 3); //Se guarda temporalmente el numero generado
                if (n == 2) //Si es uno se agrega al gen en la posicion de i 
                {
                    gene[i] = 1;
                }
            }
        }
    }
}
