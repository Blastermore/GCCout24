using UnityEngine;

public class SpinEffect : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {

        
        // Rotate the quad around its z-axis to create the spin effect
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}