using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class NumberManger : MonoBehaviour
{
    [SerializeField] ChangeBackground cam;
    [SerializeField] ScoreField score;
    [SerializeField] CardManager[] cards;
    [SerializeField] int min = 0;
    [SerializeField] int max = 10;
    private int num, chosenCard;
    void SetCard(int index, bool isTheCard)
    {
        int ans = num;
        if (!isTheCard)
        {
            while (ans == num)
            {
                ans = Random.Range(min, max + 1);
            }
        }
        int a = Random.Range(min, max + 1);
        if (a > ans)
        {
            int b = a - ans;
            cards[index].SetNumbers(a, '-', b);
        }
        else
        {
            int b = ans - a;
            cards[index].SetNumbers(a, '+', b);
        }
    }
    void NewRound()
    {
        num = Random.Range(min, max + 1);
        GetComponent<TextMeshPro>().text = num.ToString();
        chosenCard = Random.Range(0, cards.Length);
        SetCard(chosenCard, true);
        for (int i = 0; i < cards.Length; i++)
        {
            if (i != chosenCard)
            {
                SetCard(i, false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        NewRound();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Press(int cardIndex)
    {
        if (cardIndex == chosenCard)
        {
            StartCoroutine(cam.ChangeColor(Color.green));
            score.AddNumber(1);
            NewRound();
        }
        else
        {
            StartCoroutine(cam.ChangeColor(Color.red)); 
        }
    }
}
