﻿using System;
namespace Food_Menu.Models
{
	public class Dish
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public float Price { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }
    }
}

