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
    public class Individuo
    {
        Cromosoma cromosoma;
        public Individuo(int num_bits) //Declaracion del primer individuo 
        {
            cromosoma = new Cromosoma(num_bits); //Declaracion del objeto Cromosoma el cual contiene los metodos a utilizar
            cromosoma.inicializa(new Random(Guid.NewGuid().GetHashCode())); //Se manda a llamar la funcion que inicializara el proceso
        }

        public override string ToString() //Metodo para imprimir los datos que se necesitan
        {
            
            string cadena = ""; //Se declara la cadena que contendra los datos que necesitamos
            cadena = "Arreglos: ";    
            for (int i = 0; i < cromosoma.getBits_Per_Gene(); i++) //Se recorre cada uno de los bits del gene 
                //cadena += "";
                cadena += cromosoma.getGene()[i] + " "; //Se concatena cada elemento del gen al resultado para hacer la comparacion con su fenotipo
                cadena += "\tValor decimal: " + cromosoma.GetValue(); //Se concatena el fenotipo interpretado en decimal             
                return cadena;
                //return string.Format("F1: [" + cromosoma.getGene() + "] " + "\tValor en Decimal: [" + cromosoma.GetValue() + "]\n");
        }

        public Individuo[] Cross(Individuo madre)
        {
            Console.WriteLine(madre);
            Individuo[] hijos = new Individuo[2];
            hijos[0] = new Individuo(madre.cromosoma.getBits_Per_Gene());

            hijos[1] = new Individuo(madre.cromosoma.getBits_Per_Gene());
            //El arreglo madre se encargara de llamar al metodo
            int crossPoint = new Random(Guid.NewGuid().GetHashCode()).Next(3, 5); /*Se indica el punto en el
            cual se dividiran los arreglos para hacer la cruza*/
            Console.WriteLine("\n\tLa cruza es\n  ");
            for (int i = 0; i < madre.cromosoma.getBits_Per_Gene(); i++)
            {
                if (i<=crossPoint) {//Si el indice es <= al punto entonces se asignan las posiciones de cada hijo
                    hijos[0].cromosoma.getGene()[i] = this.cromosoma.getGene()[i];
                    hijos[1].cromosoma.getGene()[i] = madre.cromosoma.getGene()[i];
                }
                else
                {//si no entonces las posiciones seguiran de la misma manera
                    hijos[0].cromosoma.getGene()[i] = madre.cromosoma.getGene()[i];
                    hijos[1].cromosoma.getGene()[i] = this.cromosoma.getGene()[i]; 
                }
            }
            return hijos;
        }
    }

}
