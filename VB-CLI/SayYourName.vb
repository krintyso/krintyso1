Module Module1

    Sub Main()
        Dim Message, Title, MyValue
        Message = "Hello! What's your name?"
        Title = "Name asker"
        MyValue = InputBox(Message, Title)
        If MyValue = "Emily" Then
            Console.WriteLine("Hello Emily")
        ElseIf MyValue = "Joe" Then
            Console.WriteLine("Hello Joe")
        ElseIf MyValue = "Tyson" Then
            Console.WriteLine("Looks like someones a little lost *cracks knuckles")
        End If
    End Sub

End Module
