using System.ComponentModel.DataAnnotations;

namespace FormsSample.Models {
	public class ContactModel {
		[Required]
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Mobile { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
