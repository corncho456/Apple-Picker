using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> playerHand;
    public List<Card> opCard;
    public List<Card> nowOpCard;
    public int money;
    public Transform pPosition;
    public int handRank;


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
}
