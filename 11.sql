insert into Karyawan(NIK,namaKaryawan,jabatan,[password],isDel)
 values(1100,'agung','admin','admin',0);
select * from Karyawan;
delete from Karyawan;
SET IDENTITY_INSERT Karyawan ON;
insert into Karyawan(NIK,namaKaryawan,jabatan,[password],isDel)
 values(1,'admin','admin','admin',0);
 selec