using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAVA_FINALTERM_ACTIVITY3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        private bool ValidateAllInputs()
        {
            if (IsEmpty(budtxt.Text))
            { ShowError("Budget cannot be empty.", budtxt); return false; }

            if (IsEmpty(costtxt.Text))
            { ShowError("Estimated Cost cannot be empty.", costtxt); return false; }

            if (IsEmpty(Importtxt.Text))
            { ShowError("Importance Level cannot be empty.", Importtxt); return false; }

            if (cmbUrgency.SelectedIndex == -1)
            { ShowError("Please select an Urgency Level.", cmbUrgency); return false; }

            if (cmbRisk.SelectedIndex == -1)
            { ShowError("Please select a Risk Level.", cmbRisk); return false; }

            if (!IsNumeric(budtxt.Text))
            { ShowError("Budget must be a valid number.", budtxt); return false; }

            if (!IsNumeric(costtxt.Text))
            { ShowError("Estimated Cost must be a valid number.", costtxt); return false; }

            if (!IsNumeric(Importtxt.Text))
            { ShowError("Importance Level must be a number (1–10).", Importtxt); return false; }

            int importance = int.Parse(Importtxt.Text);
            if (importance < 1 || importance > 10)
            { ShowError("Importance Level must be between 1 and 10.", Importtxt); return false; }

            if (double.Parse(budtxt.Text) <= 0)
            { ShowError("Budget must be greater than zero.", budtxt); return false; }

            if (double.Parse(costtxt.Text) <= 0)
            { ShowError("Estimated Cost must be greater than zero.", costtxt); return false; }

            return true;
        }

        private void ShowError(string message, Control focusTarget)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTarget.Focus();
        }

        private string CheckAffordability(double budget, double cost)
        {
            double ratio = cost / budget;

            if (ratio <= 0.75) return "Affordable";
            else if (ratio <= 1.0) return "Not Affordable";
            else return "Critical";
        }

        private int ComputePriority(int importance, string urgency)
        {
            int urgencyWeight;
            switch (urgency)
            {
                case "High": urgencyWeight = 10; break;
                case "Medium": urgencyWeight = 5; break;
                default: urgencyWeight = 2; break; // Low
            }

            // Importance = 60%, Urgency = 40% of total score
            int score = (importance * 6) + (urgencyWeight * 4);
            return Math.Min(score, 100);
        }

        private string EvaluateRisk(string riskLevel)
        {
            switch (riskLevel)
            {
                case "Low": return "Safe";
                case "Medium": return "Moderate";
                case "High": return "High Risk";
                default: return "Unknown";
            }
        }

        private string GenerateDecision(string affordability, int priorityScore, string riskEvaluation)
        {
            // Rule 1: Cost exceeds budget entirely
            if (affordability == "Critical")
                return "Not Recommended";

            // Rule 2: High risk blocks immediate action
            if (riskEvaluation == "High Risk")
                return "Delay Decision";

            // Rule 3: All green lights
            if (affordability == "Affordable" && riskEvaluation == "Safe" && priorityScore >= 70)
                return "Proceed Immediately";

            // Rule 4: Affordable but not peak conditions
            if (affordability == "Affordable" && priorityScore >= 40)
                return "Proceed with Caution";

            // Rule 5: Budget is borderline
            if (affordability == "Not Affordable")
                return "Delay Decision";

            return "Proceed with Caution";
        }
        private string GenerateExplanation(string affordability, int priorityScore,
                                   string riskEvaluation, string decision)
        {
            string a, p, r, c;

            switch (affordability)
            {
                case "Affordable":
                    a = "Budget comfortably covers the cost."; break;
                case "Not Affordable":
                    a = "Cost is close to or slightly over budget."; break;
                default:
                    a = "Cost greatly exceeds budget — financially dangerous."; break;
            }

            p = priorityScore >= 70 ? "HIGH priority (Score: " + priorityScore + "/100)." :
                priorityScore >= 40 ? "MODERATE priority (Score: " + priorityScore + "/100)." :
                                      "LOW priority (Score: " + priorityScore + "/100).";

            switch (riskEvaluation)
            {
                case "Safe": r = "Risk is low."; break;
                case "Moderate": r = "Moderate risk — proceed with care."; break;
                default: r = "High risk detected — consider waiting."; break;
            }
            switch (decision)
            {
                case "Proceed Immediately":
                    c = "All indicators are favorable."; break;
                case "Proceed with Caution":
                    c = "Acceptable, but monitor finances and risk."; break;
                case "Delay Decision":
                    c = "Wait until conditions improve."; break;
                default:
                    c = "Not advisable at this time."; break;
            }
            return a + " " + p + " " + r + " " + c;
        }

        private void DisplayResult(string affordability, int priorityScore,
                           string riskEvaluation, string decision, string explanation)
        {
            lblAffordabilityResult.Text = affordability;
            lblPriorityResult.Text = priorityScore + " / 100";
            lblRiskResult.Text = riskEvaluation;
            lblDecisionResult.Text = decision;
            lblExplanationResult.Text = explanation;

            // Color: Affordability
            switch (affordability)
            {
                case "Affordable": lblAffordabilityResult.ForeColor = Color.FromArgb(0, 130, 60); break;
                case "Not Affordable": lblAffordabilityResult.ForeColor = Color.FromArgb(200, 130, 0); break;
                case "Critical": lblAffordabilityResult.ForeColor = Color.FromArgb(190, 30, 30); break;
            }
            // Color: Risk
            switch (riskEvaluation)
            {
                case "Safe": lblRiskResult.ForeColor = Color.FromArgb(0, 130, 60); break;
                case "Moderate": lblRiskResult.ForeColor = Color.FromArgb(200, 130, 0); break;
                case "High Risk": lblRiskResult.ForeColor = Color.FromArgb(190, 30, 30); break;
            }
            // Color: Decision
            switch (decision)
            {
                case "Proceed Immediately": lblDecisionResult.ForeColor = Color.FromArgb(0, 130, 60); break;
                case "Proceed with Caution": lblDecisionResult.ForeColor = Color.FromArgb(200, 130, 0); break;
                case "Delay Decision": lblDecisionResult.ForeColor = Color.FromArgb(160, 80, 0); break;
                case "Not Recommended": lblDecisionResult.ForeColor = Color.FromArgb(190, 30, 30); break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            budtxt.Clear();
            costtxt.Clear();
            cmbUrgency.SelectedIndex = -1;
            Importtxt.Clear();
            cmbRisk.SelectedIndex = -1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!ValidateAllInputs()) return;

            double budget = double.Parse(budtxt.Text);
            double cost = double.Parse(costtxt.Text);
            int importance = int.Parse(Importtxt.Text);
            string urgency = cmbUrgency.SelectedItem.ToString();
            string risk = cmbRisk.SelectedItem.ToString();

            string affordability = CheckAffordability(budget, cost);
            int priorityScore = ComputePriority(importance, urgency);
            string riskEvaluation = EvaluateRisk(risk);
            string decision = GenerateDecision(affordability, priorityScore, riskEvaluation);
            string explanation = GenerateExplanation(affordability, priorityScore, riskEvaluation, decision);

            DisplayResult(affordability, priorityScore, riskEvaluation, decision, explanation);

        }
    }
}

