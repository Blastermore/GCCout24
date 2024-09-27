using UnityEngine;

public class ParticleEmitter : MonoBehaviour
{
    public ParticleSystem particleSystem; // Assign your particle system here
    public GameObject magicCircle1;
    public GameObject magicCircle2;
    public GameObject magicCircle3;

    private Renderer magicCircleRenderer1;
    private Renderer magicCircleRenderer2;
    private Renderer magicCircleRenderer3;

    void Start()
    {
        magicCircleRenderer1.enabled = false;
        magicCircleRenderer2.enabled = false;
        magicCircleRenderer3.enabled = false;

    }
    void Update()
    {
        magicCircleRenderer1 = magicCircle1.GetComponent<Renderer>();
        magicCircleRenderer2 = magicCircle2.GetComponent<Renderer>();
        magicCircleRenderer3 = magicCircle3.GetComponent<Renderer>();


        // Check if the right mouse button is pressed
        if (Input.GetMouseButtonDown(1)) // 1 is for right-click, 0 is for left-click
        {
            // Emit the particles
            particleSystem.Play();
            magicCircleRenderer1.enabled = true;
            magicCircleRenderer2.enabled = true;
            magicCircleRenderer3.enabled = true;

        }
    }
}