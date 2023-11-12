using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
  public TextMeshProUGUI timerText;
  public Rigidbody rb;
//  public Script playerControlerScript;
  private float secondsUntilRestart = 4f; // seconds until level reload

  public AudioSource engineSound;

  void Start() {
      rb = GetComponent<Rigidbody>();
  }

  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("passBy")) // Replace "SoundTrigger" with the tag of the game object with the trigger collider
        {
          FindObjectOfType<AudioManager>().Play("PlayerPassBy");
      }
    }

  private void OnCollisionEnter(Collision collisionInfo)
  {
      if (collisionInfo.gameObject.tag == "Obstacle")
      {
        rb.useGravity = true;

        engineSound.enabled = false;
        // Play crash sound
        FindObjectOfType<AudioManager>().Play("PlayerCrash");

        InvokeRepeating("restartCountdown", 0f, 1f); // function, call start, call interval
      }
  }

  void restartCountdown() {
    secondsUntilRestart -= 1f;
    timerText.text = "Restart in... " + secondsUntilRestart.ToString();
    if (secondsUntilRestart <= 0) {
      CancelInvoke(); // stop the countdown
      // reload the level
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  }



}
