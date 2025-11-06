using UnityEngine;

public class Door : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject doorObject;

    void Update()
    {
        if (hasKey && Input.GetKeyDown(KeyCode.E))
        {
            doorObject.SetActive(false); // deur verdwijnt
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(other.gameObject);
        }
    }
}
