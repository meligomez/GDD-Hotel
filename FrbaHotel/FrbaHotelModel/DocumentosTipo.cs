using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
	public class DocumentosTipo
	{
		public int DocumentoId { get; set; }
		public string tipo { get; set; }
		public DocumentosTipo()
		{

		}
		public DocumentosTipo(int id, string desc)
		{
			this.DocumentoId = id;
			this.tipo = desc;
		}
		public List<DocumentosTipo> GetDocumentosTipos() {
			try
			{
				string[] docs = new string[4] { "DNI", "LC", "LE", "PASAPORTE" };
				List<DocumentosTipo> lst = new List<DocumentosTipo>();
				foreach (var item in docs)
				{ int id = 0;
					DocumentosTipo doc = new DocumentosTipo();
					doc.DocumentoId = id + 1;
					doc.tipo = item;
					lst.Add(doc);
				}
				return lst;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
