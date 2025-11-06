using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    private Rigidbody rb;
    public float springKracht = 500.0f;

    void Start()
    {
    
    }

    void Update()
    {
        // Spring omhoog als je Space indrukt
     if (Input.GetKeyDown(KeyCode.Space));
        {
            Debug.Log("Spring!");
            rb.AddForce(Vector3.up * springKracht);
            // Duw het object geleidelijk
            rb.AddForce(Vector3.right * 10.0f);
            // Verschillende manieren van kracht toepassen
            rb.AddForce(Vector3.up * 500, ForceMode.Force);        // Geleidelijk
            rb.AddForce(Vector3.up * 500, ForceMode.Impulse);      // Directe klap
            rb.AddForce(Vector3.up * 10, ForceMode.VelocityChange); // Directe snelheidsverandering
            // Zet directe snelheid
            rb.linearVelocity = new Vector3(5, 0, 0); // Beweeg 5 units/sec naar rechts
        }
        
    }
}