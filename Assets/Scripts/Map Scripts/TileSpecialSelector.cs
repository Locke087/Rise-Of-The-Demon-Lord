using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TileSpecialSelector : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textMeshPro;
    public int linkIndex = 0;
    public int linkIndexOld = 0;
    public Camera camera;
    public ScrollRect scroll;

	// Use this for initialization
	void Start () {
        scroll.content = textMeshPro.GetComponent<RectTransform>();
        textMeshPro.text = "";
        textMeshPro.text += "<link=Hazard>Hazard</link>";
        textMeshPro.text += "\n";
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, GetComponent<Camera>());
        SetLinkToColor(linkIndex, Color.blue);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = textMeshPro.textInfo.linkInfo[linkIndex];
            //   TMP_TextUtilities.FindIntersectingWord(linkInfo.textComponent, linkInfo., GetComponent<Camera>())
            string dddd = linkInfo.GetLinkID();
            string fff = linkInfo.GetLinkText();
            SetLinkToColor(linkIndex, Color.red);
            DotheThing(dddd, fff);
           
        }
    }

    List<Color32[]> SetLinkToColor(int linkIndex, Color32 color)
    {
        TMP_LinkInfo linkInfo = textMeshPro.textInfo.linkInfo[linkIndex];

        var oldVertColors = new List<Color32[]>(); // store the old character colors

        for (int i = 0; i < linkInfo.linkTextLength; i++)
        { // for each character in the link string
            int characterIndex = linkInfo.linkTextfirstCharacterIndex + i; // the character index into the entire text
            var charInfo = textMeshPro.textInfo.characterInfo[characterIndex];
            int meshIndex = charInfo.materialReferenceIndex; // Get the index of the material / sub text object used by this character.
            int vertexIndex = charInfo.vertexIndex; // Get the index of the first vertex of this character.

            Color32[] vertexColors = textMeshPro.textInfo.meshInfo[meshIndex].colors32; // the colors for this character
            oldVertColors.Add(vertexColors);

            if (charInfo.isVisible)
            {
                vertexColors[vertexIndex + 0] = color;
                vertexColors[vertexIndex + 1] = color;
                vertexColors[vertexIndex + 2] = color;
                vertexColors[vertexIndex + 3] = color;
            }
        }

        // Update Geometry
        textMeshPro.UpdateVertexData(TMP_VertexDataUpdateFlags.All);

        return oldVertColors;
    }


    public void DotheThing(string pick, string display)
    {
        GameObject.FindObjectOfType<MiddleManStorage>().AssignSpecial(pick, display);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, GetComponent<Camera>());
        if (linkIndex != linkIndexOld) SetLinkToColor(linkIndexOld, Color.white);
        if (linkIndex != -1)
        {
            linkIndexOld = linkIndex;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (linkIndex != -1)
        {
            SetLinkToColor(linkIndex, Color.white);
        
        }
    }
}
