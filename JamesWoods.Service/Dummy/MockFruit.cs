using JamesWoods.Domain.Lab;
using System;
using System.Collections.Generic;

namespace JamesWoods.Service.Dummy
{
    public static class MockFruit
    {
        // Fruits

        public static List<Fruit> AllFruits
        {
            get
            {
                DateTime startDate = DateTime.Parse("2016-05-09");

                return new List<Fruit> {
                    new Fruit { Id=1, Name = "Banan", BestBefore = startDate.AddDays(2), TasteGood = true },
                    new Fruit { Id=2, Name = "Äpple", BestBefore = startDate.AddDays(3), TasteGood = false },
                    new Fruit { Id=3, Name = "Päron", BestBefore = startDate.AddDays(20), TasteGood = true },
                };
            }
        }
    }
}
