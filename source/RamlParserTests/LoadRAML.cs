using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raml.Parser;

namespace RamlParserTests
{
    [TestClass]
    public class LoadRAML
    {
        [TestMethod]
        public void A001_LoadRAML()
        {
            try
            {
                var parser = new RamlParser();
                var raml = parser.LoadAsync("raml/sa.json");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
        [TestMethod]
        public void A002_LoadRAML()
        {
            try
            {
                var parser = new RamlParser();
                var raml = parser.LoadAsync("C:\\WIP\\Projects\\hmrc\\githubWS\\hmrc-api\\apis\\SA\\sa.json");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}
