using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Endgame : MonoBehaviour
{
    public TextMeshProUGUI Shifts;
    public void StartScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        Shifts.text = "You have completed " + Data.shifts + " Shifts. You have " + (1000-Data.shifts) + " Left.";
    }
}
