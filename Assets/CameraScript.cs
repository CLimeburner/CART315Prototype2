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

  private float advanceSpeed = 5;

  private float fadeAmount = 0;

  void FixedUpdate () {

      yaw += speedH * Input.GetAxis("Mouse X");
      pitch -= speedV * Input.GetAxis("Mouse Y");

      transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

      if (Input.GetKey(KeyCode.Space)) {
        vcam.m_Lens.FieldOfView = 40;
      } else {
        vcam.m_Lens.FieldOfView = 60;
      }



      //backup code for manual scrolling
      /*if (Input.GetKey(KeyCode.W) && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 245) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + 1;
      }

      if (Input.GetKey(KeyCode.S) && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition > 0) {
         vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition - 1;
      }*/


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

      //autoscrolling code
      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 11) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 120 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 30) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 240 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 54.5) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 360 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 69) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 480 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 95) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 600 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 123) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 720 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 142) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 840 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 164) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 960 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 186) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1080 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 208) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1200 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 230) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }

      if (Time.time > 1320 && vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition < 244) {
        vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition + (advanceSpeed/100);
      }


      //Reset to beginning
      if (vcam.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition == 243) {
        Application.Quit();
      }



  }
}
