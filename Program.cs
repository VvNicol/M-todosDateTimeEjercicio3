namespace MétodosDateTimeEjercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//instante de hoy
            DateTime resultado = dateTime.AddDays(1).AddMonths(-24);//esta restando 2 años al año
            
            //random
            Random random = new Random();
            int[] numeros = { 0, 1, 2, 3, 4 };
            int numeroR = random.Next(numeros.Length);

            resultado = resultado.AddYears(numeroR); //Suma años 
            
            Console.WriteLine("Resultado Inicial: " + dateTime );
            Console.WriteLine("Resultado final: " + resultado );

            if (dateTime < resultado)//condicional
            {
                Console.WriteLine("El hoy es más grande");
            }
            else
            {
                Console.WriteLine("La fecha Inicial es menor que el resultado");
            }
            //fcha1,AddDays(1).AddMontons-(24)

        }
    }
}
