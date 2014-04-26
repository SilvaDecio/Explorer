using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Inventary
{
    public Dictionary<IdentifierLevel , int> MaxLevelItens , ItemsPerLevel , ItemsStart;

    public Dictionary<int , int> ItemsNumber , MaxItensCount;

    public IdentifierLevel CurrentLevel;

    public Inventary ()
    {
        CurrentLevel = IdentifierLevel.Level1;

        ItemsNumber = new Dictionary<int , int>();

        for (int i = 1; i < 16; i++)
        {
            ItemsNumber.Add(i , 0);
        }


        MaxItensCount = new Dictionary<int , int>();

        MaxItensCount.Add(1 , 1);
        MaxItensCount.Add(2 , 2);
        MaxItensCount.Add(3 , 3);
        MaxItensCount.Add(4 , 3);
        MaxItensCount.Add(5 , 2);
        MaxItensCount.Add(6 , 1);

        MaxItensCount.Add(7 , 2);
        MaxItensCount.Add(8 , 4);
        MaxItensCount.Add(9 , 4);
        MaxItensCount.Add(10 , 4);
        MaxItensCount.Add(11 , 2);

        MaxItensCount.Add(12 , 3);
        MaxItensCount.Add(13 , 6);
        MaxItensCount.Add(14 , 6);
        MaxItensCount.Add(15 , 3);


        MaxLevelItens = new Dictionary<IdentifierLevel , int>();

        MaxLevelItens.Add(IdentifierLevel.Level1 , 12);
        MaxLevelItens.Add(IdentifierLevel.Level2 , 16);
        MaxLevelItens.Add(IdentifierLevel.Level3 , 18);


        ItemsPerLevel = new Dictionary<IdentifierLevel , int>();

        ItemsPerLevel.Add(IdentifierLevel.Level1 , 6);
        ItemsPerLevel.Add(IdentifierLevel.Level2 , 5);
        ItemsPerLevel.Add(IdentifierLevel.Level3 , 4);


        ItemsStart = new Dictionary<IdentifierLevel , int>();

        ItemsStart.Add(IdentifierLevel.Level1 , 1);
        ItemsStart.Add(IdentifierLevel.Level2 , 7);
        ItemsStart.Add(IdentifierLevel.Level3 , 12);
    }

    public bool Collect (ItemIdentifier Collected)
    {
        return ItemsNumber[Collected.Id] < MaxItensCount[Collected.Id];
    }

    public void Add (ItemIdentifier Collected)
    {
        ItemsNumber[Collected.Id]++;
    }
}