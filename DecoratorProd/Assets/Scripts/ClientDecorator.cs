using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    public List<BurgerComponent> burgerComponents;
    public BurgerSetup burgerSetup;
    public float count;
    private void OnGUI()
    {
        if (GUILayout.Button("Create Bun"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[0], count);
            count++;
        }
        if (GUILayout.Button("Create Patty"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[1], count);
            count++;
        }
        if (GUILayout.Button("Create Cheese"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[2], count);
            count++;
        }
        if (GUILayout.Button("Create Lettuce"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[3], count);
            count++;
        }
        if (GUILayout.Button("Create Tomato"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[4], count);
            count++;
        }
        if (GUILayout.Button("Create Bacon"))
        {
            burgerSetup.Decorate(burgerSetup._burger, burgerComponents[5], count);
            count++;
        }
        if (GUILayout.Button("Reset Burger"))
        {
            burgerSetup.Reset();
            count = 0;
        }
    }
}
