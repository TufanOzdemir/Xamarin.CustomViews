using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class ButtonGroup : DynamicGrid
    {
        public ButtonGroup(int column, int starHeight = 0) : base(column, starHeight)
        {
        }

        private void Refresh(View arg)
        {
            foreach (var item in Children.ToList())
            {
                item.BackgroundColor = Color.White;
            }
            Children.FirstOrDefault(i => i == arg).BackgroundColor = Color.Orange;
        }

        public override void AddView(View view)
        {
            Button btn = (Button)view;
            btn.Clicked += BtnSelected;
            base.AddView(btn);
        }

        private void BtnSelected(object sender, EventArgs e)
        {
            Refresh((View)sender);
        }
    }
}
