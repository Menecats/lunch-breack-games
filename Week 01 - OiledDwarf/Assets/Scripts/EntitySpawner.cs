using UnityEngine;

public class EntitySpawner : MonoBehaviour {
    public GameObject[] entitiesToSpawn;
	public int entitiesPerMinute = 10;

	public GamePath[] paths;

	public float nextSpawn = 5f;

	void Update() {
		nextSpawn -= Time.deltaTime;

		if(nextSpawn <= 0) {
			SpawnEnemy();
			nextSpawn = 60 / entitiesPerMinute;
		}
	}

	void SpawnEnemy() {
		GamePath targetPath = paths[Random.Range(0, paths.Length)];
		GameObject entityPrefab = entitiesToSpawn[Random.Range(0, entitiesToSpawn.Length)];

		GameObject entityInstance = Instantiate(entityPrefab, targetPath.pathStart.position, Quaternion.identity);
		Entity entity = entityInstance.GetComponent<Entity>();

		entity.setPath(targetPath);
	}
}
