using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridTiles : MonoBehaviour { 
    public bool walkable;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;
    public bool attack = false;
    public bool overTile = false;
    public bool hit = false;
    public bool onTile = false;
    public MapLocation mapLocation;
    public Rows rows;
    public PhaseSwitcher phaseSwitcher;

    public List<GameObject> marked = new List<GameObject>();
    public int counter = 0;
    public List<GridTiles> adjacencyList = new List<GridTiles>();
    public List<GridTiles> attackList = new List<GridTiles>();

    //Needed BFS (breadth first search)
    public bool visited = false;
    public GridTiles parent = null;
    public int distance = 0;
    public GameObject unit = null;
    public Vector3 myRotate;
    public float myZ;
    //For A*
    public float f = 0;
    public float g = 0;
    public float h = 0;

    // Use this for initialization
    void Start()
    {
        myZ = gameObject.transform.position.z;
        rows = gameObject.GetComponentInParent<Rows>();
        mapLocation = rows.GetComponentInParent<MapLocation>();
        phaseSwitcher = mapLocation.GetComponent<PhaseSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {

        if (current)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (target)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.green;
        }
        else if (overTile)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (selectable)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (attack)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        attackList.Clear();
        adjacencyList.Clear();

        current = false;
        target = false;
        selectable = false;
        attack = false;

        visited = false;
        parent = null;
        distance = 0;

        f = g = h = 0;
        counter = 0;

    }

    public void FindNeighbors(float jumpHeight, GridTiles target)
    {
        Reset();

        CheckTile(Vector3.forward, jumpHeight, target);
        CheckTile(-Vector3.forward, jumpHeight, target);
        CheckTile(Vector3.right, jumpHeight, target);
        CheckTile(-Vector3.right, jumpHeight, target);
    }

   
    public void SendInfo()
    {
        Debug.Log("hi");
        Debug.Log(gameObject.name);
        if (selectable)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.PlayerMove(gameObject);
        }
        else if (attack)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.PlayerAttack(gameObject, unit);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
            onTile = true;

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
            onTile = false;

        unit = null;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
        {

            unit = collision.gameObject;
            Rows[] allRows;
            allRows = mapLocation.GetComponentsInChildren<Rows>();
            int i = 0;
            foreach (Rows row in allRows)
            {
                GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
                foreach (GridTiles tile in allTiles)
                {
                    if (tile.unit != null)
                        if (tile.unit.GetComponent<MCMove>() != null)
                        {
                            i++;
                            if (i > 1) tile.unit = null;
                        }
                }
            }
            i = 0;
        }
        else unit = collision.gameObject;
    }




    public void CheckTile(Vector3 direction, float jumpHeight, GridTiles target)
    {
        Vector3 halfExtents = new Vector3(0.25f, jumpHeight);
        if (gameObject.tag == "Ramp")
        {
            halfExtents = new Vector3(0.25f, jumpHeight);
        }
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtents);
        foreach (Collider item in colliders)
        {
            GridTiles tile = null;

            if (item.GetComponent<GridTiles>() != null)
            {
               tile = item.GetComponent<GridTiles>();
            }
            else
            {
               tile = item.GetComponentInParent<GridTiles>();
            }

            if (tile != null && tile.walkable && tile.name[0] + tile.name[1] == gameObject.name[0] + gameObject.name[1])
            {
                RaycastHit hit;
                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3) || (tile == target))
                {
                    if (gameObject.transform.position.y == tile.transform.position.y)
                    {
                        adjacencyList.Add(tile);
                        attackList.Add(tile);
                    }
                    else if (gameObject.tag == "Ramp")
                    {
                        if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                        {

                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }

                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            //Debug.Log("Im Here");
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            // Debug.Log("Im Here");
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                    }
                    else if (tile.tag == "Ramp")
                    {

                        if (tile.transform.localRotation.eulerAngles.y == 0f || tile.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 90f) // A
                        {
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                    }

                }//Attacks
                else if (Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3))
                {

                    if (gameObject.transform.position.y == tile.transform.position.y)
                    {
                        attackList.Add(tile);
                    }
                    else if (gameObject.tag == "Ramp")
                    {
                        if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                        {

                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }

                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            //Debug.Log("Im Here");
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {;
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            // Debug.Log("Im Here");
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                    }
                    else if (tile.tag == "Ramp")
                    {

                        if (tile.transform.localRotation.eulerAngles.y == 0f || tile.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 90f) // A
                        {
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                    }

                }

            }
        }
    }
}


         /* if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3) || (tile == target))
            {


            }//Attacks
            else if (Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3))
            {

                if (gameObject.transform.position.y == tile.transform.position.y)
                {
                    if (phaseSwitcher.playerPhase)
                    {
                        if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                    }
                    else if (phaseSwitcher.enemyPhase)
                    {
                        if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                        else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                    }
                }
                else if (gameObject.tag == "Ramp")
                {
                    if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                    {
                        if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }


                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                    {
                        if (gameObject.transform.position.z < tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                    {
                        if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        };
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                    {
                        if (gameObject.transform.position.z > tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                }
                else if (tile.tag == "Ramp")
                {
                    if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                    {
                        if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                    {
                        if (gameObject.transform.position.z > tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                    {
                        if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                    {
                        if (gameObject.transform.position.z < tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                }

            }*/
