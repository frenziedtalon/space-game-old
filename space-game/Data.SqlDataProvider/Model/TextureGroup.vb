'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TextureGroup
    Public Property Id As Integer
    Public Property GroupId As Integer
    Public Property TextureId As Integer
    Public Property TextureTypeId As Integer

    Public Overridable Property CelestialObjects As ICollection(Of CelestialObject) = New HashSet(Of CelestialObject)
    Public Overridable Property Texture As Texture
    Public Overridable Property TextureType As TextureType

End Class
