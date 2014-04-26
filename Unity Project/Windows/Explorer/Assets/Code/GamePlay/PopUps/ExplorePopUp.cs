using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class ExplorePopUp : PopUpController
{
    AsteroidIdentifier Source;

    List<ItemIdentifier> Items;

    List<Rect> BoundingItems;

    Vector2 TouchPoint;

    public ExplorePopUp (AsteroidIdentifier source , List<ItemIdentifier> items) : base("Textures/PopUps/Explore" , "Buttons/Finish" , new Vector2((Screen.width / 2) - 125 , Screen.height - 70)) 
    {
        Source = source;

        Items = items;

        BoundingItems = new List<Rect>();

        BoundingItems.Add(new Rect(125 , 75 , Items[0].Image.width , Items[0].Image.height));
        BoundingItems.Add(new Rect(Screen.width - 300 , 75 , Items[0].Image.width , Items[0].Image.height));
        BoundingItems.Add(new Rect(125 , Screen.height - 175 , Items[0].Image.width , Items[0].Image.height));
        BoundingItems.Add(new Rect(Screen.width - 300 , Screen.height - 175 , Items[0].Image.width , Items[0].Image.height));

        TouchPoint = new Vector2();
    }

    public void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SpaceController.GetSpaceScene();
        }
    }

    public void Draw(GUIStyle BackButtonStyle)
    {
        base.Draw(BackButtonStyle);

        for (int i = 0; i < Items.Count; i++)
        {
            GUI.DrawTexture(BoundingItems[i], Items[i].Image);
        }

        // PC & Web
        if (Input.GetMouseButtonDown(0))
        {
            TouchPoint = new Vector2(Input.mousePosition.x , Screen.height - Input.mousePosition.y);
        }
        else
        {
            TouchPoint = new Vector2();
        }

        // Mobile
        //if (Input.touchCount > 0)
        //{
        //    TouchPoint = Input.GetTouch(0).position;
        //}
        //else
        //{
        //    TouchPoint = new Vector2();
        //}

        for (int i = 0; i < BoundingItems.Count; i++)
        {
            if (BoundingItems[i].Contains(TouchPoint))
            {
                if (SpaceController.MissionItems.Collect(Items[i]))
                {
                    SpaceController.MissionItems.Add(Items[i]);
                    
                    Items.RemoveAt(i);
                    
                    BoundingItems.RemoveAt(i);

                    break;
                }
                else
                {
                    //dizer q n add no inventario
                }
            }
        }

        // Finish Button
        if (BackButton.Clicked)
        {
            SpaceController.GetSpaceScene();
        }
    }
}