using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotCharacters : MonoBehaviour
{
    [Header("Card")]
    public Card m_CardCharacter;
    public int m_Quantity = 0;

    [Header("Detail Window")]
    public GameObject m_WindowDetail;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && m_CardCharacter != null)
        {
            CreateContextWindow(m_CardCharacter);
        }
    }

    public void CreateContextWindow(Card card)
    {
        m_WindowDetail.GetComponent<DetailCard>().ApplyCard(card);
        m_WindowDetail.SetActive(true);
    }
}
