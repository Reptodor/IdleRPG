using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemySpawnerProperties _spawnerProperties;
    [SerializeField] private Player _player;
    [SerializeField] private Transform _gameDirectory;

    private Enemy _enemy;

    private void Update()
    {
        if (_enemy == null)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        Vector2 spawnPosition = new Vector2(_spawnerProperties.DistanceToPlayer(), _player.transform.position.y);
        _enemy = Instantiate(_spawnerProperties.Enemies()[ChooseEnemy(_spawnerProperties.SpawnChance())], spawnPosition, Quaternion.identity, _gameDirectory);
        _enemy.Initialize(_player);
        
        _player.GetEnemy(_enemy);
    }

    private int ChooseEnemy(float[] chances)
    {

        float chanceSum = 0;

        foreach (float chance in chances)
        {
            chanceSum += chance;
        }

        float randomPoint = Random.value * chanceSum;

        for (int i = 0; i < chances.Length; i++)
        {
            if (randomPoint < chances[i])
            {
                return i;
            }
            else
            {
                randomPoint -= chances[i];
            }
        }
        return chances.Length - 1;
    }
}
