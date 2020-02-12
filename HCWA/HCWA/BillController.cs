using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
     public class BillController
    {
        double displayamt;
        
        public string createNewBill(double amt, int id, int servicenumber)
        {
            Bills b = new Bills(amt, id, servicenumber);
            DBMng.insertIntoBills(b);
            return "Successfully billed";
        }
        //-------------------------//
        //WHY ARE THERE NO COMMENTS//
        //-------------------------//
        public double getEnrolleePayAmt(Bills bill)
        {
            int id = bill.getEnrolleeId();
            double deductible = Convert.ToDouble(DBMng.getDeductible(id));
            if (deductible > bill.getAmount())
            {
                return bill.getAmount();
                
            }
            else if ((bill.getAmount() > deductible) && (bill.getCopay() > 0))
            {
                if (bill.getCopay() > deductible) {
                    return bill.getCopay();
                }
                else if (bill.getNetworkCharge() < 1) {
                    double chargedAmt = bill.getAmount();
                    displayamt = deductible + bill.getCopay() + ((bill.getAmount() - deductible - bill.getCopay()) * (1.0 - bill.getNetworkCharge()));
                    switch (bill.getServiceNumber())
                    {
                        case 0:
                            if (chargedAmt > 2000) { displayamt = displayamt + (chargedAmt - 2000); }
                        break;
                        case 1:
                            if (chargedAmt > 1500) { displayamt = displayamt + (chargedAmt - 1500); }
                            break;
                        case 2:
                            if (chargedAmt > 1000) { displayamt = displayamt + (chargedAmt - 1000); }
                            break;
                        case 3:
                            if (chargedAmt > 4000) { displayamt = displayamt + (chargedAmt - 4000); }
                            break;
                        case 4:
                            if (chargedAmt > 10000) { displayamt = displayamt + (chargedAmt - 10000); }
                            break;
                        case 5:
                            if (chargedAmt > 30000) { displayamt = displayamt + (chargedAmt - 30000); }
                            break;
                        case 6:
                            if (chargedAmt > 500) { displayamt = displayamt + (chargedAmt - 500); }
                            break;
                        case 7:
                            if (chargedAmt > 150) { displayamt = displayamt + (chargedAmt - 150); }
                            break;
                        case 8:
                            if (chargedAmt > 300) { displayamt = displayamt + (chargedAmt - 300); }
                            break;
                        case 9:
                            if (chargedAmt > 25) { displayamt = displayamt + (chargedAmt - 25); }
                            break;
                        case 10:
                            if (chargedAmt > 300) { displayamt = displayamt + (chargedAmt - 300); }
                            break;
                        case 11:
                            if (chargedAmt > 300) { displayamt = displayamt + (chargedAmt - 300); }
                            break;
                        case 12:
                            if (chargedAmt > 250) { displayamt = displayamt + (chargedAmt - 250); }
                            break;
                        case 13:
                            if (chargedAmt > 100) { displayamt = displayamt + (chargedAmt - 100); }
                            break;
                        default:                        
                            break;
                    }
                    return displayamt;
                }
                else {
                    return deductible + bill.getCopay();
                }

            }
            else {
                if (bill.getNetworkCharge() < 1) {
                    return bill.getAmount() * (1 - bill.getNetworkCharge());
                }
                else {
                    return 0;
                }
            }
        }
        public string payBill(Bills bill)
        {
            int id = bill.getBillId();
            int enrid = bill.getEnrolleeId();
            double deductible = Convert.ToDouble(DBMng.getDeductible(enrid));

            if (deductible > bill.getAmount())
            {
                DBMng.updateDeductible(enrid, Convert.ToInt32(deductible - bill.getAmount()));
                DBMng.updateIsPaid(id);

            }
            else
            {
                DBMng.updateDeductible(enrid, 0);
                DBMng.updateIsPaid(id);
            }
            return "Bill has been paid.";
        }

        

    }
}
