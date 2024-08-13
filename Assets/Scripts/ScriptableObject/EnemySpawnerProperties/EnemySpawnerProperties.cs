using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnerProperties", menuName = "EnemySpawnerProperties", order = 51)]
public class EnemySpawnerProperties : ScriptableObject
{
    [SerializeField] private Enemy[] _enemiesPrefabs;
    [SerializeField] private float _distanceToPlayer;
    [Range(0, 1)]
    [SerializeField] private float[] _spawnChance;

    public Enemy[] Enemies() => _enemiesPrefabs;

    public float[] SpawnChance() => _spawnChance;

    public float DistanceToPlayer() => _distanceToPlayer;

    private void OnValidate()
    {
        if(_enemiesPrefabs.Length != _spawnChance.Length)
            _spawnChance = new float[_enemiesPrefabs.Length];

        float chanceSum = 0;
        foreach (var chance in _spawnChance)
            chanceSum += chance;
        
        if(chanceSum > 1)
            throw new ArgumentOutOfRangeException(nameof(chanceSum));
    }
}
