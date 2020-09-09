using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace svet
{
    public partial class frmTeamMaker : Form
    {
        private List<Label> list_lbls = new List<Label>();

        public frmTeamMaker()
        {
            InitializeComponent();
            list_lbls.Add(lbl_num1);
            list_lbls.Add(lbl_num2);
            list_lbls.Add(lbl_num3);
            list_lbls.Add(lbl_num4);
            list_lbls.Add(lbl_num5);
            list_lbls.Add(lbl_num6);
            list_lbls.Add(lbl_num7);
            list_lbls.Add(lbl_num8);
            list_lbls.Add(lbl_num9);
            list_lbls.Add(lbl_num10);
            list_lbls.Add(lbl_num11);
            list_lbls.Add(lbl_num12);
            list_lbls.Add(lbl_num13);
            list_lbls.Add(lbl_num14);
            list_lbls.Add(lbl_num15);
            list_lbls.Add(lbl_num16);
            list_lbls.Add(lbl_num17);
            list_lbls.Add(lbl_num18);
            list_lbls.Add(lbl_num19);
            list_lbls.Add(lbl_num20);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gbox_20.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                gbox_20.Visible = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmTeamMaker_Load(object sender, EventArgs e)
        {
            Form myForm = new AboutBox1();
            myForm.ShowDialog();
        }
        
        private void listboxMix()
        {
            // 리스트 박스 랜덤 섞기

            ListBox.ObjectCollection list = lstPlayer.Items;
            Random rng = new Random();
            int n = list.Count;
            lstPlayer.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            lstPlayer.EndUpdate();
            lstPlayer.Invalidate();
        }

        private void AttackDefendView()
        {
            // 공격 수비 표시
            label8.Visible = true;
            label30.Visible = true;
            label29.Visible = true;
            label31.Visible = true;
        }

        private void  mapMix()
        {
            // 맵 랜덤하게 섞기 (중복X)
            Random r = new Random();
            int map_number1, map_number2;
            do
            {
                map_number1 = r.Next(1, 5);
                map_number2 = r.Next(1, 5);
            }
            while (map_number1 == map_number2);

            switch (map_number1)
            {
                case 1:
                    lbl_map1.Text = "스플릿";
                    break;
                case 2:
                    lbl_map1.Text = "바인드";
                    break;
                case 3:
                    lbl_map1.Text = "헤이븐";
                    break;
                case 4:
                    lbl_map1.Text = "어센트";
                    break;
            }
            switch (map_number2)
            {
                case 1:
                    lbl_map2.Text = "스플릿";
                    break;
                case 2:
                    lbl_map2.Text = "바인드";
                    break;
                case 3:
                    lbl_map2.Text = "헤이븐";
                    break;
                case 4:
                    lbl_map2.Text = "어센트";
                    break;
            }
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {            

            // 리스트 박스 내용을 레이블로 옮기기 (기능만 구현..)
            if (lstPlayer.Items.Count == 10)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("팀 생성을 완료했습니다.", "팀 생성 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listboxMix();

                    for (int i = 0; i<10; i++)
                    {
                        lstPlayer.SelectedIndex = i;
                        list_lbls[i].Text = lstPlayer.SelectedItem.ToString();
                    }
                    
                    AttackDefendView();
                    mapMix();
                }
                else
                {
                    MessageBox.Show("참여 인원을 설정한 값과 현재 추가한 인원 수가 다릅니다.", "현재 인원 수를 확인해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (lstPlayer.Items.Count == 20)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("팀 생성을 완료했습니다.", "팀 생성 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listboxMix();

                    for (int i = 0; i < 20; i++)
                    {
                        lstPlayer.SelectedIndex = i;
                        list_lbls[i].Text = lstPlayer.SelectedItem.ToString();
                    }

                    AttackDefendView();
                    mapMix();
                }
                else
                {
                    MessageBox.Show("참여 인원을 설정한 값과 현재 추가한 인원 수가 다릅니다.", "현재 인원 수를 확인해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("참여 인원을 모두 추가하지 않았거나, 더 많이 추가했습니다. \n현재 인원 수를 확인해주세요.", "현재 인원 수를 확인해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text != "")
            {
                string addplayer = txtAddName.Text;
                lstPlayer.Items.Add(addplayer);
                txtAddName.Text = "";
            }
            else
            {
                MessageBox.Show("닉네임을 네모칸에 입력 후 추가버튼을 눌러 추가해주세요.", "닉네임 입력을 입력해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            label3.Text = lstPlayer.Items.Count + " 명";
        }

        private void btnDelPlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 인원을 왼쪽 상자에서 선택해주세요.", "삭제할 인원을 선택해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int lstPlayer_Position = lstPlayer.SelectedIndex; // SelectedIndex == 0, Position == 0
                if (lstPlayer.Items.Count > 0)
                {
                    if (lstPlayer.SelectedIndex == 0)
                    {
                        lstPlayer.Items.Remove(lstPlayer.SelectedItem); // selecetedindex == -1, position == 0
                        if (lstPlayer.Items.Count>0)
                        {
                            lstPlayer.SelectedIndex = lstPlayer_Position;
                        }
                    }
                    else
                    {
                        lstPlayer.Items.Remove(lstPlayer.SelectedItem);
                        lstPlayer.SelectedIndex = lstPlayer_Position - 1;
                    }
                }
                label3.Text = lstPlayer.Items.Count + " 명";
            }
        }

        private void txtAddName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAddPlayer_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form myForm = new AboutBox1();
            myForm.ShowDialog();
        }
    }
}
