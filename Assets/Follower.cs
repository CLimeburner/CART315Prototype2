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

    }

    // Update is called once per frame
    void FixedUpdate()
    {

      if(Time.time > 60 && distanceTravelled < 0.645) {
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


      transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled + startPos);
      transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled + startPos);
    }
}
