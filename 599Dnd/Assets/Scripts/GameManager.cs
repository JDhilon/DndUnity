using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    //private ItemButton clickedbtn;


    public ItemButton Clickedbtn { get; private set; }
    /*
    [SerializeField]
    private GameObject monsterPrefab;

    public GameObject MonsterPrefab
    {
        get
        {
            return monsterPrefab;
        }
    }

    */

    public void chooseItem(ItemButton itembtn)
    {
        this.Clickedbtn = itembtn;
    }
}
