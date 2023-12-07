using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using OfficeOpenXml;

namespace LogicaDeNegocio
{
    public class PdfGeneradorReporte<T> : IReporteGenerador<T>
    {
        public void GenerarReporte(List<T> data, string filePath)
        {

            using (var escrito = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(escrito))
                {
                    var document = new Document(pdf);

                    foreach (var item in data)
                    {
                        document.Add(new Paragraph(item.ToString()));
                    }

                }
            }
        }
    }
    public class ExcelGeneradorReporte<T> : IReporteGenerador<T>
    {
        public void GenerarReporte(List<T> data, string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.Add("Report");
                int row = 1;

                foreach (var item in data)
                {
                    worksheet.Cells[row, 1].Value = item.ToString();
                    row++;
                }
                package.Save();
            }
        }
    }
}
