using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
  public float speed = 100f;
  public Rigidbody rb;
  public float lifeTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      Invoke("DestroyCar", lifeTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void DestroyCar() {
      Destroy(gameObject);
    }


}
