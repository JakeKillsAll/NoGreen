namespace Oxide.Plugins
{
    [Info("NoGreen", "JakeKillsAll", 0.1)]
    [Description("No Green Admin")]

    class NoGreen : RustPlugin
    {
        //intercepts the chat message
        bool OnPlayerChat(ConsoleSystem.Arg arg)  
        {
            //obtains the player who sent the chat message
            BasePlayer player = (BasePlayer)arg.connection.player;

            //Localizes the player's username
            string usrName = player.displayName;

            //Formats the username and sets the color for the client display
            string usrNameConsole =usrName;
            string usrNameClient = "<color=#55aaff>"+ usrName + "</color>";

            //stores the Message argument locally
            string[] Message = arg.Args;

            //The formats for the messages
            string formatClient = usrNameClient + ": " + Message[0];
            string formatConsole = usrNameConsole + ": " + Message[0];

            //Prints to the console and displays in-game
            PrintToChat(player, formatClient);
            Puts(formatConsole);

            //Make's sure that there is a message, if false, ignores this whole method; if true sends the new formatted message
            if (Message[0].Length > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}