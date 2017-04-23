using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Raml.Parser;

namespace RamlParserTests
{
    [TestClass]
    public class LoadRAML
    {
        [TestMethod]
        public async Task A001_LoadRAML()
        {
            try
            {
                var parser = new RamlParser();
                var raml = await parser.LoadAsync("raml/sa.json");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
        [TestMethod]
        public async Task A002_LoadRAML()
        {
            try
            {
                var parser = new RamlParser();
                var raml = await parser.LoadAsync("C:\\WIP\\Projects\\hmrc\\githubWS\\hmrc-api\\apis\\SA\\application.json");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
        [TestMethod]
        public async Task A003_LoadRAML2Json()
        {
            try
            {
                var parser = new RamlParser();
                var raml = await parser.LoadAsync("C:\\WIP\\Projects\\hmrc\\githubWS\\hmrc-api\\apis\\SA\\application.json");

                var sb = new StringBuilder();
                var ser = new JsonSerializer()
                {
                    Formatting = Formatting.Indented
                };
                using (var jw = new JsonTextWriter(new StringWriter(sb)))
                {
                    ser.Serialize(jw, raml);
                }

                var json = sb.ToString();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}
