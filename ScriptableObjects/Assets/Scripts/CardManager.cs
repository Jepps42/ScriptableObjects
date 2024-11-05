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
    // Start is called before the first frame update
    void Start()
    {
        
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
