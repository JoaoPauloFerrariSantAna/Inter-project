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
	private int indebtedId { get; set; }		// FK
	private int creditorId { get; set; }		// FK
	private DateTime initialDate { get; set; }	// Timestamp not null
	private DateTime endDate { get; set; }		// Timestamp not null
	public double ammount { get; set; }

	public DebtModel(int debtId, int indebtedId, int creditorId,
					double ammount, DateTime initialDate, DateTime endDate) {
		this.debtId = debtId;
		this.indebtedId = indebtedId;
		this.creditorId = creditorId;
		this.ammount = ammount;
		this.initialDate = initialDate;
		this.endDate = endDate;
	}
}
