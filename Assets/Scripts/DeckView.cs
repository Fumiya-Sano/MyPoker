using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Deck))]
public class DeckView : MonoBehaviour
{
    Deck deck;

    public Vector3 start;
    public float cardOffset;
    public GameObject cardPrefab;

    void Start()
    {
        deck = GetComponent<Deck>();

        ShowCards();
    }

    void ShowCards()
    {
        int cardCount = 0;

        foreach(int i in deck.GetCards())
        {

            float co = cardOffset * cardCount;
            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);

            Vector3 temp = start + new Vector3(co, 0f);
            cardCopy.transform.position = temp;
            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            //コピーしたカードプレファブのCardModelクラスを取得
            cardModel.cardIndex = i;
            //インデックスにiを代入
            cardModel.ToggleFace(true);
            //表面をレンダー（カードゲームを作りたい第2回目で作成したスクリプトを使用）

            cardCount++;
            
            
        }
    }
}

