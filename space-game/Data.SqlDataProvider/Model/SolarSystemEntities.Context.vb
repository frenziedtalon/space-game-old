﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class SolarSystemEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SolarSystemEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property SolarSystems() As DbSet(Of SolarSystem)
    Public Overridable Property Universes() As DbSet(Of Universe)
    Public Overridable Property Users() As DbSet(Of User)
    Public Overridable Property CelestialObjectTypes() As DbSet(Of CelestialObjectType)
    Public Overridable Property CelestialObjects() As DbSet(Of CelestialObject)

End Class