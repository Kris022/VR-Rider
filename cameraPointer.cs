using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameraPointer : MonoBehaviour
{

  private const float maxDistance = 20;

    // Update is called once per frame
    void Update()
    {
      RaycastHit hit;

      // Cast a ray from the center of camera view
      if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance)) {

        // Check if ray collided with a button
        Button button = hit.collider.gameObject.GetComponent<Button>();

        // if it did check the tag of the button
        if (button != null) {
          if (button.tag == "startButton") {
            goToGameScene();
          }
        }
      }
    } // end of update

    void goToGameScene() {
      SceneManager.LoadScene("Main");
    }

}
