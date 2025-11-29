using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] animalPrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
            animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
