#include <iostream>
using namespace std;

int main() {
    int num_interactions, num_input, qtd_nums_in_interval, qtd_nums_out_interval;
    
    qtd_nums_in_interval = 0;
    qtd_nums_out_interval = 0;

    cin >> num_interactions;

    for(int i=0; i<num_interactions; i++)
    {
        cin >> num_input;

        if(num_input >= 10 && num_input <=20)
        {
            qtd_nums_in_interval++;
        }
        else
        {
            qtd_nums_out_interval++;
        }
    }

    cout << qtd_nums_in_interval << " in" << endl;
    cout << qtd_nums_out_interval << " out" << endl;

    return 0;
}
