using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";
    public string charactergender= "Man";
    public string height= "190cm";
    //add your own stats here

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 25;
    public int defense = 15;
    public int shield = 75;
    public int speed = 64;
    //add your own stats here

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    public float missioncomplete = 60.2f;
    public float tasktodo = 25.4f;
    //add your own stats here

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";
    public bool Gold = true;
    public bool Mana = true;
    //add your own stats here

    void Start()
    {
        
    }

    void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            //Display Character Sheet
            Debug.Log("=== CHARACTER SHEET ===");
            Debug.Log("Name: " + playerName + " the " + characterClass);
            Debug.Log("Level: " + level);
            Debug.Log("Charactergender" + charactergender);
            Debug.Log("Height" + height);
            Debug.Log("Health: " + health + "/" + maxHealth);
            Debug.Log("Mana: " + mana);
            Debug.Log("Attack: " + attack + " | Defense: " + defense);
            Debug.Log("Shield: " + shield + " | Speed: " + speed);
            Debug.Log("Experience: " + experience + " XP");
            Debug.Log("Gold: " + gold + " coins");
            Debug.Log("Playtime: " + playtimeHours + " hours");
            Debug.Log("Missioncomplete" + missioncomplete);
            Debug.Log("Tasktodo" + tasktodo);
            Debug.Log("Current Weapon: " + currentWeapon);
            Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
            Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
            Debug.Log("How many Gold:" + Gold);
            Debug.Log("How many Mana:" + Mana);
            Debug.Log("========================");
        }
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            level--;
            maxHealth -= 0;
            health = maxHealth; 
            attack -= 0;
            defense -= 0;
            mana -= 0;

            Debug.Log("");
            Debug.Log("Noob");
        }
        //Reset Stats here when R is pressed!
    }
}