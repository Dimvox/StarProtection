using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWaves : MonoBehaviour
{

    private WaveSpawner _waveSpawner;

    private void Awake()
    {
        _waveSpawner = GameObject.Find("WaveController").GetComponent<WaveSpawner>();
    }

    private void OnDestroy()
    {
        int enemyesLeft = 0;
        enemyesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemyesLeft <= 0)
            _waveSpawner.LaunchWave();
    }
}
