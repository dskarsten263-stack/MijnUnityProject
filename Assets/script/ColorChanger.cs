using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private bool playerOnPlatform = false;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend == null)
            Debug.LogWarning("No Renderer found on " + gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnPlatform = true;
            Debug.Log("Player on platform - Press R/G/B to change color");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnPlatform = false;
        }
    }

    void Update()
    {
        if (!playerOnPlatform || rend == null) return;

        if (Input.GetKeyDown(KeyCode.R))
        {
            rend.material.color = Color.red;
            Debug.Log("Changed to Red!");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            rend.material.color = Color.green;
            Debug.Log("Changed to Green!");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            rend.material.color = Color.blue;
            Debug.Log("Changed to Blue!");
        }
    }
}
