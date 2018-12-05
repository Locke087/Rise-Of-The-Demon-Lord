using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorPlacementGroup : MonoBehaviour {

    // Use this for initialization
    public string realname;
    public PictureState place;
    public PictureState place2;
    public PictureState place3;
    public PictureState place4;
    public PictureState place5;
    public PictureState place6;
    public PictureState place7;
    public PictureState place8;
    public PictureState place9;
    public PictureState place10;
    public PictureState place11;
    public PictureState place12;
    public PictureState place13;
    public PictureState place14;
    public PictureState place15;
    public PictureState place16;
    public PictureState place17;
    public PictureState place18;
    public PictureState place19;
    public PictureState place20;
    public PictureState place21;
    public PictureState place22;
    public PictureState place23;
    public PictureState place24;
    public PictureState place25;
    public PictureState place26;
    public PictureState place27;
    public PictureState place28;
    public PictureState place29;
    public PictureState place30;
    public PictureState place31;
    public PictureState place32;
    public PictureState place33;

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchPostion(string place, string names)
    {
        if (CurrentPostion() != null)
        {
            CurrentPostion().gameObject.SetActive(false);
        }
        NewPostion(place).gameObject.SetActive(true);
    
    }

    public void StartPostion(string place, string names )
    {
        NewPostion(place).gameObject.SetActive(true);
    }

    public PictureState CurrentPostion()
    {
       
        if (place.gameObject.activeInHierarchy) return place;
        else if (place2.gameObject.activeInHierarchy) return place2;
        else if (place3.gameObject.activeInHierarchy) return place3;
        else if (place4.gameObject.activeInHierarchy) return place4;
        else if (place5.gameObject.activeInHierarchy) return place5;
        else if (place6.gameObject.activeInHierarchy) return place6;
        else if (place7.gameObject.activeInHierarchy) return place7;
        else if (place8.gameObject.activeInHierarchy) return place8;
        else if (place9.gameObject.activeInHierarchy) return place9;
        else if (place10.gameObject.activeInHierarchy) return place10;
        else if (place11.gameObject.activeInHierarchy) return place11;
        else if (place12.gameObject.activeInHierarchy) return place12;
        else if (place13.gameObject.activeInHierarchy) return place13;
        else if (place14.gameObject.activeInHierarchy) return place14;
        else if (place15.gameObject.activeInHierarchy) return place15;
        else if (place16.gameObject.activeInHierarchy) return place16;
        else if (place17.gameObject.activeInHierarchy) return place17;
        else if (place18.gameObject.activeInHierarchy) return place18;
        else if (place19.gameObject.activeInHierarchy) return place19;
        else if (place20.gameObject.activeInHierarchy) return place20;
        else if (place21.gameObject.activeInHierarchy) return place21;
        else if (place22.gameObject.activeInHierarchy) return place22;
        else if (place23.gameObject.activeInHierarchy) return place23;
        else if (place24.gameObject.activeInHierarchy) return place24;
        else if (place25.gameObject.activeInHierarchy) return place25;
        else if (place26.gameObject.activeInHierarchy) return place26;
        else if (place27.gameObject.activeInHierarchy) return place27;
        else if (place28.gameObject.activeInHierarchy) return place28;
        else if (place29.gameObject.activeInHierarchy) return place29;
        else if (place30.gameObject.activeInHierarchy) return place30;
        else if (place31.gameObject.activeInHierarchy) return place31;
        else if (place32.gameObject.activeInHierarchy) return place32;
        else if (place33.gameObject.activeInHierarchy) return place33;

        return null;
    }


    public PictureState NewPostion(string newPlace)
    {

        if (place.gameObject.name == newPlace) return place;
        else if (place2.gameObject.name == newPlace) return place2;
        else if (place3.gameObject.name == newPlace) return place3;
        else if (place4.gameObject.name == newPlace) return place4;
        else if (place5.gameObject.name == newPlace) return place5;
        else if (place6.gameObject.name == newPlace) return place6;
        else if (place7.gameObject.name == newPlace) return place7;
        else if (place8.gameObject.name == newPlace) return place8;
        else if (place9.gameObject.name == newPlace) return place9;
        else if (place10.gameObject.name == newPlace) return place10;
        else if (place11.gameObject.name == newPlace) return place11;
        else if (place12.gameObject.name == newPlace) return place12;
        else if (place13.gameObject.name == newPlace) return place13;
        else if (place14.gameObject.name == newPlace) return place14;
        else if (place15.gameObject.name == newPlace) return place15;
        else if (place16.gameObject.name == newPlace) return place16;
        else if (place17.gameObject.name == newPlace) return place17;
        else if (place18.gameObject.name == newPlace) return place18;
        else if (place19.gameObject.name == newPlace) return place19;
        else if (place20.gameObject.name == newPlace) return place20;
        else if (place21.gameObject.name == newPlace) return place21;
        else if (place22.gameObject.name == newPlace) return place22;
        else if (place23.gameObject.name == newPlace) return place23;
        else if (place24.gameObject.name == newPlace) return place24;
        else if (place25.gameObject.name == newPlace) return place25;
        else if (place26.gameObject.name == newPlace) return place26;
        else if (place27.gameObject.name == newPlace) return place27;
        else if (place28.gameObject.name == newPlace) return place28;
        else if (place29.gameObject.name == newPlace) return place29;
        else if (place30.gameObject.name == newPlace) return place30;
        else if (place31.gameObject.name == newPlace) return place31;
        else if (place32.gameObject.name == newPlace) return place32;
        else if (place33.gameObject.name == newPlace) return place33;

        return null;
    }
}
