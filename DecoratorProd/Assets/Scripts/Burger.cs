using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour, IBurger
{
    private readonly BurgerConfig _burgerConfig;
    public string Type {
        get
        {
            return _burgerConfig.Type;
        }
    }
    
    public GameObject Self { get { return _burgerConfig.Self; } }
    public Burger(BurgerConfig burgerConfig)
    {
        _burgerConfig = burgerConfig;
    }
}