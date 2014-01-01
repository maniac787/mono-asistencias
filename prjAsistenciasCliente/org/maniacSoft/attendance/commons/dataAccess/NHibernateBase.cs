using System;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;
using System.Reflection;
using log4net;
using NHibernate.Criterion;

namespace org.maniacSoft.attendance.commons.dataAccess
{
	public class NHibernateBase
	{
		private static NHibernate.Cfg.Configuration Configuration { get; set; }
		protected static ISessionFactory SessionFactory { get; set; }
		private static ISession session = null;
		private static IStatelessSession statelessSession = null;
		private static ILog log = LogManager.GetLogger("development");

		public NHibernateBase()
		{
			log4net.Config.XmlConfigurator.Configure();
		}

		public static NHibernate.Cfg.Configuration ConfigureNHibernate(string assembly)
		{

			Configuration = new NHibernate.Cfg.Configuration();//.Configure("org/maniacSoft/attendance/commons/resources/mapping/hibernate.cfg.xml");
			Configuration.SetProperty(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.PostgreSQLDialect");
			Configuration.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, "NHibernate.Driver.NpgsqlDriver");
			Configuration.SetProperty(NHibernate.Cfg.Environment.ConnectionString, @"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=smx");


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

		public IList<T> ExecuteICriteria<T>(ICriterion expression)
		{
			using (ITransaction transaction = Session.BeginTransaction())
			{
				try
				{
					IList<T> result = Session.CreateCriteria(typeof(T)).Add(expression).List<T>();
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

