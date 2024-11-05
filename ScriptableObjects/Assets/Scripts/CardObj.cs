using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "New Card" , menuName = "ScriptableObjects/Cards" , order = 0)] 



public class CardObj : ScriptableObject
{
    //Declare the variables used in our scriptable object
    public int startHealth;

    public string CardName;

    public Sprite CardImage;

    public string CardQuote;

    public int attack;

    public int health;

    public CardObj NextCard;
}
