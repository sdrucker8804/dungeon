using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public GameObject mainCamera;
    public float duration;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SmoothCam(Vector3 target) {
        float percent = 0;
        Vector3 curr = mainCamera.transform.position;
        Vector3 initial = curr;
        player.GetComponent<movement>().moving = true;
        while (percent < 1)
        {
            curr = Vector3.Lerp(initial, target, percent);
            mainCamera.transform.position = curr;
            percent += Time.unscaledDeltaTime / duration;
            yield return null;
        }
        mainCamera.transform.position = target;
        player.GetComponent<movement>().moving = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StopCoroutine("SmoothCam");
            StartCoroutine("SmoothCam", new Vector3(transform.position.x, transform.position.y, -10));
        }

    }
}
