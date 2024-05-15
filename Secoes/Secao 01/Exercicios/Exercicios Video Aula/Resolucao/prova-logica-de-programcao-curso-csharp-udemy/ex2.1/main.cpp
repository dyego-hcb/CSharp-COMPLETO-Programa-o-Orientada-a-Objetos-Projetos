#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main() {
    int cod_porduct, qtd_order;
    float total_value;

    cout << "Codigo - Especificacao - Preco" << endl;
    cout << "1 - Cachorro-Quente - R$ 4.00" << endl;
    cout << "2 - X-Salada - R$ 4.50" << endl;
    cout << "3 - X-Bacon - R$ 5.00" << endl;
    cout << "4 - Torrada Simples - R$ 2.00" << endl;
    cout << "5 - Refrigerante - R$ 1.50" << endl;
    cout << "Entre com o codigo do produto e a quantidade de itens no pedido:";

    cin >> cod_porduct;
    cin >> qtd_order;

    switch (cod_porduct)
    {
        case 1:
            total_value = qtd_order*4.00;
            break;
        case 2:
            total_value = qtd_order*4.50;
            break;
        case 3:
            total_value = qtd_order*5.00;
            break;
        case 4:
            total_value = qtd_order*2.00;
            break;
        case 5:
            total_value = qtd_order*1.50;
            break;
        default:
            break;
    }

    cout << fixed << setprecision(2);
    cout << "Total: R$ " << total_value << endl;
    return 0;
}
