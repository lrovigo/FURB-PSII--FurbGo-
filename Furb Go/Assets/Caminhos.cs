using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Caminhos : MonoBehaviour
{
    public static List<Bloco> blocos = new List<Bloco>();
    private bool achouCaminho = false;

    private List<Bloco> caminhos = new List<Bloco>();

    void Start()
    {

    }

    void popularLista()
    {
        blocos.Clear();
        Bloco A = new Bloco("A");
        Bloco B = new Bloco("B");
        Bloco C = new Bloco("C");
        Bloco D = new Bloco("D");
        Bloco E = new Bloco("E");
        Bloco F = new Bloco("F");
        Bloco G = new Bloco("G");
        Bloco H = new Bloco("H");
        Bloco I = new Bloco("I");
        Bloco J = new Bloco("J");
        Bloco K = new Bloco("K");
        Bloco L = new Bloco("L");
        Bloco M = new Bloco("M");
        Bloco N = new Bloco("N");
        Bloco Q = new Bloco("Q");
        Bloco R = new Bloco("R");
        Bloco S = new Bloco("S");
        Bloco T = new Bloco("T");
        Bloco U = new Bloco("U");
        Bloco V = new Bloco("V");
        Bloco W = new Bloco("W");
        A.Vizinhos = new List<Bloco>() { B, M};
        B.Vizinhos = new List<Bloco>() { A, I, C, M };
        C.Vizinhos = new List<Bloco>() { B, E, M};
        E.Vizinhos = new List<Bloco>() { C, D, F };
        D.Vizinhos = new List<Bloco>() { E };
        F.Vizinhos = new List<Bloco>() { E, G };
        G.Vizinhos = new List<Bloco>() { F, H, J, L, N, K };
        I.Vizinhos = new List<Bloco>() { B, T, S, R, Q };
        T.Vizinhos = new List<Bloco>() { I, S };
        S.Vizinhos = new List<Bloco>() { T, R, I, W, U };
        R.Vizinhos = new List<Bloco>() { Q, S, I, W, U };
        Q.Vizinhos = new List<Bloco>() { I, R, S, T };
        U.Vizinhos = new List<Bloco>() { V, R, S, T };
        V.Vizinhos = new List<Bloco>() { U, W };
        W.Vizinhos = new List<Bloco>() { V, R, S, T };
        H.Vizinhos = new List<Bloco>() { G, J, L, N, K };
        J.Vizinhos = new List<Bloco>() { H, G, L, N, K };
        L.Vizinhos = new List<Bloco>() { H, G, J, N, K };
        N.Vizinhos = new List<Bloco>() { H, G, J, L, K };
        K.Vizinhos = new List<Bloco>() { H, G, J, L, N };
        M.Vizinhos = new List<Bloco>() { A, B, C };
        blocos.AddRange(new[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, Q, R, S, T, U, V, W });
    }
    public string FindPath(string blocoDestino)
    {
        achouCaminho = false;
        popularLista();
        Bloco origem = blocos.Find(p => p.Nome == "C");
        Bloco destino = blocos.Find(q => q.Nome == blocoDestino);
        caminhos.Add(origem);
        SearchVizinhos(origem, destino);
        return string.Join("->", caminhos.Select(c => c.Nome));
    }

    void SearchVizinhos(Bloco origem, Bloco destino)
    {
        if (!achouCaminho)
        { 
            foreach (var vizinho in origem.Vizinhos)
            {
                if (vizinho.Nome == destino.Nome)
                {
                    achouCaminho = true;
                    caminhos.Add(vizinho);
                    break;
                }
                if (!caminhos.Contains(vizinho))
                {
                    caminhos.Add(vizinho);
                    SearchVizinhos(vizinho, destino);
                    if (achouCaminho)
                    {
                        break;
                    }
                }
            }
            if(!achouCaminho)
                caminhos.Remove(origem);
        }
    }
}

public class Bloco
{

    public string Nome { get; set; }
    public List<Bloco> Vizinhos { get; set; }

    public Bloco(string nome)
    {
        this.Nome = nome;
    }

}
