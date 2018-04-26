using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using WaterRiverLib;

namespace WindowsFormsApp4
{
    public partial class frmGraf : Form
    {
        WaterRiverLib.WaterRiverLib wat = new WaterRiverLib.WaterRiverLib();
        public frmGraf(WaterRiverLib.WaterRiverLib _wr)
        {
            wat = _wr;
            InitializeComponent();
        }

        // Массив цветов, из которых будем выбирать случайным образом цвет для графика
        Color[] _colors = new Color[] {Color.Black,
            Color.Blue,
            Color.Brown,
            Color.Gray,
            Color.Green,
            Color.Indigo,
            Color.Orange,
            Color.Red,
            Color.YellowGreen};

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Для генерации случайных точек и случайного цвета кривой
            Random rnd = new Random();

            GraphPane pane = zedGraph.GraphPane;

            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = Convert.ToDouble(numericUpDown1.Value);
            double xmax = Convert.ToDouble(numericUpDown2.Value);

            // Заполняем список точек. Приращение по оси X тоже случайно
            for (
                double x = xmin;
                x <= xmax;
                x += rnd.NextDouble() * 10 + 1
                )
            {
                wat.Value_5 = x; 
                // Случайная координата по Y
                double y = wat.Koord_y() ;

                // добавим в список точку
                list.Add(x, y);
               
            }

            // Выберем случайный цвет для графика
            Color curveColor = _colors[rnd.Next(_colors.Length)];
            LineItem myCurve = pane.AddCurve("", list, curveColor, SymbolType.None);

            // Включим сглаживание
            myCurve.Line.IsSmooth = true;

            // Обновим график
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Генератор случайных чисел для выбора номера графика, который нужно удалить
            Random rnd = new Random();

            GraphPane pane = zedGraph.GraphPane;

            // Если есть что удалять
            if (pane.CurveList.Count > 0)
            {
                // Номер графика для удаления
                int index = rnd.Next(pane.CurveList.Count);

                // Удалим кривую по индексу
                pane.CurveList.RemoveAt(index);

                // Обновим график
                zedGraph.AxisChange();
                zedGraph.Invalidate();
            }
        }

        private void frmGraf_Load(object sender, EventArgs e)
        {

        }
    }
}
     
    

