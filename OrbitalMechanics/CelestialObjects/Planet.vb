﻿
Imports Core
Imports Core.Classes
Imports Entities
Imports OrbitalMechanics.Classes

Namespace CelestialObjects
    Public Class Planet
        Inherits OrbitingCelestialObjectBase
        Implements ISphere

        Public Sub New(name As String,
                       mass As Integer,
                       texture As String,
                       radius As Distance,
                       entityManager As IEntityManager)

            MyBase.New(name, mass, texture, entityManager)
            _radius = radius
        End Sub

        Private ReadOnly _radius As Distance
        Public ReadOnly Property Radius As Distance Implements ISphere.Radius
            Get
                Return _radius
            End Get
        End Property

        Public ReadOnly Property AxialTilt As Integer Implements ISphere.AxialTilt
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property RotationSpeed As Integer Implements ISphere.RotationSpeed
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Private _volume As Double = 0

        Public ReadOnly Property Volume As Double Implements I3DObject.Volume
            Get
                If Double.Equals(_volume, 0.0) AndAlso Radius.Kilometers > 0 Then
                    _volume = Helpers.Shapes.ShapeHelper.VolumeOfASphere(Radius.Kilometers)
                End If
                Return _volume
            End Get
        End Property
        
    End Class
End Namespace