// Base class: Person
public class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }

    public void PurchaseParkingPass()
    {
        // Implementation for purchasing a parking pass
        Console.WriteLine("Parking pass purchased.");
    }
}

// Associated class: Address
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int PostalCode { get; set; }
    public string Country { get; set; }

    private bool Validate()
    {
        // Implementation for validating the address
        return true; // Example: Always valid
    }

    public string OutputAsLabel()
    {
        return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
    }
}

// Derived class: Student
public class Student : Person
{
    public int StudentNumber { get; set; }
    public int AverageMark { get; set; }

    public bool IsEligibleToEnroll(string courseName)
    {
        // Example implementation
        return AverageMark >= 50;
    }

    public int GetSeminarsTaken()
    {
        // Example implementation
        return 10; // Example fixed number
    }
}

// Derived class: Professor
public class Professor : Person
{
    public int Salary { get; private set; }
    protected int StaffNumber { get; set; }
    public int YearsOfService { get; set; }
    public int NumberOfClasses { get; set; }

    public void AssignClass(int numberOfClasses)
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
