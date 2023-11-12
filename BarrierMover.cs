using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMover : MonoBehaviour
{
    public GameObject barrierPrefab;
    public Transform leftBarrierTransform;
    public float barrierSpeed = 10f;
    public float startPoint = 3.5f;
    public float endPoint = -3.5f;
    private GameObject lb;

    // Start is called before the first frame update
    void Start()
    {
        lb = Instantiate(barrierPrefab, leftBarrierTransform.position, leftBarrierTransform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
      lb.transform.position += Vector3.back * barrierSpeed * Time.deltaTime;
      if (lb.transform.position.z <= endPoint) {
        lb.transform.position = new Vector3(lb.transform.position.x, lb.transform.position.y, startPoint);
      }
    }
}
