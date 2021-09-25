using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oni : MonoBehaviour {
    public Transform jibun_transform;
    public float speed = 0.1f;

    public Text kekka_moji;

    // Start is called before the first frame update
    void Start() {
      kekka_moji.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        Vector3 muki = jibun_transform.position - transform.position;
        muki.Normalize();
        transform.position += muki * speed;
    }

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Player") {
          // あたった相手の表示を消す
          //collision.gameObject.SetActive(false);

          // 自分の表示を消す
          //gameObject.SetActive(false);

          // 結果文字を表示
          kekka_moji.gameObject.SetActive(true);
        }

    }
}
