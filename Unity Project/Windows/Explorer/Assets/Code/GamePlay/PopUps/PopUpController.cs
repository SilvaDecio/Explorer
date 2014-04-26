using UnityEngine;

using System.Collections;

public class PopUpController
{
    protected Texture2D BackGround;

    protected Button BackButton;

    public PopUpController (string BackGroundPath , string BackButtonPath , Vector2 BackButtonPosition)
    {
        BackGround = Resources.Load(BackGroundPath) as Texture2D;

        BackButton = new Button(BackButtonPath, BackButtonPosition);
    }

    public void Draw (GUIStyle BackButtonStyle)
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BackGround);

        BackButton.Draw(BackButtonStyle);
    }
}
