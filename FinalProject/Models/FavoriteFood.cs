namespace FinalProject.Models
{
    public class FavoriteFood
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string MealOfDay { get; set; }
        public int Calories { get; set; }
        public bool IsVegetarian { get; set; }
    }
}