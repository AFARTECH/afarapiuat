﻿using MileDALibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileDALibrary.Interfaces
{
    public interface IUserRepository
    {
        List<LoginDetails> GetUserInformation(string PhoneNumber, string Password);

        List<CountryDetails> GetCountryDetails();

        List<StateDetails> GetStateDetails();

        List<DistrictDetails> GetDistrictDetails(int stateId, int countryId);

        List<VehicleDetails> GetVehicleDetails();

        List<GenderDetails> GetGenderDetails(string settingsName);

        Task<List<ResponseStatus>> UpdateProfileDetails(UpdateProfile updateProfile);

        List<DriverDetails> GetDriverDetails(string phoneNumber);

        Task<List<ResponseStatus>> SaveUserDetails(UserDetails userDetails);

        int SendEmail(string emailId, int otp);

        List<LoginDetails> GetUpdatedProfile(int userId);

        List<ResponseStatus> SaveLocation(LocationDetails locationDetails);

        List<LocationDetails> GetSavedLocation(int User_id, string Location_type);

        List<ResponseStatus> SaveBookingDetails(BookingDetails bookingDetails);

        List<DriverNotification> GetDriverNotificationDetails();

        Task<List<ResponseStatus>> DriverPaymentDetails(DriverPaymentDetails driverPaymentDetails);

        List<GetDriverPaymentDetails> GetDriverPaymentDetails(int User_Id);

        List<ExpiredVehicleInsurance> GetExpiredDrvLicense(ExpiredVehicleDetails expiredVehicleDetails);

        List<ResponseStatus> AddReferralDetails(ReferralDetails ReferralDetails);

        List<ResponseStatus> DriverRegPaymentStatusDetails(DriverRegPaymentStatus DriverRegPaymentStatus);

        List<ResponseStatus> SMSGatewayStatus(AddSMSGatewayStatus AddSMSGatewayStatus);
        List<ResponseStatus> UserPwdUpdate(PwdUpdate PwdUpdate);

        List<LoginDetails> GetUserByPhoneOrEmail(string PhoneNumber);
        List<ConfigSettings> GetMasterSettings(string settingsName);
        List<ReferralDetails> GetChkReferralCode(string ReferralCode, string UserTypeFlg);
        List<FareCalculations> GetFareCalculations(int userid, string frmloc, string toloc,
            string frmlat, string frmlong, string tolat, string tolong, string kms, string traveltime);
    }
}
