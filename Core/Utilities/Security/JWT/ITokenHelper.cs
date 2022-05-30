using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper   // Kullanıcı username ve passwordu girdiğinde bizim apiye istek gelecek , burada CreateToken operasyonu çalışacak,
                                    //eğer doğruysa veritabanından kullanıcının claimlerini oluşturacak JWT üretecek ve onları karşıya verecek. 
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}


