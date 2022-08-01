using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;

    [ContextMenu("FadeIn")]
   public void FadeIn()
    {
        sprite.DOFade(1, 2).OnComplete(() =>
        {
            Debug.Log("FadeIn completo");
        });
    }

    [ContextMenu("FadeOut")]
    public void FadeOut()
    {
        sprite.DOFade(0, 2).OnComplete(() => StartGame()).OnStart(() =>
        {
            Debug.Log("FadeOut Iniciando");
        });
    }

    private void StartGame()
    {
        Debug.Log("FadeOut Completo");
    }


    private void Start()
    {
        FadeOut();
    }

}
