using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class AttackTextClicker : MonoBehaviour, IPointerClickHandler
{

    public TextMeshProUGUI textMeshPro;
    public AttackUI attackUI;
    public int linkIndex = 0;
    public Camera camera;

    public void Start()
    {
        attackUI = GameObject.FindObjectOfType<AttackUI>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, GetComponent<Camera>());
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = textMeshPro.textInfo.linkInfo[linkIndex];
          
            string dddd = linkInfo.GetLinkID();
            string fff = linkInfo.GetLinkText();

        }
    }




}
