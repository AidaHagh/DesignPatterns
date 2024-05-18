using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex
{
    public class Menu : IMenuComponent
    {
        private readonly IList<IMenuComponent> menuComponents = new List<IMenuComponent>();

        private readonly string description;

        private readonly string name;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Description
        {
            get
            {
                return description;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Add(IMenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public void Remove(IMenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public IMenuComponent GetChild(int index)
        {
            return menuComponents[index];
        }

        public string GetMenuComponentsInfo()
        {
            return name + "\t" + description;
        }

        public string Show()
        {
           string menuDisplay=GetMenuComponentsInfo();
            for (int i = 0; i < menuComponents.Count; i++)
            {
                IMenuComponent menuComponent = menuComponents[i];
                menuDisplay += "\n" + menuComponent.Show();
            }
            return menuDisplay;
        }
    }
}