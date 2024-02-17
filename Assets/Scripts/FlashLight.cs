using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }
    public void AddLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }
    private void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }
    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }
    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;

    }

}
