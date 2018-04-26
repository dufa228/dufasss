using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRiverLib;

namespace WindowsFormsApp4
{

    public partial class glavnaya : Form
    {

        WaterRiverLib.WaterRiverLib _wr = new WaterRiverLib.WaterRiverLib();

        public frmReportAll rep;



        public glavnaya()
        {
            InitializeComponent();
        }


        private void frmGavnaya_Load(object sender, EventArgs e)
        {

            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                WaterRiverLib.WaterRiverLib _wrr = new WaterRiverLib.WaterRiverLib();
                this._wr = _wrr.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений
                _wr.Value_1 = 0.5;
                _wr.Value_2 = 1;
                _wr.Value_3 = 0.0005;
                _wr.Value_4 = 308;
                _wr.Value_5 = 2.42;
                _wr.Value_6 = 0.18;
                _wr.Value_7 = 8.6;
                _wr.Value_8 = 1000;
                _wr.Value_9 = 70;
                _wr.Value_10 = 2;
                _wr.Value_11 = 9.81;
                _wr.Value_12 = 0.0008;
                _wr.Value_13 = 0;
                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                _wr.SaveData(_wr, fileDefaultUserAppDataPath.ToString());
            }

            // Показать в заголовке главного окна номер текущей версии и пользвателя
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";

            txtValue_1.Text = _wr.Value_1.ToString();
            txtValue_2.Text = _wr.Value_2.ToString();
            txtValue_3.Text = _wr.Value_3.ToString();
            txtValue_4.Text = _wr.Value_4.ToString();
            txtValue_5.Text = _wr.Value_5.ToString();
            txtValue_6.Text = _wr.Value_6.ToString();
            txtValue_7.Text = _wr.Value_7.ToString();
            txtValue_8.Text = _wr.Value_8.ToString();
            txtValue_9.Text = _wr.Value_9.ToString();
            txtValue_10.Text = _wr.Value_10.ToString();
            //txtValue_11.Text = _Class1.Value_11.ToString();
            txtValue_12.Text = _wr.Value_12.ToString();
            txtValue_13.Text = _wr.Value_13.ToString();

            ViewRezultToForm();

            toolStripStatusLabel.Text = "Расчет выполнен успешно";
            statusStrip1.Refresh();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtValue_1.Text == "" || txtValue_1.Text == "" || txtValue_2.Text == "" || txtValue_3.Text == "" || txtValue_4.Text == "" || txtValue_5.Text == "" || txtValue_6.Text == "" || txtValue_7.Text == "" || txtValue_8.Text == "" || txtValue_9.Text == "" || txtValue_10.Text == "" || txtValue_12.Text == "")
            {
                MessageBox.Show("Ошибка! Не все поля заполнены. Перепроверьте вводимые данные!");

            }

            else
            {
                try
                {
                    _wr.Value_1 = Convert.ToDouble(txtValue_1.Text);
                    _wr.Value_2 = Convert.ToDouble(txtValue_2.Text);
                    _wr.Value_3 = Convert.ToDouble(txtValue_3.Text);
                    _wr.Value_4 = Convert.ToDouble(txtValue_4.Text);
                    _wr.Value_5 = Convert.ToDouble(txtValue_5.Text);
                    _wr.Value_6 = Convert.ToDouble(txtValue_6.Text);
                    _wr.Value_7 = Convert.ToDouble(txtValue_7.Text);
                    _wr.Value_8 = Convert.ToDouble(txtValue_8.Text);
                    _wr.Value_9 = Convert.ToDouble(txtValue_9.Text);
                    _wr.Value_10 = Convert.ToDouble(txtValue_10.Text);
                    //_Class1.Value_11 = Convert.ToDouble(txtValue_11.Text);
                    _wr.Value_12 = Convert.ToDouble(txtValue_12.Text);
                    _wr.Value_13 = Convert.ToDouble(txtValue_13.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                ViewRezultToForm();

                toolStripStatusLabel.Text = "Расчет выполнен успешно";
                statusStrip1.Refresh();
            }
        }

        private void ViewRezultToForm()
        {

            txtValue_14.Text = Math.Round(_wr.Koef_P(), 4).ToString();
            txtValue_15.Text = Math.Round(_wr.Koef_a(), 4).ToString();
            txtValue_16.Text = Math.Round(_wr.Koef_a1(), 4).ToString();

            txtValue_17.Text = Math.Round(_wr.Koord_y(), 4).ToString();
            txtValue_18.Text = Math.Round(_wr.Koord_z(), 4).ToString();

            txtValue_19.Text = Math.Round(_wr.Integr1(), 4).ToString();
            txtValue_20.Text = Math.Round(_wr.Integr2(), 4).ToString();
            txtValue_21.Text = Math.Round(_wr.Rez(), 4).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMetodichka form = new frmMetodichka();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateReportViewer();


            //FormRep rep = new FormRep();
            //rep.ShowDialog();
        }


        /// <summary>
        /// Создать отчет ReportViewer
        /// </summary>         
        private void CreateReportViewer()
        {
            rep = new frmReportAll();

            #region Подготовить данные для вывода в отчет

            List<cReportList> RepListInput = new List<cReportList>();

            RepListInput.Add(new cReportList("Расход сточных вод qo,м3/с", _wr.Value_1.ToString()));
            RepListInput.Add(new cReportList("Содержание консервативной примеси Sо, г/л", _wr.Value_2.ToString()));
            RepListInput.Add(new cReportList("Фоновая концентрация примеси в реке Sф, г/л", _wr.Value_3.ToString()));
            RepListInput.Add(new cReportList("В, м", _wr.Value_4.ToString()));
            RepListInput.Add(new cReportList("Н, м", _wr.Value_5.ToString()));
            RepListInput.Add(new cReportList("V, м/с", _wr.Value_6.ToString()));
            RepListInput.Add(new cReportList("С, м1/2/с", _wr.Value_7.ToString()));
            RepListInput.Add(new cReportList("Расстояние, ниже X, м", _wr.Value_8.ToString()));
            RepListInput.Add(new cReportList("Расстояние от берега A, м", _wr.Value_9.ToString()));
            RepListInput.Add(new cReportList("Расстояние от поверхности реки A1, м", _wr.Value_10.ToString()));
            RepListInput.Add(new cReportList("Фоновая концентрация Sp, мг/м3", _wr.Value_11.ToString()));
            RepListInput.Add(new cReportList("Поскольку примесь консервативная, то К1 = 0", _wr.Value_12.ToString()));


            List<cReportList> RepListOutput = new List<cReportList>();
            RepListOutput.Add(new cReportList("Коэффициент P", Math.Round(_wr.Koef_P(), 4).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент a1", Math.Round(_wr.Koef_a(), 4).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент a2", Math.Round(_wr.Koef_a1(), 4).ToString()));
            RepListOutput.Add(new cReportList("Координата y", _wr.Koord_y().ToString()));
            RepListOutput.Add(new cReportList("Координата z", _wr.Koord_z().ToString()));
            RepListOutput.Add(new cReportList("Интеграл вероятности Гаусса Фо,в(a)", Math.Round(_wr.Integr1(), 4).ToString()));
            RepListOutput.Add(new cReportList("Интеграл вероятности Гаусса Фо,н(a)", Math.Round(_wr.Integr2(), 4).ToString()));
            RepListOutput.Add(new cReportList("Концентрация примеси S, г/л", Math.Round(_wr.Rez(), 4).ToString()));


            #endregion Подготовить данные для вывода в отчет

            // Указать отчету источники данных                
            rep.cReportInputBindingSource.DataSource = RepListInput;
            rep.cReportOutputBindingSource.DataSource = RepListOutput;

            // Показать окно отчета на весь экран
            rep.WindowState = FormWindowState.Maximized;
            rep.ShowDialog(this);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            frmGraf form = new frmGraf(_wr);
            form.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClearRezult_TextChanged(object sender, EventArgs e)
        {

            if (txtValue_1.Text == "" || txtValue_1.Text == "" || txtValue_2.Text == "" || txtValue_3.Text == "" || txtValue_4.Text == "" || txtValue_5.Text == "" || txtValue_6.Text == "" || txtValue_7.Text == "" || txtValue_8.Text == "" || txtValue_9.Text == "" || txtValue_10.Text == "" || txtValue_12.Text == "")

            {
                toolStripStatusLabel.Text = "Ошибка! Не все поля заполнены. Перепроверьте вводимые данные!";
                statusStrip1.Refresh();


            }

            else
            {
                txtValue_14.Text = "";
                txtValue_15.Text = "";
                txtValue_16.Text = "";
                txtValue_17.Text = "";
                txtValue_18.Text = "";
                txtValue_19.Text = "";
                txtValue_20.Text = "";
                txtValue_21.Text = "";



                toolStripStatusLabel.Text = "Исходные данные скорректированы. Необходимо выпонить расчет!";
                statusStrip1.Refresh();
            }
        }

        private void txtValue_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_1.Text.Contains(",") || txtValue_1.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_2.Text.Contains(",") || txtValue_2.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void txtValue_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_3.Text.Contains(",") || txtValue_3.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void txtValue_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_4.Text.Contains(",") || txtValue_4.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_5.Text.Contains(",") || txtValue_5.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void txtValue_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_6.Text.Contains(",") || txtValue_6.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_7.Text.Contains(",") || txtValue_7.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_8.Text.Contains(",") || txtValue_8.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_9.Text.Contains(",") || txtValue_9.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void txtValue_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_10.Text.Contains(",") || txtValue_10.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValue_12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (txtValue_12.Text.Contains(",") || txtValue_12.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}

