﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Arena_Basic
{
    public partial class FmCAS : FmMain
    {




        public String PlayerClass;
        public String Enemy;
    
       


        public FmCAS()
        {
            InitializeComponent();
        }

        void dbg() //Player class Debug Constructor
        {
            Console.WriteLine("You have selected the " + PlayerClass, " Class.");
        }

        void EnemyStats()
        {
           

        }

    public String PlayerName;

        private void lblCASWarrior_Click(object sender, EventArgs e)
        {
            PlayerClass = "Warrior";
            dbg();
        }

        private void lblCASArcher_Click(object sender, EventArgs e)
        {
            PlayerClass = "Archer";
            dbg();
        }

        private void btnCASset_Click(object sender, EventArgs e)
        {
            PlayerName = txtName.Text;
            Console.WriteLine("Ahh!");
            Console.WriteLine("Welcome " + PlayerName + "!");
            Console.WriteLine("When you are ready... Select a class and an enemy and click start to begin!");
        }



        private void lbxCASenemy_SelectedValueChanged(object sender, EventArgs e)
        {
            EnemybaseModifiers es = new EnemybaseModifiers();
            Enemy = lbxCASenemy.Text;
            Console.WriteLine("Ahh! " + Enemy + " A worthy opponent i'm sure!");
            es.EnemyStats();

        }

        private void btnCASsave_Click(object sender, EventArgs e)
        {
            XmlWriterSettings PlayerData = new XmlWriterSettings();
            PlayerData.Indent = true;

            XmlWriter writer = XmlWriter.Create("PlayerData.xml", PlayerData);
            writer.WriteStartDocument();
            writer.WriteComment("This file is generated by your selections on the Create A Player Screen. These are your Default Modifiers.");
            writer.WriteStartElement("Info");
            writer.WriteAttributeString("Name", PlayerName);
            writer.WriteAttributeString("Class", PlayerClass);
            writer.WriteAttributeString("Enemy", Enemy);


           
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

            XmlReader reader = XmlReader.Create("PlayerData.xml");
            Console.WriteLine("Saving...");
            //reader.GetAttribute(0
            // Console.WriteLine(reader.GetAttribute(1));
            //Console.WriteLine(reader.GetAttribute(2));
            //  Console.WriteLine(File.ReadAllLines

            FmMain MainInstance = new FmMain();
            this.Enabled = false;
        }
      

    
    }
}
 
