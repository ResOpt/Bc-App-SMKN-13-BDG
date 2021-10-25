USE testing

CREATE TABLE pengguna(
	user_id varchar(30) PRIMARY KEY NOT NULL,
	password varchar(32) NOT NULL,
	nama_pengguna varchar(100) NOT NULL,
	status INT NOT NULL
)

INSERT INTO pengguna(user_id, password, nama_pengguna, status) VALUES ("admin", "0192023a7bbd73250516f069df18b500","Admin", 2)

CREATE TABLE barang(
	kode_barang varchar(10) PRIMARY KEY NOT NULL,
	nama_barang varchar(100) NOT NULL,
	harga_beli INT NOT NULL,
	harga_jual INT NOT NULL,
	stok INT NOT NULL,
)

CREATE TABLE pembelian(
	no_nota_beli varchar(50) NOT NULL,
	tanggal_beli SMALLDATETIME NOT NULL,
	user_id varchar(30) NOT NULL,
	harga_beli INT NOT NULL,
	jumlah INT NOT NULL,
	kode_barang varchar(10) NOT NULL,
	subtotal INT NOT NULL,
	FOREIGN KEY (user_id) REFERENCES pengguna(user_id),
	FOREIGN KEY (kode_barang) REFERENCES barang(kode_barang),
)

CREATE TABLE penjualan(
	no_nota_jual varchar(50) PRIMARY KEY NOT NULL,
	tanggal_jual SMALLDATETIME NOT NULL,
	user_id varchar(30) NOT NULL,
	harga_jual INT NOT NULL,
	jumlah INT NOT NULL,
	kode_barang varchar(10) NOT NULL,
	subtotal INT NOT NULL,
	id INT NOT NULL,
	FOREIGN KEY (user_id) REFERENCES pengguna(user_id),
	FOREIGN KEY (kode_barang) REFERENCES barang(kode_barang),
)

CREATE TABLE pembelian_total(
	nota_pembelian varchar(50) NOT NULL,
	total INT NOT NULL,
)

CREATE TABLE penjualan_total(
	nota_penjualan varchar(50) NOT NULL,
	total INT NOT NULL,
)

CREATE TABLE log(
	user_id varchar(30) NOT NULL,
	FOREIGN KEY (user_id) REFERENCES pengguna(user_id)
)