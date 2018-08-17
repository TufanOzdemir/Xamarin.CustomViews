using System;
using System.Collections.Generic;
using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class DynamicGrid : DynamicGridView
    {
        public DynamicGrid(DynamicGridEnum dynamicGridEnum, params int[] starHeightList) : base(dynamicGridEnum, starHeightList)
        {
            for (int i = 0; i < starHeightList.Length; i++)
            {
                if (starHeightList[i] <= 0)
                {
                    starHeightList[i] = 1;
                }
            }

            if (dynamicGridEnum == DynamicGridEnum.Custom)
            {
                StartCustomGrid();
            }
            else
                StartGrid();
        }

        private void StartGrid()
        {
            int percent = 100 / _column;
            for (int i = 0; i < _column; i++)
                ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(percent, (GridUnitType)_type) });
        }

        private void StartCustomGrid()
        {
            foreach (var item in _starHeightList)
                ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(item, GridUnitType.Star) });
        }
    }
}
