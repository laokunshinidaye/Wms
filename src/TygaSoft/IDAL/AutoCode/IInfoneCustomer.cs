﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.Model;

namespace TygaSoft.IDAL
{
    public partial interface IInfoneCustomer
    {
        #region ICustomer Member

        int Insert(InfoneCustomerInfo model);

        int InsertByOutput(InfoneCustomerInfo model);

        int Update(InfoneCustomerInfo model);

        int Delete(Guid id);

        bool DeleteBatch(IList<object> list);

        InfoneCustomerInfo GetModel(Guid id);

        IList<InfoneCustomerInfo> GetList(int pageIndex, int pageSize, out int totalRecords, string sqlWhere, params SqlParameter[] cmdParms);

        IList<InfoneCustomerInfo> GetList(int pageIndex, int pageSize, string sqlWhere, params SqlParameter[] cmdParms);

        IList<InfoneCustomerInfo> GetList(string sqlWhere, params SqlParameter[] cmdParms);

        IList<InfoneCustomerInfo> GetList();

        #endregion
    }
}
