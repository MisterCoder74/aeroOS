Module Module2

    Private _Mode As Tools ' Strumento selezionato

    Public Enum Tools
        Pencil
        Rubber
        Cutter
        Line
        Rectangle
        Ellipse
    End Enum

    Public Property Mode() As Tools
        Get
            Return _Mode
        End Get
        Set(ByVal value As Tools)
            _Mode = value
        End Set
    End Property

End Module