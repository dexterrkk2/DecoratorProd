using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewBurgerConfig", menuName = "Burger/Config", order = 1)]
public class BurgerConfig : ScriptableObject, IBurger
{
    public string type;
    public GameObject self;
    public string Type
    {
        get
        {
            return type;
        }
    }
    public GameObject Self
    {
        get
        {
            return self;
        }
    }
}
