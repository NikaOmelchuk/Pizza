using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzas
{
    public abstract class Zakaz
    {
        public int numZakaz;
        public abstract Pizza createZakaz();
    }

    public class ZakazPizzaCarbonara : Zakaz
    {
        public override Pizza createZakaz()
        {
            numZakaz = 1;
            PizzaCarbonara pc = new PizzaCarbonara();
            pc.createPizza();
            return pc;
        }
    }

    public class ZakazMeatPizza : Zakaz
    {
        public override Pizza createZakaz()
        {
            numZakaz = 2;
            MeatPizza pm = new MeatPizza();
            pm.createPizza();
            return pm;
        }
    }

    public class ZakazPizzaMargarita : Zakaz
    {
        public override Pizza createZakaz()
        {
            numZakaz = 3;
            PizzaMargarita pm = new PizzaMargarita();
            pm.createPizza();
            return pm;
        }
    }
}
