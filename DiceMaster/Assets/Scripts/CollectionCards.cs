using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionCards : MonoBehaviour
{
    [Header("Characters")]
    public List<Card> m_CardsCharacters;

    public GameObject[] m_SlotsCardsCharacters;
    
    [Header("Actions")]
    public List<Card> m_CardsActions;

    public GameObject[] m_SlotsCardsActions;


    void Start()
    {
        for (int i = 0; i < m_CardsCharacters.Count; i++)
        {
            m_SlotsCardsCharacters[i].GetComponent<Image>().sprite = m_CardsCharacters[i].m_Image;
            m_SlotsCardsCharacters[i].GetComponent<SlotCharacters>().m_CardCharacter = m_CardsCharacters[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
