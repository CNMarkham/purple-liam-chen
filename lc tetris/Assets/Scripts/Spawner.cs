using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tetrominoes;
    void Start()
    {
        SpawnTertomino();
    }

    public void SpawnTertomino()
    {
        int randNum = Random.Range(0, tetrominoes.Length);
        GameObject randomTetromino = tetrominoes[randNum];
        Instantiate(randomTetromino, transform.position, Quaternion.identity);
    }
}
