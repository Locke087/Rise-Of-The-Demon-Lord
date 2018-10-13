using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : Weapon
{

    public int hp;
    public int str;
    public int def;
    public int spd;
    public int skill;
    public int mag;
    public int will;
    public int movement;
    public float FinalHit;
    public int currentHp;
    public Text showHp;
    public int weight;
    public int level;
    public int levelBoost;
    public bool promote = false;
    public int enemyDamage;
    public int damage;
    public int enemyHitRate;
    public int playerHitRate;
    public int baseEnemyHit;
    public int basePlayerHit;
    GridMovement gridMove;
    public List<CharacterSheet> characterSheet;
    public int hpMod;
    public int strMod;
    public int defMod;
    public int spdMod;
    public int skillMod;
    public int movementMod;
    public List<TheNatures> allNatures;

    public int weaponWeight = 0;
    public int weaponMight = 0;
    public int weaponHit = 0;
    public string nature;

    public bool skip = false;

    // Use this for initialization
    void Start()
    {

        currentHp = hp;
        //                                    spd|str|def|skl|Hp |order
        allNatures.Add(new TheNatures("Nimble", 2, 1, 0, 1, 1, 0)); //+spd -def 
        allNatures.Add(new TheNatures("Tough", 0, 1, 2, 1, 1, 1)); //+def -spd 
        allNatures.Add(new TheNatures("Strong", 0, 2, 1, 1, 1, 2)); //+str -spd 
        allNatures.Add(new TheNatures("Aggressive", 1, 2, 1, 0, 1, 3)); //+str -def 
        allNatures.Add(new TheNatures("Handy", 1, 1, 1, 2, 0, 4)); //+skl -hp 
        allNatures.Add(new TheNatures("Hardy", 0, 1, 1, 1, 2, 5)); //+hp -spd
        Debug.Log("good day");
        promote = false;
        if (nature == null) nature = "neutral";
        statAssign(this);
        currentHp = hp;
        hp += hpMod;
        def += defMod;
        str += strMod;
        spd += spdMod;
        skill += skillMod;
        movement += movementMod;

      
        if (gameObject.GetComponent<MCMove>() != null)
            gridMove = gameObject.GetComponent<MCMove>();
        else if (gameObject.GetComponent<PlayerUnit>() != null)
            gridMove = gameObject.GetComponent<PlayerUnit>();
        else if (gameObject.GetComponent<EnemyMove>() != null)
            gridMove = gameObject.GetComponent<EnemyMove>();
        gameObject.GetComponent<GridMovement>();
        gridMove.move += movement;
        movement = gridMove.move;
        weaponStats();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /*if (gameObject.GetComponent<MCMove>() != null)
            if (gameObject.GetComponent<MCMove>().activePlayer == true)
                if (showHp != null) showHp.text = currentHp.ToString();

        if (gameObject.GetComponent<PlayerUnit>() != null)
            if (gameObject.GetComponent<PlayerUnit>().activePlayer == true)
                if (showHp != null) showHp.text = currentHp.ToString();

        if (gameObject.GetComponent<EnemyMove>() != null)
            if (gameObject.GetComponent<EnemyMove>().activeOnBoard == true)
                if (gameObject.GetComponent<EnemyMove>().activeEnemy == true)
                    if (showHp != null) showHp.text = currentHp.ToString();

        if (promote == true) classChange();*/


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

    public void Booster()
    {

        if (levelBoost > 0)
        {

            for (int i = 0; i < levelBoost; i++)
            {
                levelUp();
                level++;
            }
            levelBoost = 0;
            if (hp > currentHp)
                currentHp = hp;
        }

    }

    public void attacked(Stats attacker)
    {
        GameObject.Find("AtkHp").GetComponent<Text>().text = attacker.currentHp.ToString();
        GameObject.Find("DefHp").GetComponent<Text>().text = currentHp.ToString();
        PlayerDamaged(attacker);
        EnemyDamaged(attacker);
        if ((attacker.spd - weaponWeight) - (spd - weaponWeight) >= 3)
        {
            PlayerDamaged(attacker);
        }
        else if ((spd - weaponWeight) - (attacker.spd - weaponWeight) >= 3) EnemyDamaged(attacker);


    }


    public void Death()
    {
        GameObject.Destroy(gameObject);
    }

    public void OnDestroy()
    {
        GameObject.FindObjectOfType<SpeedCenterTurns>().UpdateList();
    }

    public void PlayerDamaged(Stats attacker)
    {
        //total atk includes weapons
        enemyHitRate = (int)CalcEnemyHitRate(attacker.skill, attacker.weaponHit);
        baseEnemyHit = enemyHitRate;
        int totalAtk = attacker.str + attacker.weaponMight;
        damage = totalAtk - def;
        float hurt = damage * CalcFinalHit(enemyHitRate);
        int newDamage = (int)hurt;
        damage = newDamage;

        Debug.Log(gameObject.name + "lost " + damage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        if (damage > 0)
            currentHp = currentHp - damage;
        else currentHp = currentHp - 1;

        if (currentHp < 0) Death();
    }


    public void EnemyDamaged(Stats attacker)
    {

        playerHitRate = (int)CalcHitRate(attacker.spd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = str + weaponMight;
        enemyDamage = totalAtk - attacker.def;
        float hurt = enemyDamage * CalcFinalHit(playerHitRate);
        int newDamage = (int)hurt;
        enemyDamage = newDamage;

        Debug.Log(gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + def);
        if (enemyDamage > 0)
            attacker.currentHp = attacker.currentHp - enemyDamage;
        else attacker.currentHp = attacker.currentHp - 1;

        if (attacker.currentHp < 0) attacker.Death();
    }

    public void SetMeleetWeaponStats(int hit, int might, int weight)
    {
        weaponHit = hit;
        weaponMight = might;
        weaponWeight = weight;
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
        FinalHit = 0;

        if (hitRate > 80)
        {

            int number = Random.Range(0, 100);
            if (number <= hitRate) FinalHit = 1;
            else if (Random.Range(0, 100) <= hitRate)
            {
                FinalHit = 1;
            }
            else if (Random.Range(0, 100) <= hitRate)
            {
                FinalHit = 1;
            }
            else
            {
                number = Random.Range(0, 100);
                if (number <= 80) FinalHit = 0.75f;
                else if (Random.Range(0, 100) <= 80)
                {
                    FinalHit = 1;
                }
                else
                {
                    number = Random.Range(0, 100);
                    if (number <= 60) FinalHit = 0.50f;
                    else
                    {
                        number = Random.Range(0, 100);
                        if (number <= 40) FinalHit = 0.25f;
                        else FinalHit = 0;
                    }
                }
            }
        }
        else if (hitRate > 60)
        {
            int number = Random.Range(0, 100);
            if (number <= hitRate) FinalHit = 0.75f;
            else if (Random.Range(0, 100) <= hitRate)
            {
                FinalHit = 1;
            }
            else
            {
                number = Random.Range(0, 100);
                if (number <= 60) FinalHit = 0.50f;
                else
                {
                    number = Random.Range(0, 100);
                    if (number <= 40) FinalHit = 0.25f;
                    else FinalHit = 0;
                }
            }
        }
        else if (hitRate > 40)
        {
            int number = Random.Range(0, 100);
            if (number <= hitRate) FinalHit = 0.50f;
            else if (Random.Range(0, 100) <= hitRate)
            {
                FinalHit = 1;
            }
            else
            {
                number = Random.Range(0, 100);
                if (number <= 40) FinalHit = 0.25f;
                else FinalHit = 0;
            }
        }
        else if (hitRate > 20)
        {
            int number = Random.Range(0, 100);
            if (number <= hitRate) FinalHit = 0.25f;
            else FinalHit = 0;
        }
        else
        {
            int number = Random.Range(0, 100);
            if (number <= hitRate) FinalHit = 0.10f;
            else FinalHit = 0;
        }
        return FinalHit;
    }

    void levelUp()
    {
        foreach (CharacterSheet ch in characterSheet)
        {
            if (ch.level == level)
            {
                int modStr = 0;
                int modSpd = 0;
                int modHp = 0;
                int modDef = 0;
                int modSkl = 0;
                foreach (TheNatures na in allNatures)
                {
                    if (na.natures == nature)
                    {
                        modStr = na.isStr;
                        modDef = na.isDef;
                        modHp = na.isHp;
                        modSpd = na.isSpd;
                        modSkl = na.isSkill;
                    }
                }

                if (ch.isStr) str += Random.Range(0, 3) + modStr;
                if (ch.isSpd) spd += Random.Range(0, 3) + modSpd;
                if (ch.isHp) hp += Random.Range(0, 3) + modHp;
                if (ch.isDef) def += Random.Range(0, 3) + modDef;
                if (ch.isSkill) skill += Random.Range(0, 3) + modSkl;
            }


        }
    }

    void classChange()
    {
        classSearch();
        level = 1;
        levelBoost = 0;
        hp += hpMod;
        def += defMod;
        str += strMod;
        spd += spdMod;
        skill = skillMod;
        movement += movementMod;
        gridMove.move = movement;


        promote = false;

    }

    void classSearch()
    {
        if (gameObject.GetComponent<MCLeaderClassModifer>() != null)
        {
            gameObject.AddComponent<MCGeneralClassMod>();
            gameObject.GetComponent<MCGeneralClassMod>().stats = this;
            Destroy(gameObject.GetComponent<MCLeaderClassModifer>());
        }
        else if (gameObject.GetComponent<HorseClassModifers>() != null)
        {
            gameObject.AddComponent<WarHorseClassMod>();
            gameObject.AddComponent<WarHorseClassMod>().stats = this;
            Destroy(gameObject.GetComponent<HorseClassModifers>());
        }



    }

    [System.Serializable]
    public class TheNatures
    {
        public int isSpd;
        public int isStr;
        public int isDef;
        public int isSkill;
        public int isHp;
        public string natures;
        public int listedOrder;

        public TheNatures(string n, int spd, int str, int def, int skl, int hp, int ord)
        {
            natures = n;
            isSpd = spd;
            isStr = str;
            isDef = def;
            isSkill = skl;
            isHp = hp;
            listedOrder = ord;
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

}

