using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;
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
using static B20_Ex01_Eldar_313371833_Idan_313116543.WelcomeForm;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class ChooseGroupForm : Form
    {
        User m_LoggedInUser;
        FormName m_FormName;
        Group m_Group;
        public ChooseGroupForm(User LoggedInUser ,FormName formName)
        {
            m_LoggedInUser = LoggedInUser;
            m_FormName = formName;
            InitializeComponent();
            foreach(Group group in m_LoggedInUser.Groups)
            {
                userGroups.Items.Add(group.Name);
            }
        }

        private void userGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = userGroups.SelectedItem.ToString();
            foreach (Group group in m_LoggedInUser.Groups)
            {
                if(group.Name == currentItem)
                {
                    m_Group = group;
                }
            }

        }

        private void checkGroupPopularity_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterOptionsForm filterOptionsForm = new FilterOptionsForm(m_LoggedInUser,m_Group,FormName.findStalker);
            filterOptionsForm.ShowDialog();
        }
    }
}
