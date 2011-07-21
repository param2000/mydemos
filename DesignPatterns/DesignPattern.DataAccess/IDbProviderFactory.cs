using System.Data;

namespace DesignPattern.DataAccess
{
    public interface IDbProviderFactory
    {
        IDbConnection CreateConnection();
        IDbCommand CreateCommand();
    }
}