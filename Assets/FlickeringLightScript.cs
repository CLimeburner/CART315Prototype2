using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLightScript : MonoBehaviour
{

    public Light flickerLight;

    // Start is called before the first frame update
    void Start()
    {
      flickerLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      flickerLight.intensity = Random.Range(0.0f, 1.0f);
    }
}
