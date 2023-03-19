using System;

namespace Pizzas
{
    public interface Pizza
    {
        public void createPizza();
        public string[] ing();
    }

    public class PizzaCarbonara : Pizza
    {
        public string [] ingredients;
        public void createPizza()
        {
            ingredients = new string[6];
            ingredients[0] = "Моцарелла";
            ingredients[1] = "Пармезан";
            ingredients[2] = "Бекон";
            ingredients[3] = "Яйца";
            ingredients[4] = "Томатный соус";
            ingredients[5] = "Травы";
        }
        public string[] ing()
        {
            return ingredients;
        }
    }

    public class MeatPizza : Pizza
    {
        public string[] ingredients;
        public void createPizza()
        {
            ingredients = new string[6];
            ingredients[0] = "Салями";
            ingredients[1] = "Ветчина";
            ingredients[2] = "Помидоры";
            ingredients[3] = "Пармизан";
            ingredients[4] = "Шинка";
            ingredients[5] = "Вырезка";
        }
        public string[] ing()
        {
            return ingredients;
        }
    }

    public class PizzaMargarita : Pizza
    {
        public string[] ingredients;
        public void createPizza()
        {
            ingredients = new string[3];
            ingredients[0] = "Моцарелла";
            ingredients[1] = "Помидоры";
            ingredients[2] = "Салями";
        }
        public string[] ing()
        {
            return ingredients;
        }
    }
}
