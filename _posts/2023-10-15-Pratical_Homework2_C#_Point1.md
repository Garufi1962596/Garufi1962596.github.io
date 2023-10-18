# Pratical Homework2 Point 1 in c#

Below you can see an image containing the output of the code and the code itself. If you want to start the project on visual studio click the following link and download the folder [HW2_point2.zip](https://github.com/Garufi1962596/Garufi1962596.github.io/edit/main/_posts)

![it is not possible to view the image please click on the repository link](/HW2_FD.png)

    namespace HW2_point2
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                InitializeDataGridView(dataGridView1);
                InitializeDataGridView(dataGridView2);
                InitializeDataGridView(dataGridView3);
                InitializeDataGridView(dataGridView4);
            }
            private void InitializeDataGridView(DataGridView dgv)
            {
                dgv.ColumnCount = 4;
                dgv.Columns[0].Name = "Value";
                dgv.Columns[1].Name = "Absolute";
                dgv.Columns[2].Name = "Relative";
                dgv.Columns[3].Name = "Percentage";
            }
    
            static Dictionary<string, int> FrequencyDistribution<T>(List<T> list) where T : notnull
            {
                Dictionary<string, int> count = new Dictionary<string, int>();
    
                if (typeof(T) == typeof(double))
                {
                    foreach (T item in list)
                    {
                        double value = (double)(object)item;
                        string interval = value.ToString("F1");
                        string valore = interval + "-" + (value + 0.1).ToString("F1");
                        if (count.ContainsKey(valore))
                        {
                            count[valore]++;
                        }
                        else
                        {
                            count[valore] = 1;
                        }
                    }
                }
                else
                {
                    foreach (T item in list)
                    {
                        string valore = item.ToString();
                        if (count.ContainsKey(valore))
                        {
                            count[valore]++;
                        }
                        else
                        {
                            count[valore] = 1;
                        }
                    }
                }
                return count;
    
            }
    
            static Dictionary<string, int> FrequencyDistributionJoin(List<RecordA> age, List<RecordS> sport)
            {
                Dictionary<string, int> combinedCounts = new Dictionary<string, int>();
                for (int i = 0; i < age.Count; i++)
                {
                    string ageValue = age[i].Valore.ToString();
                    string sportValue = sport[i].Valore;
                    string combinedKey = ageValue + "-" + sportValue;
    
                    if (combinedCounts.ContainsKey(combinedKey))
                    {
                        combinedCounts[combinedKey]++;
                    }
                    else
                    {
                        combinedCounts[combinedKey] = 1;
                    }
                }
                return combinedCounts;
            }
            static void PopulateDataGridView(DataGridView dataGridView, Dictionary<string, int> count, int totalCount)
            {
                dataGridView.Rows.Clear();
    
                foreach (var item in count)
                {
                    string valore = item.Key;
                    string absolute = item.Value.ToString();
                    string relative = ((double)item.Value / totalCount).ToString("F2");
                    string percentage = (100.0 * item.Value / totalCount).ToString("F2") + "%";
    
                    dataGridView.Rows.Add(valore, absolute, relative, percentage);
                }
    
                dataGridView.Rows.Add("", totalCount, "1", "100%");
            }
    
    
            private void Form1_Load_1(object sender, EventArgs e)
            {
    
                List<RecordA> Age = new List<RecordA>
            {
                new RecordA { Chiave= 1,  Valore=22 },
                new RecordA{ Chiave= 2,  Valore=22 },
                new RecordA { Chiave= 3,  Valore=22 },
                new RecordA { Chiave= 4,  Valore=23 },
                new RecordA { Chiave= 5,  Valore=23 },
                new RecordA { Chiave= 6,  Valore=21 },
                new RecordA { Chiave= 7,  Valore=23 },
                new RecordA { Chiave= 8,  Valore=23 },
                new RecordA { Chiave= 9,  Valore=24 },
                new RecordA { Chiave= 10, Valore= 24 },
                new RecordA { Chiave= 11, Valore= 23 },
                new RecordA { Chiave= 12, Valore= 21 },
                new RecordA { Chiave= 13, Valore= 25 },
                new RecordA { Chiave= 14, Valore= 22 },
                new RecordA { Chiave= 15, Valore= 22 },
                new RecordA { Chiave= 16, Valore= 22 },
                new RecordA { Chiave= 17, Valore= 25 },
                new RecordA { Chiave= 18, Valore= 21 },
                new RecordA { Chiave= 19, Valore= 21 },
                new RecordA { Chiave= 20, Valore= 21 },
                new RecordA { Chiave= 21, Valore= 23 },
                new RecordA { Chiave= 22, Valore= 22 },
                new RecordA { Chiave= 23, Valore= 21 },
                new RecordA { Chiave= 24, Valore= 23 },
                new RecordA { Chiave= 25, Valore= 24 },
                new RecordA { Chiave= 26, Valore= 25 },
                new RecordA { Chiave= 27, Valore= 23 },
                new RecordA { Chiave= 28, Valore= 22 },
                new RecordA { Chiave= 29, Valore= 22 },
                new RecordA { Chiave= 30, Valore= 27 },
                new RecordA { Chiave= 31, Valore= 23 },
                new RecordA { Chiave= 32, Valore= 24 },
                new RecordA { Chiave= 33, Valore= 22 },
                new RecordA { Chiave= 34, Valore= 25 },
                new RecordA { Chiave= 35, Valore= 39 },
                new RecordA { Chiave= 36, Valore= 26 },
                new RecordA { Chiave= 37, Valore= 23 },
                new RecordA { Chiave= 38, Valore= 22 },
                new RecordA { Chiave= 39, Valore= 22 },
                new RecordA { Chiave= 40, Valore= 22 },
                new RecordA { Chiave= 41, Valore= 23 },
                new RecordA { Chiave= 42, Valore= 27 },
                new RecordA { Chiave= 43, Valore= 23 },
                new RecordA { Chiave= 44, Valore= 25 },
                new RecordA { Chiave= 45, Valore= 22 },
                new RecordA { Chiave= 46, Valore= 22 },
                new RecordA { Chiave= 47, Valore= 22 },
                new RecordA { Chiave= 48, Valore= 22 },
                new RecordA { Chiave= 49, Valore= 21 },
                new RecordA { Chiave= 50, Valore= 23 },
                new RecordA { Chiave= 51, Valore= 23 },
                new RecordA { Chiave= 52, Valore= 26 },
                new RecordA { Chiave= 53, Valore= 27 },
                new RecordA { Chiave= 54, Valore= 23 },
                new RecordA { Chiave= 55, Valore= 23 },
                new RecordA { Chiave= 56, Valore= 23 }
            };
    
                List<Record> Height = new List<Record>
        {
                new Record { Chiave = 1, Valore = 1.60 },
                new Record { Chiave = 2, Valore = 1.75 },
                new Record { Chiave = 3, Valore = 1.68 },
                new Record { Chiave = 4, Valore = 1.72 },
                new Record { Chiave = 5, Valore = 1.58 },
                new Record { Chiave = 6, Valore = 1.76 },
                new Record { Chiave = 7, Valore = 1.76 },
                new Record { Chiave = 8, Valore = 1.70 },
                new Record { Chiave = 9, Valore = 1.73 },
                new Record { Chiave = 10, Valore = 1.8 },
                new Record { Chiave = 11, Valore = 1.80 },
                new Record { Chiave = 12, Valore = 1.72 },
                new Record { Chiave = 13, Valore = 1.68 },
                new Record { Chiave = 14, Valore = 1.68 },
                new Record { Chiave = 15, Valore = 1.81 },
                new Record { Chiave = 16, Valore = 1.65 },
                new Record { Chiave = 17, Valore = 1.76 },
                new Record { Chiave = 18, Valore = 1.86 },
                new Record { Chiave = 19, Valore = 1.71 },
                new Record { Chiave = 20, Valore = 1.62 },
                new Record { Chiave = 21, Valore = 1.75 },
                new Record { Chiave = 22, Valore = 1.70 },
                new Record { Chiave = 23, Valore = 1.63 },
                new Record { Chiave = 24, Valore = 1.74 },
                new Record { Chiave = 25, Valore = 1.66 },
                new Record { Chiave = 26, Valore = 1.79 },
                new Record { Chiave = 27, Valore = 1.61 },
                new Record { Chiave = 28, Valore = 1.68 },
                new Record { Chiave = 29, Valore = 1.80 },
                new Record { Chiave = 30, Valore = 1.65 },
                new Record { Chiave = 31, Valore = 1.80 },
                new Record { Chiave = 32, Valore = 1.64 },
                new Record { Chiave = 33, Valore = 1.71 },
                new Record { Chiave = 34, Valore = 1.59 },
                new Record { Chiave = 35, Valore = 1.73 },
                new Record { Chiave = 36, Valore = 1.60 },
                new Record { Chiave = 37, Valore = 1.78 },
                new Record { Chiave = 38, Valore = 1.67 },
                new Record { Chiave = 39, Valore = 1.74 },
                new Record { Chiave = 40, Valore = 1.66 },
                new Record { Chiave = 41, Valore = 1.76 },
                new Record { Chiave = 42, Valore = 1.61 },
                new Record { Chiave = 43, Valore = 1.69 },
                new Record { Chiave = 44, Valore = 1.79 },
                new Record { Chiave = 45, Valore = 1.57 },
                new Record { Chiave = 46, Valore = 1.90 },
                new Record { Chiave = 47, Valore = 1.64 },
                new Record { Chiave = 48, Valore = 1.70 },
                new Record { Chiave = 49, Valore = 1.59 },
                new Record { Chiave = 50, Valore = 1.73 },
                new Record { Chiave = 51, Valore = 1.62 },
                new Record { Chiave = 52, Valore = 1.75 },
                new Record { Chiave = 53, Valore = 1.70 },
                new Record { Chiave = 54, Valore = 1.78 },
                new Record { Chiave = 55, Valore = 1.91 },
                new Record { Chiave = 56, Valore = 1.82 }
                };
    
    
                List<RecordS> Sport = new List<RecordS>
            {
                new RecordS { Chiave = 1, Valore = "NoSport" },
                new RecordS { Chiave = 2, Valore = "Rugby" },
                new RecordS { Chiave = 3, Valore = "Krav Maga" },
                new RecordS { Chiave = 4, Valore = "Badminton" },
                new RecordS { Chiave = 5, Valore = "Rugby" },
                new RecordS { Chiave = 6, Valore = "Football" },
                new RecordS { Chiave = 7, Valore = "skiing" },
                new RecordS { Chiave = 8, Valore = "NoSport" },
                new RecordS { Chiave = 9, Valore = "NoSport" },
                new RecordS { Chiave = 10, Valore = "Football" },
                new RecordS { Chiave = 11, Valore = "NoSport" },
                new RecordS { Chiave = 12, Valore = "Football" },
                new RecordS { Chiave = 13, Valore = "Longboard" },
                new RecordS { Chiave = 14, Valore = "Football" },
                new RecordS { Chiave = 15, Valore = "Swimming" },
                new RecordS { Chiave = 16, Valore = "Swimming" },
                new RecordS { Chiave = 17, Valore = "Tennis" },
                new RecordS { Chiave = 18, Valore = "Tennis" },
                new RecordS { Chiave = 19, Valore = "Tennis" },
                new RecordS { Chiave = 20, Valore = "Gym" },
                new RecordS { Chiave = 21, Valore = "NoSport" },
                new RecordS { Chiave = 22, Valore = "Swimming" },
                new RecordS { Chiave = 23, Valore = "Gym" },
                new RecordS { Chiave = 24, Valore = "Martial arts" },
                new RecordS { Chiave = 25, Valore = "Gym" },
                new RecordS { Chiave = 26, Valore = "Gym" },
                new RecordS { Chiave = 27, Valore = "Gym" },
                new RecordS { Chiave = 28, Valore = "Gym" },
                new RecordS { Chiave = 29, Valore = "Gym" },
                new RecordS { Chiave = 30, Valore = "Football" },
                new RecordS { Chiave = 31, Valore = "Gym" },
                new RecordS { Chiave = 32, Valore = "Gym" },
                new RecordS { Chiave = 33, Valore = "Yoga" },
                new RecordS { Chiave = 34, Valore = "Figure skating" },
                new RecordS { Chiave = 35, Valore = "Climbing" },
                new RecordS { Chiave = 36, Valore = "Gym" },
                new RecordS { Chiave = 37, Valore = "Volleyball" },
                new RecordS { Chiave = 38, Valore = "NoSport" },
                new RecordS { Chiave = 39, Valore = "Gym" },
                new RecordS { Chiave = 40, Valore = "NoSport" },
                new RecordS { Chiave = 41, Valore = "NoSport" },
                new RecordS { Chiave = 42, Valore = "NoSport" },
                new RecordS { Chiave = 43, Valore = "Gym" },
                new RecordS { Chiave = 44, Valore = "Gym" },
                new RecordS { Chiave = 45, Valore = "Football" },
                new RecordS { Chiave = 46, Valore = "Football" },
                new RecordS { Chiave = 47, Valore = "NoSport" },
                new RecordS { Chiave = 48, Valore = "Gym" },
                new RecordS { Chiave = 49, Valore = "Gym" },
                new RecordS { Chiave = 50, Valore = "Gym" },
                new RecordS { Chiave = 51, Valore = "NoSport" },
                new RecordS { Chiave = 52, Valore = "Gym" },
                new RecordS { Chiave = 53, Valore = "Gym" },
                new RecordS { Chiave = 54, Valore = "NoSport" },
                new RecordS { Chiave = 55, Valore = "Gym" },
                new RecordS { Chiave = 56, Valore = "Gym" }
            };
    
    
                Dictionary<string, int> countAge = FrequencyDistribution(Age.Select(record => record.Valore).ToList());
    
                Dictionary<string, int> countHeight = FrequencyDistribution(Height.Select(record => record.Valore).ToList());
                Dictionary<string, int> countSport = FrequencyDistribution(Sport.Select(record => record.Valore).ToList());
                Dictionary<string, int> countJoin = FrequencyDistributionJoin(Age, Sport);
    
    
                PopulateDataGridView(dataGridView1, countAge, Age.Count);
                PopulateDataGridView(dataGridView2, countHeight, Height.Count);
                PopulateDataGridView(dataGridView3, countSport, Sport.Count);
                PopulateDataGridView(dataGridView4, countJoin, Age.Count);
    
            }
        }
      }
  
    class Record
    {
        public int Chiave { get; set; }
        public double Valore { get; set; }
    }
    
    class RecordA
    {
        public int Chiave { get; set; }
        public int Valore { get; set; }
    }
    
    class RecordS
    {
        public int Chiave { get; set; }
        public string Valore { get; set; }
    
        public RecordS()
        {
            Valore = "";
        }
    }
