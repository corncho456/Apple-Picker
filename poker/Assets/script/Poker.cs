using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poker : MonoBehaviour
{

    public Deck deck;
    public List<Card> pHand;
    public List<Card> chand1;
    public List<Card> chand2;

    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        deck = GetComponent<Deck>(); //덱을 얻음
        deck.MakeCard();
        Deck.Shuffle(ref deck.cards); //shuffle 테스트
                                      //ref 키워드는 메서드로 deck.cards의 참조를 전달해 메서드에 직접deck.cards를 수정하도록 지정함
        Deck.getHand(ref deck.cards, ref pHand, 3);//getHand 테스트
    }

    //플레이어 개개의 핸드패를 검사해야한다.
    public void HandEvaluator()
    {

    }
}


