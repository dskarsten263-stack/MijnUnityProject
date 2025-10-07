using UnityEngine;

public class Spellbook : MonoBehaviour
{

    void Start()
    {
        int currentMana = 25;
        string spellToCast = "Fireball";

        if (CanCast(spellToCast, currentMana))
        {
            Debug.Log("You cast " + spellToCast + "!");
            currentMana -= GetManaCost(spellToCast);
            Debug.Log("Remaining mana: " + currentMana);
            string GetSpellEffect(string spellName)
            {
                if (spellName == "Fireball")
                {
                    return "Deals fire damage to an enemy.";
                }
                else if (spellName == "Heal")
                {
                    return "Restores health to yourself or an ally.";
                }
                else if (spellName == "Teleport")
                {
                    return "Instantly moves you to a chosen location.";
                }
                else
                {
                    return "Unknown spell effect.";
                }
            }
            
        }
        else
        {
            Debug.Log("Not enough mana to cast " + spellToCast + ".");
        }

        Debug.Log("Spell Effect: " + GetSpellEffect("Fireball"));
        Debug.Log("Spell Effect: " + GetSpellEffect("Heal"));
        Debug.Log("Spell Effect: " + GetSpellEffect("Teleport"));
    }

    void Update()
    {
        

    }

     public void CastSpell(string spellName)
    {
        Debug.Log("Casting spell: " + spellName);
        if (Input.GetKeyDown(KeyCode.F) && (spellName == "Fireball"))
        {
            Debug.Log("A fiery projectile shoots forward!");
        }
        if (Input.GetKeyDown(KeyCode.H) && (spellName == "Heal"))
        {
            Debug.Log("You feel rejuvenated!");
        }
        if (Input.GetKeyDown(KeyCode.I) && (spellName == "Info"))
        {
            Debug.Log("currentMana");
        }
    }
    int GetManaCost(string spellName)
    {
        if (spellName == "Fireball")
        {
            return 10;
        }
        else if (spellName == "Heal")
        {
            return 8;
        }
        else if (spellName == "info")
        {
            return 15;
        }
        else
        {
            Debug.Log("Unknown spell: " + spellName);
            return 0;
        }
    }
    bool CanCast(string spellName, int currentMana)
    {
        int manaCost = GetManaCost(spellName);
        return currentMana >= manaCost;
    }

    string GetSpellEffect(string spellName)
    {
        if (spellName == "Fireball")
        {
            return "A fiery explosion engulfs your target.";
        }
        else if (spellName == "Heal")
        {
            return "You are bathed in a warm, healing light.";
        }
        else if (spellName == "Teleport")
        {
            return "You vanish and reappear elsewhere.";
        }
        else
        {
            return "Unknown spell effect.";
        }
    }
    
}