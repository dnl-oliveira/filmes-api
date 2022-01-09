using Microsoft.AspNetCore.Authorization;

namespace filmesAPI.Authorization
{
    public class IdadeMinimaRequirement: IAuthorizationRequirement
    {
        public int IdadeMinima { get; set; }
        public IdadeMinimaRequirement(int idadeMinima)
        {
            IdadeMinima = idadeMinima;
        }  
    }
}
