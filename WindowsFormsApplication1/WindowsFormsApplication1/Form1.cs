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

        public Form1()
        {
            InitializeComponent();

            // Define request parameters.
            
            String range = "Winter 2018!A5:F";
            credentials = GetCredentials();
            LoadItems(range);
            

            
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

        private void LoadItems(string range)
        {
            int numberOfColumns = 5;

            var service = CreateGoogleService();
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1Ox1qngNAtKSIkWHBaORz9HtyugXflEL9eclDLt09BWo/edit

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                int rowCounter = 0;
                foreach (var row in values)
                {
                    currentlyRentedItemList.Add(new ListViewItem(row[0].ToString()));
                    for (int i = 1; i <= numberOfColumns;  i++)
                    {
                        currentlyRentedItemList[rowCounter].SubItems.Add(row[i].ToString());
                    }
                    
                    rowCounter++;
                }
                listView1.Items.AddRange(currentlyRentedItemList.ToArray());

            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();

        }


        private void button1_Click(object sender, EventArgs e)
        {


            var service = CreateGoogleService();

            // Define request parameters.
            String range = "Winter 2018!A" + rowStart.ToString() + ":F";
            
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;

            string rowToInsert = (rowStart + values.Count()).ToString();

            String newRange = "Winter 2018!A" + rowToInsert + ":F" + rowToInsert;
            
            ValueRange valueRange = new ValueRange();
            valueRange.MajorDimension = "ROWS";//"ROWS";//COLUMNS

            var oblist = new List<object>() { txtBoxName.Text, "Michael Harrison", txtBoxID.Text, DateTime.Now.ToString("g"), "", txtBoxItem.Text };

            ListViewItem newItem = new ListViewItem(txtBoxName.Text);
            newItem.SubItems.Add("Michael Harrison");
            newItem.SubItems.Add(txtBoxID.Text);
            newItem.SubItems.Add(DateTime.Now.ToString("g"));
            newItem.SubItems.Add("");
            newItem.SubItems.Add(txtBoxItem.Text);
            listView1.Items.Add(newItem);

            valueRange.Values = new List<IList<object>> { oblist };

            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, newRange);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse result2 = update.Execute();

            SpreadsheetsResource.ValuesResource.BatchClearRequest delete = service.Spreadsheets.Values.BatchClear(valueRange, spreadsheetId);
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

            // Define request parameters.
            String range = "Winter 2018!A" + (rowStart + listView1.SelectedItems[0].Index).ToString() + ":F";

            


            listView1.Items.Remove(listView1.SelectedItems[0]);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }


}
