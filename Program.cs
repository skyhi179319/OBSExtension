using System;
using System.IO;
namespace OBSExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Files
            string basename = Environment.UserName;
            string LogFile = @"C:\Users/" + basename + "/OBS/System/Logs/Log.txt";
            string HomeScore = @"C:\Users/" + basename + "/OBS/Teams/HomeScore.txt";
            string AwayScore = @"C:\Users/" + basename + "/OBS/Teams/AwayScore.txt";
            string HomeName = @"C:\Users/" + basename + "/OBS//Teams/HomeName.txt";
            string AwayName = @"C:\Users/" + basename + "/OBS/Teams/AwayName.txt";
            string QuarterFile = @"C:\Users/" + basename + "/OBS/Teams/Settings/Quarter.txt";
            string PrintOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/Print_On_Off.txt";
            string CheckScoreOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/CheckScore_On_Off.txt";
            string QuarterMax = @"C:\Users/" + basename + "/OBS/System/Settings/Quarter_Max.txt";
            string ScoreMax = @"C:\Users/" + basename + "/OBS/System/Settings/Score_Max.txt";
            string ScoreMaxDifference = @"C:\Users/" + basename + "/OBS/System/Settings/Score_Max_Difference.txt";
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

                void CheckQuarter(string file)
                {
                    if (!File.Exists(file))
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.WriteLine("1");
                        stream.Close();
                    }
                    if (File.Exists(file))
                    {
                        
                    }
                }
                void CheckMaxScore(string file)
                {
                    if (!File.Exists(file))
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.WriteLine("150");
                        stream.Close();
                    }
                    if (File.Exists(file))
                    {
                        
                    }
                }
                void CheckMaxScoreDifference(string file)
                {
                    if (!File.Exists(file))
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.WriteLine("125");
                        stream.Close();
                    }
                    if (File.Exists(file))
                    {
                        
                    }
                }
                CheckBool(CheckScoreOnOff);
                CheckBool(PrintOnOff);
                CheckQuarter(QuarterMax);
                CheckMaxScore(ScoreMax);
                CheckMaxScoreDifference(ScoreMaxDifference);
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

                if (section == "Developer Mode")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
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
                    void CheckScore(bool on)
                    {
                        void SetScore(string file)
                        {
                            StreamWriter stream;
                            stream = File.CreateText(file);
                            stream.WriteLine("0");
                            stream.Close();
                        }
                        if (on == true)
                        {
                            SetScore(HomeScore);
                            SetScore(AwayScore);
                        }

                        if (on == false)
                        {
                            
                        }
                    }
                    void Score(string team, int points)
                    {
                        int home = int.Parse(File.ReadAllText(HomeScore)) - int.Parse(File.ReadAllText(AwayScore));
                        int away = int.Parse(File.ReadAllText(AwayScore)) - int.Parse(File.ReadAllText(HomeScore));
                        int max = int.Parse(File.ReadAllText(ScoreMaxDifference));
                        if (team == "Home")
                        {
                            if (home - away < max)
                            {
                                if (points < int.Parse(File.ReadAllText(ScoreMax)))
                                {
                                    StreamWriter write;
                                    write = File.CreateText(HomeScore);
                                    write.WriteLine(points);
                                    write.Close();
                                }
                            }
                            
                        }
                        if (team == "Away")
                        {
                            if (away - home < max)
                            {
                                if (points < int.Parse(File.ReadAllText(ScoreMax)))
                                {
                                    StreamWriter write;
                                    write = File.CreateText(AwayScore);
                                    write.WriteLine(points);
                                    write.Close();
                                }
                            }
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
                    bool ScoreBool = bool.Parse(File.ReadAllText(CheckScoreOnOff));
                    CheckScore(ScoreBool);
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
                            if (number < int.Parse(File.ReadAllText(QuarterMax)))
                            {
                                StreamWriter write;
                                write = File.CreateText(QuarterFile);
                                write.WriteLine(number);
                                write.Close();
                            }
                            else
                            {
                                QuarterChange();
                            }
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
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("| Team | Quarter | Exit |");
                            Console.WriteLine("-------------------------");
                            var menu = Console.ReadLine();
                            if (menu == "Team")
                            {
                                Team();
                                SettingsMenu();
                            }

                            if (menu == "Quarter")
                            {
                                QuarterChange();
                                SettingsMenu();
                            }

                            if (menu == "Exit")
                            {
                                TeamManagement();
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
                void DeveloperMode()
                {
                    void Menu()
                    {
                        void Switches()
                        {
                            void Alternate(string file, string text)
                            {
                                bool FileText = bool.Parse(text);
                                if (FileText == true)
                                {
                                    StreamWriter stream;
                                    stream = File.CreateText(file);
                                    stream.WriteLine("false");
                                    stream.Close();
                                }
                                if (FileText == false)
                                {
                                    StreamWriter stream;
                                    stream = File.CreateText(file);
                                    stream.WriteLine("true");
                                    stream.Close();
                                }
                            }
        
                            void PrintSwitch()
                            {
                                Console.WriteLine(File.ReadAllText(PrintOnOff));
                                Console.WriteLine("----------");
                                Console.WriteLine("| Change |");
                                Console.WriteLine("----------");
                                var change = Console.ReadLine();
                                if (change == "Yes")
                                {
                                    Alternate(PrintOnOff,File.ReadAllText(PrintOnOff));
                                }
        
                                if (change == "No")
                                {
                                    Switches();
                                }
                            }
        
                            void CheckScoreSwitch()
                            {
                                Console.WriteLine(File.ReadAllText(CheckScoreOnOff));
                                Console.WriteLine("----------");
                                Console.WriteLine("| Change |");
                                Console.WriteLine("----------");
                                var change = Console.ReadLine();
                                if (change == "Yes")
                                {
                                    Alternate(CheckScoreOnOff,File.ReadAllText(CheckScoreOnOff));
                                }
        
                                if (change == "No")
                                {
                                    Switches();
                                }
                            }
                    
                            void SwitchesMainMenu()
                            {
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("| Print | Check Score | Exit |");
                                Console.WriteLine("------------------------------");
                                var input = Console.ReadLine();
                                if (input == "Print")
                                {
                                    PrintSwitch();
                                    SwitchesMainMenu();
                                }
        
                                if (input == "Check Score")
                                {
                                    CheckScoreSwitch();
                                    SwitchesMainMenu();
                                }
        
                                if (input == "Exit")
                                {
                                    Menu();
                                }
                            }
                            SwitchesMainMenu();
                        }

                        void ChangeMax()
                        {
                            void Change(string file, string max)
                            {
                                int FileText = int.Parse(max);
                                if (file == QuarterMax)
                                {
                                    if (FileText <= 10)
                                    {
                                        StreamWriter stream;
                                        stream = File.CreateText(file);
                                        stream.WriteLine(FileText);
                                        stream.Close();
                                    }
                                }

                                if (file == ScoreMax)
                                {
                                    if (FileText <= 200)
                                    {
                                        StreamWriter stream;
                                        stream = File.CreateText(file);
                                        stream.WriteLine(FileText);
                                        stream.Close();
                                    }
                                }
                                if (file == ScoreMaxDifference)
                                {
                                    if (FileText <= 150)
                                    {
                                        StreamWriter stream;
                                        stream = File.CreateText(file);
                                        stream.WriteLine(FileText);
                                        stream.Close();
                                    }
                                }
                            }
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("| Quarter | Max Score | Max Difference | Exit |");
                            Console.WriteLine("-----------------------------------------------");
                            var input = Console.ReadLine();
                            if (input == "Quarter")
                            {
                                Console.WriteLine("---------------");
                                Console.WriteLine("| Quarter Max |");
                                Console.WriteLine("---------------");
                                var read = Console.ReadLine();
                                Change(QuarterMax,read);
                                ChangeMax();
                            }

                            if (input == "Max Score")
                            {
                                Console.WriteLine("-------------");
                                Console.WriteLine("| Score Max |");
                                Console.WriteLine("-------------");
                                var read = Console.ReadLine();
                                Change(ScoreMax,read);
                                ChangeMax();
                            }
                            if (input == "Max Difference")
                            {
                                Console.WriteLine("--------------------");
                                Console.WriteLine("| Score Difference |");
                                Console.WriteLine("--------------------");
                                var read = Console.ReadLine();
                                Change(ScoreMaxDifference,read);
                                ChangeMax();
                            }
                            if (input == "Exit")
                            {
                                Menu();
                            }
                        }
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("| Switches | Change Max | Main Program |");
                        Console.WriteLine("----------------------------------------");
                        var input = Console.ReadLine();
                        if (input == "Switches")
                        {
                            Switches();
                        }

                        if (input == "Change Max")
                        {
                            ChangeMax();
                        }
                        if (input == "Main Program")
                        {
                            MainMenu();
                        }
                    }
                    Menu();
                }
                Styling("Start Page");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("| Start | Developer Mode | Exit |");
                Console.WriteLine("---------------------------------");
                var start = Console.ReadLine();
                if (start == "Start")
                {
                    MainMenu();
                }

                if (start == "Developer Mode")
                {
                    DeveloperMode();
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
}
