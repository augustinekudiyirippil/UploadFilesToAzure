using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AppToCopyFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private IConfiguration Configuration;


        string connectionString; 


       


        string clientConnectionstring;
        string excMessage;
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter da;
        string strQuery = "  ";
        int gridColumnCount;
        int gridRowCount;
        string sourceFilePath, destinationFilePath, destinationFolder;
        string strDateString,   strYear, strMonth, strDay = "";


        string blobConnectionString   ;  
        string containerName;
        string blobName = "Contacts";
        string filePath = "<path_to_your_file>";
        string fileName = "";
        string responseMessage;

        ReadConfigData readConfig = new ReadConfigData();
        FileUpload fileUpload = new FileUpload();




        private void Form1_Load(object sender, EventArgs e)
        {

            connectionString = readConfig.getConfigValuee("SQLConnection");

            blobConnectionString= readConfig.getConfigValuee("AZUREConnection");

            //List all databases


            listAllDatabases();

            getContainers();
            
        }


        void getContainers()
        {
            List<string> containerNames = new List<string>();

            containerNames = fileUpload.listContainers(blobConnectionString);

            containerNames = fileUpload.listContainers(blobConnectionString);
            cmbContainers.Items.Clear();
            foreach (string containerName in containerNames)
            {
                cmbContainers.Items.Add(containerName);
            }

        }

        




        public string  uploadFilesToAzure()
        {
            try
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(blobConnectionString);

                // Get the container client
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

                // Create the container if it doesn't exist
                containerClient.CreateIfNotExists(PublicAccessType.Blob);

                // Get a reference to the blob
                BlobClient blobClient = containerClient.GetBlobClient(blobName);


                // Open the file and upload its data
                //  dataGridView.Rows[1].Cells[5].Value.ToString()

                //filePath = "\\web03\\Attachments\\Simplisys\\a9963c0c-d08e-43fa-a861-3e4f977dcfee\\Sueryder-TestEmail.jpg";

                filePath = gridGeneralAttachments.Rows[1].Cells[5].Value.ToString();  //.Remove(0, 2);

                //blobClient.Upload(filePath, true);
                
                filePath = "F:\\AttachmentsToExport\\Simplisys\\1025\\adflex-limited.csv";  // This line is for testing
                fileName = "adflex-limited.csv";

                FileStream uploadFileStream = File.OpenRead(filePath);

                            

                blobClient.Upload(uploadFileStream, true);
                uploadFileStream.Close();



                return "Upload completed.";

            


            }
            catch(Exception ex)
            {
                excMessage = ex.Message.ToString();
                return excMessage;

            }


        }

        private void btnShowIncomingAttachments_Click(object sender, EventArgs e)
        {
            showIncomingAttachments();
        }


        void showIncomingAttachments()
        {

            try
            {


                clientConnectionstring = getClientConnectionstring(cmbDatabases.SelectedItem.ToString());

                strDateString = getFormattedDate(dtFromDate.Text);

                strQuery = "  select attID, attFileName , attDiskPath ,  ";
                strQuery = strQuery + "  'F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString() + "\\IncomingEmail\\'+ cast(TicketID as varchar(10)) as NewFolder , ";
                strQuery = strQuery + " 'F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString() + "\\IncomingEmail\\'+ cast(TicketID as varchar(10)) +'\\'+ attFileName  as NewPath , ";
                strQuery = strQuery + "   attUploadedTime , attSize ,     inemlID , inemlFromAddress , inemlSubject ,   ";
                strQuery = strQuery + "   objhisid, objhisCauseObjectID ,    incID , incNumber ,ticketLogsId ,TicketID ";
                strQuery = strQuery + "  from vIncomingEmailAttachments  ";
                strQuery = strQuery + "  where attUploadedTime > '" + strDateString + "';";

                da = new SqlDataAdapter(strQuery, clientConnectionstring);
                DataSet ds = new DataSet();
                da.Fill(ds, "incomingEmailAttachments");
                gridIncomingAttachments.DataSource = ds.Tables["incomingEmailAttachments"].DefaultView;


                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblErrorIncomingAttachments.Text = excMessage;

            }
        }


        void showOutgoingAttachments()
        {
            try { 
                clientConnectionstring = getClientConnectionstring(cmbDatabases.SelectedItem.ToString());

                strDateString = getFormattedDate(dtFromDate.Text);


                strQuery = " select att.attID , att.attDiskPath , att.attFileName , att.attUploadedTime ,ematt.ema2attEmailID , e.emaID , ";
                strQuery = strQuery + " e.emaTo , e.emaSubject , e.emaObjHisID , t.ticketId , t.ticketLogsId , t.ticketIncId , ";
                strQuery = strQuery + " 'F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString() + "\\OutgoingEmail\\'+ cast(t.TicketID as varchar(10)) as NewFolder , ";
                strQuery = strQuery + "  'F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString() + "\\OutgoingEmail\\'+ cast(t.TicketID as varchar(10)) +'\\'+ attFileName  as NewPath";
                strQuery = strQuery + "  from tblAttachment att, tblEmailToAttachment ematt, tblEmail e, tblTicketIds t ";
                strQuery = strQuery + " where ematt.ema2attAttachmentID = att.attID and e.emaID = ematt.ema2attEmailID ";
                strQuery = strQuery + " and t.ticketObjhisId = e.emaObjHisID   ";
                strQuery = strQuery + "  and   attUploadedTime > '" + strDateString + "';"; 
                da = new SqlDataAdapter(strQuery, clientConnectionstring);
                DataSet ds = new DataSet();
                da.Fill(ds, "incomingEmailAttachments");
                gridOutgoingAttachments.DataSource = ds.Tables["incomingEmailAttachments"].DefaultView;


                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblErrorOutgoingAttachments.Text = excMessage;

            }

        }

        //List all databases
        private void listAllDatabases()
        {
            try
            {
                sqlConnection.ConnectionString = connectionString;
                cmbDatabases.Items.Clear();
                strQuery = "select  acctmID , acctmAccountName , acctmConnectionString  from tblmAccount   ";
                sqlConnection.Open();
                sqlCommand = new SqlCommand(strQuery, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    cmbDatabases.Items.Add(reader["acctmAccountName"].ToString());
                  

                }
                reader.Close();
                sqlConnection.Close();
               
            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblError.Text = excMessage;
            }
        }

        //Get the selected database connection string
        string getClientConnectionstring(string databaseName)
        {
            string clientString="";

            try
            {
                strQuery = "select  acctmID , acctmAccountName , acctmConnectionString  from tblmAccount where   acctmAccountName ='" + databaseName + "' ;";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(strQuery, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                clientString = reader["acctmConnectionString"].ToString();
            }

            reader.Close();
            sqlConnection.Close();

            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblError.Text = excMessage;
            }

            return clientString;




        }

        private void btnCSVIncomingAttachment_Click(object sender, EventArgs e)
        {
            ExportToCSV(gridIncomingAttachments, cmbDatabases.SelectedItem.ToString() + "-IncomingEmailAttachments");
        }

        private void btnExportIncommingAttachmenys_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorIncomingAttachments.Text = copyMethod(gridIncomingAttachments, 2, 3, 4);

            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblErrorIncomingAttachments.Text = excMessage;

            }

     
        }


  


    


        private void btnExportOutgoingAttachmenys_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorOutgoingAttachments.Text = copyMethod(gridOutgoingAttachments, 1, 12,13);

            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblErrorOutgoingAttachments.Text = excMessage;

            }
             
        }

        private void btnShowOutgoingAttachments_Click(object sender, EventArgs e)
        {
            showOutgoingAttachments();
        }

        private void btnCSVOutgoingAttachment_Click(object sender, EventArgs e)
        {
            ExportToCSV(gridOutgoingAttachments, cmbDatabases.SelectedItem.ToString() + "-OutgoingEmailAttachments");
        }

        string getFormattedDate(string fromDate)
        {
            string formattedDate= fromDate;
            try
            {
                strDateString = dtFromDate.Text;
                strYear = strDateString.Substring(strDateString.Length - 4);

                //get month
                strDay = strDateString.Substring(0, 2);


                //getdate
                strMonth = strDateString.Substring(3, 2);

                formattedDate= strYear + "-" + strMonth + "-" + strDay;

            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblError.Text = excMessage;
            }

            return formattedDate;

        
        }

        int checkContainerName()
        {
            return cmbContainers.SelectedItem.ToString().Trim().Length;

        }

        private void btnUploadToAzure_Click(object sender, EventArgs e)
        {
            //lblError.Text = uploadFilesToAzure();


            //  FileUpload fileUpload = new FileUpload();

            if (checkContainerName() > 1)
            {

                try
                {
                    




                    gridRowCount = gridGeneralAttachments.Rows.Count;

                    for (int rows = 0; rows < gridRowCount - 1; rows++)
                    {
                        //find the path till the database name


                        responseMessage = fileUpload.uploadFilesToAzureBlobAsync(blobConnectionString, cmbContainers.SelectedItem.ToString(), gridGeneralAttachments.Rows[rows].Cells[10].Value.ToString(), cmbDatabases.SelectedItem.ToString()).ToString();

                    }
                    lblError.Text = "Files uploaded";

                }
                catch (Exception ex)
                {


                    lblError.Text = ex.Message.ToString();
                }

            }
        }



        string uploadToAzure()
        {
            string uploadResult="";
            try
            {

                uploadResult = "Files uploaded successfully";
            }
            catch (Exception ex)
            {

                excMessage = ex.Message.ToString();

            }
            return uploadResult;
            

        }

        private void btnUploadIncomingToAzure_Click(object sender, EventArgs e)
        {
            if (checkContainerName() > 1)
            {

                gridRowCount = gridIncomingAttachments.Rows.Count;


                try
                {
                    for (int rows = 0; rows < gridRowCount - 1; rows++)
                    {


                        responseMessage = fileUpload.uploadFilesToAzureBlobAsync(blobConnectionString, cmbContainers.SelectedItem.ToString(), gridIncomingAttachments.Rows[rows].Cells[4].Value.ToString(), cmbDatabases.SelectedItem.ToString()).ToString();


                    }
                    lblErrorIncomingAttachments.Text = "Files uploaded";

                }
                catch (Exception ex)
                {


                    lblError.Text = ex.Message.ToString();
                }
            }
        }


      

        private Task ListContainersAsync(CloudBlobClient cloudBlobClient)
        {
            throw new NotImplementedException();
        }

        private void btnUploadOutgoingToAzure_Click(object sender, EventArgs e)
        {
            if (checkContainerName() > 1)
            {

                gridRowCount = gridOutgoingAttachments.Rows.Count;


                try
                {
                    for (int rows = 0; rows < gridRowCount - 1; rows++)
                    {
                        if (gridOutgoingAttachments.Rows[rows].Cells[13].Value.ToString().Trim().Length > 1)
                        {

                            responseMessage= fileUpload.uploadFilesToAzureBlobAsync(blobConnectionString, cmbContainers.SelectedItem.ToString() , gridOutgoingAttachments.Rows[rows].Cells[13].Value.ToString(), cmbDatabases.SelectedItem.ToString()).ToString();
                        }

                    }
                    lblErrorOutgoingAttachments.Text = "Files uploaded";

                }
                catch (Exception ex)
                {


                    lblError.Text = ex.Message.ToString();
                }
            }

        }

        private void cmdCreateContainer_Click(object sender, EventArgs e)
        {
            lblError.Text= fileUpload.AddCompanyStorage(  "TestAzureBlobContainer", blobConnectionString);
        }

        private void cmdContainers_Click(object sender, EventArgs e)
        {
            getContainers();

            

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
 

                clientConnectionstring = getClientConnectionstring(cmbDatabases.SelectedItem.ToString());

                strDateString = getFormattedDate(dtFromDate.Text);

                strQuery = " select i.incNumber,  attObjectID , attID , attFileName , attUploadedTime,attDiskPath , attSize ,TicketID , TicketLogID ,  ";
                strQuery = strQuery + "  'F:\\AttachmentsToExport\\"+cmbDatabases.SelectedItem.ToString() + "\\'+ cast(TicketID as varchar(10)) as NewFolder , ";
                strQuery = strQuery + " 'F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString() + "\\'+ cast(TicketID as varchar(10)) +'\\'+ attFileName  as NewPath  ";
                strQuery = strQuery + "   from vAttachmentsToExport a, tblIncident i ";
                strQuery = strQuery + "  where TicketID is not null and i.incID = attObjectID ";
                strQuery = strQuery + "  and attUploadedTime > '"+ strDateString + "';";

                da = new SqlDataAdapter(strQuery, clientConnectionstring);
                DataSet ds = new DataSet();
                da.Fill(ds, "generalAttachments");
                gridGeneralAttachments.DataSource = ds.Tables["generalAttachments"].DefaultView;

               
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblError.Text = excMessage;

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try 
            {
                lblError.Text = copyMethod(gridGeneralAttachments, 5, 9, 10);

            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                lblError.Text = excMessage;

            }

        }



        string copyMethod(DataGridView dataGridView,  int sourceColumn, int folderColumn, int filePathColumn)
        {

            try
            {

                gridRowCount = dataGridView.Rows.Count;
                gridColumnCount = dataGridView.Columns.Count;

                for (int rows = 0; rows < gridRowCount - 1; rows++)
                {



                    sourceFilePath = dataGridView.Rows[rows].Cells[sourceColumn].Value.ToString();
                    destinationFilePath = dataGridView.Rows[rows].Cells[filePathColumn].Value.ToString();
                    destinationFolder = dataGridView.Rows[rows].Cells[folderColumn].Value.ToString();

                    bool exists = System.IO.Directory.Exists(destinationFolder);

                    if (exists == false)
                    {
                        System.IO.Directory.CreateDirectory(destinationFolder);
                    }


                    exists = System.IO.File.Exists(destinationFilePath);
                    if (exists == false)
                    {
                        File.Copy(sourceFilePath, destinationFilePath);
                    }





                }


                MessageBox.Show("Selected files copied to the new location");
                return "Selected files copied to the new location";
            }
            catch (Exception ex)
            {
                excMessage = ex.Message.ToString();

                return excMessage;

            }


        }

        private void btnCSV_Click(object sender, EventArgs e)


        {
            ExportToCSV(gridGeneralAttachments, cmbDatabases.SelectedItem.ToString()+"-GeneralAttachments");

            
        }

        private void ExportToCSV(DataGridView dataGridView, string newFileName)
        {

            if (dataGridView.Rows.Count > 0)
            {


                string month, day;
                month = DateTime.Today.Month.ToString();
                if (month.Length == 1)
                {
                    month = "0" + month;
                }

                day = DateTime.Today.Day.ToString();
                if (day.Length == 1)
                {
                    day = "0" + day;
                }

                string fileName = "F:\\AttachmentsToExport\\"  + cmbDatabases.SelectedItem.ToString()  + "\\" + newFileName + DateTime.Today.Year.ToString() + month + day + ".csv";

                bool exists = System.IO.Directory.Exists("F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString());

                if (exists == false)
                {
                    System.IO.Directory.CreateDirectory("F:\\AttachmentsToExport\\" + cmbDatabases.SelectedItem.ToString());
                }

                exists = System.IO.File.Exists(fileName);
                if (exists == true)
                {
                    File.Delete(fileName);
                }



                string str = "";
                string strToTest;
                try

                {
                    int columnCount = dataGridView.Columns.Count;
                    string columnNames = "";
                    string[] outputCsv = new string[gridGeneralAttachments.Rows.Count + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += "\"" + dataGridView.Columns[i].HeaderText.ToString() + "\"" + ",";

                    }
                    columnNames = columnNames.Remove(columnNames.Length - 1, 1);
                    outputCsv[0] += columnNames;

                    for (int i = 1; (i - 1) < dataGridView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {


                            try
                            {
                                if (dataGridView.Rows[i - 1].Cells[j].Value.ToString() != null)
                                {
                                    str = str.Replace("\"", " ");


                                    str = "\"" + dataGridView.Rows[i - 1].Cells[j].Value.ToString().Trim() + "\"";
                                    // str = str.Replace("   ", "-");
                                    //str = str.Replace(","," ");

                                    if (j == columnCount - 1)
                                    {
                                        //  str = str.Remove(str.Length - 1, 1);
                                        outputCsv[i] += str.Replace("   ", "");


                                    }
                                    else
                                    {
                                        try
                                        {
                                            outputCsv[i] += str.Replace("   ", "") + ",";

                                       
                                            
                                        }
                                        catch(Exception ex)
                                        {
                                            excMessage = ex.Message.ToString();

                                        }
                                    }



                                    // outputCsv[i] +=    dataGridView1.Rows[i - 1].Cells[j].Value.ToString().Trim() + ",";



                                }
                                else
                                {
                                    //Below line commented on 9th September 2022
                                    //outputCsv[i] += "NULL" + ",";

                                }



                            }
                            catch (Exception e)
                            {
                                excMessage = e.Message.ToString();
                                //Below line commented on 9th September 2022
                                //outputCsv[i] += "NULL"+ ",";


                            }



                        }
                    }

                    File.WriteAllLines(fileName, outputCsv, Encoding.UTF8);


                    MessageBox.Show("The file "+ fileName + " generated");

                    //File.WriteAllLines(fileName, outputCsv, Encoding.Default);
                    // MessageBox.Show("Data Exported Successfully !!!", "Info");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error :" + ex.Message);
                }

            }


        }
    }
}
