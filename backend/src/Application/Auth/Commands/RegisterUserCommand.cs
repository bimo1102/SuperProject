using MediatR;

namespace Application.Auth.Commands
{
    public class RegisterUserCommand : IRequest<Guid>
{
    public string Email { get; set; }= string.Empty;
    public string Password { get; set; }= string.Empty;
}
  
}