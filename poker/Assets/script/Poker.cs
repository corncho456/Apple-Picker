using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poker : MonoBehaviour
{
    public Deck deck;
    public GameObject P1;
    public GameObject P2;
    public float allBetting;

    public Player player1;
    public Player player2;

    public enum handRanking
    {
        HighCard, Pair, TwoPair, ThreeOfAKind, BackStraight, Straight, RoyalStraight, Flush, FullHouse, FourOfAKind, BackStraightFlush, StraightFlush, RoyalFlush
    }

    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        player1 = P1.GetComponent<Player>();
        player2 = P2.GetComponent<Player>();
        deck = GetComponent<Deck>(); //덱을 얻음
        Deck.Shuffle(ref deck.cards); //shuffle 테스트
                                      //ref 키워드는 메서드로 deck.cards의 참조를 전달해 메서드에 직접deck.cards를 수정하도록 지정함

        Deck.getHand(ref deck.cards, ref player1.playerHand, 7);
        player1.ShowCard(1);
        player1.SortCard(ref player1.playerHand);

        player1.handRank = HandEvaluator(player1);


        Deck.getHand(ref deck.cards, ref player2.playerHand, 7);
        player2.ShowCard(2);
        player2.SortCard(ref player2.playerHand);

        player2.handRank = HandEvaluator(player2);
  

    }

    //플레이어 개개의 핸드패를 검사해야한다.
    public int HandEvaluator(Player player)
    {
        bool straight = false, royal = false, flush = false;
        bool FoK = false, ToK = false;
        int numPair = 0;
        int i;
        int straightCounter = 0;
        for (i = 1; i < player.playerHand.Count; ++i)
        {
            if (player.playerHand[i - 1].rank == player.playerHand[i].rank - 1)
            {
                ++straightCounter;
                Debug.Log("straightCounter =" + straightCounter);

            }
        }
        if(straightCounter==4)
        {
            straight = true;
            if (player.playerHand[0].rank==13) royal = true;
        }
        else if (straightCounter==4 && player.playerHand[0].rank == 13 && player.playerHand[1].rank == 4)
        {
            straight = true; //A,2,3,4,5 백 스트레이트
        }

        for (i=1;i<player.playerHand.Count; i++)
        {
            if (player.playerHand[i].suit != player.playerHand[i - 1].suit) break;
            if (i == 5) flush = true; //flush
        }

        int[] numRanks = new int[14] ;
        for (i = 0; i < player.playerHand.Count - 1; i++) ++numRanks[player.playerHand[i].rank];
        {
            numRanks[i] = player.playerHand[i].rank;
            Debug.Log(player.playerHand[i].rank);
        }
        for (i = 0; i < 14; i++)
            switch (numRanks[i])
            {
                case 2: ++numPair;break;
                case 3: ToK = true;break;
                case 4: FoK = true;break;
            }

        int handType = (int)handRanking.HighCard;

        if (royal && flush) handType = (int)handRanking.RoyalFlush;
        else if (straight && flush) handType = (int)handRanking.StraightFlush;
        else if (FoK) handType = (int)handRanking.FourOfAKind;
        else if (ToK && numPair == 1) handType = (int)handRanking.FullHouse;
        else if (flush) handType = (int)handRanking.Flush;
        else if (straight) handType = (int)handRanking.Straight;
        else if (ToK) handType = (int)handRanking.ThreeOfAKind;
        else if (numPair==2) handType = (int)handRanking.TwoPair;
        else if (numPair==1) handType = (int)handRanking.Pair;
        Debug.Log("straightCounter =" + straightCounter);
        Debug.Log("straightCounter =" + numPair);

        return handType;
    }
}