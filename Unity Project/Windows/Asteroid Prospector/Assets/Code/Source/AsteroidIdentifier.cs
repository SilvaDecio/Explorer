using UnityEngine;

using System.Collections;

public class AsteroidIdentifier : Identifier
{
	public string Mass , Temperature , Dimension , Densitity , Gravity;

    public AsteroidIdentifier (int id)
    {
        Id = id;

		Image = Resources.Load("Textures/Asteroids/Asteroid" + Id) as Texture2D;

        # region Level 1 Asteroids

        if (Id == 1)
        {
			Name = "Ceres";

			Mass = "9.5 x 10 ^ 20";
			Temperature = "-106";
			Dimension = "950";
			Densitity = "2.8";
			Gravity = "0.28";

            Level = IdentifierLevel.Level1;
        }
		else if(Id == 2)
		{
			Name = "Palas";

			Mass = "2.11 x 10 ^ 20";
			Temperature = "-109.1";
			Dimension = "544";
			Densitity = "2.8";
			Gravity = "0.18";

            Level = IdentifierLevel.Level1;
		}
		else if(Id == 3)
		{
			Name = "Juno";

            Mass = "2.67 x 10 ^ 19";
			Temperature = "-110.1";
			Dimension = "233";
			Densitity = "2.98";
			Gravity = "0.12";

            Level = IdentifierLevel.Level1;
		}
		else if(Id == 4)
		{
			Name = "Vesta";

            Mass = "2.67 x 10 ^ 20";
			Temperature = "-103";
			Dimension = "529";
			Densitity = "3.424";
			Gravity = "0.22";

            Level = IdentifierLevel.Level1;
		}
		else if(Id == 5)
		{
			Name = "Astreia";

            Mass = "2.9 x 10 ^ 18";
			Temperature = "-58.1";
			Dimension = "119";
			Densitity = "3.33";
			Gravity = "0.023";

            Level = IdentifierLevel.Level1;
        }

        # endregion

        # region Level 2 Asteroids

        else if(Id == 6)
		{
			Name = "Hebe";

            Mass = "1.28 x 10 ^ 24";
			Temperature = "-103.1";
			Dimension = "186";
			Densitity = "3.81";
			Gravity = "0.087";

            Level = IdentifierLevel.Level2;
		}
		else if(Id == 7)
		{
			Name = "Iris";

            Mass = "1.36 x 10 ^ 24";
			Temperature = "-102.1";
			Dimension = "198.8";
			Densitity = "2.72";
			Gravity = "0.055";

            Level = IdentifierLevel.Level2;
		}
		else if(Id == 8)
		{
			Name = "Metis";

            Mass = "1.113 x 10 ^ 19";
			Temperature = "-100.15";
			Dimension = "190";
			Densitity = "4.12";
			Gravity = "0.023";

            Level = IdentifierLevel.Level2;
		}
		else if(Id == 9)
		{
			Name = "Higia";

            Mass = "9.3 x 10 ^ 20";
			Temperature = "-112";
			Dimension = "407.1";
			Densitity = "2.76";
			Gravity = "0.1603";

            Level = IdentifierLevel.Level2;
		}
		else if(Id == 10)
		{
			Name = "Partenope";

            Mass = "5.13 x 10 ^ 20";
			Temperature = "-91";
			Dimension = "153.3";
			Densitity = "2.72";
			Gravity = "0.0578";

            Level = IdentifierLevel.Level2;
        }

        # endregion

        # region Level 3 Asteroids

        else if(Id == 11)
		{
			Name = "Tetis";

            Mass = "1.2 x 10 ^ 18";
			Temperature = "-100.1";
			Dimension = "90";
			Densitity = "3.21";
			Gravity = "0.0252";

            Level = IdentifierLevel.Level3;
		}
		else if(Id == 12)
		{
			Name = "Melpomene";

            Mass = "3 x 10 ^ 18";
			Temperature = "-95";
			Dimension = "140.61";
			Densitity = "1.69";
			Gravity = "0.0393";

            Level = IdentifierLevel.Level3;
		}
		else if(Id == 13)
		{
			Name = "Fortuna";

            Mass = "93.15 x 10 ^ 19";
			Temperature = "-225";
			Dimension = "225";
			Densitity = "2.70";
			Gravity = "0.0629";

            Level = IdentifierLevel.Level3;
		}
		else if(Id == 14)
		{
			Name = "Gaspra";

            Mass = "2.3 x 10 ^ 16";
			Temperature = "-91";
			Dimension = "525";
			Densitity = "2.7";
			Gravity = "0.002";

            Level = IdentifierLevel.Level3;
		}
		else if(Id == 15)
		{
			Name = "Eunomia";

            Mass = "3.12 x 10 ^ 19";
			Temperature = "-107";
			Dimension = "268";
			Densitity = "3.09";
			Gravity = "0.08";

            Level = IdentifierLevel.Level3;
        }

        # endregion
    }
}