using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for ToggleMenu1.xaml
    /// </summary>
    public partial class ToggleMenu1 : UserControl
    {

        public int AffineAngleX
        {
            get { return (int)GetValue(AffineAngleXProperty); }
            set { SetValue(AffineAngleXProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Beta.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AffineAngleXProperty =
            DependencyProperty.Register("AffineAngleX", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));

        public int AffineAngleY
        {
            get { return (int)GetValue(AffineAngleYProperty); }
            set { SetValue(AffineAngleYProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Alfa.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AffineAngleYProperty =
            DependencyProperty.Register("AffineAngleY", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));

        public int AffineAngleZ
        {
            get { return (int)GetValue(AffineAngleZProperty); }
            set { SetValue(AffineAngleZProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AffineAngleZ.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AffineAngleZProperty =
            DependencyProperty.Register("AffineAngleZ", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));



        public int Dz
        {
            get { return (int)GetValue(DzProperty); }
            set { SetValue(DzProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dz.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DzProperty =
            DependencyProperty.Register("Dz", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));



        public int Dy
        {
            get { return (int)GetValue(DyProperty); }
            set { SetValue(DyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dy.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DyProperty =
            DependencyProperty.Register("Dy", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));


        public int Dx
        {
            get { return (int)GetValue(DxProperty); }
            set { SetValue(DxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dx.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DxProperty =
            DependencyProperty.Register("Dx", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(0));


        public int K
        {
            get { return (int)GetValue(KProperty); }
            set { SetValue(KProperty, value); }
        }

        // Using a DependencyProperty as the backing store for R.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty KProperty =
            DependencyProperty.Register("K", typeof(int), typeof(ToggleMenu1), new PropertyMetadata(1));

        public ToggleMenu1()
        {
            InitializeComponent();
        }
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
