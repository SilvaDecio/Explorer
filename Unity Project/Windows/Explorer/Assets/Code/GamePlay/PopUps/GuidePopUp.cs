using UnityEngine;

using System.Collections;

public class GuidePopUp : PopUpController
{
    bool ativaSegundaTela;
    Texture segundaTela, botaoTrocaDeGuide;

    public GuidePopUp() : base("Textures/PopUps/Guide1", "Buttons/Back", new Vector2(25, Screen.height - 62 - 25))
    {
        ativaSegundaTela = false;
        segundaTela = Resources.Load("Textures/PopUps/Guide2") as Texture2D;
        botaoTrocaDeGuide = Resources.Load("Buttons/Guide") as Texture2D;
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
        //base.Draw(BackButtonStyle);

        if (ativaSegundaTela)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), segundaTela);
        }
        else
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BackGround);
        }

        if (GUI.Button(new Rect(Screen.width - botaoTrocaDeGuide.width - 20, 25, botaoTrocaDeGuide.width, botaoTrocaDeGuide.height), botaoTrocaDeGuide, GUIStyle.none))
        {
            ativaSegundaTela = !ativaSegundaTela;
        }

        BackButton.Draw(GUIStyle.none);

        if (BackButton.Clicked)
        {
            SpaceController.GetSpaceScene();
        }
    }
}