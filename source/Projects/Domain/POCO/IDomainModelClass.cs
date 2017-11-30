using System.Collections.Generic;

namespace EuTravel_2.BO
{
    public interface IDomainModelClass
    {
        List<string> _Validate(bool throwException = true);
    }
}