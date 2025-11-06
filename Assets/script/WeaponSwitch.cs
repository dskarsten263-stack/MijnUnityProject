using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public string currentWeapon = "Sword"; // standaard wapen

    void Update()
    {
        // Wisselen van wapen met toetsen 1-4
        if (Input.GetKeyDown(KeyCode.S))
            currentWeapon = "Sword";
        else if (Input.GetKeyDown(KeyCode.B))
            currentWeapon = "Bow";
        else if (Input.GetKeyDown(KeyCode.))
            currentWeapon = "Staff";
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            currentWeapon = "Dagger";

        ShowWeaponStats();
    }

    void ShowWeaponStats()
    {
        int damage = 0;
        float speed = 0f;

        // Switch-statement voor stats
        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                speed = 1.0f;
                break;
            case "Bow":
                damage = 20;
                speed = 1.5f;
                break;
            case "Staff":
                damage = 35;
                speed = 0.7f;
                break;
            case "Dagger":
                damage = 15;
                speed = 2.0f;
                break;
            default:
                damage = 10;
                speed = 1.0f;
                break;
        }

        // Toon stats in de console
        Debug.Log("Equipped: " + currentWeapon);
        Debug.Log("Damage: " + damage + ", Speed: " + speed);
    }
}
