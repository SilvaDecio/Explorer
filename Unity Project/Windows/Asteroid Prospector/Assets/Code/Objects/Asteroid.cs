using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Asteroid : MonoBehaviour
{
    public AsteroidIdentifier Source;

    public int Id;

    public List<ItemIdentifier> Items;

    // Use this for initialization
	void Start ()
    {
        Source = new AsteroidIdentifier(Id);

        Items = new List<ItemIdentifier>();

        for (int i = 0; i < 4; i++)
        {
            int id = 0;

            switch (Source.Level)
            {
                case IdentifierLevel.Level1:

                    id = Random.Range(1, 6);

                    break;

                case IdentifierLevel.Level2:

                    id = Random.Range(7, 11);

                    break;

                case IdentifierLevel.Level3:

                    id = Random.Range(12, 15);

                    break;
            }
            
            //int id = Random.Range(SpaceController.MissionItems.ItemsStart[Source.Level], SpaceController.MissionItems.ItemsStart[Source.Level] + SpaceController.MissionItems.ItemsPerLevel[Source.Level]);

            Items.Add(new ItemIdentifier(id));
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnMouseDown ()
    {
        SpaceController.GetAsteroidScene(Source , Items);
    }
}