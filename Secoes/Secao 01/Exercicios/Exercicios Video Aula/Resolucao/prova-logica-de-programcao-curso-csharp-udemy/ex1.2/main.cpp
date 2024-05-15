#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

#define PI 3.14159

float circle_area(float radius);

int main() {
    float radius;

    cin >> radius;

    cout << fixed << setprecision(4);
    cout << "A=" << circle_area(radius) << endl;
    return 0;
}

float circle_area(float radius){
    return (PI*pow(radius, 2));
}
