using UnityEngine;

using System.Collections;

public enum IdentifierLevel
{
    Level1 , Level2 , Level3
}

public class Identifier
{
    public int Id;

    public string Name;

    public Texture2D Image;

    public IdentifierLevel Level;
}