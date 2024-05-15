#include <iostream>
#include <iomanip>
using namespace std;


int main() {
    int cod_piece, qntd_piece;
    float total_value, value_un_piece;

    total_value = 0;

    for(int i=0; i<2; i++)
    {
        cin >> cod_piece;
        cin >> qntd_piece;
        cin >> value_un_piece;
        total_value += qntd_piece * value_un_piece;
    }

    cout << fixed << setprecision(2);
    cout << "VALOR A PAGAR: R$ " << total_value << endl;
    return 0;
}
