using UnityEngine;

using System.Collections;

public class Button
{
	public Texture2D Image;
	
	public Rect BoundingRectangle;
	
	public bool Clicked;
	
	public Button (string ImagePath, Vector2 Position)
	{
		Image = (Texture2D)Resources.Load(ImagePath);
        
		BoundingRectangle = new Rect(Position.x , Position.y , Image.width , Image.height);
		
		Clicked = false;
	}
	
	public void Draw ()
	{
		Clicked = GUI.Button(BoundingRectangle , Image);		
	}

    public void Draw (GUIStyle ButtonStyle)
    {
        Clicked = GUI.Button(BoundingRectangle , Image , ButtonStyle);
    }

    public void DrawRepeat ()
    {
        Clicked = GUI.RepeatButton(BoundingRectangle , Image);
    }

    public void DrawRepeat (GUIStyle RepeatButtonStyle)
    {
        Clicked = GUI.RepeatButton(BoundingRectangle , Image , RepeatButtonStyle);
    }
}