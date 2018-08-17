using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class DynamicGridView : Grid
    {
        private int _rowCount;
        private int _columnCount;
        protected int _column;
        protected int _starHeight = 0;
        protected int _type;
        protected int[] _starHeightList;

        public DynamicGridEnum _dynamicGridEnum;

        public DynamicGridView(DynamicGridEnum dynamicGridEnum,params int[] starHeightList)
        {
            _type = 1;
            switch (dynamicGridEnum)
            {
                case DynamicGridEnum.Auto:
                    _column = starHeightList[0];
                    _type = 2;
                    break;
                case DynamicGridEnum.Star:
                    _column = starHeightList[0];
                    _starHeight = starHeightList[1];
                    break;
                case DynamicGridEnum.Custom:
                    _column = starHeightList.Length;
                    break;
                default:
                    break;
            }
            _starHeightList = starHeightList;
            _dynamicGridEnum = dynamicGridEnum;
            _rowCount = 0;
            _columnCount = 0;
            Padding = 0;
            Margin = 0;
            ColumnSpacing = -1;
            RowSpacing = -1;
        }

        public virtual void AddView(View view)
        {
            int countRow = _rowCount / _column;
            if (RowDefinitions.Count <= countRow)
            {
                RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50, (GridUnitType)_type) });
            }
            Children.Add(view, _columnCount, countRow);
            _rowCount++;
            _columnCount++;
            _columnCount = _columnCount % _column;
        }
    }
}
