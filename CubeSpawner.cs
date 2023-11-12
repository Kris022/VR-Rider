using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
  public GameObject[] carPrefabs;
  public float spawnInterval = 2f;

  private GameObject chosenCar;
  private float[] spawnPositions = new float[] {-2.5f, 0f, 3f};

  private void Start() {
    InvokeRepeating("SpawnCar", 0, spawnInterval);
  }

  private void SpawnCar() {
    int randomIndex = Random.Range(0, spawnPositions.Length);
    int carPrefabIndex = Random.Range(0, carPrefabs.Length);
    chosenCar = carPrefabs[carPrefabIndex];

    GameObject carInstance = Instantiate(chosenCar, new Vector3(spawnPositions[randomIndex], transform.position.y, transform.position.z), Quaternion.identity);

  }

}
