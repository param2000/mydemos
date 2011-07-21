using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace DesignPattern.DataAccess
{
    //MONOSTATE
    public class MonoStateDbProviderFactory:IDbProviderFactory
    {
        private static DbProviderFactory _frameworkProviderFactory;

        static MonoStateDbProviderFactory()
            {_frameworkProviderFactory = DbProviderFactories.GetFactory("System.Data.Sqlclient");}

        public IDbConnection CreateConnection()
            {return _frameworkProviderFactory.CreateConnection();}

        public IDbCommand CreateCommand()
            {return _frameworkProviderFactory.CreateCommand();}
    }
    //SINGLETON CLASS
    public class DBProviderFactory:IDbProviderFactory
    {
        public static readonly IDbProviderFactory Instance = new DBProviderFactory(ConfigurationManager.ConnectionStrings[1]);
        private DbProviderFactory _frameworkProviderFactory;
        private ConnectionStringSettings _settings;
       
        private DBProviderFactory(ConnectionStringSettings settings)
        {
            _frameworkProviderFactory = DbProviderFactories.GetFactory(settings.ProviderName);
            this._settings = settings;
        }

        public IDbConnection CreateConnection()
        {
            IDbConnection connection = _frameworkProviderFactory.CreateConnection();
            connection.ConnectionString = _settings.ConnectionString;
            return connection;
        }

        public IDbCommand CreateCommand()
            {return _frameworkProviderFactory.CreateCommand();}
    }
}