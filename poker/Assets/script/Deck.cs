using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Deck : MonoBehaviour
{
    public Sprite C1;
    public Sprite C2;
    public Sprite C3;
    public Sprite C4;
    public Sprite C5;
    public Sprite C6;
    public Sprite C7;
    public Sprite C8;
    public Sprite C9;
    public Sprite C10;
    public Sprite C11;
    public Sprite C12;
    public Sprite C13;
    public Sprite D1;
    public Sprite D2;
    public Sprite D3;
    public Sprite D4;
    public Sprite D5;
    public Sprite D6;
    public Sprite D7;
    public Sprite D8;
    public Sprite D9;
    public Sprite D10;
    public Sprite D11;
    public Sprite D12;
    public Sprite D13;
    public Sprite H1;
    public Sprite H2;
    public Sprite H3;
    public Sprite H4;
    public Sprite H5;
    public Sprite H6;
    public Sprite H7;
    public Sprite H8;
    public Sprite H9;
    public Sprite H10;
    public Sprite H11;
    public Sprite H12;
    public Sprite H13;
    public Sprite S1;
    public Sprite S2;
    public Sprite S3;
    public Sprite S4;
    public Sprite S5;
    public Sprite S6;
    public Sprite S7;
    public Sprite S8;
    public Sprite S9;
    public Sprite S10;
    public Sprite S11;
    public Sprite S12;
    public Sprite S13;

    public List<string> cardNames;
    public List<Card> cards;
    public List<Sprite> cardSprites;

    public GameObject prefabCard;
    public Sprite prefabSprite;

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
        string[] letters = new string[] { "C", "D", "H", "S" };
        Sprite TempSprite;
        foreach(string s in letters)
        {
            for(int i = 0; i < 13; i++)
            {
                cardNames.Add(s + (i + 1));
                TempSprite = new Sprite();
                TempSprite = Sprite C1;
                cardSprites.Add(TempSprite);

            }

        }

        
        cards = new List<Card>();
        Sprite tS = null;
        GameObject tGO = null;
        SpriteRenderer tSR = null;
        print(cardNames.Count);

        for (int i = 0;i<cardNames.Count;i++)
        {
            GameObject cgo = Instantiate(prefabCard) as GameObject;
            //cgo.transform.parent = deckanchor; 이부분은 없으면 어케되지?
            Card card = cgo.GetComponent<Card>();
            cgo.transform.localPosition = new Vector3((i % 13) * 3, i / 13 * 4, 0);
            card.name = cardNames[i];
            card.suit = card.name[0].ToString();
            card.rank = int.Parse(card.name.Substring(1));

            tGO = Instantiate(prefabCard) as GameObject;
            tSR = tGO.GetComponent<SpriteRenderer>();
            tS = 

            //tSR.sortingOrder = 1;
            tGO.transform.parent = cgo.transform;
            tGO.name = cardNames[i];



            cards.Add(card);
        }
    }

}
