using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] imageObjs;

    [SerializeField]
    private float delayTillSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnImages());
    }

    IEnumerator SpawnImages()
    {
        yield return new WaitForSeconds(delayTillSpawn);
        _SpawnImages();
    }

    private void _SpawnImages()
    {
        int rot = 0;
        foreach (GameObject image in imageObjs)
        {
            GameObject curImage = Instantiate(image, transform.position, Quaternion.Euler(Vector3.zero + Vector3.up * rot), transform);
            rot += (365 - 365 / imageObjs.Length) / imageObjs.Length;

        }
    }

}
