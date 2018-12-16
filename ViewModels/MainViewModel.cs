using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Lab5.Commands;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Forms;
using Lab5.Models;
using System.Windows;

namespace Lab5.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private double alfa = 45;
        private double beta = 45;
        private WriteableBitmap wb;
        private Color color = Color.FromRgb(0, 0, 0);
        private int r = 200;
        private int alfaOt = 0;
        private int betaOt = 0;
        private int alfaDo = 180;
        private int betaDo = 360;
        private int resolution = 3;
        private Point pointHorizontal = new Point(double.NegativeInfinity, double.NegativeInfinity);
        private string[] viewTypes = new string[] { "Draw full carcass", "Draw horizontal carcass" };
        private int selectedIndex = 1;
        private int affineAngleX = 0;
        private int affineAngleY = 0;
        private int affineAngleZ = 0;
        private int dx = 0;
        private int dy = 0;
        private int dz = 0;
        private int k = 1;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }
        public string[] ViewTypes
        {
            get { return viewTypes; }
            set
            {
                viewTypes = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// расстоянние между горизонтальными линиями в пикселях
        /// </summary>
        public int Resolution
        {
            get { return resolution; }
            set
            {
                resolution = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// начало интервала угла альфа фигуры
        /// </summary>
        public int AlfaOt
        {
            get { return alfaOt; }
            set
            {
                alfaOt = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// начало интервала угла бета фигуры
        /// </summary>
        public int BetaOt
        {
            get { return betaOt; }
            set
            {
                betaOt = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// конец интервала угла альфа фигуры
        /// </summary>
        public int AlfaDo
        {
            get { return alfaDo; }
            set
            {
                alfaDo = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// конец интервала угла бета фигуры
        /// </summary>
        public int BetaDo
        {
            get { return betaDo; }
            set
            {
                betaDo = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// ро фигуры
        /// </summary>
        public int R
        {
            get { return r; }
            set
            {
                r = value;
                OnPropertyChanged();
            }
        }
        public WriteableBitmap Wb
        {
            get { return wb; }
            set
            {
                wb = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// угол альфа камеры
        /// </summary>
        public double Alfa
        {
            get { return alfa; }
            set
            {
                alfa = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// угол бета камеры
        /// </summary>
        public double Beta
        {
            get { return beta; }
            set
            {
                beta = value;
                OnPropertyChanged();
            }
        }
        public int AffineAngleX
        {
            get
            {
                return affineAngleX;
            }

            set
            {
                affineAngleX = value;
                OnPropertyChanged();
            }
        }
        public int AffineAngleY
        {
            get
            {
                return affineAngleY;
            }

            set
            {
                affineAngleY = value;
                OnPropertyChanged();
            }
        }
        public int AffineAngleZ
        {
            get
            {
                return affineAngleZ;
            }

            set
            {
                affineAngleZ = value;
                OnPropertyChanged();
            }
        }
        public int Dx
        {
            get
            {
                return dx;
            }

            set
            {
                dx = value;
                OnPropertyChanged();
            }
        }
        public int Dy
        {
            get
            {
                return dy;
            }

            set
            {
                dy = value;
                OnPropertyChanged();
            }
        }
        public int Dz
        {
            get
            {
                return dz;
            }

            set
            {
                dz = value;
                OnPropertyChanged();
            }
        }
        public int K
        {
            get
            {
                return k;
            }

            set
            {
                k = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            wb = BitmapFactory.New(1000, 725);
        }

        #region Commands
        public DelegateCommand drawCommand;
        public DelegateCommand Draw
        {
            get
            {
                return drawCommand ?? (drawCommand = new DelegateCommand(obj =>
                {
                    switch (SelectedIndex)
                    {
                        case 0:
                            {
                                DrawFullCarcass();
                                break;
                            }
                        case 1:
                            {
                                DrawHorizontalCarcass();
                                break;
                            }
                        case 2:
                            {
                                DrawPolygons();
                                break;
                            }
                    }
                }));
            }
        }
        private DelegateCommand clearCommand;
        public DelegateCommand Clear
        {
            get
            {
                return clearCommand ?? (clearCommand = new DelegateCommand(obj =>
                {
                    Wb.Clear();
                }));
            }
        }
        private DelegateCommand colorCommand;
        public DelegateCommand ColorCommand
        {
            get
            {
                return colorCommand ?? (colorCommand = new DelegateCommand(obj =>
                {
                    var colorDial = new ColorDialog();
                    if (colorDial.ShowDialog() == DialogResult.OK)
                        color = Color.FromRgb(colorDial.Color.R, colorDial.Color.G, colorDial.Color.B);
                    colorDial = null;


                }));
            }
        }
        private DelegateCommand applyAffineCommand;
        public DelegateCommand ApplyAffine
        {
            get
            {
                return applyAffineCommand ?? (applyAffineCommand = new DelegateCommand(obj =>
                {
                    Wb.Clear();
                    DrawHorizontalCarcass(MainModel.Scaling, MainModel.Moving, MainModel.RotationX, MainModel.RotationY, MainModel.RotationZ);
                }));
            }
        }       


        #endregion
        public void DrawFullCarcass()
        {
            Wb.Clear();

            ////Z - buffer
            //int[,] Z = new int[Wb.PixelWidth, Wb.PixelHeight];
            //for (int i = 0; i < Wb.PixelWidth; i++)
            //{
            //    for (int j = 0; j < Wb.PixelHeight; j++)
            //    {
            //        Z[i, j] = Int32.MinValue;
            //    }
            //}
            Point[] buffer = new Point[(BetaDo - BetaOt)];
            for (int alfa = AlfaOt; alfa < AlfaDo; alfa += resolution)
            {

                for (int beta = BetaOt; beta < BetaDo; beta += resolution*2)
                {
                    var res = MainModel.Axonometry(MainModel.Func(R, alfa * Math.PI / 180, beta * Math.PI / 180),
                        Alfa * Math.PI / 180,
                        Beta * Math.PI / 180);
                    if (!double.IsNegativeInfinity(pointHorizontal.X))
                    {
                        MainModel.Line(wb, (int)pointHorizontal.X, (int)pointHorizontal.Y,
                        (int)res.Item1 + Wb.PixelWidth / 2, (int)res.Item2 + Wb.PixelHeight / 2,
                         color);// ,ref Z, (int)res.Item3);
                        if (alfa > 0)
                            MainModel.Line(wb, (int)buffer[beta].X, (int)buffer[beta].Y,
                            (int)res.Item1 + Wb.PixelWidth / 2, (int)res.Item2 + Wb.PixelHeight / 2,
                            color);
                    }
                    buffer[beta] = new Point(res.Item1 + Wb.PixelWidth / 2, res.Item2 + Wb.PixelHeight / 2);
                    if (alfa < AlfaDo - resolution)
                        pointHorizontal = new Point(res.Item1 + Wb.PixelWidth / 2, res.Item2 + Wb.PixelHeight / 2);
                    else
                        pointHorizontal.X = double.NegativeInfinity;
                }
            }
        }
        public void DrawHorizontalCarcass()
        {
            Wb.Clear();

            ////Z - buffer
            //int[,] Z = new int[Wb.PixelWidth, Wb.PixelHeight];
            //for (int i = 0; i < Wb.PixelWidth; i++)
            //{
            //    for (int j = 0; j < Wb.PixelHeight; j++)
            //    {
            //        Z[i, j] = Int32.MinValue;
            //    }
            //}
            for (int alfa = AlfaOt; alfa < AlfaDo; alfa += resolution)
            {

                for (int beta = BetaOt; beta < BetaDo; beta += resolution)
                {
                    var res = MainModel.Axonometry(MainModel.Func(R, alfa * Math.PI / 180, beta * Math.PI / 180),
                        Alfa * Math.PI / 180,
                        Beta * Math.PI / 180);
                    if (!double.IsNegativeInfinity(pointHorizontal.X))
                    {
                        MainModel.Line(wb, (int)pointHorizontal.X, (int)pointHorizontal.Y,
                        (int)res.Item1 + Wb.PixelWidth / 2, (int)res.Item2 + Wb.PixelHeight / 2,
                         color);//,ref Z, (int)res.Item3);                               
                    }
                    if (alfa < AlfaDo - resolution)
                        pointHorizontal = new Point(res.Item1 + Wb.PixelWidth / 2, res.Item2 + Wb.PixelHeight / 2);
                    else
                        pointHorizontal.X = double.NegativeInfinity;
                }
            }
        }
        public void DrawPolygons()
        {
            Wb.Clear();
            Point[] bufferUp = new Point[(BetaDo - BetaOt)];
            Point[] bufferDown = new Point[(BetaDo - BetaOt)];
            for (int alfa = AlfaOt; alfa < AlfaDo; alfa += resolution)
            {
                for (int beta = BetaOt; beta < BetaDo; beta += resolution)
                {
                    var res = MainModel.Axonometry(MainModel.Func(R, alfa * Math.PI / 180, beta * Math.PI / 180),
                       Alfa * Math.PI / 180,
                       Beta * Math.PI / 180);
                    bufferDown[beta] = new Point(res.Item1 + Wb.PixelWidth / 2, res.Item2 + Wb.PixelHeight / 2);
                    if (alfa > 1 && beta > 0)
                        MainModel.Polygon(wb, bufferUp[beta - 1], bufferUp[beta], bufferDown[beta - 1], bufferDown[beta],color);
                    if (alfa > 0 && beta > 0)
                        bufferUp[beta-1] = bufferDown[beta-1];
                }
            }
        }
        public void DrawHorizontalCarcass(Func<Tuple<double, double, double>,int, Tuple<double, double, double>> scaling,
            Func<Tuple<double, double, double>,int, int, int, Tuple<double, double, double>> moving,
            Func<Tuple<double, double, double>, int, Tuple<double, double, double>> rX,
            Func<Tuple<double, double, double>, int, Tuple<double, double, double>> rY,
            Func<Tuple<double, double, double>, int, Tuple<double, double, double>> rZ)
        {
            Wb.Clear();

            ////Z - buffer
            //int[,] Z = new int[Wb.PixelWidth, Wb.PixelHeight];
            //for (int i = 0; i < Wb.PixelWidth; i++)
            //{
            //    for (int j = 0; j < Wb.PixelHeight; j++)
            //    {
            //        Z[i, j] = Int32.MinValue;
            //    }
            //}
            for (int alfa = AlfaOt; alfa < AlfaDo; alfa += resolution)
            {

                for (int beta = BetaOt; beta < BetaDo; beta += resolution * 2)
                {
                    var res = MainModel.Axonometry(rZ(rY(rX(moving(scaling(MainModel.Func(R, alfa * Math.PI / 180, beta * Math.PI / 180),K),Dx,Dy,Dz),AffineAngleX),AffineAngleY),AffineAngleZ),
                        Alfa * Math.PI / 180,
                        Beta * Math.PI / 180);
                    if (!double.IsNegativeInfinity(pointHorizontal.X))
                    {
                        MainModel.Line(wb, (int)pointHorizontal.X, (int)pointHorizontal.Y,
                        (int)res.Item1 + Wb.PixelWidth / 2, (int)res.Item2 + Wb.PixelHeight / 2,
                         color);//,ref Z, (int)res.Item3);                               
                    }
                    if (alfa < AlfaDo - resolution)
                        pointHorizontal = new Point(res.Item1 + Wb.PixelWidth / 2, res.Item2 + Wb.PixelHeight / 2);
                    else
                        pointHorizontal.X = double.NegativeInfinity;
                }
            }
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
