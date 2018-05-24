using UnityEngine;

public class Entity : MonoBehaviour
{
    public float maxSpeed = 40f;
    public float speed = 10f;

    public int dieScore = 0;
    public int escapeScore = 0;

    public GameObject dieEffectPrefab;

    public GamePath currentPath { get; private set; }

    public void setPath(GamePath path)
    {
        this.currentPath = path;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPath == null)
        {
            return;
        }
    }

    public void Escape()
    {
        this.currentPath = null;

        ScoreManager.instance.IncreaseScore(escapeScore);

        Destroy(gameObject);
    }

    public void Die()
    {
        this.currentPath = null;

        ScoreManager.instance.IncreaseScore(dieScore);
        if (dieEffectPrefab != null)
        {
            GameObject dieEffect = Instantiate(dieEffectPrefab, transform.position, Quaternion.identity);
            Destroy(dieEffect, 5f);
        }
        Destroy(gameObject);
    }
}
