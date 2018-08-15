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
        protected DynamicGridEnum _dynamicGridEnum;

        public DynamicGridView(DynamicGridEnum dynamicGridEnum,int column)
        {
            _column = column;
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
                int type = _dynamicGridEnum == DynamicGridEnum.Star || _dynamicGridEnum == DynamicGridEnum.Custom ? 1 : 2;
                RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50, (GridUnitType)type) });
            }
            Children.Add(view, _columnCount, countRow);
            _rowCount++;
            _columnCount++;
            _columnCount = _columnCount % _column;
        }
    }
}
