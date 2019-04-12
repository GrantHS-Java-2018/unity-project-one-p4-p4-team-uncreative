using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDecks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    /*chance[0]: Move piece to position 24
      chance[1]: Move piece to position 39
      chance[2]: Move piece to position 0
      chance[3]: Move piece to position 5, 15, 25, or 35, whichever is closest (ex. player position 19, 
      it'll subtract 15 from 19 and 19 from 25, 4 is less than 6, piece moves to 15). Split into 5 < currentPos < 15, 
      15 < currentPos < 25, 25 < currentPos < 35, 35 < currentPos || currentPos < 5
      chance[4]: Keep card; remove from picking, can use to get out of jail
      chance[5]: Move piece to position 12 or 28, whichever is closest (ex. player position 19, subtract 12 from 19 and
      19 from 28, 7 is less than 9, piece moves to 12) Split into 12 < currentPos < 28, 28 < currentPos || currentPos < 12
      chance[6]: same as chance[3].
      chance[7]: move piece to position (currentPos - 3).
      chance[8]: currentMoney = (currentMoney - (50 * (numOfPlayers - 1)). currentMoney[Px] = (currentMoney[Px] + 50).
      chance[9]: if currentPos <= 39, currentMoney = (currentMoney + 200). move piece to position 5.
      chance[10]: currentMoney = (currentMoney - ((25*House) + (100*Hotel))
      chance[11]: currentMoney = (currentMoney + 50)
      chance[12]: currentMoney = (currentMoney + 150)
      chance[13]: currentMoney = (currentMoney - 15)
      chance[14]: Move piece to position 11
      chance[15]: Move piece to position 10. inJail = true.
      
      cChest[0]: currentMoney = (currentMoney + 25)
      cChest[1]: Move piece to position 10. inJail = true.
      cChest[2]: currentMoney = (currentMoney - 50)
      cChest[3]: currentMoney = (currentMoney + 10)
      cChest[4]: currentMoney = (currentMoney + 20)
      cChest[5]: Keep card; remove from picking, can use to get out of jail
      cChest[6]: currentMoney = (currentMoney - ((40*House) + (115*Hotel))
      cChest[7]: currentMoney = (currentMoney + 100)
      cChest[8]: currentMoney[Px] = (currentMoney - 50). currentMoney = (currentMoney + (50 * (numOfPlayers - 1)).
      cChest[9]: currentMoney = (currentMoney + 200)
      cChest[10]: move piece to position 0. currentMoney = (currentMoney + 200)
      cChest[11]: currentMoney = (currentMoney - 100)
      cChest[12]: same as cChest[7].
      cChest[13]: currentMoney = (currentMoney + 150)
      cChest[14]: currentMoney = (currentMoney + 45)
      cChest[15]: same as cChest[7] and cChest[12].
     
     */