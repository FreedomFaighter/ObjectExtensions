namespace ObjectExtensions
{
    static public class IsNullExtension
    {
        static public bool IsNull(this object o)
        {
            return o == null;
        }
    }
}
