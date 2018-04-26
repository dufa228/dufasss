using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace WaterRiverLib
{
    [Serializable]
    public class WaterRiverLib
    {
        #region -- Mетоды сериализации

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(WaterRiverLib hc, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, hc);
            myStream.Close();
        }

        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public WaterRiverLib LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла            
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            WaterRiverLib _hc = (WaterRiverLib)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _hc;
        }

        #endregion -- Mетоды сериализации


        #region - ИСХОДНЫЕ ДАННЫЕ
        private double _Value_1;
        /// <summary>
        /// Расход сточных вод qo,м3/с
        /// </summary> 
        public double Value_1
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Расход сточных вод qo");
                else if (_Value_1 != value)
                    _Value_1 = value;
            }
            get { return _Value_1; }
        }

        private double _Value_2;
        /// <summary>
        /// Содержание консервативной примеси в них Sо, г/л
        /// </summary> 
        public double Value_2
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода содержания консервативной примеси в них Sо");
                else if (_Value_2 != value)
                    _Value_2 = value;
            }
            get { return _Value_2; }
        }

        private double _Value_3;
        /// <summary>
        /// Фоновая концентрация этой примеси в реке Sф, г/л
        /// </summary> 
        public double Value_3
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода фоновой концентрации этой примеси в реке Sф");
                else if (_Value_3 != value)
                    _Value_3 = value;
            }
            get { return _Value_3; }
        }

        private double _Value_4;
        /// <summary>
        /// В, м
        /// </summary> 
        public double Value_4
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода В, м");
                else if (_Value_4 != value)
                    _Value_4 = value;
            }
            get { return _Value_4; }
        }

        private double _Value_5;
        /// <summary>
        /// Н, м
        /// </summary> 
        public double Value_5
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода Н, м");
                else if (_Value_5 != value)
                    _Value_5 = value;
            }
            get { return _Value_5; }
        }

        private double _Value_6;
        /// <summary>
        /// V, м/с
        /// </summary> 
        public double Value_6
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода V, м/с");
                else if (_Value_6 != value)
                    _Value_6 = value;
            }
            get { return _Value_6; }
        }

        private double _Value_7;
        /// <summary>
        /// С, м1/2/с
        /// </summary> 
        public double Value_7
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода С, м1/2/с");
                else if (_Value_7 != value)
                    _Value_7 = value;
            }
            get { return _Value_7; }
        }

        private double _Value_8;
        /// <summary>
        /// Расстояние, ниже X, м
        /// </summary> 
        public double Value_8
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода Расстояние, ниже X, м");
                else if (_Value_8 != value)
                    _Value_8 = value;
            }
            get { return _Value_8; }
        }

        private double _Value_9;
        /// <summary>
        /// Расстояние от берега A, м
        /// </summary> 
        public double Value_9
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода Расстояние от берега A, м");
                else if (_Value_9 != value)
                    _Value_9 = value;
            }
            get { return _Value_9; }
        }

        private double _Value_10;
        /// <summary>
        /// Расстояние от поверхности реки A1, м
        /// </summary> 
        public double Value_10
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода Расстояние от поверхности реки A1, м");
                else if (_Value_10 != value)
                    _Value_10 = value;
            }
            get { return _Value_10; }
        }

        private double _Value_11;
        /// <summary>
        /// Постоянная (9.8)
        /// </summary> 
        public double Value_11
        {
            set { _Value_11 = value; }
            get { return _Value_11; }
        }

        private double _Value_12;
        /// <summary>
        /// Фоновая концентрация Sp, мг/м3
        /// </summary> 
        public double Value_12
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода Фоновая концентрация Sp, мг/м3");
                else if (_Value_12 != value)
                    _Value_12 = value;
            }
            get { return _Value_12; }
        }

        private double _Value_13;
        /// <summary>
        /// Поскольку примесь консервативная, то К1 = 0
        /// </summary> 
        public double Value_13
        {
            set { _Value_13 = value; }
            get { return _Value_13; }
        }
        #endregion - ИСХОДНЫЕ ДАННЫЕ

        #region - РАСЧЕТНЫЕ ПОКАЗАТЕЛИ



        /// <summary>
        /// Коэффициент P
        /// </summary>
        public double Koef_P()
        {
            double _Koef_P;
            _Koef_P = 0.026 * Math.Sqrt(_Value_4) * Math.Sqrt(Math.Sqrt(2 * _Value_11)) / (_Value_7 * Math.Pow(_Value_5, 3.0 / 4.0));
            return _Koef_P;
        }


        /// <summary>
        /// Коэффициент a
        /// </summary>
        public double  Koef_a()
        {
            double _Koef_a;
            _Koef_a = _Value_4 / (((Math.Pow(2, 1.0 / 2.0) * (Math.Pow(Koef_P(), 1.0 / 2.0))) * (Math.Pow(_Value_8, 3.0 / 4.0))));
            return _Koef_a;
        }


        /// <summary>
        /// Коэффициент a1
        /// </summary>
        public double Koef_a1()
        {
            double _Koef_a1;
            _Koef_a1 = _Value_5 / (((Math.Pow(2, 1.0 / 2.0) * (Math.Pow(Koef_P(), 1.0 / 2.0))) * (Math.Pow(_Value_8, 3.0 / 4.0))));
            return _Koef_a1;
        }


        /// <summary>
        /// Координата y
        /// </summary>
        public double Koord_y()
        {
            double _Koord_y;
            _Koord_y = 2 - (_Value_5 / 2);
            return _Koord_y;
        }


        /// <summary>
        /// Координата z
        /// </summary>
        public double Koord_z()
        {
            double _Koord_z;
            _Koord_z = _Value_4 / 2 - _Value_9;
            return _Koord_z;
        }

        public double Integr1()
        {
            double Y(double t)
            {
                // return 1 / (1 + t * t); 
                return Math.Pow(2.71828182845904, ((-Math.Pow(t, 2)) / 2));
                // return Math.Pow(2.7,Math.Pow(-p,2)/2); 
            }
            double x, a, b, h, s;
            int n;
            a = 0;
            b = Koef_a();
            n = 100000;
            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s = s + 4 * Y(x);
                x = x + h;
                s = s + 2 * Y(x);
                x = x + h;
            }
           return s = 2 / Math.Sqrt(2 * Math.PI) * h / 3 * (s + Y(a) - Y(b));
        }



        public double Integr2()
        {
            double Y(double t)
            {
                // return 1 / (1 + t * t); 
                return Math.Pow(2.71828182845904, ((-Math.Pow(t, 2)) / 2));
                // return Math.Pow(2.7,Math.Pow(-p,2)/2); 
            }
            double x, a, b, h, s;
            int n;
            a = 0;
            b = Koef_a1();
            n = 100000;
            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s = s + 4 * Y(x);
                x = x + h;
                s = s + 2 * Y(x);
                x = x + h;
            }
            return s = 2 / Math.Sqrt(2 * Math.PI) * h / 3 * (s + Y(a) - Y(b));
        }

        public double Rez()
        {
            double _Rez;
            _Rez = ((2 * _Value_1 * _Value_2) / (4 * Math.PI * _Value_6 * Koef_P() * (Math.Pow(_Value_8, 3 / 2)) * Integr2() * Integr1())) *
                (Math.Exp(-(((Koord_y() * Koord_y()) + ((Koord_z() * Koord_z())) / (Koef_P() * (Math.Pow(_Value_8, 3 / 2))))) - (_Value_13 * (_Value_8 / _Value_6)))) +
                (_Value_12 * (Math.Exp(-_Value_13 * (_Value_8 / _Value_6))));

            return Math.Round(_Rez, 4);
        }





        #endregion - РАСЧЕТНЫЕ ПОКАЗАТЕЛИ
    }
    }

