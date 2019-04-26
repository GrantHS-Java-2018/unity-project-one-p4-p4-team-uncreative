using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericProperty : Property
{
   public PropColor color;

   public enum PropColor
   {
      Brown,
      SkyBlue,
      Magenta,
      Orange,
      Red,
      Yellow,
      Green,
      DarkBlue
   }
}
