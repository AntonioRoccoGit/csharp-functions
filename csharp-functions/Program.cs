namespace csharp_functions
{
    internal class Program
    {
        ////////////////////////////////////////////////
        ////////////////////PROGRAM/////////////////////
        ////////////////////////////////////////////////
        static void Main(string[] args)
        {

            /*
                BONUS:
                Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
                Rieseguire il programma con l’input preso esternamente dall’utente. 
             */
            
            Console.WriteLine("Quanti numeri vuoi digitare?");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] userArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Inserire {i+1}° numero: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Array originale: ");
            PrintArray(userArray);

            Console.WriteLine();
            Console.Write("Array al quadrato: ");
            PrintArray(ArrayToSquare(userArray));

            Console.WriteLine();
            Console.Write("Somma elementi array: ");
            Console.Write(ArrayElementSum(userArray));

            Console.WriteLine();
            Console.Write("Somma elementi array elevati al quadrato: ");
            Console.Write(ArrayElementSum(ArrayToSquare(userArray)));

            Console.WriteLine();
            Console.Write("Array originale: ");
            PrintArray(userArray);

        }



        ////////////////////////////////////////////////
        /////////////////////FUNCTION///////////////////
        ////////////////////////////////////////////////

        //print an array in that format [element1, element2, element3, ...]
        public static void PrintArray(int[] array)
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

        //sum all element in array
        public static int ArrayElementSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //square of a number
        public static int SquareNumber(int number)
        {
            return (number * number);
        }

        //do the square of all int number in array
        public static int[] ArrayToSquare(int[] array)
        {
            int[] copyArray = (int[])array.Clone();
                
            for (int i = 0;i < copyArray.Length;i++)
            {
                int currElem = copyArray[i];
                copyArray[i] = SquareNumber(currElem);
            }
            return copyArray;
        }

    }
}