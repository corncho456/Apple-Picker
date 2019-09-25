using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poker : MonoBehaviour
{

    public Deck deck;
    public GameObject P1;

    public Player player1;

    public enum handRanking
    {
        HighCard, Pair, TwoPair, ThreeOfAKind, BackStraight, Straight, Flush, FullHouse, FourOfAKind, BackStraightFlush, StraightFlush
    }


    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        player1 = P1.GetComponent<Player>();
        deck = GetComponent<Deck>(); //덱을 얻음
        deck.MakeCard();
        Deck.Shuffle(ref deck.cards); //shuffle 테스트
                                      //ref 키워드는 메서드로 deck.cards의 참조를 전달해 메서드에 직접deck.cards를 수정하도록 지정함
        Deck.getHand(ref deck.cards, ref player1.playerHand, 3);
        player1.ShowCard();

    }


    //플레이어 개개의 핸드패를 검사해야한다.
    public int HandEvaluator(Player player)
    {
        bool straight = false, royal = false, flush = false;
        bool FoK = false, ToK = false;
        int numPair = 0;
        int i;
        int straightCounter = 0;
        for (i = 1; i < player1.playerHand.Count; ++i)
        {
            if (player.playerHand[i].rank == player.playerHand[i - 1].rank - 1)
            {
                ++straightCounter;
            }
        }
        if(straightCounter==5)
        {
            straight = true;
            if (player.playerHand[0].rank==13) royal = true;
        }
        else if (straightCounter==4 && player.playerHand[0].rank == 13 && player.playerHand[1].rank == 4)
        {

        }


        int R = (int)handRanking.HighCard;

        

        return R;
    }
}




