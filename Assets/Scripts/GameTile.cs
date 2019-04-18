using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
        // Auto-implemented properties.
        public string Name;
        public string Type;
        public int position;

        public GameTile()
        {
                
        }

        public GameTile(string name)
        {
                this.Name = name;
        }

}