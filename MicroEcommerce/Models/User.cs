using Silvernet.Utils;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Silvernet.Models {
	public class User {

		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = Messages.USER_MOD_USERNAME)]
		public string UserName { get; set; }

		[Required(ErrorMessage = Messages.USER_MOD_EMAIL)]
		public string Email { get; set; }

		[Required(ErrorMessage = Messages.USER_MOD_PASSWORD)]
		[JsonIgnore]
		public string Password { get; set; }

	}
}
