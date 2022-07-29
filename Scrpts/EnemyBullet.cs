using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 지가 향하는 방향으로 이동하고 싶다.
public class EnemyBullet : MonoBehaviour
{
    public float speed = 5;
    public GameObject explosionFactory;

    Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 지가 향하는 방향으로 이동하고 싶다.
        // P = P0 + vt
        transform.position += transform.up * speed * Time.deltaTime;
    }

    // 다른 물체와 부딪혔을 때 갸도 죽고 나도 죽고... 
    private void OnCollisionEnter(Collision collision)
    {
        EnemyBullet.CollisionEenemy(explosionFactory, transform, collision, gameObject);
    }

    public static void CollisionEenemy(GameObject explosionFactory, Transform transform, Collision collision, GameObject gameObject)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        if (collision.gameObject.name.Contains("Bullet"))
        {
            GameObject target = GameObject.Find("Player");
            if (target)
            {
                PlayerFire player = target.GetComponent<PlayerFire>();
                // 3. 탄창에 총알을 넣어주기
                player.bulletPool.Add(collision.gameObject);
                // 탄창에 집어 넣고싶다.
                collision.gameObject.SetActive(false);
            }
        }
        // 그렇지 않으면
        else
        {
            PlayerHealth.Instance.HP--;
            // 없애자
        }
        Destroy(gameObject);
    }
}