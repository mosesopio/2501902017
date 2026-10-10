Module Module 1
    Sub Main()
        Dim studentMarks(,) As Integer = {
            {75, 80, 90, 85},
            {80, 85, 95, 90},
            {90, 95, 81, 80},
            {85, 90, 80, 75}
         
           }   
           Console.WriteLine("Student Marks:") 
           For i As Integer = 0 To studentMarks.GetLength(0) - 1
                For j As Integer = 0 To studentMarks.GetLength(1) - 1
                    Console.Write(studentMarks(i, j) & vb Tab)
                Next
                console.WriteLine()   
            Next
            Console.WriteLine()  
            Console.WriteLine("The required mark is:" & studentMarks(2, 2))  
            Console.ReadLine() 
        Ene Sub
        End Module        
