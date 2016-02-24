﻿Imports Entities

Public Interface IEntityManager
    Sub RegisterEntity(ByRef newEntity As BaseGameEntity)
    Sub RemoveEntity(ByRef pEntity As BaseGameEntity)
    Sub UpdateAll()
    Function GetEntityFromId(id As Guid) As BaseGameEntity
End Interface
