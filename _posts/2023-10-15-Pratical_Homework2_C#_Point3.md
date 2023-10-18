# Pratical Homework2 Point 3 in c#

Below you can see an image containing the output of the code and the code itself. If you want to start the project on visual studio click the following link and download the folder [hmw_point3.zip](https://github.com/Garufi1962596/Garufi1962596.github.io/edit/main/_posts)

![it is not possible to view the image please click on the repository link](/HW2.png)

    namespace hw2_point3
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
    
                // Popola le intestazioni delle colonne per tutte le tabelle DataGridView
                InitializeDataGridView(dataGridViewN1K1);
                InitializeDataGridView(dataGridViewN1K2);
                InitializeDataGridView(dataGridViewN2K1);
                InitializeDataGridView(dataGridViewN2K2);
            }
            private void InitializeDataGridView(DataGridView dgv)
            {
                dgv.ColumnCount = 4;
                dgv.Columns[0].Name = "Interval";
                dgv.Columns[1].Name = "Absolute";
                dgv.Columns[2].Name = "Relative";
                dgv.Columns[3].Name = "Percentage";
            }
    
            private void CalculateDistribution(List<double> arr, int k, DataGridView dgv)
            {
                Dictionary<string, int> count = new Dictionary<string, int>();
    
                for (int i = 0; i < k; i++)
                {
                    double lowerBound = (double)i / k;
                    double upperBound = (double)(i + 1) / k;
                    string interval = lowerBound.ToString("F2") + " - " + upperBound.ToString("F2");
                    count[interval] = 0;
    
                    foreach (var element in arr)
                    {
                        if (element >= lowerBound && element < upperBound)
                        {
                            count[interval]++;
                        }
                    }
                }
    
                foreach (var interval in count)
                {
                    dgv.Rows.Add(interval.Key, interval.Value, ((double)interval.Value / arr.Count).ToString("F2"), (100 * interval.Value / arr.Count).ToString("F2") + "%");
                }
            }
    
            private void Form1_Load(object sender, EventArgs e)
            {
                int K1 = 5;
                int K2 = 10;
                int N1 = 20;
                int N2 = 50;
    
                List<double> randomNumbers1 = new List<double>();
                List<double> randomNumbers2 = new List<double>();
    
                Random random = new Random();
                for (int i = 0; i < N1; i++)
                {
                    randomNumbers1.Add(random.NextDouble());
                }
    
                for (int i = 0; i < N2; i++)
                {
                    randomNumbers2.Add(random.NextDouble());
                }
    
                CalculateDistribution(randomNumbers1, K1, dataGridViewN1K1);
                CalculateDistribution(randomNumbers1, K2, dataGridViewN1K2);
                CalculateDistribution(randomNumbers2, K1, dataGridViewN2K1);
                CalculateDistribution(randomNumbers2, K2, dataGridViewN2K2);
    
            }
        }
    }
