using Berger.Extensions.Pagination;

namespace Berger.Extensions.GraphQL
{
    public class Response<T> where T : class
    {
        #region Properties
        public T First { get; set; } = Activator.CreateInstance<T>();
        public List<T> List { get; set; } = new List<T>();
        public Pagination<T> Pagination { get; set; } = new Pagination<T>();
        #endregion
    }
}