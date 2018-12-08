using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRewards : MonoBehaviour {

    public GameObject top;
    public GameObject lockp;
    public GameObject basep;
    public GridTiles tiles;

    public void RandomReward()
    {
        foreach (UnitWeapon w in CurrentGame.game.memoryGeneral.currentLevel.chestPool.weapons)
        {
            SwordLoader.AssignSword(w.name, w);
        }
        foreach (UnitAssessory a in CurrentGame.game.memoryGeneral.currentLevel.chestPool.assessories)
        {
            AssessoryLoader.AssignAssessory(a.name, a);
        }

        int num = Random.Range(0, 3);
        if (num == 0)
        {
            int num1 = Random.Range(0, CurrentGame.game.memoryGeneral.currentLevel.chestPool.weapons.Count);
            int i = 0;
            foreach (UnitWeapon w in CurrentGame.game.memoryGeneral.currentLevel.chestPool.weapons)
            {
                if (i == num1)
                {
                    CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(w);
                    if(!CurrentGame.game.memoryGeneral.shopWares.weapons.Exists(x=> x == w)) CurrentGame.game.memoryGeneral.shopWares.weapons.Add(w);
                    StartCoroutine(Done());
                }
                i++;  
            }
        }
        else if (num == 1)
        {
            int num1 = Random.Range(0, CurrentGame.game.memoryGeneral.currentLevel.chestPool.assessories.Count);
            int i = 0;
            foreach (UnitAssessory a in CurrentGame.game.memoryGeneral.currentLevel.chestPool.assessories)
            {
                if (i == num1)
                {
                    CurrentGame.game.memoryGeneral.itemsOwned.assessories.Add(a);
                    if (!CurrentGame.game.memoryGeneral.shopWares.assessories.Exists(x => x == a)) CurrentGame.game.memoryGeneral.shopWares.assessories.Add(a);
                    StartCoroutine(Done());
                }
                i++;
            }
        }
        else
        {
            CurrentGame.game.memoryGeneral.gold += CurrentGame.game.memoryGeneral.currentLevel.chestPool.gold;
            StartCoroutine(Done());
        }

    }

    IEnumerator Done()
    {
        lockp.SetActive(false);
        top.SetActive(false);     
        yield return new WaitForSeconds(1f);
        basep.SetActive(false);
        tiles.walkable = true;
        tiles.tag = "Tile";
        //gameObject.tag = "Tile";
       // gameObject.GetComponent<GridTiles>().walkable = true;
    }
}
