using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : GridMovement
{

    public Rigidbody rb;
    public MoveSwitch moveSwitch;
    // Use this for initialization
    void Start()
    {
        moveSwitch = moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    public bool activePlayer = false;
    public bool activeOnBoard = false;
    public bool tileActive = false;
    public bool moved = false;
    public bool attackState = false;
    public Stats playerStats;


    Rows row;

    /* Update is called once per frame
    void FixedUpdate()
    {

        if (pause) return;

        if (rb.IsSleeping()) rb.WakeUp();

        if (moveSwitch.gridOn == true && activeOnBoard)
        {
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
                    newEnemy.attacked(playerStats);
                    attackState = false;
                }

            }

        }

    }

    void AssignArray(List<GameObject> list)
    {
        EnemyMove[] enemyTargets = GameObject.FindObjectsOfType<EnemyMove>();
        foreach (EnemyMove obj in enemyTargets)
            if (obj.activeOnBoard == true) list.Add(obj.gameObject);
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<Rows>() != null)
        {
            row = collision.gameObject.GetComponentInParent<Rows>();
            if (row.GetComponentInParent<MapLocation>().inMap == true) activeOnBoard = true;
            else if (row.GetComponentInParent<MapLocation>().inMap == false) activeOnBoard = false;
        }
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.GetComponent<PlayerUnit>() == this)
                {
                    if (activePlayer == true)
                        activePlayer = false;
                    else
                        activePlayer = true;

                }
                if (hit.collider.GetComponent<GridTiles>() != null)
                {
                    GridTiles t = hit.collider.GetComponent<GridTiles>();

                    if (t.selectable)
                    {
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
    }*/
}
