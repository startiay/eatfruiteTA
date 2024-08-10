using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Camera Camera;
    [SerializeField] private GameObject[] fruite;
    private float spawnTimer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnT(spawnTimer, fruite));
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator spawnT(float interval, GameObject[] fruite)
    {

        yield return new WaitForSeconds(interval);
        Instantiate(fruite[Random.Range(0, fruite.Length)],
            new Vector2(Random.Range(Camera.gameObject.transform.position.x - 8,
            Camera.gameObject.transform.position.x + 8), 4),
            Quaternion.identity).transform.SetParent(this.transform); ;
        StartCoroutine(spawnT(spawnTimer, fruite));
    }
}
