using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Info
    {
        public String exibirInfo(int index)
        {
            String info = "";
            switch (index)
            {
                case 0:
                    info = ("Nome: Bubble Sort\r\nComplexidade: Alta\r\nEstabilidade: Estável");
                    break;

                case 1:
                    info = ("Nome: Selection Sort\r\nComplexidade: Alta\r\nEstabilidade: Instável");
                    break;

                case 2:
                    info = ("Nome: Insertion Sort\r\nComplexidade: Alta\r\nEstabilidade: Estável");
                    break;

                case 3:
                    info = ("Nome: Shake Sort\r\nComplexidade: Alta\r\nEstabilidade: Estável");
                    break;

                case 4:
                    info = ("Nome: Comb Sort\r\nComplexidade: Média\r\nEstabilidade: Instável");
                    break;

                case 5:
                    info = ("Nome: Shell Sort\r\nComplexidade: Média\r\nEstabilidade: Instável");
                    break;

                case 6:
                    info = ("Nome: Quick Sort\r\nComplexidade: Média\r\nEstabilidade: Instável");
                    break;

                case 7:
                    info = ("Nome: Merge Sort\r\nComplexidade: ???\r\nEstabilidade: ???");
                    break;

                case 8:
                    info = ("Nome: Heap Sort\r\nComplexidade: Média\r\nEstabilidade: Estável");
                    break;

                default:
                    info = String.Format("Por favor, selecione um método primeiro.");
                    break;
            }
            return info;
        }
    }
}
