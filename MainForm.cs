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

namespace PostStringManipulation
{
    public partial class Main : Form
    {
        private string regexPattern;
        private string inputText;
        private int patternNo;

        public Main()
        {
            InitializeComponent();
            SetDefaultValuesToComponents();
            SetDefaultValuesToVariables();
        }

        private void SetDefaultValuesToVariables()
        {
            if (!int.TryParse(StartOnBox.Text, out StringHelpers.startOn))
                return;

            if (!int.TryParse(IncrementBox.Text, out StringHelpers.incrementValue))
                return;

            if (!int.TryParse(RepeatAmountBox.Text, out StringHelpers.repeatValue))
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
        }


        private void RegexExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputText = InputBox.Text;
                regexPattern = RegexPatternBox.Text;
                RegexResultWindow.Text = StringHelpers.ReplaceTextWithPattern(inputText, regexPattern);
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
            if (!int.TryParse(StartOnBox.Text, out StringHelpers.startOn))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);
        }

        private void IncrementBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(IncrementBox.Text, out StringHelpers.incrementValue))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);
        }

        private void RepeatAmountBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(RepeatAmountBox.Text, out StringHelpers.repeatValue))
                return;

            FinalValueOfRepetitionsBoxController.UpdateValue(this);
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

            if (!inputDecoded.StartsWith("["))
            {
                MatchFirstPattern(inputDecoded);
                patternNo = 1;
            }
            else
            {
                patternNo = 2;
                MatchSecondPattern(inputDecoded);
            }
        }

        private void MatchSecondPattern(string inputDecoded)
        {
            MatchCollection primaryMatchCollection = Regex.Matches(inputDecoded, "(?:\\[)?(?:{)?((.*?)=\"(.*?)\"})+?(?:,\\s)?(?:})?(?:\\])?");
            foreach (Match primaryMatch in primaryMatchCollection)
            {
                List<TextBox> textBoxes = Boxbuilder.BuildCoupledTextBoxes(
                    postStringSeparatorGroup, 10, 5, Boxbuilder.Positioning.Horizontal,
                    primaryMatch.Groups[2].Value,
                    primaryMatch.Groups[3].Value);

                if (textBoxes != null)
                {
                    foreach (TextBox textBox in textBoxes)
                        postStringSeparatorGroup.Controls.Add(textBox);
                }
            }
        }

        private void MatchFirstPattern(string inputDecoded)
        {
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

            if (patternNo == 1)
            {
                for (int i = 0; i < postStringSeparatorGroup.Controls.Count; i++)
                {
                    sb.Append(postStringSeparatorGroup.Controls[i].Text);
                    if (i % 2 == 0)
                        sb.Append("=");

                    if (i % 2 == 1 && i < postStringSeparatorGroup.Controls.Count - 1)
                        sb.Append("&");

                }
            }

            if (patternNo == 2)
            {
                for (int i = 0; i < postStringSeparatorGroup.Controls.Count; i++)
                {
                    if (i == 0)
                        sb.Append("[{");

                    sb.Append(postStringSeparatorGroup.Controls[i].Text);
                    if (i % 2 == 0)
                        sb.Append("\"=\"");

                    if (i % 2 == 1 && i < postStringSeparatorGroup.Controls.Count - 1)
                        sb.Append("\"}, {\"");

                    if (i == postStringSeparatorGroup.Controls.Count - 1)
                        sb.Append("\"}]");
                }
            }
            postStringOutput.Text = sb.ToString();
        }
    }
}
