using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using O2S.Components.PDFRender4NET;

namespace VehicleManagerSys.Core
{
    public class PdfHelper
    {
        private Font BoldFont { get; set; }
        private Font NormalFont { get; set; }
        private Font MixBoldFont { get; set; }
        public PdfHelper()
        {
            BaseFont ArialFont = BaseFont.CreateFont("STZHONGS.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            BoldFont = new Font(ArialFont, 11, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            NormalFont = new Font(ArialFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boldFont"></param>
        /// <param name="normalFont"></param>
        public PdfHelper(Font boldFont, Font normalFont)
        {
            BoldFont = boldFont;
            NormalFont = normalFont;

        }
        public PdfHelper(Font boldFont, Font normalFont, Font mixBoldFont)
        {
            BoldFont = boldFont;
            NormalFont = normalFont;
            MixBoldFont = mixBoldFont;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="font"></param>
        /// <returns></returns>
        public Paragraph CreateParagraph(string content, Font font)
        {
            return CreateParagraph(content, font, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="font"></param>
        /// <returns></returns>
        public Paragraph CreateParagraph(string content, Font font, bool hadSpaceInFirstLineIndent)
        {
            if (content == "")
                content = " ";

            Chunk chunk = new Chunk(content, font);
            Paragraph paragraph = new Paragraph();
            paragraph.IndentationLeft = 36f;
            paragraph.IndentationRight = 36f;
            if (hadSpaceInFirstLineIndent)
                paragraph.FirstLineIndent = 18f;
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add(chunk);
            paragraph.SpacingAfter = 12f;
            return paragraph;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="font"></param>
        /// <returns></returns>
        public Paragraph CreateTitleParagraph(string content, Font font)
        {
            if (content == "")
                content = " ";

            Chunk chunk = new Chunk(content, font);
            Paragraph paragraph = new Paragraph();
            paragraph.IndentationLeft = 36f;
            paragraph.IndentationRight = 36f;
           
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add(chunk);
            paragraph.SpacingAfter = 12f;
            return paragraph;
        }
        /// <summary>
        /// 创建文本块
        /// </summary>
        /// <param name="content"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public Chunk CreateChunk(string text, Font font)
        {
            if (text == "")
                text = " ";
            // Paragraph pg = new Paragraph(text, font);
            Chunk chunk = new Chunk(text, font);

            return chunk;
        }

        /// <summary>
        /// 创建表格，列平均分配
        /// </summary>
        /// <param name="cols">列数</param>
        /// <param name="doc">文档</param>
        /// <returns>表格</returns>
        public PdfPTable CreateTable(int cols, Document doc)
        {
            float width = doc.Right;
            return CreateTable(cols, width);
        }

        /// <summary>
        /// 创建表格，列平均分配
        /// </summary>
        /// <param name="cols">列数</param>
        /// <param name="width">总宽度</param>
        /// <returns>表格</returns>
        public PdfPTable CreateTable(int cols, float width)
        {
            float[] colList = new float[cols];
            for (int i = 0; i < cols; i++)
            {
                colList[i] = 2;
            }
            return CreateTable(colList, width);
        }

        /// <summary>
        /// 创建表格
        /// </summary>
        /// <param name="cols">列宽度(比例)</param>
        /// <param name="doc">文档</param>
        /// <returns>表格</returns>
        public PdfPTable CreateTable(float[] cols, Document doc)
        {
            float width = doc.Right;
            return CreateTable(cols, width);
        }

        /// <summary>
        /// 创建表格
        /// </summary>
        /// <param name="cols">列宽度(比例)</param>
        /// <param name="width">总宽度</param>
        /// <returns>表格</returns>
        public PdfPTable CreateTable(float[] cols, float width)
        {
            PdfPTable table = new PdfPTable(cols);
            table.TotalWidth = width;
            table.LockedWidth = true;
            return table;
        }

        public PdfPTable CreateTable(float[] cols)
        {
            PdfPTable table = new PdfPTable(cols);
            table.LockedWidth = true;
            return table;
        }


        /// <summary>
        /// 创建表格，列平均分配
        /// </summary>
        /// <param name="doc">文档</param>
        /// <returns>表格</returns>
        public void CreateGrayTable(Document doc)
        {
            float width = doc.Right;
            PdfPTable table = CreateTable(1, width);
            PdfPCell cell = CreateCell("", NormalFont, Element.ALIGN_LEFT, 1, 1,false, new BaseColor(179, 179, 179, 100));
            table.AddCell(cell);
            doc.Add(table);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public PdfPCell CreateNoWidthCell(string text, Font font, int align)
        {
            Paragraph pg = new Paragraph(text, font);
            PdfPCell cell = new PdfPCell(pg);
            cell.MinimumHeight = 26f;
            cell.UseAscender = true;
            cell.UseDescender = true;
            cell.BorderWidth = 0;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return cell;
        }
        public PdfPCell CreateNoWidthNormalCell(string text, Font font, int align)
        {
            Paragraph pg = new Paragraph(text, font);
            PdfPCell cell = new PdfPCell(pg);
            cell.UseAscender = true;
            cell.UseDescender = true;
            cell.BorderWidth = 0;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return cell;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public PdfPCell CreateCell(string text, Font font, int align)
        {
            return CreateCell(text, font, align, 1, 1, false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="align"></param>
        /// <param name="title"></param>
        /// <param name="colspan"></param>
        /// <returns></returns>
        public PdfPCell CreateCell(string text, Font font, int align, int colspan, int rowspan)
        {
            return CreateCell(text, font, align, colspan, rowspan, false, new BaseColor(134, 195, 228, 100));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="align"></param>
        /// <param name="title"></param>
        /// <param name="colspan"></param>
        /// <param name="noBorder"></param>
        /// <returns></returns>
        public PdfPCell CreateCell(string text, Font font, int align, int colspan,int rowspan, bool noBorder)
        {
            return CreateCell(text, font, align, colspan, rowspan, noBorder, new BaseColor(134, 195, 228, 100));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="align"></param>
        /// <param name="title"></param>
        /// <param name="colspan"></param>
        /// <param name="noBorder"></param>
        /// <param name="bgColor"></param>
        /// <returns></returns>
        public PdfPCell CreateCell(string text, Font font, int align, int colspan,int rowspan, bool noBorder, BaseColor bgColor)
        {
            if (text == "")
                text = " ";
            Paragraph pg = new Paragraph(text, font);
            PdfPCell cell = new PdfPCell(pg);
            cell.UseAscender = true;
            cell.UseDescender = true;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = colspan;
            cell.MinimumHeight = 15f;
            cell.Rowspan = rowspan;
            //if (title)
            //    cell.BackgroundColor = bgColor;
            if (noBorder)
                cell.BorderWidth = 0;
            else
                cell.BorderWidth = 0.3F;
            return cell;
        }

        #region 调整Cell的高度

        public PdfPCell CreateCustomCell(string text, Font font, int align)
        {
            return CreateCustomCell(text, font, align, 1);
        }
        public PdfPCell CreateCustomCell(string text, Font font, int align, int colspan)
        {
            if (text == "")
                text = " ";
            Paragraph pg = new Paragraph(text, font);
            PdfPCell cell = new PdfPCell(pg);
            cell.UseAscender = true;
            cell.UseDescender = true;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = colspan;
            cell.MinimumHeight = 19;
            return cell;
        }
        #endregion

        public void AddHeader(PdfPTable table, string text, Font font, int colspan)
        {
            Paragraph pr = new Paragraph(text, font);
            pr.Alignment = 1;
            PdfPCell header = new PdfPCell(pr);
            header.UseAscender = true;
            header.SetLeading(0, 0);
            header.Colspan = colspan;
            header.Border = Rectangle.NO_BORDER;
            header.HorizontalAlignment = Element.ALIGN_CENTER;
            header.MinimumHeight = 26f;
            table.AddCell(header);

        }

        public void AddRows(PdfPTable table, string text, int rowspan)
        {
            AddRows(table, text, rowspan, false);
        }

        public void AddRows(PdfPTable table, string text, int rowspan, bool title)
        {
            AddRows(table, text, rowspan, title, Element.ALIGN_RIGHT);
        }
        public void AddRows(PdfPTable table, string text, int rowspan, bool title, int align)
        {
            PdfPCell rows = new PdfPCell(new Phrase(text, NormalFont));
            rows.Rowspan = rowspan;
            rows.HorizontalAlignment = align;
            rows.VerticalAlignment = Element.ALIGN_MIDDLE;
            if (title)
                rows.BackgroundColor = new BaseColor(134, 195, 228, 100);
            table.AddCell(rows);
        }

        public void AddBoldRows(PdfPTable table, string text, int rowspan)
        {
            PdfPCell rows = new PdfPCell(new Phrase(text, MixBoldFont));
            rows.Rowspan = rowspan;
            rows.HorizontalAlignment = Element.ALIGN_RIGHT;
            rows.VerticalAlignment = Element.ALIGN_MIDDLE;
            rows.MinimumHeight = 38;
            table.AddCell(rows);
        }
        public void AddRightLeftCell(PdfPTable table, string caption, string value1, int colspan)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            PdfPCell cell = CreateCell(value1, NormalFont, Element.ALIGN_LEFT);
            cell.Colspan = colspan;
            table.AddCell(cell);
        }

        public void AddRightLeftCell(PdfPTable table, string caption, string value1, string value2, string value3)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCell(value1, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value2, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value3, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddRightLeftCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(value4, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddRightLeftCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4, string value5)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCell(value1, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value2, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value3, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value4, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value5, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddTopRightCenterCell(PdfPTable table, string caption, string value)
        {
            table.AddCell(CreateNoWidthCell(caption, NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateNoWidthCell(value, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddTopLeftLeftCell(PdfPTable table, string caption, string value)
        {
            table.AddCell(CreateNoWidthCell(caption, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateNoWidthCell(value, NormalFont, Element.ALIGN_LEFT));
        }
        public void AddLeftCell(PdfPTable table, string caption)
        {
            AddLeftCell(table, caption, 1, false);
        }

        public void AddLeftCell(PdfPTable table, string caption, int colspan, bool noBorder)
        {
            PdfPCell cell = CreateCell(caption, NormalFont, Element.ALIGN_LEFT, colspan,1, noBorder);
            table.AddCell(cell);
        }
        public void AddLeftCell(PdfPTable table, string caption, BaseColor bgColor)
        {
            PdfPCell cell = CreateCell(caption, NormalFont, Element.ALIGN_LEFT);
            cell.BackgroundColor = bgColor;
            table.AddCell(cell);

        }
        public void AddCenterCell(PdfPTable table, string caption)
        {
            PdfPCell cell = CreateCell(caption, NormalFont, Element.ALIGN_CENTER);
            table.AddCell(cell);
        }

        public void AddCenterCell(PdfPTable table, string caption, BaseColor bgColor)
        {
            PdfPCell cell = CreateCell(caption, NormalFont, Element.ALIGN_CENTER);
            cell.BackgroundColor = bgColor;
            table.AddCell(cell);
        }
        public void AddCenterCell(PdfPTable table, string caption, BaseColor bgColor, int height)
        {
            PdfPCell cell = CreateCell(caption, NormalFont, Element.ALIGN_CENTER);
            cell.BackgroundColor = bgColor;
            cell.MinimumHeight = height;
            table.AddCell(cell);
        }
        public void AddCenterCell(PdfPTable table, string caption, BaseColor bgColor, Font font)
        {
            PdfPCell cell = CreateCell(caption, font, Element.ALIGN_CENTER);
            cell.BackgroundColor = bgColor;
            table.AddCell(cell);
        }

        public void AddRightCenterCell(PdfPTable table, string caption, string value)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCell(value, NormalFont, Element.ALIGN_CENTER));
        }

        public void AddDataRightCenterCell(PdfPTable table, string caption, string value)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value, NormalFont, Element.ALIGN_CENTER));
        }


        public void AddRightCenterCell(PdfPTable table, string caption, string value, int colspan)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            PdfPCell cell = CreateCell(value, NormalFont, Element.ALIGN_LEFT);
            cell.Colspan = colspan;
            cell.MinimumHeight = 27;
            table.AddCell(cell);
        }

        public void AddRightCenterCell(PdfPTable table, string caption, string value1, string value2, string value3)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value3, NormalFont, Element.ALIGN_CENTER));
        }

        public void AddRightCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value4, NormalFont, Element.ALIGN_CENTER));
        }

        public void AddBoldCaptionCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value2, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value4, MixBoldFont, Element.ALIGN_CENTER));
        }

        public void AddCaptionRightCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value2, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, MixBoldFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value4, MixBoldFont, Element.ALIGN_CENTER));
        }

        public void AddBodyRightCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value4, NormalFont, Element.ALIGN_LEFT));
        }
        public void AddBodyRightCenterCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value4, NormalFont, Element.ALIGN_CENTER));
        }

        public void AddBodyRightCenterCenterCellToEnginDetail(PdfPTable table, string caption, string value1, string value2, string value3, string value4)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER, 3));

            table.AddCell(CreateCustomCell(value4, NormalFont, Element.ALIGN_CENTER));
        }
        public void AddRightCenterCell(PdfPTable table, string caption, string value1, string value2, string value3, string value4, string value5)
        {
            table.AddCell(CreateCell(caption, NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value3, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value4, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCell(value5, NormalFont, Element.ALIGN_CENTER));
        }

        public void AddRightLeftRightLeftCell(PdfPTable table, string caption1, string value1, string caption2, string value2)
        {
            table.AddCell(CreateCustomCell(caption1, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(caption2, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddRightLeftRightLeftCell(PdfPTable table, string caption1, string value1, string caption2, string value2, string value3)
        {
            table.AddCell(CreateCustomCell(caption1, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(caption2, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_LEFT));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddRightCenterRightCenterCenterCell(PdfPTable table, string caption1, string value1, string caption2, string value2, string value3)
        {
            table.AddCell(CreateCustomCell(caption1, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(caption2, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_CENTER));
        }
        public void AddRightLeftRightCenterCell(PdfPTable table, string caption1, string value1, string caption2, string value2, string value3)
        {
            table.AddCell(CreateCustomCell(caption1, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value1, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(caption2, MixBoldFont, Element.ALIGN_RIGHT));
            table.AddCell(CreateCustomCell(value2, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(CreateCustomCell(value3, NormalFont, Element.ALIGN_LEFT));
        }

        public void AddTitleRow(PdfPTable table, string caption, int colspan)
        {
            PdfPCell header = new PdfPCell(new Phrase(caption, MixBoldFont));
            header.Colspan = colspan;
            header.BackgroundColor = new BaseColor(134, 195, 228, 100);
            header.MinimumHeight = 19;
            //header.Border = Rectangle.NO_BORDER;
            header.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(header);
        }

        public void AddTitleRow(PdfPTable table, string caption, int colspan, bool isRemark)
        {
            PdfPCell header = new PdfPCell(new Phrase(caption, MixBoldFont));
            header.Colspan = colspan;
            header.MinimumHeight = 19;
            header.BackgroundColor = new BaseColor(134, 195, 228, 100);
            //header.Border = Rectangle.NO_BORDER;
            if (isRemark)
            {
                header.HorizontalAlignment = Element.ALIGN_CENTER;
            }
            table.AddCell(header);
        }

        public void AddTitleCenterCell(PdfPTable table, string caption)
        {
            PdfPCell header = new PdfPCell(new Phrase(caption, NormalFont));
            header.BackgroundColor = new BaseColor(134, 195, 228, 100);
            //header.Border = Rectangle.NO_BORDER;
            header.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(header);
        }

        /*
        public void AddFullTitleRow(PdfPTable table, string caption)
        {
            PdfPCell header = new PdfPCell(new Phrase(caption, BoldFont));
            header.Colspan = 5;
            //header.Border = Rectangle.NO_BORDER;
            header.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(header);
        }
        */
        public PdfPTable NewTable(Document doc)
        {
            PdfPTable table = new PdfPTable(new float[] { 2, 2, 2, 2, 2 });
            float width = doc.Right;
            table.TotalWidth = width;
            table.LockedWidth = true;
            return table;
        }

        public void AddFullRightLeftCell(PdfPTable table, string caption, string value, int colspan)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            PdfPCell cell = CreateCustomCell(value, NormalFont, Element.ALIGN_LEFT);
            cell.Colspan = colspan;
            table.AddCell(cell);
        }

        public void AddFullRightCenterCell(PdfPTable table, string caption, string value, int colspan)
        {
            table.AddCell(CreateCustomCell(caption, MixBoldFont, Element.ALIGN_RIGHT));
            PdfPCell cell = CreateCustomCell(value, NormalFont, Element.ALIGN_CENTER);
            cell.Colspan = colspan;
            table.AddCell(cell);
        }

        public System.Drawing.Imaging.ImageFormat GetImageFormatFromExtName(string extName)
        {
            System.Drawing.Imaging.ImageFormat result = System.Drawing.Imaging.ImageFormat.Bmp;
            switch (extName.ToLower())
            {
                case "jpg":
                    result = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case "jpeg":
                    result = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case "ico":
                    result = System.Drawing.Imaging.ImageFormat.Icon;
                    break;
                case "gif":
                    result = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
                case "png":
                    result = System.Drawing.Imaging.ImageFormat.Png;
                    break;


            }
            return result;

        }

        public Image CreateBMPImage(byte[] btImg, float width, float height)
        {
            //  MemoryStream ms = new MemoryStream(btImg);
            // System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            //  Image img = Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Bmp);

            Image img = Image.GetInstance(btImg);
            img.Alignment = Image.ALIGN_CENTER;
            img.ScaleAbsolute(width, height);
            //  img.CompressionLevel = PdfStream.BEST_COMPRESSION;


            return img;
        }

        public Image CreateImage(byte[] btImg, float width, float height)
        {
            //  MemoryStream ms = new MemoryStream(btImg);
            // System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            //  Image img = Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] tmp = ImageGdi(btImg, width, height);
            Image img = Image.GetInstance(tmp);
            img.Alignment = Image.ALIGN_CENTER;
            
            img.ScaleAbsolute(width, height);
            //img.CompressionLevel = PdfStream.BEST_COMPRESSION;

            //   ms.Close();
            //   ms.Dispose();
            return img;
        }

        public Image CreateImage(byte[] btImg)
        {
            //  MemoryStream ms = new MemoryStream(btImg);
            // System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            //  Image img = Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Bmp);
            //byte[] tmp = ImageGdi(btImg, width, height);
            Image img = Image.GetInstance(btImg);
            img.Alignment = Image.ALIGN_CENTER;

            //img.ScaleAbsolute(width, height);
            //img.CompressionLevel = PdfStream.BEST_COMPRESSION;

            //   ms.Close();
            //   ms.Dispose();
            return img;
        }

        ///
        /// GDI压缩图片
        ///
        /// 传入参数Bitmap
        ///
        private byte[] ImageGdi(byte[] img, float new_width, float new_height)
        {
            byte[] buffer;
            if (img.Length > 300000)
            {

                MemoryStream ms = new MemoryStream(img);
                System.Drawing.Image m_src_image = System.Drawing.Image.FromStream(ms);


                System.Drawing.Bitmap bbmp = new System.Drawing.Bitmap((int)new_width, (int)new_height, m_src_image.PixelFormat);
                System.Drawing.Graphics m_graphics = System.Drawing.Graphics.FromImage(bbmp);
                m_graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                m_graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                m_graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                m_graphics.DrawImage(m_src_image, 0, 0, bbmp.Width, bbmp.Height);

                ms = new MemoryStream();

                bbmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                buffer = ms.GetBuffer();
                ms.Close();
                ms.Dispose();
                return buffer;
            }
            else
            {

                return img;
            }
        }

        public Document CreateDocument()
        {
            Document doc = new Document(PageSize.A3.Rotate(), 10, 10, 110, 55);

            return doc;
        }


        public Document CreateDocument(bool useA4, float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            Document doc;
            if (useA4)
                doc = new Document(PageSize.A4.Rotate(), 36, 36, 36, 36);
            else
                doc = new Document(PageSize.A3.Rotate(), 36, 36, 36, 36);

            doc.SetMargins(marginLeft, marginRight, marginTop, marginBottom);
            return doc;
        }
        public Document CreateDocumentA4()
        {
            return CreateDocumentA4(10, 10, 150, 100);
        }

        public Document CreateDocument(int width, int height)
        {
            return new Document(new Rectangle(width, height));
        }

        public Document CreateDocumentA4(float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            Document doc = new Document(PageSize.A4, 36, 36, 36, 36);
            doc.SetMargins(marginLeft, marginRight, marginTop, marginBottom);
            return doc;
        }

        public void DrawLine(PdfContentByte canvas,float beginX,float beginY,float endX,float endY)
        {
            canvas.SaveState();
            canvas.MoveTo(beginX, beginY);
            canvas.LineTo(endX, endY);
            canvas.Stroke();
            canvas.RestoreState();

        }


        /// <summary>
        /// 创建无边框单元格
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <returns></returns>
        public PdfPCell CreateNoWidthCell(string text, Font font)
        {
            Paragraph pg = new Paragraph(text, font);
            PdfPCell cell = new PdfPCell(pg);
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Border = Rectangle.NO_BORDER;
            return cell;
        }

        /// <summary>
        /// 创建无边框单元格
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <returns></returns>
        public PdfPCell CreateNoWidthCell(string caption, Font captionFont, string text, Font font)
        {
            Chunk chunkCaption = new Chunk(caption, captionFont);

            PdfPCell cell = new PdfPCell();
            Phrase phrase = new Phrase();

            phrase.Add(chunkCaption);

            if (!string.IsNullOrEmpty(text))
            {
                Chunk chunkText = new Chunk(text, font);

                phrase.Add(chunkText);
            }
            phrase.Leading = 10f;
            cell.AddElement(phrase);
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Border = Rectangle.NO_BORDER;
            return cell;
        }

        public PdfPCell EmptyCell
        {
            get
            {
                Paragraph pg = new Paragraph(" ", NormalFont);
                PdfPCell cell = new PdfPCell(pg);
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Border = Rectangle.NO_BORDER;
                return cell;
            }
        }

        public void ConcatPDFs(List<MemoryStream> streamOfPDFFiles, MemoryStream outputStream, bool paginate, bool userA3, bool pageCenter)
        {
            Document document;
            if (userA3)
                document = CreateDocument();
            else
                document = CreateDocumentA4();
            try
            {
                #region test
                //try
                //{
                //    string fileName = "D:\\1.pdf";
                //    Document test = CreateDocument();

                //    FileStream outputStream1 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                //    PdfWriter writer2 = PdfWriter.GetInstance(test, outputStream1);
                //    test.Open();
                //    test.Add(CreateParagraph("MYName is Google",NormalFont));
                //    test.Add(new Paragraph("This is a custom size"));
                //    test.Add(CreateParagraph("Who is Google", NormalFont));



                //    outputStream1.Flush();
                //    test.Close();
                //    outputStream1.Close();

                //}
                //catch
                //{
                //}
                #endregion
                List<MemoryStream> pdfs = streamOfPDFFiles;
                List<PdfReader> readers = new List<PdfReader>();
                int totalPages = 0;

                foreach (MemoryStream pdf in pdfs)
                {
                    if (pdf != null)
                    {
                        MemoryStream ms = new MemoryStream(pdf.ToArray());
                        PdfReader pdfReader = new PdfReader(ms);

                        readers.Add(pdfReader);

                        totalPages += pdfReader.NumberOfPages;
                        ms.Flush();
                        ms.Close();
                    }
                }
                // Create a writer for the outputstream
                PdfWriter writer = PdfWriter.GetInstance(document, outputStream);

                document.Open();
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                PdfContentByte cb = writer.DirectContent; // Holds the PDF
                // data

                PdfImportedPage page;
                int currentPageNumber = 0;
                int pageOfCurrentReaderPDF = 0;
                foreach (PdfReader pdfReader in readers)
                {
                    while (pageOfCurrentReaderPDF < pdfReader.NumberOfPages)
                    {

                        pageOfCurrentReaderPDF++;
                        currentPageNumber++;
                        document.SetPageSize(pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF));

                        document.NewPage();
                        page = writer.GetImportedPage(pdfReader, pageOfCurrentReaderPDF);
                        // cb.AddTemplate(page, 0, 0);

                        int rotation = pdfReader.GetPageRotation(pageOfCurrentReaderPDF);
                        //switch (rotation)
                        //{
                        //    case 90:
                        //        cb.AddTemplate(page, 0, -1, 1, 0, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Height);
                        //        if (paginate)
                        //        {
                        //            cb.BeginText();
                        //            cb.SetFontAndSize(bf, 9);
                        //            if (pageCenter)
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right / 2, 20, 0);
                        //            else
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right - 30, 20, 0);
                        //            cb.EndText();
                        //        }
                        //        break;
                        //    case 180:
                        //        cb.AddTemplate(page, -1, 0, 0, -1, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Width, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Height);
                        //        if (paginate)
                        //        {
                        //            cb.BeginText();
                        //            cb.SetFontAndSize(bf, 9);
                        //            if (pageCenter)
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, document.Right / 2, 270);
                        //            else
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, 30, 270);

                        //            cb.EndText();
                        //        }
                        //        break;
                        //    case 270:
                        //        cb.AddTemplate(page, 0, 1, -1, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Width, 0);
                        //        if (paginate)
                        //        {
                        //            cb.BeginText();
                        //            cb.SetFontAndSize(bf, 9);
                        //            if (pageCenter)
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right / 2, 20, 0);
                        //            else
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right - 30, 20, 0);
                        //            cb.EndText();
                        //        }
                        //        break;
                        //    default:
                        //        cb.AddTemplate(page, 1, 0, 0, 1, 0, 0);//等同于 cb.AddTemplate(page1, 0,0)
                        //        if (paginate)
                        //        {
                        //            cb.BeginText();
                        //            cb.SetFontAndSize(bf, 9);
                        //            if (pageCenter)
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, document.Right / 2, 270);
                        //            else
                        //                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, 30, 270);

                        //            cb.EndText();
                        //        }
                        //        break;
                        //}

                        #region rotation handle old
                        if (rotation == 90 || rotation == 270)
                        {
                            //landscape mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Height);
                            if (paginate)
                            {
                                cb.BeginText();
                                cb.SetFontAndSize(bf, 9);
                                if (pageCenter)
                                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right / 2, 20, 0);
                                else
                                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right - 30, 20, 0);
                                cb.EndText();
                            }
                        }
                        else
                        {
                            //portrait mode
                            //portrait mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Width);

                            if (paginate)
                            {
                                cb.BeginText();
                                cb.SetFontAndSize(bf, 9);
                                if (pageCenter)
                                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, document.Right / 2, 270);
                                else
                                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, 30, 270);

                                cb.EndText();
                            }
                        }
                        #endregion
                        // Code for pagination.
                    }
                    pageOfCurrentReaderPDF = 0;
                }
                outputStream.Flush();
                document.Close();
                outputStream.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (document.IsOpen())
                    document.Close();
                try
                {
                    if (outputStream != null)
                        outputStream.Close();
                }
                catch (IOException ioe)
                {
                    throw new Exception(ioe.Message);

                }
            }
        }


        public void AddText(PdfWriter pdfWriter,BaseFont font, int x,int y,string text)
        {
            PdfContentByte pb = pdfWriter.DirectContent;
            pb.BeginText();
            pb.SetFontAndSize(font, 9);
            pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,text, x, y, 0);
            pb.EndText();
        }
        public void ConcatOnePDF(MemoryStream streamOfPDFFile, string fileName, bool userA3)
        {
            if (streamOfPDFFile == null) return;
            Document document;
            FileStream outputStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            if (userA3)
                document = CreateDocument();
            else
                document = CreateDocumentA4();
            try
            {
                int totalPages = 0;
                MemoryStream ms = new MemoryStream(streamOfPDFFile.ToArray());
                PdfReader pdfReader = new PdfReader(ms);

                totalPages += pdfReader.NumberOfPages;
                PdfWriter writer = PdfWriter.GetInstance(document, outputStream);
                document.Open();
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                PdfContentByte cb = writer.DirectContent; // Holds the PDF

                // data

                PdfImportedPage page;
                int currentPageNumber = 0;
                int pageOfCurrentReaderPDF = 0;

                while (pageOfCurrentReaderPDF < pdfReader.NumberOfPages)
                {
                    document.NewPage();
                    pageOfCurrentReaderPDF++;
                    currentPageNumber++;

                    page = writer.GetImportedPage(pdfReader, pageOfCurrentReaderPDF);
                    // cb.AddTemplate(page, 0, 0);

                    int rotation = pdfReader.GetPageRotation(1);
                    if (rotation == 90 || rotation == 270)
                    {
                        //landscape mode
                        cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Height);
                    }
                    else
                    {
                        //portrait mode
                        cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Width);

                    }


                }


                pageOfCurrentReaderPDF = 0;

                outputStream.Flush();

                document.Close();
                ms.Close();
                streamOfPDFFile.Flush();
                streamOfPDFFile.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (document.IsOpen())
                    document.Close();
                try
                {
                    if (outputStream != null)
                        outputStream.Close();
                }
                catch (IOException ioe)
                {
                    throw new Exception(ioe.Message);

                }
            }
        }

        public void ConcatMulPDF(string[] pfdFiles, string fileName, bool userA3)
        {
            Document document;
            FileStream outputStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            if (userA3)
                document = CreateDocument();
            else
                document = CreateDocumentA4();

            try
            {

                List<PdfReader> readers = new List<PdfReader>();
                int totalPages = 0;

                foreach (string pdf in pfdFiles)
                {
                    if (File.Exists(pdf))
                    {
                        PdfReader pdfReader = new PdfReader(pdf);
                        readers.Add(pdfReader);
                        totalPages += pdfReader.NumberOfPages;
                    }
                }
                // Create a writer for the outputstream
                PdfWriter writer = PdfWriter.GetInstance(document, outputStream);
                // writer.CompressionLevel = PdfStream.BEST_COMPRESSION;

                document.Open();
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                PdfContentByte cb = writer.DirectContent; // Holds the PDF

                // data

                PdfImportedPage page;
                int currentPageNumber = 0;
                int pageOfCurrentReaderPDF = 0;
                foreach (PdfReader pdfReader in readers)
                {
                    while (pageOfCurrentReaderPDF < pdfReader.NumberOfPages)
                    {
                        document.NewPage();
                        pageOfCurrentReaderPDF++;
                        currentPageNumber++;
                        page = writer.GetImportedPage(pdfReader, pageOfCurrentReaderPDF);
                        // cb.AddTemplate(page, 0, 0);

                        int rotation = pdfReader.GetPageRotation(1);
                        if (rotation == 90 || rotation == 270)
                        {
                            //landscape mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Height);
                        }
                        else
                        {
                            //portrait mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Width);

                        }

                        if (rotation == 90 || rotation == 270)
                        {
                            //landscape mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Height);

                            cb.BeginText();
                            cb.SetFontAndSize(bf, 9);

                            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, document.Right - 30, 20, 0);
                            cb.EndText();

                        }
                        else
                        {
                            //portrait mode
                            //portrait mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(pageOfCurrentReaderPDF).Width);


                            cb.BeginText();
                            cb.SetFontAndSize(bf, 9);

                            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "" + currentPageNumber + " of " + totalPages, 20, 30, 270);

                            cb.EndText();

                        }

                    }
                    pageOfCurrentReaderPDF = 0;
                }

                outputStream.Flush();

                document.Close();

                foreach (var item in readers)
                {

                    item.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (document.IsOpen())
                    document.Close();
                try
                {
                    if (outputStream != null)
                        outputStream.Close();
                }
                catch (IOException ioe)
                {
                    throw new Exception(ioe.Message);

                }
            }
        }

        public void ConcatPDFs(List<MemoryStream> streamOfPDFFiles, FileStream outputStream, bool userA3)
        {
            Document document;
            if (userA3)
                document = CreateDocument();
            else
                document = CreateDocumentA4();
            try
            {
                List<MemoryStream> pdfs = streamOfPDFFiles;
                List<PdfReader> readers = new List<PdfReader>();
                int totalPages = 0;

                foreach (MemoryStream pdf in pdfs)
                {
                    MemoryStream ms = new MemoryStream(pdf.ToArray());
                    PdfReader pdfReader = new PdfReader(ms);
                    readers.Add(pdfReader);
                    totalPages += pdfReader.NumberOfPages;
                }
                // Create a writer for the outputstream
                PdfWriter writer = PdfWriter.GetInstance(document, outputStream);

                document.Open();
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                PdfContentByte cb = writer.DirectContent; // Holds the PDF

                // data

                PdfImportedPage page;
                int currentPageNumber = 0;
                int pageOfCurrentReaderPDF = 0;
                foreach (PdfReader pdfReader in readers)
                {
                    while (pageOfCurrentReaderPDF < pdfReader.NumberOfPages)
                    {
                        document.NewPage();
                        pageOfCurrentReaderPDF++;
                        currentPageNumber++;
                        page = writer.GetImportedPage(pdfReader, pageOfCurrentReaderPDF);

                        // cb.AddTemplate(page, 0, 0);

                        int rotation = pdfReader.GetPageRotation(pageOfCurrentReaderPDF);
                        if (rotation == 90 || rotation == 270)
                        {
                            //landscape mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Height);
                        }
                        else
                        {
                            //portrait mode
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, pdfReader.GetPageSizeWithRotation(1).Width);

                        }

                    }
                    pageOfCurrentReaderPDF = 0;
                }
                outputStream.Flush();
                document.Close();
                outputStream.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (document.IsOpen())
                    document.Close();
                try
                {
                    if (outputStream != null)
                        outputStream.Close();
                }
                catch (IOException ioe)
                {
                    throw new Exception(ioe.Message);

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public enum Definition
        {
            One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="pic">图片文件</param>
        /// <param name="pageNum">转换第几页</param>
        /// <param name="imageFormat">设置所需图片格式</param>
        /// <param name="definition">设置图片的清晰度，数字越大越清晰</param>
        public void ConvertPDF2Image(MemoryStream pdfInputPath, MemoryStream pic, int pageNum, System.Drawing.Imaging.ImageFormat imageFormat, Definition definition)
        {
            try
            {
                pdfInputPath = new MemoryStream(pdfInputPath.ToArray());
                O2S.Components.PDFRender4NET.PDFFile pdfFile = O2S.Components.PDFRender4NET.PDFFile.Open(pdfInputPath);

                System.Drawing.Bitmap pageImage = pdfFile.GetPageImage(pageNum - 1, 56 * (int)definition);
                pageImage.Save(pic, imageFormat);
                pageImage.Dispose();

                pdfFile.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void CreatePdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 110, 55);
            try
            {
                Font titleFont = new Font(BaseFont.CreateFont(), 12, iTextSharp.text.Font.BOLD ^ iTextSharp.text.Font.UNDERLINE, new BaseColor(System.Drawing.Color.Black));
                Chunk chunk = new Chunk("123456", titleFont);
                Paragraph paragraph = new Paragraph();
                paragraph.IndentationLeft = 36f;
                paragraph.IndentationRight = 36f;
                paragraph.Alignment = Element.ALIGN_LEFT;
                paragraph.Add(chunk);
                paragraph.SpacingAfter = 12f;

         
                doc.Open();
                doc.NewPage();
                doc.Add(paragraph);

                //PdfWriter pdfWriter =  PdfWriter.GetInstance(,)
                
            }
            finally
            {
                doc.Close();
            }
        }

        public int printShow(string url)
        {
            int isOK = 0;
            PDFFile file = PDFFile.Open(url);
            PrinterSettings settings = new PrinterSettings();
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            settings.PrinterName = "Adobe PDF"; // 打印机名称
            settings.PrintToFile = false;

            //设置纸张大小（可以不设置，取默认设置）3.90 in,  8.65 in
            PaperSize ps = new PaperSize("test", 1, 1);
            ps.RawKind = 9; //如果是自定义纸张，就要大于118，（A4值为9，详细纸张类型与值的对照请看http://msdn.microsoft.com/zh-tw/library/system.drawing.printing.papersize.rawkind(v=vs.85).aspx）

            O2S.Components.PDFRender4NET.Printing.PDFPrintSettings pdfPrintSettings = new O2S.Components.PDFRender4NET.Printing.PDFPrintSettings(settings);
            pdfPrintSettings.PaperSize = ps;
            pdfPrintSettings.PageScaling = O2S.Components.PDFRender4NET.Printing.PageScaling.FitToPrinterMarginsProportional;
            pdfPrintSettings.PrinterSettings.Copies = 1;

            try
            {
                file.Print(pdfPrintSettings);
                isOK = 1;
            }
            catch (Exception ex)
            {
                isOK = -1;
                throw;
            }
            finally
            {
                file.Dispose();
            }
            return isOK;
        }
    }
}

/*
 *  PdfHelper pdfHelper = new PdfHelper();
            Document doc = pdfHelper.CreateDocumentA4();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
          doc.Open();
                doc.NewPage();
                     BaseFont ArialFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font BoldFont = new iTextSharp.text.Font(ArialFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
                   iTextSharp.text.Image img = pdfHelper.CreateImage(qrcode, 100, 100f);
                img.SetAbsolutePosition(AppHelper.PointSetting.X_QRCode, AppHelper.PointSetting.Y_QRCode);
                doc.Add(img);
                                PrintPoint print = AppHelper.PointSetting;
                PdfContentByte pb = writer.DirectContent;
                pb.BeginText();
                pb.SetFontAndSize(ArialFont, 9);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("yyyy"), print.X_Year, print.Y_Year, 0);
                    pb.EndText();

                doc.Close();
                MemoryStream pdf = new MemoryStream(memoryStream.ToArray());

                PDFFile pdfFile = PDFFile.Open(pdf);
                PrinterSettings settings = new PrinterSettings();
                PrintDocument pd = new PrintDocument();
                settings.PrinterName = AppHelper.AppSetting.PrinterName;
                settings.PrintToFile = false;

                PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
                pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional;
                pdfPrintSettings.PrinterSettings.Copies = 1;
                pdfFile.Print(pdfPrintSettings);
                pdf.Close();
                pdf.Dispose();
                pdfFile.Dispose();
 */
