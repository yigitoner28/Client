Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Module MainModule

    Dim _client As TcpClient


    Sub Main(args As String())
        Try
            Dim ip As String = "xxx.xxx.x.xx"

            Dim port As Integer = xxxx

            _client = New TcpClient(ip, port)

            '_client = New TcpClient
            '_client.Connect(ip, port)

            Using ns As NetworkStream = _client.GetStream()

                While True

                    Dim toSend() As Byte = Encoding.ASCII.GetBytes(Console.ReadLine())

                    ns.Write(toSend, 0, toSend.Length)

                    Dim toReceive(100000) As Byte

                    Dim length As Integer = ns.Read(toReceive, 0, toReceive.Length)

                    Dim text As String = Encoding.ASCII.GetString(toReceive, 0, length)

                    Console.WriteLine(text)
                    Console.WriteLine()



                End While


            End Using


        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Console.ReadLine()



    End Sub
End Module
