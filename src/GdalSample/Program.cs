using System;

namespace GdalSample
{
    class Program
    {
        static void Main(string[] args)
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
