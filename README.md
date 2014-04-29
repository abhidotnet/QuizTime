QuizTime
========

REST based solution using webapi.

This is homework for most people. This is a working example of REST based architecture using web-api. 
I plan to build on this solution. It runs in Visual Studio 2013 and also holds a reference to JustMock. 
This reference is not required at this time.

The solution has been tested using SoapUi. There is no user interface for this project. 
Pressing F5 will bring up the browser.

The URLs used to test are:
http://localhost:49792
/api/quizanswer/computescore --> Send a valid quizanswer json.
/api/quizanswer --> Gets an answer string
/api/question --> Gets list of questions along with the choices available.
/api/question/{id} --> Gets specific question.
