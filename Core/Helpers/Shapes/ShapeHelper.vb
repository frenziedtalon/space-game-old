﻿Namespace Helpers.Shapes
    Public Class ShapeHelper

        Public Shared Function VolumeOfASphere(radius As Integer) As Double
            Return (4 / 3) * Math.PI * radius * radius
        End Function

    End Class
End Namespace