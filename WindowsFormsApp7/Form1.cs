using Syncfusion.Pdf;
using Syncfusion.Pdf.ColorSpace;
using Syncfusion.Pdf.Functions;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System.Reflection;
using System.Threading;
using Syncfusion.Pdf.Interactive;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp = new Excel.Application();
        //***************DATE BASE**************************************//
        //---------------DATE SOURCE SHEET[1]---------------------------//
        //Create COM Objects. Create a COM object for everything that is referenced
        Excel.Workbook xlWorkbook ;
        Excel._Worksheet xlWorksheet ;
        Excel.Range xlRange;
        int rowCount ;
        int colCount ;
        int X_Cor_Collum=3;
        int Y_Cor_Collum=4;
        int Area_Collum = 5;
        int Excel_Layout_Page = 6;
        int Cable_Pulled_Collum=10;
        int Cable_Ready_Collum=11;
        int Tray_Not_Done_Collum=12;
        int No_Equipment_Collum = 15;
        int Cable_Ter_Done_Collum=13;
        int Cable_Not_Pull = 20;
        int Cable_MC_1st_Collum =16;
        int Cable_MC_2rd_Collum =17;
        int cable_Mc_3TH_Collum =18;
        float circle_Diameter = 41.4f;
        // Print status point
        float x_print_start_point = 2910.0f;
        float y_print_start_point = 990.0f;
        float y_print_offset = 23.0f;

        int Zone_Total_Pulled = 0;
        int Zone_Total_Cable_Ready = 0;
        int Zone_Total_Not_Tray = 0;
        int Zone_Total_Not_Equipment = 0;
        int Zone_Total_Ter_Done = 0;
        int Zone_Total_No_Pull = 0;
        bool first_Load = true;


        //---------------Highlight---------------------------//
        float Transparency_instrument = 0.3f;
        float Transparency_text = 1.0f;
        float Transparency_MC = 1.0f;
        //Create new PDF solid brush.  
        PdfBrush brush_Pulled = new PdfSolidBrush(Color.Red);
        PdfBrush brush_No_Pulled = new PdfSolidBrush(Color.LightGray);
        PdfBrush brush_Cable_Ready = new PdfSolidBrush(Color.Yellow);
        PdfBrush brush_Tray_Not_Done = new PdfSolidBrush(Color.Orange);
        PdfBrush brush_No_Equiment = new PdfSolidBrush(Color.DarkBlue);
        PdfBrush brush_Cable_Ter_Done = new PdfSolidBrush(Color.YellowGreen);
        PdfBrush note_brush = new PdfSolidBrush(Color.Black);
        PdfBrush brush_MC_1st = new PdfSolidBrush(Color.DarkMagenta);
        PdfBrush brush_MC_2rd = new PdfSolidBrush(Color.DeepPink);
        PdfBrush brush_MC_3th = new PdfSolidBrush(Color.MediumAquamarine);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load Link of Document
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.TabPages[3].Enabled = false;
            tabControl1.TabPages[4].Enabled = false;
            try
            {
                txt_Database.Text = Properties.Settings.Default.Txt_Database;
                txt_2D_Inst_Layout.Text = Properties.Settings.Default.Txt_Ins_Layout_2D;
                txt_2C_Inst_Layout.Text = Properties.Settings.Default.Txt_Ins_Layout_2C;
                txt_3A_Inst_Layout.Text = Properties.Settings.Default.Txt_Ins_Layout_3A;
                txt_2B_Inst_Layout.Text = Properties.Settings.Default.Txt_Ins_Layout_2B;
                chx_Zone_Pulled.Checked = Properties.Settings.Default.Chx_Cable_Pulled;
                chx_Zone_Cable_Ready.Checked = Properties.Settings.Default.Chx_Cable_Ready;
                chx_Zone_Tray_Not_Done.Checked = Properties.Settings.Default.Chx_No_Tray;
                chx_Zone_No_Equipment.Checked = Properties.Settings.Default.Chx_No_Equipment;
                chx_Zone_Termination_Done.Checked = Properties.Settings.Default.Chx_Ter_Done;
                chx_MC_1st.Checked = Properties.Settings.Default.Chx_MC_1st;
                chx_MC_2nd.Checked = Properties.Settings.Default.Chx_MC_2rd;
                chx_MC_3th.Checked = Properties.Settings.Default.Chx_MC_3th;
                txt_MC_1st.Text = Properties.Settings.Default.Txt_MC_1st;
                txt_MC_2rd.Text = Properties.Settings.Default.Txt_MC_2rd;
                txt_MC_3th.Text = Properties.Settings.Default.Txt_MC_3th;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            txt_Database.Text = filename;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Database.Text == "")
            {
                MessageBox.Show("Instrument Database Link Empty", "Inform ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            getExcelFile();
            tabControl1.TabPages[1].Enabled = tabControl1.TabPages[2].Enabled= tabControl1.TabPages[3].Enabled= tabControl1.TabPages[4].Enabled =true;


        }
        public void getExcelFile()
        {
            FileInfo fi = new FileInfo(txt_Database.Text);
            if (fi.Exists )
            {
                //***************DATE BASE Load Data**************************************//
                xlWorkbook = xlApp.Workbooks.Open(fi.ToString());
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;
            }
            else if (fi.Exists)
            {
                MessageBox.Show("Database File Invalid", "Inform ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Save Link of Document
            try
            {
                Properties.Settings.Default.Txt_Database = txt_Database.Text;
                Properties.Settings.Default.Txt_Ins_Layout_2D = txt_2D_Inst_Layout.Text;
                Properties.Settings.Default.Txt_Ins_Layout_2C = txt_2C_Inst_Layout.Text;
                Properties.Settings.Default.Txt_Ins_Layout_3A = txt_3A_Inst_Layout.Text;
                Properties.Settings.Default.Txt_Ins_Layout_2B = txt_2B_Inst_Layout.Text;
                Properties.Settings.Default.Chx_Cable_Pulled = chx_Zone_Pulled.Checked;
                Properties.Settings.Default.Chx_Cable_Ready = chx_Zone_Cable_Ready.Checked;
                Properties.Settings.Default.Chx_No_Tray = chx_Zone_Tray_Not_Done.Checked;
                Properties.Settings.Default.Chx_No_Equipment = chx_Zone_No_Equipment.Checked;
                Properties.Settings.Default.Chx_Ter_Done = chx_Zone_Termination_Done.Checked;
                Properties.Settings.Default.Chx_MC_1st = chx_MC_1st.Checked;
                Properties.Settings.Default.Chx_MC_2rd = chx_MC_2nd.Checked;
                Properties.Settings.Default.Chx_MC_3th = chx_MC_3th.Checked;
                Properties.Settings.Default.Txt_MC_1st = txt_MC_1st.Text;
                Properties.Settings.Default.Txt_MC_2rd = txt_MC_2rd.Text;
                Properties.Settings.Default.Txt_MC_3th = txt_MC_3th.Text;

                Properties.Settings.Default.Save();

                //cleanup Excel

                GC.Collect();
                GC.WaitForPendingFinalizers();
                //release com objects to fully kill excel process from running in the background
                // Release Cable Database Form
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close(); //to close the window(Form1)  
        }

        private void btn_load_Layout_2D_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string filename = openFileDialog2.FileName;
            txt_2D_Inst_Layout.Text = filename;
        }

        private void Update_Layout_Status(string link_layout, string zone, AxAcroPDFLib.AxAcroPDF zone_adobe_show)
        {
            var values = (xlRange.Value as Object[,]);
            rowCount = xlRange.Rows.Count;
            colCount = xlRange.Columns.Count;
            Console.WriteLine("Row Source Range: " + rowCount.ToString());
            Console.WriteLine("Col Source Range:" + colCount.ToString());
            //Load an existing PDF document
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(link_layout);
            int pageCount = loadedDocument.Pages.Count;
            Console.WriteLine("total page: " + pageCount.ToString());
            //pageCount = 1;
            // int i = 0;


            PdfLoadedPage[] loadedpage = new PdfLoadedPage[pageCount];
            PdfGraphics[] graphics = new PdfGraphics[pageCount];
            PdfGraphicsState[] state = new PdfGraphicsState[pageCount];
            for (int i = 0; i < pageCount; i++)
            {
                Console.WriteLine("count: " + i.ToString());
                loadedpage[i] = loadedDocument.Pages[i] as PdfLoadedPage;
                graphics[i] = loadedpage[i].Graphics;
                state[i] = graphics[i].Save();
                graphics[i].SetTransparency(Transparency_instrument);
            }
            Zone_Total_Cable_Ready = Zone_Total_Not_Tray =Zone_Total_Not_Equipment= Zone_Total_Pulled = Zone_Total_Ter_Done =Zone_Total_No_Pull= 0;

            //Process Markup 
            for (int j = 2; j <= rowCount; j++)
            //for (int j = 2; j <= 20; j++)
            {
                Console.WriteLine("Row Number: " + j.ToString());
                int progress_status = 0;
                if (values[j, Area_Collum].ToString() == zone)
                {
                    float x_coor = float.Parse(values[j, X_Cor_Collum].ToString()) - circle_Diameter / 2;// offset point
                    float y_coor = float.Parse(values[j, Y_Cor_Collum].ToString());
                    //Console.WriteLine("Coordinate:" + x_coor.ToString() + " " + y_coor.ToString());

                    if ((x_coor > 0) && (y_coor > 0))
                    {
                        if (Convert.ToInt32(values[j, Cable_Ter_Done_Collum]) > 0)
                        {
                            progress_status = Cable_Ter_Done_Collum;
                            Zone_Total_Ter_Done++;
                        }
                        else if (Convert.ToInt32(values[j, Tray_Not_Done_Collum])>0)
                        {
                            progress_status = Tray_Not_Done_Collum;
                            Zone_Total_Not_Tray++;
                        }   
                        else if (Convert.ToInt32(values[j, No_Equipment_Collum]) > 0)
                        {
                            progress_status = No_Equipment_Collum;
                            Zone_Total_Not_Equipment++;
                        }    
                        else if (Convert.ToInt32(values[j, Cable_Ready_Collum]) > 0)
                        {
                            progress_status = Cable_Ready_Collum;
                            Zone_Total_Cable_Ready++;
                        }
                        else if (Convert.ToInt32(values[j, Cable_Pulled_Collum]) > 0)
                        {
                            progress_status = Cable_Pulled_Collum;
                            Zone_Total_Pulled++;
                        }
                        else if(Convert.ToInt32(values[j,Cable_Pulled_Collum])<=0)
                        {
                            progress_status = Cable_Not_Pull;
                            Zone_Total_No_Pull++;
                        }    
                        // Markup Status Termination of Equipment 
                        if ((chx_Zone_Termination_Done.Checked == true) && (progress_status == Cable_Ter_Done_Collum))// Display Cable Termination Done Status
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_Cable_Ter_Done, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        }
                        else if((chx_Zone_Tray_Not_Done.Checked == true) && (progress_status == Tray_Not_Done_Collum))
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_Tray_Not_Done, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        } 
                        else if ((chx_Zone_No_Equipment.Checked == true) && (progress_status == No_Equipment_Collum))
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_No_Equiment, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        }                    
                        else if ((chx_Zone_Cable_Ready.Checked == true) && (progress_status == Cable_Ready_Collum))
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_Cable_Ready, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        }
                        else if ((chx_Zone_Pulled.Checked == true) && (progress_status == Cable_Pulled_Collum))
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_Pulled, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        }
                        else if (progress_status==Cable_Not_Pull)
                        {
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawEllipse(brush_No_Pulled, new RectangleF(x_coor, y_coor, circle_Diameter, circle_Diameter));
                        }    
                    }
                }
            }
            //Process Status of MC
            RectangleF bounds;
            for (int i = 0; i < pageCount; i++)
            {
                graphics[i].SetTransparency(Transparency_MC);
            }
            for (int j = 2; j <= rowCount; j++)
            {
                Console.WriteLine("Row Number MC : " + j.ToString());
                if (values[j, Area_Collum].ToString() == zone)
                {
                    float x_coor = float.Parse(values[j, X_Cor_Collum].ToString());// offset point
                    float y_coor = float.Parse(values[j, Y_Cor_Collum].ToString()) + 0.72f*circle_Diameter;
                    //Console.WriteLine("Coordinate:" + x_coor.ToString() + " " + y_coor.ToString());

                    if ((x_coor > 0) && (y_coor > 0))
                    {
                        if (chx_MC_1st.Checked && (Convert.ToInt32(values[j, Cable_MC_1st_Collum]) > 0))
                        {
                            bounds = new RectangleF(x_coor-10, y_coor, 5, 5);
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawRectangle(brush_MC_1st, bounds);
                        }
                        if (chx_MC_2nd.Checked && (Convert.ToInt32(values[j, Cable_MC_2rd_Collum]) > 0))
                        {
                            bounds = new RectangleF(x_coor-2.5f, y_coor, 5, 5);
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawRectangle(brush_MC_2rd, bounds);
                        }
                        if (chx_MC_3th.Checked && (Convert.ToInt32(values[j, cable_Mc_3TH_Collum]) > 0))
                        {
                            bounds = new RectangleF(x_coor+10, y_coor, 5, 5);
                            graphics[Convert.ToInt32(values[j, Excel_Layout_Page]) - 1].DrawRectangle(brush_MC_3th, bounds);
                        }

                    }
                }
            }



         // Print the Status to PDF File
         string time_today = DateTime.Now.ToString("dd MM yy");
            if (zone == "3A" && first_Load==true)
            {
                y_print_start_point += 60;
                first_Load = false;
            }


            for (int i = 0; i < pageCount; i++)
            {  
                //Draw the text.
                graphics[i].SetTransparency(Transparency_text);
                //Set the standard font.
                PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 30);
                graphics[i].DrawString(zone + " Updated Date: " + time_today, font, PdfBrushes.DarkRed, new PointF(x_print_start_point, y_print_start_point - y_print_offset / 2));
                //Set the standard font.
                font = new PdfStandardFont(PdfFontFamily.TimesRoman, 18);
                if (chx_Zone_Pulled.Checked == true)
                {
                    //Set the bounds for rectangle
                    bounds = new RectangleF(x_print_start_point - 40, y_print_start_point + 1 * y_print_offset, 30, 18);
                    graphics[i].DrawRectangle(brush_Pulled, bounds);
                    graphics[i].DrawString("Cable Pulled. Not Ready: " + Zone_Total_Pulled.ToString(), font, note_brush, new PointF(x_print_start_point, 1 * y_print_offset + y_print_start_point));
                }
                if (chx_Zone_Cable_Ready.Checked == true)
                {
                    bounds = new RectangleF(x_print_start_point - 40, y_print_start_point + 2 * y_print_offset, 30, 18);
                    graphics[i].DrawRectangle(brush_Cable_Ready, bounds);
                    graphics[i].DrawString("Cable Ready For Termination : " + Zone_Total_Cable_Ready.ToString(), font, note_brush, new PointF(x_print_start_point, y_print_start_point + 2 * y_print_offset));
                }
                if (chx_Zone_Tray_Not_Done.Checked == true)
                {
                    bounds = new RectangleF(x_print_start_point - 40, y_print_start_point + 3 * y_print_offset, 30, 18);
                    graphics[i].DrawRectangle(brush_Tray_Not_Done, bounds);
                    graphics[i].DrawString("No Tray: " + Zone_Total_Not_Tray.ToString(), font, note_brush, new PointF(x_print_start_point, y_print_start_point + 3 * y_print_offset));
                }
                if (chx_Zone_No_Equipment.Checked == true)
                {
                    bounds = new RectangleF(x_print_start_point - 40, y_print_start_point + 4 * y_print_offset, 30, 18);
                    graphics[i].DrawRectangle(brush_No_Equiment, bounds);
                    graphics[i].DrawString("No Equipment: " + Zone_Total_Not_Equipment.ToString(), font, note_brush, new PointF(x_print_start_point, y_print_start_point + 4 * y_print_offset));
                }
                if (chx_Zone_Termination_Done.Checked == true)
                {
                    bounds = new RectangleF(x_print_start_point - 40, y_print_start_point + 5 * y_print_offset, 30, 18);
                    graphics[i].DrawRectangle(brush_Cable_Ter_Done, bounds);
                    graphics[i].DrawString("Termination Done: " + Zone_Total_Ter_Done.ToString(), font, note_brush, new PointF(x_print_start_point, y_print_start_point + 5 * y_print_offset));
                }
                }
            // Create new foldder for instrument_layout form
            string folderLocation = "D:\\" + "Instrument Layout";
            bool exists = System.IO.Directory.Exists(folderLocation);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }
            loadedDocument.Save(folderLocation + "\\Instrument Layout" + " " + zone + "_" + time_today + ".pdf");
            zone_adobe_show.LoadFile(folderLocation + "\\Instrument Layout" + " " + zone + "_" + time_today + ".pdf");
            //Closes the document
            loadedDocument.Close(true);
        }
        private void btn_2D_Update_Status_Click(object sender, EventArgs e)
        {
            Update_Layout_Status(txt_2D_Inst_Layout.Text, "2D", axAcroPDF_2D_Inst);
        
        }
        private void btn_2C_Update_Status_Click(object sender, EventArgs e)
        {
            Update_Layout_Status(txt_2C_Inst_Layout.Text, "2C", axAcroPDF_2C_Inst);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            string filename = openFileDialog3.FileName;
            txt_2C_Inst_Layout.Text = filename;
        }
        private void btn_load_Layout_3A_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            string filename = openFileDialog4.FileName;
            txt_3A_Inst_Layout.Text = filename;

        }
        private void btn_3A_Update_Status_Click(object sender, EventArgs e)
        {
            Update_Layout_Status(txt_3A_Inst_Layout.Text, "3A", axAcroPDF_3A_Inst);
        }

        private void btn_load_Layout_2B_Click_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
            string filename = openFileDialog5.FileName;
            txt_2B_Inst_Layout.Text = filename;

        }

        private void btn_2B_Update_Status_Click(object sender, EventArgs e)
        {
            Update_Layout_Status(txt_2B_Inst_Layout.Text, "2B", axAcroPDF_2B_Inst);
        }
    }
    }




