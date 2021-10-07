namespace Patterns.FactoryMethod
{
  public class WebDialog : Dialog
  {
    public override IButton CreateButton()
      => new HtmlButton();
  }
}