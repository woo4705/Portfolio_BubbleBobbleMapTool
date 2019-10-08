using Google.Protobuf;
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
using static StageDataReflection;
using static WholeStageData.Types;

namespace GameMapTool
{
    public partial class Form1 : Form
    {
        static private string m_fileName ="";
        static public bool m_isNewFile { get; set; } = false;
        FileStream m_fileStream;
        static public MonsterData m_MonsterBuffer;
        static public List<MonsterData> m_StageMonsters;

        public void SetFileName(string s)
        {
            m_fileName = s;
        }

        string m_filePath { get;  } = Path.GetFullPath(
               Path.Combine(Application.StartupPath + @"..\..\..\..\..\BubbleBobbleImitation\Include\DataFile\")
              );
        //파일을 로딩하면 세팅함
        public Form1()
        {
            InitializeComponent();
            AddTileBrushButtonEvents();
            AddMapPaletteEvent();
            AddMenuClickEvent();
        //    m_MonsterBuffer = new MonsterData();
            m_StageMonsters = new List<MonsterData>();
        }

        public void AddTileBrushButtonEvents()
        {
            this.Tile10.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile10Button);
            this.Tile11.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile11Button);
            this.Tile20.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile20Button);
            this.Tile21.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile21Button);
            this.Tile30.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile30Button);
            this.Tile31.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile31Button);
            this.Tile40.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile40Button);
            this.Tile41.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile41Button);
            this.Tile50.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile50Button);
            this.Tile51.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTile51Button);
            this.TileEraser.Click += new System.EventHandler(GameMapTool.MapPalette.ClickTileEraserButton);
        }

        public void AddMapPaletteEvent()
        {
            this.MapCanvas.Click += new System.EventHandler(GameMapTool.MapPalette.DrawTile);
        }

        public void GetPaletteLocation(ref int x, ref int y)
        {
            x = this.MapCanvas.Location.X;
            y = this.MapCanvas.Location.Y;
        }


        public void AddMenuClickEvent()
        {
            this.MenuSave.Click += new System.EventHandler(ClickSaveMenu);
        }


        public void ClickSaveMenu(object sender, EventArgs e)
        {
            Int32[,] canvasData = new Int32[25,30];
            MapPalette.GetMapCanvasInfo(ref canvasData);

            WholeStageData wholeStageData = new WholeStageData
            {
                StageLevel = 1,
            };

            for (int i = 0; i < 25; i++)
            {
                WholeStageData.Types.MapLine mapLine = new MapLine();
                for (int j = 0; j < 30; j++)
                {
                    mapLine.Block.Add(canvasData[i, j]);
                }
                wholeStageData.Map.Add(mapLine);
            }

            wholeStageData.ToString();
            if(m_isNewFile == false)
            {
                m_fileName = "";
                ShowSaveDialogBox(ref wholeStageData);
            }
            else
            {
                m_fileStream = File.Create(m_filePath + m_fileName);
                SaveFile(ref wholeStageData);
            }

            
        }


        public void ShowSaveDialogBox(ref WholeStageData data)
        {
            SaveWindow saveDialog = new SaveWindow();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                SaveFile(ref data);
                MessageBox.Show("파일을 저장했습니다.");
            }
            saveDialog.Dispose();
        }

        void SaveFile(ref WholeStageData data)
        {
            using ( var output = File.Create(m_filePath + m_fileName) )
            {

                for(int i=0; i<25; i++)
                {
                    System.Diagnostics.Debug.Write("["+i+"]: ");
                    for (int j = 0; j < 25; j++)
                    {
                        System.Diagnostics.Debug.Write( data.Map[i].Block[j]+", ");
                    }
                    System.Diagnostics.Debug.WriteLine("");
                }

                data.WriteTo(output);
            }
        }

        void LoadFIle()
        {
            //TODO 저장된 파일 로딩 만들기
        }


        private void MonsterAddBtn_Click(object sender, EventArgs e)
        {
            MonsterEditWindow editWindow = new MonsterEditWindow();

            if (editWindow.ShowDialog(this) == DialogResult.OK)
            {
                MonsterData monster = new MonsterData();

                MonTypeComboBoxItem selectedMonType = (MonTypeComboBoxItem)editWindow.MonsterTypeSelector.SelectedItem;
                monster.type = selectedMonType.Value;
                monster.MonsterID = editWindow.MonsterIdInput.Text;
                foreach (MonsterAICommand cmd in editWindow.m_CmdDataList)
                {
                    monster.Commands.Add(cmd);
                }
                m_StageMonsters.Add(monster);
                MonsterList.Items.Add(monster.MonsterID);

            }
            editWindow.Dispose();
        }

        private void MonsterList_DoubleClick(object sender, EventArgs e)
        {
            MonsterData selectedMonster = null;
            string selectedID = MonsterList.SelectedItem.ToString();

            foreach( MonsterData mon in m_StageMonsters)
            {
                if (mon.MonsterID.Equals(selectedID))
                {
                    selectedMonster = mon;
                    break;
                }
            }
            EditMonster(ref selectedMonster);
        }

        private void EditMonster(ref MonsterData editMonster)
        {
            MonsterEditWindow editWindow = new MonsterEditWindow();
            editWindow.LoadMonsterToEdit(ref editMonster);

            if (editWindow.ShowDialog(this) == DialogResult.OK)
            {
                string MonID = editMonster.MonsterID;
                editMonster.Clear();
                editMonster.MonsterID = MonID;

                MonTypeComboBoxItem selectedMonType = (MonTypeComboBoxItem)editWindow.MonsterTypeSelector.SelectedItem;
                editMonster.type = selectedMonType.Value;
                editMonster.MonsterID = editWindow.MonsterIdInput.Text;
                foreach (MonsterAICommand cmd in editWindow.m_CmdDataList)
                {
                    editMonster.Commands.Add(cmd);
                }
                MessageBox.Show("수정이 정상적으로 완료되었습니다.");
            }
            editWindow.Dispose();
        }
    }

}
