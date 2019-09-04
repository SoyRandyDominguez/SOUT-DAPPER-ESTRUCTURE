select * from users
select * from Permissions
select * from UserPermissions
select * from PermissionFunctions

--Get User by Email and Password
select * from Users where Email = 'rdominguez@soutlogic.com' and Password ='root'

--Get permisos by UserID
select p.* from Permissions p
join  UserPermissions up on up.PermissionID = p.PermissionID
join Users u on u.UserID = up.UserID
where u.UserID = 1

--Get All Funciones del usuario by UserID
select pf.* from UserFunctions uf
join PermissionFunctions pf on pf.PermissionFunctionID = uf.PermissionFunctionID
join Users u on u.UserID = uf.UserID
where u.UserID = 1  and PermissionID = 1000


--Get  Funciones del usuario by UserID and PermissionID
select pf.* from UserFunctions uf
join PermissionFunctions pf on pf.PermissionFunctionID = uf.PermissionFunctionID
join Users u on u.UserID = uf.UserID
where u.UserID = 1  and pf.PermissionID = 1000