using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI BurgerOrder;
    public TextMeshProUGUI score;
    public BurgerSetup burgerSetup;
    public string order;
    public ClientDecorator clientDecorator;
    private void Start()
    {
        createOrder();
    }
    public void OrderCheck()
    {
        if (burgerSetup._burger.Type == order)
        {
            Debug.Log("OrderComplete");
            Data.score++;
            order = "Good Job!";
            Data.orderSize++;
            burgerSetup.Invoke("Reset", 2f);
        }
    }
    public void createOrder()
    {
        order = "Bun";
        for (int i =0; i< Data.orderSize; i++)
        {
            int random = Random.Range(0, clientDecorator.burgerComponents.Count);
            order += clientDecorator.burgerComponents[random].Type;
        }
        order += "Bun";
    }
    private void Update()
    {
        score.text = "Score " + Data.score;
        OrderCheck();
        BurgerOrder.text = "Please fulfill this Order:" + order;
        if(Data.score == 5)
        {
            EndGame();
        }
    }
    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Data.shifts++;
    }
}
