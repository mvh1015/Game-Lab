using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Text;
using System.Threading;

namespace WindowsFormsApplication1
{
    
    enum Pages
    {
        SignIn, LabEquipment
    };


    public partial class Form1 : Form
    {
        

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets};
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        int rowStart = 5;

        List<ListViewItem> currentlyRentedItemList = new List<ListViewItem>();
        String spreadsheetId = "1Ox1qngNAtKSIkWHBaORz9HtyugXflEL9eclDLt09BWo";

        GoogleCredential credentials;
        SheetsService service;

        Pages currentPage = Pages.LabEquipment;

        int actualRowIndex = -1;

        String itemRange = "Winter 2018!A5:G";

        public Form1()
        {
            InitializeComponent();


            /*listView1.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(listView1);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(4);
            buttonAction.DrawIfEmpty = true;
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);
            */
            


            // Define request parameters.

            
            credentials = GetCredentials();

            toTimePicker.Value = System.DateTime.Now;
            fromTimePicker.Value = System.DateTime.Now.Subtract(new System.TimeSpan(1,0,0,0,0));
            Thread thread = new Thread(() => LoadItems());
            thread.Start();



        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }

        // Create Google Sheets API service.
        private SheetsService CreateGoogleService()
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        private void LoadItems()
        {
            currentlyRentedItemList.Clear();

            int numberOfColumns;
            switch (currentPage)
            {
                case Pages.LabEquipment:
                    numberOfColumns = 6;
                    break;
                case Pages.SignIn:
                    numberOfColumns = 5;
                    break;
                default:
                    numberOfColumns = 0;
                    break;

            }
            
            var service = CreateGoogleService();
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, GetItemRange());

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1Ox1qngNAtKSIkWHBaORz9HtyugXflEL9eclDLt09BWo/edit

            

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;

            string beginDate = fromTimePicker.Value.ToString("d");

            actualRowIndex = -1;

            if (values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                int rowCounter = 0;
                foreach (var row in values)
                {
                    if (actualRowIndex == -1 && (fromTimePicker.Value.Date.CompareTo(Convert.ToDateTime(row[3].ToString())) <= 0))
                    {
                        actualRowIndex = values.IndexOf(row);
                    } else if (actualRowIndex == -1)
                    {
                        continue;
                    }
                        

                        if (row.Count > 0)
                        {
                            currentlyRentedItemList.Add(new ListViewItem(row[0].ToString()));
                            for (int i = 1; i <= numberOfColumns; i++)
                            {



                                Console.Write(row);
                                if (i < row.Count)
                                {
                                    currentlyRentedItemList[rowCounter].SubItems.Add(row[i].ToString());

                                } else
                                {
                                    currentlyRentedItemList[rowCounter].SubItems.Add("");
                                }

                            }
                            rowCounter++;

                            this.Invoke(new MethodInvoker(delegate
                            {
                                progressBar1.Visible = true;
                                progressBar1.Maximum = values.Count;
                                progressBar1.Value = rowCounter;
                            }));
                        }
                    //}
                    

                }

                this.Invoke(new MethodInvoker(delegate
                {
                    listView1.Items.AddRange(currentlyRentedItemList.ToArray());
                    progressBar1.Value = currentlyRentedItemList.Count;

                    progressBar1.Visible = false;
                }));
                

            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();

            this.Invoke(new MethodInvoker(delegate
            {
                switch (currentPage)
                {
                    case Pages.SignIn:
                        btnLabEquipment.Enabled = true;
                        break;
                    case Pages.LabEquipment:
                        btnSignIn.Enabled = true;
                        break;
                    default:
                        
                        break;

                }

                filterBtn.Enabled = true;
            }));

        }

       

        private string GetTodaysRange(Pages page, SheetsService service)
        {
            string startRange = null;
            switch(page)
            {
                case Pages.SignIn:
                    startRange = "Winter 2018!I" + rowStart.ToString() + ":N";
                    break;
                case Pages.LabEquipment:
                    startRange = "Winter 2018!A" + rowStart.ToString() + ":G";
                    break;
                default:
                    startRange = null;
                    break;

            }
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, startRange);

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;

            string rowToInsert = (rowStart + values.Count()).ToString();

            switch (page)
            {
                case Pages.SignIn:
                    startRange = "Winter 2018!I" + rowToInsert + ":N" + rowToInsert;
                    break;
                case Pages.LabEquipment:
                    startRange = "Winter 2018!A" + rowToInsert + ":G" + rowToInsert;
                    break;

            }
            return startRange;

        }

        
        private string FindCurrentMonitor() //super temporary
        {
            DateTime afternoonStart = new DateTime(1, 1, 1, 12, 0, 0);
            DateTime nightStart = new DateTime(1, 1, 1, 16, 0, 0);
            if (DateTime.Now.TimeOfDay.CompareTo(afternoonStart.TimeOfDay) < 0)
            {
                return "William Lavalliere";
            } else if (DateTime.Now.TimeOfDay.CompareTo(nightStart.TimeOfDay) < 0)
            {
                return "Kyle Gray";
            } else
            {
                return "Michael Harrison";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var service = CreateGoogleService();

            String newRange = GetTodaysRange(currentPage, service);
            
            var valueRange = new ValueRange();
            valueRange.MajorDimension = "ROWS";//"ROWS";//COLUMNS

            
            var oblist = new List<object>() { txtBoxName.Text, FindCurrentMonitor(), txtBoxID.Text, DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), ""};

            

            ListViewItem newItem = new ListViewItem(txtBoxName.Text);
            newItem.SubItems.Add(FindCurrentMonitor());
            newItem.SubItems.Add(txtBoxID.Text);
            newItem.SubItems.Add(DateTime.Now.ToString("d"));
            newItem.SubItems.Add(DateTime.Now.ToString("t"));
            newItem.SubItems.Add("");
 
            if (currentPage == Pages.LabEquipment)
            {
                oblist.Add(txtBoxItem.Text);
                newItem.SubItems.Add(txtBoxItem.Text);
            }
                

            listView1.Items.Add(newItem);

            valueRange.Values = new List<IList<object>> { oblist };

            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, newRange);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse result2 = update.Execute();

            txtBoxName.Text = "";
            txtBoxItem.Text = "";
            txtBoxID.Text = "";

            
        }

        private void AddEntry(bool labRental)
        {

        }

        private GoogleCredential GetCredentials()
        {
            GoogleCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);

                Console.WriteLine("Credential file saved to: " + credPath);

            }
            return credential;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var service = CreateGoogleService();
            string range;
            //delete selected one
            switch(currentPage)
            {
                case Pages.SignIn:
                    range = "Winter 2018!I" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString() + ":N" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString();
                    break;
                case Pages.LabEquipment:
                    range = "Winter 2018!A" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString() + ":G" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString();
                    break;
                default:
                    range = null;
                    break;


            }
            

            // The ranges to clear, in A1 notation.
            List<string> ranges = new List<string>();  // TODO: Update placeholder value.
            ranges.Add(range);

            // TODO: Assign values to desired properties of `requestBody`:
            BatchClearValuesRequest requestBody = new BatchClearValuesRequest();
            requestBody.Ranges = ranges;

            SpreadsheetsResource.ValuesResource.BatchClearRequest delete = service.Spreadsheets.Values.BatchClear(requestBody, spreadsheetId);
            
            BatchClearValuesResponse result2 = delete.Execute();

            //BatchUpdateSpreadsheetRequest requestMoveUpBody = new BatchUpdateSpreadsheetRequest();
            //requestMoveUpBody.Requests = 

            //SpreadsheetsResource.BatchUpdateRequest moveUp = service.Spreadsheets.BatchUpdate(requestMoveUpBody, spreadsheetId);

            


            listView1.Items.Remove(listView1.SelectedItems[0]);

            returnBtn.Enabled = false;
            returnBtn.Visible = false;
            deleteBtn.Enabled = false;
            deleteBtn.Visible = false;
            copyBtn.Enabled = false;
            copyBtn.Visible = false;

        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[5].Text == "")
                {
                    returnBtn.Enabled = true;
                    returnBtn.Visible = true;
                }
                else
                {
                    returnBtn.Enabled = false;
                    returnBtn.Visible = false;
                }

                deleteBtn.Enabled = true;
                deleteBtn.Visible = true;
                copyBtn.Enabled = true;
                copyBtn.Visible = true;

            } else
            {
                deleteBtn.Enabled = false;
                deleteBtn.Visible = false;
                copyBtn.Enabled = false;
                copyBtn.Visible = false;
                returnBtn.Enabled = false;
                returnBtn.Visible = false;
            }
            

               
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var service = CreateGoogleService();

            string range;
            // Define request parameters.
            switch (currentPage)
            {
                case Pages.SignIn:
                    range = "Winter 2018!N" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString();
                    break;
                case Pages.LabEquipment:
                    range = "Winter 2018!F" + (rowStart + actualRowIndex + listView1.SelectedItems[0].Index).ToString();
                    break;
                default:
                    range = null;
                    break;
            }


            var valueRange = new ValueRange();
            valueRange.MajorDimension = "ROWS";//"ROWS";//COLUMNS

            var oblist = new List<object>() { DateTime.Now.ToString("t") };

            listView1.SelectedItems[0].SubItems[5].Text = DateTime.Now.ToString("t");

            valueRange.Values = new List<IList<object>> { oblist };

            

            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse result2 = update.Execute();

            returnBtn.Enabled = false;
            returnBtn.Visible = false;
            deleteBtn.Enabled = false;
            deleteBtn.Visible = false;
            copyBtn.Enabled = false;
            copyBtn.Enabled = false;


        }


        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLabEquipment_Click(object sender, EventArgs e)
        {
            currentPage = Pages.LabEquipment;
            btnLabEquipment.Enabled = false;

            
            listView1.Columns.Insert(6, "Equipment", 191);
            listView1.Items.Clear();
            

            String range = "Winter 2018!A5:G";
            
            

            deleteBtn.Visible = true;
            returnBtn.Visible = true;
            copyBtn.Visible = true;
            txtBoxItem.Visible = true;
            equipmentLbl.Visible = true;

            SignInTitleLabel.Visible = false;
            equipmentTitleLbl.Visible = true;

            Thread thread = new Thread(() => LoadItems());
            thread.Start();

            
        }

        private string GetItemRange()
        {
            switch(currentPage)
            {
                case Pages.LabEquipment:
                    return "Winter 2018!A5:G";
                case Pages.SignIn:
                    return "Winter 2018!I5:N";
                default:
                    return null;

            }
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            currentPage = Pages.SignIn;
            btnSignIn.Enabled = false;
            listView1.Columns.RemoveAt(6);
            listView1.Items.Clear();
            deleteBtn.Visible = false;
            copyBtn.Visible = false;
            returnBtn.Visible = false;
            equipmentLbl.Visible = false;

            String range = "Winter 2018!I5:N";

            

            txtBoxItem.Visible = false;
            SignInTitleLabel.Visible = true;
            
            equipmentTitleLbl.Visible = false;

            Thread thread = new Thread(() => LoadItems());
            thread.Start();

        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = searchBtn;
        }

        private void txtBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        

        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            StudentSearch search = new StudentSearch();
            var nameList = (List<User>)search.Invoke(txtBoxID.Text).Result;

            txtBoxName.Text = nameList[0].ProperName;
            ActiveForm.AcceptButton = null;

            
        }

        private void loadingLbl_Click(object sender, EventArgs e)
        {

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = listView1.SelectedItems[0].Text;
            txtBoxID.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void fromTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            filterBtn.Enabled = false;

            Thread thread = new Thread(() => LoadItems());
            thread.Start();
        }
    }


}
