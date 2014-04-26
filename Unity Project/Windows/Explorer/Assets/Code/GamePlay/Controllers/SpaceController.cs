using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public enum GamePlayState
{
    Space , Guide , Inventary , Asteroid , Explore
}

public class SpaceController : MonoBehaviour
{
    Button GuideButton, InventaryButton;

    public static Inventary MissionItems;

    # region Controllers

    public static GamePlayState CurrentState;

    static AsteroidPopUp AsteroidScene;

    static ExplorePopUp ExploreScene;

    static GuidePopUp GuideScene;

    static InventaryPopUp InventaryScene;

    # endregion

    public GUIStyle BackButtonStyle , NameStyle , OtherStyle;

    // Use this for initialization
    void Start()
    {
        # region Buttons

        GuideButton = new Button("Buttons/Guide" , new Vector2(50 , 50));

        InventaryButton = new Button("Buttons/Inventary" , new Vector2(Screen.width - 137 , 50));

        # endregion

        MissionItems = new Inventary();

        # region Pop Up's

        CurrentState = GamePlayState.Space;

        GuideScene = new GuidePopUp();

        InventaryScene = new InventaryPopUp();

        # endregion
    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentState)
        {
            case GamePlayState.Space:

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }

                break;

            case GamePlayState.Guide:

                GuideScene.Update();

                break;

            case GamePlayState.Inventary:

                InventaryScene.Update();

                break;

            case GamePlayState.Asteroid:

                AsteroidScene.Update();

                break;

            case GamePlayState.Explore:

                ExploreScene.Update();

                break;
        }
    }

    void OnGUI()
    {
        switch (CurrentState)
        {
            case GamePlayState.Space:

                GuideButton.Draw(BackButtonStyle);
                InventaryButton.Draw(BackButtonStyle);

                if (GuideButton.Clicked)
                {
                    GetGuideScene();
                }

                if (InventaryButton.Clicked)
                {
                    GetInventaryScene();
                }

                break;

            case GamePlayState.Guide:

                GuideScene.Draw(BackButtonStyle);

                break;

            case GamePlayState.Inventary:

                InventaryScene.Draw(BackButtonStyle);

                break;

            case GamePlayState.Asteroid:

                AsteroidScene.Draw(BackButtonStyle , NameStyle , OtherStyle);
                
                break;

            case GamePlayState.Explore:

                ExploreScene.Draw(BackButtonStyle);
                
                break;
        }
    }

    public static void GetSpaceScene()
    {
        CurrentState = GamePlayState.Space;
    }

    public static void GetAsteroidScene(AsteroidIdentifier Source , List<ItemIdentifier> Items)
    {
        CurrentState = GamePlayState.Asteroid;

        AsteroidScene = new AsteroidPopUp(Source , Items);
    }

    public static void GetExploreScene(AsteroidIdentifier Source, List<ItemIdentifier> Items)
    {
        CurrentState = GamePlayState.Explore;

        ExploreScene = new ExplorePopUp(Source , Items);
    }

    public static void GetInventaryScene ()
    {
        CurrentState = GamePlayState.Inventary;
    }

    public static void GetGuideScene ()
    {
        CurrentState = GamePlayState.Guide;
    }
}