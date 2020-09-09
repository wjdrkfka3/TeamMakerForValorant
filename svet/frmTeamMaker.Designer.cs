namespace svet
{
    partial class frmTeamMaker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamMaker));
            this.btnGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_num5 = new System.Windows.Forms.Label();
            this.lbl_num4 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_num10 = new System.Windows.Forms.Label();
            this.lbl_num9 = new System.Windows.Forms.Label();
            this.lbl_num8 = new System.Windows.Forms.Label();
            this.lbl_num7 = new System.Windows.Forms.Label();
            this.lbl_num6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lbl_num15 = new System.Windows.Forms.Label();
            this.lbl_num14 = new System.Windows.Forms.Label();
            this.lbl_num13 = new System.Windows.Forms.Label();
            this.lbl_num12 = new System.Windows.Forms.Label();
            this.lbl_num11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_num20 = new System.Windows.Forms.Label();
            this.lbl_num19 = new System.Windows.Forms.Label();
            this.lbl_num18 = new System.Windows.Forms.Label();
            this.lbl_num17 = new System.Windows.Forms.Label();
            this.lbl_num16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbox_10 = new System.Windows.Forms.GroupBox();
            this.gbox_20 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_map2 = new System.Windows.Forms.Label();
            this.lbl_map1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnDelPlayer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbox_10.SuspendLayout();
            this.gbox_20.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerator
            // 
            this.btnGenerator.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGenerator.Location = new System.Drawing.Point(195, 204);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(180, 40);
            this.btnGenerator.TabIndex = 2;
            this.btnGenerator.Text = "팀 생성하기";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "참여 인원 설정 : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(122, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "10";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_num5);
            this.groupBox1.Controls.Add(this.lbl_num4);
            this.groupBox1.Controls.Add(this.lbl_num3);
            this.groupBox1.Controls.Add(this.lbl_num2);
            this.groupBox1.Controls.Add(this.lbl_num1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 150);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team #1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "공격";
            this.label8.Visible = false;
            // 
            // lbl_num5
            // 
            this.lbl_num5.AutoSize = true;
            this.lbl_num5.Location = new System.Drawing.Point(7, 122);
            this.lbl_num5.Name = "lbl_num5";
            this.lbl_num5.Size = new System.Drawing.Size(0, 15);
            this.lbl_num5.TabIndex = 11;
            // 
            // lbl_num4
            // 
            this.lbl_num4.AutoSize = true;
            this.lbl_num4.Location = new System.Drawing.Point(7, 95);
            this.lbl_num4.Name = "lbl_num4";
            this.lbl_num4.Size = new System.Drawing.Size(0, 15);
            this.lbl_num4.TabIndex = 10;
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Location = new System.Drawing.Point(7, 67);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(0, 15);
            this.lbl_num3.TabIndex = 9;
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(7, 42);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(0, 15);
            this.lbl_num2.TabIndex = 8;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(51, 18);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(0, 15);
            this.lbl_num1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "팀장 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.lbl_num10);
            this.groupBox2.Controls.Add(this.lbl_num9);
            this.groupBox2.Controls.Add(this.lbl_num8);
            this.groupBox2.Controls.Add(this.lbl_num7);
            this.groupBox2.Controls.Add(this.lbl_num6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(160, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team #2";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(81, 137);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 15);
            this.label30.TabIndex = 43;
            this.label30.Text = "수비";
            this.label30.Visible = false;
            // 
            // lbl_num10
            // 
            this.lbl_num10.AutoSize = true;
            this.lbl_num10.Location = new System.Drawing.Point(6, 121);
            this.lbl_num10.Name = "lbl_num10";
            this.lbl_num10.Size = new System.Drawing.Size(0, 15);
            this.lbl_num10.TabIndex = 11;
            // 
            // lbl_num9
            // 
            this.lbl_num9.AutoSize = true;
            this.lbl_num9.Location = new System.Drawing.Point(6, 94);
            this.lbl_num9.Name = "lbl_num9";
            this.lbl_num9.Size = new System.Drawing.Size(0, 15);
            this.lbl_num9.TabIndex = 10;
            // 
            // lbl_num8
            // 
            this.lbl_num8.AutoSize = true;
            this.lbl_num8.Location = new System.Drawing.Point(6, 66);
            this.lbl_num8.Name = "lbl_num8";
            this.lbl_num8.Size = new System.Drawing.Size(0, 15);
            this.lbl_num8.TabIndex = 9;
            // 
            // lbl_num7
            // 
            this.lbl_num7.AutoSize = true;
            this.lbl_num7.Location = new System.Drawing.Point(6, 41);
            this.lbl_num7.Name = "lbl_num7";
            this.lbl_num7.Size = new System.Drawing.Size(0, 15);
            this.lbl_num7.TabIndex = 8;
            // 
            // lbl_num6
            // 
            this.lbl_num6.AutoSize = true;
            this.lbl_num6.Location = new System.Drawing.Point(50, 17);
            this.lbl_num6.Name = "lbl_num6";
            this.lbl_num6.Size = new System.Drawing.Size(0, 15);
            this.lbl_num6.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "팀장 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.lbl_num15);
            this.groupBox3.Controls.Add(this.lbl_num14);
            this.groupBox3.Controls.Add(this.lbl_num13);
            this.groupBox3.Controls.Add(this.lbl_num12);
            this.groupBox3.Controls.Add(this.lbl_num11);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Team #3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(81, 137);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 15);
            this.label29.TabIndex = 43;
            this.label29.Text = "공격";
            this.label29.Visible = false;
            // 
            // lbl_num15
            // 
            this.lbl_num15.AutoSize = true;
            this.lbl_num15.Location = new System.Drawing.Point(6, 121);
            this.lbl_num15.Name = "lbl_num15";
            this.lbl_num15.Size = new System.Drawing.Size(0, 15);
            this.lbl_num15.TabIndex = 11;
            // 
            // lbl_num14
            // 
            this.lbl_num14.AutoSize = true;
            this.lbl_num14.Location = new System.Drawing.Point(6, 94);
            this.lbl_num14.Name = "lbl_num14";
            this.lbl_num14.Size = new System.Drawing.Size(0, 15);
            this.lbl_num14.TabIndex = 10;
            // 
            // lbl_num13
            // 
            this.lbl_num13.AutoSize = true;
            this.lbl_num13.Location = new System.Drawing.Point(6, 66);
            this.lbl_num13.Name = "lbl_num13";
            this.lbl_num13.Size = new System.Drawing.Size(0, 15);
            this.lbl_num13.TabIndex = 9;
            // 
            // lbl_num12
            // 
            this.lbl_num12.AutoSize = true;
            this.lbl_num12.Location = new System.Drawing.Point(6, 41);
            this.lbl_num12.Name = "lbl_num12";
            this.lbl_num12.Size = new System.Drawing.Size(0, 15);
            this.lbl_num12.TabIndex = 8;
            // 
            // lbl_num11
            // 
            this.lbl_num11.AutoSize = true;
            this.lbl_num11.Location = new System.Drawing.Point(50, 17);
            this.lbl_num11.Name = "lbl_num11";
            this.lbl_num11.Size = new System.Drawing.Size(0, 15);
            this.lbl_num11.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 15);
            this.label22.TabIndex = 6;
            this.label22.Text = "팀장 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.lbl_num20);
            this.groupBox4.Controls.Add(this.lbl_num19);
            this.groupBox4.Controls.Add(this.lbl_num18);
            this.groupBox4.Controls.Add(this.lbl_num17);
            this.groupBox4.Controls.Add(this.lbl_num16);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Location = new System.Drawing.Point(160, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 150);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Team #4";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(81, 137);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 15);
            this.label31.TabIndex = 44;
            this.label31.Text = "수비";
            this.label31.Visible = false;
            // 
            // lbl_num20
            // 
            this.lbl_num20.AutoSize = true;
            this.lbl_num20.Location = new System.Drawing.Point(6, 121);
            this.lbl_num20.Name = "lbl_num20";
            this.lbl_num20.Size = new System.Drawing.Size(0, 15);
            this.lbl_num20.TabIndex = 11;
            // 
            // lbl_num19
            // 
            this.lbl_num19.AutoSize = true;
            this.lbl_num19.Location = new System.Drawing.Point(6, 94);
            this.lbl_num19.Name = "lbl_num19";
            this.lbl_num19.Size = new System.Drawing.Size(0, 15);
            this.lbl_num19.TabIndex = 10;
            // 
            // lbl_num18
            // 
            this.lbl_num18.AutoSize = true;
            this.lbl_num18.Location = new System.Drawing.Point(6, 66);
            this.lbl_num18.Name = "lbl_num18";
            this.lbl_num18.Size = new System.Drawing.Size(0, 15);
            this.lbl_num18.TabIndex = 9;
            // 
            // lbl_num17
            // 
            this.lbl_num17.AutoSize = true;
            this.lbl_num17.Location = new System.Drawing.Point(6, 41);
            this.lbl_num17.Name = "lbl_num17";
            this.lbl_num17.Size = new System.Drawing.Size(0, 15);
            this.lbl_num17.TabIndex = 8;
            // 
            // lbl_num16
            // 
            this.lbl_num16.AutoSize = true;
            this.lbl_num16.Location = new System.Drawing.Point(50, 17);
            this.lbl_num16.Name = "lbl_num16";
            this.lbl_num16.Size = new System.Drawing.Size(0, 15);
            this.lbl_num16.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "팀장 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "VS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "VS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbox_10
            // 
            this.gbox_10.Controls.Add(this.groupBox1);
            this.gbox_10.Controls.Add(this.groupBox2);
            this.gbox_10.Controls.Add(this.label2);
            this.gbox_10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbox_10.Location = new System.Drawing.Point(245, 286);
            this.gbox_10.Name = "gbox_10";
            this.gbox_10.Size = new System.Drawing.Size(277, 180);
            this.gbox_10.TabIndex = 17;
            this.gbox_10.TabStop = false;
            // 
            // gbox_20
            // 
            this.gbox_20.Controls.Add(this.groupBox3);
            this.gbox_20.Controls.Add(this.groupBox4);
            this.gbox_20.Controls.Add(this.label4);
            this.gbox_20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbox_20.Location = new System.Drawing.Point(245, 471);
            this.gbox_20.Name = "gbox_20";
            this.gbox_20.Size = new System.Drawing.Size(277, 180);
            this.gbox_20.TabIndex = 18;
            this.gbox_20.TabStop = false;
            this.gbox_20.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_map2);
            this.groupBox5.Controls.Add(this.lbl_map1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(405, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 71);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "맵 선택";
            // 
            // lbl_map2
            // 
            this.lbl_map2.AutoSize = true;
            this.lbl_map2.Location = new System.Drawing.Point(60, 46);
            this.lbl_map2.Name = "lbl_map2";
            this.lbl_map2.Size = new System.Drawing.Size(0, 15);
            this.lbl_map2.TabIndex = 3;
            // 
            // lbl_map1
            // 
            this.lbl_map1.AutoSize = true;
            this.lbl_map1.Location = new System.Drawing.Point(60, 21);
            this.lbl_map1.Name = "lbl_map1";
            this.lbl_map1.Size = new System.Drawing.Size(0, 15);
            this.lbl_map1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "2경기 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "1경기 : ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.Location = new System.Drawing.Point(468, 194);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 15);
            this.label32.TabIndex = 42;
            this.label32.Text = "Ver 1.0";
            // 
            // lstPlayer
            // 
            this.lstPlayer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.ItemHeight = 15;
            this.lstPlayer.Location = new System.Drawing.Point(12, 293);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(227, 334);
            this.lstPlayer.TabIndex = 43;
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAddName.Location = new System.Drawing.Point(12, 267);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 23);
            this.txtAddName.TabIndex = 44;
            this.txtAddName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddName_KeyDown);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddPlayer.Location = new System.Drawing.Point(116, 267);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(60, 23);
            this.btnAddPlayer.TabIndex = 45;
            this.btnAddPlayer.Text = "추가";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnDelPlayer
            // 
            this.btnDelPlayer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelPlayer.Location = new System.Drawing.Point(179, 267);
            this.btnDelPlayer.Name = "btnDelPlayer";
            this.btnDelPlayer.Size = new System.Drawing.Size(60, 23);
            this.btnDelPlayer.TabIndex = 46;
            this.btnDelPlayer.Text = "삭제";
            this.btnDelPlayer.UseVisualStyleBackColor = true;
            this.btnDelPlayer.Click += new System.EventHandler(this.btnDelPlayer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(162, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "명";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(103, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "현재 추가된 인원 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(212, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "0 명";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::svet.Properties.Resources.svet클랜발로라느내전;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 167);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmTeamMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 658);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lstPlayer);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbox_20);
            this.Controls.Add(this.gbox_10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeamMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sVeT 클랜 발로란트 내전 팀 생성기 by 옹피";
            this.Load += new System.EventHandler(this.frmTeamMaker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbox_10.ResumeLayout(false);
            this.gbox_10.PerformLayout();
            this.gbox_20.ResumeLayout(false);
            this.gbox_20.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbox_10;
        private System.Windows.Forms.GroupBox gbox_20;
        private System.Windows.Forms.Label lbl_num5;
        private System.Windows.Forms.Label lbl_num4;
        private System.Windows.Forms.Label lbl_num3;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_num10;
        private System.Windows.Forms.Label lbl_num9;
        private System.Windows.Forms.Label lbl_num8;
        private System.Windows.Forms.Label lbl_num7;
        private System.Windows.Forms.Label lbl_num6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_num15;
        private System.Windows.Forms.Label lbl_num14;
        private System.Windows.Forms.Label lbl_num13;
        private System.Windows.Forms.Label lbl_num12;
        private System.Windows.Forms.Label lbl_num11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_num20;
        private System.Windows.Forms.Label lbl_num19;
        private System.Windows.Forms.Label lbl_num18;
        private System.Windows.Forms.Label lbl_num17;
        private System.Windows.Forms.Label lbl_num16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_map2;
        private System.Windows.Forms.Label lbl_map1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnDelPlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

