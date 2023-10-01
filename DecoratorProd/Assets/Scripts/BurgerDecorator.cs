using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerDecorator : ScriptableObject, IBurger
{
    private readonly IBurger _burger;
    private readonly BurgerComponent _burgerComponent;
    GameObject spawn;
    public BurgerDecorator(IBurger burger, BurgerComponent burgerComponent, float count)
    {
        _burger = burger;
        _burgerComponent = burgerComponent;
        Vector3 position = new Vector3(0, (count/10), 0);
        Debug.Log(position);
        spawn =Instantiate(burgerComponent.Self, position, Quaternion.identity);
        if (_burger.Type != null)
        {
            Debug.Log(_burger.Type);
        }
    }
    public string Type
    {
        get 
        {
            if (_burger != null)
            {
                return _burger.Type + _burgerComponent.Type;
            }
            return _burgerComponent.Type;
        }
    }
    public GameObject Self
    {
        get { return spawn; }
    }
}
