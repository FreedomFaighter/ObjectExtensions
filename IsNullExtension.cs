using System.Threading.Tasks;

namespace ObjectExtensions
{
    static public class IsNullExtension
    {
        static public bool IsNull(this object o)
        {
            return o == null;
        }

        static public Task<bool> IsNullAsync(this object o)
        {
            return new Task<bool>(() => { return o.IsNull(); });
        }
    }
}
