Create Trigger barangKeluar on detailJual
after insert
as
declare @stok as int
declare @jum_jual as int
declare @kodebarang as varchar(25)
select @kodebarang = idBarangRefId, @jum_jual= jmlJual from inserted
select @stok=stok from Barang where idBarang=@kodebarang
set @stok = @stok - @jum_jual
begin transaction
	update barang set stok=@stok where idBarang = @kodebarang
if @@error=0
	commit transaction
else
	rollback transaction