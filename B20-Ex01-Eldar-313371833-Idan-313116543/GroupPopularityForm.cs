using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
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

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class GroupPopularityForm : Form
    {
        Group m_Group;
        List<string> m_PreferredGenders;
        List<AgeRange> m_PreferredAges;
        int m_MemberCount;
        public GroupPopularityForm(Group i_Group, List<string> i_PreferredGenders, List<AgeRange> i_PreferredAges)
        {
            m_Group = i_Group;
            m_PreferredGenders = i_PreferredGenders;
            m_PreferredAges = i_PreferredAges;
            m_MemberCount = FoundSoulmateFormLogic.numberOfMembersInGroup(m_Group, m_PreferredGenders, m_PreferredAges);
            InitializeComponent();
            int lowestAge = i_PreferredAges[0].LowestAge;
            int highestAge = i_PreferredAges[0].HighestAge;
            foreach(AgeRange ageRange in i_PreferredAges)
            {
                if(highestAge>ageRange.HighestAge)
                {
                    highestAge = ageRange.HighestAge;
                }
                if (lowestAge < ageRange.LowestAge)
                {
                    lowestAge = ageRange.LowestAge;
                }
            }
            header.Text = string.Format("the number of members with the gender {0} and between the ages {1} - {2} in the group is:", string.Join(",", m_PreferredGenders),lowestAge,highestAge);
            memberCount.Text = string.Format("{0}",m_MemberCount);
        }
    }
}
