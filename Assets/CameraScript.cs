using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraScript : MonoBehaviour
{
  public CinemachineVirtualCamera vcam;

  public float speedH = 5.0f;
  public float speedV = 5.0f;

  private float yaw = 0.0f;
  private float pitch = 0.0f;

  private float advanceSpeed = 3;

  private float fadeAmount = 0;

  void Start () {
     Cursor.visible = false;
     Cursor.lockState = CursorLockMode.Locked;
  }

  void FixedUpdate () {

      yaw += speedH * Input.GetAxis("Mouse X");
      pitch -= speedV * Input.GetAxis("Mouse Y");

      if(pitch > 90.0f) {
        pitch = 90.0f;
      }
      if(pitch < -90.0f) {
        pitch = -90.0f;
      }

      transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

      if (Input.GetMouseButton(0)) {
        vcam.m_Lens.FieldOfView = 40;
      } else {
        vcam.m_Lens.FieldOfView = 60;
      }



      //backup code for manual scrolling
      if (Input.GetKey(KeyCode.W) && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 245) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + 0.1f;
      }

      if (Input.GetKey(KeyCode.S) && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition > 0) {
         vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition - 0.1f;
      }


      //Fade to Black code
      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition > 3 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 11) {
        fadeAmount = (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition - 3)/8;
        fadeAmount = 1 - fadeAmount;
        GameObject.Find("Blackout").GetComponent<Renderer>().material.color = new Color(0,0,0,fadeAmount);
      }

      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition >= 11 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition <= 230) {
        GameObject.Find("Blackout").GetComponent<Renderer>().material.color = new Color(0,0,0,0);
      }

      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition > 230 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 245) {
        fadeAmount = (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition - 230)/12;
        if (fadeAmount > 1) {
          fadeAmount = 1;
        }
        GameObject.Find("Blackout").GetComponent<Renderer>().material.color = new Color(0,0,0,fadeAmount);
      }



      //autoscrolling code -- SHORT VERSION --
      /*if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 47) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 60 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 67) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 120 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 125) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 180 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 196) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 240 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 243) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }*/




      //autoscrolling code -- LONG VERSION --
      /*if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 9.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 90 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 23.75) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 180 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 30.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 270 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 38.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 360 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 55) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 450 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 69) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 540 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 78) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 630 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 88) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 720 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 95.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 810 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 104.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 900 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 111) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 990 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 123) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1080 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 131) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1170 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 143) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1260 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 156) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1350 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 170) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1440 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 185) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1530 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 200) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1620 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 215) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1710 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 230) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1800 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 244) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }*/





      //Quit out at end
      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == 243) {
        Application.Quit();
      }



  }
}
