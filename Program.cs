using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // FIles
        string basename = Environment.UserName;
        string LogFile = @"C:\Users/" + basename + "/OBS/System/Logs/Log.txt";
        string HomeScore = @"C:\Users/" + basename + "/OBS/Teams/HomeScore.txt";
        string AwayScore = @"C:\Users/" + basename + "/OBS/Teams/AwayScore.txt";
        string HomeName = @"C:\Users/" + basename + "/OBS//Teams/HomeName.txt";
        string AwayName = @"C:\Users/" + basename + "/OBS/Teams/AwayName.txt";
        string QuarterFile = @"C:\Users/" + basename + "/OBS/Teams/Settings/Quarter.txt";
        string PrintOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/Print_On_Off.txt";
        void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                StreamWriter stream;
                stream = File.CreateText(file);
                stream.Close();
            }
        }

        void Admin()
        {
            void CheckBool(string file)
            {
                if (!File.Exists(file))
                {
                    StreamWriter stream;
                    stream = File.CreateText(file);
                    stream.WriteLine("true");
                    stream.Close();
                }
                if (File.Exists(file))
                {
                    
                }
            }
            CheckBool(PrintOnOff);
        }
        void FileSystem()
        {
            void CheckDirectories(string directory)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
            CheckDirectories(@"C:\Users/" + basename + "/OBS");
            CheckDirectories(@"C:\Users/" + basename + "/OBS/System");
            CheckDirectories(@"C:\Users/" + basename + "/OBS/System/Logs");
            CheckDirectories(@"C:\Users/" + basename + "/OBS/Teams");
            CheckDirectories(@"C:\Users/" + basename + "/OBS/Teams/Settings");
            CheckDirectories(@"C:\Users/" + basename + "/OBS/System/Settings");
            CheckFile(LogFile);
            CheckFile(HomeScore);
            CheckFile(AwayScore);
            CheckFile(HomeName);
            CheckFile(AwayName);
            CheckFile(QuarterFile);
        }
        void LogSystem(string log)
        {
            CheckFile(LogFile);
            DateTime date = DateTime.Now;
            StreamWriter write;
            write = File.AppendText(LogFile);
            write.WriteLine(log + " - " + date);
            write.Close();
        }
        void Styling(string section)
        {
            if (section == "Start Page")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }

            if (section == "Main Menu")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
            }
            if (section == "Scoring")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }

            if (section == "Team Management")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
        }
        void MainMenu()
        {
            void Scoring()
            {
                void Score(string team, int points)
                {
                    if (team == "Home")
                    {
                        StreamWriter write;
                        write = File.CreateText(HomeScore);
                        write.WriteLine(points);
                        write.Close();
                    }

                    if (team == "Away")
                    {
                        StreamWriter write;
                        write = File.CreateText(AwayScore);
                        write.WriteLine(points);
                        write.Close();
                    }
                }

                void ScorePoints()
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine("| What Team? |");
                    Console.WriteLine("--------------");
                    var team = Console.ReadLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("| Points |");
                    Console.WriteLine("----------");
                    var points = Console.ReadLine();
                    Score(team, int.Parse(points));
                }
                Styling("Scoring");
                Console.WriteLine("----------------");
                Console.WriteLine("| Score | Exit |");
                Console.WriteLine("----------------");
                var ReadyState = Console.ReadLine();
                if (ReadyState == "Score")
                {
                    ScorePoints();
                    Scoring();
                }

                if (ReadyState == "Exit")
                {
                    MainMenu();
                }
            }
            void TeamManagement()
            {
                void Team()
                {
                    void TeamName(string team, string name)
                    {
                        if (team == "Home")
                        {
                            StreamWriter write;
                            write = File.CreateText(HomeName);
                            write.WriteLine(name);
                            write.Close();
                        }
                        if (team == "Away")
                        {
                            StreamWriter write;
                            write = File.CreateText(AwayName);
                            write.WriteLine(name);
                            write.Close();
                        }
                    }
                    Console.WriteLine("--------------");
                    Console.WriteLine("| What Team? |");
                    Console.WriteLine("--------------");
                    var SubName = Console.ReadLine();
                    Console.WriteLine("------------");
                    Console.WriteLine("| Team Name |");
                    Console.WriteLine("------------");
                    var teamname = Console.ReadLine();
                    TeamName(SubName, teamname);
                }

                void QuarterChange()
                {
                    void ChangeQuarter(int number)
                    {
                        StreamWriter write;
                        write = File.CreateText(QuarterFile);
                        write.WriteLine(number);
                        write.Close();
                    }
                    Console.WriteLine("------------------");
                    Console.WriteLine("| Quarter Number |");
                    Console.WriteLine("------------------");
                    var Quarter = Console.ReadLine();
                    ChangeQuarter(int.Parse(Quarter));
                }
                void SettingsMenu()
                {
                    void SettingMainMenu()
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("| Team | Quarter |");
                        Console.WriteLine("------------------");
                        var menu = Console.ReadLine();
                        if (menu == "Team")
                        {
                            Team();
                        }

                        if (menu == "Quarter")
                        {
                            QuarterChange();
                        }
                    }
                    SettingMainMenu();    
                }

                void MainTeamMenu()
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("| Settings | Exit |");
                    Console.WriteLine("-------------------");
                    var Userinput = Console.ReadLine();

                    if (Userinput == "Settings")
                    {
                        SettingsMenu();
                    }

                    if (Userinput == "Exit")
                    {
                        MainMenu();
                    }
                }
                Styling("Team Management");
                MainTeamMenu();
            }

            void Settings()
            {
                void PrintScript(string file)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                         Console.WriteLine(line);  
                    }  
                       
                }
                bool PrintBool = bool.Parse(File.ReadAllText(PrintOnOff));
                void Print(bool on)
                {
                    if (on == true)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("| Logs | Exit |");
                        Console.WriteLine("---------------");
                        var read = Console.ReadLine();
                        if (read == "Logs")
                        { 
                            PrintScript(LogFile);
                            Print(PrintBool);
                        }
                        
                        if (read == "Exit")
                        {
                            Settings();
                        }
                    }

                    if (on == false)
                    {
                        MainMenu();
                    }
                }
                void MainMenuSettings()
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("| Print | Exit |");
                    Console.WriteLine("----------------");
                    var read = Console.ReadLine();
                    if (read == "Print")
                    {
                        Print(PrintBool);
                    }

                    if (read == "Exit")
                    {
                        MainMenu();
                    }
                }
                MainMenuSettings();
            }
            Styling("Main Menu");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| Score | Team Management | Settings | Exit |");
            Console.WriteLine("---------------------------------------------");
            var MainMenuInput = Console.ReadLine();
            if (MainMenuInput == "Score")
            {
                Scoring();
            }

            if (MainMenuInput == "Team Management")
            {
                TeamManagement();
            }

            if (MainMenuInput == "Settings")
            {
                Settings();
            }
            if (MainMenuInput == "Exit")
            {
                Console.ReadKey();
            }
        }
        void StartPage()
        {
            Styling("Start Page");
            Console.WriteLine("----------------");
            Console.WriteLine("| Start | Exit |");
            Console.WriteLine("----------------");
            var start = Console.ReadLine();
            if (start == "Start")
            {
                MainMenu();
            }

            if (start == "Exit")
            {
                Console.ReadKey();
            }
        }
        FileSystem();
        Admin();
        LogSystem("Program Has Started");
        StartPage();
        LogSystem("Program Has Ended");
    }
}
