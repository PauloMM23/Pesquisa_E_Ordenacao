using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Ordenacao
    {
        public String ordem(int metodo, List<int> listaNumeros)
        {
            Metodos metodos = new Metodos();
            Stopwatch sw = Stopwatch.StartNew();
            sw.Reset();
            String tempo = "";

            switch (metodo)
            {
                case 0:
                    sw.Start();
                    metodos.bolha(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 1:
                    sw.Start();
                    metodos.selecao(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 2:
                    sw.Start();
                    metodos.insercao(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 3:
                    sw.Start();
                    metodos.agitacao(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 4:
                    sw.Start();
                    metodos.pente(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 5:
                    sw.Start();
                    metodos.shell(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 6:
                    sw.Start();
                    metodos.quick(listaNumeros,0,listaNumeros.Count -1);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;

                case 7:
                    /*sw.Start();
                    metodos.merge(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;
                    */
                case 8:
                    sw.Start();
                    metodos.heapSort(listaNumeros);
                    sw.Stop();
                    tempo = "O TEMPO DE ORDENAÇÃO DOS NÚMEROS FOI: " + sw.ElapsedMilliseconds + "ms";
                    break;
                default:
                    tempo = "Por favor, digite algum número antes de executar.";
                    break;
            }
            return tempo;
        }
    }
}
