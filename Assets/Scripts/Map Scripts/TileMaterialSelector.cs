using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TileMaterialSelector : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
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
        textMeshPro.text += "<link=Dirt>Dirt</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Street>Street</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=HouseTile>House Tile</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=DungeonTile>Dungeon Tile</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=ColoredHouseTile>Colored House Tile</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Cobblestone>Cobblestone</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Bridge>Bridge</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Forest>Forest</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Mountain>Mountain</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=StonePathway>Stone Pathway</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Vine>Vine</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Grass>Grass</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=LavaGround>Lava Ground</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Bricks>Bricks</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=OverGrownWall>OverGrown Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=StoneWall>Stone Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=GraniteWall>Granite Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Rivers>Water</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Lava>Lava</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Carpet>Carpet</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Snow>Snow</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SnowyWall>Snowy Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SnowyRock>Snowy Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SnowyMountain>Snowy Mountain</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Ice>Ice</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Sand>Sand</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SandFlow>Sand Flow</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SandyGrass>Sandy Grass</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SandStone>Sandstone</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=SandStoneWall>Sandstone Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=roughRoad>Rough Road</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Roof>Roof</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=MossyRock>Mossy Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Limestone>Limestone</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Quartz>Quartz</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Obsidian>Obsidian</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=OtherCarpet>Dark Carpet</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Poison>Poison</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Swamp>Swamp</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=MoltenRock>Molten Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=MossyPuddle>Mossy Puddle</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=Rusty>Rusty</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=RedRock>Red Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=RedRockWall>Red Rock Wall</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=DarkRedRock>Dark Red Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=DarkRedRock>Dark Red Rock</link>";
        textMeshPro.text += "\n";
        textMeshPro.text += "<link=OrangeRedRock>Orange Red Rock</link>";
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
        GameObject.FindObjectOfType<MiddleManStorage>().AssignMaterial(pick, display);
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
