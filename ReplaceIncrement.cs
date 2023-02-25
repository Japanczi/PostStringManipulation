using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace WindowsFormsProject1
{
    public partial class Main : Form
    {
        private const string regexSeparator = ",?";
        private string regexPattern;
        private string inputText;
        private int startOn;
        private int incrementValue;
        private int repeatValue;


        public Main()
        {
            InitializeComponent();
            SetDefaultValuesToComponents();
            SetDefaultValuesToVariables();
        }

        private void SetDefaultValuesToVariables()
        {
            if (!int.TryParse(StartOnBox.Text, out startOn))
                return;

            if (!int.TryParse(IncrementBox.Text, out incrementValue))
                return;

            if (!int.TryParse(RepeatAmountBox.Text, out repeatValue))
                return;
        }

        private void SetDefaultValuesToComponents()
        {
            InputBox.Text = "[{fooId=\"202302,202301,202212,202211\"}, {barId=\"2YZ132,3Z4Y23\"}]";
            RegexPatternBox.Text = @"(\d{4}\d{2})";
            StartOnBox.Text = "6";
            IncrementBox.Text = "1";
            RepeatAmountBox.Text = "5";
            FinalValueOfRepetitionsBoxController.UpdateValue(this);

            postStringInput.Text = "how=43&todo=&something=lol&test34=";
        }

        private void ReplaceTextWithPattern(string input, string pattern)
        {
            Regex rx = new Regex(pattern + regexSeparator);
            MatchCollection matchCollection = rx.Matches(input);
            if (matchCollection.Count == 0)
                return;

            int firstMatchIndex = matchCollection[0].Index;
            input = RemoveMatchedStringFromInput(input, matchCollection);

            RegexResultWindow.Text = BuildFinalString(input, firstMatchIndex);
        }

        private string BuildFinalString(string input, int firstMatchIndex)
        {
            int incrementChange = startOn;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < repeatValue; i++)
            {
                string stringToAppend = $"${{yyyy, -{incrementChange}, M}}";
                sb.Append(stringToAppend);

                if (i < repeatValue - 1)
                    sb.Append(",");

                incrementChange += incrementValue;
            }

            return input.Insert(firstMatchIndex, sb.ToString());
        }

        private static string RemoveMatchedStringFromInput(string temporaryText, MatchCollection matchCollection)
        {
            foreach (Match currentMatch in matchCollection)
            {
                temporaryText = Regex.Replace(temporaryText, currentMatch.Value, string.Empty);
            }

            return temporaryText;
        }

        private void RegexExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputText = InputBox.Text;
                regexPattern = RegexPatternBox.Text;
                ReplaceTextWithPattern(inputText, regexPattern);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void DataTokenManipulatorVisibilitySwitchMethod(object sender, EventArgs e)
        {
            postStringSeparatorMain.Visible = false;
            DateTokenManipulatorGroup.Visible = true;
            DateTokenManipulatorSwitch.Text = "Date Token Manipulator";
        }

        private void StartOnBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(StartOnBox.Text, out startOn))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);
        }

        private void IncrementBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(IncrementBox.Text, out incrementValue))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);
        }

        private void RepeatAmountBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(RepeatAmountBox.Text, out repeatValue))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void postStringSeparator_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void postStringVisibilitySwitchMethod(object sender, EventArgs e)
        {
            DateTokenManipulatorGroup.Visible = false;
            postStringSeparatorMain.Visible = true;
            postStringVisibilitySwitch.Text = "Post String Separator";

        }

        private void GenerateFieldsButton_Click(object sender, EventArgs e)
        {
            postStringSeparatorGroup.Controls.Clear();
            Boxbuilder.Reset();

            string inputDecoded = WebUtility.HtmlDecode(postStringInput.Text);

            MatchCollection matchCollection = Regex.Matches(inputDecoded, @"[a-zA-Z0-9=\[\]\{\},;:]+");
            if (matchCollection.Count == 0)
            {
                postStringOutput.Text = "Invalid input.";
                return;
            }
            foreach (Match match in matchCollection)
            {
                MatchCollection secondaryMatchCollection = Regex.Matches(match.Value, @"([a-zA-Z0-9=\[\]\{\},;:]+)=(.*)?");
                foreach (Match secondaryMatch in secondaryMatchCollection)
                {
                    List<TextBox> textBoxes = Boxbuilder.BuildCoupledTextBoxes(
                        postStringSeparatorGroup, 10, 5, Boxbuilder.Positioning.Horizontal,
                        secondaryMatch.Groups[1].Value,
                        secondaryMatch.Groups[2].Value);
                    
                    if (textBoxes != null)
                    {
                        foreach (TextBox textBox in textBoxes)
                            postStringSeparatorGroup.Controls.Add(textBox);
                    }
                }
            }

        }

        private void FieldsToOutputButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < postStringSeparatorGroup.Controls.Count; i++)
            {
                sb.Append(postStringSeparatorGroup.Controls[i].Text);
                if (i % 2 == 0)
                    sb.Append("=");

                if (i % 2 == 1 && i < postStringSeparatorGroup.Controls.Count - 1)
                    sb.Append("&");
                
            }

            postStringOutput.Text = sb.ToString();
        }
    }
}
