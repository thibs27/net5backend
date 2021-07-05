using System.ComponentModel.DataAnnotations;

namespace net5backend.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		public string UserName;
		[Required]
        public string Password;
    }
}