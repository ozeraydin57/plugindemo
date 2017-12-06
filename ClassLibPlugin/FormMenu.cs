using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Entities;

namespace ClassLibPlugin
{
    public class FormMenu
    {
        private List<EntMenu> Menu = new EntMenu().GetMenu();

        public void AddMenu(MenuStrip mnRoot)
        {
            var hrMenu = GetHrMenu(mnRoot);
            if (hrMenu == null)
            {
                ToolStripMenuItem menuRoot = new ToolStripMenuItem() { Text = "Human Resources", Name = "mnHumanResources" };
                mnRoot.Items.Add(menuRoot);

                hrMenu = GetHrMenu(mnRoot);
                foreach (var item in Menu)
                {
                    hrMenu.DropDownItems.Add(new ToolStripMenuItem() { Text = item.MenuTitle });
                }
            }

        }

        private ToolStripMenuItem GetHrMenu(MenuStrip mnRoot)
        {
            return mnRoot.Items.Find("mnHumanResources", false).FirstOrDefault() as ToolStripMenuItem;
        }


    }
}
