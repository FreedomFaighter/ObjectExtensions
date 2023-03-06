using System;

[assembly: AssemblyTitle("ObjectExtensions")]
[assembly: AssemblyDescription("Simple extension to check if your object is a null value in .NET")]
[assembly: AssemblyCompany("John H. Freeman")]
[assembly: AssemblyVersion("0.1")]
[assembly: AssemblyCopyright("2012")]
[assembly: AssemblyTrademark("brainkernel")]

namespace ObjectExtensions
{
    static public class ObjectExtensions
    {
        static public Boolean IsNull(this Object o)
        {
            return o == null;
        }
    }
}
