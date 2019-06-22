using app.Modules.ORM.Entities;
using NHibernate;
using NHibernate.Cfg;

namespace app
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
 
        private static ISessionFactory SessionFactory
        {
            get
            {
                if(_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(User).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                
                return _sessionFactory;
            }
        }
 
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}