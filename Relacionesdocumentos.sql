
--buscar pedido a partie de una requi
SELECT T3.[DocNum] FROM [dbo].[PRQ1]  T1
LEFT JOIN POR1 T2 ON T1.[TrgetEntry]=T2.[DocEntry] AND T1.[TargetType] =T2.[ObjType] 
INNER JOIN OPOR T3 ON T2.[DocEntry] = T3.[DocEntry] WHERE T1.[DocEntry] =64

--BUSCAR PEDIDO ENTRADA Y FACTURA

SELECT T3.[DocNum], T5.[DocNum], T7.[DocNum], T6.[TrgetEntry], T6.[TargetType] FROM [dbo].[PRQ1]  T1
LEFT JOIN POR1 T2 ON T1.[TrgetEntry]=T2.[DocEntry] AND T1.[TargetType] =T2.[ObjType] 
INNER JOIN OPOR T3 ON T2.[DocEntry] = T3.[DocEntry] 
LEFT JOIN PDN1 T4 ON T2.[TrgetEntry]=T4.[DocEntry] AND T2.[TargetType] =T4.[ObjType] 
INNER JOIN OPDN T5 ON T4.[DocEntry] = T5.[DocEntry]
LEFT JOIN PCH1 T6 ON T4.[TrgetEntry]=T6.[DocEntry] AND T4.[TargetType] =T6.[ObjType] 
INNER JOIN OPCH T7 ON T6.[DocEntry] = T7.[DocEntry] WHERE T1.[DocEntry] =64

SELECT T0.DocEntry, T1.DocNum FROM PCH1 T0
Left join OPCH T1 ON T0.DocEntry = T1.DocEntry
WHERE T1.DocNum = 34223

SELECT  top 10000 * FROM JDT1 
WHERE TransId = 370949
(
select TransId, * from OVPM
WHERE DocEntry = 19720
)

select top 1000 prcCode, PrcName from oprc


SELECT T0.[AbsId], T0.[AcctCode], T1.* FROM [dbo].[OBGT]  T0 
INNER JOIN [dbo].[BGT1]  T1 ON T1.[BudgId] = T0.[AbsId] 
WHERE T0.[AbsId]  = 173
AND (MONTH(GETDATE())-1) = T1.LINE_ID

SELECT TOP 1000 * FROM ADOC
