namespace MatrixFilters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxRedHistogram = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreenHistogram = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlueHistogram = new System.Windows.Forms.PictureBox();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            this.buttonNewPicture = new System.Windows.Forms.Button();
            this.buttonRecalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearPolygonBrush = new System.Windows.Forms.Button();
            this.labelScrollValue = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.radioButtonPolygonBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonCircleBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonWholePicture = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxCustomFilter = new System.Windows.Forms.GroupBox();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCustomFiltr = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgesLaplace = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgesDiagonal = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgesHorizontal = new System.Windows.Forms.RadioButton();
            this.radioButtonEdgesVertical = new System.Windows.Forms.RadioButton();
            this.radioButtonBlurGauss = new System.Windows.Forms.RadioButton();
            this.radioButtonBlurBox3 = new System.Windows.Forms.RadioButton();
            this.radioButtonEmbossSouthEast = new System.Windows.Forms.RadioButton();
            this.radioButtonEmbossEast = new System.Windows.Forms.RadioButton();
            this.radioButtonMeanRemoval = new System.Windows.Forms.RadioButton();
            this.radioButtonSharpen = new System.Windows.Forms.RadioButton();
            this.radioButtonIdentity = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDivider = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAutomaticDividers = new System.Windows.Forms.CheckBox();
            this.numericUpDownMove = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxCustomFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRedHistogram
            // 
            this.pictureBoxRedHistogram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxRedHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRedHistogram.Location = new System.Drawing.Point(756, 13);
            this.pictureBoxRedHistogram.Name = "pictureBoxRedHistogram";
            this.pictureBoxRedHistogram.Size = new System.Drawing.Size(296, 178);
            this.pictureBoxRedHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedHistogram.TabIndex = 0;
            this.pictureBoxRedHistogram.TabStop = false;
            // 
            // pictureBoxGreenHistogram
            // 
            this.pictureBoxGreenHistogram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxGreenHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGreenHistogram.Location = new System.Drawing.Point(756, 264);
            this.pictureBoxGreenHistogram.Name = "pictureBoxGreenHistogram";
            this.pictureBoxGreenHistogram.Size = new System.Drawing.Size(296, 178);
            this.pictureBoxGreenHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreenHistogram.TabIndex = 1;
            this.pictureBoxGreenHistogram.TabStop = false;
            // 
            // pictureBoxBlueHistogram
            // 
            this.pictureBoxBlueHistogram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxBlueHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlueHistogram.Location = new System.Drawing.Point(756, 517);
            this.pictureBoxBlueHistogram.Name = "pictureBoxBlueHistogram";
            this.pictureBoxBlueHistogram.Size = new System.Drawing.Size(296, 178);
            this.pictureBoxBlueHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlueHistogram.TabIndex = 2;
            this.pictureBoxBlueHistogram.TabStop = false;
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPicture.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(719, 774);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPicture.TabIndex = 3;
            this.pictureBoxPicture.TabStop = false;
            this.pictureBoxPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPicture_Paint);
            // 
            // buttonNewPicture
            // 
            this.buttonNewPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNewPicture.Location = new System.Drawing.Point(835, 719);
            this.buttonNewPicture.Name = "buttonNewPicture";
            this.buttonNewPicture.Size = new System.Drawing.Size(134, 68);
            this.buttonNewPicture.TabIndex = 4;
            this.buttonNewPicture.Text = "Wczytaj nowy obrazek";
            this.buttonNewPicture.UseVisualStyleBackColor = true;
            this.buttonNewPicture.Click += new System.EventHandler(this.buttonNewPicture_Click);
            // 
            // buttonRecalculate
            // 
            this.buttonRecalculate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRecalculate.Location = new System.Drawing.Point(1092, 719);
            this.buttonRecalculate.Name = "buttonRecalculate";
            this.buttonRecalculate.Size = new System.Drawing.Size(142, 68);
            this.buttonRecalculate.TabIndex = 5;
            this.buttonRecalculate.Text = "Przelicz";
            this.buttonRecalculate.UseVisualStyleBackColor = true;
            this.buttonRecalculate.Click += new System.EventHandler(this.buttonRecalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.buttonClearPolygonBrush);
            this.groupBox1.Controls.Add(this.labelScrollValue);
            this.groupBox1.Controls.Add(this.trackBarRadius);
            this.groupBox1.Controls.Add(this.radioButtonPolygonBrush);
            this.groupBox1.Controls.Add(this.radioButtonCircleBrush);
            this.groupBox1.Controls.Add(this.radioButtonWholePicture);
            this.groupBox1.Location = new System.Drawing.Point(1058, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obszar działania filtra";
            // 
            // buttonClearPolygonBrush
            // 
            this.buttonClearPolygonBrush.Location = new System.Drawing.Point(119, 136);
            this.buttonClearPolygonBrush.Name = "buttonClearPolygonBrush";
            this.buttonClearPolygonBrush.Size = new System.Drawing.Size(75, 23);
            this.buttonClearPolygonBrush.TabIndex = 5;
            this.buttonClearPolygonBrush.Text = "Wyczyść";
            this.buttonClearPolygonBrush.UseVisualStyleBackColor = true;
            this.buttonClearPolygonBrush.Click += new System.EventHandler(this.buttonClearPolygonBrush_Click);
            // 
            // labelScrollValue
            // 
            this.labelScrollValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelScrollValue.AutoSize = true;
            this.labelScrollValue.Location = new System.Drawing.Point(200, 66);
            this.labelScrollValue.Name = "labelScrollValue";
            this.labelScrollValue.Size = new System.Drawing.Size(25, 13);
            this.labelScrollValue.TabIndex = 4;
            this.labelScrollValue.Text = "100";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.LargeChange = 50;
            this.trackBarRadius.Location = new System.Drawing.Point(7, 66);
            this.trackBarRadius.Maximum = 500;
            this.trackBarRadius.Minimum = 10;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(187, 45);
            this.trackBarRadius.SmallChange = 10;
            this.trackBarRadius.TabIndex = 3;
            this.trackBarRadius.TickFrequency = 50;
            this.trackBarRadius.Value = 100;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBarRadius_Scroll);
            // 
            // radioButtonPolygonBrush
            // 
            this.radioButtonPolygonBrush.AutoSize = true;
            this.radioButtonPolygonBrush.Location = new System.Drawing.Point(7, 136);
            this.radioButtonPolygonBrush.Name = "radioButtonPolygonBrush";
            this.radioButtonPolygonBrush.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPolygonBrush.TabIndex = 2;
            this.radioButtonPolygonBrush.Text = "Wielokąt";
            this.radioButtonPolygonBrush.UseVisualStyleBackColor = true;
            this.radioButtonPolygonBrush.CheckedChanged += new System.EventHandler(this.radioButtonBrush_CheckedChanged);
            // 
            // radioButtonCircleBrush
            // 
            this.radioButtonCircleBrush.AutoSize = true;
            this.radioButtonCircleBrush.Location = new System.Drawing.Point(7, 43);
            this.radioButtonCircleBrush.Name = "radioButtonCircleBrush";
            this.radioButtonCircleBrush.Size = new System.Drawing.Size(95, 17);
            this.radioButtonCircleBrush.TabIndex = 1;
            this.radioButtonCircleBrush.Text = "Pędzel kołowy";
            this.radioButtonCircleBrush.UseVisualStyleBackColor = true;
            this.radioButtonCircleBrush.CheckedChanged += new System.EventHandler(this.radioButtonBrush_CheckedChanged);
            // 
            // radioButtonWholePicture
            // 
            this.radioButtonWholePicture.AutoSize = true;
            this.radioButtonWholePicture.Checked = true;
            this.radioButtonWholePicture.Location = new System.Drawing.Point(7, 20);
            this.radioButtonWholePicture.Name = "radioButtonWholePicture";
            this.radioButtonWholePicture.Size = new System.Drawing.Size(76, 17);
            this.radioButtonWholePicture.TabIndex = 0;
            this.radioButtonWholePicture.TabStop = true;
            this.radioButtonWholePicture.Text = "Cały obraz";
            this.radioButtonWholePicture.UseVisualStyleBackColor = true;
            this.radioButtonWholePicture.CheckedChanged += new System.EventHandler(this.radioButtonBrush_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.numericUpDownMove);
            this.groupBox2.Controls.Add(this.checkBoxAutomaticDividers);
            this.groupBox2.Controls.Add(this.numericUpDownDivider);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBoxCustomFilter);
            this.groupBox2.Controls.Add(this.radioButtonCustomFiltr);
            this.groupBox2.Controls.Add(this.radioButtonEdgesLaplace);
            this.groupBox2.Controls.Add(this.radioButtonEdgesDiagonal);
            this.groupBox2.Controls.Add(this.radioButtonEdgesHorizontal);
            this.groupBox2.Controls.Add(this.radioButtonEdgesVertical);
            this.groupBox2.Controls.Add(this.radioButtonBlurGauss);
            this.groupBox2.Controls.Add(this.radioButtonBlurBox3);
            this.groupBox2.Controls.Add(this.radioButtonEmbossSouthEast);
            this.groupBox2.Controls.Add(this.radioButtonEmbossEast);
            this.groupBox2.Controls.Add(this.radioButtonMeanRemoval);
            this.groupBox2.Controls.Add(this.radioButtonSharpen);
            this.groupBox2.Controls.Add(this.radioButtonIdentity);
            this.groupBox2.Location = new System.Drawing.Point(1058, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 497);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybór filtra macierzowego";
            // 
            // groupBoxCustomFilter
            // 
            this.groupBoxCustomFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown9);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown8);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown6);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown5);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown7);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown4);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown3);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown2);
            this.groupBoxCustomFilter.Controls.Add(this.numericUpDown1);
            this.groupBoxCustomFilter.Enabled = false;
            this.groupBoxCustomFilter.Location = new System.Drawing.Point(6, 305);
            this.groupBoxCustomFilter.Name = "groupBoxCustomFilter";
            this.groupBoxCustomFilter.Size = new System.Drawing.Size(233, 101);
            this.groupBoxCustomFilter.TabIndex = 12;
            this.groupBoxCustomFilter.TabStop = false;
            this.groupBoxCustomFilter.Text = "Własny filtr";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(159, 72);
            this.numericUpDown9.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown9.TabIndex = 8;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(83, 72);
            this.numericUpDown8.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown8.TabIndex = 7;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(159, 46);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown6.TabIndex = 6;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(83, 46);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown5.TabIndex = 5;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(7, 72);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown7.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(7, 46);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown4.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(159, 20);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 20);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 20);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // radioButtonCustomFiltr
            // 
            this.radioButtonCustomFiltr.AutoSize = true;
            this.radioButtonCustomFiltr.Location = new System.Drawing.Point(7, 282);
            this.radioButtonCustomFiltr.Name = "radioButtonCustomFiltr";
            this.radioButtonCustomFiltr.Size = new System.Drawing.Size(62, 17);
            this.radioButtonCustomFiltr.TabIndex = 11;
            this.radioButtonCustomFiltr.TabStop = true;
            this.radioButtonCustomFiltr.Text = "Własny";
            this.radioButtonCustomFiltr.UseVisualStyleBackColor = true;
            this.radioButtonCustomFiltr.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEdgesLaplace
            // 
            this.radioButtonEdgesLaplace.AutoSize = true;
            this.radioButtonEdgesLaplace.Location = new System.Drawing.Point(7, 259);
            this.radioButtonEdgesLaplace.Name = "radioButtonEdgesLaplace";
            this.radioButtonEdgesLaplace.Size = new System.Drawing.Size(175, 17);
            this.radioButtonEdgesLaplace.TabIndex = 10;
            this.radioButtonEdgesLaplace.TabStop = true;
            this.radioButtonEdgesLaplace.Text = "Wykrywanie krawędzi (Laplace)";
            this.radioButtonEdgesLaplace.UseVisualStyleBackColor = true;
            this.radioButtonEdgesLaplace.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEdgesDiagonal
            // 
            this.radioButtonEdgesDiagonal.AutoSize = true;
            this.radioButtonEdgesDiagonal.Location = new System.Drawing.Point(7, 236);
            this.radioButtonEdgesDiagonal.Name = "radioButtonEdgesDiagonal";
            this.radioButtonEdgesDiagonal.Size = new System.Drawing.Size(172, 17);
            this.radioButtonEdgesDiagonal.TabIndex = 9;
            this.radioButtonEdgesDiagonal.TabStop = true;
            this.radioButtonEdgesDiagonal.Text = "Wykrywanie krawędzi (ukośne)";
            this.radioButtonEdgesDiagonal.UseVisualStyleBackColor = true;
            this.radioButtonEdgesDiagonal.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEdgesHorizontal
            // 
            this.radioButtonEdgesHorizontal.AutoSize = true;
            this.radioButtonEdgesHorizontal.Location = new System.Drawing.Point(7, 213);
            this.radioButtonEdgesHorizontal.Name = "radioButtonEdgesHorizontal";
            this.radioButtonEdgesHorizontal.Size = new System.Drawing.Size(176, 17);
            this.radioButtonEdgesHorizontal.TabIndex = 8;
            this.radioButtonEdgesHorizontal.TabStop = true;
            this.radioButtonEdgesHorizontal.Text = "Wykrywanie krawędzi (poziome)";
            this.radioButtonEdgesHorizontal.UseVisualStyleBackColor = true;
            this.radioButtonEdgesHorizontal.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEdgesVertical
            // 
            this.radioButtonEdgesVertical.AutoSize = true;
            this.radioButtonEdgesVertical.Location = new System.Drawing.Point(7, 190);
            this.radioButtonEdgesVertical.Name = "radioButtonEdgesVertical";
            this.radioButtonEdgesVertical.Size = new System.Drawing.Size(177, 17);
            this.radioButtonEdgesVertical.TabIndex = 7;
            this.radioButtonEdgesVertical.TabStop = true;
            this.radioButtonEdgesVertical.Text = "Wykrywanie krawędzi (pionowe)";
            this.radioButtonEdgesVertical.UseVisualStyleBackColor = true;
            this.radioButtonEdgesVertical.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonBlurGauss
            // 
            this.radioButtonBlurGauss.AutoSize = true;
            this.radioButtonBlurGauss.Location = new System.Drawing.Point(7, 167);
            this.radioButtonBlurGauss.Name = "radioButtonBlurGauss";
            this.radioButtonBlurGauss.Size = new System.Drawing.Size(110, 17);
            this.radioButtonBlurGauss.TabIndex = 6;
            this.radioButtonBlurGauss.TabStop = true;
            this.radioButtonBlurGauss.Text = "Rozmycie (Gauss)";
            this.radioButtonBlurGauss.UseVisualStyleBackColor = true;
            this.radioButtonBlurGauss.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonBlurBox3
            // 
            this.radioButtonBlurBox3.AutoSize = true;
            this.radioButtonBlurBox3.Location = new System.Drawing.Point(7, 144);
            this.radioButtonBlurBox3.Name = "radioButtonBlurBox3";
            this.radioButtonBlurBox3.Size = new System.Drawing.Size(71, 17);
            this.radioButtonBlurBox3.TabIndex = 5;
            this.radioButtonBlurBox3.TabStop = true;
            this.radioButtonBlurBox3.Text = "Rozmycie";
            this.radioButtonBlurBox3.UseVisualStyleBackColor = true;
            this.radioButtonBlurBox3.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEmbossSouthEast
            // 
            this.radioButtonEmbossSouthEast.AutoSize = true;
            this.radioButtonEmbossSouthEast.Location = new System.Drawing.Point(7, 121);
            this.radioButtonEmbossSouthEast.Name = "radioButtonEmbossSouthEast";
            this.radioButtonEmbossSouthEast.Size = new System.Drawing.Size(173, 17);
            this.radioButtonEmbossSouthEast.TabIndex = 4;
            this.radioButtonEmbossSouthEast.TabStop = true;
            this.radioButtonEmbossSouthEast.Text = "Wypuklenie (zachodni wschód)";
            this.radioButtonEmbossSouthEast.UseVisualStyleBackColor = true;
            this.radioButtonEmbossSouthEast.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonEmbossEast
            // 
            this.radioButtonEmbossEast.AutoSize = true;
            this.radioButtonEmbossEast.Location = new System.Drawing.Point(7, 98);
            this.radioButtonEmbossEast.Name = "radioButtonEmbossEast";
            this.radioButtonEmbossEast.Size = new System.Drawing.Size(127, 17);
            this.radioButtonEmbossEast.TabIndex = 3;
            this.radioButtonEmbossEast.TabStop = true;
            this.radioButtonEmbossEast.Text = "Wypuklenie (wschód)";
            this.radioButtonEmbossEast.UseVisualStyleBackColor = true;
            this.radioButtonEmbossEast.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonMeanRemoval
            // 
            this.radioButtonMeanRemoval.AutoSize = true;
            this.radioButtonMeanRemoval.Location = new System.Drawing.Point(7, 75);
            this.radioButtonMeanRemoval.Name = "radioButtonMeanRemoval";
            this.radioButtonMeanRemoval.Size = new System.Drawing.Size(97, 17);
            this.radioButtonMeanRemoval.TabIndex = 2;
            this.radioButtonMeanRemoval.TabStop = true;
            this.radioButtonMeanRemoval.Text = "Mean Removal";
            this.radioButtonMeanRemoval.UseVisualStyleBackColor = true;
            this.radioButtonMeanRemoval.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonSharpen
            // 
            this.radioButtonSharpen.AutoSize = true;
            this.radioButtonSharpen.Location = new System.Drawing.Point(7, 52);
            this.radioButtonSharpen.Name = "radioButtonSharpen";
            this.radioButtonSharpen.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSharpen.TabIndex = 1;
            this.radioButtonSharpen.TabStop = true;
            this.radioButtonSharpen.Text = "Wyostrzenie";
            this.radioButtonSharpen.UseVisualStyleBackColor = true;
            this.radioButtonSharpen.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // radioButtonIdentity
            // 
            this.radioButtonIdentity.AutoSize = true;
            this.radioButtonIdentity.Checked = true;
            this.radioButtonIdentity.Location = new System.Drawing.Point(7, 29);
            this.radioButtonIdentity.Name = "radioButtonIdentity";
            this.radioButtonIdentity.Size = new System.Drawing.Size(88, 17);
            this.radioButtonIdentity.TabIndex = 0;
            this.radioButtonIdentity.TabStop = true;
            this.radioButtonIdentity.Text = "Identyczność";
            this.radioButtonIdentity.UseVisualStyleBackColor = true;
            this.radioButtonIdentity.CheckedChanged += new System.EventHandler(this.radioButtonFilter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Przesunięcie";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dzielnik";
            // 
            // numericUpDownDivider
            // 
            this.numericUpDownDivider.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownDivider.DecimalPlaces = 8;
            this.numericUpDownDivider.Enabled = false;
            this.numericUpDownDivider.Location = new System.Drawing.Point(115, 441);
            this.numericUpDownDivider.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownDivider.Name = "numericUpDownDivider";
            this.numericUpDownDivider.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDivider.TabIndex = 16;
            this.numericUpDownDivider.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxAutomaticDividers
            // 
            this.checkBoxAutomaticDividers.AutoSize = true;
            this.checkBoxAutomaticDividers.Checked = true;
            this.checkBoxAutomaticDividers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutomaticDividers.Location = new System.Drawing.Point(19, 467);
            this.checkBoxAutomaticDividers.Name = "checkBoxAutomaticDividers";
            this.checkBoxAutomaticDividers.Size = new System.Drawing.Size(190, 17);
            this.checkBoxAutomaticDividers.TabIndex = 17;
            this.checkBoxAutomaticDividers.Text = "Automatyczne ustawianie dzielnika";
            this.checkBoxAutomaticDividers.UseVisualStyleBackColor = true;
            this.checkBoxAutomaticDividers.CheckedChanged += new System.EventHandler(this.checkBoxAutomaticDividers_CheckedChanged);
            // 
            // numericUpDownMove
            // 
            this.numericUpDownMove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownMove.Location = new System.Drawing.Point(115, 412);
            this.numericUpDownMove.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMove.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDownMove.Name = "numericUpDownMove";
            this.numericUpDownMove.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMove.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 799);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRecalculate);
            this.Controls.Add(this.buttonNewPicture);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.pictureBoxBlueHistogram);
            this.Controls.Add(this.pictureBoxGreenHistogram);
            this.Controls.Add(this.pictureBoxRedHistogram);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxCustomFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRedHistogram;
        private System.Windows.Forms.PictureBox pictureBoxGreenHistogram;
        private System.Windows.Forms.PictureBox pictureBoxBlueHistogram;
        private System.Windows.Forms.PictureBox pictureBoxPicture;
        private System.Windows.Forms.Button buttonNewPicture;
        private System.Windows.Forms.Button buttonRecalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.RadioButton radioButtonPolygonBrush;
        private System.Windows.Forms.RadioButton radioButtonCircleBrush;
        private System.Windows.Forms.RadioButton radioButtonWholePicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonBlurBox3;
        private System.Windows.Forms.RadioButton radioButtonEmbossSouthEast;
        private System.Windows.Forms.RadioButton radioButtonEmbossEast;
        private System.Windows.Forms.RadioButton radioButtonMeanRemoval;
        private System.Windows.Forms.RadioButton radioButtonSharpen;
        private System.Windows.Forms.RadioButton radioButtonIdentity;
        private System.Windows.Forms.Label labelScrollValue;
        private System.Windows.Forms.Button buttonClearPolygonBrush;
        private System.Windows.Forms.GroupBox groupBoxCustomFilter;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButtonCustomFiltr;
        private System.Windows.Forms.RadioButton radioButtonEdgesLaplace;
        private System.Windows.Forms.RadioButton radioButtonEdgesDiagonal;
        private System.Windows.Forms.RadioButton radioButtonEdgesHorizontal;
        private System.Windows.Forms.RadioButton radioButtonEdgesVertical;
        private System.Windows.Forms.RadioButton radioButtonBlurGauss;
        private System.Windows.Forms.NumericUpDown numericUpDownDivider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAutomaticDividers;
        private System.Windows.Forms.NumericUpDown numericUpDownMove;
    }
}

