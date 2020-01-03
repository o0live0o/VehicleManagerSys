using CI.UIComponents.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleManagerSys.Common.Dtos;

namespace VehicleManagerSys.Main.Selectors
{
    public class ConstViewer : ViewerBase<Constant>
    {
        private IList<Constant> m_items;
        private Constant m_selectedItem;
        private ConstListControl m_Control;
        private string _mTypeName;
        /// <summary>
        /// 构造函数。
        /// </summary>
        public ConstViewer(string typeName)
            : base()
        {
            this._mTypeName = typeName;            
             m_Control = new ConstListControl(_mTypeName);
            m_Control.AfterSelected += new EventHandler(SampleList_Selected);
        }



        /// <summary>
        /// 初始化视区容器控件。
        /// </summary>
        protected override void InitializeControl()
        {
            this.m_control = m_Control;
        }

        /// <summary>
        /// 获取当前选中对象。
        /// </summary>
        /// <returns>当前选中对象。</returns>
        protected override Constant GetSelectedItem()
        {
            return m_selectedItem;
            //return m_sampleListControl.SelectedItem;
        }

        /// <summary>
        /// 根据显示的文本定位选定的对象。
        /// </summary>
        /// <param name="text">显示的文本。</param>
        public override void LocateItem(string text)
        {
            //  m_sampleListControl.Locate(text);
        }

        /// <summary>
        /// 填充对象集到容器控件。
        /// </summary>
        /// <param name="list">对象集</param>
        public override void FillItems(IList<Constant> list)
        {

        }

        /// <summary>
        /// 获取默认项。
        /// </summary>
        protected override Constant GetDefaultItem()
        {
            return new Constant();
        }



        private void SampleList_Selected(object sender, EventArgs e)
        {
            if (this.m_Control.ConstView != null)
                m_selectedItem = this.m_Control.ConstView;
            else
                m_selectedItem = null;

            this.OnControlClick(this, e);
        }
    }
}
