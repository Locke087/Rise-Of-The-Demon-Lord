using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TileShapeSelector : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textMeshPro;
    public int linkIndex = 0;
    public int linkIndexOld = 0;
    public Camera camera;
    public ScrollRect scroll;

    // Use this for initialization
    void Start()
    {
        scroll.content = textMeshPro.GetComponent<RectTransform>();
        textMeshPro.text += "<link=Normal>Normal Tile</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=RampE>Ramp</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Walls>Set Walls</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LongWall>Extending Walls</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=ChestC>Treasure Chest</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=DoorC>Locked Door</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Rivers>River Vertical</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=RiverH>River Horizontal</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=RiverC>River Corner</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LakeC>Lake Corner</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LakeS>Lake Side</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LakeM>Lake Middle</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaR>Lava River Vertical</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaH>Lava River Horizontal</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaRC>Lava River Corner</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaLC>Lava Lake Corner</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaLS>Lava Lake Side</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaLM>Lava Lake Middle</link>";
        textMeshPro.text += "\n";
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, GetComponent<Camera>());
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
        GameObject.FindObjectOfType<MiddleManStorage>().AssignShape(pick, display);
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
            Debug.Log("ImHereE");
        }
    }
}
