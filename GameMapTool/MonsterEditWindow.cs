using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GameMapTool
{
   
    public partial class MonsterEditWindow : Form
    {
        public List<MonsterAICommand> m_CmdDataList;
        public Dictionary<MonsterType, string> m_MonsterImgPath = new Dictionary<MonsterType, string>();
        private bool m_IsEdit;

        public MonsterEditWindow()
        {
            InitializeComponent();
            SetMonsterImgPath();
            SetCommandSelector();
            SetMonsterTypeSelector();
            m_IsEdit = false;
            m_CmdDataList = new List<MonsterAICommand>();
        }

        void SetCommandSelector()
        {
            CmdSelector.DisplayMember = "Name";
            CmdSelector.ValueMember = "Value";
            var Data = new[] {
                new CmdComboBoxItem{ Name="Idle", Value = MonsterAICommand.Idle },
                new CmdComboBoxItem{ Name="Move Right", Value = MonsterAICommand.Move_Right },
                new CmdComboBoxItem{ Name="Move Left", Value = MonsterAICommand.Move_Left },
                new CmdComboBoxItem{ Name="Jump", Value = MonsterAICommand.Jump },
            };
            CmdSelector.DataSource = Data;
            CmdSelector.SelectedIndex = 0;
        }

        void SetMonsterTypeSelector()
        {
            MonsterTypeSelector.DisplayMember = "Name";
            MonsterTypeSelector.ValueMember = "Value";
            var Data = new[] {
                new MonTypeComboBoxItem{ Name="Zen-Chan", Value = MonsterType.Zen_chan },
            };
            MonsterTypeSelector.DataSource = Data;
            MonsterTypeSelector.SelectedIndex = 0;
        }

        void SetMonsterImgPath()
        {
            String path = Path.GetFullPath(
               Path.Combine(Application.StartupPath + @"..\..\..\Bmp\")
              );
            m_MonsterImgPath.Add(MonsterType.Zen_chan, path + "Monster_Zenchan.png");
        }

        public void LoadMonsterToEdit(ref MonsterData monster)
        {
            m_IsEdit = true;

            MonsterIdInput.Text = monster.MonsterID;
            MonsterIdInput.Enabled = false;
            MonsterTypeSelector.SelectedItem = monster.type;
            InitXPos.Text = monster.startPos.X.ToString();
            InitYPos.Text = monster.startPos.Y.ToString();

            foreach (MonsterAICommand savedCmd in monster.Commands)
            {
                m_CmdDataList.Add(savedCmd);
                CommandList.Items.Add(savedCmd);
            }
        }


        private void CmdAddBtn_Click(object sender, EventArgs e)
        {
             CmdComboBoxItem selectedItem = (CmdComboBoxItem)CmdSelector.SelectedItem;

            int cmdIdx = CommandList.SelectedIndex + 1;
            int amount = Convert.ToInt32(CmdAmount.Text);

            for (int i = 0; i < amount; i++)
            {
                if (cmdIdx <= 0)
                {
                    CommandList.Items.Add(selectedItem.Name);
                    m_CmdDataList.Add(selectedItem.Value);
                }
                else
                {
                    CommandList.Items.Insert(cmdIdx, selectedItem.Name);
                    m_CmdDataList.Insert(cmdIdx, selectedItem.Value);
                }
            }
        }

        private void CmdDeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIdx =CommandList.SelectedIndex;
            var selectedItem = m_CmdDataList[selectedIdx];
            CommandList.Items.RemoveAt(selectedIdx);
            m_CmdDataList.Remove(selectedItem);
            CommandList.SelectedIndex = selectedIdx - 1;
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            string saveMonsterID = MonsterIdInput.Text;

            if (m_IsEdit == false)
            {
                if (saveMonsterID.Equals(""))
                {
                    MessageBox.Show("몬스터ID를 입력하세요");
                    return;
                }

                foreach (MonsterData monster in Form1.m_StageMonsters)
                {
                    if (monster.MonsterID.Equals(saveMonsterID))
                    {
                        MessageBox.Show("몬스터ID가 이미 존재하는 값입니다");
                        return;
                    }
                }
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void MonsterTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonTypeComboBoxItem selected = (MonTypeComboBoxItem)MonsterTypeSelector.SelectedItem;
            MonsterPic.Image = Image.FromFile(m_MonsterImgPath[selected.Value]);
        }
    }

    public class CmdComboBoxItem
    {
        public string Name { get; set; }
        public MonsterAICommand Value { get; set; }
    }

    public class MonTypeComboBoxItem
    {
        public string Name { get; set; }
        public MonsterType Value { get; set; }
    }
}
