using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Prog3Api.NET.Data;
using Prog3Api.NET.Models;

namespace Prog3Api.NET.Business.PersonaBusiness
{
    public class GetPersonasById
    {
        public class GetPersonaByIdComando : IRequest<Persona>
        {
            public int IdPersona { get; set; }

        }
        public class EjecutaValidacion : AbstractValidator<GetPersonaByIdComando>
        {
            public EjecutaValidacion()
            {
                RuleFor(p => p.IdPersona).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<GetPersonaByIdComando, Persona>
        {
            private readonly ContextDB _contexto;
            public Manejador(ContextDB context)
            {
                _contexto = context;
            }

            public async Task<Persona> Handle(GetPersonaByIdComando comando, CancellationToken token)
            {
                var result = new Persona();
                try
                {
                    result = await _contexto.Personas.FirstOrDefaultAsync(c => c.Id == comando.IdPersona);
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        // todo
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                return result;
            }
        }
    }
}
