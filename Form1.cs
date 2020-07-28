using System;
using System.Windows.Forms;

//The C# API can be re-downloaded at https://wearedevs.net/d/Exploit%20API
//Make sure it is added as a reference if you decide to re-download
using WeAreDevs_API;

//The exploit itself auto updates. You never need to do work yourself!
//Just create the project once and let WeAreDevs do the work for you.
//Why is this free? Its because of the non-intrusive watermark the API adds
namespace Exploit_Template_with_WRDAPI
{
    public partial class Form1 : Form
    {
        //Creates object so we can make calls to WeAreDevs_API.
        readonly ExploitAPI api = new ExploitAPI();
        /*To see methods you can call, go to 
        The project in the solution explorer -> References -> Right click on WeAreDevs_API.dll ->
        View in Object Browser -> WeAreDevs_API -> WeAreDevs_API -> click Exploit API.
        This will then show a list of all functions you can use!*/

        public Form1()
        {
            InitializeComponent();
        }

        //The exploit must be injected before calling any other function!
        private void BtnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        //Executes the lua script
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = inputScript.Text;
            api.SendLimitedLuaScript(script);
        }

        //Sets your player's walkspeed to 100
        //Quick command button using a Lua script
        private void BtnSpeed_Click(object sender, EventArgs e)
        {
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");
        }

        //Gives your player btools
        //Quick command button using a pre-built command
        private void BtnBtools_Click(object sender, EventArgs e)
        {
            api.SendCommand("btools me");
        }

        //Example usage of a dynamic command
        //Quick command button using a pre-built command, but this one grab's the user input
        //Teleports the player to a player of the specified username
        private void BtnTPTo_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.SendCommand("teleport " + username);
        }

        //Changes UI text to say if the exploit is injected or not
        //Challenge: Try making the attach button only show if the exploit is not injected
        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                txtIsInjected.Text = "Status: online";
            }
            else
            {
                //The exploit is not injected... The client must inject
                txtIsInjected.Text = "Status: offline";
            }
        }

        //Check if the exploit is injected on load
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //Check if the exploit is injected every 3 seconds
        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.SendCommand("float me");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.SendCommand("unfloat me");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Charachter.Humanoid,JumpPower=100");
        }
    }
}
}
}
}
