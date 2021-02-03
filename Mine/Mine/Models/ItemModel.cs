using System;
using SQLite;

namespace Mine.Models
{
    //Items for characters and monsters to use
    public class ItemModel
    {
        //The Id for the Item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        //The Display Text for the item
        public string Text { get; set; }
        //The Description for the Item
        public string Description { get; set; }

        //The Value of the Item Damage
        public int Value { get; set; } = 0;
    }
}