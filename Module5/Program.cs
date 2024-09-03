namespace Module5
{
    class MainClass 
    {
        public static void Main (string[] args) 
        {

            var anketa = new Anketa();

            var favoriteColors = new FavoriteColors();
            favoriteColors.EnterFavoriteColors();

            Console.WriteLine("\nYour profile:");
            Console.WriteLine($"Name: {anketa.User.Name}");
            Console.WriteLine($"Surname: {anketa.User.Surname}");
            Console.WriteLine($"Age: {anketa.User.Age}");

            var animals = new Animals(anketa.User.PetNames);
            animals.DisplayPetInformation(anketa.User.Pet);

            favoriteColors.DisplayFavoriteColors();
        }
    }
}