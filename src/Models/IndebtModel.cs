using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

/*
 * O que uma pessoa endividada tem?
 * Ela tem:
 * - Uma data de nascimento
 * - O valor da dívida
*/

public class IndebtModel {
	private int indebtId { get; set; }
	public double debtToPay { get; set; }

	// Constructor
	public IndebtModel(int indebtId, double debtToPay) {
		this.indebtId = indebtId;
		this.debtToPay = debtToPay;
	}
}
