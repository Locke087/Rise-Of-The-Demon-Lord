using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    //Script that new more

    public bool amIBusy = false;
    MoveSwitch moveSwitch;
    public bool activeMenu = false;
    public List<GameObject> startMenus;
    public Button manageParty;
    public Button mapInfo;
    public Button scoutObjective;
    public Button startRetreat;
    public Button tacticalOptions;
    public List<Button> fieldButtons;
    public List<Button> battleButtons;
    public GameObject colorBox;
    public Button[,] buttonPF;
    public float moveHorizontal;
    public float moveVertical;
    public bool up = false;
    public bool down = false;
    public bool right = false;
    public bool left = false;
    public int currentIndex;
    public Button currentButton;
    public StartMenu start;
    public int fI = 0;
    public int fJ = 0;
    public GameObject menu;
    public bool fieldTime = false;
    public bool battleTime = false;
    public int horizontalF = 0;
    public int verticalF = 0;
    public int lastHF = 0;
    public int lastVF = 0;
    public int mySize;
    public List<MapLocation> mapLocation;
    public MapLocation activeMap;
    // Use this for initialization // m for menu
    void Start()
    {
        // startMenus.AddRange(GameObject.FindGameObjectsWithTag("StartMenus"));
        mapLocation = new List<MapLocation>();
        mapLocation.AddRange(GameObject.FindObjectsOfType<MapLocation>());
        menu = GameObject.Find("Menu");
        moveSwitch = moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        fieldButtons = new List<Button>();
        battleButtons = new List<Button>();
        startMenus = new List<GameObject>();
        startMenus.AddRange(GameObject.FindGameObjectsWithTag("StartMenus"));
        fieldButtons.AddRange(GameObject.Find("MainSectionSMIF").GetComponentsInChildren<Button>());
        GameObject.Find("Ext").SetActive(false);
        battleButtons.AddRange(GameObject.Find("StartMenuInBattle").GetComponent<BattleMenu>().GetComponentsInChildren<Button>());
        CreateArrayField(4, 2);
        mySize = battleButtons.Count;
        ExitMenu();
        StartCoroutine(IndentifyMap());
        mapInfo.onClick.AddListener(DoSomething);
        menu.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (amIBusy) return;

        if (Input.GetButtonDown("Start"))
        {
            menu.SetActive(true);
            if (!activeMenu) WhichMenu();
            else if (activeMenu) ExitMenu();
        }
        if (Input.GetButtonDown("Cancel")) ExitMenu();


        moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");


        if (moveVertical > 0) up = true;
        else up = false;

        if (moveVertical < 0) down = true;
        else down = false;


        if (moveHorizontal < 0) right = true;
        else right = false;

        if (moveHorizontal > 0) left = true;
        else left = false;

        if (moveVertical != 0 || moveHorizontal != 0)
        {
            if (battleTime) InBattleMove();
            else if (fieldTime) InFieldMove();
        }


    }

    public void ReassignMenuMovement(string section, int rows, int collums)
    {
        fieldButtons.Clear();
        fieldButtons.AddRange(GameObject.Find(section).GetComponentsInChildren<Button>());
        CreateArrayField(rows, collums);
    }

    void DeactiveAllMenus()
    {
        foreach (GameObject newMenu in startMenus)
            newMenu.SetActive(false);

    }


    void ToggleMenu(string looking, bool yesOrNo)
    {
        foreach (GameObject newMenu in startMenus)
        {
            if (looking == newMenu.name) newMenu.SetActive(yesOrNo);
        }
    }



    void CreateArrayField(int rows, int collums)
    {
        int rowSize = rows;
        int collumSize = collums;
        int k = 0;
        buttonPF = new Button[rowSize, collumSize];
        for (int i = 0; i < collumSize; i++)
        {
            for (int j = 0; j < rowSize; j++)
            {
                if (fieldButtons[k])
                {
                    buttonPF[j, i] = fieldButtons[k];
                    k++;
                    Debug.Log(buttonPF[j, i]);
                }
            }
        }

    }


    void ResetColor()
    {
        for (int i = 0; i < buttonPF.GetLength(1); i++)
        {
            for (int j = 0; j < buttonPF.GetLength(0); j++)
            {
                if (buttonPF[j, i].GetComponentInChildren<Text>().color == Color.blue)
                {
                    buttonPF[j, i].GetComponentInChildren<Text>().color = Color.black;
                }
            }
        }

    }

    void MoveBox(Button location)
    {
        colorBox.transform.localPosition = location.transform.localPosition;
    }

    IEnumerator IndentifyMap()
    {

        yield return new WaitForEndOfFrame();
        FindMap();
        Debug.Log("done now");
    }


    IEnumerator MenuMovement(Button newButton, bool whichTime)
    {
        Debug.Log("yes");
        yield return new WaitForSeconds(0.3f);
        Debug.Log("done");
        amIBusy = false;
        if (whichTime) battleTime = true;
        else if (!whichTime) fieldTime = true;
    }


    void FindMap()
    {
        foreach (MapLocation map in mapLocation)
        {
            Debug.Log(map.inMap);
            if (map.inMap) activeMap = map;
        }
    }

    void WhichMenu()
    {
        if (amIBusy) return;

        activeMenu = true;

        if (!moveSwitch.gridOn) InFieldMenu();
        else if (moveSwitch.gridOn) InBattleMenu();


    }

    void WhichMoveMenu()
    {
        if (!moveSwitch.gridOn) InFieldMove();
        else if (moveSwitch.gridOn) InBattleMove();
    }

    public void DoSomething()
    {
        Debug.Log("I got something");
    }

    void InFieldMenu()
    {
        foreach (GameObject menu in startMenus)
        {
            if (menu.name == "StartMenuInField")
            {
                activeMap.PausePlayers();
                menu.SetActive(true);
                ToggleMenu(menu.name, true);
            }
        }
        currentButton = manageParty;
        manageParty.GetComponentInChildren<Text>().color = Color.blue;
        activeMenu = true;
        fieldTime = true;

    }

    void InBattleMenu()
    {
        foreach (GameObject menu in startMenus)
        {
            if (menu.name == "StartMenuInBattle")
            {
                activeMap.PausePlayers();
                menu.SetActive(true);
                ToggleMenu(menu.name, true);
            }
        }
        currentButton = mapInfo;
        mapInfo.GetComponentInChildren<Text>().color = Color.blue;
        activeMenu = true;
        battleTime = true;


    }

    void InFieldMove()
    {
        Debug.Log("moveAlog");
        Debug.Log(fI + " < " + buttonPF.GetLength(0) + " " + fJ + " < " + buttonPF.GetLength(1));

        foreach (Button but in fieldButtons)
        {

            if (but.GetComponentInChildren<Text>().color == Color.blue)
            {
                Debug.Log("am I blue");
                currentButton = but;
            }
        }

        if (up)
        {
            if (fI != 0 && fI < buttonPF.GetLength(0))
            {
                fI--;
                ResetColor();
                Debug.Log("up move");
                buttonPF[fI, fJ].GetComponentInChildren<Text>().color = Color.blue;
                MoveBox(buttonPF[fI, fJ]);
                amIBusy = true;
                fieldTime = false;
                up = false;
                StartCoroutine(MenuMovement(buttonPF[fI, fJ], false));
            }
        }
        else if (down)
        {
            if (fI < buttonPF.GetLength(0) - 1)
            {
                fI++;
                ResetColor();
                Debug.Log("down move");
                buttonPF[fI, fJ].GetComponentInChildren<Text>().color = Color.blue;
                MoveBox(buttonPF[fI, fJ]);
                amIBusy = true;
                fieldTime = false;
                down = false;
                StartCoroutine(MenuMovement(buttonPF[fI, fJ], false));
            }
        }
        else if (right)
        {
            if (fJ != 0 && fJ < buttonPF.GetLength(1))
            {
                fJ--;
                ResetColor();
                Debug.Log("right move");
                buttonPF[fI, fJ].GetComponentInChildren<Text>().color = Color.blue;
                MoveBox(buttonPF[fI, fJ]);
                amIBusy = true;
                fieldTime = false;
                right = false;
                StartCoroutine(MenuMovement(buttonPF[fI, fJ], false));
            }
        }
        else if (left)
        {
            if (fJ < buttonPF.GetLength(1) - 1)
            {
                fJ++;
                ResetColor();
                Debug.Log("left move");
                buttonPF[fI, fJ].GetComponentInChildren<Text>().color = Color.blue;
                MoveBox(buttonPF[fI, fJ]);
                amIBusy = true;
                fieldTime = false;
                left = false;
                StartCoroutine(MenuMovement(buttonPF[fI, fJ], false));
            }
        }



    }

    void InBattleMove()
    {

        foreach (Button but in battleButtons)
        {

            if (but.GetComponentInChildren<Text>().color == Color.blue) currentButton = but;
        }

        if (currentButton == null) return;

        currentIndex = battleButtons.IndexOf(currentButton);

        if (down == true)
        {
            if (currentIndex + 1 < battleButtons.Count)
            {
                Debug.Log("what is the world");
                battleButtons[currentIndex].GetComponentInChildren<Text>().color = Color.black;
                battleButtons[currentIndex + 1].GetComponentInChildren<Text>().color = Color.blue;
                battleTime = false;
                StartCoroutine(MenuMovement(battleButtons[currentIndex + 1], true));
            }
        }
        if (up == true)
        {
            if (currentIndex - 1 >= 0)
            {
                Debug.Log("what is turtles");
                battleButtons[currentIndex].GetComponentInChildren<Text>().color = Color.black;
                battleButtons[currentIndex - 1].GetComponentInChildren<Text>().color = Color.blue;
                battleTime = false;
                StartCoroutine(MenuMovement(battleButtons[currentIndex - 1], true));
            }
        }

    }

    void ExitMenu()
    {
        foreach (GameObject allMenus in startMenus)
        {
            allMenus.SetActive(false);
        }


        battleTime = false;
        fieldTime = false;
        activeMenu = false;
        if (activeMap != null)
            activeMap.UnPausePlayers();

    }

    public bool Busy(bool busy)
    {
        amIBusy = busy;
        return amIBusy;
    }




}
