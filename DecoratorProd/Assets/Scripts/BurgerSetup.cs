using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BurgerSetup : MonoBehaviour
{
    public BurgerConfig _burgerConfig;
    public IBurger _burger;
    private void Start()
    {
        _burger = new Burger(_burgerConfig);
    }
    public void Decorate(IBurger burger, BurgerComponent burgerComponent, float count)
    {
        _burger = new BurgerDecorator(burger, burgerComponent, count);
    }
    public void Reset()
    {
        SceneManager.LoadScene(1);
        _burger = new Burger(_burgerConfig);
    }
}
