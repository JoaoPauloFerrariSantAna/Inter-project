using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

public class ClientModel {
	private int clientId { get; set; }

	[Required(AllowEmptyStrings = false, ErrorMessage = "CPF é obrigatório")]
	[StringLength(15, MinimumLength = 15)]
	private string cpf { get; set; } = string.Empty;

	[Required(AllowEmptyStrings = false, ErrorMessage = "Email é obrigatório")]
	[StringLength(128, MinimumLength = 40)]
	private string email { get; set; } = string.Empty;

	private DateTime dataNasc { get; set; }

	// maybe separate fullName into lastName and firstName
	// For now, the minimum should only be firstName
	[Required(AllowEmptyStrings = false, ErrorMessage = "Nome é obrigatório")]
	[StringLength(32, MinimumLength = 8, ErrorMessage = "Nome curto")]
	public string fullName { get; set; } = string.Empty;

	public ClientModel(string fullName, string email, string cpf, DateTime dataNasc) {
		this.clientId = clientId;
		this.fullName = fullName;
		this.email = email;
		this.cpf = cpf;
		this.dataNasc = dataNasc;
	}
}
