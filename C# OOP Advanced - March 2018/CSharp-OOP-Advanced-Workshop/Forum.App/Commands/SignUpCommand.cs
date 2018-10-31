namespace Forum.App.Commands
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SignUpCommand : ICommand
    {
        private const string loginError = "Invalid login!";

        private IUserService userService;
        private IMenuFactory menuFactory;

        public SignUpCommand(IUserService userService, IMenuFactory menuFactory)
        {
            this.userService = userService;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string username = args[0];
            string password = args[1];

            bool succes = this.userService.TrySignUpUser(username, password);

            if (!succes)
            {
                throw new InvalidOperationException(loginError);
            }

            return this.menuFactory.CreateMenu("MainMenu");
        }
    }
}
