using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoasterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if((Time.time%90) == 60) {
        this.GetComponent<Transform>().position = new Vector3(60.0f, 3.18f, 28.41f);
      }
      if((Time.time%90) > 30 && (Time.time%120) < 90) {
        this.GetComponent<Transform>().Translate(-0.1f, 0, 0);
      }
      if((Time.time%90) > 60 && transform.position.x > 25.51) {
        this.GetComponent<Transform>().Translate(-0.1f, 0, 0);
      }
    }
}
