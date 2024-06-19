using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

/*
 * O que uma pessoa endividada tem?
 * Ela tem:
 * - Um ID
 * - Um nome
 * - Um CPF
 * - Um email
 * - Uma data de nascimento
 * - O valor da dívida
*/

public class InDebtModel {
	public string name			{ get; set; } = string.Empty;
	public DateTime? dataNasc	{ get; set; }
	// XXX.XXX-YY
	private string cpf			{ get; set; } = string.Empty;
	private string email		{ get; set; } = string.Empty;

	// Constructor
	public InDebtModel(string name, DateTime dataNasc, string cpf, string email) {
		this.name = name;
		this.dataNasc = dataNasc;
		this.cpf = cpf;
		this.email = email;
	}
}
