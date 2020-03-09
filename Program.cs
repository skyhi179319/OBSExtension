using System;
using System.IO;
using System.Threading;
namespace OBSExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Files
            string basename = Environment.UserName;
            string LogFile = @"C:\Users/" + basename + "/OBS/System/Logs/Log.txt";
            // Please Make Home Score Your Team Main Score For Analysis To Work Properly
            string HomeScore = @"C:\Users/" + basename + "/OBS/Teams/HomeScore.txt";
            string AwayScore = @"C:\Users/" + basename + "/OBS/Teams/AwayScore.txt";
            string HomeName = @"C:\Users/" + basename + "/OBS//Teams/HomeName.txt";
            string AwayName = @"C:\Users/" + basename + "/OBS/Teams/AwayName.txt";
            string QuarterFile = @"C:\Users/" + basename + "/OBS/Teams/Settings/Quarter.txt";
            string PrintOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/Print_On_Off.txt";
            string CheckScoreOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/CheckScore_On_Off.txt";
            string QuarterMax = @"C:\Users/" + basename + "/OBS/System/Settings/Quarter_Max.txt";
            string ScoreMax = @"C:\Users/" + basename + "/OBS/System/Settings/Score_Max.txt";
            string PrintScoreTimeout = @"C:\Users/" + basename + "/OBS/System/Settings/Print_Score_Timeout.txt";
            string PrintScoreTimeoutOnOff = @"C:\Users/" + basename + "/OBS/System/Settings/Print_Score_Timeout_On_Off.txt";
            string ScoreMaxDifference = @"C:\Users/" + basename + "/OBS/System/Settings/Score_Max_Difference.txt";
            string PerQuarter = @"C:\Users/" + basename + "/OBS/Analysis/Points_Average_Per_Quarter.Analysis";
            // functions
            void Timing(bool enabled,int secs)
            {
                if (enabled == true)
                {
                    Thread.Sleep(secs * 1000);
                }

                if (enabled == false)
                {
                    Console.ReadKey();
                }
            }
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
                void CheckAnalysis(string file){
                    if (!File.Exists(file))
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.Close();
                    }
                    if (File.Exists(file))
                    {
                        
                    }
                }
                void CheckPrintTimeout(string file)
                {
                    if (!File.Exists(file))
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.WriteLine("5");
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
                CheckAnalysis(PerQuarter);
                CheckPrintTimeout(PrintScoreTimeout);
                CheckBool(PrintScoreTimeoutOnOff);
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
                void UserId()
                {
                    string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";
                    void IdInfo()
                    {
                        void id(string file, int one, int two, int three, int four)
                        {
                            if (!File.Exists(file))
                            {
                                StreamWriter stream;
                                stream = File.CreateText(file);
                                stream.Write(one + "-" + two + "-" + three + "-" + four);
                                stream.Close();
                            }
                        }
                        Random r = new Random();
                        int one = r.Next(0, 9);
                        int two = r.Next(10, 99);
                        int three = r.Next(100, 999);
                        int four = r.Next(1000, 9999);
                        id(filename, one, two, three, four);
                    }
                    IdInfo();
                }
                CheckDirectories(@"C:\Users/" + basename + "/OBS");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/System");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/System/Logs");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/Teams");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/Teams/Settings");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/System/Settings");
                CheckDirectories(@"C:\Users/" + basename + "/OBS/Analysis");
                CheckFile(LogFile);
                CheckFile(HomeScore);
                CheckFile(AwayScore);
                CheckFile(HomeName);
                CheckFile(AwayName);
                CheckFile(QuarterFile);
                UserId();
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
                LogSystem("Styling" + " - " + section);
                if (section == "Timer")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                }
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
                        int HomeScoreNumber = int.Parse(File.ReadAllText(HomeScore));
                        int AwayScoreNumber = int.Parse(File.ReadAllText(HomeScore));
                        int HomeCac = HomeScoreNumber + points;
                        int AwayCac = AwayScoreNumber + points;
                        if (team == "Home")
                        {
                            if (home - away < max)
                            {
                                if (points < int.Parse(File.ReadAllText(ScoreMax)))
                                {
                                    StreamWriter write;
                                    write = File.CreateText(HomeScore);
                                    write.WriteLine(HomeCac);
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
                                    write.WriteLine(AwayCac);
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

                    void Reset()
                    {
                        void ResetFiles(string file)
                        {
                            StreamWriter write;
                            write = File.CreateText(file);
                            write.WriteLine("0");
                            write.Close();
                        }
                        ResetFiles(HomeScore);
                        ResetFiles(AwayScore);
                    }

                    void print(int home, int away)
                    {
                        string info = home + "-" + away;
                        Console.WriteLine(info);
                    }
                    Styling("Scoring");
                    bool ScoreBool = bool.Parse(File.ReadAllText(CheckScoreOnOff));
                    CheckScore(ScoreBool);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("| Score | Reset | Print | Exit |");
                    Console.WriteLine("--------------------------------");
                    var ReadyState = Console.ReadLine();
                    if (ReadyState == "Score")
                    {
                        ScorePoints();
                        Scoring();
                    }

                    if (ReadyState == "Reset")
                    {
                        Reset();
                        Scoring();
                    }

                    if (ReadyState == "Print")
                    {
                        print(int.Parse(File.ReadAllText(HomeScore)),int.Parse(File.ReadAllText(AwayScore)));
                        bool PrintBool = bool.Parse(File.ReadAllText(PrintScoreTimeoutOnOff));
                        int time = int.Parse(File.ReadAllText(PrintScoreTimeout));
                        Timing(PrintBool,time);
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
                void Analysis()
                {
                    int YourTeam = int.Parse(File.ReadAllText(HomeScore));
                    void AvgPntsQuarter(int points, int quarter)
                    {
                        void WriteFile(string file)
                        {
                            decimal cac = decimal.Divide(points,quarter);
                            if (YourTeam <= 0)
                            {
                                Console.WriteLine("Something Went Wrong - Can't Be Divided By 0");
                                Analysis();
                            }
                            else
                            {
                                StreamWriter stream;
                                stream = File.CreateText(file);
                                stream.WriteLine(String.Format("{0:0.00}",  cac));
                                stream.Close();
                            }
                            
                        }
                        WriteFile(PerQuarter);
                        Console.WriteLine(File.ReadAllText(PerQuarter));
                    }
                    Console.WriteLine("---------------------");
                    Console.WriteLine("| Avg Points | Exit |");
                    Console.WriteLine("---------------------");
                    var read = Console.ReadLine();
                    if (read == "Avg Points")
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine("| Quarter |");
                        Console.WriteLine("-----------");
                        var change = Console.ReadLine();
                        if (change == "Quarter")
                        {
                            AvgPntsQuarter(YourTeam,int.Parse(File.ReadAllText(QuarterFile)));
                            Analysis();
                        }
                    }

                    if (read == "Exit")
                    {
                        MainMenu();
                    }
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
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("| Score | Team Management | Analysis | Settings | Exit |");
                Console.WriteLine("--------------------------------------------------------");
                var MainMenuInput = Console.ReadLine();
                if (MainMenuInput == "Score")
                {
                    LogSystem("Score");
                    Scoring();
                }
                if (MainMenuInput == "Team Management")
                {
                    LogSystem("Team Management");
                    TeamManagement();
                }
                if (MainMenuInput == "Analysis")
                {
                    LogSystem("Analysis");
                    Analysis();
                }
                if (MainMenuInput == "Settings")
                {
                    LogSystem("Settings");
                    Settings();
                }
                if (MainMenuInput == "Exit")
                {
                    Console.ReadKey();
                }
            }
            void StartTimer(bool enable, int sec, string text)
            {
                void centerText(String t)
                {
                    Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                    Console.WriteLine(t);
                }
                LogSystem("Timing Effect" + " - " + text);
                Styling("Timer");
                if (enable == true)
                {
                    centerText(text);
                    Timing(enable,sec);
                }
                if (enable == false)
                {
                    centerText(text);
                    Timing(enable,sec);
                    Thread.Sleep(2000);
                }
            }
            void StartEnd(string text)
            {
                void centerText(String t)
                {
                    Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                    Console.WriteLine(t);
                    LogSystem(t);
                }
                void main()
                {
                    Styling("Timer");
                    centerText(text);
                    Timing(true,5);
                }
                main();
            }
            void TimeStampInOut(string option)
            {
                string LoggedInFile = @"C:\Users/" + basename + "/OBS/System/LoggedIn.UserInfo";
                CheckFile(LoggedInFile);
                string LoggedOutFile = @"C:\Users/" + basename + "/OBS/System/LoggedOut.UserInfo";
                CheckFile(LoggedOutFile);
                if (option == "Logged In")
                {
                    DateTime date = DateTime.Now;
                    StreamWriter write;
                    write = File.CreateText(LoggedInFile);
                    write.WriteLine(option + " - " + date);
                    write.Close();
                }
                if (option == "Logged Out")
                {
                    DateTime date = DateTime.Now;
                    StreamWriter write;
                    write = File.CreateText(LoggedOutFile);
                    write.WriteLine(option + " - " + date);
                    write.Close();
                }
            }
            void LoggedIn()
            {
                string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";
                string read = File.ReadAllText(filename);
                void text(string text)
                {
                    void centerText(String t)
                    {
                        Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                        Console.WriteLine(t);
                    }
                    LogSystem(text);
                    centerText(text);
                    Timing(true,5);
                }
                Styling("Timer");
                text("User Id: " + read);
                TimeStampInOut("Logged In");
                LogSystem("User Logged In");
            }
            void LoggedOut()
            {
                string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";
                string read = File.ReadAllText(filename);
                void text(string text)
                {
                    void centerText(String t)
                    {
                        Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                        Console.WriteLine(t);
                    }
                    LogSystem(text);
                    centerText(text);
                    Timing(true,5);
                }
                Styling("Timer");
                text("User Id: " + read);
                TimeStampInOut("Logged Out");
                LogSystem("User Logged Out");
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
                                LogSystem("Developer Altered Settings");
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
                                    Alternate(PrintOnOff, File.ReadAllText(PrintOnOff));
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
                                    Alternate(CheckScoreOnOff, File.ReadAllText(CheckScoreOnOff));
                                }
                                if (change == "No")
                                {
                                    Switches();
                                }
                            }
                            void CheckPrintTimeoutSwitch()
                            {
                                Console.WriteLine(File.ReadAllText(CheckScoreOnOff));
                                Console.WriteLine("----------");
                                Console.WriteLine("| Change |");
                                Console.WriteLine("----------");
                                var change = Console.ReadLine();
                                if (change == "Yes")
                                {
                                    Alternate(PrintScoreTimeoutOnOff, File.ReadAllText(PrintScoreTimeoutOnOff));
                                }

                                if (change == "No")
                                {
                                    Switches();
                                }
                            }

                            void SwitchesMainMenu()
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("| Print | Check Score | Print Score | Exit |");
                                Console.WriteLine("--------------------------------------------");
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

                                if (input == "Print Score")
                                {
                                    CheckPrintTimeoutSwitch();
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

                                if (file == PrintScoreTimeout)
                                {
                                    if (FileText <= 20)
                                    {
                                        StreamWriter stream;
                                        stream = File.CreateText(file);
                                        stream.WriteLine(FileText);
                                        stream.Close();
                                    }
                                }

                                LogSystem("Developer Altered Settings");
                            }

                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("| Quarter | Max Score | Max Difference | Print Timeout | Exit |");
                            Console.WriteLine("---------------------------------------------------------------");
                            var input = Console.ReadLine();
                            if (input == "Quarter")
                            {
                                Console.WriteLine("---------------");
                                Console.WriteLine("| Quarter Max |");
                                Console.WriteLine("---------------");
                                var read = Console.ReadLine();
                                Change(QuarterMax, read);
                                ChangeMax();
                            }

                            if (input == "Max Score")
                            {
                                Console.WriteLine("-------------");
                                Console.WriteLine("| Score Max |");
                                Console.WriteLine("-------------");
                                var read = Console.ReadLine();
                                Change(ScoreMax, read);
                                ChangeMax();
                            }

                            if (input == "Max Difference")
                            {
                                Console.WriteLine("--------------------");
                                Console.WriteLine("| Score Difference |");
                                Console.WriteLine("--------------------");
                                var read = Console.ReadLine();
                                Change(ScoreMaxDifference, read);
                                ChangeMax();
                            }

                            if (input == "Print Timeout")
                            {
                                Console.WriteLine("--------------");
                                Console.WriteLine("| Time Limit |");
                                Console.WriteLine("--------------");
                                var read = Console.ReadLine();
                                Change(PrintScoreTimeout, read);
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
                void LCommand(bool enable)
                {
                    Styling("Timer");

                    void PrintScript(string file)
                    {
                        string[] lines = File.ReadAllLines(file);
                        foreach (string line in lines)
                        {
                            Thread.Sleep(125);
                            Console.WriteLine(line);
                        }
                    }

                    if (enable == true)
                    {
                        Timing(true, 5);
                        PrintScript(LogFile);
                        LogSystem("Command Completed");
                        Timing(true, 10);
                        StartPage();
                    }

                    if (enable == false)
                    {
                        Timing(true, 5);
                        PrintScript(LogFile);
                        LogSystem("Command Completed");
                        Timing(true, 10);
                    }
                }
                void DCommand(bool enable)
                {
                    string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";

                    void PrintScript(string FileName, string file)
                    {
                        string text = File.ReadAllText(file);
                        string fullText = FileName + " - " + text;
                        Console.WriteLine(fullText);
                        Timing(true, 1);
                    }

                    Styling("Timer");
                    if (enable == true)
                    {
                        Timing(true, 5);
                        PrintScript("UserID", filename);
                        PrintScript("CheckScore_On_Off", CheckScoreOnOff);
                        PrintScript("Print_On_Of", PrintOnOff);
                        PrintScript("Print_Score_Timeout", PrintScoreTimeout);
                        PrintScript("Print_Score_Timeout_On_Off", PrintScoreTimeoutOnOff);
                        PrintScript("Quarter_Max", QuarterMax);
                        PrintScript("Score_Max", ScoreMax);
                        PrintScript("Score_Max_Difference", ScoreMaxDifference);
                        LogSystem("Command Completed");
                        Timing(true, 10);
                        StartPage();
                    }

                    if (enable == false)
                    {
                        Timing(true, 5);
                        PrintScript("UserID", filename);
                        PrintScript("CheckScore_On_Off", CheckScoreOnOff);
                        PrintScript("Print_On_Of", PrintOnOff);
                        PrintScript("Print_Score_Timeout", PrintScoreTimeout);
                        PrintScript("Print_Score_Timeout_On_Off", PrintScoreTimeoutOnOff);
                        PrintScript("Quarter_Max", QuarterMax);
                        PrintScript("Score_Max", ScoreMax);
                        PrintScript("Score_Max_Difference", ScoreMaxDifference);
                        LogSystem("Command Completed");
                        Timing(true, 10);
                    }
                }
                void InfoCommand(bool enable)
                {
                    void print(string text)
                    {
                        void centerText(String t)
                        {
                            Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                            Console.WriteLine(t);
                        }

                        centerText(text);
                    }

                    Styling("Timer");
                    if (enable == true)
                    {
                        print("Created By Skyler Barr");
                        Timing(true, 1);
                        print("Version 1.0");
                        Timing(true, 1);
                        print("Built For Semester Project");
                        LogSystem("Command Completed");
                        Timing(true, 4);
                        StartPage();
                    }

                    if (enable == false)
                    {
                        print("Created By Skyler Barr");
                        Timing(true, 1);
                        print("Version 1.0");
                        Timing(true, 1);
                        print("Built For Semester Project");
                        LogSystem("Command Completed");
                        Timing(true, 4);
                    }
                }
                void ClearL(string text)
                {
                    void Clear(string file)
                    {
                        StreamWriter stream;
                        stream = File.CreateText(file);
                        stream.Close();
                    }

                    void centerText(String t)
                    {
                        Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                        Console.WriteLine(t);
                    }
                    Styling("Timer");
                    Clear(LogFile);
                    centerText(text);
                    Console.Beep(800,200);
                    Timing(true, 5);
                    LogSystem("Program Has Started");
                    StartTimer(true, 4, "Program Starting");
                    StartEnd("Welcome To OBS Extension");
                    LoggedIn();
                    StartPage();
                }
                void ResetId()
                {
                    void ResetUserId()
                    {
                        string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";
                        void IdInfo()
                        {
                            void id(string file, int one, int two, int three, int four)
                            {
                                StreamWriter stream;
                                stream = File.CreateText(file);
                                stream.Write(one + "-" + two + "-" + three + "-" + four);
                                stream.Close();
                            }
                            Random r = new Random();
                            int one = r.Next(0, 9);
                            int two = r.Next(10, 99);
                            int three = r.Next(100, 999);
                            int four = r.Next(1000, 9999);
                            id(filename, one, two, three, four);
                        }
                        void centerText(String t)
                        {
                            Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                            Console.WriteLine(t);
                        }
                        Styling("Timer");
                        IdInfo();
                        string read = File.ReadAllText(filename);
                        string text = "Your New User Id Is: " + read;
                        centerText(text);
                        Timing(true,3);
                        LogSystem("Resetting User Id To: " + read);
                        Timing(true,5);
                    }
                    ResetUserId();
                }
                void ReadUser()
                {
                    string filename = @"C:\Users/" + basename + "/OBS/System/UserID.UserInfo";
                    void centerText(String t)
                    {
                        Console.Write(new string(' ', (Console.WindowWidth - t.Length) / 2));
                        Console.WriteLine(t);
                        LogSystem(t);
                    }
                    Styling("Timer");
                    string read = File.ReadAllText(filename);
                    centerText("User Id: " + read);
                    Timing(true,4);
                }
                void ACommand(bool enabled)
                {
                    InfoCommand(enabled);
                    LCommand(enabled);
                    DCommand(enabled);
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
                    
                }
                if (start == "-S")
                {
                    MainMenu();
                }
                if (start == "-DM")
                {
                    DeveloperMode();
                }
                if (start == "-Ex")
                {
                    
                }
                if (start == "-L")
                {
                    LCommand(true);
                }
                if (start == "-D")
                {
                    DCommand(true);
                }
                if (start == "-A")
                {
                    ACommand(false);
                    StartPage();
                }
                if (start == "-info")
                {
                    InfoCommand(true);
                }
                if (start == "-LClear")
                {
                    ClearL("Cleared File - Must Auto-Restart");
                }
                if (start == "-Id")
                {
                    ReadUser();
                    StartPage();
                }
                if (start == "-ResetId")
                {
                    ResetId();
                    StartPage();
                }
            }
            // Called Functions
            FileSystem();
            Admin();
            LogSystem("Program Has Started");
            StartTimer(true,4,"Program Starting");
            StartEnd("Welcome To OBS Extension");
            LoggedIn();
            StartPage();
            LoggedOut();
            StartEnd("Thank You For Using OBS Extension");
            StartTimer(true,8,"Program Ending");
            LogSystem("Program Has Ended");
        }
    }
}