using System;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;
using System.Reflection;

namespace org.maniacSoft.attendance.commons.dataAccess
{
	public class NHibernateBase
	{
		private static NHibernate.Cfg.Configuration Configuration { get; set; }
		protected static ISessionFactory SessionFactory { get; set; }
		private static ISession session = null;
		private static IStatelessSession statelessSession = null;

		/*public NHibernateBase ()
		{
		}*/

		public static NHibernate.Cfg.Configuration ConfigureNHibernate(string assembly)
		{

			Configuration = new NHibernate.Cfg.Configuration();

			Configuration.AddAssembly(assembly);
			//Configuration.AddAssembly(Assembly.GetCallingAssembly());
			//Configuration.SetProperty(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.PostgreSQLDialect");
			return Configuration;
		}
		public void Initialize(string assembly)
		{
			Configuration = ConfigureNHibernate(assembly);

			SessionFactory = Configuration.BuildSessionFactory();
		}

		public static ISession Session
		{
			get
			{
				if (session == null)
				{
					session = SessionFactory.OpenSession();
				}
				
				return session;
			}
		}

		public static IStatelessSession StatelessSession
		{
			get
			{
				if (statelessSession == null)
				{
					statelessSession = SessionFactory.OpenStatelessSession();
				}
				
				return statelessSession;
			}
		}

		public IList<T> ExecuteICriteria<T>()
		{
			using (ITransaction transaction = Session.BeginTransaction())
			{
				try
				{
					IList<T> result = Session.CreateCriteria(typeof(T)).List<T>();
					transaction.Commit();
					return result;
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					throw;
				}
			}
		}
	}



}

