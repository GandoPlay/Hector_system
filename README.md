# idf_Hatal_v1
Ido Ben Yossef
Messages:
--------------------
-contains a list of message objects.
Message:
-------------------
-represent a message in the json file.
-contains which action the message has.
-contains which type of message is this.
ActionMessage:
-------------------
-contains whether the action is request or answer.
-if it's answer- also contains whether the last request has passed.
TypeMessage:
-------------------
-contains the type of message - end/ start /classification.
Classification:
------------------
-contains the rate of Classification.
-contains the urgency of Classification.


AVL:
--------------
-the data structure to instore the messages from the json file.
-the tree is ordered by the datetime.
-Add: adding a new message ==> O(log n)
-Find: find if a certain message (x) is in the tree ==> O(log n)

-in case we have 'n' messages building the entire tree would be ==> O(n * log n)
