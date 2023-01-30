# ECommerce Project

.Net 3.1 versiyonu ile bir e-ticaret projesi oluþturulacak. Proje içerisinde temelde 3 katman tanýmlanacak bu katmanlar;

	## NetECommerce.Entity => Veri tabanýnda tablo haline gelmesini istediðimiz classlarý barýndýran katman.
		- Katmanda kullanýlan paketler;
		#### Microsoft.AspNetCore.Identity.EntityFrameworkCore
	### Base
	### Entity
	### Enum
	### Interface

	## NetECommerce.DAL => Veri tabaný ile iletiþim halinde olan katman.
		- Katmanda kullanýlan paketler;
		#### Microsoft.AspNetCore.Identity.EntityFrameworkCore
		#### Microsoft.EntityFrameworkCore.SqlServer
		#### Microsoft.EntityFrameworkCore.Tools
	### Context
		####ProjectContext

	## NetECommerce.BLL => DAL (Data Access Layer) ile iletiþim halinde olarak, alýnan bilgileri Listeleme, Oluþturma, Güncelleme, Silme eylemlerini gerçekleþtirecek olan katman
