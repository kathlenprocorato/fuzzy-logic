using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using DotFuzzy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fuzzy_Logic
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe;
        MembershipFunctionCollection roomTemp, desiredTemp, acOutput;
        LinguisticVariable roomTempLevel, desiredTempLevel, acOutputLevel;
        FuzzyRuleCollection myrules;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desiredtemp.Text = "";
            textBox2.Text = "";
            roomtemp.Text = "33.2";
            acoutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setMembers();
            setRules();
            setFuzzyEngine();
            roomtemp.Text = "33.2";
        }

        public void setMembers()
        {
            roomTemp = new MembershipFunctionCollection();
            roomTemp.Add(new MembershipFunction("VERY_COLD", -10.0, 0.0, 0.0, -5.0));
            roomTemp.Add(new MembershipFunction("COLD", 0.0, 10.0, 10.0, 15.0));
            roomTemp.Add(new MembershipFunction("WARM", 10.0, 20.0, 15.0, 30.0));
            roomTemp.Add(new MembershipFunction("HOT", 20.0, 30.0, 30.0, 40.0));
            roomTemp.Add(new MembershipFunction("VERY_HOT", 30.0, 40.0, 40.0, 50.0));
            roomTempLevel = new LinguisticVariable("ROOM", roomTemp);


            desiredTemp = new MembershipFunctionCollection();
            desiredTemp.Add(new MembershipFunction("VERY_COLD", -10.0, 0.0, 0.0, -5.0));
            desiredTemp.Add(new MembershipFunction("COLD", 0.0, 10.0, 10.0, 15.0));
            desiredTemp.Add(new MembershipFunction("WARM", 10.0, 20.0, 15.0, 30.0));
            desiredTemp.Add(new MembershipFunction("HOT", 20.0, 30.0, 30.0, 40.0));
            desiredTemp.Add(new MembershipFunction("VERY_HOT", 30.0, 40.0, 40.0, 50.0));
            desiredTempLevel = new LinguisticVariable("DESIRED", desiredTemp);

            acOutput = new MembershipFunctionCollection();
            acOutput.Add(new MembershipFunction("COOL", -10.0, -5.0, -5.0, 0.0));
            acOutput.Add(new MembershipFunction("NO_CHANGE", -5.0, 0.0, 0.0, 5.0));
            acOutput.Add(new MembershipFunction("HEAT", 0.0, 5.0, 5.0, 10.0));
            acOutputLevel = new LinguisticVariable("AC_OUTPUT", acOutput);
        }

        public void setRules()
        {
            myrules = new FuzzyRuleCollection();
            //IF ROOM IS COLD
            myrules.Add(new FuzzyRule("IF (ROOM IS COLD) AND (DESIRED IS VERY_COLD) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS COLD) AND (DESIRED IS WARM) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS COLD) AND (DESIRED IS HOT) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS COLD) AND (DESIRED IS VERY_HOT) THEN ACOUTPUT IS HEAT"));
            //IF ROOM IS VERY_COLD
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_COLD) AND (DESIRED IS COLD) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_COLD) AND (DESIRED IS WARM) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_COLD) AND (DESIRED IS HOT) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_COLD) AND (DESIRED IS VERY_HOT) THEN ACOUTPUT IS HEAT"));
            //IF ROOM IS HOT
            myrules.Add(new FuzzyRule("IF (ROOM IS HOT) AND (DESIRED IS VERY_HOT) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS HOT) AND (DESIRED IS WARM) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS HOT) AND (DESIRED IS COLD) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS HOT) AND (DESIRED IS VERY_COLD) THEN ACOUTPUT IS COOL"));
            //IF ROOM IS VERY_HOT
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_HOT) AND (DESIRED IS HOT) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_HOT) AND (DESIRED IS WARM) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_HOT) AND (DESIRED IS COLD) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_HOT) AND (DESIRED IS VERY_COLD) THEN ACOUTPUT IS COOL"));
            //IF ROOM IS WARM
            myrules.Add(new FuzzyRule("IF (ROOM IS WARM) AND (DESIRED IS VERY_COLD) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS WARM) AND (DESIRED IS COLD) THEN ACOUTPUT IS COOL"));
            myrules.Add(new FuzzyRule("IF (ROOM IS WARM) AND (DESIRED IS HOT) THEN ACOUTPUT IS HEAT"));
            myrules.Add(new FuzzyRule("IF (ROOM IS WARM) AND (DESIRED IS VERY_HOT) THEN ACOUTPUT IS HEAT"));
            //NO CHANGE RULES
            myrules.Add(new FuzzyRule("IF (ROOM IS WARM) AND (DESIRED IS WARM) THEN ACOUTPUT IS NO_CHANGE"));
            myrules.Add(new FuzzyRule("IF (ROOM IS COLD) AND (DESIRED IS COLD) THEN ACOUTPUT IS NO_CHANGE"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_COLD) AND (DESIRED IS VERY_COLD) THEN ACOUTPUT IS NO_CHANGE"));
            myrules.Add(new FuzzyRule("IF (ROOM IS VERY_HOT) AND (DESIRED IS VERY_HOT) THEN ACOUTPUT IS NO_CHANGE"));
            myrules.Add(new FuzzyRule("IF (ROOM IS HOT) AND (DESIRED IS HOT) THEN ACOUTPUT IS NO_CHANGE"));

        }

        public void setFuzzyEngine()
        {
            fe = new FuzzyEngine();
            fe.LinguisticVariableCollection.Add(roomTempLevel);
            fe.LinguisticVariableCollection.Add(desiredTempLevel);
            fe.LinguisticVariableCollection.Add(acOutputLevel);
            fe.FuzzyRuleCollection = myrules;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desiredtemp.Text = textBox2.Text;
            fuziffyvalues();
            defuzzy();
            computetemp();

        }

        public void fuziffyvalues()
        {
            roomTempLevel.InputValue = Convert.ToDouble(roomtemp.Text);
            roomTempLevel.Fuzzify("VERY_COLD");

            desiredTempLevel.InputValue = (Convert.ToDouble(textBox2.Text));
            desiredTempLevel.Fuzzify("VERY_COLD");

        }
        public void defuzzy()
        {
            fe.Consequent = "AC_OUTPUT";
            acoutput.Text = "" + fe.Defuzzify();
        }

        public void computetemp()
        {
            double oldtemp = Convert.ToDouble(roomtemp.Text);
            double oldacoutput = Convert.ToDouble(acoutput.Text);
            double newtemp = oldtemp + oldacoutput;
            roomtemp.Text = newtemp.ToString(); ;

        }
    }
}
