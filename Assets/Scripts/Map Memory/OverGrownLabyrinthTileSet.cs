using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OverGrownLabyrinthTileSet {

    public GameTypeDirector rout;
    public GameTypeDirector rescue;
    public GameTypeDirector arrive;
    public GameTypeDirector escape;
    public GameTypeDirector survive;
    public GameTypeDirector defend;
    public GameTypeDirector protect;
    public GameTypeDirector defeatBoss;
    public GameTypeDirector seize;
    public GameTypeDirector capture;


    public OverGrownLabyrinthTileSet()
    {
        rout = new GameTypeDirector();
        rescue = new GameTypeDirector();
        arrive = new GameTypeDirector();
        escape = new GameTypeDirector();
        survive = new GameTypeDirector();
        defend = new GameTypeDirector();
        protect = new GameTypeDirector();
        defeatBoss = new GameTypeDirector();
        seize = new GameTypeDirector();
        capture = new GameTypeDirector();
    }
}
