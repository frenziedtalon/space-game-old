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

Partial Public Class Texture
    Public Property Id As Integer
    Public Property Name As String
    Public Property PathId As Integer
    Public Property TypeId As Integer

    Public Overridable Property TexturePath As TexturePath
    Public Overridable Property TextureType As TextureType
    Public Overridable Property TextureGroupToTextures As ICollection(Of TextureGroupToTexture) = New HashSet(Of TextureGroupToTexture)

End Class