using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;
using static B20_Ex01_Eldar_313371833_Idan_313116543.WelcomeForm;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    public partial class FilterOptionsForm : Form
    {
        public User m_LoggedInUser;
        public FormName m_FormName;
        public List<AgeRange> m_PreferredAgeRanges;
        public List<string> m_PreferredGenders;
        public Group m_Group;
        public FilterOptionsForm(User i_LoggedInUser,Group group,FormName formName)
        {
            m_Group = group;
            m_FormName = formName;
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            switch (m_FormName)
            {
                case FormName.findStalker:
                    {
                        chosenParamaters();
                        FoundSoulmateForm foundSoulmateForm = new FoundSoulmateForm(m_LoggedInUser, m_PreferredGenders, m_PreferredAgeRanges);
                        this.Hide();
                        foundSoulmateForm.ShowDialog();
                        break;
                    }
                case FormName.groupPopularity:
                    {
                        chosenParamaters();
                        GroupPopularityForm foundSoulmateForm = new GroupPopularityForm(m_Group, m_PreferredGenders, m_PreferredAgeRanges);
                        this.Hide();
                        foundSoulmateForm.ShowDialog();
                        break;
                    }
                default:
                    break;

            }
            
        }
        
        private void chosenParamaters()
        {
            if (!FilterOptionsFormLogic.CheckBoxesValidation(preferredGenderCheckList) || !FilterOptionsFormLogic.CheckBoxesValidation(preferredAgesCheckList))
            {
                MessageBox.Show("You must check at least one item from each checkbox list");
                return;
            }
            // sends checklist box of age ranges and gets a list of the ranges
            m_PreferredAgeRanges = FilterOptionsFormLogic.GetAgeRanges(preferredAgesCheckList);
            m_PreferredGenders = FilterOptionsFormLogic.GetGenders(preferredGenderCheckList);
                    

        }
    }
}
