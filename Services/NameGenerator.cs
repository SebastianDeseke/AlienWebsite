namespace SebsFirstWebapp.Services;

public class NameGenerator
{
    Random rnd = new Random();
    public string[] Firstname = { "Paul", "Steven", "John", "Mark", "Martin", "Josh", "Maksimilian" };
    public string[] Secondname = { "Segall", "Simmens", "Martins", "Schmidt", "Stein", "Donau" };

    public string GenerateName()
    {
        int firstnamepos = rnd.Next(Firstname.Length);
        int secondnamepos = rnd.Next(Secondname.Length);
        return Firstname[firstnamepos] + " " + Secondname[secondnamepos];
    }

    public string WackyNameGenerator()
    {
        int arrlengf = rnd.Next(3, 11);
        int arrlengs = rnd.Next(3, 17);
        char[] frontname = new char[arrlengf];
        char[] surname = new char[arrlengs];
        char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u' };
        for (int i = 0; i < arrlengf; i++)
        {
            if (i == 0)
            {
                frontname[i] = (char)rnd.Next(65, 91);
            }
            else
            {
                double probability = rnd.NextDouble();
                if (probability < 0.4)
                {
                    // Select a vowel with 40% probability
                    frontname[i] = vowels[rnd.Next(0, vowels.Length)];
                }
                else
                {
                    frontname[i] = (char)rnd.Next(97, 123);
                }

            }
        }

        for (int i = 0; i < arrlengs; i++)
        {
            if (i == 0)
            {
                surname[i] = (char)rnd.Next(65, 91);
            }
            else
            {
                double probability = rnd.NextDouble();
                if (probability < 0.4)
                {
                    surname[i] = vowels[rnd.Next(0, vowels.Length)];
                }
                else
                {
                    surname[i] = (char)rnd.Next(97, 123);
                }

            }
        }
        return "Your name is " + string.Join("", frontname) + " " + string.Join("", surname);
    }
}
