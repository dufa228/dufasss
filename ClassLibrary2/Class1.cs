using System;
using System.IO;

namespace ClassLibrary2
{
    [Serializable]
    public class Class1

    {
        #region -- Mетоды сериализации

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(Class1 hc, string NameFile)
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
        public Class1 LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла            
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            Class1 _hc = (Class1)myXMLFormat.Deserialize(myStreamB);
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
            set { if (value <= 0)
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
            set {
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
            set {
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
            return Math.Round(_Koef_P, 4);
        }


        /// <summary>
        /// Коэффициент a
        /// </summary>
        public double Koef_a()
        {
            double _Koef_a;
            _Koef_a = _Value_4 / (((Math.Pow(2, 1.0 / 2.0) * (Math.Pow(Koef_P(), 1.0 / 2.0))) * (Math.Pow(_Value_8, 3.0 / 4.0))));
            return Math.Round(_Koef_a, 4);
        }


        /// <summary>
        /// Коэффициент a1
        /// </summary>
        public double Koef_a1()
        {
            double _Koef_a1;
            _Koef_a1 = Math.Round(_Value_5 / (((Math.Pow(2, 1.0 / 2.0) * (Math.Pow(Koef_P(), 1.0 / 2.0))) * (Math.Pow(_Value_8, 3.0 / 4.0)))), 4);
            return _Koef_a1;
        }


        /// <summary>
        /// Координата y
        /// </summary>
        public double Koord_y()
        {
            double _Koord_y;
            _Koord_y = 2 - (_Value_5 / 2);
            return Math.Round((_Koord_y), 4);
        }


        /// <summary>
        /// Координата z
        /// </summary>
        public double Koord_z()
        {
            double _Koord_z;
            _Koord_z = _Value_4 / 2 - _Value_9;
            return Math.Round(_Koord_z, 4);
        }

        
            

        




        #endregion - РАСЧЕТНЫЕ ПОКАЗАТЕЛИ
    }
}

