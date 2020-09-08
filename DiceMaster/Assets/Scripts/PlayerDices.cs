using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDices : MonoBehaviour
{
    [Header("Bag")]
    public List<Dice> m_BagDices;

    [Header("Hand")]
    public List<Dice> m_handDices;

    [Header("Field")]
    public List<Dice> m_FieldDices;
    public List<Dice> m_AttackDices;

    public List<Dice> m_KODices;
    public List<Dice> m_PrepDices;
    
    public List<Dice> m_UsedDices;

    public List<Dice> m_ReserveDices;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
