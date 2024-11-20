using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite dan u nedelji (1-7):");

        int dan;
        if (int.TryParse(Console.ReadLine(), out dan))
        {
            string nazivDana = dan switch
            {
                1 => "Ponedeljak",
                2 => "Utorak",
                3 => "Sreda",
                4 => "Četvrtak",
                5 => "Petak",
                6 => "Subota",
                7 => "Nedelja",
                _ => "Nepoznat dan"
            };

            Console.WriteLine($"Uneli ste dan: {nazivDana}");
        }
        else
        {
            Console.WriteLine("Uneli ste nevažeći broj. Pokušajte ponovo.");
        }
    }
}
