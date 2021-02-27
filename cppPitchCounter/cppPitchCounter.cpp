// cppPitchCounter.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;


int incrimentPitchCounter(int pitchCounter) {
	return pitchCounter+1;
}
void blit() {
	cout<<"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
}

int main()
{
	int buttonCLick = NULL;
	
	int pitchCount = 0;
	bool play = true;

	while (play)
	{
		blit();
		cout << "The current Pitch Count is: ";
		cout << pitchCount;
		cout << "\n";
		cout << "To count a pitch enter a 1 and enter: ";
		cin >> buttonCLick;
		if (buttonCLick !=NULL) {
			pitchCount = incrimentPitchCounter(pitchCount);
		}
	}
}

