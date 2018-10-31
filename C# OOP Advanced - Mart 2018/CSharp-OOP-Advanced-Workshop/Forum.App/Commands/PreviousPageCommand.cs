﻿namespace Forum.App.Commands
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PreviousPageCommand : ICommand
    {
        ISession session;

        public PreviousPageCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            IMenu currentMenu = this.session.CurrentMenu;

            if (currentMenu is IPaginatedMenu paginatedMenu)
            {
                paginatedMenu.ChangePage(false);
            }

            return currentMenu;
        }
    }
}
