using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

/*
 * O que uma divida tem?
 * Ela tem:
 * - Um ID
 * - A quantidade de dinheiro que se deve
 * - Quando a dívida foi feita
 * - Quando a dívida vai acabar
 * - O nome (ou ID) de quem precisou do dinheiro
 * - O nome (ou ID) de quem foi pego o dinheiro
*/

public class DebtModel {
	private int debtId { get; set; }			// Unique ID
	private int inDebtedId { get; set; }		// InDebt ID
	private int creditorId { get; set; }		// Creditor ID
	private DateTime initialDate { get; set; }	// Timestamp not null
	private DateTime endDate { get; set; }		// Timestamp not null
	public double moneyAmount { get; set; }

	public DebtModel(int debtId, int inDebtedId, int creditorId, 
					double moneyAmount, DateTime initialDate, DateTime endDate) {
		this.debtId = debtId;
		this.inDebtedId = inDebtedId;
		this.creditorId = creditorId;
		this.moneyAmount = moneyAmount;
		this.initialDate = initialDate;
		this.endDate = endDate;
	}
}