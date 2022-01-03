using EISProject.ControlForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.DataBaseFunctions
{
  public  class EmployeeFile
    {

       private static string filePath = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\employeeFiles";

        public static void AddFilesToEmployee(Dictionary<string,Guna.UI.WinForms.GunaTextBox>fileNames,int employeeId)
        {

            // TODO: store employee files by iterating through filanames values dictionary 

            using(var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var fileDb = new Employees_Documents_Table();
                var employeeName = dbModel.Employee_Information_Table
                            .Where(n => n.employee_id == employeeId)
                            .FirstOrDefault();
                // iterate values of filenames dictionaries 
                foreach (var file in fileNames.Values)
                {

                    if (file.Text != string.Empty)
                    {
                        var fileType = GetFileType(file.Name);

                        System.IO.File.Copy(file.Text, $@"{filePath}\{employeeId}-{fileType}.pdf");

                        fileDb.employee_id = employeeId;
                        fileDb.employee_name = $"{employeeName.last_name}, {employeeName.given_name} {employeeName.middle_name}";
                        fileDb.date_uploaded = DateTime.Today;
                        fileDb.filetype = fileType;
                        fileDb.filename = $@"{filePath}\{fileDb.employee_id}-{GetFileType(file.Name)}.pdf";
                        fileDb.file_size = GetFileSize(file.Text);


                        try
                        {
                            // add fileDb Object to employee Doc Table
                            dbModel.Employees_Documents_Table.Add(fileDb);
                            //
                            //copy the filepath of the file to the employeeFiles folder
                       

                            dbModel.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Ooopps something went Wrong!\n{ex.Message}\n{ex.InnerException}", "An Error Occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                if (EISMainForm.Emp_File_HasClick)
                {
                    //refresh EmployeeFilesGridView
                    EmployeeFilesUi.DocGrid.PopulateGridView(EmployeeFilesUi.DocGrid.fullList = dbModel.Employees_Documents_Table.ToList());
                }

            }

           

        }

        private static string GetFileSize(string file)
        {
            var fileLength = new System.IO.FileInfo(file).Length;

            if (fileLength >= (1 << 10))
                return $"{fileLength >> 10} Kb";
            else if (fileLength >= (1 << 20))
                return $"{fileLength >> 20} Mb";
            else
                return $"{fileLength} Bytes";
        }

        public static void CheckEmployeeDocs(int employeeId)
        {
            using (var docModel = new EmployeeInformationSystemDataBaseEntities())
            {

                int documents = docModel.Employees_Documents_Table.Where(i => i.employee_id == employeeId).Count();
                var employee = docModel.Employee_Information_Table.Where(i => i.employee_id == employeeId).FirstOrDefault();
                if (documents == 6)
                {
  
                    employee.required_documents = "COMPLETED";
                    docModel.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    employee.required_documents = "INCOMPLETE";
                    docModel.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                }

                docModel.SaveChanges();

                // refreshing ActiveGridView
                if(EISMainForm.Active_Emp_HasClick)
                ActiveEmployeeUi.GridObj.PopulateGridView(ActiveEmployeeUi.GridObj.fullList = docModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").ToList());
            }
        }


        public static void DeleteEmployeeFiles(int employeeId)
        {
            using(var dbModel =new EmployeeInformationSystemDataBaseEntities())
            {
                var fileList = dbModel.Employees_Documents_Table.Where(i => i.employee_id == employeeId).ToList();

                foreach (var file in fileList)
                {
                    System.IO.File.Delete(file.filename);
                    dbModel.Entry(file).State = System.Data.Entity.EntityState.Deleted;
                    dbModel.SaveChanges();
                }
            }
        }


        public static void DeleteSingleFile(int fileId)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var fileItem = dbModel.Employees_Documents_Table.Where(i => i.file_id == fileId).FirstOrDefault();
                System.IO.File.Delete(fileItem.filename);
                dbModel.Entry(fileItem).State = System.Data.Entity.EntityState.Deleted;
                dbModel.SaveChanges();

                if (EISMainForm.Emp_File_HasClick)
                    ControlForms.EmployeeFilesUi.DocGrid.PopulateGridView(ControlForms.EmployeeFilesUi.DocGrid.fullList = dbModel.Employees_Documents_Table.ToList());
            }
        }
       
        public static void UploadSingleFile(int employeeId,string fileType,string empFilePath)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var empName = dbModel.Employee_Information_Table.Where(i => i.employee_id == employeeId).SingleOrDefault();

                System.IO.File.Copy(empFilePath, $@"{filePath}\{employeeId}-{fileType}.pdf");

                var empFile = new Employees_Documents_Table()
                {
                    filename = $@"{filePath}\{employeeId}-{fileType}.pdf",
                    filetype = fileType,
                    file_size = GetFileSize(empFilePath),
                    employee_name = $"{empName.last_name }, { empName.given_name} {empName.middle_name }",
                    employee_id = employeeId,
                    date_uploaded = DateTime.Today
                    
                };

                dbModel.Employees_Documents_Table.Add(empFile);
                dbModel.SaveChanges();


                if (EISMainForm.Emp_File_HasClick)
                    ControlForms.EmployeeFilesUi.DocGrid.PopulateGridView(ControlForms.EmployeeFilesUi.DocGrid.fullList = dbModel.Employees_Documents_Table.ToList());
            }
        }

        public static void DeleteAllFiles()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                dbModel.Database.ExecuteSqlCommand("TRUNCATE TABLE Employees_Documents_Table");

                if(EISMainForm.Emp_File_HasClick)
                ControlForms.EmployeeFilesUi.DocGrid.PopulateGridView(ControlForms.EmployeeFilesUi.DocGrid.fullList = dbModel.Employees_Documents_Table.ToList());
            }

            var directory = new System.IO.DirectoryInfo(filePath);

            foreach (var file in directory.EnumerateFiles())
            {
                file.Delete();
            }
        }

       private static string GetFileType(string fileName)
        {
            // TODO : return the correct filetype of fileName
            Dictionary<string, string> fileTypes = new Dictionary<string, string>()
            {

                { "torTxtBox","TOR"},{ "cvTxtBox","Curriculum Vatae"},
                { "policeTxtBox","Police Clearance"},{ "diplomaTxtBox","Diploma"},
                { "nbiTxtBox","NBI Clearance"},{ "brgyTxtBox","HEALTH Clearance"},

            };


            return fileTypes[fileName];
        }


       

      
    }
}
