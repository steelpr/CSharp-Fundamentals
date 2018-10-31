namespace Forum.App.Contracts.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CategoryInfoViewModel : ICategoryInfoViewModel, IPostInfoViewModel
    {
        public CategoryInfoViewModel(int id, string name, int postCount)
        {
            this.Id = id;
            this.Name = name;
            this.PostCount = postCount;
        }

        public CategoryInfoViewModel(string title, int replyCount)
        {
            this.Title = title;
            this.ReplyCount = replyCount;
        }

        public int Id { get; }

        public string Name { get; }

        public int PostCount { get; }

        public string Title { get; }

        public int ReplyCount { get; }
    }
}
