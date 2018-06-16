using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {
    private GameObject[] columns;
    public GameObject ColumnPrefab;
    public int poolSize=5;
    private float timePassed;
    public float spawnRate = 4;
    public float columnMax = 1f; 
    public float columnMin = -1f;
    private float spawnX = 10f;
    private int currentCol = 0;
    private Vector2 position = new Vector2(-5f, -5f);

	// Use this for initialization
	void Start () {
        columns = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++){
            columns[i] = (GameObject)Instantiate(ColumnPrefab, position, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        timePassed += Time.deltaTime;
        if(timePassed > 4){
            timePassed = 0;
            float Ypos = Random.Range(columnMin, columnMax);
            columns[currentCol].transform.position = new Vector2(spawnX, Ypos);
            currentCol++;
            if(currentCol>poolSize){
                currentCol = 0;
            }
        }
	}
}
