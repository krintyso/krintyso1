Imports System

Module Program
  Sub Main ()
      Dim Message, Title, MyValue
      Message = "Hello! What's your name?"
      Title = "Name asker"
      MyValue = InputBox(Message, Title)
      Console.Writeline(" Greetings " & MyValue)
  End Sub
End Module
