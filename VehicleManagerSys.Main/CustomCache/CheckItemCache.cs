using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Dtos.Emuns;

namespace VehicleManagerSys.Main.CustomCache
{
    public class CheckItemCache
    {
        private static object lockObj = new object();

        private static CheckItemCache _checkItemCache = null;

        private static List<CheckItem> _hb_checkItems = new List<CheckItem>();

        private CheckItemCache() { }


        static CheckItemCache()
        {
            _checkItemCache = new CheckItemCache();
            _checkItemCache.Init_HB_CheckItem();
        }

        public static CheckItemCache GetInsance()
        {
            return _checkItemCache;
        }

        public List<CheckItem> Get_HB_CheckItem()
        {
            return _hb_checkItems;
        }

        private void Init_HB_CheckItem()
        {
            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Gasoline },
                ItemCode = "X1",
                ItemName = "双怠速"
            });

            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Gasoline },
                ItemCode = "X2",
                ItemName = "ASM工况"
            });

            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Gasoline },
                ItemCode = "X3",
                ItemName = "VMAS工况"
            });

            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Diesel },
                ItemCode = "X4",
                ItemName = "不透光烟度"
            });

            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Diesel },
                ItemCode = "X5",
                ItemName = "Lugdown工况"
            });

            _hb_checkItems.Add(new CheckItem()
            {
                FuelType = new List<FuelEnum>() { FuelEnum.Diesel },
                ItemCode = "X6",
                ItemName = "滤纸式烟度"
            });
        }
    }
}
