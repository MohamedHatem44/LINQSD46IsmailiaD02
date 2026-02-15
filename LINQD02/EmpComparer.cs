using System.Diagnostics.CodeAnalysis;

namespace LINQD02
{
    public class EmpComparer : IEqualityComparer<Employee>
    {
        /*------------------------------------------------------------------*/
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id;
        }
        /*------------------------------------------------------------------*/
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
        /*------------------------------------------------------------------*/
    }
}
