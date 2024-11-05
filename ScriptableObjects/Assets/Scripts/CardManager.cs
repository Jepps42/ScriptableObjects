using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //Variables

    public SpriteRenderer CardPic;

    public CardObj CurrentCard;

    public TextMeshProUGUI CardName;

    public TextMeshProUGUI CardQuote;

    public TextMeshProUGUI Health;

    public List<CardObj> Cards = new List<CardObj>();

    private UnityEngine.Object[] loadcards;

    // Start is called before the first frame update
    void Start()
    {
        loadcards = Resources.LoadAll<CardObj>("ScriptableObjects/Cards");
        foreach (CardObj c in loadcards)
        {
            c.health = c.startHealth;
            Cards.Add(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CardPic.sprite = CurrentCard.CardImage;
        CardQuote.text = CurrentCard.CardQuote;
        CardName.text = CurrentCard.CardName;
        Health.text = " " + CurrentCard.health;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CurrentCard = CurrentCard.NextCard;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            CurrentCard.health -= CurrentCard.NextCard.attack;
        }
    }
}
