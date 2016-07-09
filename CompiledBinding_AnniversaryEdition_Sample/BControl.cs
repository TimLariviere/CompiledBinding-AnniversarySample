using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CompiledBinding_AnniversaryEdition_Sample
{
    public class BControl : Control
    {


        public BClass B
        {
            get { return (BClass)GetValue(BProperty); }
            set { SetValue(BProperty, value); }
        }

        // Using a DependencyProperty as the backing store for B.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BProperty =
            DependencyProperty.Register("B", typeof(BClass), typeof(BControl), new PropertyMetadata(null));


    }
}
