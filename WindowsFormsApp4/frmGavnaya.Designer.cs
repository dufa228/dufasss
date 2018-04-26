namespace WindowsFormsApp4
{
    partial class glavnaya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue_3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue_5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValue_6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValue_7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValue_8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValue_9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValue_10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValue_14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValue_15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValue_16 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValue_17 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValue_18 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValue_19 = new System.Windows.Forms.TextBox();
            this.txtValue_20 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtValue_12 = new System.Windows.Forms.TextBox();
            this.txtValue_13 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtValue_21 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расход сточных вод qo,м3/с";
            // 
            // txtValue_1
            // 
            this.txtValue_1.Location = new System.Drawing.Point(461, 34);
            this.txtValue_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_1.Name = "txtValue_1";
            this.txtValue_1.Size = new System.Drawing.Size(112, 26);
            this.txtValue_1.TabIndex = 2;
            this.txtValue_1.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Содержание консервативной примеси Sо, г/л";
            // 
            // txtValue_2
            // 
            this.txtValue_2.Location = new System.Drawing.Point(461, 69);
            this.txtValue_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_2.Name = "txtValue_2";
            this.txtValue_2.Size = new System.Drawing.Size(112, 26);
            this.txtValue_2.TabIndex = 2;
            this.txtValue_2.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фоновая концентрация примеси в реке Sф, г/л";
            // 
            // txtValue_3
            // 
            this.txtValue_3.Location = new System.Drawing.Point(461, 104);
            this.txtValue_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_3.Name = "txtValue_3";
            this.txtValue_3.Size = new System.Drawing.Size(112, 26);
            this.txtValue_3.TabIndex = 2;
            this.txtValue_3.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "В, м";
            // 
            // txtValue_4
            // 
            this.txtValue_4.Location = new System.Drawing.Point(464, 19);
            this.txtValue_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_4.Name = "txtValue_4";
            this.txtValue_4.Size = new System.Drawing.Size(112, 26);
            this.txtValue_4.TabIndex = 2;
            this.txtValue_4.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Н, м";
            // 
            // txtValue_5
            // 
            this.txtValue_5.Location = new System.Drawing.Point(464, 54);
            this.txtValue_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_5.Name = "txtValue_5";
            this.txtValue_5.Size = new System.Drawing.Size(112, 26);
            this.txtValue_5.TabIndex = 2;
            this.txtValue_5.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "V, м/с";
            // 
            // txtValue_6
            // 
            this.txtValue_6.Location = new System.Drawing.Point(464, 89);
            this.txtValue_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_6.Name = "txtValue_6";
            this.txtValue_6.Size = new System.Drawing.Size(112, 26);
            this.txtValue_6.TabIndex = 2;
            this.txtValue_6.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_6_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "С, м1/2/с";
            // 
            // txtValue_7
            // 
            this.txtValue_7.Location = new System.Drawing.Point(464, 124);
            this.txtValue_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_7.Name = "txtValue_7";
            this.txtValue_7.Size = new System.Drawing.Size(112, 26);
            this.txtValue_7.TabIndex = 2;
            this.txtValue_7.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_7_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Расстояние, ниже X, м";
            // 
            // txtValue_8
            // 
            this.txtValue_8.Location = new System.Drawing.Point(461, 309);
            this.txtValue_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_8.Name = "txtValue_8";
            this.txtValue_8.Size = new System.Drawing.Size(112, 26);
            this.txtValue_8.TabIndex = 2;
            this.txtValue_8.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_8_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Расстояние от берега A, м";
            // 
            // txtValue_9
            // 
            this.txtValue_9.Location = new System.Drawing.Point(461, 344);
            this.txtValue_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_9.Name = "txtValue_9";
            this.txtValue_9.Size = new System.Drawing.Size(112, 26);
            this.txtValue_9.TabIndex = 2;
            this.txtValue_9.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_9_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Расстояние от поверхности реки A1, м";
            // 
            // txtValue_10
            // 
            this.txtValue_10.Location = new System.Drawing.Point(461, 379);
            this.txtValue_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_10.Name = "txtValue_10";
            this.txtValue_10.Size = new System.Drawing.Size(112, 26);
            this.txtValue_10.TabIndex = 2;
            this.txtValue_10.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_10_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Коэффициент P";
            // 
            // txtValue_14
            // 
            this.txtValue_14.Location = new System.Drawing.Point(187, 41);
            this.txtValue_14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_14.Name = "txtValue_14";
            this.txtValue_14.ReadOnly = true;
            this.txtValue_14.Size = new System.Drawing.Size(112, 26);
            this.txtValue_14.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Коэффициент a";
            // 
            // txtValue_15
            // 
            this.txtValue_15.Location = new System.Drawing.Point(187, 89);
            this.txtValue_15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_15.Name = "txtValue_15";
            this.txtValue_15.ReadOnly = true;
            this.txtValue_15.Size = new System.Drawing.Size(112, 26);
            this.txtValue_15.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Коэффициент a";
            // 
            // txtValue_16
            // 
            this.txtValue_16.Location = new System.Drawing.Point(187, 125);
            this.txtValue_16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_16.Name = "txtValue_16";
            this.txtValue_16.ReadOnly = true;
            this.txtValue_16.Size = new System.Drawing.Size(112, 26);
            this.txtValue_16.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Координата y";
            // 
            // txtValue_17
            // 
            this.txtValue_17.Location = new System.Drawing.Point(462, 86);
            this.txtValue_17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_17.Name = "txtValue_17";
            this.txtValue_17.ReadOnly = true;
            this.txtValue_17.Size = new System.Drawing.Size(112, 26);
            this.txtValue_17.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Координата z";
            // 
            // txtValue_18
            // 
            this.txtValue_18.Location = new System.Drawing.Point(462, 121);
            this.txtValue_18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_18.Name = "txtValue_18";
            this.txtValue_18.ReadOnly = true;
            this.txtValue_18.Size = new System.Drawing.Size(112, 26);
            this.txtValue_18.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(287, 100);
            this.label17.TabIndex = 0;
            this.label17.Text = "Осредненные гидравлические\r\nи морфологические характеристики\r\nреки на участке сме" +
    "шения\r\nпо расчетному расходу с учетом\r\nрасхода сточных вод.";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 782);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1059, 719);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(138, 35);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Рассчитать";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(660, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(298, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Интеграл вероятности Гаусса Фо,в(a)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(660, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(298, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Интеграл вероятности Гаусса Фо,н(a)";
            // 
            // txtValue_19
            // 
            this.txtValue_19.Location = new System.Drawing.Point(1005, 86);
            this.txtValue_19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_19.Name = "txtValue_19";
            this.txtValue_19.ReadOnly = true;
            this.txtValue_19.Size = new System.Drawing.Size(112, 26);
            this.txtValue_19.TabIndex = 2;
            // 
            // txtValue_20
            // 
            this.txtValue_20.Location = new System.Drawing.Point(1005, 125);
            this.txtValue_20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_20.Name = "txtValue_20";
            this.txtValue_20.ReadOnly = true;
            this.txtValue_20.Size = new System.Drawing.Size(112, 26);
            this.txtValue_20.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(263, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Фоновая концентрация Sp, мг/м3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 456);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(360, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Поскольку примесь консервативная, то К1 = 0";
            // 
            // txtValue_12
            // 
            this.txtValue_12.Location = new System.Drawing.Point(461, 414);
            this.txtValue_12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_12.Name = "txtValue_12";
            this.txtValue_12.Size = new System.Drawing.Size(112, 26);
            this.txtValue_12.TabIndex = 2;
            this.txtValue_12.TextChanged += new System.EventHandler(this.ClearRezult_TextChanged);
            this.txtValue_12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_12_KeyPress);
            // 
            // txtValue_13
            // 
            this.txtValue_13.Location = new System.Drawing.Point(461, 449);
            this.txtValue_13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_13.Name = "txtValue_13";
            this.txtValue_13.ReadOnly = true;
            this.txtValue_13.Size = new System.Drawing.Size(112, 26);
            this.txtValue_13.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(38, 726);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(230, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Концентрация примеси S, г/л";
            // 
            // txtValue_21
            // 
            this.txtValue_21.Location = new System.Drawing.Point(297, 726);
            this.txtValue_21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue_21.Name = "txtValue_21";
            this.txtValue_21.ReadOnly = true;
            this.txtValue_21.Size = new System.Drawing.Size(212, 26);
            this.txtValue_21.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtValue_12);
            this.groupBox1.Controls.Add(this.txtValue_13);
            this.groupBox1.Controls.Add(this.txtValue_10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtValue_9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtValue_8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtValue_3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValue_2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValue_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(631, 502);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValue_7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtValue_6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtValue_5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtValue_4);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(15, 139);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(594, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Характеристики реки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValue_18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtValue_17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtValue_20);
            this.groupBox2.Controls.Add(this.txtValue_16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtValue_15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtValue_19);
            this.groupBox2.Controls.Add(this.txtValue_14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(18, 516);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1179, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1009, 420);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "График";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 420);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Методичка ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.по;
            this.pictureBox1.Location = new System.Drawing.Point(666, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(839, 420);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Отчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 840);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // glavnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 862);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValue_21);
            this.Controls.Add(this.label22);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "glavnaya";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.frmGavnaya_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue_5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValue_6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValue_7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValue_8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValue_9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValue_10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValue_14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValue_15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValue_16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValue_17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValue_18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtValue_19;
        private System.Windows.Forms.TextBox txtValue_20;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtValue_12;
        private System.Windows.Forms.TextBox txtValue_13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtValue_21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

