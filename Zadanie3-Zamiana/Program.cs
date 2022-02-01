String plik = System.IO.File.ReadAllText(@"C:\test\pierwszy.txt");
DateTime thisDay = DateTime.Today;
var date = thisDay.ToString("d").Replace("-", "");
var replacement = plik.Replace("praca", "job");

String path = "C:/test/pierwszy_changed-" + date + ".txt";
File.WriteAllText(path, replacement);
