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
      if (Time.time > 90 && distanceTravelled < 0.43) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 180 && distanceTravelled < 0.631) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 270 && distanceTravelled < 0.885) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 360 && distanceTravelled < 1.409) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 450 && distanceTravelled < 1.853) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 540 && distanceTravelled < 2.139) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 630 && distanceTravelled < 2.456) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 720 && distanceTravelled < 2.694) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 810 && distanceTravelled < 2.98) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 900 && distanceTravelled < 3.186) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 990 && distanceTravelled < 3.567) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1080 && distanceTravelled < 3.821) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1170 && distanceTravelled < 4.202) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1260 && distanceTravelled < 4.615) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1350 && distanceTravelled < 5.059) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1440 && distanceTravelled < 5.536) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1530 && distanceTravelled < 6.012) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1620 && distanceTravelled < 6.488) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1710 && distanceTravelled < 6.964) {
        distanceTravelled += speed * Time.deltaTime;
      }

      if (Time.time > 1800 && distanceTravelled < 7.408) {
        distanceTravelled += speed * Time.deltaTime;
      }



      transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled + startPos);
      transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled + startPos);
    }
}
