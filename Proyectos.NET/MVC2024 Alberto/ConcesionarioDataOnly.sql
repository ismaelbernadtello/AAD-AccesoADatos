USE [Concesionario]
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([Id], [Nom_Marca]) VALUES (1, N'Seat')
INSERT [dbo].[Marcas] ([Id], [Nom_Marca]) VALUES (2, N'Citroën')
INSERT [dbo].[Marcas] ([Id], [Nom_Marca]) VALUES (3, N'Volkswagen')
INSERT [dbo].[Marcas] ([Id], [Nom_Marca]) VALUES (4, N'Ferrari')
INSERT [dbo].[Marcas] ([Id], [Nom_Marca]) VALUES (5, N'Ford')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Series] ON 

INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (1, N'Málaga', 1)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (2, N'León', 1)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (3, N'Toledo', 1)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (4, N'c3', 2)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (5, N'Saxo', 2)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (6, N'Golf', 3)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (7, N'Jetta', 3)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (8, N'F-150', 4)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (9, N'LaFerrari', 4)
INSERT [dbo].[Series] ([Id], [NomSerie], [MarcaId]) VALUES (10, N'Focus', 5)
SET IDENTITY_INSERT [dbo].[Series] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursales] ON 

INSERT [dbo].[Sucursales] ([Id], [Nombre], [Direccion], [Ciudad]) VALUES (1, N'Flexicar', N'Crtra Logroño', N'Zaragoza')
INSERT [dbo].[Sucursales] ([Id], [Nombre], [Direccion], [Ciudad]) VALUES (2, N'CompramosTuCoche', N'las Fuentes', N'Zaragoza')
INSERT [dbo].[Sucursales] ([Id], [Nombre], [Direccion], [Ciudad]) VALUES (3, N'HR Motor', N'Alcobendas', N'Madrid')
SET IDENTITY_INSERT [dbo].[Sucursales] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] ON 

INSERT [dbo].[Vehiculos] ([Id], [Matricula], [Color], [SerieId], [SucursalId]) VALUES (1, N'TE-5498-D', N'Verde', 1, 1)
INSERT [dbo].[Vehiculos] ([Id], [Matricula], [Color], [SerieId], [SucursalId]) VALUES (2, N'9862 DGC', N'Negro', 2, 2)
INSERT [dbo].[Vehiculos] ([Id], [Matricula], [Color], [SerieId], [SucursalId]) VALUES (3, N'4414 FCZ', N'Verde', 7, 3)
INSERT [dbo].[Vehiculos] ([Id], [Matricula], [Color], [SerieId], [SucursalId]) VALUES (4, N'0030 LHY', N'Blanco', 6, 1)
INSERT [dbo].[Vehiculos] ([Id], [Matricula], [Color], [SerieId], [SucursalId]) VALUES (5, N'7785 JMS', N'Blanco', 10, 1)
SET IDENTITY_INSERT [dbo].[Vehiculos] OFF
GO
