using UnityEngine;

[RequireComponent(typeof(Entity))]
public class EntityMove : MonoBehaviour {
	private Entity Entity;

	void Start () {
		Entity = GetComponent<Entity>();
	}
	
	// Update is called once per frame
	void Update () {
		GamePath path = Entity.currentPath;

		if(path == null) {
			return;
		}

		Vector3 movement = path.pathEnd.position - transform.position;
		Vector3 frameMovement = movement.normalized * Entity.speed * Time.deltaTime;
		
		if(movement.magnitude >= frameMovement.magnitude) {
			transform.Translate(frameMovement, Space.World);
			transform.LookAt(path.pathEnd);
		} else {
			Entity.Escape();
		}
	}
}
