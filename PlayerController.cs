using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Rigidbody rb;
  public float turnSpeed = 10f;
  public float movementSpeed = 10f;

  public Transform cameraHolder;

  // limit top turn speed
  private float sidewaysForce;

  private float rotationAmount = 0f;

// get rotation from the cameraOffset
//aply it ot the camholder transform

    // Update is called once per frame
    void Update()
    {
      // change to camholder transform
      sidewaysForce = Camera.main.transform.rotation.z * turnSpeed;
      rotationAmount = Mathf.Lerp(0f, sidewaysForce, 0.25f);
  //    Debug.Log(rotationAmount);
      transform.Rotate(rotationAmount, 0, 0);

    }
// Clamp the rotation value
// Allow the bike to fall over when too much leaning?
// prevent the bike from flying!!!

    void FixedUpdate()
    {
      rb.AddForce(-sidewaysForce * movementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
