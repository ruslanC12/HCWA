using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    class Plan
    {
        private double PlanYearMaxBenefit;
        private double OutOfPocketMaxPerEnrollee;
        private double OutOfPocketMaxPerFamily;
        private double AnnualPlanDeductible;
        private double InpatientCharges;
        private double EmergencyRoom;
        private double OutpatientSurgery;
        private double DiagnosticsLabAndXray;
        private double PhysicianOfficeVisits;
        private double SpecialistOfficeVisits;
        private double PreventativeServices;
        private double BabyCare;
        private double DurableMedicalEquipment;
        private double NursingFacility;
        private double PhysicalTherapy;
        private double PrimaryEnrolleeFee;
        private double DependentEnrolleeFee;
        private double PrimaryEnrolleeChangeFee;
        private double DependentEnrolleeChangeFee;
        // if enrollee's plan is extended, this should be set to true

        public Plan(Boolean hasExtendedPlan)
        {
            if (hasExtendedPlan)
            {
                PlanYearMaxBenefit = 1000000.00;
                OutOfPocketMaxPerEnrollee = 6500;
                OutOfPocketMaxPerFamily = 12000.00;
                AnnualPlanDeductible = 0.00;
                InpatientCharges = 300.00;
                EmergencyRoom = 250.00;
                OutpatientSurgery = 250.00;
                DiagnosticsLabAndXray = 0.00;
                PhysicianOfficeVisits = 20.00;
                SpecialistOfficeVisits = 30.00;
                PreventativeServices = 0.00;
                BabyCare = 0.00;

                DurableMedicalEquipment = -99999999.99; //not finished
                NursingFacility = 0.00;
                PhysicalTherapy = 30.00;

                PrimaryEnrolleeFee = 65.00;
                DependentEnrolleeFee = 25.00;

                PrimaryEnrolleeChangeFee = 50.00;
                DependentEnrolleeChangeFee = 20.00;
            }
            else
            {
                PlanYearMaxBenefit = 250000.00;
                OutOfPocketMaxPerEnrollee = 9500;
                OutOfPocketMaxPerFamily = 18000.00;
                AnnualPlanDeductible = 250.00;
                InpatientCharges = -999999.99;
                EmergencyRoom = 250.00;
                OutpatientSurgery = -9999999.99;
                DiagnosticsLabAndXray = -99999999.99;
                PhysicianOfficeVisits = -999999999.99;
                SpecialistOfficeVisits = -999999.99;
                PreventativeServices = 0.00;
                BabyCare = 0.00;

                DurableMedicalEquipment = -99999999.99; //not finished
                NursingFacility = -9999999.99;
                PhysicalTherapy = -9999999.99;

                PrimaryEnrolleeFee = 45.00;
                DependentEnrolleeFee = 20.00;

                PrimaryEnrolleeChangeFee = 150.00;
                DependentEnrolleeChangeFee = 40.00;
            }
        }
    }
}
