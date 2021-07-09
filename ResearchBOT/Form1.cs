using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ResearchBOT
{
	public partial class Form1 : Form
	{
		string filepath = "";
		string filename = "";
		List<string> lines = new List<string>();
		List<string> allDataPoints = new List<string>();
		List<string> allLocalVariables = new List<string>();
		List<string> allMacros = new List<string>();
		List<string> allFunctions = new List<string>();
		List<string> allProcedures = new List<string>();
		List<string> allMerges = new List<string>();
		List<string> allFrons = new List<string>();
		List<string> allOns = new List<string>();


		HashSet<string> uniqueDataPoints = new HashSet<string>();
		HashSet<string> uniqueLocalVariables = new HashSet<string>();
		HashSet<string> uniqueMacros = new HashSet<string>();
		HashSet<string> uniqueFunctions = new HashSet<string>();
		HashSet<string> uniqueProcedures = new HashSet<string>();
		HashSet<string> uniqueMerges = new HashSet<string>();
		HashSet<string> uniqueFrons = new HashSet<string>();
		HashSet<string> uniqueOns = new HashSet<string>();


		int CurrentLineNumber = 1;
		int dataPointCount = 0;
		int macroCount = 0;
		int functionCount = 0;
		int procedureCount = 0;
		int mergeCount = 0;
		int lvCount = 0;
		int fronsCount = 0;
		int OnsCount = 0;



		public Form1()
		{
			InitializeComponent();
		}

		private void browseBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Title = "SELECT THE FILE TO RESEARCH";
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				filepath = openFile.FileName;
				filename = openFile.SafeFileName;
				selectedFile.Text = openFile.SafeFileName.ToUpper() + " SELECTED";
				selectedFile.ForeColor = Color.FromArgb(64, 64, 64);
				Button btn = (Button)sender;
				btn.Text = "BROWSE AGAIN";
				lines = File.ReadAllLines(filepath, Encoding.UTF8).ToList();
				endRange.Value = lines.Count;
				startResearchBtn.Enabled = true;
				startResearchBtn.BackColor = Color.DarkOliveGreen;
				startResearchBtn.ForeColor = Color.White;
				textResultchkBx.Enabled = true;
				resetRangeBtn.Enabled = true;

			}
		}

		private void startResearchBtn_Click(object sender, EventArgs e)
		{
			if (filepath == null || filepath == "")
			{
				MessageBox.Show("PLEASE SELECT A FILE TO RESEARCH", "ERROR");
			}
			else
			{
				startResearchBtn.BackColor = Color.Gray;
				startResearchBtn.ForeColor = Color.White;
				startResearchBtn.Enabled = false;
				textResultchkBx.Enabled = false;
				resetRangeBtn.Enabled = false;
				resultText.Text = "";
				int startFrom = (int)startRange.Value - 1;
				int endAt = (int)endRange.Value - 1;
				if (startFrom > endAt)
				{
					MessageBox.Show("PLEASE ENTER A VALID RANGE", "INVALID");
				}
				else
				{
					CurrentLineNumber = startFrom + 1;
					if (endAt > lines.Count || endAt == 0)
					{
						endAt = lines.Count();
					}
					for (int i = startFrom; i < endAt; i++)
					{
						findMatch(lines[i], @"\^\(.*?\)[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^MACRO\(.*?\)[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^PROCEDURE\(.*?\)[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^FUNCTION\(.*?[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^MERGE\(.*?[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^FRON\(.*?[^A-Za-z0-9,_\^\(\)]");
						findMatch(lines[i], @"\^ON\(.*?[^A-Za-z0-9,_\^\(\)]");


						CurrentLineNumber++;
					}

					resultText.Text += "\nSUMMARY\n";
					resultText.Text += "************************************************************\n";
					resultText.Text += "TOTAL DATA POINTS : " + dataPointCount + "\n";
					resultText.Text += "TOTAL LOCAL VARIABLES: " + lvCount + "\n";
					resultText.Text += "TOTAL MACROS: " + macroCount + "\n";
					resultText.Text += "TOTAL FUNCTIONS : " + functionCount + "\n";
					resultText.Text += "TOTAL PROCEDURES : " + procedureCount + "\n";
					resultText.Text += "TOTAL MERGES : " + mergeCount + "\n";
					resultText.Text += "TOTAL FRONS : " + fronsCount + "\n";
					resultText.Text += "UNIQUE DATA POINTS: " + uniqueDataPoints.Count + "\n";
					resultText.Text += "UNIQUE LOCAL VARIABLES: " + uniqueLocalVariables.Count + "\n";
					resultText.Text += "UNIQUE MACROS: " + uniqueMacros.Count + "\n";
					resultText.Text += "UNIQUE FUNCTIONS: " + uniqueFunctions.Count + "\n";
					resultText.Text += "UNIQUE PROCEDURES: " + uniqueProcedures.Count + "\n";
					resultText.Text += "UNIQUE MERGES: " + uniqueMerges.Count + "\n";
					resultText.Text += "UNIQUE FRONS: " + uniqueFrons.Count + "\n";
					resultText.Text += "UNIQUE ONS: " + uniqueOns.Count + "\n";


					displayResult("TOTAL DATA POINTS", allDataPoints);
					displayResult("TOTAL LOCAL VARIABLES", allLocalVariables);
					displayResult("MACROS", allMacros);
					displayResult("FUNCTIONS", allFunctions);
					displayResult("PROCEDURES", allProcedures);
					displayResult("MERGES", allMerges);
					displayResult("FRONS", allFrons);
					displayResult("UNIQUE DATA POINTS", uniqueDataPoints.ToList());
					displayResult("UNIQUE LOCAL VARIABLES", uniqueLocalVariables.ToList());
					displayResult("UNIQUE MACROS", uniqueMacros.ToList());
					displayResult("UNIQUE FUNCTIONS", uniqueFunctions.ToList());
					displayResult("UNIQUE PROCEDURES", uniqueProcedures.ToList());
					displayResult("UNIQUE MERGES", uniqueMerges.ToList());
					displayResult("UNIQUE FRONS", uniqueFrons.ToList());
					displayResult("UNIQUE ONS", uniqueOns.ToList());


					MessageBox.Show(filename.ToUpper() + " - " + "RESEARCH COMPLETE", "RESEARCHBOT");

					if (textResultchkBx.Checked)
					{
						try
						{
							string result = "C:/Users/gopala.panchavarnam/Desktop/ResearchBOTResults/";
							if (!Directory.Exists(result))
							{
								Directory.CreateDirectory(result);
							}

							File.WriteAllText(result + filename.ToUpper() + "_" +
								DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".txt", resultText.Text);
							MessageBox.Show("TEXT FILE HAS BEEN GENERATED SUCCESSFULLY IN \n" +
								result.ToUpper(), "SUCCESS!");

						}
						catch (Exception)
						{

							MessageBox.Show("COULD NOT WRITE TO TEXT FILE", "OOPS!");
						}

					}

				}

			}

			reset();
		}

		private void helpBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1. CLICK ON THE BROWSE BUTTON\n\n2. SELECT THE FILE FROM THE OPEN FILE DIALOG BOX\n\n" +
				"3.SELECT THE RANGE TO RESEARCH IN THE SELECTED FILE\n\n4. CHECK RESULT IN TEXT FILE IF YOU NEED A TEXT RESULT\n\n " +
				"5. CLICK ON THE START RESEARCH BUTTON\n\n + 6. RESEARCHBOT PROVIDES YOU WITH THE FOLLOWING DETAILS \n\n\t" +
				"i) TOTAL NUMBER OF DATAPOINTS\n\n\tii) TOTAL NUMBER OF LOCAL VARIABLES\n\n\tiii) TOTAL NUMBER OF MACROS\n\n\t" +
				"iv) TOTAL NUMBER OF FUCTIONS\n\n\tv) TOTAL NUMBER OF PROCEDURES\n\n\tvi) UNIQUE DATAPOINTS\n\n\t" +
				"vii) UNIQUE LOCAL VARIABLES\n", "RESEARCHBOT V1.0");
		}

		private void findMatch(string text, string reg)
		{
			Regex regex = new Regex(reg, RegexOptions.IgnoreCase);
			MatchCollection mc = regex.Matches(text);
			foreach (Match m in mc)
			{
				if (reg.Contains("MACRO"))
				{
					macroCount++;
					allMacros.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueMacros.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}

				else if (reg.Contains("PROCEDURE"))
				{

					procedureCount++;
					allProcedures.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueProcedures.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}

				else if (reg.Contains("MERGE"))
				{

					mergeCount++;
					allMerges.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueMerges.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}

				else if (reg.Contains("FUNCTION"))
				{

					functionCount++;
					allFunctions.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueFunctions.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}
				else if (reg.Contains("FRON"))
				{

					fronsCount++;
					allFrons.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueFrons.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}

				else if (reg.Contains("ON"))
				{

					OnsCount++;
					allOns.Add(CurrentLineNumber + " " + m.Value.Substring(1, m.Value.Length - 2).ToLower());
					uniqueOns.Add(m.Value.Substring(1, m.Value.Length - 2).ToLower());
				}

				else
				{
					if (m.Value.Substring(2, 2).ToLower().Equals("lv"))
					{
						allLocalVariables.Add(CurrentLineNumber + " " + m.Value.Substring(2, m.Value.Length - 4).ToLower());
						uniqueLocalVariables.Add(m.Value.Substring(2, m.Value.Length - 4).ToLower());
						lvCount++;
					}
					else
					{
						allDataPoints.Add(CurrentLineNumber + " " + m.Value.Substring(2, m.Value.Length - 4).ToLower());
						uniqueDataPoints.Add(m.Value.Substring(2, m.Value.Length - 4).ToLower());
						dataPointCount++;
					}
				}
			}
		}

		private void displayResult(string heading, List<string> data)
		{
			if (data.Count != 0)
			{
				resultText.Text += "\n" + heading.ToUpper() + "\n";
				resultText.Text += "************************************************************\n";

				for (int i = 0; i < data.Count; i++)
				{
					resultText.Text += data[i] + "\n";
				}
			}
		}

		private void reset()
		{
			lines.Clear();
			allDataPoints.Clear();
			allLocalVariables.Clear();
			allMacros.Clear();
			allFunctions.Clear();
			allProcedures.Clear();
			allMerges.Clear();
			allFrons.Clear();
			allOns.Clear();

			uniqueDataPoints.Clear();
			uniqueLocalVariables.Clear();
			uniqueMacros.Clear();
			uniqueFunctions.Clear();
			uniqueProcedures.Clear();
			uniqueMerges.Clear();
			uniqueFrons.Clear();
			uniqueOns.Clear();

			CurrentLineNumber = 1;
			dataPointCount = 0;
			lvCount = 0;
			macroCount = 0;
			functionCount = 0;
			procedureCount = 0;
			mergeCount = 0;
			OnsCount = 0;
		}

		private void resetRangeBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(filepath))
			{
				startRange.Value = 1;
				endRange.Value = 1;
			}
			else
			{
				startRange.Value = 1;
				endRange.Value = lines.Count;
			}
		}

		private void aboutBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("DEVELOPED BY\nGOPALAKRISHNAN PV [TEAM SIMBA]", "RESEARCHBOT");
		}
	}
}