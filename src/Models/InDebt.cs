using System.Component.DataAnnotations;

namespace InterProject.Models;

/*
 * O que uma pessoa endividada tem?
 * Ela tem:
 * - Um ID
 * - Um nome
 * - Um CPF
 * - Um email
 * - O valor da dívida
*/

public class InDebt {
	private int id;
	private int cpf;
	private double debt_value;
	private string name;
	private string email;

	public InDebt(int id, int cpf, double debt_value, string name, string email) {
		this.id = id;
		this.cpf = cpf;
		this.debt_value = debt_value;
		this.name = name;
		this.email = email;
	}
}
