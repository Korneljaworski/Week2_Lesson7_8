public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
            Wynik z Matury z matematyki powyżej 70
            Wynik z fizyki powyżej 55
            Wynik z chemii powyżej 45
            Łączny wynik z 3 przedmiotów powyżej 180
            Albo
            Wynik z matematyki i jednego przedmiotu powyżej 150

            Dane testowe:
            Matematyka 80
            Fizyka 71
            Chemia 0
            Rezultat w terminalu :            Kandydat dopuszczony do rekrutacji
        */

        Console.WriteLine("Podaj wynik z Matematyki:");
        int scoreMaths = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wynik z Fizyki:");
        int scorePhysics = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wynik z Chemii:");
        int scoreChemistry = Int32.Parse(Console.ReadLine());

        if ((scoreMaths > 70 && scorePhysics > 55 && scoreChemistry > 45 && (scoreMaths + scorePhysics + scoreChemistry > 180) ) || scoreMaths + scorePhysics > 150 || scoreMaths + scoreChemistry > 150)
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");

        }
    }

}
