using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GameMapTool
{
    static class MapPalette
    {
        enum Brush : Int16
        {
            None =  0,
            Tile10 = 10,
            Tile11 = 11,
            Tile20 = 20,
            Tile21 = 21,
            Tile30 = 30,
            Tile31 = 31,
            Tile40 = 40,
            Tile41 = 41,
            Tile50 = 50,
            Tile51 = 51,
        }

        private static Int16[,] m_Canvas_Info = new Int16[25, 30];
        private static PictureBox[,] m_Canvas_Bitmaps = new PictureBox[25, 30];
        public static List<MonsterData> MonsterList = new List<MonsterData>();

        private static Dictionary<Brush, string> m_TileImgPath = new Dictionary<Brush, string>();
        private static bool m_IsMouseDown = false;
        private static Form1 m_MainForm;

        private static Brush m_CurrentBrush = 0;

        public static void Initialize() {
            //타일의 이미지 파일이 있는 경로 설정

            m_MainForm = Program.GetMainfrom();

            String path = Path.GetFullPath(
               Path.Combine(Application.StartupPath + @"..\..\..\Bmp\")
              );

            m_TileImgPath.Add( Brush.Tile10, path + "Tile1_0.bmp" );
            m_TileImgPath.Add(Brush.Tile11, path + "Tile1_1.bmp");
            m_TileImgPath.Add( Brush.Tile20, path + "Tile2_0.bmp" );
            m_TileImgPath.Add( Brush.Tile21, path + "Tile2_1.bmp" );
            m_TileImgPath.Add(Brush.Tile30, path + "Tile3_0.bmp");
            m_TileImgPath.Add(Brush.Tile31, path + "Tile3_1.bmp");
            m_TileImgPath.Add(Brush.Tile40, path + "Tile4_0.bmp");
            m_TileImgPath.Add(Brush.Tile41, path + "Tile4_1.bmp");
            m_TileImgPath.Add(Brush.Tile50, path + "Tile5_0.bmp");
            m_TileImgPath.Add(Brush.Tile51, path + "Tile5_1.bmp");

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    m_Canvas_Info[i,j] = 0;
                    m_Canvas_Bitmaps[i, j] = new PictureBox();
                    m_Canvas_Bitmaps[i,j].InitialImage = null;
                    m_Canvas_Bitmaps[i, j].Left = j * 16;
                    m_Canvas_Bitmaps[i, j].Top = i * 16;
                    m_Canvas_Bitmaps[i, j].Width = 16;
                    m_Canvas_Bitmaps[i, j].Height = 16;

                    Program.GetMainfrom().MapCanvas.Controls.Add(m_Canvas_Bitmaps[i, j]);

                    m_Canvas_Bitmaps[i, j].MouseDown += new MouseEventHandler(CanvasMouseDown);
                    m_Canvas_Bitmaps[i, j].MouseUp += new MouseEventHandler(CanvasMouseUp);
                    m_Canvas_Bitmaps[i, j].MouseEnter += new System.EventHandler(CanvasMouseEnter);
                }
            }

        }


        private static void CanvasMouseDown(object sender, EventArgs e)
        {
            m_IsMouseDown = true;

            Control control = (Control)sender;

            if (control.Capture)
            {
                control.Capture = false;
                System.Diagnostics.Debug.WriteLine(control.Name);
            }
        }

        private static void CanvasMouseUp(object sender, EventArgs e)
        {
            m_IsMouseDown = false;
        }


        private static void CanvasMouseEnter(object sender, EventArgs e)
        {
            Point canvasClickedPos = m_MainForm.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            canvasClickedPos.X -= m_MainForm.MapCanvas.Location.X;
            canvasClickedPos.Y -= m_MainForm.MapCanvas.Location.Y;

            int TileX = canvasClickedPos.X / 16;
            int TileY = canvasClickedPos.Y / 16;

            Program.GetMainfrom().Status.Text = "("+TileX + "," + TileY+")";
            Program.GetMainfrom().Status.Text += Program.GetMainfrom().Status.Text;

            if (m_IsMouseDown == true)
            {
                DrawTile(sender,  e);
            }
        }


        public static void DrawTile(object sender, EventArgs e)
        {
            Form1 Mainform = Program.GetMainfrom();

            Point canvasClickedPos = Mainform.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            canvasClickedPos.X -= Mainform.MapCanvas.Location.X;
            canvasClickedPos.Y -= Mainform.MapCanvas.Location.Y;

            int TileX = canvasClickedPos.X / 16;
            int TileY = canvasClickedPos.Y / 16;

            Graphics g = Mainform.CreateGraphics();
            m_Canvas_Info[TileY,TileX] = (short)m_CurrentBrush;

            if (m_CurrentBrush == Brush.None)
            {
                m_Canvas_Bitmaps[TileY, TileX].Image = null;
            }
            else
            {
                Image Tile = new Bitmap (Image.FromFile(m_TileImgPath[m_CurrentBrush]), new Size(16,16));
                m_Canvas_Bitmaps[TileY, TileX].Image = Tile;
            }
        }


        public static void GetMapCanvasInfo(ref Int32[,] res)
        {
            for( int i=0; i<25; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    res[i, j] = m_Canvas_Info[i, j];
                }
            }
        }


        public static void ClickTile10Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile10;
        }

        public static void ClickTile11Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile11;
        }

        public static void ClickTile20Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile20;
        }

        public static void ClickTile21Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile21;
        }

        public static void ClickTile30Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile30;
        }

        public static void ClickTile31Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile31;
        }

        public static void ClickTile40Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile40;
        }

        public static void ClickTile41Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile41;
        }

        public static void ClickTile50Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile50;
        }

        public static void ClickTile51Button(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.Tile51;
        }

        public static void ClickTileEraserButton(object sender, EventArgs e)
        {
            m_CurrentBrush = Brush.None;
        }
    }



}
