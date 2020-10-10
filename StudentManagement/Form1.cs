using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        // Load가 실행 되었는지 확인용 boolean
        private bool loadCompleted_ = false;

        // 학생정보 입력 확인용 boolean
        private bool isWritten1_ = false;
        private bool isWritten2_ = false;
        private bool isWritten3_ = false;

        // 삭제 시 사용할 boolean
        private bool deleteStudent1_ = false;
        private bool deleteStudent2_ = false;
        private bool deleteStudent3_ = false;

        // 학생정보저장파일 및 세팅파일 이름 저장용 string
        string fileName = "student.bsh";
        string settingName = "setting.set";
        
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            // 저장 된 파일 없을 때 빈파일 생성
            if (!File.Exists(fileName))
            {
                BinaryWriter student_bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                student_bw.Close();
            }

            // 체크박스 설정용 세팅파일이 없을 때 초기파일(false) 생성
            if (!File.Exists(settingName))
            {
                BinaryWriter setting_bw = new BinaryWriter(new FileStream(settingName, FileMode.Create));
                setting_bw.Write(false);  // false = 체크해제
                setting_bw.Close();
            }

            // 기초 세팅(강의 중 작성)
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;

            labelCountStudent.Text = "0";

            BinaryReader setting_br = new BinaryReader(new FileStream(settingName, FileMode.Open));

            // 이전 체크박스가 체크되었다면, 체크박스 체크 후 Load 실행.
            if (setting_br.ReadBoolean() != false)
            {
                setting_br.Close();
                checkBoxLoadSetting.Checked = true;
                LoadStudent();
                return;
            }
            setting_br.Close();
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            loadCompleted_ = true;
        }

        #region Student 1 Event Handlers

        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent1Memo_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent1Name.Text = "학생정보없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.SelectedIndex = 0;
            textBoxStudent1Memo.Text = "";
            deleteStudent1_ = true;
            SaveStudent();
            return;
        }

        #endregion

        #region Student 2 Event Handlers

        private void textBoxStudent2Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent2ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void comboBoxStudent2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent2Memo_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent2Name.Text = "학생정보없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.SelectedIndex = 0;
            textBoxStudent2Memo.Text = "";
            deleteStudent2_ = true;
            SaveStudent();
            return;
        }

        #endregion

        #region Student 3 Event Handlers

        private void textBoxStudent3Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent3ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void comboBoxStudent3Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void textBoxStudent3Memo_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent3Name.Text = "학생정보없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.SelectedIndex = 0;
            textBoxStudent3Memo.Text = "";
            deleteStudent3_ = true;
            SaveStudent();
            return;
        }

        #endregion

        private void LoadStudent()
        {
            int student_count = 0; // 학생 수 카운트 초기화

            BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open));

            try
            {
                isWritten1_ = br.ReadBoolean();
                isWritten2_ = br.ReadBoolean();
                isWritten3_ = br.ReadBoolean();
            }
            catch   // 최초 실행 시
            {
                MessageBox.Show("저장된 데이터가 없습니다.");
            }

            if (isWritten1_ == true)
            {
                // 학생1 이름
                textBoxStudent1Name.Text = br.ReadString();

                // 학생1 학번
                textBoxStudent1ID.Text = Convert.ToString(br.ReadInt32());

                // 학생1 성별
                if (br.ReadInt32() == 0)
                    comboBoxStudent1Gender.SelectedIndex = 0;
                else
                    comboBoxStudent1Gender.SelectedIndex = 1;

                // 학생1 메모
                textBoxStudent1Memo.Text = br.ReadString();

                // 학생 수 추가
                student_count += 1;

                // 삭제용 boolean 초기화
                deleteStudent1_ = false;
            }

            if (isWritten2_ == true)
            {
                // 학생2 이름
                textBoxStudent2Name.Text = br.ReadString();

                // 학생2 학번
                textBoxStudent2ID.Text = Convert.ToString(br.ReadInt32());

                // 학생2 성별
                if (br.ReadInt32() == 0)
                    comboBoxStudent2Gender.SelectedIndex = 0;
                else
                    comboBoxStudent2Gender.SelectedIndex = 1;

                // 학생2 메모
                textBoxStudent2Memo.Text = br.ReadString();

                // 학생 수 추가
                student_count += 1;

                // 삭제용 boolean 초기화
                deleteStudent2_ = false;
            }
            if (isWritten3_ == true)
            {
                // 학생3 이름
                textBoxStudent3Name.Text = br.ReadString();

                // 학생3 학번
                textBoxStudent3ID.Text = Convert.ToString(br.ReadInt32());

                // 학생3 성별
                if (br.ReadInt32() == 0)
                    comboBoxStudent3Gender.SelectedIndex = 0;
                else
                    comboBoxStudent3Gender.SelectedIndex = 1;

                // 학생3 메모
                textBoxStudent3Memo.Text = br.ReadString();

                // 학생 수 추가
                student_count += 1;

                // 삭제용 boolean 초기화
                deleteStudent3_ = false;
            }
            labelCountStudent.Text = Convert.ToString(student_count);
            br.Close();
        }

        private void SaveStudent()
        {
            // Load 전 Save 무시
            if (loadCompleted_ == false)
                return;

            int count_1 = 0, count_2 = 0, count_3 = 0;

            // 학번이 입력 되었는지 확인
            if (textBoxStudent1ID.Text != "")
            {
                isWritten1_ = true;
                count_1 = 1;
            }
            else
                isWritten1_ = false;
            
            if (textBoxStudent2ID.Text != "")
            {
                isWritten2_ = true;
                count_2 = 1;
            }
            else
                isWritten2_ = false;

            if (textBoxStudent3ID.Text != "")
            {
                isWritten3_ = true;
                count_3 = 1;
            }
            else
                isWritten3_ = false;

            labelCountStudent.Text = Convert.ToString(count_1 + count_2 + count_3);

            BinaryWriter bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));

            // 학생정보 입력 확인용 bool값 기입
            bw.Write(isWritten1_);
            bw.Write(isWritten2_);
            bw.Write(isWritten3_);

            if (isWritten1_ == true || deleteStudent1_ == true)
            {
                try
                {
                    // 학생1 이름 기입
                    bw.Write(textBoxStudent1Name.Text);

                    // 학생1 학번 기입, 삭제 중이라면 Convert "" 에서 오류가 생기니 0 기입
                    if (deleteStudent1_ == true)
                        bw.Write(0);
                    else
                        bw.Write(Convert.ToInt32(textBoxStudent1ID.Text));

                    // 학생1 성별 기입 (0 = 남자, 1 = 여자)
                    if (comboBoxStudent1Gender.SelectedIndex == 0)
                        bw.Write(0);
                    else
                        bw.Write(1);

                    // 학생1 메모 기입
                    bw.Write(textBoxStudent1Memo.Text);
                }
                catch (System.FormatException) // 학번 기입란에 문자열 입력 시
                {
                    MessageBox.Show("형식에 맞춰 작성하세요");
                }
            }

            if (isWritten2_ == true || deleteStudent2_ == true)
            {
                try
                {
                    // 학생2 이름 기입
                    bw.Write(textBoxStudent2Name.Text);

                    // 학생2 학번 기입, 삭제 중이라면 Convert "" 에서 오류가 생기니 0 기입
                    if (deleteStudent2_ == true)
                        bw.Write(0);
                    else
                        bw.Write(Convert.ToInt32(textBoxStudent2ID.Text));

                    // 학생2 성별 기입 (0 = 남자, 1 = 여자)
                    if (comboBoxStudent2Gender.SelectedIndex == 0)
                        bw.Write(0);
                    else
                        bw.Write(1);

                    // 학생2 메모 기입
                    bw.Write(textBoxStudent2Memo.Text);
                }
                catch (System.FormatException) // 학번 기입란에 문자열 입력 시
                {
                    MessageBox.Show("형식에 맞춰 작성하세요");
                }
            }

            if (isWritten3_ == true || deleteStudent3_ == true)
            {
                try
                {
                    // 학생3 이름 기입
                    bw.Write(textBoxStudent3Name.Text);

                    // 학생3 학번 기입, 삭제 중이라면 Convert "" 에서 오류가 생기니 0 기입
                    if (deleteStudent3_ == true)
                        bw.Write(0);
                    else
                        bw.Write(Convert.ToInt32(textBoxStudent3ID.Text));

                    // 학생3 성별 기입 (0 = 남자, 1 = 여자)
                    if (comboBoxStudent3Gender.SelectedIndex == 0)
                        bw.Write(0);
                    else
                        bw.Write(1);

                    // 학생3 메모 기입
                    bw.Write(textBoxStudent3Memo.Text);
                }
                catch (System.FormatException) // 학번 기입란에 문자열 입력 시
                {
                    MessageBox.Show("형식에 맞춰 작성하세요");
                }
            }
            bw.Close();
        }

        /*
         
         */

        private void checkBoxLoadSetting_CheckedChanged(object sender, EventArgs e)
        {
            BinaryWriter setting_bw = new BinaryWriter(new FileStream(settingName, FileMode.Create));
            setting_bw.Write(checkBoxLoadSetting.Checked); // 체크 시 true, 아닐 시 false 
            setting_bw.Close();
        }
    }
}
