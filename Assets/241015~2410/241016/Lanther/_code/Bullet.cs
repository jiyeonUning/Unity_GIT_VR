using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float returnTime;
             private float remainTime;


    void OnEnable() { remainTime = returnTime; }

    void Update()
    {
        remainTime -= Time.deltaTime;
        if (remainTime < 0) { Destroy(bulletPrefab); }
    }
}
