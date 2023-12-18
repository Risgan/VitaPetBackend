using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Models.Usuario;

namespace VitaPetBackend.Mappers.Usuario
{
    public class UsuarioMapper
    {
        public static UsuarioModel MapCreate(UsuarioCreateDto dto)
        {
            return new UsuarioModel()
            {
                tipo_documento = dto.tipo_documento,
                rol = dto.rol,
                documento = dto.documento,
                primer_nombre = dto.primer_nombre,
                segundo_nombre = dto.segundo_nombre,
                primer_apellido = dto.primer_apellido,
                segundo_apellido = dto.segundo_apellido,
                foto = dto.foto,
                veterinaria = dto.veterinaria
            };
        }

        public static UsuarioModel MapResponse(UsuarioDto dto)
        {
            return new UsuarioModel() {
                id = dto.id,
                tipo_documento = dto.tipo_documento,
                rol = dto.rol,
                documento = dto.documento,
                primer_nombre = dto.primer_nombre,
                segundo_nombre = dto.segundo_nombre,
                primer_apellido = dto.primer_apellido,
                segundo_apellido = dto.segundo_apellido,
                foto = dto.foto,
                veterinaria = dto.veterinaria
            };
        }

        public static UsuarioDto MapResponse(UsuarioModel dto)
        {
            return new UsuarioDto()
            {
                id = dto.id,
                tipo_documento = dto.tipo_documento,
                rol = dto.rol,
                documento = dto.documento,
                primer_nombre = dto.primer_nombre,
                segundo_nombre = dto.segundo_nombre,
                primer_apellido = dto.primer_apellido,
                segundo_apellido = dto.segundo_apellido,
                foto = dto.foto,
                veterinaria = dto.veterinaria
            };
        }

        internal static IEnumerable<UsuarioDto> MapResponse(IEnumerable<UsuarioModel> enumerable)
        {
            IEnumerable<UsuarioDto> response = enumerable.Select(MapResponse);
            return response;
        }

        internal static IEnumerable<UsuarioModel> MapResponse(IEnumerable<UsuarioDto> enumerable)
        {
            IEnumerable<UsuarioModel> response = enumerable.Select(MapResponse);
            return response;
        }
    }
}
