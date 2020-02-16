Imports BL

Module Module1

    Sub Main()
        Console.WriteLine("Hello")
        Dim manager = New ProductManager()

        Dim products = manager.GetAll()

        For Each product In products
            Console.WriteLine(product)
        Next




    End Sub

End Module
