using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private Waves[] _waves;
    private int _currentEnemyIndex;
    private int _currentWaveIndex;
    private int _quantityEnemiesLeftToSpawn;

    private void Start()
    {
        _quantityEnemiesLeftToSpawn = _waves[0].WaveSettings.Length;
        LaunchWave();
    }

    private IEnumerator SpawnEnemyInWave()
    {
        if (_quantityEnemiesLeftToSpawn > 0)
        {
            yield return new WaitForSeconds(_waves[_currentWaveIndex]
               .WaveSettings[_currentEnemyIndex]
               .SpawnDelay);
            Instantiate(_waves[_currentWaveIndex].WaveSettings[_currentEnemyIndex].Enemy,
                _waves[_currentWaveIndex].WaveSettings[_currentEnemyIndex]
                .Spawner.transform.position, Quaternion.identity);
            _quantityEnemiesLeftToSpawn--;
            _currentEnemyIndex++;
            StartCoroutine(SpawnEnemyInWave());
        }
        else
        {
            if (_currentWaveIndex < _waves.Length - 1)
            {
                _currentWaveIndex++;
                _quantityEnemiesLeftToSpawn = _waves[_currentWaveIndex].WaveSettings.Length;
                _currentEnemyIndex = 0;
                
            }
        }
    }

    public void LaunchWave()
    {
        StartCoroutine(SpawnEnemyInWave());
    }
}



[System.Serializable]

public class Waves 
{
    [SerializeField] private WaveSettings[] _waveSettings;
    public WaveSettings[] WaveSettings { get => _waveSettings; }
}

[System.Serializable]
public class WaveSettings
{
    [SerializeField] private GameObject _enemy;
    public GameObject Enemy { get => _enemy; }
    [SerializeField] private GameObject _spawner;
    public GameObject Spawner { get => _spawner; }
    [SerializeField] private float _spawnDelay;
    public float SpawnDelay { get => _spawnDelay; }
}
