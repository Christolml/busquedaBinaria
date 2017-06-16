using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaBinaria
{
    class Vector
    {
        int[] vector;
        static Random aleatorio = new Random();
        public int comparaciones { get; set; }


        public Vector(int tamaño)
        {
            vector = new int[tamaño];
        }


        /// <Llenado_del_vector>
        /// Nos llena nuestro vector de números aleatorios y sin repetirse los números mediante
        /// una sobreescritura en caso que se repitan los números en nuestro vector
        /// </summary>
        /// <param name="limite"></param>
        public void llenar(int limite)
        {
            int pos = 0;    

            vector[pos] = aleatorio.Next(0, limite);            //el primer número que estara en nuestro vector 
        
            for (pos = 1; pos < vector.Length; pos++)           //a partir de aqui lo lleno después del primer núm que esta arriba
            {
                vector[pos] = aleatorio.Next(0, limite);        //asigno el valor aleatorio y lo agrego a la posición del vector
                for (int pos2 = 0; pos2 < pos; pos2++)                   //con este for me sirve para comparar el valor del nuevo núm (arriba) con los que ya estaban almacenados
                {
                    if (vector[pos] == vector[pos2])
                        pos--;                                  //con esto el contador no va avanzar ya que la sentencia 
                                                                //del if fue verdara y ese num ya existe en el arreglo y lo vuelve a ejecutar el codigo y lo sobreescribira    
                }
            }
            Array.Sort(vector);
        }


        public int buscar(int entrada)
        {
            comparaciones = 0;
            int encontrado=-1;   //me sirve para saber que me va devolver, si devuelve -1 no existe el número a buscar
            int inicio = 0, final = vector.Length, mitad=(inicio+final)/2, buscar=entrada;

            if(entrada == vector[inicio])
            {
                encontrado = vector[inicio];
            }
            else
            {
                while (buscar > 0)
                {
                    while (buscar < vector[mitad] && buscar > 0)
                    {
                        comparaciones++;
                        final = mitad;
                        mitad = (final + inicio) / 2;
                        if (buscar == vector[mitad])
                        {
                            encontrado = vector[mitad];
                            buscar = 0;
                        }
                        else if (mitad == inicio + 1 && final == inicio + 2) //este me sirve para saber que no existe un número en el vector
                        {                                                   //por eso le doy el valor de de buscar=0 para romper el ciclo y que me devuelva -1 el encontrado
                            buscar = 0;
                        }

                    }

                    while (buscar > vector[mitad])
                    {
                        comparaciones++;
                        inicio = mitad;
                        mitad = (final + inicio) / 2;
                        if (buscar == vector[mitad])
                        {
                            encontrado = vector[mitad];
                            buscar = 0;
                        }
                        else if (mitad == inicio + 1 && final == inicio + 2)
                        {
                            buscar = 0;
                        }

                    }
                }

            }
            return encontrado;
        }

        public override string ToString()
        {
            string mostrar = "";
            for (int i = 0; i < vector.Length; i++)
            {
                mostrar += "Posición " + Convert.ToString(i) + "------" + Convert.ToString(vector[i]) + "\r\n";
            }
            return mostrar;
        }












        /// <métodoBurbuja_Ascendiente>
        /// Nos ordena nuestro vector de forma ascendiente
        /// </summary>
        /*public void metodoBurbuja()
        //{
        //    int t;
        //    for (int a = 1; a < vector.Length; a++)
        //        for (int b = vector.Length - 1; b >= a; b--)
        //        {
        //            if (vector[b - 1] > vector[b])
        //            {
        //                t = vector[b - 1];
        //                vector[b - 1] = vector[b];
        //                vector[b] = t;
        //            }
        //        }
        }*/

        /*private static Random rng = new Random();

        //public static void Shuffle<T>(this IList<T> list)
        //{
        //    int n = list.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        }*/
    }
}
