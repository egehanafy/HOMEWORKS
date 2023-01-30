using NetECommerce.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.BLL.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static ProjectContext _dbInstance;

        public static ProjectContext DbInstance
        {
            get
            {
                if (_dbInstance is null) _dbInstance = new ProjectContext();
                return _dbInstance;
            }
        }
    }
}
