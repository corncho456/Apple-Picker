using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> playerHand;
    public List<Card> sortedHand;
    public List<Card> opCard;
    public List<Card> nowOpCard;
    public int money;
    public Transform pPosition;
    public int handRank;
    public enum enSuit { C, D, H, S }


    public enum handRanking
    {
        HighCard, Pair, TwoPair, ThreeOfAKind, BackStraight, Straight, Flush, FullHouse, FourOfAKind, BackStraightFlush, StraightFlush
    }


    void Start()
    {
        

    }

    public class PlayerInformation
    {
        public string playerName;
        public int money;
    }

    public void ShowCard()
    {
        GameObject tGO = null;
        for(int i = 0; i < playerHand.Count; i++)
        {
            tGO = playerHand[i].cObject;
            tGO.transform.localPosition = new Vector3( 3 * i, -4 ,0);
            playerHand[i].faceUp = true;
        }

    }

    public void SortCard(ref List<Card> pHand)
    {
        pHand.Sort(delegate (Card A, Card B)
        {
            if (A.suitNum > B.suitNum) return 1;
            else if (A.suitNum < B.suitNum) return -1;
            return 0;
        });  
        pHand.Sort(delegate (Card A, Card B)
        {
            if (A.rank > B.rank) return 1;
            else if (A.rank < B.rank) return -1;
            return 0;
        });
    }
}
