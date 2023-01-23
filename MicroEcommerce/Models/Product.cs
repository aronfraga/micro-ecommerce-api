﻿using Silvernet.Models.DTO;
using Silvernet.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Silvernet.Models {
	public class Product {

		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = Messages.PRO_MOD_BRAND)]
		public string Brand { get; set; }

		[Required(ErrorMessage = Messages.PRO_MOD_MODEL)]
		public string Model { get; set; }

		public string Description { get; set; }

		[ForeignKey("CategoryId")]
		[Required(ErrorMessage = Messages.PRO_MOD_CATEG)]
		public int CategoryId { get; set; }

		[JsonIgnore]
		public Category Category { get; set; }

		[Required(ErrorMessage = Messages.PRO_MOD_PRICE)]
		public double Price { get; set; }

		[Required(ErrorMessage = Messages.PRO_MOD_STOCK)]
		public int Stock { get; set; }

	}
}
