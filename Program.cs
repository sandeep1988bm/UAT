using System;
using NLog;

namespace NLog_to_file
{
    class TestingNLog
    {
        /*
        * This creates your Log. 
        * Notice that in the config file we defined that everything should go into the file.
        * (and if you set the console, it'll output to it as well).
        */
        static readonly Logger Log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
           InteractiveDemo();

            /* 
             * You can run the following for simple log messages
             */
           //SimpleDemo();
        }

        #region Simple demo. Straight to the point.
        private static void SimpleDemo()
        {
            Log.Trace("The chatter of people on the street");
            Log.Debug("Where are you going and why?");
            Log.Info("What bus station you're at.");
            Log.Warn("You're playing on the phone and not looking up for your bus");
            Log.Error("You get on the wrong bus.");
            Log.Fatal("You are run over by the bus.");
            Console.ReadLine();
        }
        #endregion

        #region Interactive amusing demo.

        private static void InteractiveDemo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("The individuals involved:");
            Console.Out.WriteLine("You:\tA male typical IT person");
            Console.Out.WriteLine("SO:\tyour female Significant Other");
            Console.Out.WriteLine("BGFF:\tyour SO's Best Gay Friend Forever");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("The Scenario:");
            Console.Out.WriteLine("You have been dragged into some dress shopping with your SO & her BGFF");
            Console.Out.WriteLine("");
            Console.ResetColor();
            WaitForEnter();


            // Trace - very detailed logs, which may include high-volume information such 
            // as protocol payloads. This log level is typically only enabled during development
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Trace:");
            Console.Out.WriteLine("------");

            Log.Trace("All the chatter between SO & BGFF about the different shades of");
            Log.Trace("pink and how they might or might not match the shoes.");
            WaitForEnter();

            // Debug - debugging information, less detailed than trace, typically not 
            // enabled in production environment.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Debug:");
            Console.Out.WriteLine("------");
            Log.Debug("Your SO emotional level. Influenced usually by the day");
            Log.Debug("of month, and how her last chat with her mother ended.");
            WaitForEnter();

            // Info - information messages, which are normally enabled in production environment
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Info:");
            Console.Out.WriteLine("----");
            Log.Info("Which store are you at.");
            WaitForEnter();

            // Warn - warning messages, typically for non-critical issues, which can be
            // recovered or which are temporary failures
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Warning:");
            Console.Out.WriteLine("-------");
            Log.Warn("Your SO asks: \"Does my ass look fat in this?\".");
            WaitForEnter();

            // Error - error messages
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Error:");
            Console.Out.WriteLine("------");
            Log.Error("You hesitate before answering.");
            WaitForEnter();

            // Fatal - very serious errors
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("Fatal:");
            Console.Out.WriteLine("------");
            Log.Fatal("You answer the above question wrongly.");
            WaitForEnter();

            /*
             * Closing app
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Disclaimer: I will not be hold onto the above stigmas, as they were only.");
            Console.Out.WriteLine("meant to be a humorous example.");
            Console.Out.WriteLine("");
            Console.ResetColor();
            WaitForEnter();
        }

        /// <summary>
        /// Will read keys until 'Enter' is pressed.
        /// </summary>
        private static void WaitForEnter()
        {
            Console.ResetColor();
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Hit Enter to continue");
            ConsoleKeyInfo cki = Console.ReadKey(true); // the true will hide the key from console
            while (cki.Key != ConsoleKey.Enter)
                cki = Console.ReadKey(true);
            Console.Out.WriteLine("");
        } 
        #endregion
    }
}
