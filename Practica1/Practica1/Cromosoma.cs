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

        public double GetValue() /*Con esta funcion se devuelve 
            el valor decimal del gen*/
        {
            double value = 0;
            for (int i = 0; i < BITS_PER_GENE - 1; i++ ) /*Se recorre el tamaño 
                de los bits que tiene el gen*/
            {
                value += gene[BITS_PER_GENE-i-1] * Math.Pow(2.0,i); /*Se eleva a la potencia correspondiente 
                cada uno de los valores del gen*/
            }
            if (gene[0] == 1) //Se realiza una condicional para saber que valor regresar 
            {
                value = -value;
            }
            return value; //Retorna el valor de gen en decimal

        }

        public void inicializa() //Con esta funcion se llena el gen con numeros aleatorios
        {
            Random random = new Random();
            int n;
            for (int i=0; i<BITS_PER_GENE; i++ ) {
                n = random.Next(0, 2); //Se guarda temporalmente el numero generado
                if (n==1) //Si es uno se agrega al gen en la posicion de i 
                {
                    gene[i]=1;
                }
            }
        }

        public string getGene() //Regresa el valor del gen
        {
            string genotipo = ""; /*Se declara una cadena donde se guardara el gen*/
            for (int i =0; i<BITS_PER_GENE; i++) /*Se recorre todo el arreglo del gen */
            {
                genotipo += gene[i].ToString(); /*Se agregan los valores del gen*/
            }
            return genotipo; //Regresa la cadane con el valor del gen
        }

        public string getGeneGray()
        {
            string genotipogray = ""; //Se declara una cadena donde se guardara el codigo gray
            genotipogray = gene[0].ToString(); //Se agrega el primer bit igual debido a que solo indica el signo
            genotipogray += gene[1].ToString();//Debido al algortimo el bit mas significativo se agrega igual
            for (int i = 1; i < BITS_PER_GENE-1; i++)//Recorre todo el arreglo del gen
            {
                if (gene[i] != gene[i+1]) /*El algoritmo dice que se aplique una XOR al bit y un bit 
                    posterior si el resultado es verdadero se agrega 1 al codigo gray*/
                    genotipogray += 1;
                else//sino se cumple la condicion entonces se  agrega un cero
                    genotipogray += 0;             
            }
            return genotipogray;  //Retorna la cadena en Gray 
        }
    }
}
