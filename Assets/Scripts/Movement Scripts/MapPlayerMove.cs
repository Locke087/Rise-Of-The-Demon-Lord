using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayerMove : GridMovement {

    // Use this for initialization
    public bool busy = false;
    MapPlayerAttack playerAttack;
    Rigidbody rb;
	void Start () {
      playerAttack = gameObject.GetComponent<MapPlayerAttack>();
      rb = gameObject.GetComponent<Rigidbody>();
        if (rb.IsSleeping()) rb.WakeUp();
        rb.drag = 0;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }
	
    public void AssignMe()
    {
        MapManager manager = GameObject.FindObjectOfType<MapManager>();
        manager.UserSet(gameObject);
    }

    public void RemoveMe()
    {
        MapManager manager = GameObject.FindObjectOfType<MapManager>();
        manager.UserRemove();
    }

    public void ShowMove()
    {
        Debug.Log("nowWhat");
        if (!playerAttack.inUse)
        {
            busy = true;
            AssignMe();
          
            FindSelectableTiles();
        }
    }

   
    public void HideMove()
    {
        busy = false;
        RemoveMe();
        RemoveSelectableTiles();
    }

   

    public IEnumerator GoMove(GridTiles tile)
    {
        isMoving = true;
        MoveToTile(tile);
        Move();
        do
        {
            Move();
            yield return new WaitForSeconds(0.01f);
        } while (isMoving);
        if (gameObject.transform.localRotation != tile.transform.localRotation) gameObject.transform.localRotation = tile.transform.localRotation;
        GameObject.FindObjectOfType<PlayerUnitMenu>().moveDoubleClick = false;
        HideMove();
    }

}
