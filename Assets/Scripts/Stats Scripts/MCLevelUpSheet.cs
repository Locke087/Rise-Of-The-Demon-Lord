using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //This allows the IComparable Interface

public class MCLevelUpSheet : MonoBehaviour
{

    public List<Stats.CharacterSheet> cs;
    public List<TheNatures> allNatures;
    public Stats stats;
    public string nature;
    // Use this for initialization
    void Start()
    {
        allNatures.Add(new TheNatures("Nimble", 2, 1, 0, 1, 1, 0)); //+spd -def 
        allNatures.Add(new TheNatures("Tough", 0, 1, 2, 1, 1, 1)); //+def -spd 
        allNatures.Add(new TheNatures("Strong", 0, 2, 1, 1, 1, 2)); //+str -spd 
        allNatures.Add(new TheNatures("Aggressive", 1, 2, 1, 0, 1, 3)); //+str -def 
        allNatures.Add(new TheNatures("Handy", 1, 1, 1, 2, 0, 4)); //+skl -hp 
        allNatures.Add(new TheNatures("Hardy", 0, 1, 1, 1, 2, 5)); //+hp -spd

        nature = "Nimble";
        stats = gameObject.GetComponent<Stats>();
        stats.GetMyNature(nature);
        MySheet();
        stats.GetMySheet(cs);
        stats.Booster();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.promote == true)
        {
            cs.Clear();
            MyProSheet();
            stats.GetMySheet(cs);
        }
    }



    void MySheet()
    {
        bool o = true;
        bool x = false;
        // True = Stat up False = no stat up
        cs = new List<Stats.CharacterSheet>();
        //                                  stat up total spd|str|def|skl|Hp
        cs.Add(new Stats.CharacterSheet(o, o, x, x, o)); // 1  + 0   0   1   1  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 2  + 0   0   2   0  1
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 3  + 0   0   0   2  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 4  + 1   0   0   0  2
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 5  + 0   1   0   3  0
        cs.Add(new Stats.CharacterSheet(x, o, x, o, x)); // 6  + 2   0   3   0  3
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 7  + 0   2   0   4  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 8  + 0   0   4   0  4
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 9  + 0   0   0   5  0
        cs.Add(new Stats.CharacterSheet(x, o, x, o, o)); // 10 + 3   0   5   0  0
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 11 + 0   0   0   6  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 12 + 4   0   0   0  5
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 13 + 0   3   0   7  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 14 + 5   0   0   0  6
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 15 + 0   4   0   8  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 16 + 6   0   0   0  7
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 17 + 0   0   0   9  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 18 + 7   0   0   0  8
        cs.Add(new Stats.CharacterSheet(o, x, o, o, o)); // 19 + 0   5   0   0  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 20 + 0   0   6   0  9
        //                        7  5  6  9  9                
    }

    void MyProSheet()
    {

        bool o = true;
        bool x = false;
        // True = Stat up False = no stat up
        cs = new List<Stats.CharacterSheet>();
        //                                  stat up total spd|str|def|skl|Hp
        cs.Add(new Stats.CharacterSheet(o, o, x, x, o)); // 1  + 0   0   1   1  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 2  + 0   0   2   0  1
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 3  + 0   0   0   2  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 4  + 1   0   0   0  2
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 5  + 0   1   0   3  0
        cs.Add(new Stats.CharacterSheet(x, o, x, o, x)); // 6  + 2   0   3   0  3
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 7  + 0   2   0   4  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 8  + 0   0   4   0  4
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 9  + 0   0   0   5  0
        cs.Add(new Stats.CharacterSheet(x, o, x, o, o)); // 10 + 3   0   5   0  0
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 11 + 0   0   0   6  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 12 + 4   0   0   0  5
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 13 + 0   3   0   7  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 14 + 5   0   0   0  6
        cs.Add(new Stats.CharacterSheet(o, x, o, x, o)); // 15 + 0   4   0   8  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 16 + 6   0   0   0  7
        cs.Add(new Stats.CharacterSheet(o, o, o, x, o)); // 17 + 0   0   0   9  0
        cs.Add(new Stats.CharacterSheet(x, o, o, o, x)); // 18 + 7   0   0   0  8
        cs.Add(new Stats.CharacterSheet(o, x, o, o, o)); // 19 + 0   5   0   0  0
        cs.Add(new Stats.CharacterSheet(o, o, x, o, x)); // 20 + 0   0   6   0  9
        //                        7  5  6  9  9                
    }

    [System.Serializable]
    public class TheNatures
    {
        // Update is called once per frame
        public int isSpd;
        public int isStr;
        public int isDef;
        public int isSkill;
        public int isHp;
        public string natures;
        public int listedOrder;
        public bool visited = false;

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

        public CharacterSheet(bool spd, bool str, bool def, bool skl, bool hp)
        {
            isSpd = spd;
            isStr = str;
            isDef = def;
            visited = false;
            isSkill = skl;
            isHp = hp;
        }


    }


}


