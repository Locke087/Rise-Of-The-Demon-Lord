﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{

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
    public Text showHp;
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

    public string currentClass;
    public List<TheClassesBase> allClassesBase;
    // public List<TheClassesInc> allClassesInc;
    public List<TheClassesMod> allClassesMods;
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
        currentHp = hp;
        //                                    spd|str|def|skl|Hp|Mag|Will |order
        allNatures.Add(new TheNatures("Nimble", 3, 1, 0, 1, 1, 1, 1)); //+spd -def 
        allNatures.Add(new TheNatures("Tough", 0, 1, 3, 1, 1, 1, 1)); //+def -spd 
        allNatures.Add(new TheNatures("Strong", 0, 2, 1, 1, 1, 1, 1)); //+str -spd 
        allNatures.Add(new TheNatures("Aggressive", 1, 3, 1, 0, 1, 1, 1)); //+str -def 
        allNatures.Add(new TheNatures("Handy", 1, 1, 1, 3, 0, 1, 1)); //+skl -hp 
        allNatures.Add(new TheNatures("Heathly", 0, 1, 1, 1, 3, 1, 1)); //+hp -sp
        allNatures.Add(new TheNatures("Neutral", 1, 1, 1, 1, 1, 1, 1)); //neutral
        if (nature == null) nature = "Neutral";
        currentHp = hp;
        gameObject.GetComponent<ARandomNature>().PickANature();
        startClassesUp();


        Debug.Log("hsfsifhdj");
        if (gameObject.GetComponent<MapPlayerMove>() != null)
        {
            friend = true;
            gameObject.GetComponent<MapPlayerMove>().move = movement;
        }
        else if (gameObject.GetComponent<MapEnemyMove>() != null)
        {
            foe = true;
            gameObject.GetComponent<MapEnemyMove>().move = movement;
        }


        // gameObject.GetComponent<Weapon>().weaponStats();

        //confirm.gameObject.SetActive(false);
        //cancel.gameObject.SetActive(false);
        FindStats();
        ReflectStat();
        // Booster();
        StartCoroutine(RefreshStat());
    }


  
    public IEnumerator RefreshStat()
    {
        yield return new WaitForSeconds(0.5f);
        FindStats();
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

    public void OnMouseEnter()
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
    }


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
        str = (int)temp;
        Debug.Log(str);
        //baseDef = baseDef + defModStat;
        float ntemp = baseDef * defMod;
        def = (int)ntemp;
        //baseSkill = baseSkill + defModStat;
        float stemp = baseSkill * defMod;
        skill = (int)stemp;
        //baseSpd = baseSpd + spdModStat;
        float ftemp = baseSpd * spdMod;
        spd = (int)ftemp;
        //baseMagic = baseMagic + magicModStat;
        float jtemp = baseMagic * magicMod;
        magic = (int)jtemp;
        //baseWill = baseWill + willModStat;
        float gtemp = baseWill * willMod;
        will = (int)gtemp;

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

        PlayerDamaged(attacker);
        if (currentHp > 0 && attacker.currentHp > 0) EnemyDamaged(attacker);

        if ((attacker.spd - weaponWeight) - (spd - weaponWeight) >= 3 && currentHp > 0 && attacker.currentHp > 0)
        {
            PlayerDamaged(attacker);
        }
        else if ((spd - weaponWeight) - (attacker.spd - weaponWeight) >= 3 && currentHp > 0 && attacker.currentHp > 0) EnemyDamaged(attacker);

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
    
        StartCoroutine(DeathTimer());
    }

    public IEnumerator DeathTimer()
    {
        UnitsLiving();
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }

    public void UnitsLiving()
    {

        if (GameObject.FindGameObjectsWithTag("Enemy") != null)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length > 1) { }
            else
            {
                if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
            }

            if (GameObject.FindGameObjectsWithTag("Player") != null) return;
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




    }

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

        GameObject.Find("AtkHp").GetComponentInChildren<Text>().text = currentHp.ToString();
        GameObject.Find("DefHp").GetComponentInChildren<Text>().text = attacker.currentHp.ToString();
        GameObject.Find("AtkAtk").GetComponentInChildren<Text>().text = pDamage.ToString();
        GameObject.Find("DefAtk").GetComponentInChildren<Text>().text = eDamage.ToString();
        GameObject.Find("AtkHit").GetComponentInChildren<Text>().text = pHit.ToString();
        GameObject.Find("DefHit").GetComponentInChildren<Text>().text = eHit.ToString();
        GameObject.Find("AtkCC").GetComponentInChildren<Text>().text = pCritC.ToString();
        GameObject.Find("DefCC").GetComponentInChildren<Text>().text = eCritC.ToString();
        GameObject.Find("AtkCR").GetComponentInChildren<Text>().text = pCrit.ToString();
        GameObject.Find("DefCR").GetComponentInChildren<Text>().text = eCrit.ToString();

     /*   if (gameObject.tag == "Enemy")
        {
            StartCoroutine(WaitABit(attacker));
        }
        else
        {
           
            StartCoroutine(WaitTilConfirm(attacker));
        }*/

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
  

    public void CleanTextBoxs()
    {

        GameObject.Find("AtkHp").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefHp").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("AtkAtk").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefAtk").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("AtkHit").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefHit").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("AtkCC").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefCC").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("AtkCR").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefCR").GetComponentInChildren<Text>().text = "0";
        GameObject.Find("DefTD").GetComponent<Text>().text = "0";
        GameObject.Find("DefTD2").GetComponent<Text>().text = "0";
        GameObject.Find("AtkTD").GetComponent<Text>().text = "0";
        GameObject.Find("AtkTD2").GetComponent<Text>().text = "0";
    }

    public void PlayerDamaged(Stats attacker)
    {
        //total atk includes weapons
        enemyHitRate = (int)CalcEnemyHitRate(attacker.skill, attacker.weaponHit);
        baseEnemyHit = enemyHitRate;
        int totalAtk = attacker.str + attacker.weaponMight;
        damage = totalAtk - def;
        float hurt = damage * CalcFinalHit(enemyHitRate);
        int newDamage = CalcCrit(hurt, attacker.weaponCritRate + attacker.critRate, attacker.weaponCritChance + attacker.critChance);
        damage = newDamage;
       
        Debug.Log(gameObject.name + "lost " + damage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        if (damage > 0)
            currentHp = currentHp - damage;
        else
        {
            damage = 1;
            currentHp = currentHp - damage;
        }

        if (GameObject.Find("AtkTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("AtkTD2").GetComponent<Text>().text = damage.ToString();
        }
        else
        {
            GameObject.Find("AtkTD").GetComponent<Text>().text = damage.ToString();
        }

        GameObject.Find("AtkHp").GetComponentInChildren<Text>().text = currentHp.ToString();
        

        if (currentHp <= 0) Death();
    }


    public void EnemyDamaged(Stats attacker)
    {

        playerHitRate = (int)CalcHitRate(attacker.spd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = str + weaponMight;
        enemyDamage = totalAtk - attacker.def;
        float hurt = enemyDamage * CalcFinalHit(playerHitRate);
        if (hurt < 0)
        {
            int newDamage = CalcCrit(hurt, weaponCritRate + critRate, weaponCritChance + critChance);
            enemyDamage = newDamage;
        }
        
       
     
        Debug.Log(gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + def);

        if (enemyDamage > 0)
            attacker.currentHp = attacker.currentHp - enemyDamage;
        else
        {
            enemyDamage = 1;
            attacker.currentHp = attacker.currentHp - enemyDamage;
        }

        if (GameObject.Find("DefTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("DefTD2").GetComponent<Text>().text = enemyDamage.ToString();
        }
        else
        {
            GameObject.Find("DefTD").GetComponent<Text>().text = enemyDamage.ToString();
        }

        GameObject.Find("DefHp").GetComponentInChildren<Text>().text = attacker.currentHp.ToString();

        if (attacker.currentHp < 0) attacker.Death();
    }

    public void SetMeleetWeaponStats(int hit, int might, int weight, int chance, float rate)
    {
        weaponHit = hit;
        weaponMight = might;
        weaponWeight = weight;
        weaponCritChance = chance;
        weaponCritRate = rate;
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
            if (Random.Range(0, 101) <= hitRate) finalHit = 1;
            if (Random.Range(0, 101) <= hitRate)
            {
                finalHit = 1;
            }
            else
            {
                if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
                else
                {
                    if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
                    else
                    {
                        if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
                        else finalHit = 0;
                    }
                }
            }
        }
        else if (hitRate > 60)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.75f;
            if (Random.Range(0, 101) <= hitRate)
            {
                finalHit = 0.75f;
            }
            else
            {
              
                if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
                else
                {
                    if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
                    else finalHit = 0;
                }
            }
        }
        else if (hitRate > 40)
        {
            if (Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
            else if (Random.Range(0, 101) <= hitRate)
            {
                finalHit = 0.50f;
            }
            else if (Random.Range(0, 101) <= hitRate)
            {
                finalHit = 0.50f;
            }
            else
            {
                if (Random.Range(0, 101) <= hitRate) finalHit = 0.25f;
                else finalHit = 0;
            }
        }
        else if (hitRate > 20)
        {
            int number = Random.Range(0, 101);
            if (number <= hitRate) finalHit = 0.25f;
            if (number <= hitRate) finalHit = 0.25f;
            if (number <= hitRate) finalHit = 0.25f;
            else finalHit = 0;
        }
        else
        {
            int number = Random.Range(0, 101);
            if (number <= hitRate) finalHit = 0.10f;
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
        allClassesBase = new List<TheClassesBase>();
        //allClassesInc = new List<TheClassesInc>();
        allClassesMods = new List<TheClassesMod>();
        allClassesMaster = new List<TheClassesMaster>();

        StatRange(7, 5, 3, 5, 2, 1);
        allClassesBase.Add(new TheClassesBase("Warrior", calcStr, calcDef, calcSpd, calcSkill, calcMagic, calcWill, 15, 5));
        //allClassesInc.Add(new TheClassesInc("Warrior", Warrior.IncList()));
        allClassesMods.Add(new TheClassesMod("Warrior", Warrior.ModList()));
        StatRange(6, 6, 5, 4, 1, 2);
        allClassesBase.Add(new TheClassesBase("Cavalier", calcStr, calcDef, calcSpd, calcSkill, calcMagic, calcWill, 15, 7));
        //allClassesInc.Add(new TheClassesInc("Cavalier", Cavalier.IncList()));
        allClassesMods.Add(new TheClassesMod("Cavalier", Cavalier.ModList()));

        for (int i = 0; i < 2; i++)
        {
            allClassesMaster.Add(new TheClassesMaster(allClassesBase[i].theClass, allClassesBase[i], allClassesMods[i]));
        }

        FindStats();

    }

    public void FindStats()
    {
        Debug.Log("gotHere");
        foreach (TheClassesMaster mas in allClassesMaster)
        {
            if (mas.className == currentClass)
            {
                if (currentClass == "Warrior")
                {
                    WarriorClass();
                }
                else if (currentClass == "Cavalier")
                {
                    CavalierClass();
                }

                if (gameObject.GetComponent<Stats>() != null)
                {
                    StartingBases(mas.baseClass.isHp, mas.baseClass.isStr, mas.baseClass.isDef, mas.baseClass.isSpd, mas.baseClass.isSkill, mas.baseClass.isMag, mas.baseClass.isWill, mas.baseClass.isMove);
                    UpdateMods(mas.modClass.isStr, mas.modClass.isDef, mas.modClass.isSpd, mas.modClass.isSkill, mas.modClass.isMag, mas.modClass.isWill);
                    //gameObject.GetComponent<Stats>().UpdateModsStat(mas.incClass.isStr, mas.incClass.isDef, mas.incClass.isSpd, mas.incClass.isSkill, mas.incClass.isMag, mas.incClass.isWill);
                }
                else
                {
                    Debug.Log("but Why");
                }


            }
        }

    }

    public void StatRange(int a, int d, int sp, int sk, int m, int w)
    {
        int max = 45;
        int min = 30;
        int temp = 0;
        int range = 4;
        bool done = false;
        do
        {
            int aTemp = a;
            calcStr = Random.Range(a, aTemp + range);
            aTemp = d;
            calcDef = Random.Range(d, aTemp + range);
            aTemp = sp;
            calcSpd = Random.Range(sp, aTemp + range);
            aTemp = sk;
            calcSkill = Random.Range(sk, aTemp + range);
            aTemp = m;
            calcMagic = Random.Range(m, aTemp + range);
            aTemp = w;
            calcWill = Random.Range(m, aTemp + range);
            temp = calcStr + calcDef + calcSpd + calcSkill + calcMagic + calcWill;

            if (temp > min && temp < max)
            {
                done = true;
            }
        } while (!done);


    }


    public void WarriorClass()
    {

        gameObject.GetComponent<Weapon>().weapon = "Long Sword";
       // Warrior.LevelUp();

    }

    public void CavalierClass()
    {

        gameObject.GetComponent<Weapon>().weapon = "Battle Axe";
      //  Cavalier.LevelUp();
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
        public string theClass = "";

        public TheClassesMod(string cas, List<float> list)
        {
            theClass = cas;
            isStr = list[0];
            isDef = list[1];
            isSpd = list[2];
            isSkill = list[3];
            isMag = list[4];
            isWill = list[5];
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
        public string theClass = "";

        public TheClassesBase(string cas, int str, int def, int spd, int skl, int mag, int will, int hp, int mo)
        {
            theClass = cas;
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
        public string className;
        public TheClassesBase baseClass;
        // public TheClassesInc incClass;
        public TheClassesMod modClass;

        public TheClassesMaster(string n, TheClassesBase b, TheClassesMod m)
        {
            baseClass = b;
            className = b.theClass;
            modClass = m;
            //  i = incClass;

        }


    }


}

