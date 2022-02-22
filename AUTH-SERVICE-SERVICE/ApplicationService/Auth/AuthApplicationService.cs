using AUTH_SERVICE_COMMON.Exceptions;
using AUTH_SERVICE_COMMON.Helpers.AuditContext;
using AUTH_SERVICE_COMMON.Helpers.ConvertContext;
using AUTH_SERVICE_CROSSCUTING.DTO.User;
using AUTH_SERVICE_DOMAIN.Entities.User;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User.Interfaces;
using AUTH_SERVICE_SERVICE.ApplicationService.Auth.Interfaces;
using AUTH_SERVICE_SERVICE.ApplicationService.Config.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AUTH_SERVICE_SERVICE.ApplicationService.Auth
{
    public class AuthApplicationService : IAuthApplicationService
    {
        private readonly IAuthUnitOfWork _uow;
        private readonly ITokenApplicationService tokenApplicationService;

        public AuthApplicationService(IAuthUnitOfWork uow, ITokenApplicationService tokenApplicationService)
        {
            _uow = uow;
            this.tokenApplicationService = tokenApplicationService;
        }

        public async Task<LoginResponseDto> Login(LoginDto dto, CancellationToken ctToken = default)
        {
            ctToken.ThrowIfCancellationRequested();

            var password = dto.Password.ToSha256();
            var user = await _uow.UserRepository.GetUntracked()
                        .Where(user => user.Email == dto.Email && user.Password == password)
                        .FirstOrDefaultAsync(ctToken);


            if (user == null)
            {
                await _uow.LogRepository.AddAsync(AuditHelper.LogEntityWrongPassword(dto.Email));
                await _uow.CommitAsync();

                throw new NotFoundException("Email or Password is Incorrect.");
            }


            var userLogged = new LoginResponseDto
            {
                Token = tokenApplicationService.GenerateToken(user)
            };

            await _uow.LogRepository.AddAsync(AuditHelper.LogEntityLogin(user));
            await _uow.CommitAsync();

            return userLogged;
        }

        public async Task Register(RegisterDto dto, CancellationToken ctToken = default)
        {
            ctToken.ThrowIfCancellationRequested();

            var emailAlreadyRegisted = _uow.UserRepository.GetUntracked().Any(user => user.Email == dto.Email);

            if (emailAlreadyRegisted)
            {
                throw new DomainException("User already registered.");
            }

            var newUser = new UserEntity
            {
                Email = dto.Email,
                Name = dto.Name,
                Password = dto.Password.ToSha256(),
                LastName = dto.LastName
            };

            await _uow.UserRepository.AddAsync(newUser);
            await _uow.LogRepository.AddAsync(AuditHelper.LogEntityRegister(newUser));

            await _uow.CommitAsync();
        }

    }
}
