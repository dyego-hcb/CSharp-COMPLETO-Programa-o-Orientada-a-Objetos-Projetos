#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

float calculate_delta(float a, float b, float c);
void calculate_baskara(float a, float b, float delta, float& x1, float& x2);

int main() {
    float a, b, c, delta, x1, x2;

    x1 = 0;
    x2 = 0;
    
    cin >> a;
    cin >> b;
    cin >> c;

    delta = calculate_delta(a, b, c);
    
    if(delta <= 0 || a == 0)
    {
        cout << "Impossivel calcular" << endl;
        return 0;
    }

    calculate_baskara(a, b, delta, x1, x2);

    cout << fixed << setprecision(5);
    cout << "X1 = " << x1 << endl;

    cout << fixed << setprecision(5);
    cout << "X2 = " << x2 << endl;
    return 0;
}

float calculate_delta(float a, float b, float c){
    float delta;

    delta = pow(b, 2) - (4 * a * c);

    return delta;
}

void calculate_baskara(float a, float b, float delta, float& x1, float& x2){
    x1 = (-b + sqrt(delta)) / (2 * a);
    x2 = (-b - sqrt(delta)) / (2 * a);
}
