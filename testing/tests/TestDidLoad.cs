using System;
using Xunit;
using Xunit.Abstractions;
using DPMetaLib;

namespace DPMetaLib_test
{
  public class TestDidLoad
  {
    private readonly ITestOutputHelper output;
    private MappedModel testObject;

    public TestDidLoad(ITestOutputHelper output)
    {
      this.output = output;
      testObject = YamlLoader.LoadFromFile("..\\..\\..\\resources\\metadata\\basic_mapping_sample.1.yaml");
    }

    /* Start of Tests */

    [Fact]
    public void EnsureLoadedSomething()
    {
      int t = testObject.mappedDataSet.mappedDataItems.Count;
      Assert.True(t > 0, "No mapped columns where found.");
    }

    // [Fact]
    // public void EnsureValidatesAsJSON()
    // {
    //   ValidationResult result = JsonLoader.ValidateJson(testObject.JSON);
    //   String errmsg = "";
    //   {
    //     // return first exception
    //     var e = result.Errors[0];
    //     errmsg = string.Format("Validation Message: {0} - {1}", e.ErrorType, e.Message);
    //     errmsg = errmsg + string.Format("  - exception at: {0}, {1} - {2}", e.LineNumber, e.LinePosition, e.Path);
    //   }
    //   Assert.True(result.Valid, errmsg);
    // }

    // [Fact]
    // public void DeserialiseSerialiseWithoutChange()
    // {
    //   testObject.SaveToFile("YAML", "/home/scott/development/dw-ecosystem/dw-metadata/dw-meta-lib.test/out/", "SRC1.dbo.REF_DATA1~HSTG.dbo.HSTG_SRC1_REF_DATA1.yaml");
    //   // Assert.True(TODO: file compare);
    // }
  }
}