namespace MétodosDateTimeEjercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//instante de hoy
            int suma = 1 + dateTime.Day;
            int meses = dateTime.Month - 24;
            Random random = new Random();
            int[] numeros = { 0, 1, 2, 3, 4 };

            int numeroR = random.Next(numeros.Length);
            int randomYear = dateTime.Year + numeroR;

            DateTime resultado = dateTime.AddDays(suma);
            resultado = dateTime.AddMonths(meses);
            resultado = dateTime.AddYears(numeroR);

            Console.WriteLine("Resultado final: " + resultado );

        }
    }
}
