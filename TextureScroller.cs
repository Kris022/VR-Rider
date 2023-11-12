using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float scrollX = 0f;
    public float scrollY = 0.5f;
    void Update()
    {
      float offsetX = scrollX * Time.time;
      float offsetY = scrollY * Time.time; 
      GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
