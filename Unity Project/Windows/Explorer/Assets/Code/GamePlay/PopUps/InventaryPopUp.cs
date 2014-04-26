using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class InventaryPopUp : PopUpController
{
    Dictionary<IdentifierLevel, List<ItemIdentifier>> items = new Dictionary<IdentifierLevel, List<ItemIdentifier>>();
	List<ItemIdentifier> itemsLevel4 = new List<ItemIdentifier> ();

    public InventaryPopUp() : base("Textures/PopUps/Inventary", "Buttons/Back", new Vector2(25 , 25))
    {
        for (IdentifierLevel i = IdentifierLevel.Level1; i < IdentifierLevel.Level3+1; i++)
		{
            List<ItemIdentifier> listaDoLevel = new List<ItemIdentifier>();
            
            for (int j = 0; j < SpaceController.MissionItems.ItemsPerLevel[i]; j++)
			{
                listaDoLevel.Add(new ItemIdentifier(j + SpaceController.MissionItems.ItemsStart[i]));
			}
			 items.Add((IdentifierLevel)i,listaDoLevel);
		}
        
		itemsLevel4.Add (new ItemIdentifier (6));
		itemsLevel4.Add (new ItemIdentifier (17));
		itemsLevel4.Add (new ItemIdentifier (18));
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SpaceController.GetSpaceScene();
        }
    }

    public void Draw(GUIStyle BackButtonStyle)
    {
        base.Draw(BackButtonStyle);

        for (int j = 0; j < items[IdentifierLevel.Level1].Count; j++)
            {
            
                GUI.DrawTexture(new Rect(j * items[IdentifierLevel.Level1][j].Image.width * 0.75f + 60, Screen.height - 95,
                    items[IdentifierLevel.Level1][j].Image.width * 0.75f, items[IdentifierLevel.Level1][j].Image.height * 0.75f), items[IdentifierLevel.Level1][j].Image);

                GUI.Label(new Rect(j * items[IdentifierLevel.Level1][j].Image.width * 0.75f + 50 + items[IdentifierLevel.Level1][j].Image.width /2 * 0.75f, Screen.height - 95 + items[IdentifierLevel.Level1][j].Image.height * 0.75f,
                    items[IdentifierLevel.Level1][j].Image.width * 0.75f, items[IdentifierLevel.Level1][j].Image.height * 0.75f),
                    SpaceController.MissionItems.ItemsNumber[items[IdentifierLevel.Level1][j].Id] + "/" + SpaceController.MissionItems.MaxItensCount[items[IdentifierLevel.Level1][j].Id], GUIStyle.none);
            }
        for (int j = 0; j < items[IdentifierLevel.Level2].Count; j++)
        {

            GUI.DrawTexture(new Rect(j * items[IdentifierLevel.Level2][j].Image.width * 0.75f + 120, Screen.height - 210,
                items[IdentifierLevel.Level2][j].Image.width * 0.75f, items[IdentifierLevel.Level2][j].Image.height * 0.75f), items[IdentifierLevel.Level2][j].Image);

            GUI.Label(new Rect(j * items[IdentifierLevel.Level2][j].Image.width * 0.75f + 110 + items[IdentifierLevel.Level2][j].Image.width /2 * 0.75f, Screen.height - 210 + items[IdentifierLevel.Level2][j].Image.height * 0.75f,
                    items[IdentifierLevel.Level2][j].Image.width * 0.75f, items[IdentifierLevel.Level2][j].Image.height * 0.75f),
                    SpaceController.MissionItems.ItemsNumber[items[IdentifierLevel.Level2][j].Id] + "/" + SpaceController.MissionItems.MaxItensCount[items[IdentifierLevel.Level2][j].Id], GUIStyle.none);
        }
        for (int j = 0; j < items[IdentifierLevel.Level3].Count; j++)
        {

            GUI.DrawTexture(new Rect(j * items[IdentifierLevel.Level3][j].Image.width * 0.65f + 200, Screen.height - 330,
                items[IdentifierLevel.Level3][j].Image.width * 0.65f, items[IdentifierLevel.Level3][j].Image.height * 0.65f), items[IdentifierLevel.Level3][j].Image);

            GUI.Label(new Rect(j * items[IdentifierLevel.Level3][j].Image.width * 0.65f + 190 + items[IdentifierLevel.Level3][j].Image.width /2 * 0.65f, Screen.height - 330 + items[IdentifierLevel.Level3][j].Image.height * 0.65f,
                    items[IdentifierLevel.Level3][j].Image.width * 0.65f, items[IdentifierLevel.Level3][j].Image.height * 0.65f),
                    SpaceController.MissionItems.ItemsNumber[items[IdentifierLevel.Level3][j].Id] + "/" + SpaceController.MissionItems.MaxItensCount[items[IdentifierLevel.Level2][j].Id], GUIStyle.none);
        }

		if(SpaceController.MissionItems.ItemsPerLevel[IdentifierLevel.Level3] == SpaceController.MissionItems.MaxLevelItens[IdentifierLevel.Level3])
			for (int i = 0; i < 3; i++) {
			GUI.DrawTexture(new Rect(i*itemsLevel4[i].Image.width * 0.6f + 250,40,itemsLevel4[i].Image.width * 0.6f,itemsLevel4[i].Image.height * 0.6f), itemsLevel4[i].Image);
						}
        
        if (BackButton.Clicked)
        {
            SpaceController.GetSpaceScene();
        }
    }
}