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
    public float finalHit;
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
    public static Random rng = new Random();
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
    public Button confirm;
    public Button cancel;
    // Use this for initialization
    void Start()
    {
        confirm = GameObject.Find("AttackConfirm").GetComponent<Button>();
        cancel = GameObject.Find("AttackCancel").GetComponent<Button>();
        confirm.onClick.AddListener(ButtonTrue);
        cancel.onClick.AddListener(ButtonFalse);
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

        confirm.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);

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

        AttackPreview(attacker);
    }

    public void AttackContinue(Stats attacker)
    {
        PlayerDamaged(attacker);
        EnemyDamaged(attacker);
        if ((attacker.spd - weaponWeight) - (spd - weaponWeight) >= 3)
        {
            PlayerDamaged(attacker);
        }
        else if ((spd - weaponWeight) - (attacker.spd - weaponWeight) >= 3) EnemyDamaged(attacker);

        GameObject.FindObjectOfType<MapManager>().PlayerAttackTrue();
    }


    public void Death()
    {
        GameObject.Destroy(gameObject);
    }

    public void OnDestroy()
    {
        GameObject.FindObjectOfType<SpeedCenterTurns>().UpdateList();
    }


    public void AttackPreview(Stats attacker)
    {
        int eDamage = EnemyAttack(attacker);
        int pDamage = PlayerAttack(attacker);
        int eHit = EnemyHit(attacker);
        int pHit = PlayerHit(attacker);
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

        confirm.gameObject.SetActive(true);
        cancel.gameObject.SetActive(true);
        StartCoroutine(WaitTilConfirm(attacker));

    }

    private IEnumerator WaitTilConfirm(Stats attacker)
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

    public void ExitAttack()
    {
        GameObject.FindObjectOfType<MapManager>().AttackFalse();
    }

    public void ButtonFalse()
    {
       done = true;
       go = false;
       confirm.gameObject.SetActive(false);
       cancel.gameObject.SetActive(false);
    }

    public void ButtonTrue()
    {
        done = true;
        go = true;
        confirm.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
    }


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
        else currentHp = currentHp - 1;

        if (currentHp <= 0) Death();
    }


    public void EnemyDamaged(Stats attacker)
    {

        playerHitRate = (int)CalcHitRate(attacker.spd, attacker.weaponWeight);
        basePlayerHit = playerHitRate;
        int totalAtk = str + weaponMight;
        enemyDamage = totalAtk - attacker.def;
        float hurt = enemyDamage * CalcFinalHit(playerHitRate);
        int newDamage = CalcCrit(hurt, weaponCritRate + critRate, weaponCritChance + critChance); 
        enemyDamage = newDamage;
        Debug.Log(gameObject.name + "lost " + enemyDamage + " HP" + " Normal Atk was" + totalAtk + "-" + def);

        if (enemyDamage > 0)
            attacker.currentHp = attacker.currentHp - enemyDamage;
        else attacker.currentHp = attacker.currentHp - 1;

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

        if (hitRate > 80)
        {
            Debug.Log("is this Random " + Random.Range(0, 101));
            Debug.Log("is this Random1 " + Random.Range(0, 101));
            Debug.Log("is this Random2 " + Random.Range(0, 101));
            Debug.Log("is this Random3 " + Random.Range(0, 101));
            Debug.Log("is this Random4 " + Random.Range(0, 101));
          
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

