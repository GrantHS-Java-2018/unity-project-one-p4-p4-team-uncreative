using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
        // Auto-implemented properties.
        public int rent { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int cost { get; set; }
        public int position { get; set; }

        public GameTile()
        {
        }

        public GameTile(string name)
        {
                this.Name = name;
        }
}

public class Board
{
        GameTile brownOne = new GameTile { rent = 2, Name = "Mediterranean Avenue", Color = "brown", cost = 60, position = 1};
        GameTile brownTwo = new GameTile {rent = 4, Name = "Baltic Avenue", Color = "brown", cost = 60, position = 3};
        GameTile railroadOne = new GameTile {rent = 25, name = "Reading Railroad", Color = "black", cost = 200, position = 5};
        GameTile skyBlueOne = new GameTile {rent = 6, Name = "Oriental Avenue", Color = "sky blue", cost = 100, position = 6};
        GameTile skyBlueTwo = new GameTile {rent = 6, name = "Vermont Avenue", Color = "sky blue", cost = 100, position = 8};
        GameTile skyBlueThree = new GameTile {rent = 8, name = "Connecticut Avenue", Color = "sky blue", cost = 120, position = 9};
        GameTile magentaOne = new GameTile {rent = 10, name = "St. Charles Place", Color = "magenta", cost = 140, position = 11};
        GameTile magentaTwo = new GameTile {rent = 10, name = "States Avenue", Color = "magenta", cost = 140, position = 13};
        GameTile magentaThree = new GameTile {rent = 12, name = "Virginia Avenue", Color = "magenta", cost = 160, position = 14};
        GameTile railroadTwo = new GameTile {rent = 25, name = "Pennsylvania Railroad", Color = "black", cost = 200, position = 15};
        GameTile orangeOne = new GameTile {rent = 14, name = "St. James Place", Color = "orange", cost = 180, position = 16};
        GameTile orangeTwo = new GameTile {rent = 14, name = "Tennessee Avenue", Color = "orange", cost = 180, position = 18};
        GameTile orangeThree = new GameTile {rent = 16, name = "New York Avenue", Color = "orange", cost = 200, position = 19};
        GameTile redOne = new GameTile {rent = 18, name = "Kentucky Avenue", Color = "red", cost = 220, position = 21};
        GameTile redTwo = new GameTile {rent = 18, name = "Indiana Avenue", Color = "red", cost = 220, position = 23};
        GameTile redThree = new GameTile {rent = 20, name = "Illinois Avenue", Color = "red", cost = 240, position = 24};
        GameTile railroadThree = new GameTile {rent = 25, name = "B. & O. Railroad", Color = "black", cost = 200, position = 25};
        GameTile yellowOne = new GameTile {rent = 22, name = "Atlantic Avenue", Color = "yellow", cost = 260, position = 26};
        GameTile yellowTwo = new GameTile {rent = 22, name = "Ventnor Avenue", Color = "yellow", cost = 260, position = 27};
        GameTile yellowThree = new GameTile {rent = 24, name = "Marvin Gardens", Color = "yellow", cost = 280, position = 29};
        GameTile greenOne = new GameTile {rent = 26, name = "Pacific Avenue", Color = "green", cost = 300, position = 31};
        GameTile greenTwo = new GameTile {rent = 26, name = "North Carolina Avenue", Color = "green", cost = 300, position = 32};
        GameTile greenThree = new GameTile {rent = 28, name = "Pennsylvania Avenue", Color = "green", cost = 300, position = 34};
        GameTile railroadFour = new GameTile {rent = 25, name = "Short Line", Color = "black", cost = 200, position = 35};
        GameTile blueOne = new GameTile {rent = 35, name = "Park Place", Color = "blue", cost = 350, position = 37};
        GameTile blueTwo = new GameTile {rent = 50, name = "Boardwalk", Color = "blue", cost = 400, position = 39};
        
}