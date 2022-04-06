# PhoneNumberComparer
Given two phone number strings , this API compares if the numbers are in same order/sequence in both the strings
As per the requirements, logic will ignore anything other than number
logic uses recursion to compare the strings- char by char
if a char is not a number, pointer will be moved to next character within the string
Functionality is exposed as Azure Functions

Az Func takes two phone numbers as Input
Input will be submitted to Az Func as "POST"

{
"phone1":"818 584 9484",
"phone2":"818 5849 484"

}


