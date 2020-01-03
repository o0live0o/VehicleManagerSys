using CI.Controls;
using CI.UIComponents.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Live0xUtils.DbUtils.SqlServer;
using System.Data.SqlClient;
using System.Collections;
using VehicleManagerSys.Common.Dtos;
using VehicleManagerSys.Common;

namespace VehicleManagerSys.Main.Selectors
{
    public class ConstSelector : SelectorBase<Constant>
    {
        private bool m_includeAll;
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private List<Constant> const_list;
        private string _mTypeName;

        public ConstSelector(string typeName, int weight = 100,int heiht = 292) : base()
        {
            _mTypeName = typeName;
            m_getItemsDelegate = new GetItemsDelegate(GetList);
            m_viewer = new ConstViewer(_mTypeName);
            m_viewer.Size = new System.Drawing.Size(weight, heiht);
        }

        public ConstSelector(FlatField faltField, bool autoSelectedDefaultItem, bool includeAll,string typeName, int weight = 100,int height = 292)
        {
            _mTypeName = typeName;
            m_subject = new FlatFieldSubject(faltField);
            m_viewer = new ConstViewer(_mTypeName);
            m_viewer.Size = new System.Drawing.Size(weight, height);

            m_includeAll = includeAll;
            this.Initialize(new SelectorBase<Constant>.GetItemsDelegate(this.GetList));
            this.AutoSelectedDefaultItem = autoSelectedDefaultItem;

        }

        public bool IncludeAll
        {
            get { return m_includeAll; }
            set { m_includeAll = value; }
        }

        public IList<Constant> GetList()
        {
            //string sql = "SELECT * FROM CONST_DEFINE WHERE CON_CHNAME = @CON_CHNAME";
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("CON_CHNAME", _mTypeName);
            //const_list = _mssqlHelper.QueryList<CONST_DEFINE>(sql, hashtable).ToList();
            //if (_mTypeName.Equals("JYLB"))
            //{
            //    const_list = const_list.Where(p => p.CON_CON.Contains("环保")).ToList();
            //}
            const_list = AppHelper.Constants.Where(p =>!string.IsNullOrEmpty(p.ConstantType) && p.ConstantType.Equals(_mTypeName)).ToList();
            return const_list;
        }

        public void ClearInfo()
        {
            try
            {
                this.Clear();
                this.NeedReloadItems = false;
                //				this.m_viewer.FillItems(null); 
            }
            catch (Exception ex)
            {
            }
        }
    }
}
