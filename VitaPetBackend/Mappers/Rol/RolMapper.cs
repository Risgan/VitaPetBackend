using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Models.Rol;

namespace VitaPetBackend.Mappers.Rol
{
    public class RolMapper
    {
        public static RolModel MapCreate(RolCreateDto dto)
        {
            return new RolModel()
            {
                nombre = dto.nombre,
            };
        }

        public static RolModel MapResponse(RolDto dto)
        {
            return new RolModel()
            {
                id = dto.id,
                nombre = dto.nombre
            };
        }

        public static RolDto MapResponse(RolModel dto)
        {
            return new RolDto()
            {
                id = dto.id,
                nombre = dto.nombre
            };
        }

        internal static IEnumerable<RolDto> MapResponse(IEnumerable<RolModel> enumerable)
        {
            IEnumerable<RolDto> response = enumerable.Select(MapResponse);
            return response;
        }

        internal static IEnumerable<RolModel> MapResponse(IEnumerable<RolDto> enumerable)
        {
            IEnumerable<RolModel> response = enumerable.Select(MapResponse);
            return response;
        }
    }
}
