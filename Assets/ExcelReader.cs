using System.IO;
using OfficeOpenXml;
using UnityEngine;
using UnityEngine.UI;

public class ExcelReader : MonoBehaviour
{
    [SerializeField] private Text label;

    private void Start()
    {
        string filePath = @$"{Application.streamingAssetsPath}\ExampleExcel.xlsx";

        FileInfo fileInfo = new FileInfo(filePath);

        using ExcelPackage excelPackage = new ExcelPackage(fileInfo);
        ExcelWorksheet firstSheet = excelPackage.Workbook.Worksheets[1];

        if (firstSheet.Cells.Value is object[,] cells)
        {
            string result = $"{cells[1, 0]} {cells[1, 1]} {cells[1, 2]}";

            print(result);
            label.text = result;
        }
    }
}