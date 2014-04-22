using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class AsteroidPopUp : PopUpController
{
    Button ExploreButton;

    AsteroidIdentifier Source;

    List<ItemIdentifier> Items;

    TextBlock NameLabel , MassLabel , TemperatureLabel , DimensionLabel , DensitityLabel , GravityLabel;

    Texture2D Photo;

    Rect BoundingPhoto;

    public AsteroidPopUp(AsteroidIdentifier source , List<ItemIdentifier> items) : base("Textures/PopUps/Asteroid" , "Buttons/Back" , new Vector2(15 , 15))
    {
        Source = source;

        if (Source.Level > SpaceController.MissionItems.CurrentLevel)
        {
            ExploreButton = new Button("Buttons/NoExplore", new Vector2(Screen.width - 301 , Screen.height - 70));
        }
        else
        {
            ExploreButton = new Button("Buttons/Explore", new Vector2(Screen.width - 301 , Screen.height - 70));
        }

        Items = items;

        # region Text Blocks

        NameLabel = new TextBlock(new Vector2(200 , 75) , Source.Name);
        MassLabel = new TextBlock(new Vector2(255 , Screen.height - 270) , Source.Mass + " kg");
        TemperatureLabel = new TextBlock(new Vector2(275 , Screen.height - 215) , Source.Temperature + " ºC");
        DimensionLabel = new TextBlock(new Vector2(275 , Screen.height - 160) , Source.Dimension + " Km");
        DensitityLabel = new TextBlock(new Vector2(275 , Screen.height - 105) , Source.Densitity + " g/cm³");
        GravityLabel = new TextBlock(new Vector2(275 , Screen.height - 50) , Source.Gravity + " m/s²");

        # endregion

        Photo = Source.Image;

        BoundingPhoto = new Rect(Screen.width - 250 , 75 , Photo.width , Photo.height);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SpaceController.GetSpaceScene();
        }
    }

    public void Draw(GUIStyle BackButtonStyle , GUIStyle NameStyle , GUIStyle OtherStyle)
    {
        base.Draw(BackButtonStyle);

        ExploreButton.Draw(BackButtonStyle);

        if(ExploreButton.Clicked)
        {
            if (Source.Level <= SpaceController.MissionItems.CurrentLevel)
            {
                SpaceController.GetExploreScene(Source, Items);
            }
        }

        if (BackButton.Clicked)
        {
            SpaceController.GetSpaceScene();
        }

        # region Text Blocks

        NameLabel.Draw(NameStyle);
        MassLabel.Draw(OtherStyle);
        TemperatureLabel.Draw(OtherStyle);
        DimensionLabel.Draw(OtherStyle);
        DensitityLabel.Draw(OtherStyle);
        GravityLabel.Draw(OtherStyle);

        # endregion

        GUI.DrawTexture(BoundingPhoto, Photo);
    }
}