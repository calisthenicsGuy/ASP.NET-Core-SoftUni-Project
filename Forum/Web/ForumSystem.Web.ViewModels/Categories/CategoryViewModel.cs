﻿namespace ForumSystem.Web.ViewModels.Categories
{
    using ForumSystem.Data.Models;
    using ForumSystem.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int PostsCount { get; set; }
    }
}
