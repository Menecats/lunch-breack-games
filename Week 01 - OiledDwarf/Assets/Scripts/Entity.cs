using UnityEngine;

public class Entity : MonoBehaviour {
    public float maxSpeed = 40f;
	public float speed = 10f;

	public GamePath currentPath {get; private set;}

	public void setPath(GamePath path) {
		this.currentPath = path;
	}

	// Update is called once per frame
	void Update () {
		if(currentPath == null) {
			return;
		}
	}

	public void Escape() {
		this.currentPath = null;

		Debug.Log("Escaped");

		Destroy(gameObject);
	}

	public void Die() {
		this.currentPath = null;

		Debug.Log("Dead");

		Destroy(gameObject);
	}
}
