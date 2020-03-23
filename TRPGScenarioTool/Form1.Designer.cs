namespace TRPGScenarioTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newAllSave = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.fileDataClearButton = new System.Windows.Forms.Button();
            this.campaignName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scenarioName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.systemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.view = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.scenarioList = new System.Windows.Forms.ComboBox();
            this.systemList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.predataSave = new System.Windows.Forms.Button();
            this.preBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vsQ = new System.Windows.Forms.RadioButton();
            this.vsP = new System.Windows.Forms.RadioButton();
            this.vsE = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataName1 = new System.Windows.Forms.TextBox();
            this.dataName2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.RichTextBox();
            this.box2 = new System.Windows.Forms.RichTextBox();
            this.edit1 = new System.Windows.Forms.Button();
            this.dataList1 = new System.Windows.Forms.ComboBox();
            this.edit2 = new System.Windows.Forms.Button();
            this.dataList2 = new System.Windows.Forms.ComboBox();
            this.newData1 = new System.Windows.Forms.Button();
            this.newData2 = new System.Windows.Forms.Button();
            this.view1 = new System.Windows.Forms.Button();
            this.view2 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ho1 = new System.Windows.Forms.RadioButton();
            this.sc1 = new System.Windows.Forms.RadioButton();
            this.info1 = new System.Windows.Forms.RadioButton();
            this.data1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ho2 = new System.Windows.Forms.RadioButton();
            this.sc2 = new System.Windows.Forms.RadioButton();
            this.info2 = new System.Windows.Forms.RadioButton();
            this.data2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newAllSave);
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Controls.Add(this.fileDataClearButton);
            this.groupBox1.Controls.Add(this.campaignName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scenarioName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.systemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(200, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "フォルダ名生成用データ";
            // 
            // newAllSave
            // 
            this.newAllSave.Location = new System.Drawing.Point(346, 66);
            this.newAllSave.Name = "newAllSave";
            this.newAllSave.Size = new System.Drawing.Size(61, 20);
            this.newAllSave.TabIndex = 11;
            this.newAllSave.Text = "全体保存";
            this.newAllSave.UseVisualStyleBackColor = true;
            this.newAllSave.Click += new System.EventHandler(this.newAllSave_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(346, 41);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(61, 20);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "新規生成";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.New_Click);
            // 
            // fileDataClearButton
            // 
            this.fileDataClearButton.Location = new System.Drawing.Point(346, 16);
            this.fileDataClearButton.Name = "fileDataClearButton";
            this.fileDataClearButton.Size = new System.Drawing.Size(61, 20);
            this.fileDataClearButton.TabIndex = 9;
            this.fileDataClearButton.Text = "クリア";
            this.fileDataClearButton.UseVisualStyleBackColor = true;
            this.fileDataClearButton.Click += new System.EventHandler(this.FileDataClear_Click);
            // 
            // campaignName
            // 
            this.campaignName.Location = new System.Drawing.Point(85, 67);
            this.campaignName.Name = "campaignName";
            this.campaignName.Size = new System.Drawing.Size(241, 19);
            this.campaignName.TabIndex = 5;
            this.campaignName.Text = "単発";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "キャンペーン名";
            // 
            // scenarioName
            // 
            this.scenarioName.Location = new System.Drawing.Point(85, 42);
            this.scenarioName.Name = "scenarioName";
            this.scenarioName.Size = new System.Drawing.Size(241, 19);
            this.scenarioName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "シナリオ名";
            // 
            // systemName
            // 
            this.systemName.Location = new System.Drawing.Point(85, 17);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(241, 19);
            this.systemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "システム名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.view);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.scenarioList);
            this.groupBox2.Controls.Add(this.systemList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(638, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "既存フォルダ選択";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(358, 74);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(61, 20);
            this.view.TabIndex = 8;
            this.view.Text = "閲覧";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.View_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(277, 74);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(61, 20);
            this.edit.TabIndex = 7;
            this.edit.Text = "編集";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // scenarioList
            // 
            this.scenarioList.FormattingEnabled = true;
            this.scenarioList.Location = new System.Drawing.Point(67, 46);
            this.scenarioList.Name = "scenarioList";
            this.scenarioList.Size = new System.Drawing.Size(351, 20);
            this.scenarioList.TabIndex = 6;
            // 
            // systemList
            // 
            this.systemList.FormattingEnabled = true;
            this.systemList.Location = new System.Drawing.Point(67, 17);
            this.systemList.Name = "systemList";
            this.systemList.Size = new System.Drawing.Size(351, 20);
            this.systemList.TabIndex = 5;
            this.systemList.SelectedIndexChanged += new System.EventHandler(this.SystemList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "シナリオ名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "システム名";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.predataSave);
            this.groupBox3.Controls.Add(this.preBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.vsQ);
            this.groupBox3.Controls.Add(this.vsP);
            this.groupBox3.Controls.Add(this.vsE);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.num);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 444);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "予告欄";
            // 
            // predataSave
            // 
            this.predataSave.Location = new System.Drawing.Point(295, 54);
            this.predataSave.Name = "predataSave";
            this.predataSave.Size = new System.Drawing.Size(37, 23);
            this.predataSave.TabIndex = 42;
            this.predataSave.Text = "保存";
            this.predataSave.UseVisualStyleBackColor = true;
            this.predataSave.Click += new System.EventHandler(this.PredataSave_Click);
            // 
            // preBox
            // 
            this.preBox.Location = new System.Drawing.Point(7, 80);
            this.preBox.Name = "preBox";
            this.preBox.Size = new System.Drawing.Size(325, 357);
            this.preBox.TabIndex = 13;
            this.preBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "予告";
            // 
            // vsQ
            // 
            this.vsQ.AutoSize = true;
            this.vsQ.Location = new System.Drawing.Point(285, 22);
            this.vsQ.Name = "vsQ";
            this.vsQ.Size = new System.Drawing.Size(47, 16);
            this.vsQ.TabIndex = 11;
            this.vsQ.TabStop = true;
            this.vsQ.Text = "特殊";
            this.vsQ.UseVisualStyleBackColor = true;
            // 
            // vsP
            // 
            this.vsP.AutoSize = true;
            this.vsP.Location = new System.Drawing.Point(232, 22);
            this.vsP.Name = "vsP";
            this.vsP.Size = new System.Drawing.Size(47, 16);
            this.vsP.TabIndex = 10;
            this.vsP.TabStop = true;
            this.vsP.Text = "対立";
            this.vsP.UseVisualStyleBackColor = true;
            // 
            // vsE
            // 
            this.vsE.AutoSize = true;
            this.vsE.Location = new System.Drawing.Point(179, 22);
            this.vsE.Name = "vsE";
            this.vsE.Size = new System.Drawing.Size(47, 16);
            this.vsE.TabIndex = 9;
            this.vsE.TabStop = true;
            this.vsE.Text = "協力";
            this.vsE.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "形式";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(43, 22);
            this.num.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(52, 19);
            this.num.TabIndex = 7;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "人数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.Turquoise;
            this.label10.Location = new System.Drawing.Point(9, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "TRPGScenarioTool";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.Turquoise;
            this.label11.Location = new System.Drawing.Point(150, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "var:1.0";
            // 
            // dataName1
            // 
            this.dataName1.Location = new System.Drawing.Point(74, 47);
            this.dataName1.Name = "dataName1";
            this.dataName1.Size = new System.Drawing.Size(213, 19);
            this.dataName1.TabIndex = 6;
            // 
            // dataName2
            // 
            this.dataName2.Location = new System.Drawing.Point(432, 47);
            this.dataName2.Name = "dataName2";
            this.dataName2.Size = new System.Drawing.Size(213, 19);
            this.dataName2.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "データ名";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "データ名";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(27, 111);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(303, 326);
            this.box1.TabIndex = 28;
            this.box1.Text = "";
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(387, 111);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(303, 326);
            this.box2.TabIndex = 29;
            this.box2.Text = "";
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(293, 18);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(37, 23);
            this.edit1.TabIndex = 30;
            this.edit1.Text = "編集";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // dataList1
            // 
            this.dataList1.FormattingEnabled = true;
            this.dataList1.Location = new System.Drawing.Point(74, 20);
            this.dataList1.Name = "dataList1";
            this.dataList1.Size = new System.Drawing.Size(213, 20);
            this.dataList1.TabIndex = 31;
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(651, 19);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(37, 23);
            this.edit2.TabIndex = 32;
            this.edit2.Text = "編集";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // dataList2
            // 
            this.dataList2.FormattingEnabled = true;
            this.dataList2.Location = new System.Drawing.Point(432, 21);
            this.dataList2.Name = "dataList2";
            this.dataList2.Size = new System.Drawing.Size(213, 20);
            this.dataList2.TabIndex = 33;
            // 
            // newData1
            // 
            this.newData1.Location = new System.Drawing.Point(29, 45);
            this.newData1.Name = "newData1";
            this.newData1.Size = new System.Drawing.Size(37, 23);
            this.newData1.TabIndex = 34;
            this.newData1.Text = "新規";
            this.newData1.UseVisualStyleBackColor = true;
            this.newData1.Click += new System.EventHandler(this.newData1_Click);
            // 
            // newData2
            // 
            this.newData2.Location = new System.Drawing.Point(387, 46);
            this.newData2.Name = "newData2";
            this.newData2.Size = new System.Drawing.Size(37, 23);
            this.newData2.TabIndex = 35;
            this.newData2.Text = "新規";
            this.newData2.UseVisualStyleBackColor = true;
            this.newData2.Click += new System.EventHandler(this.newData2_Click);
            // 
            // view1
            // 
            this.view1.Location = new System.Drawing.Point(293, 45);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(37, 23);
            this.view1.TabIndex = 36;
            this.view1.Text = "閲覧";
            this.view1.UseVisualStyleBackColor = true;
            this.view1.Click += new System.EventHandler(this.view1_Click);
            // 
            // view2
            // 
            this.view2.Location = new System.Drawing.Point(651, 46);
            this.view2.Name = "view2";
            this.view2.Size = new System.Drawing.Size(37, 23);
            this.view2.TabIndex = 37;
            this.view2.Text = "閲覧";
            this.view2.UseVisualStyleBackColor = true;
            this.view2.Click += new System.EventHandler(this.view2_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(293, 80);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(37, 23);
            this.save1.TabIndex = 38;
            this.save1.Text = "保存";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(651, 81);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(37, 23);
            this.save2.TabIndex = 39;
            this.save2.Text = "保存";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ho1);
            this.groupBox5.Controls.Add(this.sc1);
            this.groupBox5.Controls.Add(this.info1);
            this.groupBox5.Controls.Add(this.data1);
            this.groupBox5.Location = new System.Drawing.Point(27, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 37);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "形式";
            // 
            // ho1
            // 
            this.ho1.AutoSize = true;
            this.ho1.Location = new System.Drawing.Point(6, 15);
            this.ho1.Name = "ho1";
            this.ho1.Size = new System.Drawing.Size(77, 16);
            this.ho1.TabIndex = 0;
            this.ho1.TabStop = true;
            this.ho1.Text = "ハンドアウト";
            this.ho1.UseVisualStyleBackColor = true;
            // 
            // sc1
            // 
            this.sc1.AutoSize = true;
            this.sc1.Location = new System.Drawing.Point(83, 15);
            this.sc1.Name = "sc1";
            this.sc1.Size = new System.Drawing.Size(52, 16);
            this.sc1.TabIndex = 15;
            this.sc1.TabStop = true;
            this.sc1.Text = "シーン";
            this.sc1.UseVisualStyleBackColor = true;
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(137, 15);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(47, 16);
            this.info1.TabIndex = 16;
            this.info1.TabStop = true;
            this.info1.Text = "情報";
            this.info1.UseVisualStyleBackColor = true;
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.Location = new System.Drawing.Point(185, 15);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(51, 16);
            this.data1.TabIndex = 17;
            this.data1.TabStop = true;
            this.data1.Text = "データ";
            this.data1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.save2);
            this.groupBox4.Controls.Add(this.save1);
            this.groupBox4.Controls.Add(this.view2);
            this.groupBox4.Controls.Add(this.view1);
            this.groupBox4.Controls.Add(this.newData2);
            this.groupBox4.Controls.Add(this.newData1);
            this.groupBox4.Controls.Add(this.dataList2);
            this.groupBox4.Controls.Add(this.edit2);
            this.groupBox4.Controls.Add(this.dataList1);
            this.groupBox4.Controls.Add(this.edit1);
            this.groupBox4.Controls.Add(this.box2);
            this.groupBox4.Controls.Add(this.box1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataName2);
            this.groupBox4.Controls.Add(this.dataName1);
            this.groupBox4.Location = new System.Drawing.Point(353, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 444);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "データ管理用";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ho2);
            this.groupBox6.Controls.Add(this.sc2);
            this.groupBox6.Controls.Add(this.info2);
            this.groupBox6.Controls.Add(this.data2);
            this.groupBox6.Location = new System.Drawing.Point(387, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 37);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "形式";
            // 
            // ho2
            // 
            this.ho2.AutoSize = true;
            this.ho2.Location = new System.Drawing.Point(6, 15);
            this.ho2.Name = "ho2";
            this.ho2.Size = new System.Drawing.Size(77, 16);
            this.ho2.TabIndex = 0;
            this.ho2.TabStop = true;
            this.ho2.Text = "ハンドアウト";
            this.ho2.UseVisualStyleBackColor = true;
            // 
            // sc2
            // 
            this.sc2.AutoSize = true;
            this.sc2.Location = new System.Drawing.Point(83, 15);
            this.sc2.Name = "sc2";
            this.sc2.Size = new System.Drawing.Size(52, 16);
            this.sc2.TabIndex = 15;
            this.sc2.TabStop = true;
            this.sc2.Text = "シーン";
            this.sc2.UseVisualStyleBackColor = true;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(137, 15);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(47, 16);
            this.info2.TabIndex = 16;
            this.info2.TabStop = true;
            this.info2.Text = "情報";
            this.info2.UseVisualStyleBackColor = true;
            // 
            // data2
            // 
            this.data2.AutoSize = true;
            this.data2.Location = new System.Drawing.Point(185, 15);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(51, 16);
            this.data2.TabIndex = 17;
            this.data2.TabStop = true;
            this.data2.Text = "データ";
            this.data2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TRPGScenarioTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campaignName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scenarioName;
        private System.Windows.Forms.TextBox systemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ComboBox scenarioList;
        private System.Windows.Forms.ComboBox systemList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton vsE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox preBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton vsQ;
        private System.Windows.Forms.RadioButton vsP;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button fileDataClearButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button newAllSave;
        private System.Windows.Forms.TextBox dataName1;
        private System.Windows.Forms.TextBox dataName2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox box1;
        private System.Windows.Forms.RichTextBox box2;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.ComboBox dataList1;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.ComboBox dataList2;
        private System.Windows.Forms.Button newData1;
        private System.Windows.Forms.Button newData2;
        private System.Windows.Forms.Button view1;
        private System.Windows.Forms.Button view2;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton ho1;
        private System.Windows.Forms.RadioButton sc1;
        private System.Windows.Forms.RadioButton info1;
        private System.Windows.Forms.RadioButton data1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton ho2;
        private System.Windows.Forms.RadioButton sc2;
        private System.Windows.Forms.RadioButton info2;
        private System.Windows.Forms.RadioButton data2;
        private System.Windows.Forms.Button predataSave;
    }
}

