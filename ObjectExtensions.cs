using System;
using System.Reflection;

[assembly: AssemblyTitle("ObjectExtensions")]
[assembly: AssemblyDescription("Simple extension to check if your object is a null value in .NET")]
[assembly: AssemblyCompany("John H. Freeman")]
[assembly: AssemblyVersion("0.1")]
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
