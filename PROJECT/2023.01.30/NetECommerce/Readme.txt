# ECommerce Project

.Net 3.1 versiyonu ile bir e-ticaret projesi oluşturulacak. Proje içerisinde temelde 3 katman tanımlanacak bu katmanlar;

	## NetECommerce.Entity => Veri tabanında tablo haline gelmesini istediğimiz classları barındıran katman.
		- Katmanda kullanılan paketler;
		#### Microsoft.AspNetCore.Identity.EntityFrameworkCore
	### Base
	### Entity
	### Enum
	### Interface

	## NetECommerce.DAL => Veri tabanı ile iletişim halinde olan katman.
		- Katmanda kullanılan paketler;
		#### Microsoft.AspNetCore.Identity.EntityFrameworkCore
		#### Microsoft.EntityFrameworkCore.SqlServer
		#### Microsoft.EntityFrameworkCore.Tools
	### Context
		####ProjectContext

	## NetECommerce.BLL => DAL (Data Access Layer) ile iletişim halinde olarak, alınan bilgileri Listeleme, Oluşturma, Güncelleme, Silme eylemlerini gerçekleştirecek olan katman
