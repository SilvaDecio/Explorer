using UnityEngine;

using System.Collections;

public class ItemIdentifier : Identifier
{
    public ItemIdentifier(int id)
    {
        Id = id;

        Image = Resources.Load("Textures/Items/Item" + Id) as Texture2D;

        # region Level 1 Items

        if (Id == 1)
        {
            Name = "Water";
            Level = IdentifierLevel.Level1;
        }
        else if (Id == 2)
        {
            Name = "Magnesium";
            Level = IdentifierLevel.Level1;
        }
        else if (Id == 3)
        {
            Name = "Carbon";
            Level = IdentifierLevel.Level1;
        }
        else if (Id == 4)
        {
            Name = "Iron";
            Level = IdentifierLevel.Level1;
        }
        else if (Id == 5)
        {
            Name = "Nickel";
            Level = IdentifierLevel.Level1;
        }
        else if (Id == 6)
        {
            Name = "S Pill";
            Level = IdentifierLevel.Level1;
        }

        # endregion

        # region Level 2 Items

        else if (Id == 7)
        {
            Name = "T Pill";
            Level = IdentifierLevel.Level2;
        }
        else if (Id == 8)
        {
            Name = "E Pill";
            Level = IdentifierLevel.Level2;
        }
        else if (Id == 9)
        {
            Name = "T Pill";
            Level = IdentifierLevel.Level2;
        }
        else if (Id == 10)
        {
            Name = "I Pill";
            Level = IdentifierLevel.Level2;
        }
        else if (Id == 11)
        {
            Name = "S Pill";
            Level = IdentifierLevel.Level2;
        }

        # endregion

        # region Level 3 Items

        else if (Id == 12)
        {
            Name = "I Pill";
            Level = IdentifierLevel.Level3;
        }
        else if (Id == 13)
        {
            Name = "R Pill";
            Level = IdentifierLevel.Level3;
        }
        else if (Id == 14)
        {
            Name = "I Pill";
            Level = IdentifierLevel.Level3;
        }
        else if (Id == 15)
        {
            Name = "S Pill";
            Level = IdentifierLevel.Level3;
        }

        # endregion

        # region Level 4 Items

        else if (Id == 16)
        {
            Name = "S Pill";
            //Level = IdentifierLevel.Level4;
        }
        else if (Id == 17)
        {
            Name = "U Pill";
            //Level = IdentifierLevel.Level4;
        }
        else if (Id == 18)
        {
            Name = "N Pill";
            //Level = IdentifierLevel.Level4;
        }

        # endregion
    }
}