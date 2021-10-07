using FluentAssertions;
using Patterns.FactoryMethod;
using Xunit;

namespace DesignPatterns.Tests
{
  public class FactoryMethodTests
  {
    [Trait("Unit Tests", "FactoryMethodTests")]
    [Fact(DisplayName = "Create Windows Dialog With Windows Button")]
    public void Create_Windows_Dialog_With_Windows_Button()
    {
      // Arrage
      var dialog = new WindowsDialog();

      // Act
      var button = dialog.CreateButton();

      // Assert
      button.Should().BeOfType<WindowsButton>();
    }

    [Trait("Unit Tests", "FactoryMethodTests")]
    [Fact(DisplayName = "Create Web Dialog With Html Button")]
    public void Create_Web_Dialog_With_Html_Button()
    {
      // Arrage
      var dialog = new WebDialog();

      // Act
      var button = dialog.CreateButton();

      // Assert
      button.Should().BeOfType<HtmlButton>();
    }
  }
}