using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameMapTool
{
    public partial class SaveWindow : Form
    {
        public SaveWindow()
        {
            InitializeComponent();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string fileName = fileNameInput.Text;

            //TODO: 파일명으로 올 수 없는 문자열이 올때 예외처리 하기
            if (fileName == "")
            {
                MessageBox.Show("파일명을 입력하세요");
            }
            else
            {
                Program.GetMainfrom().SetFileName(fileName);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
