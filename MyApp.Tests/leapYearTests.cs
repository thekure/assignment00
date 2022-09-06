namespace MyApp.Tests;

public class leapYearTests
{
    [Fact]
    public void isLeapYear_Should_Return_true_On_Inputs_4_100_400()
    {
        // Arrange
        var results = new List<bool>();

         // Act
        results.Add(Year.isLeapYear(4000));
        results.Add(!Year.isLeapYear(1900));
        results.Add(Year.isLeapYear(40000));

        // Assert
        foreach (bool test in results){
            test.Should().Be(true);
        }
    }

    [Fact]
    public void printIsLeapYearShouldThrowFormatException()
    {
        // Arrange
            var intstring = "hello";
            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            Year.printIsLeapYear(intstring);

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Cannot be parsed to an integer.");
       
    }

    [Fact]
    public void printIsLeapYearShouldPrintYay()
    {
        // Arrange
            var intstring = "4000";
            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            Year.printIsLeapYear(intstring);

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
       
    }

    [Fact]
    public void printIsLeapYearShouldPrintNay()
    {
        // Arrange
            var intstring = "1900";
            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            Year.printIsLeapYear(intstring);

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
       
    }

[Fact]
    public void isLeapYearShouldThrowExceptionUnder1582()
    {
        // Arrange
            var testIntString = "1581";
            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            Year.printIsLeapYear(testIntString);
            
            

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Does not support years before 1582");
       
    }
    
}