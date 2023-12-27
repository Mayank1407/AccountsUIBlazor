using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApi.Sql.Queries
{
	[ExcludeFromCodeCoverage]
	public static class VendorQueries
    {
		public static string AllCustomer => "SELECT * FROM [Vendor] (NOLOCK)";

		public static string CustomerById => "SELECT * FROM [Vendor] (NOLOCK) WHERE [CustomerId] = @CustomerId";

		public static string AddCustomer =>
            @"INSERT INTO [dbo].[Vendor]
           ([FirstName]
           ,[MiddleName]
           ,[NickName]
           ,[LastName]
           ,[Mobile]
           ,[ReferredBy]
           ,[CreatedBy]
           ,[ModifiedDate]
           ,[CreatedDate]
           ,[ModifiedBy]
           ,[Url]
           ,[IsActive])
     VALUES
           (@FirstName
           ,@MiddleName
           ,@NickName
           ,@LastName
           ,@Mobile
           ,@ReferredBy
           ,@CreatedBy
           ,@ModifiedDate
           ,@CreatedDate
           ,@ModifiedBy
           ,@Url
           ,@IsActive)";

		public static string UpdateCustomer =>
            @"UPDATE [Vendor] 
            SET [FirstName] = @FirstName, 
				[LastName] = @LastName, 
				[Email] = @Email, 
				[PhoneNumber] = @PhoneNumber
            WHERE [CustomerId] = @CustomerId";

		public static string DeleteCustomer => "Update FROM [Vendor] WHERE [VendorId] = @CustomerId where isActive=0";
	}
}
