using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;
using System.Data.SqlTypes;

namespace BookClub.Services
{

    public abstract class BaseService : IDisposable
    {

        protected SqlConnection m_connection = null;
        private static XmlDocument s_sqlCommands = null;
        private static object s_processLock = new object();

        public BaseService(SqlConnection connection)
        {
            m_connection = connection;
            if (s_sqlCommands == null)
            {
                lock (s_processLock)
                {
                    if (s_sqlCommands == null)
                    {
                        s_sqlCommands = new XmlDocument();
                        s_sqlCommands.Load("Sql/SqlCommands.xml");
                    }
                }
            }
        }

        public string GetSqlCommand(string path)
        {
            return s_sqlCommands.DocumentElement.SelectSingleNode(path).InnerText;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                m_connection = null;
            }
            // free native resources
        }

        public static T ConvertDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
                return default(T);
            else
                return (T)obj;
        }

        public static int? ConvertDBInt(object obj)
        {
            if (obj == null || obj == DBNull.Value)
                return null;
            else
                return (int)obj;
        }

    }

}
