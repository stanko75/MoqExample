using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoqExampleTest
{
  using MoqExample.ViewModel;

  [TestClass]
  public class MoqExampleUnitTest
  {
    [TestMethod]
    public void MoqExampleTestMethod()
    {
      var sut = new MoqExampleViewModel();
      sut.UpdateTextBox(null);
      Assert.AreEqual(sut.MyTextBox, "This text is from button click");
    }
  }
}