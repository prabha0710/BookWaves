using System;


namespace BookWaves.Common
{
	public  class UserDTO
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public UserType UserType { get; set; }

	}	
}
