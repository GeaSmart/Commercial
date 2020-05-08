using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Data;
using DGVPrinterHelper;

namespace Presentacion
{
    public class _cfgUtil
    {
        public static bool checkFields(GroupBox gpb)
        {
            int errors = 0;

            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(3));

            foreach (Control c in gpb.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (c.Tag.ToString() == "O")
                    {
                        if (string.IsNullOrEmpty(c.Text.Trim()))
                        {
                            errors++;
                            c.BackColor = System.Drawing.Color.Orange;
                            c.ForeColor = System.Drawing.Color.White;
                            c.Focus();
                        }
                    }
                }
            }
            backgroundWorker.RunWorkerAsync();

            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                foreach (Control c in gpb.Controls)
                {
                    c.BackColor = SystemColors.Window;
                    c.ForeColor = SystemColors.WindowText;
                }
            };

            if (errors == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Falta(n) " + errors + " campo(s) por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void restoreFields(GroupBox gpb)
        {
            foreach (Control c in gpb.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.BackColor = System.Drawing.Color.White;
                    c.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type = null)
        {
            var controls = control.Controls.Cast<Control>();
            //check the all value, if true then get all the controls
            //otherwise get the controls of the specified type
            if (type == null)
                return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls);
            else
                return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public static void clearFields(GroupBox gpb)
        {

            //var g = Get
            //List<Control> ch = gpb.Controls.OfType<TextBox>().Cast<Control>().ToList();
            //Control.ControlCollection cc = (Control.ControlCollection)ch;

            //gpb.Controls
            //var children = gpb.Controls.OfType<GroupBox>();
            //control.Controls.OfType<Control>();
            foreach (Control c in gpb.Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    if (childc is TextBox)
                    {
                        childc.Text = "";
                    }
                }
                //****************************************
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown f = (NumericUpDown)c;
                    f.Value = 0;
                }
                if (c is ComboBox)
                {
                    ComboBox f = (ComboBox)c;
                    f.SelectedIndex = -1;
                }
                if (c is CheckBox)
                {
                    CheckBox f2 = (CheckBox)c;
                    f2.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker f3 = (DateTimePicker)c;
                    f3.Value = DateTime.Now;
                }
                if (c is PictureBox)
                {
                    PictureBox f4 = (PictureBox)c;
                    f4.Image = null;
                }

                if (c is GroupBox)
                {
                    foreach (Control d in c.Controls)
                    {
                        if (d is TextBox)
                        {
                            d.Text = "";
                        }
                        if (d is NumericUpDown)
                        {
                            NumericUpDown f = (NumericUpDown)d;
                            f.Value = 0;
                        }
                        if (d is ComboBox)
                        {
                            ComboBox f = (ComboBox)d;
                            f.SelectedIndex = -1;
                        }
                        if (d is CheckBox)
                        {
                            CheckBox f2 = (CheckBox)d;
                            f2.Checked = false;
                        }
                        if (d is DateTimePicker)
                        {
                            DateTimePicker f3 = (DateTimePicker)d;
                            f3.Value = DateTime.Now;
                        }
                        if (d is PictureBox)
                        {
                            PictureBox f4 = (PictureBox)d;
                            f4.Image = null;
                        }
                        if (d is TabControl)
                        {
                            TabControl f4 = (TabControl)d;
                            foreach (TabPage pagina in f4.TabPages)
                            {
                                foreach (Control e in pagina.Controls)
                                {
                                    if (e is TextBox)
                                    {
                                        e.Text = "";
                                    }
                                    if (e is NumericUpDown)
                                    {
                                        NumericUpDown f = (NumericUpDown)e;
                                        f.Value = 0;
                                    }
                                    if (e is ComboBox)
                                    {
                                        ComboBox f = (ComboBox)e;
                                        f.SelectedIndex = -1;
                                    }
                                    if (e is CheckBox)
                                    {
                                        CheckBox f2 = (CheckBox)e;
                                        f2.Checked = false;
                                    }
                                    if (e is DateTimePicker)
                                    {
                                        DateTimePicker f3 = (DateTimePicker)e;
                                        f3.Value = DateTime.Now;
                                    }
                                    if (e is PictureBox)
                                    {
                                        PictureBox f5 = (PictureBox)e;
                                        f5.Image = null;
                                    }
                                }
                            }
                        }
                    }
                }

                if (c is TabControl)
                {
                    TabControl f4 = (TabControl)c;
                    foreach (TabPage pagina in f4.TabPages)
                    {
                        foreach (Control d in pagina.Controls)
                        {
                            if (d is TextBox)
                            {
                                d.Text = "";
                            }
                            if (d is NumericUpDown)
                            {
                                NumericUpDown f = (NumericUpDown)d;
                                f.Value = 0;
                            }
                            if (d is ComboBox)
                            {
                                ComboBox f = (ComboBox)d;
                                f.SelectedIndex = -1;
                            }
                            if (d is CheckBox)
                            {
                                CheckBox f2 = (CheckBox)d;
                                f2.Checked = false;
                            }
                            if (d is DateTimePicker)
                            {
                                DateTimePicker f3 = (DateTimePicker)d;
                                f3.Value = DateTime.Now;
                            }
                            if (d is PictureBox)
                            {
                                PictureBox f5 = (PictureBox)d;
                                f5.Image = null;
                            }
                        }
                    }
                }
                if (c is Panel)
                {
                    foreach (Control d in c.Controls)
                    {
                        if (d is TextBox)
                        {
                            d.Text = "";
                        }
                        if (d is NumericUpDown)
                        {
                            NumericUpDown f = (NumericUpDown)d;
                            f.Value = 0;
                        }
                        if (d is ComboBox)
                        {
                            ComboBox f = (ComboBox)d;
                            f.SelectedIndex = -1;
                        }
                        if (d is CheckBox)
                        {
                            CheckBox f2 = (CheckBox)d;
                            f2.Checked = false;
                        }
                        if (d is DateTimePicker)
                        {
                            DateTimePicker f3 = (DateTimePicker)d;
                            f3.Value = DateTime.Now;
                        }
                        if (d is PictureBox)
                        {
                            PictureBox f5 = (PictureBox)d;
                            f5.Image = null;
                        }
                    }
                }
            }
        }

        public static System.Drawing.Image ScaleImage(System.Drawing.Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static void enumerarFilasDatagridview(DataGridView DataGridView1, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //Captura el numero de filas del datagridview
                string RowsNumber = (e.RowIndex + 1).ToString();
                while (RowsNumber.Length < DataGridView1.RowCount.ToString().Length)
                {
                    RowsNumber = "0" + RowsNumber;
                }
                System.Drawing.SizeF size = e.Graphics.MeasureString(RowsNumber, DataGridView1.Font);
                if (DataGridView1.RowHeadersWidth < Convert.ToInt32(size.Width + 20))
                {
                    DataGridView1.RowHeadersWidth = Convert.ToInt32(size.Width + 20);
                }
                else
                {
                    DataGridView1.RowHeadersWidth = Convert.ToInt32(size.Width + 20);
                }
                System.Drawing.Brush ob = System.Drawing.SystemBrushes.ControlText;
                e.Graphics.DrawString(RowsNumber, DataGridView1.Font, ob, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void exportarExcel(DataGridView dgv, string referencia)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                //worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = referencia;
                // storing header part in Excel  
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = referencia;
                sfd.Filter = "Libro de excel (*.xlsx)|*.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();

                    DialogResult dialogResult = MessageBox.Show("El archivo fue exportado satisfactoriamente en la ruta: " + sfd.FileName + "\r\n\r\n¿Desea abrirlo?", "SICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (SystemException ex)
            { }
        }

        public static void ExportarPdf(DataGridView dgv, String referencia, string parametros)
        {
            bool isImprimir = true;
            if (dgv.RowCount == 0)
            {
                DialogResult dialogResult = MessageBox.Show("La grilla no contiene filas, aún así ¿Desea exportarla?", "SICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    isImprimir = false;
                }
            }
            
            if (isImprimir)
            {
                string strPdfPath = "";
                DataTable dtblTable = (DataTable)(dgv.DataSource);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = referencia;
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    strPdfPath = sfd.FileName;
                    //
                    System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
                    Document document = new Document();
                    document.SetPageSize(iTextSharp.text.PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    //Report Header
                    BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.Color.GRAY);
                    Paragraph prgHeading = new Paragraph();
                    prgHeading.Alignment = Element.ALIGN_CENTER;
                    prgHeading.Add(new Chunk(referencia.ToUpper(), fntHead));
                    document.Add(prgHeading);

                    //Author
                    Paragraph prgAuthor = new Paragraph();
                    BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, iTextSharp.text.Color.GRAY);
                    prgAuthor.Alignment = Element.ALIGN_RIGHT;
                    prgAuthor.Add(new Chunk("Sistema de gestión comercial SICO", fntAuthor));

                    if (parametros.Length > 0)
                    {
                        prgAuthor.Add(new Chunk("\n" + parametros, fntAuthor));
                    }

                    prgAuthor.Add(new Chunk("\nAutor : " + SharedData.Instance().USU_nombre_completo, fntAuthor));
                    prgAuthor.Add(new Chunk("\nFecha : " + DateTime.Now, fntAuthor));
                    document.Add(prgAuthor);

                    //Add a line seperation
                    Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.Color.BLACK, Element.ALIGN_LEFT, 1)));
                    document.Add(p);

                    //Add line break
                    document.Add(new Chunk("\n", fntHead));

                    //Write the table
                    PdfPTable table = new PdfPTable(dtblTable.Columns.Count);                    
                    //Table header
                    BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, iTextSharp.text.Color.WHITE);
                    for (int i = 0; i < dtblTable.Columns.Count; i++)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.BackgroundColor = iTextSharp.text.Color.GRAY;
                        cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                        table.AddCell(cell);
                    }
                    //table Data
                    for (int i = 0; i < dtblTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtblTable.Columns.Count; j++)
                        {
                            table.AddCell(dtblTable.Rows[i][j].ToString());
                        }
                    }
                    //
                    table.WidthPercentage = 100;
                    //
                    document.Add(table);

                    document.Close();
                    writer.Close();
                    fs.Close();

                    //
                    DialogResult dialogResult2 = MessageBox.Show("El archivo fue exportado satisfactoriamente en la ruta: " + sfd.FileName + "\r\n\r\n¿Desea abrirlo?", "SICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }                
            }
        }

        public static void Imprimir(DataGridView dgv, string referencia, string parametros)
        {
            bool isImprimir = true;
            if (dgv.RowCount == 0)
            {
                DialogResult dialogResult = MessageBox.Show("La grilla no contiene filas, aún así ¿Desea imprimirla?", "SICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    isImprimir = false;
                }
            }

            if (isImprimir)
            {

                DGVPrinter printer = new DGVPrinter();
                printer.Title = referencia;
                if (parametros.Length > 0)
                {
                    printer.SubTitle = parametros;
                }
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.TableAlignment = DGVPrinter.Alignment.Center;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = false;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Sistema de gestion comercial SICO\r\n" + SharedData.Instance().USU_nombre_completo + " - " + DateTime.Now.ToString();
                printer.FooterSpacing = 15;

                if (dgv.Columns.Count > 5)
                {
                    printer.PageSettings.Landscape = true;
                }
                printer.PrintDataGridView(dgv);
            }
            
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            //    return;
            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
    }
}
