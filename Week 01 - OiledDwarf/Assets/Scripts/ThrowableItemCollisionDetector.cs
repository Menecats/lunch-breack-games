using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableItemCollisionDetector : MonoBehaviour {
    public ThrowableItem throwableItem;

    void OnCollisionEnter(Collision collision)
    {
        throwableItem.Explode();
    }
}
