using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    const int num_of_card = 52;
    public string suit;
    public int suitNum;
    public int rank;
    public GameObject back;
    public GameObject cObject;


    public Card(string _suit,int _rank)
    {
        suit = _suit;
        rank = _rank;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class CardDefinition
    {
        public string face;
        public int rank;
    }

    public bool faceUp
    {
        get
        {
            return (!back.activeSelf);
        }
        set
        {
            back.SetActive(!value);
        }
    }



}



