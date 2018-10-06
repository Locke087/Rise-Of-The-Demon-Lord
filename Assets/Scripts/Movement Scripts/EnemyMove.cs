using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : GridMovement
{
    GameObject target;
    public bool moved = false;
    public bool attackState = false;
    public Stats playerStats;
    public float thePlayer;
    public bool setup = true;
    public bool activeOnBoard = false;
    public bool activeEnemy = false;
    public int activeCheck = 0;
    public MoveSwitch moveSwitch;
    public Rigidbody rb;
    Rows row;
    // Use this for initialization
    void Start()
    {
        moveSwitch = moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (pause) return;
        if (rb.IsSleeping()) rb.WakeUp();

        if (moveSwitch.gridOn == true && activeOnBoard)
        {

            if (activeEnemy) activeCheck++;


            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            Debug.DrawRay(transform.position, transform.forward);

            if (!isEnemyPhase || freeze)
            {
                return;
            }

            if (!isMoving)
            {
                if (activeEnemy)
                {
                    FindNearestTarget();
                    CalculatePath();
                    FindSelectableTiles();
                    actualTargetTile.target = true;
                }
            }
            else
            {
                moved = true;
                float nextTo = 1;
                thePlayer = Vector3.Distance(transform.position, target.transform.position);
                if (nextTo >= thePlayer)
                    attackState = true;
                Move();

            }

            if (moved && !isMoving)
            {


                if (attackState)
                {
                    List<GameObject> newTargets = new List<GameObject>();
                    AssignArray(newTargets);

                    GameObject nearest = null;
                    float distance = Mathf.Infinity;

                    foreach (GameObject obj in newTargets)
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

                enemyIsFinished = true;
            }
        }
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

    void CalculatePath()
    {
        GridTiles targetTile = GetTargetTile(target);
        FindPath(targetTile);

    }

    void AssignArray(List<GameObject> list)
    {
        MCMove MCtarget = GameObject.FindObjectOfType<MCMove>();
        PlayerUnit[] playerTargets = GameObject.FindObjectsOfType<PlayerUnit>();
        if (MCtarget.activeOnBoard == true) list.Add(MCtarget.gameObject);
        foreach (PlayerUnit obj in playerTargets)
            if (obj.activeOnBoard == true) list.Add(obj.gameObject);
    }

    void FindNearestTarget()
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

        target = nearest;
    }
}
