using System;
using System.Collections.Generic;
using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class DynamicGrid : DynamicGridView
    {
        
        private int _starHeight = 0;
        List<int> _starHeightList;

        public DynamicGrid(DynamicGridEnum dynamicGridEnum, int column) : base(dynamicGridEnum,column)
        {
            Initialize();
        }

        public DynamicGrid(DynamicGridEnum dynamicGridEnum, int column, int starHeight) : base(dynamicGridEnum, column)
        {
            _starHeight = starHeight;
            Initialize();
        }

        public DynamicGrid(DynamicGridEnum dynamicGridEnum, int column, List<int> starHeightList) : base(dynamicGridEnum, column)
        {
            _starHeightList = starHeightList;
            Initialize();
        }

        private void Initialize()
        {
            switch (_dynamicGridEnum)
            {
                case DynamicGridEnum.Auto:
                    StartAutoGrid();
                    break;
                case DynamicGridEnum.Star:
                    StartStarGrid();
                    break;
                case DynamicGridEnum.Custom:
                    StartCustomGrid();
                    break;
                default:
                    break;
            }
        }

        private void StartAutoGrid()
        {
            int percent = 100 / _column;
            for (int i = 0; i < _column; i++)
            {
                ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(percent, GridUnitType.Auto) });
            }
        }

        private void StartStarGrid()
        {
            int percent = 100 / _column;
            for (int i = 0; i < _column; i++)
            {
                ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(percent, GridUnitType.Star) });
            }
        }

        private void StartCustomGrid()
        {
            foreach (var item in _starHeightList)
            {
                ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(item, GridUnitType.Star) });
            }
        }
    }
}
