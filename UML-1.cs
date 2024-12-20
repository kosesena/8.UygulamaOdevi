// Base class: Person - Person sınıfı,temel bir sınıftır(base class) ve Student ile Proffessor sınıfları bu sınıfı miras alır.Kişilerin adı,telefon numarası ve e-posta adresi gibi ortak özelliklerini içerir.
public class Person
{
    public string Name { get; set; } // Kişinin adı için bir özelliktir. get ve set ile değer okuyabilir veya yazabilirsiniz.
    public string PhoneNumber { get; set; } // Telefon numarasını tutar.
    public string EmailAddress { get; set; } // Kişinin e-posta adresini saklar.

    public void PurchaseParkingPass() // Person sınıfına ait bir metottur.Bu metod,park yeri satın alma işleminin simüle eder.Şu anda sadece bir mesaj yazdırıyor.
    {
        // Implementation for purchasing a parking pass
        Console.WriteLine("Parking pass purchased.");
    }
}

// Associated class: Address - Bu sınıf,Person nesnesi ile ilişkilidir.Person nesnesi bir adreste yaşıyor olabilir.
public class Address
{
    public string Street { get; set; } // Sokak adı
    public string City { get; set; } // Şehir adı
    public string State { get; set; } // Eyalet ya da bölge bilgisi
    public int PostalCode { get; set; } // Posta kodunu tutar
    public string Country { get; set; } // Ülke adını tutar

    private bool Validate() // Bu metot adresin geçerliliğini kontrol etmek için kullanlabilir.Şu anda sadece true döndürüyor.
    {
        // Implementation for validating the address
        return true; // Example: Always valid
    }

    public string OutputAsLabel() // Adresi etiket formatında bir string olarak döndürür.Örneğin: "123 Main St, Springfield, IL,62704, USA"
    {
        return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
    }
}

// Derived class: Student
public class Student : Person // Student sınıfı,Person sınıfından miras alır.Böylece Name,PhoneNumber,EmailAddress gibi özelliklere sahiptir.
{
    public int StudentNumber { get; set; } // Öğrencinin numarasını tutar
    public int AverageMark { get; set; } // Öğrencinin ortalama notunu saklar

    public bool IsEligibleToEnroll(string courseName) //Bir öğrencinin,belirli bir derse kayıt için uygun olup olmadığını kontrol eder.Burada AverageMark(ortalama not)50 ve üzerindeyse true döner.
    {
        // Example implementation
        return AverageMark >= 50;
    }

    public int GetSeminarsTaken() // Öğrencinin katıldığı seminer sayısını döndürür.Şu an sabit bir değer (10) döndürüyor.
    {
        // Example implementation
        return 10; // Example fixed number
    }
}

// Derived class: Professor
public class Professor : Person // Professor sınıfı da Person sınıfından türetilmiştir.
{
    public int Salary { get; private set; } // Profesörün maaşını tutar.Bu özellik yalnızca sınıf içinde değiştirilebilir(private set).
    protected int StaffNumber { get; set; } // Profesörün personel numarasını saklar.Bu özellik yalnızca bu sınıf ve alt sınıflar tarafından erişilebilir.
    public int YearsOfService { get; set; } // Profesörün hizmet süresi
    public int NumberOfClasses { get; set; } // Profesörün verdiği ders sayısını tutar

    public void AssignClass(int numberOfClasses) // Profesörün verdiği ders sayısını artırır.
    {
        NumberOfClasses += numberOfClasses;
    }
}

// Main program to demonstrate relationships
public class Program
{
    public static void Main(string[] args)
    {
        // Example usage
        Address address = new Address
        {
            Street = "123 Main St",
            City = "Springfield",
            State = "IL",
            PostalCode = 62704,
            Country = "USA"
        };

        Professor professor = new Professor
        {
            Name = "Dr. Smith",
            PhoneNumber = "123-456-7890",
            EmailAddress = "drsmith@example.com",
            YearsOfService = 10,
            NumberOfClasses = 3
        };

        Student student = new Student
        {
            Name = "John Doe",
            PhoneNumber = "987-654-3210",
            EmailAddress = "johndoe@example.com",
            StudentNumber = 12345,
            AverageMark = 85
        };

        Console.WriteLine($"Professor {professor.Name} supervises {student.Name}");
        Console.WriteLine($"Student's address: {address.OutputAsLabel()}");
    }
}
