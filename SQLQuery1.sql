SELECT T0.[ItemCode]
	, T0.[MinOrdrQty]
	, T0.[CardCode] 
	, (SELECT TOP 1 A.AvgPrice FROM OITW A where A.ItemCode = T0.[ItemCode] AND  A.AvgPrice > 0) As Precio
	FROM OITM T0 
	WHERE T0.[ItemCode] LIKE 'MP%'


	SELECT T0.[ItemCode] , T0.[MinOrdrQty] , T0.[CardCode] , (SELECT TOP 1 A.AvgPrice FROM OITW A where A.ItemCode = T0.[ItemCode] AND  A.AvgPrice > 0) As Precio 	FROM OITM T0  	WHERE T0.[ItemCode] LIKE 'MP%'

