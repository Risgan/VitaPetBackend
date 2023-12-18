using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Models.TipoDocumento;

namespace VitaPetBackend.Mappers.TipoDocumento
{
    public class TipoDocumentoMapper
    {
        public static TipoDocumentoModel MapCreate(TipoDocumentoCreateDto dto)
        {
            return new TipoDocumentoModel()
            {
                sigla = dto.sigla,
                documento = dto.documento,
            };
        }

        public static TipoDocumentoModel MapResponse(TipoDocumentoDto dto)
        {
            return new TipoDocumentoModel()
            {
                id = dto.id,
                sigla = dto.sigla,
                documento = dto.documento,
            };
        }

        public static TipoDocumentoDto MapResponse(TipoDocumentoModel dto)
        {
            return new TipoDocumentoDto()
            {
                id = dto.id,
                sigla = dto.sigla,
                documento = dto.documento,
            };
        }

        internal static IEnumerable<TipoDocumentoDto> MapResponse(IEnumerable<TipoDocumentoModel> enumerable)
        {
            IEnumerable<TipoDocumentoDto> response = enumerable.Select(MapResponse);
            return response;
        }

        internal static IEnumerable<TipoDocumentoModel> MapResponse(IEnumerable<TipoDocumentoDto> enumerable)
        {
            IEnumerable<TipoDocumentoModel> response = enumerable.Select(MapResponse);
            return response;
        }
    }
}
