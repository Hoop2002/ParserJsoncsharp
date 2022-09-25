

namespace ConsoleAppJsonParser
{
    class Program
    {
        static void Main()
        {
            var path = Path.GetFullPath("C:\\Users\\docto\\source\\repos\\ConsoleAppJsonParser\\code 1.json");
            var json = File.ReadAllText(path);
            var client = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Rootobject>(json);

           
            for (int i = 0; i < client.Clients.Length; i++)
            {
                try
                {
                    string nameClient = client.Clients[i].Наименование;
                    double numOfHours = (double) client.Clients[i].КоличествоЧасов;
                    double numOfHoursSysAd = (double) client.Clients[i].ДоговорыКонтрагента[0].Участки[2].КоличествоЧасов;


                    if (numOfHours > 2.0 & numOfHoursSysAd > 0.5)
                    {
                        string output = String.Format("Наименование - {0}; Количество Часов - {1}; Кол. Часов \"Системное администрировани\" - {2};",
                                                       nameClient, numOfHours, numOfHoursSysAd);
                        Console.WriteLine(output);
                    }
                }
                catch
                {
                    
                }
                     
            }
            
            
        }
    }
}
