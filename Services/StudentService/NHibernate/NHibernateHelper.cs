using NHibernate;
using NHibernate.Cfg;
using ISession = NHibernate.ISession;

namespace StudentService.NHibernate;


public class NHibernateHelper
{
    private static ISessionFactory _sessionFactory;

    private static ISessionFactory SessionFactory
    {
        get
        {
            if (_sessionFactory == null)
            {
                var configuration = new Configuration();
                configuration.Configure(); // configures from hibernate.cfg.xml
                //configuration.AddAssembly(typeof(Student).Assembly);
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
