<html>
	<head>
		<title>Data Member</title>
	</head>
	
<table align="center">
	<form method="POST" action="proses/add_data.php">
	<tr>
		<td>Nama Lengkap</td>
		<td><input type="text" name="nama"></td>
	</tr>
	<tr>
		<td>Jenis Kelamin</td>
		<td><input type="radio" value="Laki-Laki" name="jenis_kelamin">Laki-Laki <input type="radio" value="perempuan" name="jenis_kelamin">Perempuan</td>
	</tr>
	<tr>
		<td>Tanggal Lahir</td>
		<td><select name="hari">
			<?php
			
			for($i=1; $i<=31; $i++)
			
		
			
			{
				
			echo "<option value =".$i.">".$i."</option>";
			
			}
			
			?>
			</select>
		
			<select name="bulan">
		
			<?php
			
			$bulan = array("Jan", "Feb", "Mart", "Apl", "Mei", "Jun", "Jul", "Agust", "Sept", "Oct", "Nov", "Des");
			for($i=1; $i<=12; $i++)
				
			{
			
			echo "<option value=".$i.">".$bulan[$i]."</option>";
			
			}
			
			?>
			
			</select>
		
			<select name="tahun">
		
			<?php
			
			for($i=1986; $i<=2018; $i++)
				
			{
			
			echo "<option value = ".$i.">".$i."</option>";
			
			}
			
			?>
			</select>
		</td>
		
		<tr>
			<td>Telepon</td>
			<td><input type="text" name="tlp"></td>
		</tr>
		
		<tr>
			<td>Email</td>
			<td><input type="text" name="email"></td>
		</tr>
		
		<tr>
			<td>Alamat</td>
			<td><textarea name="alamat"></textarea></td>
		</tr>
		
		<tr>
			<td>Kota</td>
			<td><input type="text" name="kota"></td>
		</tr>
		
		<tr>
			<td>Kode Pos</td>
			<td><input type="text" name="kode_pos"></td>
		</tr>
		
		<tr>
			<td>Catatan</td>
			<td><input type="text" name="catatan"></td>
		</tr>
		
		<tr>
			<td><input type="submit" name="submit" value="Simpan"></td>
		</tr>
		</form>
</table>