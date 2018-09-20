using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWayOfMrsCosmopolite
{
    public partial class cosmopoliteForm : Form
    {
        public cosmopoliteForm()
        {
            InitializeComponent();
        }

        // Create Method for Clicking of Help Button
        // Declare and populate rndNum variable
        // Create Case statement to show different help message dependent on rndNum
        // Cancel Help
        private void cosmopoliteForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            cosmopoliteAbout aboutBox = new cosmopoliteAbout();
            aboutBox.ShowDialog();
            e.Cancel = true;
        }

        // Create Method for cosmopoliteForm Form Load
        private void cosmopoliteForm_Load(object sender, EventArgs e)
        {
            // Declare and populate textString List
            string[] textString = { " A little soap and water never killed anyone.", " A penny saved is a penny earned.", " A washed pot never boils.", " Because.", " Big events always cast their shadows.", " Bored! How can you be bored? I was never bored at your age.", " Close the door! you weren't born in a barn.", " Do as I say not as I do.", " Do unto otters as you would have them do unto you.", " Do you think I'm made of money?", " Do you think this is a hotel? You can't come in here only to sleep.", " Don't go out with a wet head, you'll catch cold.", " Don't make me come in there!", " Don't talk with your mouth full.", " Don't put that in your mouth, you don't know where it's been.", " Don't you have anything better to do.", " Eat it up, it'll make your hair curly.", " Enough is enough.", " Everything comes to he who waits.", " Every second counts.", " Go to your room and think about what you did!", " Hard work never did anybody any harm.", " How do you know you don't like it you haven't tasted it.", " How many times do I have to tell you?", " I can always tell when you're lying.", " I can't be having with that kind of thing.", " I'd forget my own head if it wasn't nailed on.", " If a single woman sleeps with a piece of wedding cake under her pillow, she will dream of her future husband.", " If I've told you once I've told you a million times.", " If it were a dog, it would have bitten you.", " If the wind changes, your face will stay like that.", " If Om had wanted you to have holes in your ears he would have put them there.", " If you can't say something nice, don't say anything at all.", " If you don't clean your plate, you won't get any dessert.", " If you don't stop crying I'll give you something to cry about.", " If you have another one you won't have an appetite for your dinner.", " If you keep goin' all cosmic on me you'll feel the end of my broom and no mistake.", " If you play with fire you will wet the bed.", " If you want a thing done properly you've got to do it yourself.", " If you feel a burning in your ears somebody is talking about you.", " If you're too sick to work you're too sick to go out tonight.", " I haven't got all day, you know.", " I have only one pair of hands.", " I was not born yesterday.", " I'll treat you like an adult when you start acting like one.", " I'm not as green as I'm cabbage-looking.", " I'm not always going to be around to do these things for you.", " I'm not going to ask you again.", " It does you good to get out in the fresh air.", " It never rains but it pours.", " It's amazing what you see if you keep your eyes open.", " It won't get better if you pick at it.", " I've got a feeling in my water.", " Learn to eat with a knife and fork.", " Oo, you are so sharp you'll cut yourself one of these days.", " Say that again and I'll wash your mouth out with soap.", " Seeing is believing.", " The big sea does not care which way the little fishes swim.", " There is a time and a place for everything.", " There is no time like the present.", " There's a lot goes on we don't get told.", " There's a lot goes on we don't know about, in my opinion.", " We live and learn.", " Well, I'll go to the foot of our stairs.", " When I was you age, I had to walk ten miles through the snow, uphill, by myself, every day, to go to school.", " When you have got to go, you have got to go.", " Wrap up warm or you'll catch your death.", " You can't tell a book by its cover.", " You could knock me down with a feather.", " You never know what's going to turn up.", " You should always wear clean underwear because you never know if you will be knocked down by a cart.", " You've got to learn to walk before you can run." };

            // Declare and populate rndNum and randomNumber variables
            // Update cosmopoliteText TextBox dependent on randomNumber value
            Random rndNum = new Random();
            int randomNumber = rndNum.Next(0, textString.Length);
            cosmopoliteText.Text = textString[randomNumber];
        }

        // Create Method for cosmopoliteForm Form Closure
        private void cosmopoliteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Declare and populate variables
            Random rndNum = new Random();
            string[] yearString = { "Lenient Vegetable", "Pensive Hare", "Astounded Beetle", "Engaging Sloth", "Hyena", "Notional Serpent", "Prawn", "Pensive Frog", "Reversed Ptarmigan", "Revolving Crab", "Sideways Leech", "Spinning Mouse", "Talking Frog", "Reciprocating Llama", "Sneezing Panda", "Intimidating Porpoise", "Backwards-Facing Artichoke", "Scrofulous Vole", "Justifiably Defensive Lobster" };
            int yearNumber = rndNum.Next(0, yearString.Length);
            string[] driveString = { "∞", "∆", "∑", "π", "Ø", "Γ", "Θ", "Λ", "Ξ", "Φ", "Ψ", "Ω", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int driveNumber = rndNum.Next(0, driveString.Length);
            string streetNumber = rndNum.Next(0, 25).ToString();
            int closeNumber = rndNum.Next(0, 10);
            string[] errorString = { "*Blip* *Blip* *Blip* Can Not Find Drive "+ driveString[driveNumber] +":", "*Blip* *Blip* *Blip* End of Cheese Error", "*Blip* *Blip* *Blip* Please Reboot Universe", "*Blip* *Blip* *Blip* Unknown Application Error", "*Blip* *Blip* *Blip* Year Of The "+ yearString[yearNumber] +" *Blip* *Blip* *Blip*", "+++ ?????? +++ Hello +++ Redo From Start +++", "+++ Error At Address: "+ streetNumber +", Treacle Mine Road, Ankh-Morpork +++", "+++ Eternal domain error +++", "+++ Hi Mum Is Testing +++ MELON MELON MELON +++ Out Of Cheese Error +++ !!!!! +++ Mr. Jelly! Mr. Jelly! +++", "+++ MELON MELON MELON +++", "+++ Mr. Jelly! Mr. Jelly! +++", "+++ Oneoneoneoneoneoneone +++", "+++ Out Of Cheese Error +++ MELON MELON MELON +++ Redo From Start +++", "+++ Out Of Cheese Error +++", "+++ Out of Cheese Error. Redo From Start. +++", "+++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++ MELON MELON MELON +++ Error At Address: "+ streetNumber +", Treacle Mine Road, Ankh-Morpork +++ !!!!! +++ Oneoneoneoneoneone +++ Redo From Start +++", "+++ Whoops! Here Comes The Cheese! +++", "Because Everything. ????? Eternal Domain Error. +++++ Redo From Start +++++.", "*Blip* *Blip* *Blip* Year Of The "+ yearString[yearNumber] +" *Blip* *Blip* *Blip*" };
            int errorNumber;
            errorNumber = rndNum.Next(0, errorString.Length);

            // If closeNumber equals 5 then show random errorString
            if (closeNumber == 5){
                 MessageBox.Show(errorString[errorNumber],"HEX",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Create Method for cosmopoliteForm DoubleClick
        private void cosmopoliteForm_DoubleClick(object sender, EventArgs e)
        {
            // Execute code from cosmopoliteForm Load Method    
            cosmopoliteForm_Load(this, new EventArgs());
        }

        // Create Method for cosmopoliteForm Click
        private void cosmopoliteForm_Click(object sender, EventArgs e)
        {
            // Copy trimmed cosmopoliteText Text to clipboard
            Clipboard.SetText(cosmopoliteText.Text.Trim());
        }
    }
}
