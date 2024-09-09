using System;
using BookWaves.Common;

namespace BookWaves.Data
{
    public class User
    {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
        public UserType UserType { get; set; }

		
		public User(UserDTO DTOuser)
		{
			Id = DTOuser.Id;
			Name = DTOuser.Name;
			Email = DTOuser.Email;
			Password = DTOuser.Password;
			UserType = DTOuser.UserType;

		}

	}
}