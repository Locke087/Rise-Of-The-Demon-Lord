using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MCMove : GridMovement
{
    //mine
    public Rigidbody rb;
    public MoveSwitch moveSwitch;
    //public Vector3 startPoint;
    // Use this for initialization
    void Start()
    {
        moveSwitch = moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();

        //startPoint = transform.position;
    }
    public bool activePlayer = false;
    public bool tileActive = false;
    public bool moved = false;
    public bool attackState = false;
    public Stats playerStats;
    Rows row;
    public bool activeOnBoard = false;
    public bool OnHighGround = false;

    public bool up = false;
    public bool down = false;
    public bool right = false;
    public bool left = false;
    public GameObject[,] buttonPF;
    public List<GameObject> fieldButtons;
    public int fI = 0;
    public int fJ = 0;
    public bool fieldTime = false;
    public bool amIBusy = false;
    public GameObject currentButton;
    public GameObject colorBox;
    // Update is called once per frame
    void FixedUpdate()
    {

        if (pause) return;

        if (moveSwitch.gridOn == false)
        {
            //mine
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            //needToCenter = true;
            rb.drag = 2;
            transform.rotation = setQuaterRotation(0, 0, 0);
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

           /* if (Input.GetButtonDown("Jump"))
            {
                if (rb.transform.position.y <= 1.4)
                {
                    OnHighGround = false;
                    jumpUp();
                }
                else if (OnHighGround == true)
                {
                    if (rb.transform.position.y <= 2.4) jumpUp();
                    else if (rb.transform.position.y <= 3.4) jumpUp();
                    else if (rb.transform.position.y <= 4.3) jumpUp();
                }
            }*/



       


        }
        else if (moveSwitch.gridOn == true)
        {
            //Heavily Mixed

            if (rb.IsSleeping()) rb.WakeUp();
            rb.drag = 0;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            Debug.DrawRay(transform.position, transform.forward);

            if (!isPlayerPhase || freeze)
            {
                return;
            }

            if (!isMoving)
            {
                if (activePlayer == true)
                {
                    tileActive = true;
                    FindSelectableTiles();
                }
                else if (tileActive == true)
                {
                    tileActive = false;
                    RemoveSelectableTiles();
                }

                CheckMouse();


            }
            else
            {
                moved = true;
                Move();
            }

            if (moved && !isMoving)
            {
                activePlayer = false;
                if (attackState)
                {
                    List<GameObject> targets = new List<GameObject>();
                    AssignArray(targets);
                    GameObject nearest = null;
                    float distance = Mathf.Infinity;

                    foreach (GameObject obj in targets)
                    {
                        float d = Vector3.Distance(transform.position, obj.transform.position);

                        if (d < distance)
                        {
                            distance = d;
                            nearest = obj;
                        }
                    }
                    GameObject Enemy = nearest;
                    Stats newEnemy = Enemy.GetComponent<Stats>();
                    playerStats.weaponStats();
                    newEnemy.attacked(playerStats);
                    attackState = false;
                }
                //mabye add end turn command here
            }

        }


    }

    //Mine

    void AssignArray(List<GameObject> list)
    {
        EnemyMove[] enemyTargets = GameObject.FindObjectsOfType<EnemyMove>();
        foreach (EnemyMove obj in enemyTargets)
            if (obj.activeOnBoard == true) list.Add(obj.gameObject);
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<Rows>() != null)
            row = collision.gameObject.GetComponentInParent<Rows>();
        if (row.GetComponentInParent<MapLocation>().inMap == true) activeOnBoard = true;
        else if (row.GetComponentInParent<MapLocation>().inMap == false) activeOnBoard = false;
    }


    private static Quaternion setQuaterRotation(float x, float y, float z)
    {
        Quaternion newQuaternion = new Quaternion();
        newQuaternion.Set(x, y, z, 1);
        return newQuaternion;
    }

   /* void jumpUp()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical < 0) rb.AddForce(Vector3.back * 30 + Vector3.up * 120);
        else if (moveVertical > 0) rb.AddForce(Vector3.forward * 30 + Vector3.up * 120);
        else if (moveHorizontal < 0) rb.AddForce(Vector3.left * 30 + Vector3.up * 120);
        else if (moveHorizontal > 0) rb.AddForce(Vector3.right * 30 + Vector3.up * 120);
        else rb.AddForce(Vector3.up * 150);
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ramp")
        {
            OnHighGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ramp")
        {
            OnHighGround = false;
        }
    }


    IEnumerator MenuMovement()
    {
        Debug.Log("yes");
        yield return new WaitForSeconds(0.3f);
        Debug.Log("done");
        amIBusy = false;
        fieldTime = true;
    }


    void InFieldMove()
    {
        Debug.Log("moveAlog");
        Debug.Log(fI + " < " + buttonPF.GetLength(0) + " " + fJ + " < " + buttonPF.GetLength(1));

        foreach (GameObject but in fieldButtons)
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
                StartCoroutine(MenuMovement());
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
                StartCoroutine(MenuMovement());
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
                StartCoroutine(MenuMovement());
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
                StartCoroutine(MenuMovement());
            }
        }



    }

    void MoveBox(GameObject location)
    {
        colorBox.transform.localPosition = location.transform.localPosition;
    }

    public void ReassignMenuMovement(string section, int rows, int collums)
    {
        fieldButtons.Clear();
        fieldButtons.AddRange(GameObject.Find(section).GetComponentsInChildren<GameObject>());
        CreateArrayField(rows, collums);
    }

    void CreateArrayField(int rows, int collums)
    {
        int rowSize = rows;
        int collumSize = collums;
        int k = 0;
        buttonPF = new GameObject[rowSize, collumSize];
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
                if (buttonPF[j, i].GetComponent<Renderer>().material.color == Color.blue)
                {
                    buttonPF[j, i].GetComponent<Renderer>().material.color = Color.black;
                }
            }
        }

    }

    //heavy mixed
    void CheckMouse()
    {

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.GetComponent<MCMove>() == this)
                {
                    if (activePlayer == true && !isMoving)
                        activePlayer = false;
                    else
                        activePlayer = true;

                }
                if (hit.collider.GetComponent<GridTiles>() != null)
                {
                    GridTiles t = hit.collider.GetComponent<GridTiles>();
                    Debug.Log("I got that click");
                    if (t.selectable)
                    {
                        isMoving = true;
                        MoveToTile(t);
                    }
                    if (t.attack)
                    {
                        attackState = true;
                        FindPath(t);
                    }
                }
            }
        }

    }

}