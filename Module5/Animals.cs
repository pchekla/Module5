namespace Module5
{
    public class Animals
    {
        public string[] PetNames { get; set; }

        public Animals(string[] petNames)
        {
            PetNames = petNames;
        }

        public void DisplayPetInformation(bool hasPet)
        {
            if (hasPet)
            {
                if (PetNames.Length > 0)
                {
                    Console.WriteLine($"You have {PetNames.Length} pet(s):");
                    
                    foreach (var name in PetNames)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("You have pets, but no pet names were entered.");
                }
            }
            else
            {
                Console.WriteLine("Unfortunately, you do not have any pets.");
            }
        }

        public void EnterPetNames()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("How many pets do you have?");
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int numberOfPets) && numberOfPets > 0)
                {
                    PetNames = new string[numberOfPets];
                    for (int i = 0; i < numberOfPets; i++)
                    {
                        bool nameValid = false;

                        while (!nameValid)
                        {
                            Console.WriteLine($"Enter the name of pet #{i + 1}:");
                            string petName = Console.ReadLine() ?? string.Empty;

                            if (!string.IsNullOrWhiteSpace(petName))
                            {
                                PetNames[i] = petName;
                                nameValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Name cannot be empty. Please enter a valid name.");
                            }
                        }
                    }
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the number of pets.");
                }
            }
        }
    }
}