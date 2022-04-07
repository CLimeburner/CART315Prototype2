using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{

  public Light glower;


    // Start is called before the first frame update
    void Start()
    {
      glower = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
      glower.intensity = 2.5f*(Mathf.Sin(Mathf.PI*(Time.time%4)/2)+1);
    }
}
