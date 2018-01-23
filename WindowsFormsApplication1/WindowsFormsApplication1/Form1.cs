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
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";


        public Form1()
        {
            InitializeComponent();


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

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1Ox1qngNAtKSIkWHBaORz9HtyugXflEL9eclDLt09BWo";
            String range = "Winter 2018!A5:F";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1Ox1qngNAtKSIkWHBaORz9HtyugXflEL9eclDLt09BWo/edit

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                foreach (var row in values)
                {
                    // Print columns A and E, which correspond to indices 0 and 4.
                    Console.WriteLine("{0}, {1}", row[0], row[4]);
                    
                    richTextBox1.Text += (row[0] + " ");
                    richTextBox1.Text += (row[1] + " ");
                    richTextBox1.Text += (row[2] + " ");
                    richTextBox1.Text += (row[3] + " ") ;
                    richTextBox1.Text += (row[4] + " ");
                    richTextBox1.Text += (row[5] + " \n");
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();


            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
