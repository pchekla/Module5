namespace Module5
{

    public class FavoriteColors
    {

        public string[] Colors { get; private set; } = Array.Empty<string>();

        public void EnterFavoriteColors()
        {
            byte numberOfColors = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("How many favorite colors do you have? (Enter a number between 0 and 255):");
                string input = Console.ReadLine() ?? string.Empty;

                // Проверка, что введено непустое значение и число в диапазоне 0-255
                if (!string.IsNullOrWhiteSpace(input) && byte.TryParse(input, out numberOfColors))
                {
                    validInput = true;

                    if (numberOfColors > 0)
                    {
                        Colors = new string[numberOfColors];

                        for (int i = 0; i < numberOfColors; i++)
                        {
                            string colorName;
                            bool validColorName = false;

                            while (!validColorName)
                            {
                                Console.WriteLine($"Enter the name of color #{i + 1}:");
                                colorName = Console.ReadLine()?.Trim() ?? string.Empty;

                                if (!string.IsNullOrWhiteSpace(colorName))
                                {
                                    Colors[i] = colorName;
                                    validColorName = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Color name cannot be empty or only whitespace. Please enter a valid color name.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 255.");
                }
            }
        }
        public void DisplayFavoriteColors()
        {
            if (Colors.Length > 0)
            {
                Console.WriteLine($"You have {Colors.Length} favorite color(s):");
                foreach (var color in Colors)
                {
                    Console.WriteLine(color);
                }
            }
            else
            {
                Console.WriteLine("Unfortunately, you do not have any favorite colors.");
            }
        }
    }
}