using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    //mine

    public bool isPlayerPhase;
    public bool isEnemyPhase;
    public bool freeze;
    public bool enemyIsFinished;
    public bool enemyAccounted;
    public bool pause = false;

    //not mine

    List<GridTiles> selectableTiles = new List<GridTiles>();
    List<GameObject> tiles = new List<GameObject>();
    Stack<GridTiles> path = new Stack<GridTiles>();
    GridTiles currentTile;
    List<GridTiles> attackTile = new List<GridTiles>();

    public bool isMoving = false;
    public int move = 5;
    public float jumpHeight = 0;
    public float moveSpeed = 2;

    Vector3 velocity = new Vector3();
    Vector3 heading = new Vector3();

    public float halfHeight = 1.4f;

    public GridTiles actualTargetTile;

    public void Init()
    {

        AssignArray(tiles);
        //mine
       // if (gameObject.GetComponent<EnemyMove>() == null) isPlayerPhase = true;
       // else isPlayerPhase = false;
       // isEnemyPhase = false;
       // freeze = false;
       // enemyIsFinished = false;
       // enemyAccounted = false;
        //not mine
       // halfHeight = gameObject.GetComponent<Collider>().bounds.extents.y;
    }

    public void GetCurrentTile()
    {
        currentTile = GetTargetTile(gameObject);
        currentTile.current = true;
    }

    public GridTiles GetTargetTile(GameObject target)
    {
        RaycastHit hit;
        GridTiles tile = null;

        if (Physics.Raycast(target.transform.position, -Vector3.up, out hit, 3))
        {
            if (hit.collider.GetComponent<GridTiles>() == null)
            {

                Debug.Log("thudfdjs");
                tile = hit.collider.GetComponentInParent<GridTiles>();
            }
            else
            {
                tile = hit.collider.GetComponent<GridTiles>();
            }
        }

        return tile;
    }

    public void ComputeAdjacencyLists(float jumpHeight, GridTiles target)
    {
        AssignArray(tiles);
        foreach (GameObject tile in tiles) tile.GetComponent<GridTiles>().FindNeighbors(jumpHeight, target);

    }

    void AssignArray(List<GameObject> list)
    {
        GridTiles[] mapTiles = GameObject.FindObjectsOfType<GridTiles>();
        foreach (GridTiles obj in mapTiles)
            list.Add(obj.gameObject);
    }


    public void FindSelectableTiles()
    {
        ComputeAdjacencyLists(jumpHeight, null);
        GetCurrentTile();

        Queue<GridTiles> process = new Queue<GridTiles>();

        process.Enqueue(currentTile);
        currentTile.visited = true;


        //currentTile.parent = ??  leave as null 

        while (process.Count > 0)
        {
            GridTiles t = process.Dequeue();
            selectableTiles.Add(t);
            t.selectable = true;

            if (t.distance < move)
            {
                foreach (GridTiles tile in t.adjacencyList)
                {
                    if (!tile.visited)
                    {

                        tile.parent = t;
                        tile.visited = true;
                        tile.distance = 1 + t.distance;
                        process.Enqueue(tile);
                    }
                }

               /*foreach (GridTiles tile in t.attackList)
                {
                    if (!tile.visited)
                    {
                        attackTile.Add(tile);
                        tile.parent = t;
                        tile.visited = true;
                        tile.distance = 1 + t.distance;
                        tile.selectable = false;
                        tile.attack = true;
                    }
                }*/



            }



        }
    }


    public void MoveToTile(GridTiles tile)
    {
        path.Clear();
        tile.target = true;
        isMoving = true;
        
        
        GridTiles next = tile;
       
        while (next != null)
        {
            path.Push(next);
            next = next.parent;
        }
    }

    public void Move()
    {
        if (path.Count > 0)
        {
            GridTiles t = path.Peek();
            Vector3 target = t.transform.position;
          
            //Calculate the unit's position on top of the target tile
            target.y += halfHeight; //+ t.GetComponent<Collider>().bounds.extents.y;
           
            if (Vector3.Distance(transform.position, target) >= 0.05f)
            {
                CalculateHeading(target);
                SetHorizotalVelocity();
                //Locomotion
                transform.forward = heading;
                transform.position += velocity * Time.deltaTime;
            }
            else
            {
                //Tile center reached
                transform.position = target;
                path.Pop();
            }
        }
        else
        {
            RemoveSelectableTiles();
            isMoving = false;


        }
    }

    protected void RemoveSelectableTiles()
    {
        if (currentTile != null)
        {
            currentTile.current = false;
            currentTile = null;
        }

        foreach (GridTiles tile in attackTile)
        {
            tile.Reset();
        }

        foreach (GridTiles tile in selectableTiles)
        {
            tile.Reset();
        }



        selectableTiles.Clear();
        attackTile.Clear();
    }

    void CalculateHeading(Vector3 target)
    {
        heading = target - transform.position;
        heading.Normalize();
    }

    void SetHorizotalVelocity()
    {
        velocity = heading * moveSpeed;
    }

    protected GridTiles FindLowestF(List<GridTiles> list)
    {
        GridTiles lowest = list[0];

        foreach (GridTiles t in list)
        {
            if (t.f < lowest.f)
            {
                lowest = t;
            }
        }

        list.Remove(lowest);

        return lowest;
    }

    protected GridTiles FindEndTile(GridTiles t)
    {
        Stack<GridTiles> tempPath = new Stack<GridTiles>();

        GridTiles next = t.parent;
        while (next != null)
        {
            tempPath.Push(next);
            next = next.parent;
        }

        if (tempPath.Count <= move)
        {
            return t.parent;
        }

        GridTiles endTile = null;
        for (int i = 0; i <= move; i++)
        {
            endTile = tempPath.Pop();
        }

        return endTile;
    }

    protected void FindPath(GridTiles target)
    {
        ComputeAdjacencyLists(jumpHeight, target);
        GetCurrentTile();

        List<GridTiles> openList = new List<GridTiles>();
        List<GridTiles> closedList = new List<GridTiles>();

        openList.Add(currentTile);
        //currentTile.parent = ??
        currentTile.h = Vector3.Distance(currentTile.transform.position, target.transform.position);
        currentTile.f = currentTile.h;

        while (openList.Count > 0)
        {
            GridTiles t = FindLowestF(openList);

            closedList.Add(t);

            if (t == target)
            {
                actualTargetTile = FindEndTile(t);
                MoveToTile(actualTargetTile);
                return;
            }

            foreach (GridTiles tile in t.adjacencyList)
            {
                if (closedList.Contains(tile))
                {
                    //Do nothing, already processed
                }
                else if (openList.Contains(tile))
                {
                    float tempG = t.g + Vector3.Distance(tile.transform.position, t.transform.position);

                    if (tempG < tile.g)
                    {
                        tile.parent = t;

                        tile.g = tempG;
                        tile.f = tile.g + tile.h;
                    }
                }
                else
                {
                    tile.parent = t;

                    tile.g = t.g + Vector3.Distance(tile.transform.position, t.transform.position);
                    tile.h = Vector3.Distance(tile.transform.position, target.transform.position);
                    tile.f = tile.g + tile.h;

                    openList.Add(tile);
                }
            }
        }



        GameObject.FindObjectOfType<MoveSwitch>().gridOn = false;
        Debug.Log("Make A Better Map you nit wit");
    }


}
