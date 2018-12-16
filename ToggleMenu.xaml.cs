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
    /// Interaction logic for ToggleMenu.xaml
    /// </summary>
    public partial class ToggleMenu : UserControl
    {
        public int R
        {
            get { return (int)GetValue(RProperty); }
            set { SetValue(RProperty, value); }
        }

        // Using a DependencyProperty as the backing store for R.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RProperty =
            DependencyProperty.Register("R", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));


        public int AlfaOt
        {
            get { return (int)GetValue(AlfaOtProperty); }
            set { SetValue(AlfaOtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AlfaOt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlfaOtProperty =
            DependencyProperty.Register("AlfaOt", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));


        public int AlfaDo
        {
            get { return (int)GetValue(AlfaDoProperty); }
            set { SetValue(AlfaDoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AlfaDo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlfaDoProperty =
            DependencyProperty.Register("AlfaDo", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));


        public int BetaOt
        {
            get { return (int)GetValue(BetaOtProperty); }
            set { SetValue(BetaOtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BetaOt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BetaOtProperty =
            DependencyProperty.Register("BetaOt", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));


        public int BetaDo
        {
            get { return (int)GetValue(BetaDoProperty); }
            set { SetValue(BetaDoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BetaDo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BetaDoProperty =
            DependencyProperty.Register("BetaDo", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));

        public int Resolution
        {
            get { return (int)GetValue(ResolutionProperty); }
            set { SetValue(ResolutionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Resolution.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ResolutionProperty =
            DependencyProperty.Register("Resolution", typeof(int), typeof(ToggleMenu), new PropertyMetadata(0));




        public ToggleMenu()
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
