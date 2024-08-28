using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallComponents : MonoBehaviour
{
    #region VARIAVEIS
    public float positioninX = -3f;
    public float durationinX = 2;
    private float originalpositioninX = 2;
    public int movimentos = 0;

    #endregion

    #region METODO
    public void mudarpositioninX (float local, float duration)
    {
        transform.DOMoveX((local), duration);
    }
    #endregion

    void Start()
    {
        Debug.Log("Iniciando o jogo");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            mudarpositioninX(positioninX, durationinX);
            movimentos++;
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            mudarpositioninX(originalpositioninX, durationinX);
            movimentos++;
        }
    }
}
