#include <iostream>
using namespace std;

#define PASSWORD 2002

int main() {
    int password_type;

    while (true) {
        cin >> password_type;
        if (password_type == PASSWORD) {
            cout << "Acesso Permitido" << endl;
            break;
        } else {
            cout << "Senha Invalida" << endl;
        }
    }

    return 0;
}
