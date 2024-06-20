using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

public class ClientModel {
	private int clientId { get; set; }
	private string cpf { get; set; } = string.Empty;
	private string email { get; set; } = string.Empty;
	private DateTime dataNasc { get; set; }
	public string name { get; set; } = string.Empty;

	public ClientModel(string name, string email, string cpf, DateTime dataNasc) {
		this.clientId = clientId;
		this.name = name;
		this.email = email;
		this.cpf = cpf;
		this.dataNasc = dataNasc;
	}
}
