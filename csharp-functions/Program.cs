namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
                BONUS:
                Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
                Rieseguire il programma con l’input preso esternamente dall’utente. 
             */

            ////////////////////PROGRAM/////////////////////
            int[] userArray = { 2, 6, 7, 5, 3, 9, 12, 6, 7, 11};

            Console.Write("Array originale: ");
            printArray(userArray);

            Console.WriteLine();
            Console.Write("Array al quadrato: ");
            printArray(arrayToSquare(userArray));

            Console.WriteLine();
            Console.Write("Somma elementi array: ");
            Console.Write(arrayElementSum(userArray));

            Console.WriteLine();
            Console.Write("Somma elementi array elevati al quadrato: ");
            Console.Write(arrayElementSum(arrayToSquare(userArray)));

            Console.WriteLine();
            Console.Write("Array originale: ");
            printArray(userArray);

            

            

            /////////////////////FUNCTION///////////////////

            //print an array in that format [element1, element2, element3, ...]
            void printArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++) { 
                    int currentNumber = array[i];
                    if (i < array.Length -1) { 
                        Console.Write($"{currentNumber}, ");
                    }else
                    {
                        Console.Write(currentNumber);
                    } 

                }

                Console.Write("]");
                
            }
            
            //int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            int arrayElementSum(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            //square of a numeber
            int squareNumber(int number)
            {
                return (number * number);
            }

            //int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
            int[] arrayToSquare(int[] array)
            {
                int[] copyArray = (int[])array.Clone();
                
                for (int i = 0;i < copyArray.Length;i++)
                {
                    int currElem = copyArray[i];
                    copyArray[i] = squareNumber(currElem);
                }
                return copyArray;
            }


        }
    }
}