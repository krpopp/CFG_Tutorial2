using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExamples : MonoBehaviour
{

    GameObject[] enemyObjs;

    int[] studentAges;
    string[] studentNames;
    bool[] studentPass;
    float[] studentTime;

    public GameObject enemyPrefab;

    public List<GameObject> enemyList = new List<GameObject>();
    List<float> enemyHealth = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        enemyObjs = new GameObject[5];
        for (int i = 0; i < enemyObjs.Length; i++) {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemyObjs[i] = newEnemy;
        }

        Debug.Log(enemyObjs[2]);

        studentAges = new int[17];
        studentAges[0] = 20;
        studentAges[1] = 18;
        studentAges[2] = 22;
        studentAges[3] = 19;

        for (int i = 0; i < 7; i++) {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            newEnemy.transform.name = "Enemy " + i;
            enemyList.Add(newEnemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            newEnemy.transform.name = "Enemy " + enemyList.Count;
            enemyList.Add(newEnemy);
        }
        if (Input.GetMouseButtonDown(1)) {
            enemyList.RemoveAt(enemyList.Count - 1);
        }
    }
}
