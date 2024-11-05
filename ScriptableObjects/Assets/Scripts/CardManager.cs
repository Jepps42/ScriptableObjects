using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //Variables

    public SpriteRenderer CardPic;

    public CardObj CurrentCard;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CardPic.sprite = CurrentCard.CardImage;
    }
}
