using System.Linq;
using BookWaves.Common;
using BookWaves.Data;

namespace BookWaves.Logic
{
	public  class AuthenticationBL
	{
		public  bool Register(UserDTO DTOuser)
		{
			bool Existuser = BookWavesContext.Users.Any(u => u.Email == DTOuser.Email);
			if(Existuser)
			{
				return false;
			}
			var newUser = new User(DTOuser);

			BookWavesContext.Users.Add(newUser);
			return true;
		}

		public UserDTO  Login(string strEmail , string strPassword)
		{
			var userExist = BookWavesContext.Users.FirstOrDefault(u => u.Email == strEmail && u.Password == strPassword);

			if(userExist != null)
			{
				return new UserDTO
				{
					Id = userExist.Id,
					Name = userExist.Name,
					UserType = userExist.UserType,
					Email = userExist.Email,
					Password = userExist.Password

				};
			}

			return default;
		}
	}
}
