using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _enemiesPrefabs;
    [SerializeField] private Transform _spawnpoint;
    [SerializeField] private Player _player;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemiesPrefabs[0], _spawnpoint.position, Quaternion.identity);
        enemy.Initialize(_player);
        _player.GetEnemy(enemy);
    }
}
