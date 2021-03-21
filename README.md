# idf_Hatal_v1
Ido Ben Yossef
Messages:
--------------------
-Contains a list of message objects.
Message:
-------------------
-represent a message in the json file.
-contains which action the message has.
-contains which type of message is this.
ActionMessage:
-------------------
-Contains whether the action is request or answer.
-If it's answer- also contains whether the last request has passed.
TypeMessage:
-------------------
-Contains the type of message - end/ start /classification.
Classification:
------------------
-Contains the rate of Classification.
-Contains the urgency of Classification.


AVL:
--------------
-The data structure to instore the messages from the json file.
-The tree is ordered by the datetime..
-Add: adding a new message ==> O(log n).
-Find: find if a certain message (x) is in the tree ==> O(log n).

-In case we have 'n' messages building the entire tree would be ==> O(n * log n).
