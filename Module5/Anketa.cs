namespace Module5
{
    public class Anketa
    {
        public (string Name, string Surname, byte Age, bool Pet, string[] PetNames) User;

        public Anketa()
        {
            User = (string.Empty, string.Empty, 0, false, Array.Empty<string>());

            EnterName();
            EnterSurname();
            EnterAge();
            EnterPet();
        }

        private void EnterName()
        {
            while (string.IsNullOrWhiteSpace(User.Name))
            {
                Console.WriteLine("Enter a name:");
                User.Name = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(User.Name))
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                }
            }
        }

        private void EnterSurname()
        {
            while (string.IsNullOrWhiteSpace(User.Surname))
            {
                Console.WriteLine("Enter your last name:");
                User.Surname = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(User.Surname))
                {
                    Console.WriteLine("Last name cannot be empty. Please enter a valid last name.");
                }
            }
        }

        private void EnterAge()
        {
            byte age;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Write down your age (1-255):");
                string input = Console.ReadLine() ?? string.Empty;

                if (byte.TryParse(input, out age) && age <= 255 && age > 0)
                {
                    User.Age = age;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 255.");
                }
            }
        }

        private void EnterPet()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Do you have any animals (yes/no)?");
                string input = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                if (input == "yes")
                {
                    User.Pet = true;
                    var animals = new Animals(Array.Empty<string>());
                    animals.EnterPetNames();
                    User.PetNames = animals.PetNames;
                    validInput = true;
                }
                else if (input == "no")
                {
                    User.Pet = false;
                    User.PetNames = Array.Empty<string>();
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter (yes/no)?");
                }
            }
        }
    }
}