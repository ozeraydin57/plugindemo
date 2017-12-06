using System.Collections.Generic;

namespace Entities
{
    public class EntMenu
    {
        public List<EntMenu> GetMenu()
        {
            List<EntMenu> menu = new List<EntMenu>();
            menu.Add(new EntMenu { ActionName = "", Menu = null, ControllerName = "", MenuTitle = "Emploies" });
            menu.Add(new EntMenu { ActionName = "", Menu = null, ControllerName = "", MenuTitle = "Recruitment" });
            return menu;
        }
        public string MenuTitle { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public List<string> Menu { get; set; }
    }
}
