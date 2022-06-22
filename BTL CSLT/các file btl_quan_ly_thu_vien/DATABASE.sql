-- Quan Ly Thu Vien 


-- Tao bang 
-- Tao bang ngon ngu
Create table NgonNgu 
( MaNgonNgu char(50)
  Constraint nn_pk primary key,
  TenNgonNgu nvarchar(50));

-- Tao bang the loai
Create table TheLoai 
( MaTheLoai char(50)
  Constraint tl_pk primary key,
  TenTheLoai nvarchar(50));

-- Tao bang nha xuat ban
Create table NhaXuatBan 
( MaNXB char(50)
  Constraint nxb_pk primary key,
  TenNXB nvarchar(50),
  DiaChiNXB nvarchar(50),
  SdtNXB nvarchar(50),
  EmailNXB nvarchar(50)); 

-- Tao bang DMsach 
Create table DMSach 
( MaSach char(50)
  Constraint s_pk primary key ,
  TenSach nvarchar(50),
  TenTG nvarchar(50),
  NamXB date ,
  KhoSach nvarchar(50) ,
  GiaSach float ,
  LanTaiBan float ,
  SoTrang float,
  TomTatND nvarchar(200),
  SoLuong float ,
  DonGiaThue float ,
  MaNgonNgu char(50),
  MaTheLoai char(50),
  MaNXB char(50),
  CONSTRAINT snn_fk FOREIGN KEY (MaNgonNgu) REFERENCES NgonNgu(MaNgonNgu),
  CONSTRAINT stl_fk FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
  CONSTRAINT snxb_fk FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan(MaNXB));
  
-- Tao bang dan toc
  Create table DanToc 
  ( MaDanToc char(50) 
    Constraint dt_pk primary key ,
	TenDanToc nvarchar(50));

-- Tao bang Que
  Create table Que 
  ( MaQue char(50)
    Constraint q_pk primary key ,
	TenQue nvarchar(50));

-- Tao bang Vi pham 
  Create table ViPham 
  ( MaViPham char(50)
    Constraint vp_pk primary key ,
	TienPhat float ,
	TenViPham nvarchar(50));

-- Tao bang thu thu 
  Create table ThuThu 
  ( MaThuThu char(50)
    Constraint tt_pk primary key , 
	TenThuThu nvarchar(50),
	DiaChiThuThu nvarchar(50),
	SdtCDThuThu nvarchar(50),
	SdtDDThuThu nvarchar(50),
	MaQue char(50),
    CONSTRAINT ttq_fk FOREIGN KEY (MaQue) REFERENCES Que(MaQue));

-- Tao bang the muon
  Create table TheMuon 
  ( MaTheMuon char(50)
    Constraint tm_pk primary key,
	HoTen nvarchar(50),
	GioiTinh nvarchar(50),
	NgaySinh date ,
	DiaChiHienTai nvarchar(50),
	CMTND nvarchar(50),
	NgayLamThe date ,
	NgayHetHan date ,
	SoLuongMuon int ,
	MaQue char(50),
	MaDanToc char(50),
	CONSTRAINT tmq_fk FOREIGN KEY (MaQue) REFERENCES Que(MaQue),
    CONSTRAINT tmdt_fk FOREIGN KEY (MaDanToc) REFERENCES DanToc(MaDanToc));

-- Tao bang ho so muon 
   Create table HoSoMuon
   ( MaHSM char(50)
     Constraint hsm_pk primary key ,
	 NgayMuon date ,
	 TamUng float ,
	 MaThuThu char(50),
	 MaTheMuon char (50),
	 CONSTRAINT hsmtt_fk FOREIGN KEY (MaThuThu) REFERENCES ThuThu(MaThuThu),
     CONSTRAINT hsmtm_fk FOREIGN KEY (MaTheMuon) REFERENCES TheMuon(MaTheMuon));

-- Tao bang Chi tiet ho so muon 
   Create table ChiTietHSM 
   ( MaSach char(50),
     MaHSM char(50),
	 TinhTrang nvarchar(50),
	 CONSTRAINT cthsm_pk PRIMARY KEY ( MaSach , MaHSM ) ,
     CONSTRAINT cthsms_fk FOREIGN KEY (MaSach) REFERENCES DMSACH(MaSach),
     CONSTRAINT cthsmhsm_fk FOREIGN KEY (MaHSM) REFERENCES HoSoMuon(MaHSM));

-- Tao ho so tra 
   Create table HoSoTra 
   ( MaHST char(50)
     Constraint hst_pk primary key ,
	 MaHSM char(50),
	 NgayTra date ,
	 TongTien float ,
	 SoTienThanhToan float ,
	 MaThuThu char(50),
	 CONSTRAINT hsthsm_fk FOREIGN KEY (MaHSM) REFERENCES HoSoMuon(MaHSm),
	 CONSTRAINT hsttt_fk FOREIGN KEY (MaThuThu) REFERENCES ThuThu(MaThuThu));

-- Tao ho so chi tiet tra 
   Create table ChiTietHST 
   ( MaHST char(50),
     MaSach char(50),
	 ThanhTien float ,
	 MaViPham char(50) ,
	 CONSTRAINT cthst_pk PRIMARY KEY ( MaSach , MaHST ) ,
	 CONSTRAINT cthstvp_fk FOREIGN KEY (MaViPham) REFERENCES ViPham(MaViPham),
     CONSTRAINT cthsts_fk FOREIGN KEY (MaSach) REFERENCES DMSACH(MaSach),
     CONSTRAINT cthsthst_fk FOREIGN KEY (MaHST) REFERENCES HoSoTra(MaHST));



--- Them du lieu 
--- Them bang ngonngu
insert into NgonNgu( MaNgonNgu , TenNgonNgu)
   values('S1001' , N'Tiếng Việt');
insert into NgonNgu( MaNgonNgu , TenNgonNgu)
   values('S1002' , N'Tiếng Anh');
insert into NgonNgu( MaNgonNgu , TenNgonNgu)
   values('S1003' , N'Tiếng Trung Quốc');
insert into NgonNgu( MaNgonNgu , TenNgonNgu)
   values('S1004' , N'Tiếng Nhật');
insert into NgonNgu( MaNgonNgu , TenNgonNgu)
   values('S1005' , N'Tiếng Pháp');
   
--- them bang theloai 
insert into theloai ( MaTheLoai , TenTheLoai ) 
  values ( 'ct1', N'Chính trị');
insert into theloai ( MaTheLoai , TenTheLoai ) 
  values ( 'pl2', N'Pháp luật');
insert into theloai ( MaTheLoai , TenTheLoai ) 
  values ( 'cn3', N'Truyện tranh');
insert into theloai ( MaTheLoai , TenTheLoai ) 
  values ( 'kt4', N'Kinh tế');
insert into theloai ( MaTheLoai , TenTheLoai ) 
  values ( 'nght5', N'Nghệ thuật');

--- them bang nha xuat ban 
insert into nhaxuatban ( MaNXB , TenNXB ,SdtNXB, DiaChiNXB, EmailNXB) 
  values ( 'NXB001', N'NXB Giao thông vận tải' ,'0979810001', N'Hoàn Kiếm , Hà Nội' , ' Giaothongvantai@gmail.com' );
insert into nhaxuatban ( MaNXB , TenNXB ,SdtNXB , DiaChiNXB, EmailNXB ) 
  values ( 'NXB002', N'NXB Lao động' ,'0979810002', N'Đống Đa , Hà Nội', 'Laodong@gmail.com' );
insert into nhaxuatban ( MaNXB , TenNXB ,SdtNXB , DiaChiNXB, EmailNXB ) 
  values ( 'NXB003', N'NXB Thông tin và truyền thông' ,'0979810003', N'Trần Duy Hưng , Hà Nội','thongtintuyentruyen@gmail.com' );
insert into nhaxuatban ( MaNXB , TenNXB ,SdtNXB , DiaChiNXB, EmailNXB ) 
  values ( 'NXB004', N'NXB Tư pháp' ,'0979810004', N'Hoàn Kiếm , Hà Nội','tuphap@gmail.com'  );
insert into nhaxuatban ( MaNXB , TenNXB ,SdtNXB , DiaChiNXB ,EmailNXB ) 
  values ( 'NXB005', N'NXB Hội nhà văn' ,'0979810005', N'Nguyễn Du , Hà Nội' ,'hoinhvan@gmail.com');

--- them du lieu bang DMsach 
insert into DMsach ( MaSach , TenSach , TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue , MaNgonNgu , MaTheLoai , MaNXB) 
   values ('SSI' , N'Kinh tế chính trị' , N'Vũ Thị Bình' ,'10/2/2000' , '12*13', 120000 , 3 , 34 , N'Cuốn sách nói về lịch sử hình thành chính trị và sự phát triển kinh tế của Việt Nam' , 8 , 20000 , 'S1001' , 'ct1' , 'NXB001');
insert into DMsach ( MaSach , TenSach , TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue,MaNgonNgu, MaTheLoai , MaNXB) 
   values ('SSII' , N'Pháp luật đại cương' , N'Đào Tùng Lâm' , '11/3/2001' , '13*14', 150000 , 4 , 45 , N'Cuốn sách nói chi tiết về các luật cũng như sự thay đổi giữa các lần sửa luật' , 10 , 50000 , 'S1002' , 'pl2' , 'NXB002');
insert into DMsach ( MaSach , TenSach , TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue,MaNgonNgu, MaTheLoai , MaNXB) 
   values ('SSIII' , N'Cậu bé bút chì' , N'Nguyễn Thị Hà' , '12/4/2002' , '14*15', 170000 , 7 , 21 , N'Cuốn sách kể về cuộc sống thường ngày của cậu bé shin với nhiều tình tiết gây cười' , 5 , 70000 , 'S1003' , 'cn3' , 'NXB003');
insert into DMsach ( MaSach , TenSach , TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue , MaNgonNgu , MaTheLoai , MaNXB) 
   values ('SSIV' , N'Kinh tế vi mô' , N'Vũ Thị Ba' , '2/2/2003' , '12*13', 190000 , 2 , 29 , N'Cuốn sách nói về các công thức tính toán phù hợp để phát triển nền kinh tế' , 2 , 90000 , 'S1004' , 'kt4' , 'NXB004');
insert into DMsach ( MaSach , TenSach , TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue, MaNgonNgu , MaTheLoai , MaNXB) 
   values ('SSV' , N'Mỹ thuật Việt Nam' , N'Đinh Tiến Dũng' , '2/12/2001' , '11*12', 110000 , 10 , 56 , N'Cuốn sách nói về những tác phẩm hội họa cũng như xu hướng thẩm mỹ qua từng thế hệ Việt Nam' , 10 , 10000 , 'S1005' , 'nght5' , 'NXB005');

---- them du lieu bang dan toc 
insert into DanToc ( MaDanToc , TenDanToc ) 
   values ('DT001' , N'Kinh');
insert into DanToc ( MaDanToc , TenDanToc ) 
   values ('DT002' , N'Tày');
insert into DanToc ( MaDanToc , TenDanToc ) 
   values ('DT003' , N'Dao');
insert into DanToc ( MaDanToc , TenDanToc ) 
   values ('DT004' , N'Thái');
insert into DanToc ( MaDanToc , TenDanToc ) 
   values ('DT005' , N'Mông');
   
   --- them du lieu bang Que 
insert into Que ( MaQue , TenQue ) 
   values ( 'QI' , N'Hà Nội');
insert into Que ( MaQue , TenQue ) 
   values ( 'QII' , N'Bắc Ninh');
insert into Que ( MaQue , TenQue ) 
   values ( 'QIII' , N'Bắc Giang');
insert into Que ( MaQue , TenQue ) 
   values ( 'QIV' , N'Lạng Sơn');
insert into Que ( MaQue , TenQue ) 
   values ( 'QV' , N'Hà Nam');

--- them du lieu bang vi pham
insert into ViPham ( MaViPham , TenViPham , TienPhat)
   values('VP001' , N'Rách sách',10000);
insert into ViPham ( MaViPham , TenViPham , TienPhat)
   values('VP002' , N'Mất sách',20000);
insert into ViPham ( MaViPham , TenViPham , TienPhat)
   values('VP003' , N'Bẩn sách',30000);
insert into ViPham ( MaViPham , TenViPham , TienPhat)
   values('VP004' , N'Trả sách muộn 1 tuần',50000);
insert into ViPham ( MaViPham , TenViPham , TienPhat)
   values('VP005' , N'Trả sách muộn 1 tháng trở lên',100000);

---Them du lieu vao thuthu
insert into ThuThu ( MaThuThu ,TenThuThu ,DiaChiThuThu ,SdtCDThuThu ,SdtDDThuThu ,MaQue )
  values( 'TT100' , N'Tăng Thùy Liên' , N'Ba Đình' ,'0212345671','0979812221','QI');
insert into ThuThu ( MaThuThu ,TenThuThu ,DiaChiThuThu ,SdtCDThuThu ,SdtDDThuThu ,MaQue )
  values( 'TT200' , N'Trần Phương Thảo' , N'Hà Nam','0212345672','0979822222','QII');
insert into ThuThu ( MaThuThu ,TenThuThu ,DiaChiThuThu ,SdtCDThuThu ,SdtDDThuThu ,MaQue )
  values( 'TT300' , N'Vũ Diệp Linh' , N'Bình Định','0212345673','0979822233','QIII');
insert into ThuThu ( MaThuThu ,TenThuThu ,DiaChiThuThu ,SdtCDThuThu ,SdtDDThuThu ,MaQue )
  values( 'TT400' , N'Vũ Thị Trang' , N'Lào Cai','0212345674','0979822244','QIV');
insert into ThuThu ( MaThuThu ,TenThuThu ,DiaChiThuThu ,SdtCDThuThu ,SdtDDThuThu ,MaQue )
  values( 'TT500' , N'Tôn Đức Thắng' , N'Phú Thọ','0212345675','0979822255','QV');

--- Them du lieu bang the muon 
Insert into TheMuon (MaTheMuon ,HoTen ,GioiTinh ,NgaySinh ,DiaChiHienTai,CMTND ,NgayLamThe,NgayHetHan ,SoLuongMuon ,MaQue ,MaDanToc )
  values ('TMA' , N'Hồ Ngọc Hà',N'Nữ','2001/2/1',N'Thanh Xuân, Hà Nội','124940131','2020/1/23','2020/7/23' , 1,'QIV','DT001');
Insert into TheMuon (MaTheMuon ,HoTen ,GioiTinh ,NgaySinh ,DiaChiHienTai,CMTND ,NgayLamThe,NgayHetHan ,SoLuongMuon ,MaQue ,MaDanToc )
  values ('TMB' , N'Bùi Anh Tuấn',N'Nam','2001/4/3',N'Ba Đình, Hà Nội','124940132','2019/2/3','2019/9/23' , 2,'QI','DT002');
Insert into TheMuon (MaTheMuon ,HoTen ,GioiTinh ,NgaySinh ,DiaChiHienTai,CMTND ,NgayLamThe,NgayHetHan ,SoLuongMuon ,MaQue ,MaDanToc )
  values ('TMC' , N'Lương Minh Phương',N'Nữ','2000/5/6',N'Nguyễn Trãi, Hà Nội','124940133','2021/2/23','2022/9/24' , 1 ,'QIII','DT003');
Insert into TheMuon (MaTheMuon ,HoTen ,GioiTinh ,NgaySinh ,DiaChiHienTai,CMTND ,NgayLamThe,NgayHetHan ,SoLuongMuon ,MaQue ,MaDanToc )
  values ('TMD' , N'Bùi Tiến Dũng',N'Nam','2002/4/5',N'Hoài Đức, Hà Nội','124940134','2018/1/23','2019/9/6' , 2 ,'QV','DT004');
Insert into TheMuon (MaTheMuon ,HoTen ,GioiTinh ,NgaySinh ,DiaChiHienTai,CMTND ,NgayLamThe,NgayHetHan ,SoLuongMuon ,MaQue ,MaDanToc )
  values ('TMH' , N'Quế Ngọc Hải',N'Nam','2000/6/7',N'Hai Bà Trưng, Hà Nội','124940135','2020/9/2','2022/9/2' , 3 ,'QII','DT005');

--- them du lieu vao ho so muon 
Insert into  HoSoMuon( MaHSM , MaTheMuon , TamUng  ,MaThuThu ,NgayMuon) 
  values('HSMA','TMA', 10000 , 'TT500','2020/2/23');
Insert into  HoSoMuon( MaHSM , MaTheMuon , TamUng  ,MaThuThu ,NgayMuon) 
  values('HSMB','TMH', 25000 , 'TT400','2020/10/3');
Insert into  HoSoMuon( MaHSM , MaTheMuon , TamUng  ,MaThuThu ,NgayMuon) 
  values('HSMC','TMD', 35000 , 'TT200','2018/3/23');
Insert into  HoSoMuon( MaHSM , MaTheMuon , TamUng  ,MaThuThu ,NgayMuon) 
  values('HSMD','TMB', 45000 , 'TT100','5/6/2019');
Insert into  HoSoMuon( MaHSM , MaTheMuon , TamUng  ,MaThuThu ,NgayMuon) 
  values('HSME','TMC', 5000 , 'TT300','2022/7/25');

--- them du lieu vao chi tiet ho so muon 
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSI' , 'HSME',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSII' , 'HSME',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSIII' , 'HSME',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSIV' , 'HSMD',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSV' , 'HSMD',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSIII' , 'HSMC',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSIV' , 'HSMA',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSV' , 'HSMB',N'Chưa trả');
Insert into ChiTietHSM ( MaSach ,MaHSM ,TinhTrang )
  values ('SSIV' , 'HSMB',N'Chưa trả');

--- them du lieu bang ho so tra 
Insert into HoSoTra ( MaHST ,MaHSM, NgayTra ,TongTien  ,SoTienThanhToan ,MaThuThu )
  values('HST1','HSMA' ,'2020/6/22', 190000 , 190000 ,'TT300');
Insert into HoSoTra ( MaHST ,MaHSM, NgayTra ,TongTien  ,SoTienThanhToan ,MaThuThu )
  values('HST2','HSMB' ,'2022/9/1', 340000 , 340000 ,'TT400');
Insert into HoSoTra ( MaHST ,MaHSM, NgayTra ,TongTien  ,SoTienThanhToan ,MaThuThu )
  values('HST3','HSMC' ,'2019/9/5', 140000 , 140000 ,'TT200');
Insert into HoSoTra ( MaHST ,MaHSM, NgayTra ,TongTien  ,SoTienThanhToan ,MaThuThu )
  values('HST4','HSMD' ,'2020/7/24', 500000 , 500000 ,'TT100');
Insert into HoSoTra ( MaHST ,MaHSM, NgayTra ,TongTien  ,SoTienThanhToan ,MaThuThu )
  values('HST5','HSME' ,'2022/9/20', 450000 , 450000 ,'TT500');

--- them du lieu bang chi tiet ho so tra 
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST1','SSIV',190000,null );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST2','SSV',340000,'VP001' );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST2','SSIV',340000,'VP003' );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST3','SSIII',140000,'VP002' );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST4','SSV',500000,'VP005');
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST4','SSIV',500000,'VP005');
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST5','SSI',450000,null );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST5','SSI',450000,'VP001' );
Insert into ChiTietHST ( MaHST ,MaSach ,ThanhTien ,MaViPham )
  values('HST5','SSI',450000,null );
 
 -- Tao bang dang nhap 
Create table DangNhap 
( TenDangNhap nvarchar(50),
  MatKhau nvarchar(50),
);

Insert into DangNhap ( TenDangNhap , MatKhau ) 
   values ('Nhom1', '10CSLT');
Insert into DangNhap ( TenDangNhap , MatKhau ) 
   values ('HocSinh', '12345');
Insert into DangNhap ( TenDangNhap , MatKhau ) 
   values ('NhomTruong', 'CSLTDe');   
Insert into DangNhap ( TenDangNhap , MatKhau ) 
   values ('ThuThu', 'QuanLy');  
Insert into DangNhap ( TenDangNhap , MatKhau ) 
   values ('NhanVien', 'QuanLyThuVien');