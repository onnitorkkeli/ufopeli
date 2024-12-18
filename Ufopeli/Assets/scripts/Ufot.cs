using System.Collections;
using UnityEngine;

public class Ufot : MonoBehaviour
{
    [SerializeField] GameObject[] ufoPrefab;

    [SerializeField] float secondSpawn = 0.5f;

    [SerializeField] float min;

    [SerializeField] float max;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(UfoSpawn());
    }

    // Update is called once per frame
    IEnumerator UfoSpawn()
    {
        while (true) 
        {
            var wanted = Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ufoPrefab[Random.Range(0, ufoPrefab.Length)],position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 15f);
        }
    }
}
