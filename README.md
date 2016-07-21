# _Scrabbles Word Score with C#, Nancy, and Razor_

#### _Project Specifications_

#### By _**Sid Benavente & Shokouh Farvid & Russell Davies**_

## Description/Specs

| Behavior        | Input Example           | Output Example  |
| ------------- |:-------------:| -----:|
| A player can enter a letter and get a return value based on the letter | "A" | 1 |
| Each letter with a value of 1 is assigned to the appropriate group | [A,E,I,O,U,L,N,R,S,T] | 1 |
| Each letter with a value of 2 is assigned to the appropriate group | [D,G] | 2 |
| Each letter with a value of 3 is assigned to the appropriate group | [B,C,M,P] | 3 |
| Each letter with a value of 4 is assigned to the appropriate group | [F,H,V,W,Y] | 4 |
| Each letter with a value of 5 is assigned to the appropriate group | [K] | 5 |
| Each letter with a value of 8 is assigned to the appropriate group | [J,X] | 8 |
| Each letter with a value of 10 is assigned to the appropriate group | [Q,Z] | 10 |
| A player can enter two letters and their appropriate values are summed and returned| [A, Q] | 11 |
| A player can submit a seven-letter word and get a return summed value | "SEVENTY" | 13 |

* Player enters a potential Scrabble word, and the system returns the Scrabble score for that word.


* Clone this repository, and on your pre-configured Epicodus computer, run "DNU restore" at the PowerShell prompt in the top directory of the cloned repository. Then type in "DNX Kestrel" at the same prompt and a local instance of the kestrel server will boot. Navigate in your browser to "LocalHost:5004" to view the homepage.

## Known Bugs

## Support and contact details
Please contact the authors if you have any questions or comments.

## Technologies Used
This webpage was written using C#, Nancy, Razor, CSS, and Bootstrap.

### License
Copyright (c) 2016 _** Sid Benavente & Shokouh Farvid & Russell Davies **_

This software is licensed under the MIT license.
