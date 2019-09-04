using System;
using Xunit;

namespace Gdal.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            OSGeo.OGR.Ogr.RegisterAll();
            for(var i=0; i <OSGeo.OGR.Ogr.GetDriverCount(); i++)
            {
                var driver =  OSGeo.OGR.Ogr.GetDriver(i);
                Console.WriteLine(driver.GetName());
            }
        }
    }
}
