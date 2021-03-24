using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    Image image;
    GenerateBalloons b1;

    bool isTouched = false;

    int spriteNumber = 0;

    void Start()
    {
        b1 = transform.root.GetComponent<GenerateBalloons>();
        image = GetComponent<Image>();
        Color col = new Color(Random.Range(0f, 1f) , Random.Range(0f, 1f), Random.Range(0f, 1f));
        col.a = Random.Range(0.6f, 1f);
        image.color = col;
    }

    public void OnTouch()
    {
        if(isTouched || b1.isOnMenu) return;
        isTouched = true;
        b1.killedCount++;
        b1.ShowKilledText();
        StartCoroutine(ShowAnim());
        Destroy(gameObject, 0.8f);
    }

    IEnumerator ShowAnim()
    {
        image.sprite = b1.destrSp[spriteNumber];
        spriteNumber++;
        if(spriteNumber == b1.destrSp.Length) 
        {
            image.enabled = false;
            yield break;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ShowAnim());
        yield return null;
    }

    void OnCollisitionEnter2D(Collision2D collision)
    {
        b1.leackedCount++;
        b1.ShowLeackdText();
        Destroy(gameObject);
    }
}
