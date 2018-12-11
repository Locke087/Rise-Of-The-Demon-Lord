using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayStats : MonoBehaviour {

    public string unitID;
    public int hp;
    public int str;
    public int def;
    public int spd;
    public int skill;
    public int magic;
    public int will;
    public int baseHp;
    public int baseStr;
    public int baseDef;
    public int baseSpd;
    public int baseSkill;
    public int baseMagic;
    public int baseWill;

    public int movement;
    public float finalHit;
    public int currentHp;
 
    public int weight;
    public int level;
    public int levelBoost = 10;
    public int enemyDamage;
    public int damage;
    public int enemyHitRate;
    public int playerHitRate;
    public int baseEnemyHit;
    public int basePlayerHit;
    public List<CharacterSheet> characterSheet;
    public float hpMod;
    public float strMod;
    public float defMod;
    public float spdMod;
    public float skillMod;
    public float willMod;
    public float magicMod;
    public float hpCap;
    public float strCap;
    public float defCap;
    public float spdCap;
    public float skillCap;
    public float willCap;
    public float magicCap;
    public List<TheNatures> allNatures;
    public int weaponWeight = 0;
    public int weaponMight = 0;
    public int weaponHit = 0;
    public float weaponCritRate = 0;
    public int weaponCritChance = 0;
    public string nature;
    public int critChance = 0;
    public float critRate = 0;
    public bool skip = false;
    public bool done = false;
    public bool go = false;
    public bool dead = false;
    public bool friend = false;
    public bool foe = false;
    public UnitAssessory currentAssessory1;
    public UnitAssessory currentAssessory2;
    public UnitAssessory currentAssessory3;
    //  public Button confirm;
    //public Button cancel;
    /* public int hpModStat;
     public int strModStat;
     public int defModStat;
     public int spdModStat;
     public int skillModStat;
     public int willModStat;
     public int magicModStat;
     public int movementMod;*/
    /// <summary>
    /// class Stuff
    /// </summary>
    // Use this for initialization

    public List<TheClassesBase> allClassesBase;
    // public List<TheClassesInc> allClassesInc;
    public List<TheClassesMod> allClassesMods;
    public List<TheClassesCap> allClassesCaps;
    public List<TheClassesMaster> allClassesMaster;
    public int calcHp;
    public int calcStr;
    public int calcDef;
    public int calcSpd;
    public int calcSkill;
    public int calcMagic;
    public int calcWill;

    void Start()
    {
        // confirm = GameObject.Find("AttackConfirm").GetComponent<Button>();
        // cancel = GameObject.Find("AttackCancel").GetComponent<Button>();
        //  confirm.onClick.AddListener(ButtonTrue);
        //   cancel.onClick.AddListener(ButtonFalse);
        //                                    spd|str|def|skl|Hp|Mag|Will |order
        allNatures.Add(new TheNatures("Nimble", 3, 1, 0, 1, 1, 1, 1)); //+spd -def 
        allNatures.Add(new TheNatures("Quick", 3, 1, 1, 1, 1, 1, 0)); //+spd -will 
        allNatures.Add(new TheNatures("Runner", 3, 0, 1, 1, 1, 1, 1)); //+spd -str 
        allNatures.Add(new TheNatures("Sprinter", 3, 1, 1, 0, 1, 1, 1)); //+spd -skill
        allNatures.Add(new TheNatures("Speedy", 3, 1, 1, 1, 0, 1, 1)); //+spd -hp;

        allNatures.Add(new TheNatures("Smart", 0, 1, 1, 1, 1, 3, 1)); // +mag -spd
        allNatures.Add(new TheNatures("Magical", 1, 0, 1, 1, 1, 3, 1)); // +mag -str 
        allNatures.Add(new TheNatures("Nuke", 1, 1, 0, 1, 1, 3, 1)); // +mag -def
        allNatures.Add(new TheNatures("SpellCaster", 1, 1, 1, 1, 0, 3, 1)); // +mag -hp
        allNatures.Add(new TheNatures("Haphazard", 0, 1, 1, 0, 1, 3, 1)); // +mag -skill 
                                                                          //sp st de sk hp mag will
        allNatures.Add(new TheNatures("Willfull", 1, 0, 1, 1, 1, 1, 3)); // +will -str 
        allNatures.Add(new TheNatures("Resistant", 0, 1, 1, 1, 1, 1, 3)); // +will -spd 
        allNatures.Add(new TheNatures("Resilient", 1, 1, 1, 0, 1, 1, 3)); // +will -skill 
        allNatures.Add(new TheNatures("Faithfull", 1, 1, 0, 1, 1, 1, 3)); // +will -def
        allNatures.Add(new TheNatures("Hopefull", 1, 1, 1, 1, 0, 1, 3)); // +will -hp
        allNatures.Add(new TheNatures("Surviver", 1, 1, 1, 1, 1, 0, 3)); // +will -mag

        allNatures.Add(new TheNatures("Tough", 0, 1, 3, 1, 1, 1, 1)); //+def -spd 
        allNatures.Add(new TheNatures("Guard", 1, 0, 3, 1, 1, 1, 1)); //+def -atk
        allNatures.Add(new TheNatures("Hard", 1, 1, 3, 1, 1, 0, 1)); //+def -mag
        allNatures.Add(new TheNatures("Heavy", 0, 1, 3, 0, 1, 1, 1)); //+def -skill 
        allNatures.Add(new TheNatures("Thick", 0, 1, 3, 1, 0, 1, 1)); //+def -hp 
        allNatures.Add(new TheNatures("Bulky", 0, 1, 3, 1, 1, 1, 0)); //+def -will 

        allNatures.Add(new TheNatures("Strong", 0, 3, 1, 1, 1, 1, 1)); //+str -spd 
        allNatures.Add(new TheNatures("Aggressive", 1, 3, 1, 0, 1, 1, 1)); //+str -def 
        allNatures.Add(new TheNatures("Ripper", 1, 3, 1, 1, 1, 1, 0)); //+str -will
        allNatures.Add(new TheNatures("Fighter", 1, 3, 1, 1, 1, 0, 1)); //+str -mag 
        allNatures.Add(new TheNatures("Wild", 1, 3, 1, 0, 1, 1, 1)); //+str -skill 
        allNatures.Add(new TheNatures("", 1, 3, 1, 1, 0, 1, 1)); //+str -hp 
                                                                 //sp st de sk hp mag will
        allNatures.Add(new TheNatures("Handy", 1, 1, 1, 3, 0, 1, 1)); //+skl -hp 
        allNatures.Add(new TheNatures("Sure", 1, 1, 0, 3, 1, 1, 1)); //+skl -def 
        allNatures.Add(new TheNatures("Steady", 0, 1, 1, 3, 1, 1, 1)); //+skl -spd
        allNatures.Add(new TheNatures("Firm", 1, 1, 1, 3, 1, 0, 1)); //+skl -mag 
        allNatures.Add(new TheNatures("Aimmer", 1, 0, 1, 3, 1, 1, 1)); //+skl -str 
        allNatures.Add(new TheNatures("Ready", 1, 0, 1, 3, 1, 1, 0)); //+skl -will 

        allNatures.Add(new TheNatures("Heathly", 0, 1, 1, 1, 3, 1, 1)); //+hp -spd
        allNatures.Add(new TheNatures("Hardy", 0, 1, 1, 1, 3, 1, 0)); //+hp -will
        allNatures.Add(new TheNatures("Knowing", 1, 1, 0, 1, 3, 1, 1)); //+hp -def
        allNatures.Add(new TheNatures("Drifter", 1, 1, 1, 1, 3, 1, 0)); //+hp -will
        allNatures.Add(new TheNatures("Weak", 1, 0, 1, 1, 3, 1, 1)); //+hp -atk
        allNatures.Add(new TheNatures("Dumb", 1, 1, 0, 1, 3, 0, 1)); //+hp -mag
        allNatures.Add(new TheNatures("Lame", 1, 1, 1, 0, 3, 1, 1)); //+hp -skill

        allNatures.Add(new TheNatures("Neutral", 1, 1, 1, 1, 1, 1, 1)); //neutral
        currentAssessory1 = new UnitAssessory();
        currentAssessory2 = new UnitAssessory();
        currentAssessory3 = new UnitAssessory();
        if (nature == null) nature = "Neutral";
        currentHp = hp;

 
    }


    public void Clean()
    {
        allClassesBase.Clear();
        // public List<TheClassesInc> allClassesInc;
        allClassesMods.Clear();
        allClassesCaps.Clear();
        allClassesMaster.Clear();
}

    public void StartUp()
    {

        currentHp = hp;
        startClassesUp();
        ActivateAssessories();
        ReflectStat();
       // StartCoroutine(RefreshStat());
    }
    public void RefreshIt()
    {
        StartCoroutine(RefreshStat());
    }

    public Unit FindMyself()
    {
        Unit me = new Unit();
        foreach (Unit u in CurrentGame.game.storeroom.units)
        {
            if (unitID == u.unitID) me = u;
        }
        return me;
    }

 

    public IEnumerator RefreshStat()
    {
        yield return new WaitForSeconds(0.2f);
        classesRefresh();
        ActivateAssessories();
        ReflectStat();

    }

    // Update is called once per frame
    public void StartingBases(int h, int a, int d, int sp, int sk, int m, int w, int mo)
    {
        int key = 0;
        int count = 0;
        foreach (TheNatures n in allNatures)
        {
            if (nature == n.natures) key = count;
            count++;
        }
        baseHp = h + allNatures[key].isHp;
        baseStr = a + allNatures[key].isStr;
        baseDef = d + allNatures[key].isDef;
        baseSpd = sp + allNatures[key].isSpd;
        baseSkill = sk + allNatures[key].isSkill;
        baseMagic = m + allNatures[key].isMag;
        baseWill = w + allNatures[key].isWill;
        movement = mo;
    }


    public void GetMySheet(List<CharacterSheet> ch)
    {
        characterSheet = ch;
    }


    public void GetMyNature(string n)
    {
        nature = n;
    }

    /* public void OnMouseEnter()
     {
         if (!GameObject.FindObjectOfType<SpeedCenterTurns>().stopped)
         {
             GameObject.Find("SumHp").GetComponent<Text>().text = currentHp.ToString();
             GameObject.Find("SumDef").GetComponent<Text>().text = def.ToString();
             GameObject.Find("SumAtk").GetComponent<Text>().text = str.ToString();
             GameObject.Find("SumSpd").GetComponent<Text>().text = spd.ToString();
             GameObject.Find("SumSkl").GetComponent<Text>().text = skill.ToString();
         }
     }

     public void OnMouseExit()
     {

         if (!GameObject.FindObjectOfType<SpeedCenterTurns>().stopped)
         {
             GameObject.Find("SumHp").GetComponent<Text>().text = "0";
             GameObject.Find("SumDef").GetComponent<Text>().text = "0";
             GameObject.Find("SumAtk").GetComponent<Text>().text = "0";
             GameObject.Find("SumSpd").GetComponent<Text>().text = "0";
             GameObject.Find("SumSkl").GetComponent<Text>().text = "0";
         }
     }*/


    /* public void UpdateModsStat(int a, int d, int sp, int sk, int m, int w)
     {
         skillModStat = sk;
         strModStat = a;
         spdModStat = sp;
         defModStat = d;
         magicModStat = m;
         willModStat = w;
     }*/

    public void UpdateMods(float a, float d, float sp, float sk, float m, float w)
    {
        skillMod = sk;
        strMod = a;
        spdMod = sp;
        defMod = d;
        magicMod = m;
        willMod = w;
    }

    public void UpdateCaps(float a, float d, float sp, float sk, float m, float w, float hp)
    {
        skillCap = sk;
        strCap = a;
        spdCap = sp;
        defCap = d;
        magicCap = m;
        willCap = w;
        hpCap = hp;
    }

    /* public void Booster()
     {

         if (levelBoost > 0)
         {

             for (int i = 0; i < levelBoost; i++)
             {
                 FindStats();
                 ReflectStat();
                 level++;
             }
             levelBoost = 0;
             if (hp > currentHp)
                 currentHp = hp;
         }

     }*/

    public void ReflectStat()
    {
        Debug.Log("hello");
        //baseStr = baseStr + strModStat;
        float temp = baseStr * strMod;
        if (temp > strCap)
        {
            str = (int)strCap;
        }
        else str = (int)temp;
        Debug.Log(str);
        //baseDef = baseDef + defModStat;
        float ntemp = baseDef * defMod;
        if (ntemp > defCap)
        {
            def = (int)defCap;
        }
        else def = (int)ntemp;
        //baseSkill = baseSkill + defModStat;
        float stemp = baseSkill * defMod;
        if (stemp > skillCap)
        {
            skill = (int)skillCap;
        }
        else skill = (int)stemp;
        //baseSpd = baseSpd + spdModStat;
        float ftemp = baseSpd * spdMod;
        if (ftemp > spdCap)
        {
            spd = (int)spdCap;
        }
        else spd = (int)ftemp;
        //baseMagic = baseMagic + magicModStat;
        float jtemp = baseMagic * magicMod;
        if (jtemp > magicCap)
        {
            magic = (int)magicCap;
        }
        else magic = (int)jtemp;
        //baseWill = baseWill + willModStat;
        float gtemp = baseWill * willMod;
        if (gtemp > willCap)
        {
            will = (int)willCap;
        }
        else will = (int)gtemp;

        float defTemp = baseDef;
        float strTemp = str;
        Debug.Log(defTemp + " " + strTemp);
        float fbtemp = Mathf.Round((strTemp / 1.5f) + (defTemp / 1.5f));
        hp = (int)fbtemp;
        currentHp = hp;
    }

    public void attacked(Stats attacker)
    {
        //AttackPreview(attacker);
        int aAttackSpeed = spd - weaponWeight;
        int dAttackSpeed = attacker.spd - attacker.weaponWeight;
        DefenderDamaged(attacker);
        if ((aAttackSpeed) < 0) aAttackSpeed = 0;
        if ((dAttackSpeed) < 0) dAttackSpeed = 0;
        //Double Attack if: (Attack Speed – enemy Attack Speed) >= 4
        if ((aAttackSpeed - dAttackSpeed) >= 4 && currentHp >= 0 && attacker.currentHp >= 0)
        {
            DefenderDamaged(attacker);
        }
        else if ((dAttackSpeed - aAttackSpeed) >= 4 && currentHp >= 0 && attacker.currentHp >= 0) AttackerDamaged(attacker);

        //if (gameObject.tag == "Player") GameObject.FindObjectOfType<MapManager>().PlayerAttackTrue();
    }


    public void Death()
    {
        dead = true;

        if (gameObject.tag == "Player")
        {
            if (GameObject.FindObjectOfType<SpeedCenterTurns>().activeUnit == gameObject)
            {
                GameObject.FindObjectOfType<PlayerUnitMenu>().EndTurn();
            }
        }
        else
        {
            if (GameObject.FindObjectOfType<SpeedCenterTurns>().activeUnit == gameObject)
            {
                GameObject.FindObjectOfType<SpeedCenterTurns>().AdvanceTurn();
            }
        }

        //GameObject.FindObjectOfType<SpeedCenterTurns>().UpdateList();
        gameObject.tag = "Dead";

        StartCoroutine(DeathTimer());
    }

    public IEnumerator DeathTimer()
    {
        //UnitsLiving();
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }

    /* public void UnitsLiving()
     {

         if (GameObject.FindGameObjectsWithTag("Enemy") != null)
         {
             if (GameObject.FindGameObjectsWithTag("Enemy").Length > 1) { }
             else
             {
                 if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
             }

             if (GameObject.FindGameObjectWithTag("Player") != null) return;
             else
             {
                 GameObject.FindObjectOfType<GameOver>().GameEnd();
             }
         }
         else
         {
             if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
         }

         gameObject.tag = "Dead";




     }*/

    public void AttackPreview(Stats attacker)
    {
        int eDamage = EnemyAttack(attacker);
        if (eDamage <= 0) eDamage = 1;
        int pDamage = PlayerAttack(attacker);
        if (pDamage <= 0) pDamage = 1;
        int eHit = EnemyHit(attacker);
        if (eHit > 100) eHit = 100;
        else if (eHit < 0) eHit = 0;
        int pHit = PlayerHit(attacker);
        if (pHit > 100) pHit = 100;
        else if (pHit < 0) pHit = 0;
        int eCritC = EnemyCritChance(attacker);
        int pCritC = PlayerCritChance(attacker);
        float eCrit = EnemyCrit(attacker);
        float pCrit = PlayerCrit(attacker);

    }

    /*  private IEnumerator WaitTilConfirm(Stats attacker)
      {
          yield return new WaitUntil(() => done == true);
          if (go)
          {
              done = false;
              AttackContinue(attacker);
          }
          else
          {
              done = false;
              ExitAttack();
          }
      }

      private IEnumerator WaitABit(Stats attacker)
      {
          yield return new WaitForSeconds(2f);

      }

      public void ExitAttack()
      {
          GameObject.FindObjectOfType<MapManager>().AttackFalse();
      }

      public void ButtonFalse()
      {
         done = true;
         go = false;
      }

      public void ButtonTrue()
      {
          done = true;
          go = true;
      }*/


    public int EnemyHit(Stats attacker)
    {
        int hitRate = (int)CalcEnemyHitRate(attacker.skill, attacker.weaponHit);
        return hitRate;

    }

    public int EnemyCritChance(Stats attacker)
    {
        int crit = attacker.weaponCritChance + attacker.critChance;
        return crit;

    }

    public float EnemyCrit(Stats attacker)
    {
        float crit = attacker.weaponCritRate + attacker.critRate;
        return crit;

    }

    public int EnemyAttack(Stats attacker)
    {
        int totalAtk = str + weaponMight;
        int tempEnemyDamage = totalAtk - attacker.def;
        return tempEnemyDamage;
    }

    public int PlayerAttack(Stats attacker)
    {
        int totalAtk = attacker.str + attacker.weaponMight;
        int tempDamage = totalAtk - def;
        return tempDamage;

    }

    public int PlayerHit(Stats attacker)
    {

        int hitRate = (int)CalcHitRate(attacker.spd, attacker.weaponWeight);

        return hitRate;

    }

    public float PlayerCrit(Stats attacker)
    {
        float newDamage = weaponCritRate + critRate;
        return newDamage;

    }

    public int PlayerCritChance(Stats attacker)
    {
        int newDamage = weaponCritChance + critChance;
        return newDamage;

    }

    public int CalcCrit(float hurt, float rate, int chance)
    {
        if (Random.Range(0, 101) <= chance)
        {
      
            float critNum = hurt * rate;
            int final = (int)critNum;
            return final;
        }
        return (int)hurt;
    }


    public int CalcCritE(float hurt, float rate, int chance)
    {
        if (Random.Range(0, 101) <= chance)
        {
           

            float critNum = hurt * rate;
            int final = (int)critNum;
            return final;
        }
        return (int)hurt;
    }



    public void DefenderDamaged(Stats attacker)
    {
        //total atk includes weapons
        enemyHitRate = (int)CalcEnemyHitRate(attacker.skill, attacker.weaponHit);
        baseEnemyHit = enemyHitRate;
        int totalAtk = attacker.str + attacker.weaponMight;
        damage = totalAtk - def;
        float reduce = CalcFinalHit(enemyHitRate);
        float hurt = damage * reduce;
        int newDamage = CalcCrit(hurt, attacker.weaponCritRate + attacker.critRate, attacker.weaponCritChance + attacker.critChance);
        damage = newDamage;
        Debug.Log("Is Now This Much HP: " + attacker.currentHp);

        if (damage > 0)
            currentHp = currentHp - damage;
        else
        {
            damage = 1;
            currentHp = currentHp - damage;
        }

        Debug.Log(gameObject.name + "lost " + damage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        Debug.Log("Is Now This Much HP: " + currentHp);
      


        if (currentHp <= 0) Death();
    }


    public void AttackerDamaged(Stats attacker)
    {

        playerHitRate = (int)CalcHitRate(attacker.spd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = str + weaponMight;
        enemyDamage = totalAtk - attacker.def;
        float reduce = CalcFinalHit(playerHitRate);
        float hurt = enemyDamage * reduce;
        if (hurt < 0)
        {

            int newDamage = CalcCrit(hurt, weaponCritRate + critRate, weaponCritChance + critChance);
            enemyDamage = newDamage;
        }


        Debug.Log("Had This Much HP: " + attacker.currentHp);

        if (enemyDamage > 0)
            attacker.currentHp = attacker.currentHp - enemyDamage;
        else
        {
            enemyDamage = 1;
            attacker.currentHp = attacker.currentHp - enemyDamage;
        }


        Debug.Log(attacker.gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        Debug.Log("Is Now This Much HP: " + attacker.currentHp);
    

        if (attacker.currentHp <= 0) attacker.Death();
    }

    public void SetMeleetWeaponStats()
    {
        Unit me = FindMyself();
        if (me.inventory.invSlot1.weapon.equipped)
        {
            weaponHit = me.inventory.invSlot1.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot1.weapon.details.might;
            weaponWeight = me.inventory.invSlot1.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot1.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot1.weapon.details.critrate;
        }
        else if (me.inventory.invSlot2.weapon.equipped)
        {
            weaponHit = me.inventory.invSlot2.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot2.weapon.details.might;
            weaponWeight = me.inventory.invSlot2.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot2.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot2.weapon.details.critrate;
        }
        else if (me.inventory.invSlot3.weapon.equipped)
        {
            weaponHit = me.inventory.invSlot3.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot3.weapon.details.might;
            weaponWeight = me.inventory.invSlot3.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot3.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot3.weapon.details.critrate;
        }
        else if (me.inventory.invSlot4.weapon.equipped)
        {
            weaponHit = me.inventory.invSlot4.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot4.weapon.details.might;
            weaponWeight = me.inventory.invSlot4.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot4.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot4.weapon.details.critrate;
        }
        else if (me.inventory.invSlot5.weapon.equipped)
        {
            weaponHit = me.inventory.invSlot5.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot5.weapon.details.might;
            weaponWeight = me.inventory.invSlot5.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot5.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot5.weapon.details.critrate;
        }

    }

    public void ActivateAssessories()
    {
        if (currentAssessory1.name != "")
        {
            if (currentAssessory1.details.boostStr) str += (int)(str * currentAssessory1.details.boost);
            if (currentAssessory1.details.boostDef) def += (int)(def * currentAssessory1.details.boost);
            if (currentAssessory1.details.boostSpd) spd += (int)(spd * currentAssessory1.details.boost);
            if (currentAssessory1.details.boostSkill) skill += (int)(skill * currentAssessory1.details.boost);
            if (currentAssessory1.details.boostMag) magic += (int)(magic * currentAssessory1.details.boost);
            if (currentAssessory1.details.boostWill) will += (int)(will * currentAssessory1.details.boost);
            weaponWeight += currentAssessory1.details.weight;
        }
        if (currentAssessory2.name != "")
        {
            if (currentAssessory2.details.boostStr) str += (int)(str * currentAssessory2.details.boost);
            if (currentAssessory2.details.boostDef) def += (int)(def * currentAssessory2.details.boost);
            if (currentAssessory2.details.boostSpd) spd += (int)(spd * currentAssessory2.details.boost);
            if (currentAssessory2.details.boostSkill) skill += (int)(skill * currentAssessory2.details.boost);
            if (currentAssessory2.details.boostMag) magic += (int)(magic * currentAssessory2.details.boost);
            if (currentAssessory2.details.boostWill) will += (int)(will * currentAssessory2.details.boost);
            weaponWeight += currentAssessory2.details.weight;
        }
        if (currentAssessory3.name != "")
        {

            if (currentAssessory3.details.boostStr) str += (int)(str * currentAssessory3.details.boost);
            if (currentAssessory3.details.boostDef) def += (int)(def * currentAssessory3.details.boost);
            if (currentAssessory3.details.boostSpd) spd += (int)(spd * currentAssessory3.details.boost);
            if (currentAssessory3.details.boostSkill) skill += (int)(skill * currentAssessory3.details.boost);
            if (currentAssessory3.details.boostMag) magic += (int)(magic * currentAssessory3.details.boost);
            if (currentAssessory3.details.boostWill) will += (int)(will * currentAssessory3.details.boost);
            weaponWeight += currentAssessory3.details.weight;
        }
    }

    public void SetAssessories()
    {
        Unit me = FindMyself();
        if (me.inventory.invSlot1.assessory.equipped)
        {
            currentAssessory1 = me.inventory.invSlot1.assessory;
        }
        if (me.inventory.invSlot2.assessory.equipped)
        {
            if (currentAssessory1.name == "") currentAssessory1 = me.inventory.invSlot2.assessory;
            else currentAssessory2 = me.inventory.invSlot2.assessory;

        }
        if (me.inventory.invSlot3.assessory.equipped)
        {
            if (currentAssessory1.name == "") currentAssessory1 = me.inventory.invSlot3.assessory;
            if (currentAssessory2.name == "") currentAssessory2 = me.inventory.invSlot3.assessory;
            else currentAssessory3 = me.inventory.invSlot3.assessory;
        }
        if (me.inventory.invSlot4.assessory.equipped)
        {
            if (currentAssessory1.name == "") currentAssessory1 = me.inventory.invSlot4.assessory;
            if (currentAssessory2.name == "") currentAssessory2 = me.inventory.invSlot4.assessory;
            else currentAssessory3 = me.inventory.invSlot4.assessory;
        }
        if (me.inventory.invSlot5.assessory.equipped)
        {
            if (currentAssessory1.name == "") currentAssessory1 = me.inventory.invSlot5.assessory;
            if (currentAssessory2.name == "") currentAssessory2 = me.inventory.invSlot5.assessory;
            else currentAssessory3 = me.inventory.invSlot5.assessory;
        }

    }

    public float CalcEnemyHitRate(int enemySkill, int enemyWeaponHit)
    {
        float accurary = enemyWeaponHit + (enemySkill * 2);
        float avoid = (spd - weaponWeight) * 2;
        float hit = accurary - avoid;

        return hit;
        //where hitRate will be calculated
    }

    public float CalcHitRate(int enemySpd, int enemyWeaponWeight)
    {
        float accurary = weaponHit + (skill * 2);
        float avoid = (enemySpd - enemyWeaponWeight) * 2;
        float hit = accurary - avoid;

        return hit;
        //where hitRate will be calculated
    }

    public float CalcFinalHit(int hitRate)
    {
        finalHit = 0;

        if (hitRate >= 100) finalHit = 1;
        else if (hitRate > 80)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 1;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 1;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
            else finalHit = 0;
        }
        else if (hitRate > 60)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
            else finalHit = 0;
        }
        else if (hitRate > 40)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
            else finalHit = 0;
        }
        else if (hitRate > 20)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
            else if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
            else finalHit = 0;
        }
        else
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.10f;
            else finalHit = 0;
        }

        return finalHit;
    }




    /// <summary>
    /// Class Section
    /// </summary>
    public void startClassesUp()
    {
        //  TheClassesBase(string cas, int spd, int str, int def, int skl, int hp, int mag, int will, int mo)
        // string cas, float spd, float str, float def, float skl, float mag, float will)
        // h, a, d, sp, sk, m, w                     // h, a  d  sp,sk,m, w  mo
        // gameObject.GetComponent<Stats>().StartingBases(15, 8, 8, 7, 6, 3, 4, 7);
        // sp,a, d, sk, hp, m, w, mo
        Unit me = FindMyself();
        nature = me.unitInfo.nature;
        SetMeleetWeaponStats();


        allClassesBase = new List<TheClassesBase>();
        //allClassesInc = new List<TheClassesInc>();
        allClassesMods = new List<TheClassesMod>();
        allClassesMaster = new List<TheClassesMaster>();

       // StatRange(me.unitInfo.bases);

        allClassesBase.Add(new TheClassesBase(me.unitInfo.bases[0], me.unitInfo.bases[1], me.unitInfo.bases[2], me.unitInfo.bases[3], me.unitInfo.bases[4], me.unitInfo.bases[5], 15, me.unitInfo.main.movement));
        //allClassesInc.Add(new TheClassesInc("Warrior", Warrior.IncList()));
        Debug.Log(me.unitInfo.main.caps.Count + " hooooow");

        allClassesCaps.Add(new TheClassesCap(me.unitInfo.main.caps));
        allClassesMods.Add(new TheClassesMod(me.unitInfo.main.modifiers));

        /*allClassesBase.Add(new TheClassesBase("Cavalier", calcStr, calcDef, calcSpd, calcSkill, calcMagic, calcWill, 15, 7));
          //allClassesInc.Add(new TheClassesInc("Cavalier", Cavalier.IncList()));
          allClassesMods.Add(new TheClassesMod("Cavalier", Cavalier.ModList()));
          StatRange(7, 5, 3, 5, 2, 1);
          allClassesBase.Add(new TheClassesBase("WarriorE", calcStr, calcDef, calcSpd, calcSkill, calcMagic, calcWill, 15, 5));
          //allClassesInc.Add(new TheClassesInc("Warrior", Warrior.IncList()));
          allClassesMods.Add(new TheClassesMod("WarriorE", WarriorE.ModList()));
          StatRange(6, 6, 5, 4, 1, 2);
          allClassesBase.Add(new TheClassesBase("CavalierE", calcStr, calcDef, calcSpd, calcSkill, calcMagic, calcWill, 15, 7));
          //allClassesInc.Add(new TheClassesInc("Cavalier", Cavalier.IncList()));
          allClassesMods.Add(new TheClassesMod("CavalierE", CavalierE.ModList()));*/

        allClassesMaster.Add(new TheClassesMaster(allClassesBase[0], allClassesMods[0], allClassesCaps[0]));

        FindStats();

    }
    public void classesRefresh()
    {
        allClassesCaps.Clear();
        allClassesMods.Clear();
        allClassesMaster.Clear();

        allClassesMods.Add(new TheClassesMod(FindMyself().unitInfo.main.modifiers));
        allClassesCaps.Add(new TheClassesCap(FindMyself().unitInfo.main.caps));
        allClassesMaster.Add(new TheClassesMaster(allClassesBase[0], allClassesMods[0], allClassesCaps[0]));

        FinishStats();

    }

    public void FindStats()
    {
        Debug.Log("gotHere");
        foreach (TheClassesMaster mas in allClassesMaster)
        {
            StartingBases(mas.bases.isHp, mas.bases.isStr, mas.bases.isDef, mas.bases.isSpd, mas.bases.isSkill, mas.bases.isMag, mas.bases.isWill, mas.bases.isMove);
            UpdateCaps(mas.cap.isStr, mas.cap.isDef, mas.cap.isSpd, mas.cap.isSkill, mas.cap.isMag, mas.cap.isWill, mas.cap.isHp);
            UpdateMods(mas.mod.isStr, mas.mod.isDef, mas.mod.isSpd, mas.mod.isSkill, mas.mod.isMag, mas.mod.isWill);
        }

    }

    public void FinishStats()
    {
        Debug.Log("gotHere");
        foreach (TheClassesMaster mas in allClassesMaster)
        {
            UpdateCaps(mas.cap.isStr, mas.cap.isDef, mas.cap.isSpd, mas.cap.isSkill, mas.cap.isMag, mas.cap.isWill, mas.cap.isHp);
            UpdateMods(mas.mod.isStr, mas.mod.isDef, mas.mod.isSpd, mas.mod.isSkill, mas.mod.isMag, mas.mod.isWill);
        }

    }

    public void StatRange(List<int> all)
    {
        int max = 35;
        int min = 20;
        int temp = 0;
        int range = 3;
        bool done = false;
        do
        {
            int aTemp = all[0];
            calcStr = Random.Range(aTemp, aTemp + range);
            aTemp = all[1];
            calcDef = Random.Range(aTemp, aTemp + range);
            aTemp = all[2];
            calcSpd = Random.Range(aTemp, aTemp + range);
            aTemp = all[3];
            calcSkill = Random.Range(aTemp, aTemp + range);
            aTemp = all[4];
            calcMagic = Random.Range(aTemp, aTemp + range);
            aTemp = all[5];
            calcWill = Random.Range(aTemp, aTemp + range);
            temp = calcStr + calcDef + calcSpd + calcSkill + calcMagic + calcWill;

            if (temp > min && temp < max)
            {
                done = true;
            }
        } while (!done);


    }



    [System.Serializable]
    public class TheNatures
    {
        public int isSpd;
        public int isStr;
        public int isDef;
        public int isSkill;
        public int isHp;
        public int isMag;
        public int isWill;
        public string natures;


        public TheNatures(string n, int spd, int str, int def, int skl, int hp, int mag, int will)
        {
            natures = n;
            isSpd = spd;
            isStr = str;
            isDef = def;
            isSkill = skl;
            isHp = hp;
            isMag = mag;
            isWill = will;

        }

    }

    [System.Serializable]
    public class CharacterSheet
    {

        // Use this for initialization
        public bool isSpd;
        public bool isStr;
        public bool isDef;
        public bool isSkill;
        public bool isHp;
        public bool visited = false;
        public int level = 0;
        public CharacterSheet(bool spd, bool str, bool def, bool skl, bool hp)
        {
            level++;
            isSpd = spd;
            isStr = str;
            isDef = def;
            visited = false;
            isSkill = skl;
            isHp = hp;
        }


    }

    [System.Serializable]
    public class TheClassesMod
    {
        public float isSpd = 0;
        public float isStr = 0;
        public float isDef = 0;
        public float isSkill = 0;
        public float isMag = 0;
        public float isWill = 0;

        public TheClassesMod(List<float> list)
        {
            isStr = list[0];
            isDef = list[1];
            isSpd = list[2];
            isSkill = list[3];
            isMag = list[4];
            isWill = list[5];
        }
    }

    [System.Serializable]
    public class TheClassesCap
    {
        public float isSpd = 0;
        public float isStr = 0;
        public float isDef = 0;
        public float isSkill = 0;
        public float isMag = 0;
        public float isWill = 0;
        public float isHp = 0;

        public TheClassesCap(List<float> list)
        {
            isStr = list[0];
            isDef = list[1];
            isSpd = list[2];
            isSkill = list[3];
            isMag = list[4];
            isWill = list[5];
            isHp = list[6];
        }
    }

    [System.Serializable]
    public class TheClassesBase
    {

        public int isSpd = 0;
        public int isStr = 0;
        public int isDef = 0;
        public int isSkill = 0;
        public int isHp = 0;
        public int isMag = 0;
        public int isWill = 0;
        public int isMove = 0;

        public TheClassesBase(int str, int def, int spd, int skl, int mag, int will, int hp, int mo)
        {

            isSpd = spd;
            isStr = str;
            isDef = def;
            isSkill = skl;
            isHp = hp;
            isMag = mag;
            isWill = will;
            isMove = mo;
        }


    }


    [System.Serializable]
    public class TheClassesMaster
    {
        public TheClassesBase bases;
        // public TheClassesInc incClass;
        public TheClassesMod mod;
        public TheClassesCap cap;

        public TheClassesMaster(TheClassesBase b, TheClassesMod m, TheClassesCap c)
        {
            bases = b;
            mod = m;
            cap = c;
            //  i = incClass;

        }


    }
}
