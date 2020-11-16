<html>
<head>
<title>Daftar Member Maker Twitter - Langit Dev</title>
</head>
<body>
<font face="Verdana">
<?php
//Cek CPU Load
$load = sys_getloadavg();
$limit = 25;
if ($load[0] >= $limit) {
header('HTTP/1.1 503 Too busy, try again later'); die('<center><h2>Server penuh silahkan kembali dalam beberapa menit lagi.. :)</h2><a href="http://maker.favcc1.com/">Langit Maker</a><script> top.location.href="http://maker.favcc1.com/" </script></ center>');
}
else {
mysql_connect("db4free.net","ferdhika31","bandung0");
mysql_select_db("makertwt");

$sql = "select * from akun order by Nama asc";
$exe = mysql_query($sql);
echo "<h2>Daftar Member Maker Twitter</h2><hr>
<table border='1'>
<tr><th>No</th><th>Nama</th><th>Hak Akses</th><th>Status</th><th>Twitter</th><th>Tanggal Expire</th></tr>
";
$no = 1;
while($data = mysql_fetch_array($exe)){
echo "<tr><td>{$no}</td><td>{$data['nama']}</td><td>{$data['hak']}</td><td>{$data['status']}</td><td><a href='https://twitter.com/{$data['twitter']}' target='_blank'>{$data['twitter']}</a></td><td>{$data['tglexpire']}</td></tr>";
$no++;
}
echo "</table><hr><a href='http://adf.ly/ceo8K' target='_blank'>Download Apps</a><hr>

<a href='https://www.facebook.com/messages/ferdhika31' target='_blank'><img title='Harga akun' src='harga.jpg'/></a><br>
Kirim pesan ke fb saya http://facebook.com/ferdhika31
Format Pemesanan :
<ul type='square'>
<li>Nama :</li>
<li>Username :</li>
<li>Password :</li>
<li>Username Twitter :</li>
<li>Hak Akses :</li>
</ul>
Contoh :
<ul type='square'>
<li>Nama : Ferdhika Yudira</li>
<li>Username : ferdhika</li>
<li>Password : djancok</li>
<li>Username Twitter : FerdhikaYudira</li>
<li>Hak Akses : Premium</li>
</ul>
<br>
Pembayaran via Pulsa :
<ol>
<li>Telkomsel</li>
<li>Axis</li>
</ol>
";
}
?>
</body>
</html>