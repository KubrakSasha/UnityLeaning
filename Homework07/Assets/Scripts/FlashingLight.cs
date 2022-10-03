using UnityEngine;

public class FlashingLight : MonoBehaviour
{
    Light flashLight;
    public Light FlashLight { get { return flashLight = flashLight ?? GetComponent<Light>(); } }
  
    void Start()
    {
        FlashLight.enabled = false;
    }    
    void Update()
    {
        if (Random.value <= 0.2f)
        {
            FlashLight.enabled = true;
        }
        else
        {
            FlashLight.enabled = false;
        }
    }
}