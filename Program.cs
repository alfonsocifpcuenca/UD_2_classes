namespace UD_2_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos la Person Conan
            Person conan = new Person("Conan", 100);

            // Declaramos la Person Aragorn
            Person aragorn = new Person("Aragorn", 56);

            // Saludan ambas Person
            conan.SayHello();
            aragorn.SayHello();

            // Aragorn se pone en modo defensa
            aragorn.State = PersonState.Defending;

            // Conan ataca a Aragorn con 20 puntos de ataque
            conan.Attack(aragorn, 20);

            // Mostramos la vida restante de ambas Person
            Console.WriteLine($"A {aragorn.Name} le quedan {aragorn.PointOfLife} puntos de vida");
            Console.WriteLine($"A {conan.Name} le quedan {conan.PointOfLife} puntos de vida");
        }
    }
}