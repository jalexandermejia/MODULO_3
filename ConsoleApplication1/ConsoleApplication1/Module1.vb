Module Module1

    Sub Main()
        float nota1, nota2,nota3, suma, promedio;
        Console.WriteLine("digite nota 1:") ;
        nota1 = float.parse(console.ReadLine()) ;
         Console.WriteLine("digite nota 2:");
        nota1 = float.parse(console.ReadLine()) ;
         Console.WriteLine("digite nota 3:");
        nota1 = float.parse(console.ReadLine()) ;
        suma = nota1 + nota2 + nota3;
        promedio = suma/3;

        If (promedio >= 3) Then

            Console.WriteLine("promocionado con: "+ promediio);
        Else
            Console.WriteLine(" no fue promocionado con: "+ promedio);

            Console.ReadKey();
        End If
    End Sub

End Module
