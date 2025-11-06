using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float rotateSpeed = 30.0f; // graden per seconde

    void Update()
    {
        // Draai rond de Y-as
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
