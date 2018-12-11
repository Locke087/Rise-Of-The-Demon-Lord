using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{
    public InfoForUnit info;
    public string unitID;
    public string unitIdx;
    public Image mapImage;
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

    public int effectStr;
    public int effectDef;
    public int effectSpd;
    public int effectSkill;
    public int effectMagic;
    public int effectWill;

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
    public bool poison = false;
    public bool sleep = false;
    public bool hobble = false;
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
    public string affinity;
    public float attackBonus;
    public float strBoost;
    public float spdBoost;
    public float defBoost;
    public float skillBoost;
    public float magBoost;
    public float willBoost;
    public float attackReduce;
    public float strReduce;
    public float spdReduce;
    public float defReduce;
    public float skillReduce;
    public float magReduce;
    public float willReduce;
    public bool beneficial = false;
    public bool enmity = false;
    public UnitSkillDetail currentAttack;
    public UnitAssessory currentAssessory1;
    public UnitAssessory currentAssessory2;
    public UnitAssessory currentAssessory3;
    public List<ActiveEffects> activeEffects;
    public UnitWeaponDetails theWeapon;
    public List<WeaknessChart> weaknessChart;
    void Start()
    {
        allNatures = new List<TheNatures>();
        weaknessChart = new List<WeaknessChart>();
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
        allNatures.Add(new TheNatures("Hulk", 1, 3, 1, 1, 0, 1, 1)); //+str -hp 
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

        weaknessChart.Add(new WeaknessChart("Dark", "b", "n", "n", "n", "n", "n", "e"));
        weaknessChart.Add(new WeaknessChart("Light", "e", "n", "n", "n", "n", "n", "b"));
                                                  //  d    n    m    f    w    e    l
        weaknessChart.Add(new WeaknessChart("Water", "n", "n", "n", "n", "b", "e", "n"));
        weaknessChart.Add(new WeaknessChart("Fire", "n", "n", "e", "n", "n", "b", "n"));
        activeEffects = new List<ActiveEffects>();
        attackBonus = 0;
        strBoost = 0;
        defBoost = 0;
        spdBoost = 0;
        skillBoost = 0;      
        magBoost = 0;
        willBoost = 0;
        if (nature == null) nature = "Neutral";
        currentHp = hp;
       
        startClassesUp();
        currentAssessory1 = new UnitAssessory();
        currentAssessory2 = new UnitAssessory();
        currentAssessory3 = new UnitAssessory();

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
            gameObject.GetComponent<MapEnemyMove>().oldmove = movement;
        }

      //  mapImage.sprite = Resources.Load<Sprite>(FindMyself().unitActor.neutralPortrait.personalID);
        // gameObject.GetComponent<Weapon>().weaponStats();

        //confirm.gameObject.SetActive(false);
        //cancel.gameObject.SetActive(false);
       // FindStats();
        ReflectStat();
        // Booster();
        UpdateHp();
        StartCoroutine(RefreshStat());
    }

    public void HealHp(int num)
    {
        if (currentHp == hp)
        {
            info.attackText.text = "Full Hp";
            StartCoroutine(ClearNoticeText());
        }
        if (currentHp + num > hp)
        {
            info.attackText.faceColor = Color.green;
            info.attackText.text = hp.ToString() + " Hp Now Full";
            currentHp = hp;
            UpdateHp();
            StartCoroutine(ClearNoticeText());
        }
        else
        {

            info.attackText.faceColor = Color.green;
            info.attackText.text = hp.ToString() + " Healed";
            currentHp += num;
            UpdateHp();
            StartCoroutine(ClearNoticeText());
        }
    }

    public void DamageHp(int num, float type)
    {
        info.attackText.faceColor = Color.red;
        info.attackText.text = num.ToString();
        if (info.attackText.text != "")
        {
            if (type == 1) info.attackText.text = num.ToString() + " Incredible Hit 100% Dmg";
            else if (type == 0.75f) info.attackText.text = num.ToString() + " Great Hit 75% Dmg";
            else if (type == 0.50f) info.attackText.text = num.ToString() + " Nice Hit 50% Dmg";
            else if (type == 0.25f) info.attackText.text = num.ToString() + " Nearly Missed 25% Dmg";
            else if (type == 0.10f) info.attackText.text = num.ToString() + " Poor Hit 10% Dmg";
            else if (type == 0) info.attackText.text = num.ToString() + " Missed 0% Dmg";
        }
        else
        {
            if (type == 1) info.lowattackText.text = num.ToString() + " Incredible Hit 100% Dmg";
            else if (type == 0.75f) info.lowattackText.text = num.ToString() + " Great Hit 75% Dmg";
            else if (type == 0.50f) info.lowattackText.text = num.ToString() + " Nice Hit 50% Dmg";
            else if (type == 0.25f) info.lowattackText.text = num.ToString() + " Nearly Missed 25% Dmg";
            else if (type == 0.10f) info.lowattackText.text = num.ToString() + " Poor Hit 10% Dmg";
            else if (type == 0) info.lowattackText.text = num.ToString() + " Missed 0% Dmg";
        }
        StartCoroutine(ClearNoticeText());      
    }

    public void PoisonDamage()
    {
        int num = 0;
        num = (int)(hp * 0.15f);
        info.attackText.faceColor = Color.magenta;
        info.attackText.text = num.ToString() + " Poison Damage";
        currentHp = currentHp - num;
        if (currentHp < 0) currentHp = 0;
        UpdateHp();
        if (currentHp <= 0) Death();
        StartCoroutine(ClearNoticeText());
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
        yield return new WaitForSeconds(4f);
        classesRefresh();
        ActivateAssessories();
        ReflectStat();
        UpdateHp();
    }

    public IEnumerator ClearNoticeText()
    {
        yield return new WaitForSeconds(2f);
        info.attackText.text = "";
        info.lowattackText.text = "";
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
        EffectiveStats();
        if (gameObject.tag == "player")
        {
            UnitWeapon aWeapon = gameObject.GetComponent<MapPlayerAttack>().weapon;
            UnitWeapon bWeapon = attacker.GetComponent<MapEnemyMove>().weapon;
          
            attackedControl(attacker, bWeapon, aWeapon);
        }
        else
        {
            UnitWeapon bWeapon = gameObject.GetComponent<MapEnemyMove>().weapon;
            UnitWeapon aWeapon = attacker.GetComponent<MapPlayerAttack>().weapon;
            attackedControl(attacker, aWeapon, bWeapon);
        }
    }

    public void EffectGoAway(string which)
    {
        if (which == "strBoost") strBoost = 0;
        else if (which == "defBonus") defBoost = 0;
        else if (which == "spdBoost") spdBoost = 0;
        else if (which == "skillBoost") skillBoost = 0;
        else if (which == "magBoost") magBoost = 0;
        else if (which == "willBoost") willBoost = 0;
        else if (which == "strReduce") strReduce = 0;
        else if (which == "defReduce") defReduce = 0;
        else if (which == "spdReduce") spdReduce = 0;
        else if (which == "skillReduce") skillReduce = 0;
        else if (which == "magReduce") magReduce = 0;
        else if (which == "willReduce") willReduce = 0;
        else if (which == "sleep") sleep = false;
        else if (which == "poison") poison = false;
        else if (which == "movementDown") hobble = false;
    }



    public void StatusEffect(string which, int num)
    {
        if (which == "strBoost") strBoost = num;
        else if (which == "defBonus") defBoost = num;
        else if (which == "spdBoost") spdBoost = num;
        else if (which == "skillBoost") skillBoost = num;
        else if (which == "magBoost") magBoost = num;
        else if (which == "willBoost") willBoost = num;
        else if (which == "strReduce") strReduce = num;
        else if (which == "defReduce") defReduce = num;
        else if (which == "spdReduce") spdReduce = num;
        else if (which == "skillReduce") skillReduce = num;
        else if (which == "magReduce") magReduce = num;
        else if (which == "willReduce") willReduce = num;
        else if (which == "sleep") sleep = true;
        else if (which == "poison") poison = true;
        else if (which == "movementDown") hobble = true;
    }
    public void LowerCounter(string which)
    {
        if (activeEffects.Exists(x => x.name == which))
        {
            activeEffects.Find(x => x.name == which).timer--;
            if (activeEffects.Find(x => x.name == which).timer <= 0) EffectGoAway(which);
        }
    }

  


    public void EffectiveStats()
    {
        // attackBonus = 0;
        int tempA = 0;
        int tempB = 0;
        //str
        if(strBoost != 0) tempA = (int)(str * (1 + strBoost));
        if (strReduce != 0) tempB = (int)(str * strReduce);

        if (tempA != 0 && tempB == 0) effectStr = tempA;
        else if (tempA == 0 && tempB != 0) effectStr = tempB;
        else if (tempA - tempB > 0) effectStr = tempA - tempB;
        else effectStr = str;

        //def
        if (defBoost != 0) tempA = (int)(def * (1 + defBoost));
        if (defReduce != 0) tempB = (int)(def * defReduce);

        if (tempA != 0 && tempB == 0) effectDef = tempA;
        else if (tempA == 0 && tempB != 0) effectDef = tempB;
        else if (tempA - tempB > 0) effectDef = tempA - tempB;
        else effectDef = def;

        //spd
        if (spdBoost != 0) tempA = (int)(spd * (1 + spdBoost));
        if (spdReduce != 0) tempB = (int)(spd * spdReduce);

        if (tempA != 0 && tempB == 0) effectSpd = tempA;
        else if (tempA == 0 && tempB != 0) effectSpd = tempB;
        else if (tempA - tempB > 0) effectSpd = tempA - tempB;
        else effectSpd = spd;

        //skill
        if (skillBoost != 0) tempA = (int)(skill * (1 + skillBoost));
        if (skillReduce != 0) tempB = (int)(skill * skillReduce);

        if (tempA != 0 && tempB == 0) effectSkill = tempA;
        else if (tempA == 0 && tempB != 0) effectSkill = tempB;
        else if (tempA - tempB > 0) effectSkill = tempA - tempB;
        else effectSkill = skill;

        //mag
        if (magBoost != 0) tempA = (int)(magic * (1 + magBoost));
        if (magReduce != 0) tempB = (int)(magic * magReduce);

        if (tempA != 0 && tempB == 0) effectMagic = tempA;
        else if (tempA == 0 && tempB != 0) effectMagic = tempB;
        else if (tempA - tempB > 0) effectMagic = tempA - tempB;
        else effectMagic = magic;

        //will
        if (willBoost != 0) tempA = (int)(will * (1 + willBoost));
        if (willReduce != 0) tempB = (int)(will * willReduce);

        if (tempA != 0 && tempB == 0) effectWill = tempA;
        else if (tempA == 0 && tempB != 0) effectWill = tempB;
        else if (tempA - tempB > 0) effectWill = tempA - tempB;
        else effectWill = will;
    }


    public void attackedControl(Stats attacker, UnitWeapon weaponAtk, UnitWeapon weaponDef)
    {
        //AttackPreview(attacker);
        int aAttackSpeed = effectSpd - weaponWeight;
        int dAttackSpeed = attacker.effectSpd - attacker.weaponWeight;

        if(weaponAtk.details.physical) DefenderDamaged(attacker);
        else DefenderMagDamaged(attacker);
        if ((aAttackSpeed) < 0) aAttackSpeed = 0;
        if ((dAttackSpeed) < 0) dAttackSpeed = 0;
        //Double Attack if: (Attack Speed – enemy Attack Speed) >= 4
        if ((aAttackSpeed - dAttackSpeed) >= 4 && currentHp >= 0 && attacker.currentHp >= 0)
        {
            if (weaponAtk.details.physical) DefenderDamaged(attacker);
            else DefenderMagDamaged(attacker);
        }
        else if ((dAttackSpeed - aAttackSpeed) >= 4 && currentHp >= 0 && attacker.currentHp >= 0)
        {
            if (!attacker.sleep)
            {
                if (weaponDef.details.physical) AttackerDamaged(attacker);
                else AttackerMagDamaged(attacker);
            }
        }

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
            GameObject.Find("AtkCritS").GetComponent<Text>().text = "Crit!";
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
            GameObject.Find("DefCritS").GetComponent<Text>().text = "Crit!";
            
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
        GameObject.Find("AtkHitP").GetComponent<Text>().text = "0";
        GameObject.Find("AtkHitP2").GetComponent<Text>().text = "0";
        GameObject.Find("DefHitP").GetComponent<Text>().text = "0";
        GameObject.Find("DefHitP2").GetComponent<Text>().text = "0";
        GameObject.Find("DefCritS").GetComponent<Text>().text = "";
        GameObject.Find("AtkCritS").GetComponent<Text>().text = "";

    }

    public void UpdateHp()
    {
        if (info.hpText != null) info.hpText.text = currentHp.ToString(); 
    }

    public void StealInfo(int num)
    {

        info.attackText.faceColor = Color.red;
        StartCoroutine(ClearNoticeText());


    }
    public void AffityBonus(string compare)
    {

    }


    public void Skill(Stats attacker)
    {
        attackBonus = 0;
        EffectiveStats();
        if (currentAttack.effects.poison)
        {
            if (StatusHitEnemy(attacker))
            {
                activeEffects.Add(new ActiveEffects("poison", 3));
                poison = true;
            }
        }
        if (currentAttack.effects.sleep)
        {
            if (StatusHitEnemy(attacker))
            {
                activeEffects.Add(new ActiveEffects("sleep", 3));
                sleep = true;
            }
        }
        if (currentAttack.effects.movementDown)
        {
            if (StatusHitEnemy(attacker))
            {
                activeEffects.Add(new ActiveEffects("hobble", 3));
                hobble = true;
            }
        }
        if (currentAttack.effects.reduceAttack) 
        {
            if (StatusHitEnemy(attacker))
            {
                activeEffects.Add(new ActiveEffects("strReduce", 3));
                strReduce = 0.15f;
            }
        }
        if (currentAttack.effects.reduceDefense)
        {
            if (StatusHitEnemy(attacker))
            {
                activeEffects.Add(new ActiveEffects("defReduce", 3));
                defReduce = 0.15f;
            }
        }
      /*  if (currentAttack.effects.)
        {
            if (StatusHitEnemy(attacker)) sdpReduce = 0.15f;
        }*/
        if (currentAttack.physicalDamage)
        {
            if (currentAttack.effects.stealMoney)
            {
                attacker.StealInfo(currentAttack.baseEffect);
                DefenderDamaged(attacker);
            }
            if (currentAttack.effects.fireDamage && affinity == "Wood")
            {
             
                attacker.attackBonus = 0.5f;
              
                DefenderDamaged(attacker);
            }
            else if (currentAttack.effects.fireDamage && affinity == "Wood")
            {
              // Bad Match Up
                attacker.attackBonus = 0.5f;
            }
          
        }
        else if (currentAttack.magicDamage)
        {
            if (currentAttack.effects.fireDamage && affinity == "Wood")
            {
                attacker.attackBonus = 1.5f;
            }
            DefenderMagDamaged(attacker);
        }
        else if (currentAttack.support)
        {
       
            if (currentAttack.effects.healing)
            {
                if (affinity != "Undead")
                {
                    currentHp +=  magic/2;
                    HealHp(magic / 2);
                    UpdateHp();
                }
                else
                {
                    currentHp -= magic / 2;
                    HealHp(magic / 2);
                    if (currentHp < 0) currentHp = 0;
                    UpdateHp();
                    if (currentHp <= 0) Death();
                  
                }
            }

            if (currentAttack.effects.revive)
            {
               
                if (affinity != "Undead")
                {
                    if (dead)
                    {
                        dead = false;
                        currentHp += magic / 2;
                        gameObject.SetActive(true);
                        HealHp(magic / 2);
                        UpdateHp();
                    }
                    else
                    {
                        currentHp += magic / 2;
                        HealHp(magic / 2);
                        UpdateHp();
                    }
                }
                else
                {
                    currentHp -= magic / 2;
                    if (currentHp < 0) currentHp = 0;
                    HealHp(currentAttack.restore);
                    UpdateHp();
                    if (currentHp <= 0) Death();
                 
                }
            }
          
        }
    }

    public void WeaponEffects(Stats attacker)
    {
      int hitE = (int)CalcStatusHitE(attacker.will, attacker.weaponHit);
      int hitP = (int)CalcStatusHit(attacker.spd, attacker.weaponWeight);
        if(CalcIfHit(hitE))
        {
          //  attacker.
        }
        if (CalcIfHit(hitE))
        {

        }
    }

    public bool StatusHitEnemy(Stats attacker)
    {
        int hitE = (int)CalcStatusHitE(attacker.will, attacker.weaponHit);
        //int hitP = (int)CalcStatusHit(attacker.spd, attacker.weaponWeight);
        if (CalcIfHit(hitE))
        {
            return true;
        }
        return true;
    }

    public float CalcStatusHit(int enemySpd, int enemyWeaponWeight)
    {
        float accurary = weaponHit + (will * 2);
        float avoid = (enemySpd - enemyWeaponWeight) * 2;
        float hit = accurary - avoid;

        return hit;
        //where hitRate will be calculated
    }

    public float CalcStatusHitE(int enemyWill, int enemyWeaponHit)
    {
        float accurary = enemyWeaponHit + (enemyWill * 2);
        float avoid = (spd - weaponWeight) * 2;
        float hit = accurary - avoid;

        return hit;
        //where hitRate will be calculated
    }

    public bool CalcIfHit(int hitRate)
    {
        if (hitRate >= 100) return true;
        if (Random.Range(0, 101) <= hitRate) return true;
        if (Random.Range(0, 101) <= hitRate) return true;
        return false;
    }

    public void DefenderDamaged(Stats attacker)
    {
       
        //total atk includes weapons
        enemyHitRate = (int)CalcEnemyHitRate(attacker.effectSkill, attacker.weaponHit);
        baseEnemyHit = enemyHitRate;
        int totalAtk = attacker.effectStr + attacker.weaponMight;
        damage = totalAtk  - effectDef;
        if (attackBonus != 0) damage = (int)(totalAtk * attacker.attackBonus) - effectDef;
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
        DamageHp(damage, reduce);
        UpdateHp();
        Debug.Log(gameObject.name + "lost " + damage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        Debug.Log("Is Now This Much HP: " + currentHp);
        if (GameObject.Find("AtkTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("AtkTD2").GetComponent<Text>().text = damage.ToString();
        }
        else
        {
            GameObject.Find("AtkTD").GetComponent<Text>().text = damage.ToString();
        }

        if (GameObject.Find("AtkHitP").GetComponent<Text>().text != "0")
        {
            GameObject.Find("AtkHitP2").GetComponent<Text>().text = reduce.ToString();
        }
        else
        {
            GameObject.Find("AtkHitP").GetComponent<Text>().text = reduce.ToString();
        }

        GameObject.Find("AtkHp").GetComponentInChildren<Text>().text = currentHp.ToString();
        

        if (currentHp <= 0) Death();
    }


    public void AttackerDamaged(Stats attacker)
    {
      
        playerHitRate = (int)CalcHitRate(attacker.effectSpd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = effectStr + weaponMight;
        enemyDamage = totalAtk - attacker.effectDef;
        if (attackBonus != 0) enemyDamage = (int)(totalAtk * attackBonus) - attacker.effectDef;
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
        attacker.DamageHp(enemyDamage, reduce);
        attacker.UpdateHp();
        Debug.Log(attacker.gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        Debug.Log("Is Now This Much HP: " + attacker.currentHp);
        if (GameObject.Find("DefTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("DefTD2").GetComponent<Text>().text = enemyDamage.ToString();
        }
        else
        {
            GameObject.Find("DefTD").GetComponent<Text>().text = enemyDamage.ToString();
        }

        if (GameObject.Find("DefHitP").GetComponent<Text>().text != "0")
        {
            GameObject.Find("DefHitP2").GetComponent<Text>().text = reduce.ToString();
        }
        else
        {
            GameObject.Find("DefHitP").GetComponent<Text>().text = reduce.ToString();
        }

        GameObject.Find("DefHp").GetComponentInChildren<Text>().text = attacker.currentHp.ToString();
        if (attacker.currentHp < 0) attacker.currentHp = 0;
        if (attacker.currentHp <= 0) attacker.Death();
    }


    public void DefenderMagDamaged(Stats attacker)
    {
        //total atk includes weapons
       
        enemyHitRate = (int)CalcEnemyHitRate(attacker.effectSkill, attacker.weaponHit);
        baseEnemyHit = enemyHitRate;
        int totalAtk = attacker.effectMagic + attacker.weaponMight;
        damage = totalAtk - effectWill;
        if (attacker.attackBonus != 0) damage = (int)(totalAtk * attacker.attackBonus) - effectWill;
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
        DamageHp(damage, reduce);
        UpdateHp();
        Debug.Log(gameObject.name + "lost " + damage + " HP" + " Normal Atk was" + totalAtk + "-" + will);
        Debug.Log("Is Now This Much HP: " + currentHp);
        if (GameObject.Find("AtkTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("AtkTD2").GetComponent<Text>().text = damage.ToString();
        }
        else
        {
            GameObject.Find("AtkTD").GetComponent<Text>().text = damage.ToString();
        }

        if (GameObject.Find("AtkHitP").GetComponent<Text>().text != "0")
        {
            GameObject.Find("AtkHitP2").GetComponent<Text>().text = reduce.ToString();
        }
        else
        {
            GameObject.Find("AtkHitP").GetComponent<Text>().text = reduce.ToString();
        }

        GameObject.Find("AtkHp").GetComponentInChildren<Text>().text = currentHp.ToString();

        if (currentHp < 0) currentHp = 0;
        if (currentHp <= 0) Death();
    }


    public void AttackerMagDamaged(Stats attacker)
    {

        playerHitRate = (int)CalcHitRate(attacker.effectSpd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = effectMagic + weaponMight;
        enemyDamage = totalAtk - attacker.effectWill;
        if (attackBonus != 0) enemyDamage = (int)(totalAtk * attackBonus) - attacker.effectWill;
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
        attacker.DamageHp(enemyDamage, reduce);
        attacker.UpdateHp();
       
        Debug.Log(attacker.gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + will);
        Debug.Log("Is Now This Much HP: " + attacker.currentHp);
        if (GameObject.Find("DefTD").GetComponent<Text>().text != "0")
        {
            GameObject.Find("DefTD2").GetComponent<Text>().text = enemyDamage.ToString();
        }
        else
        {
            GameObject.Find("DefTD").GetComponent<Text>().text = enemyDamage.ToString();
        }

        if (GameObject.Find("DefHitP").GetComponent<Text>().text != "0")
        {
            GameObject.Find("DefHitP2").GetComponent<Text>().text = reduce.ToString();
        }
        else
        {
            GameObject.Find("DefHitP").GetComponent<Text>().text = reduce.ToString();
        }

        GameObject.Find("DefHp").GetComponentInChildren<Text>().text = attacker.currentHp.ToString();

        if (attacker.currentHp <= 0) attacker.Death();
    }

    public void SetMeleetWeaponStats( )
    {
        Unit me = FindMyself();
        if (me.inventory.invSlot1.weapon.equipped)
        {
            theWeapon = me.inventory.invSlot1.weapon.details;
            weaponHit = me.inventory.invSlot1.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot1.weapon.details.might;
            weaponWeight = me.inventory.invSlot1.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot1.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot1.weapon.details.critrate;
        }
        else if (me.inventory.invSlot2.weapon.equipped)
        {
            theWeapon = me.inventory.invSlot2.weapon.details;
            weaponHit = me.inventory.invSlot2.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot2.weapon.details.might;
            weaponWeight = me.inventory.invSlot2.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot2.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot2.weapon.details.critrate;
        }
        else if (me.inventory.invSlot3.weapon.equipped)
        {
            theWeapon = me.inventory.invSlot3.weapon.details;
            weaponHit = me.inventory.invSlot3.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot3.weapon.details.might;
            weaponWeight = me.inventory.invSlot3.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot3.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot3.weapon.details.critrate;
        }
        else if (me.inventory.invSlot4.weapon.equipped)
        {
            theWeapon = me.inventory.invSlot4.weapon.details;
            weaponHit = me.inventory.invSlot4.weapon.details.hitrate;
            weaponMight = me.inventory.invSlot4.weapon.details.might;
            weaponWeight = me.inventory.invSlot4.weapon.details.weight;
            weaponCritChance = me.inventory.invSlot4.weapon.details.critchance;
            weaponCritRate = me.inventory.invSlot4.weapon.details.critrate;
        }
        else if (me.inventory.invSlot5.weapon.equipped)
        {
            theWeapon = me.inventory.invSlot5.weapon.details;
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
            else if(Random.Range(0, 101) <= hitRate) finalHit = 0.50f;
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
    
        allClassesMods = new List<TheClassesMod>();
        allClassesMaster = new List<TheClassesMaster>();

        //  StatRange(me.unitInfo.bases);
        Debug.Log(me.unitInfo.bases.Count + " frhhfkewnf");
        allClassesBase.Add(new TheClassesBase(me.unitInfo.bases[0], me.unitInfo.bases[1], me.unitInfo.bases[2], me.unitInfo.bases[3], me.unitInfo.bases[4], me.unitInfo.bases[5], 15, me.unitInfo.main.movement));
   
        allClassesCaps.Add(new TheClassesCap(me.unitInfo.main.caps));
        allClassesMods.Add(new TheClassesMod(me.unitInfo.main.modifiers));

  
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
            int aTemp = all[0] ;
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
    public class WeaknessChart
    {
        public string name;
        public string dark;
        public string nature;
        public string metal;
        public string fire;
        public string earth;
        public string water;
        public string light;

        public WeaknessChart(string nam, string dar, string nat, string met, string fir, string wat, string ear, string lig)
        {
            name = nam;
            dark = dar;
            nature = nat;
            metal = met;
            fire = fir;
            light = lig;
            earth = ear;
            water = wat;
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

