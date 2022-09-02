namespace MyApp.Tests;

public class leapYearTests
{
    [Fact]
    public void rename()
    {
        // Arrange
        var Year = new Year();

         // Act
        var results = new List<bool>();
        results.Add(Year.isLeapYear(4));
        results.Add(!Year.isLeapYear(100));
        results.Add(Year.isLeapYear(400));

        // Assert
        foreach (bool test in results){
            test.Should().Be(true);
        }
    }
}