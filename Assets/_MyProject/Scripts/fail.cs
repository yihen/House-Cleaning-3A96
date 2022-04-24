using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;


public class fail : MonoBehaviour
{

    private string excelName;

    void Start()
    {
        RunTimeTest();
    }

    void RunTimeTest()
    {
        DateTime dt = DateTime.Now;
        excelName = dt.ToString("yyyy-MM-dd") + ".xls";

        string path = Application.dataPath + "/Output/";

        if (!Directory.Exists(path))
        {
            Debug.Log("Create Directory");
            Directory.CreateDirectory(path);
        }

        Debug.Log("streaming assets: " + Application.streamingAssetsPath);


        if (System.IO.File.Exists(path + excelName))
        {
            Debug.Log("File Exist: [" + path + "]");
            //*****
            HSSFWorkbook book;
            using (FileStream file = new FileStream(@path + excelName, FileMode.Open, FileAccess.Read))
            {
                book = new HSSFWorkbook(file);
                file.Close();
            }

            ISheet sheet = book.GetSheetAt(0);

            IRow hRow = sheet.GetRow(0);
            IRow row = sheet.CreateRow(sheet.LastRowNum);
            string time = DateTime.Now.ToString("t");

            for (int i = 0; i < hRow.LastCellNum; i++)
            {
                row.CreateCell(0).SetCellValue("-");
                row.CreateCell(1).SetCellValue("-");
                row.CreateCell(2).SetCellValue("-");
                row.CreateCell(3).SetCellValue(time);
            }

            sheet.CreateRow(sheet.LastRowNum + 1).CreateCell(0).SetCellValue("-END-");

            using (FileStream file = new FileStream(@path + excelName, FileMode.Open, FileAccess.Write))
            {
                book.Write(file);
                file.Close();
            }

        }
        else
        {
            Debug.Log("File DOES NOT Exist");

            //*****
            IWorkbook book = new HSSFWorkbook();
            //using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite)) {
            //	book = new XSSFWorkbook();
            //}
            string time = DateTime.Now.ToString("t");
            ISheet sheet = book.CreateSheet("Batch" + dt.ToString("yyyy-MM-dd"));
            sheet.CreateRow(0).CreateCell(0).SetCellValue("Water");
            sheet.GetRow(0).CreateCell(1).SetCellValue("Boxes");
            sheet.GetRow(0).CreateCell(2).SetCellValue("Fires");
            sheet.GetRow(0).CreateCell(3).SetCellValue("EndTime");
            sheet.CreateRow(1).CreateCell(0).SetCellValue("-");
            sheet.GetRow(1).CreateCell(1).SetCellValue("-");
            sheet.GetRow(1).CreateCell(2).SetCellValue("-");
            sheet.GetRow(1).CreateCell(3).SetCellValue(time);


            sheet.CreateRow(sheet.LastRowNum + 1).CreateCell(0).SetCellValue("-END-");
            //save
            FileStream xfile = File.Create(path + excelName);
            book.Write(xfile);
            xfile.Close();


        }
    }
}
