namespace SebsFirstWebapp.Services;

public class NameGenerator
{
    Random rnd = new Random();
    public string [] Firstname = {"Paul","Steven","John","Mark","Martin","Josh","Maksimilian"};
    public string [] Secondname = {"Segall","Simmens","Martins","Schmidt","Stein","Donau"};

    public string GenerateName()
    {
        int firstnamepos = rnd.Next(Firstname.Length);
        int secondnamepos = rnd.Next(Secondname.Length);
        return Firstname[firstnamepos] + Secondname[secondnamepos];
    }
}
