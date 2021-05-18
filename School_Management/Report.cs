using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using DevExpress.XtraEditors;

namespace School_Management
{
    class Report
    {
        public string Title { get; set; }
        public DateTime createDate { get; set; }
        public DataTable Table { get; set; }
        public Report()
        {
            createDate = DateTime.Now;
        }
        public void toWordReport(string filename)
        {
            //Create an instance for word app  
            Word.Application winword = new Word.Application();

            //Create a missing variable for missing value  
            object missing = System.Reflection.Missing.Value;

            try
            {
                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document = getWordDocument();

                //Save the document  
                document.SaveAs2(filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
            }
        }
        public bool ToExcelReport(string filename)
        {
            if (Table.Rows.Count != 0)
            {
                var excelApp = new Excel.Application();

                excelApp.Visible = false;

                // Create a new, empty workbook and add it to the collection returned
                // by property Workbooks. The new workbook becomes the active workbook.
                // Add has an optional parameter for specifying a praticular template.
                // Because no argument is sent in this example, Add creates a new workbook.
                excelApp.Workbooks.Add();

                // This example uses a single workSheet. The explicit type casting is
                // removed in a later procedure.
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // print header
                for (int i = 0; i < Table.Columns.Count; i++)
                {
                    workSheet.Cells[3, i + 1] = Table.Columns[i].ColumnName;
                }

                // print content
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    for (int j = 0; j < Table.Columns.Count; j++)
                    {
                        //check for image cell and print
                        if (Table.Rows[i][j].GetType() == typeof(byte[]))
                        {

                        }
                        else if (Table.Rows[i][j].GetType() == typeof(DateTime))
                        {
                            workSheet.Cells[i + 4, j + 1] = (Table.Rows[i][j]).ToString().Split(' ')[0];
                        }
                        else
                        {
                            workSheet.Cells[i + 4, j + 1] = (Table.Rows[i][j]).ToString();
                        }
                    }
                }

                for (int i = 0; i < Table.Columns.Count; i++)
                {
                    workSheet.Columns[i + 1].AutoFit();
                }

                workSheet.SaveAs(filename);

                excelApp.Quit();

                return true;
            }
            return false;
        }
        public Word.Document getWordDocument()
        {
            try
            {
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Word.Document document = new Word.Document();

                //Add header into the document  
                foreach (Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.ParagraphFormat.FirstLineIndent = 0;
                    headerRange.Font.ColorIndex = Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                }

                //Add the footers into the document  
                foreach (Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Create title
                Word.Paragraph title = document.Content.Paragraphs.Add(ref missing);
                title.Range.Text = this.Title;
                title.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.Font.Size = 26;
                title.Range.Font.Color = Word.WdColor.wdColorDarkBlue;
                title.Format.FirstLineIndent = 0;
                title.Range.InsertParagraphAfter();

                //Create date report
                Word.Paragraph ReportDate = document.Content.Paragraphs.Add(ref missing);
                ReportDate.Range.Text = "Export date: " + this.createDate.ToLongDateString();
                ReportDate.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                ReportDate.Range.Font.Size = 14;
                ReportDate.Range.Font.Color = Word.WdColor.wdColorBlack;
                ReportDate.Format.FirstLineIndent = 0;
                ReportDate.Range.InsertParagraphAfter();

                //Create table and insert datatable 
                Word.Table firstTable = document.Tables.Add(title.Range, Table.Rows.Count + 1, Table.Columns.Count + 1, ref missing, ref missing);
                firstTable.Range.Font.Size = 10;
                firstTable.Range.Font.Color = Word.WdColor.wdColorBlack;
                firstTable.Borders.Enable = 1;
                firstTable.AllowAutoFit = true;

                int tableRow = 0; // row index for datatable
                foreach (Word.Row row in firstTable.Rows)
                {
                    int tableColumn = 0; // column index for datatable
                    foreach (Word.Cell cell in row.Cells)
                    {
                        cell.Range.Font.Size = 8;
                        cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        //Header row  
                        if (cell.RowIndex == 1)
                        {
                            if (cell.ColumnIndex == 1)
                            {
                                cell.Range.Text = "STT";
                            }
                            else
                            {
                                cell.Range.Text = Table.Columns[tableColumn].ColumnName;
                                tableColumn++;
                            }
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here  
                            cell.Range.Font.Name = "verdana";
                            //Center alignment for the Header cells  
                            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                        //Data row
                        else
                        {
                            if (cell.ColumnIndex == 1)
                            {
                                cell.Range.Text = (cell.RowIndex - 1).ToString();
                            }
                            else
                            {
                                //check for image cell and print
                                if (Table.Rows[tableRow][tableColumn].GetType() == typeof(byte[]))
                                {
                                    Image image = new Picture().ByteArrToImage((byte[])Table.Rows[tableRow][tableColumn]);

                                    // resize image
                                    Bitmap bitmap = new Bitmap(image, new Size(90, 90));
                                    image = (Image)bitmap;

                                    Clipboard.SetImage(image);
                                    cell.Range.PasteAndFormat(Word.WdRecoveryType.wdSingleCellTable);
                                    Clipboard.Clear();
                                }
                                else if (Table.Rows[tableRow][tableColumn].GetType() == typeof(DateTime))
                                {
                                    cell.Range.Text = ((DateTime)Table.Rows[tableRow][tableColumn]).ToShortDateString();
                                    tableColumn++;
                                }
                                else
                                {
                                    cell.Range.Text = (Table.Rows[tableRow][tableColumn]).ToString().Trim();
                                    tableColumn++;
                                }
                            }
                        }
                    }
                    if (row.Index != 1)
                    {
                        tableRow++;
                    }
                }
                return document;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public void Print()
        {
            //Create an instance for word app  
            Word.Application winword = new Word.Application();

            //Create a missing variable for missing value  
            object missing = System.Reflection.Missing.Value;

            try
            {

                //Set animation status for word application  
                winword.ShowAnimation = true;

                //Set status for word application is to be visible or not.  
                winword.Visible = true;

                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document = getWordDocument();


                //var dialog = winword.Dialogs[Word.WdWordDialog.wdDialogFilePrint];

                //int dialogResult = dialog.Show(ref missing);

                //if (dialogResult == 1)
                //{
                document.PrintOut(ref missing, ref missing, ref missing, ref missing,
                             ref missing, ref missing, ref missing, ref missing,
                             ref missing, ref missing, ref missing, ref missing,
                             ref missing, ref missing, ref missing, ref missing,
                             ref missing, ref missing);
                //}
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                throw;
            }
        }
    }
}
