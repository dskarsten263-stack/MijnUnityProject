using UnityEngine;

public class Spellbook : MonoBehaviour
{
   
    private int currentMana = 125;

    void Start()
    {
        
        CastSpell("Fireball");
        CastSpell("Heal");
        CastSpell("Teleport");
        CastSpell("UnknownSpell"); 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F)) CastSpell("Fireball");
        if (Input.GetKeyDown(KeyCode.H)) CastSpell("Heal");
        if (Input.GetKeyDown(KeyCode.T)) CastSpell("Teleport");
    }

       void CastSpell(string spellName)
    {
        Debug.Log("Trying to cast: " + spellName);

        if (!CanCastSpell(spellName))
        {
            Debug.Log("Not enough mana to cast " + spellName);
            return; 
        }

        
        int manaCost = GetManaCost(spellName);
        currentMana -= manaCost;
        Debug.Log("Mana cost: " + manaCost + ". Remaining mana: " + currentMana);

        
        string effect = GetSpellEffect(spellName);
        Debug.Log("Spell Effect: " + effect);
    }

    
    bool CanCastSpell(string spellName)
    {
        int manaCost = GetManaCost(spellName);
        return currentMana >= manaCost;
    }

    
    int GetManaCost(string spellName)
    {
        switch (spellName)
        {
            case "Fireball":
                return 10;
            case "Heal":
                return 8;
            case "Teleport":
                return 15;
            default:
                return 0; 
        }
    }

    
    string GetSpellEffect(string spellName)
    {
        switch (spellName)
        {
            case "Fireball":
                return "A fiery explosion engulfs your target.";
            case "Heal":
                return "You are bathed in a warm, healing light.";
            case "Teleport":
                return "You vanish and reappear elsewhere.";
            default:
                return "Unknown spell effect.";
        }
    }
}
