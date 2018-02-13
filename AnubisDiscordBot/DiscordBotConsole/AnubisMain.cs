/*
===========================================================================

Anubis Discord Chat Bot MIT Source Code
Copyright (C) 2015-2018 Hevedy <github.com/Hevedy>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

===========================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Security.Cryptography;

using Discord;
using Discord.Commands;


namespace FDL.Library.Numeric {
    public static class RandomNumber {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int Between( int minimumValue, int maximumValue ) {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes( randomNumber );

            double asciiValueOfRandomCharacter = Convert.ToDouble( randomNumber[0] );

            double multiplier = Math.Max( 0, ( asciiValueOfRandomCharacter / 255d ) - 0.00000000001d );

            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor( multiplier * range );

            return (int)( minimumValue + randomValueInRange );
        }
    }
}


namespace DiscordBotConsole {
    class AnubisMain {
        IDiscordClient Discord;
        CommandService Commands;

        private bool lotRunning = false; 
        public bool LotRunning // This is your property
        {
                get { return lotRunning; }
                set { lotRunning = value; }
        }

        public int lotCurrentUserID = 0;
        public int LotCurrentUserID  // This is your property
        {
            get { return lotCurrentUserID; }
            set { lotCurrentUserID = value; }
        }

        public int lotSelectedNum = 0;
        public int LotSelectedNum  // This is your property
        {
            get { return lotSelectedNum; }
            set { lotSelectedNum = value; }
        }

        public int lotMaxNum = 1;
        public int LotMaxNum  // This is your property
        {
            get { return lotMaxNum; }
            set { lotMaxNum = value; }
        }

        public int lotMinNum = 1;
        public int LotMinNum  // This is your property
        {
            get { return lotMinNum; }
            set { lotMinNum = value; }
        }

        public string lotReward = "None";
        public string LotReward  // This is your property
        {
            get { return lotReward; }
            set { lotReward = value; }
        }


        public string lotSelectedWinner = "None";
        public string LotSelectedWinner  // This is your property
        {
            get { return lotSelectedWinner; }
            set { lotSelectedWinner = value; }
        }

        public bool lotNeedNum = false;
        public bool LotNeedNum  // This is your property
        {
            get { return lotNeedNum; }
            set { lotNeedNum = value; }
        }

        public static string GetUserName( IUser MyUser ) {
            if ( MyUser.Nickname == "" || MyUser.Nickname == null ) {
                return MyUser.Name;
            } else {
                return MyUser.Nickname;
            }
        }

        public static string GetUserNameMention( IUser MyUser ) {
            if ( MyUser.NicknameMention == "" || MyUser.NicknameMention == null || MyUser.Nickname == "" || MyUser.Nickname == null ) {
                return MyUser.Mention;
            } else {
                return MyUser.NicknameMention;
            }
        }

        static string ConvertStringArrayToStringJoin( string[] array ) {
            //
            // Use string Join to concatenate the string elements.
            //
            string result = string.Join( " ", array );
            return result;
        }

        public AnubisMain() {

            string BotName = "Anubis";
            string BotVersion = "0.8.9";
            string AdminChannel = "MyAdminChannel";
            string BotChannel = "Bots";
            string EventChannel = "Event";
            bool FutureEvent = false;
            string FutureEventDate = "18/01/01"; //(Year/Month/Day)
            string FutureEventDescription = "";
            string FutureEventReward = "Something for you"; 

            List<int> LotNumbers = new List<int>();
            List<ulong> LotNumbersUser = new List<ulong>();

            System.Timers.Timer LotTimer = new System.Timers.Timer();
            LotTimer.Elapsed += new ElapsedEventHandler( OnTimedLotEvent );
            LotTimer.Interval = 5000;
            LotTimer.Enabled = false;

            bool LotTimerEnabled = false;

            Discord = new DiscordClient( x =>
             {
                 x.LogLevel = LogSeverity.Info;
                 x.LogHandler = Log;

             } );

            Discord.UsingCommands( x =>
            {
                x.PrefixChar = '!';
                x.HelpMode = HelpMode.Disabled;
                x.AllowMentionPrefix = true;
            } );

            Commands = Discord.GetService<CommandService>();

            Commands.CreateCommand( "Help" ).Alias( new string[] { "help", "Info", "info", "Halp", "halp", "HELP", "Ayuda", "AYUDA", "ayuda" } )
                .Do( async ( e ) =>
                {
                    await e.User.SendMessage( "__**General Commands List:**__\n" +
                        "**!Help** - Get the commands list.\n" +
                        "**!Name** - Get the bot name.\n" +
                        "**!Ver/Version** - Returns the bot version.\n" +
                        "**!BugReport** - Report a bug to the developers.\n" +
                        "**!Invite/Discord** - Get the link to invite.\n" +
                        "**!Status/Events** - Returns if there is any events running.\n" +
                        "**!Enter <Optional Number>** - Enter into a running events.\n" +
                        "\n" +
                        "__**Info Commands List:**__\n" +
                        "**!Website/Web** - Returns the your Website.\n" );
            } );


            Commands.CreateCommand( "Bool" ).Alias( new string[] { "bool", "BOOL", "true", "true", "TRUE", "False", "false", "FALSE" } )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    int trueRandom = FDL.Library.Numeric.RandomNumber.Between( 0, 1 );
                    Random rnd = new Random();
                    int r = rnd.Next( 0, 2 );
                    string reply = "Error.";
                    switch ( r ) {
                        case 0:
                            reply = "False";
                            break;
                        case 1:
                            reply = "True";
                            break;
                    }
                    reply = userName + " " + reply + ".";
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Status" ).Alias( new string[] { "status", "STATUS", "Stat", "stat", "STAT", "Event", "event", "EVENT", "Events", "events", "EVENTS" } )
                .Do( async ( e ) =>
                {
                    string reply = "Error.";
                    string userName = GetUserName( e.User );
                    if ( LotRunning ) {
                        reply = "There is one event running";
                        if ( LotNeedNum ) {
                            reply = "There is one event running for a random selected users. The reward is: " + LotReward + "\n";
                        } else {
                            reply = "There is one event running for a random number between " + LotMinNum + " to " + LotMaxNum + ". The reward is: " + LotReward + "\n";
                        }
                    } else {
                        reply = "There are no any active events right now :(" + "\n";
                    }

                    if ( FutureEvent ) {
                        reply = reply + "Future Events: There is a planned event for the day " + FutureEventDate + " (Year/Month/Day) and the reward is a " + FutureEventReward;
                    } else {
                        reply = reply + "Future Events: No future events soon.";
                    }
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Sum" ).Alias( new string[] { "sum", "SUM", "Add", "add", "ADD" } )
                .Parameter( "NumberA", ParameterType.Required )
                .Parameter( "NumberB", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    int numberA = 0, numberB = 0, numCalc = 0;
                    string reply = "Error.";
                    string userName = GetUserName( e.User );
                    if ( e.GetArg( "NumberA" ) != "" && e.GetArg( "NumberB" ) != "" ) {
                        if ( Int32.TryParse( e.GetArg( "NumberA" ), out numberA ) ) {
                            if ( Int32.TryParse( e.GetArg( "NumberB" ), out numberB ) ) {
                                numCalc = Convert.ToInt32( e.GetArg( "NumberA" ) ) + Convert.ToInt32( e.GetArg( "NumberB" ) );
                                reply = "(" + e.GetArg( "NumberA" ) + " + " + e.GetArg( "NumberB" ) + ") = " + numCalc.ToString();
                            } else {
                                reply = "one of the numbers is invalid";
                            }
                        } else {
                            reply = "one of the numbers is invalid";
                        }
                    } else {
                        reply = "one of the numbers is missing";
                    }
                    reply = userName + " " + reply + ".";
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Sub" ).Alias( new string[] { "sub", "SUB", "Subtraction", "subtraction", "SUBTRACTION" } )
                .Parameter( "NumberA", ParameterType.Required )
                .Parameter( "NumberB", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    int numberA = 0, numberB = 0, numCalc = 0;
                    string reply = "Error.";
                    string userName = GetUserName( e.User );
                    if ( e.GetArg( "NumberA" ) != "" && e.GetArg( "NumberB" ) != "" ) {
                        if ( Int32.TryParse( e.GetArg( "NumberA" ), out numberA ) ) {
                            if ( Int32.TryParse( e.GetArg( "NumberB" ), out numberB ) ) {
                                numCalc = Convert.ToInt32( e.GetArg( "NumberA" ) ) - Convert.ToInt32( e.GetArg( "NumberB" ) );
                                reply = "(" + e.GetArg( "NumberA" ) + " - " + e.GetArg( "NumberB" ) + ") = " + numCalc.ToString();
                            } else {
                                reply = "one of the numbers is invalid";
                            }
                        } else {
                            reply = "one of the numbers is invalid";
                        }
                    } else {
                        reply = "one of the numbers is missing";
                    }
                    reply = userName + " " + reply + ".";
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Mul" ).Alias( new string[] { "mul", "MUL", "Multiplication", "multiplication", "MULTIPLICATION" } )
                .Parameter( "NumberA", ParameterType.Required )
                .Parameter( "NumberB", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    int numberA = 0, numberB = 0, numCalc = 0;
                    string reply = "Error.";
                    string userName = GetUserName( e.User );
                    if ( e.GetArg( "NumberA" ) != "" && e.GetArg( "NumberB" ) != "" ) {
                        if ( Int32.TryParse( e.GetArg( "NumberA" ), out numberA ) ) {
                            if ( Int32.TryParse( e.GetArg( "NumberB" ), out numberB ) ) {
                                numCalc = Convert.ToInt32( e.GetArg( "NumberA" ) ) * Convert.ToInt32( e.GetArg( "NumberB" ) );
                                reply = "(" + e.GetArg( "NumberA" ) + " X " + e.GetArg( "NumberB" ) + ") = " + numCalc.ToString();
                            } else {
                                reply = "one of the numbers is invalid";
                            }
                        } else {
                            reply = "one of the numbers is invalid";
                        }
                    } else {
                        reply = "one of the numbers is missing";
                    }
                    reply = userName + " " + reply + ".";
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Div" ).Alias( new string[] { "div", "DIV", "Division", "division", "DIVISION" } )
                .Parameter( "NumberA", ParameterType.Required )
                .Parameter( "NumberB", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    int numberA = 0, numberB = 0, numCalc = 0;
                    string reply = "Error.";
                    string userName = GetUserName( e.User );
                    if ( e.GetArg( "NumberA" ) != "" && e.GetArg( "NumberB" ) != "" ) {
                    if ( Int32.TryParse( e.GetArg( "NumberA" ), out numberA ) ) {
                        if ( Int32.TryParse( e.GetArg( "NumberB" ), out numberB ) ) {
                            numCalc = Convert.ToInt32( e.GetArg( "NumberA" ) ) / Convert.ToInt32( e.GetArg( "NumberB" ) );
                            reply = "(" + e.GetArg( "NumberA" ) + " : " + e.GetArg( "NumberB" )  + ") = " + numCalc.ToString();
                        } else {
                            reply = "one of the numbers is invalid";
                        }
                    } else {
                        reply = "one of the numbers is invalid";
                    }
                    } else {
                    reply = "one of the numbers is missing";
                    }
                    reply = userName + " " + reply + ".";
                    await e.Channel.SendMessage( reply );
                } );

            Commands.CreateCommand( "Ask" ).Alias( new string[] { "ask", "8Ball", "8ball", "ASK", "8BALL", "Preguntar", "preguntar" } )
                .Parameter( "Question", ParameterType.Multiple )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    int numUsers = e.Channel.Users.Count();
                    Random rnda = new Random();
                    int ra = rnda.Next( 0, numUsers );
                    string randomUser = GetUserName( e.Channel.Users.ElementAt( ra ) );
                    string reply = "Error.";
                    Random rnd = new Random();
                    int r = rnd.Next( 0, 9 );
                    if ( e.GetArg( "Question" ) != "" ) {
                        switch ( r ) {
                            case 0:
                                reply = "no";
                                break;
                            case 1:
                                reply = "you should ask " + randomUser + " that";
                                break;
                            case 2:
                                reply = "Probably";
                                break;
                            case 3:
                                reply = "IDK";
                                break;
                            case 4:
                                reply = "Mmm can be";
                                break;
                            case 5:
                                reply = "LOL what ?";
                                break;
                            case 6:
                                reply = "YES";
                                break;
                            case 7:
                                reply = "yes";
                                break;
                            case 8:
                                reply = "NO";
                                break;
                        }
                        reply = userName + " " + reply + ".";
                    } else {
                        reply = userName + " are you trolling me ?";    
                    }
                    await e.Channel.SendMessage( reply );
                } );


            Commands.CreateCommand( "Coin" ).Alias( new string[] { "coin", "COIN", "Moneda", "moneda", "MONEDA" } )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string reply = "Error.";
                    Random rnd = new Random();
                    int r = rnd.Next( 0, 8 );
                    switch ( r ) {
                        case 0:
                            reply = "Heads";
                            break;
                        case 1:
                            reply = "Tails";
                            break;
                        case 2:
                            reply = "Tails";
                            break;
                        case 3:
                            reply = "The coin hit your head, and you fall to the ground. War, war never changes";
                            break;
                        case 4:
                            reply = "Heads";
                            break;
                        case 5:
                            reply = "_The coin falls throw the sewer grate_";
                            break;
                        case 6:
                            reply = "Heads";
                            break;
                        case 7:
                            reply = "Tails";
                            break;
                    }
                    await e.Channel.SendMessage( userName + " " + reply + "." );
                } );

            Commands.CreateCommand( "GameIdea" ).Alias( new string[] { "gameidea", "Gameidea", "GAMEIDEA" } )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    int numUsers = e.Channel.Users.Count();
                    Random rnd = new Random();
                    int ra = rnd.Next( 0, numUsers );
                    string randomUser = GetUserName( e.Channel.Users.ElementAt( ra ) );
                    string reply = "Error.";
                    int r = rnd.Next( 0, 7 );
                    switch ( r ) {
                        case 0:
                            reply = "sorry I can't share my ideas for free";
                            break;
                        case 1:
                            reply = "PM me in private to reach a price, to share with you my idea";
                            break;
                        case 2:
                            reply = "I'm out of ideas sorry";
                            break;
                        case 3:
                            reply = "you should ask " + randomUser + " for a real good idea";
                            break;
                        case 4:
                            reply = "Error 404 Not Found";
                            break;
                        case 5:
                            reply = "you should sign a NDA before I can share with you my idea";
                            break;
                        case 6:
                            reply = "got an idea, but we have to split the game income 50%-50%";
                            break;
                    }
                    await e.Channel.SendMessage( userName + " " + reply + "." );

                    int colorsNum = 15, entitiesNum = 14, actionsNum = 8, finalNum = 14;
                    Random random = new Random();
                    colorsNum = random.Next( 0, colorsNum );
                    entitiesNum = random.Next( 0, entitiesNum );
                    actionsNum = random.Next( 0, actionsNum );
                    finalNum = random.Next( 0, finalNum );
                    string[] colorsArray = new string[15] { "red", "green", "purple", "orange", "yellow", "blue", "grey", "white", "black", "pink", "normal" ,"big", "small", "huge", "tiny" };
                    string[] entitiesArray = new string[14] { "houses", "cars", "trees", "bridges", "builds", "doors", "windows", "dogs", "cats", "giraffes", "mammoths", "carpets", "humans", "owls" };
                    string[] actionArray = new string[8] { "that walk over", "that swim in", "that fly over", "that destroy", "that punch", "that break", "that cut", "that jump over" };
                    string[] finalArray = new string[14] { "fields", "swimming pools", "roads", "houses", "trees", "airplanes", "holes", "glasses", "game engines", "docs", "computers", "owls", "humans", "walls" };
                    string baseName = "A game about " + colorsArray[colorsNum] + " " + entitiesArray[entitiesNum] + " " + actionArray[actionsNum] + " " + finalArray[finalNum];
                    if ( r == 1 ||r == 6 || r == 5 ) {
                        await e.User.SendMessage( "Pss " + userName + " " + baseName + "." );
                    }
                } );

            Commands.CreateCommand( "Music" ).Alias( new string[] { "music", "MUSIC", "Musica", "MUSICA", "musica" } )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string reply = "Error.";
                    Random rnd = new Random();
                    int r = rnd.Next( 0, 15 );
                    switch ( r ) {
                        case 0:
                            reply = "URL";
                            break;
                        case 1:
                            reply = "URL";
                            break;
                        case 2:
                            reply = "URL";
                            break;
                        case 3:
                            reply = "URL";
                            break;
                        case 4:
                            reply = "URL";
                            break;
                        case 5:
                            reply = "URL";
                            break;
                        case 6:
                            reply = "URL";
                            break;
                        case 7:
                            reply = "URL";
                            break;
                        case 8:
                            reply = "URL";
                            break;
                        case 9:
                            reply = "URL";
                            break;
                        case 10:
                            reply = "URL";
                            break;
                        case 11:
                            reply = "URL";
                            break;
                        case 12:
                            reply = "URL";
                            break;
                        case 13:
                            reply = "URL";
                            break;
                        case 14:
                            reply = "URL";
                            break;
                    }
                    await e.Channel.SendMessage( userName + " " + reply + "." );
                } );

            Commands.CreateCommand( "BugReport" ).Alias( new string[] { "bugreport", "Bugreport", "BUGREPORT" } )
                .Parameter( "Report", ParameterType.Multiple )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string report = "Error.";
                    if ( e.GetArg( "Report" ) != "" ) {
                        string bugreport = "Empty.";
                        bugreport = ConvertStringArrayToStringJoin(e.Args);
                        Console.WriteLine( e.User.Name + " ###Reported a bug: " + bugreport );
                        report = userName + " thanks you for report a bug, the developers will be notified.";
                    } else {
                        report = userName + " you should add the bug description after the command.";
                    }
                    await e.Channel.SendMessage( report );

                } );

            Commands.CreateCommand( "Roll" ).Alias( new string[] { "help", "Info", "info", "Halp", "halp", "HELP", "Ayuda", "AYUDA", "ayuda" } )
                .Do( async ( e ) =>
                {
                    await e.Channel.SendMessage( "❄" );
                } );

            Commands.CreateCommand( "Hello" ).Alias( new string[] { "hello", "HELLO", "Hi", "hi", "HI" } )
                .Parameter( "User", ParameterType.Optional )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string text = "Error.";
                    if ( e.GetArg( "User" ) != "" ) {
                        var user = e.Channel.FindUsers( e.GetArg( "User" ) ).FirstOrDefault();
                        if ( user == null ) {
                            text = "_" + userNameMention + " says hello to " + "his invisible friend." + "_";
                        } else {
                            text = "_" + userNameMention + " says hello to " + GetUserNameMention( user ) + "." + "_";
                        }
                    } else {
                        text = "_" + userNameMention + " says hello to " + "the chat." + "_";
                    }
                    await e.Channel.SendMessage( text );
                } );

            Commands.CreateCommand( "Bye" ).Alias( new string[] { "bye", "BYE", "cya", "Cya", "CYA" } )
                .Parameter( "User", ParameterType.Optional )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string text = "Error.";
                    if ( e.GetArg( "User" ) != "" ) {
                        var user = e.Channel.FindUsers( e.GetArg( "User" ) ).FirstOrDefault();
                        if ( user == null ) {
                            text = "_" + userNameMention + " says goodbye to " + "his invisible friend." + "_";
                        } else {
                            text = "_" + userNameMention + " says goodbye to " + GetUserNameMention( user ) + "." + "_";
                        }
                    } else {
                        text = "_" + userNameMention + " says goodbye to " + "the chat." + "_";
                    }
                    await e.Channel.SendMessage( text );
                } );

            Commands.CreateCommand( "Welcome" ).Alias( new string[] { "welcome", "WELCOME", "Wel", "wel", "WEL" } )
                .Parameter( "User", ParameterType.Optional )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string text = "Error.";
                    if ( e.GetArg( "User" ) != "" ) {
                        var user = e.Channel.FindUsers( e.GetArg( "User" ) ).FirstOrDefault();
                        if ( user == null ) {
                            text = "_" + userNameMention + " says welcome to " + "his invisible friend." + "_";
                        } else {
                            text = "_" + userNameMention + " says welcome to " + GetUserNameMention( user ) + "." + "_";
                        }
                    } else {
                        text = "_" + userNameMention + " says welcome to " + "the chat." + "_";
                    }
                    await e.Channel.SendMessage( text );
                } );

            Commands.CreateCommand( "Ping" ).Alias( new string[] { "ping", "png" } )
                .Do( async ( e ) =>
                 {
                     await e.Channel.SendMessage( "Pong" );
                 } );

            Commands.CreateCommand( "Name" ).Alias( new string[] { "name", "botname", "BotName", "Botname", "Bot", "BOT", "NAME", "BOTNAME", "Nombre" } )
                .Do( async ( e ) =>
                {
                    await e.Channel.SendMessage( "My Name is " + BotName + ", what is your name ?" );
                } );

            Commands.CreateCommand( "Version" ).Alias( new string[] { "version", "VERSION", "BotVersion", "botversion", "Botversion", "BOTVERSION", "BotVer", "Botver", "botver", "BOTVER", "Ver", "ver", "VER" } )
                .Do( async ( e ) =>
                {
                    await e.Channel.SendMessage( "My Version is: " + BotVersion );
                } );

            Commands.CreateCommand( "Website" ).Alias( new string[] { "website", "WEBSITE", "Web", "web", "WEB" } )
                .Do( async ( e ) =>
                {
                    await e.Channel.SendMessage( "Website: MyWebsite" );
                } );

            Commands.CreateCommand( "Mission" ).Alias( new string[] { "mission", "miss" } )
                .Do( async ( e ) =>
                {
                    await e.Channel.SendTTSMessage( "My mission is dominate the world." );
                } );

            Commands.CreateCommand( "Random" ).Alias( new string[] { "random", "rand" } )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    Random rnd = new Random();
                    int r = rnd.Next();
                    await e.Channel.SendMessage( userName + " your number: " + r.ToString() );
                } );

            // !StartLot Nothing -1 0 100 1
            Commands.CreateCommand( "StartLot" )
                .Parameter( "Reward", ParameterType.Required )
                .Parameter( "Time", ParameterType.Required )
                .Parameter( "MinNum", ParameterType.Required )
                .Parameter( "MaxNum", ParameterType.Required )
                .Parameter( "NeedNumber", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    string final = "Error";
                    var role = e.Server.FindRoles( AdminChannel ).FirstOrDefault();
                    if ( e.User.HasRole( role ) ) {
                        LotNumbers.Clear();
                        LotNumbersUser.Clear();
                        Random rnd = new Random();
                        int time = 60000;
                        if ( Convert.ToInt32( e.GetArg( "Time" ) ) == -1 ) {
                            time = -1000;
                        } else {
                            time = Convert.ToInt32( e.GetArg( "Time" ) ) * 60000;
                        }
                        string reward = e.GetArg( "Reward" );
                        string rewardNew = reward.Replace( "_", " " );
                        LotReward = rewardNew;
                        int needNum = Convert.ToInt32( e.GetArg( "NeedNumber" ) );
                        if ( needNum == 1 ) {
                            LotNeedNum = true;
                        } else {
                            LotNeedNum = false;
                        }
                        LotMinNum = Convert.ToInt32( e.GetArg( "MinNum" ) );
                        LotMaxNum = Convert.ToInt32( e.GetArg( "MaxNum" ) );
                        if ( time == -1000 ) {
                            LotTimerEnabled = false;
                        } else {
                            LotTimerEnabled = true;
                            LotTimer.Stop();
                            LotTimer.Interval = time
                            LotTimer.Enabled = true;
                            LotTimer.Start();
                        }
                        int r = rnd.Next();
                        LotRunning = true;
                        if ( time == -1000 ) {
                            if ( LotNeedNum ) {
                                final = "**###** Lottery for with numbers from " + LotMinNum + " to " + LotMaxNum + ". Reward: " + rewardNew + ". Has been started.";
                            } else {
                                final = "**###** Lottery with reward: " + rewardNew + ". Has been started.";
                            }
                        } else {
                            if ( LotNeedNum ) {
                                final = "**###** Lottery for " + e.GetArg( "Time" ) + " minute/s, with numbers from " + LotMinNum + " to " + LotMaxNum + ". Reward: " + rewardNew + ". Has been started.";
                            } else {
                                final = "**###** Lottery for " + e.GetArg( "Time" ) + " minute/s" + ". Reward: " + rewardNew + ". Has been started.";
                            }
                        }
                    } else {
                        final = "Sorry only the admin can start a Lottery.";
                    }
                    await e.Channel.SendMessage( final );
                } );

            Commands.CreateCommand( "BotEndLot" )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string final = "Error";
                    var roleA = e.Server.FindRoles( BotChannel ).FirstOrDefault();
                    var roleB = e.Server.FindRoles( AdminChannel ).FirstOrDefault();
                    if ( ( e.User.HasRole( roleA ) || e.User.HasRole( roleB ) ) && LotRunning ) {
                        LotRunning = false;
                        if ( LotTimerEnabled ) {
                            LotTimerEnabled = false;
                            LotTimer.Enabled = false;
                            LotTimer.Stop();
                        }
                        if ( LotNeedNum ) {
                            int sRandLoops = FDL.Library.Numeric.RandomNumber.Between( 0, 9999 );
                            Random rnd = new Random();
                            int number = 0;
                            for ( int i = 0; i < sRandLoops; i++ ) {
                                number = rnd.Next( LotMinNum, LotMaxNum + 1 );
                            }

                            if ( LotNumbers.Contains( number ) ) {
                                int numIndex = LotNumbers[number];
                                ulong userID = LotNumbersUser[numIndex];
                                var user = e.Channel.GetUser( userID );
                                final = "The lottery number is the: **#" + number + "**. The winner of the lottery reward: **" + LotReward + "** is: " + GetUserNameMention( user );
                            } else {
                                final = "The lottery number is the: **#" + number + "** there is no winner.";
                            }
                        } else {
                            if ( LotNumbersUser.Count() >= 1 ) {
                                int sRandLoops = FDL.Library.Numeric.RandomNumber.Between( 0, 9999 );
                                Random rnd = new Random();
                                int number = 0;
                                for ( int i = 0; i < sRandLoops; i++ ) {
                                    number = rnd.Next( 0, LotNumbersUser.Count() );
                                }
                                ulong userID = LotNumbersUser[number];
                                var user = e.Channel.GetUser( userID );
                                final = "The winner of the lottery reward: **" + LotReward + "** is: " + GetUserNameMention( user );
                            } else {
                                final = "No one entered to the lottery.";
                            }
                        }
                        var userAdmin = e.Channel.FindUsers( "AdminName" ).FirstOrDefault();
                        final = final + "\n**The winner will be contacted via PM by** " + GetUserNameMention( userAdmin ) + ". Thanks you all for enter!";
                    } else {
                        final = "Sorry only the admin can end the lottery.";
                    }
                    await e.Channel.SendMessage( final );
                } );

            Commands.CreateCommand( "GetFromGroup" )
                .Parameter( "Reward", ParameterType.Required )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string final = "Error";
                    LotNumbers.Clear();
                    LotNumbersUser.Clear();
                    var roleA = e.Server.FindRoles( BotChannel ).FirstOrDefault();
                    var roleB = e.Server.FindRoles( AdminChannel ).FirstOrDefault();
                    if ( e.User.HasRole( roleA ) || e.User.HasRole( roleB ) ) {
                        string reward = e.GetArg( "Reward" );
                        string rewardNew = reward.Replace( "_", " " );
                        LotReward = rewardNew;
                        var roleC = e.Server.FindRoles( EventChannel ).FirstOrDefault();
                        List<IUser> usersList = new List<IUser>();
                        usersList = e.Server.Users.ToList<IUser>();
                        for ( int i = 0; i < e.Server.UserCount; i++ ) {
                            if (usersList[i].HasRole( roleC )) {
                                LotNumbersUser.Add( usersList[i].Id );
                            }
                        }
                        if ( LotNumbersUser.Count() >= 1 ) {
                            int sRandLoops = FDL.Library.Numeric.RandomNumber.Between( 0, 9999 );
                            Random rnd = new Random();
                            int number = 0;
                            for ( int i = 0; i < sRandLoops; i++ ) {
                                number = rnd.Next( 0, LotNumbersUser.Count() );
                            }
                            ulong userID = LotNumbersUser[number];
                            var user = e.Channel.GetUser( userID );
                            final = "The winner of the event reward: **" + LotReward + "** is: " + GetUserNameMention( user );
                        } else {
                            final = "No one entered to the lottery.";
                        }
                        var userAdmin = e.Channel.FindUsers( "AdminName" ).FirstOrDefault();
                        final = final + "\n**The winner will be contacted via PM by** " + GetUserNameMention( userAdmin ) + ". Thanks you all for enter!";
                    } else {
                        final = "Sorry only the admin can execute this command.";
                    }
                    await e.Channel.SendMessage( final );
                } );

            Commands.CreateCommand( "Enter" ).Alias( new string[] { "enter" } )
                .Parameter( "Number", ParameterType.Optional )
                .Do( async ( e ) =>
                {
                    string userName = GetUserName( e.User );
                    string userNameMention = GetUserNameMention( e.User );
                    string final = "Error";
                    Console.WriteLine( e.Channel.ToString() );
                    if ( e.Channel.ToString() == "general" ) { 
                        if ( LotRunning ) {
                            Random rnd = new Random();
                            int r = rnd.Next(LotMinNum, LotMaxNum + 1);
                            int number = r;
                            int lotIndex = 0;
                            int userIndex = 0;
                            ulong userID = 0;
                            ulong thisUserID = 0;
                            int oldNumber = 0;
                            if ( e.GetArg( "Number" ) != "" ) {
                                if (Int32.TryParse( e.GetArg( "Number" ), out number ) ) { // Check if is a valid number
                                    if ( number >= LotMinNum && number <= LotMaxNum ) {

                                    } else {
                                        number = r;
                                    }
                                } else {
                                    number = r;
                                }
                            } else {
                                number = r;
                            }

                            if ( LotNeedNum ) { 
                                if ( LotNumbers.Contains( number ) ) { 
                                    lotIndex = LotNumbers.IndexOf( number );
                                    userIndex = lotIndex;
                                    userID = LotNumbersUser[userIndex];
                                    thisUserID = e.User.Id;
                                    if ( thisUserID == userID ) {
                                        final = userName + " is already in with the " + number + " to the lottery.";
                                    } else { 
                                        while ( LotNumbers.Contains( number ) ) { 
                                            r = rnd.Next( LotMinNum, LotMaxNum + 1);
                                            number = r;
                                        }
                                        if ( LotNumbersUser.Contains( thisUserID ) ) { //
                                            userIndex = LotNumbersUser.IndexOf( thisUserID );
                                            userID = LotNumbersUser[userIndex];
                                            oldNumber = LotNumbers[userIndex];
                                            LotNumbers[userIndex] = number;
                                            final = userName + " changed the number from " + oldNumber + " to " + number + " (random selected) to the lottery.";
                                        } else { 
                                            LotNumbers.Add( number );
                                            LotNumbersUser.Add( thisUserID );
                                            final = "**###**" + userName + " enter with the number " + number + " (random selected) to the lottery.";
                                        }
                                    }
                                } else { 
                                    thisUserID = e.User.Id;
                                    if ( LotNumbersUser.Contains( thisUserID ) ) { 
                                        userIndex = LotNumbersUser.IndexOf( thisUserID );
                                        lotIndex = userIndex;
                                        oldNumber = LotNumbers[lotIndex];
                                        if ( LotNumbers.Contains( number ) ) { 
                                            while ( LotNumbers.Contains( number ) ) {
                                                r = rnd.Next( LotMinNum, LotMaxNum + 1);
                                                number = r;
                                            }
                                            LotNumbers[userIndex] = number;
                                            final = userName + " changed the number from " + oldNumber + " to " + number + " (random selected) to the lottery.";
                                        } else {
                                            LotNumbers[userIndex] = number;
                                            final = userName + " changed the number from " + oldNumber + " to " + number + " for the lottery.";
                                        }
                                    } else { 
                                        if ( LotNumbers.Contains( number ) ) {
                                            while ( LotNumbers.Contains( number ) ) {
                                                r = rnd.Next( LotMinNum, LotMaxNum + 1);
                                                number = r;
                                            }
                                            LotNumbers.Add( number );
                                            LotNumbersUser.Add( thisUserID );
                                            final = userName + " changed the number from " + oldNumber + " to " + number + " (random selected) to the lottery.";
                                        } else {
                                            LotNumbers.Add( number );
                                            LotNumbersUser.Add( thisUserID );
                                            final = "**###**" + userName + " enter with the number " + number + " to the lottery.";
                                        }
                                    }
                                }

                            } else {
                                thisUserID = e.User.Id;
                                if( LotNumbersUser.Contains( thisUserID ) ) {
                                    userIndex = LotNumbersUser.IndexOf( thisUserID );
                                    final = userName + " you're already in the lottery with the number #" + userIndex + ".";

                                } else {
                                    LotNumbersUser.Add( thisUserID );
                                    final = "**###**" + userName + " enter to the lottery.";
                                }
                            }
                        } else {
                            final = "Sorry " + userName + " there isn't any Lottery to enter right now.";
                        }
                    } else {
                        final = "Sorry " + userName + " you can't play lottery in this chat.";
                    }
                    await e.Channel.SendMessage( final );
            } );

            Commands.CreateCommand( "StopLottery" ) // !StopLottery
                .Do( async ( e ) =>
                {
                    if ( e.User.HasRole( e.Server.FindRoles( "Admin" ).FirstOrDefault() ) ) {
                        await e.Channel.SendMessage( "Lottery" );
                    }
                } );

            Discord.ExecuteAndWait( async () =>
             {
                 await Discord.Connect( "YourToken", TokenType.Bot );
             } );


        }

        private void OnTimedLotEvent( object source, ElapsedEventArgs e ) {
            EndLot();
            Console.WriteLine( "Hello World!" );
        }

        private void EndLot() {
            LotRunning = false;
        }

        private Task Log( LogMessage message ) {
            Console.WriteLine( message.ToString() );
            return Task.CompletedTask;
        }


    }

}
