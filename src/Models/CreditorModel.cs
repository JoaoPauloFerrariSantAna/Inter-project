using System.ComponentModel.DataAnnotations;

namespace InterProject.Models;

public class CreditorModel {
	private int creditorId { get; set; } // FK for the ClientModel Role
	private int debtId { get; set; } // FK for DebtModel
	public double loanAmount { get; set; }

	public CreditorModel(int creditorId, int debtId, double loanAmount) {
		this.creditorId = creditorId;
		this.debtId = debtId;
		this.loanAmount = loanAmount;
	}
}
