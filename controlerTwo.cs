using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerTwo : MonoBehaviour
{
  public float maxTurnAngle = 30f;
  public float turnSpeed = 5f;

  private float horizontalInput;
  private float leanAngle;

  private void Update()
  {
      horizontalInput = Input.GetAxis("Mouse X"); // switch to camera rotation
      float turnAmount = horizontalInput * turnSpeed * Time.deltaTime;
      transform.Rotate(0, turnAmount, 0);

      float targetLeanAngle = horizontalInput * maxTurnAngle;
      leanAngle = Mathf.Lerp(leanAngle, targetLeanAngle, turnSpeed * Time.deltaTime);
      transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, -leanAngle);
  }
}
