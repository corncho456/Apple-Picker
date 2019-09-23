using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string suit;
    public int rank;
    public GameObject back;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class CardDefinition
{
    public string face;
    public int rank;
    public List<CardSprite> pips = new List<CardSprite>();
}

public class CardSprite
{
    public Sprite image;

}