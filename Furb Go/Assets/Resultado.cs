﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resultado : MonoBehaviour
{
    private bool Posicionando = false;
    public GameObject BotaoBloco;
    public GameObject ScrollLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Posicionando)
        {
            Posicionando = true;
            foreach (var caminho in Map.Instrucoes)
            {
                var botao = (GameObject)Instantiate(BotaoBloco);
                botao.transform.SetParent(ScrollLayer.transform,false);
                botao.GetComponent<Button>().onClick.AddListener(OnClick);
                botao.transform.GetChild(0).GetComponent<Text>().text = "Bloco "+ caminho.Key.Nome;
            }
        }
    }

    private void OnClick()
    {
        //fazer alguma coisa
    }
}