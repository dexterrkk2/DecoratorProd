using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewBurgerPart",menuName = "Burger/Part", order = 1)]
public class BurgerComponent : ScriptableObject, IBurger
{
    [Tooltip("Burger object")]
    [SerializeField] private string type ="";
    [Tooltip("This object")]
    [SerializeField] private GameObject self;

    public string Type { get { return type; } }
    public GameObject Self { get { return self; } }
}