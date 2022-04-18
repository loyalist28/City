using System;
using System.IO;
using City;

int personId = 1;

Person[] peopleArr = new Person[100];

for(int i = 0; i < peopleArr.Length; i++)
{
    peopleArr[i] = CreateRandomPerson(personId);
    
    personId++;
}

foreach(Person p in peopleArr)
{
    Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.PersonGender} {p.Id}");
}

Person CreateRandomPerson(int id) 
{
    Person.Gender gender;
    string surname;

    Random rand = new Random();
    string namesPath;

    if(rand.Next(2) == 0) 
        gender = Person.Gender.Male;
    else
        gender = Person.Gender.Female;

    if (gender == Person.Gender.Male)
    {
        namesPath = @"C:\Users\Alexander\source\repos\City\City\assets\Male_Names.txt";
    }
    else
        namesPath = @"C:\Users\Alexander\source\repos\City\City\assets\Female_Names.txt";

    string[]? namesArr;
    string[]? surnamesArr;
    using (StreamReader srNames = File.OpenText(namesPath), srSurnames = File.OpenText(@"C:\Users\Alexander\source\repos\City\City\assets\Surnames.txt"))
    {
        namesArr = srNames.ReadToEnd().Split("\r\n");
        

        surnamesArr = srSurnames.ReadToEnd().Split("\r\n");
    }

    surname = surnamesArr[rand.Next(surnamesArr.Length)];

    if (gender == Person.Gender.Female)
    {
        string surnameSuffix = surname.Substring(surname.Length - 2);

        switch(surnameSuffix)
        {
            case "ов":
                surname = surname + "а";
                break;
            case "ев":
                surname = surname + "а";
                break;
            case "ёв":
                surname = surname + "а";
                break;
            case "ин":
                surname = surname + "а";
                break;
            case "ын":
                surname = surname + "а";
                break;
            case "ий":
                surname = surname.Replace("ий", "ая");
                break;
            case "ый":
                surname = surname.Replace("ый", "ая");
                break;
            case "ой":
                surname = surname.Replace("ой", "ая");
                break;
        }
    }

    return new Person(namesArr[rand.Next(namesArr.Length)], surname, gender, id);
}