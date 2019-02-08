using System.Collections.Generic;

namespace Rethought.Perspective
{
    public interface IRequestUrlBuilder
    {
        string Build(
            string apiEndPoint,
            IEnumerable<IParameter> parameters = null);
    }
}