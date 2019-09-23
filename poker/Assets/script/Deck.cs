using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Deck : MonoBehaviour
{

    public List<string> cardNames;
    public List<Card> cards;

    public Sprite[] cardSprites;
    public GameObject prefabCard;
    //public Sprite prefabSprite;

    // Start is called before the first frame update
    void Start()
    {
        MakeCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void MakeCard()
    {
        //스프라이트를 각 카드에 맞게 할당함
        //각 세트는 1~13으로 구성됨 2~10,j,q,k,a이므로
        cardNames = new List<string>();
        
        string[] letters = new string[] { "S", "D", "H", "C" };
        
        foreach(string s in letters)
        {
            for(int i = 0; i < 13; i++)
            {
                cardNames.Add(s+(i+1));
            }

        }
                
        cards = new List<Card>();
        Sprite tS = null;
        GameObject tGO = null;
        SpriteRenderer tSR = null;
        print(cardNames.Count);

        for (int i = 0;i<cardNames.Count;i++)
        {
            tGO = Instantiate(prefabCard) as GameObject;
            tSR = tGO.GetComponent<SpriteRenderer>();
            tGO.transform.localPosition = new Vector3((i % 13) * 3, i / 13 * 4, 0);
            tS = cardSprites[i];
            tSR.sprite = tS;
            Card card = tGO.GetComponent<Card>();

            card.name = cardNames[i];
            card.suit = card.name[0].ToString();
            card.rank = int.Parse(card.name.Substring(1));

            tSR.sortingOrder = 1;

            tGO.name = cardNames[i];

            cards.Add(card);
        }
    }

    public static void Shuffle(ref List<Card> oCards)
    {
        List<Card> tCards = new List<Card>();
        int ndx;
        while (oCards.Count > 0)
        {
            ndx = Random.Range(0, oCards.Count);
            tCards.Add(oCards[ndx]);
            oCards.RemoveAt(ndx);
        }
        oCards = tCards;
    }
}
