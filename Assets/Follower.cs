using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    float speed = 0.05f;
    public float startPos = 0;
    float distanceTravelled;

    // Start is called before the first frame update
    void Start()
    {
      startPos = startPos - 0.975f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //advances people -- SHORT VERSION --
      /*if(Time.time > 60 && distanceTravelled < 0.645) {
        distanceTravelled += speed * Time.deltaTime;
      }
      if(Time.time > 120 && distanceTravelled < 2.47) {
        distanceTravelled += speed * Time.deltaTime;
      }
      if(Time.time > 180 && distanceTravelled < 4.725) {
        distanceTravelled += speed * Time.deltaTime;
      }
      if(Time.time > 240 && distanceTravelled < 6.2) {
        distanceTravelled += speed * Time.deltaTime;
      }
      */

      //advances people -- LONG VERSION --
      if (Time.time > 120 && distanceTravelled < 0.615) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 240 && distanceTravelled < 1.38) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 360 && distanceTravelled < 1.85) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 480 && distanceTravelled < 2.675) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 600 && distanceTravelled < 3.575) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 720 && distanceTravelled < 4.2) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 840 && distanceTravelled < 4.9) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 960 && distanceTravelled < 5.6) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1080 && distanceTravelled < 6.275) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1200 && distanceTravelled < 6.975) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1320 && distanceTravelled < 7.5) {
        distanceTravelled += speed * Time.deltaTime;
      }


      transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled + startPos);
      transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled + startPos);
    }
}
