    
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace TileScripts
{
    [Serializable]
    public abstract class Tile //Large class that holds all types of tiles (properties, card draws, jail, literally everything)
    {
        [FormerlySerializedAs("TileName")] public String tileName;
        protected Vector3 TilePosition; //position on the board of the tile

        public Vector3 GetTilePosition()
        {
            return TilePosition;
        }

        public abstract void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues);
        public abstract void DoTileAction(); //do whatever the tile action is (go to jail, draw card, buy property, anything)
    }
}