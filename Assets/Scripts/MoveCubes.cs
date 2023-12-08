using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{
   public bool isWASD = false;
   public bool isArrow = false;
   public float speed = 5f; // скорость движения куба

   private void OnValidate()
   {
      if (isWASD == true)
      {
         isArrow = false;
      }

      if (isArrow == true)
      {
         isWASD = false;
      }
   }

   private void Update()
   {
      if (isWASD == true)
      {
         WASDMovement();
      }

      if (isArrow == true)
      {
         ArrowMovement();
      }
   }

   public void WASDMovement()
   {
      // движение куба при нажатии клавиш WASD
      if (Input.GetKey(KeyCode.W))
      {
         transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.A))
      {
         transform.Translate(Vector3.left * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.S))
      {
         transform.Translate(Vector3.back * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.D))
      {
         transform.Translate(Vector3.right * speed * Time.deltaTime);
      }
   }

   public void ArrowMovement()
   {
      // движение куба при нажатии стрелок
      if (Input.GetKey(KeyCode.UpArrow))
      {
         transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.LeftArrow))
      {
         transform.Translate(Vector3.left * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.DownArrow))
      {
         transform.Translate(Vector3.back * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.RightArrow))
      {
         transform.Translate(Vector3.right * speed * Time.deltaTime);
      }
   }
}
