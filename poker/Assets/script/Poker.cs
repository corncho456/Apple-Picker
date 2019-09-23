using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poker : MonoBehaviour
{

    public Deck deck;
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        deck = GetComponent<Deck>(); //덱을 얻음
        deck.MakeCard();
        Deck.Shuffle(ref deck.cards); //덱을 섞음
                                      //ref 키워드는 메서드로 deck.cards의 참조를 전달해 메서드에 직접deck.cards를 수정하도록 지정함
    }
}
