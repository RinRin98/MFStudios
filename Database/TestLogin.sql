CREATE DATABASE TestLogin
GO

USE TestLogin
GO

CREATE TABLE NhanVien(
	MaNV CHAR(5) CONSTRAINT NV_PK PRIMARY KEY,
	pass VARCHAR(50) not null,
	HOTEN NVARCHAR(50) NOT NULL,
	SDT VARCHAR(11) NULL,
	gmail VARCHAR(50) not null
)

CREATE PROC INSERT_NV @pass VARCHAR(50), @HO_TEN NVARCHAR(50), @DT VARCHAR(11), @gmail VARCHAR(50)
AS
BEGIN
	DECLARE @ROW INT, @MaNV VARCHAR(5)
	IF NOT EXISTS(SELECT * FROM NhanVien)
		SET @MaNV ='NV001'
	ELSE
	BEGIN
		SELECT @ROW=MAX(CONVERT(INT,SUBSTRING(MaNV,5,LEN(MaNV)-1)))
		FROM NhanVien
		SET @MaNV='NV0'+ iif(@ROW<10, '0','') + CONVERT(VARCHAR(9),@ROW+1)
	END
	INSERT INTO NhanVien VALUES (@MaNV,@pass,@HO_TEN,@DT, @gmail)
END

EXEC INSERT_NV '123', N'Trần Hải Cường','0839776655', 'xuantoannguyen2212@gmail.com'
EXEC INSERT_NV 'admin', N'Nguyễn Xuân Toản','0988256956', 'xuantoannguyen2212@gmail.com'
EXEC INSERT_NV '345', N'Trần Hải Ly','0839776655', 'xuantoannguyen2212@gmail.com'
EXEC INSERT_NV '6787', N'Trần Hải','0839776655', 'xuantoannguyen2212@gmail.com'
EXEC INSERT_NV '6787', N'Trần Loi','0839776655', 'huynhthangloi2510@gmail.com'



Select HOTEN from NhanVien where MaNV = 'NV002';