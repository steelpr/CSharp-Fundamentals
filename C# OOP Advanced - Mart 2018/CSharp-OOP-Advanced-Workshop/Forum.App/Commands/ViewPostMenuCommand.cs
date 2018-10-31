namespace Forum.App.Commands
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ViewPostMenuCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public ViewPostMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            int categotyId = int.Parse(args[0]);

            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IIdHoldingMenu menu = (IIdHoldingMenu)this.menuFactory.CreateMenu(menuName);
            menu.SetId(categotyId);

            return menu;
        }
    }
}
