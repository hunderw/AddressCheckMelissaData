
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Net;


namespace AddressCheckSOAP
{
    public partial class Form1 : Form
    {
        // Initialize DQWS Service, Request Array, and Response Array
        dqwsAddressCheck.RequestArray ReqAddressCheck = new dqwsAddressCheck.RequestArray();
        dqwsAddressCheck.ResponseArray ResAddressCheck = new dqwsAddressCheck.ResponseArray();
        dqwsAddressCheck.ServiceClient AddressCheckClient = new dqwsAddressCheck.ServiceClient();

        int recordCount = 0;
        int TotalRecords = 1;
        int currentRecord = 0;
        int MaxArraySize = 20;   //Set this to the initial maximum number of records in your array
        XmlSerializer XmlSer;
        FileStream fs;
        System.Xml.XmlDocument rootNode = new System.Xml.XmlDocument();
        Boolean isInitialized = true;


        public Form1()
        {
            InitializeComponent();

            txtMaxArraySize.Text = MaxArraySize.ToString();
            txtMaxRecords.Text = MaxArraySize.ToString();
        }


        // Function to Initialize DQWS V2 XML
        private void Initialize()
        {
            // Initialize new instance of Request Array
            // Change the MaxArraySize value to the maximum number of records you with to insert

            ReqAddressCheck = new dqwsAddressCheck.RequestArray();
            // Set Customer ID and Transmission Reference (Optional)
            ReqAddressCheck.CustomerID = txtCustomerID.Text;
            ReqAddressCheck.TransmissionReference = "Testing: DQWS SOAP Sample Code implementation using multiple record inputs.";
            ReqAddressCheck.OptAddressParsed = "True";

            //Initialize the records array
            ReqAddressCheck.Record = new dqwsAddressCheck.RequestArrayRecord[MaxArraySize];
        }

        // Function to Insert a Record for Multiple Record Handling
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // When Starting to Insert Records, cannot change maximum in between.
            btnChangeMax.Enabled = false;
            txtMaxRecords.Enabled = false;

            if (recordCount == 0)
                Initialize();

            if (recordCount != MaxArraySize)
            {
                // Clicking insert multiple times will cause the following finction to be called
                // Records will be inserted until the Verify button is clicked or until the maximum
                // number of records are reached.

                // Set the input fields for current record
                ReqAddressCheck.Record[recordCount] = new dqwsAddressCheck.RequestArrayRecord();
                ReqAddressCheck.Record[recordCount].Company = txtCompany.Text;
                ReqAddressCheck.Record[recordCount].Urbanization = txtUrbanization.Text;
                ReqAddressCheck.Record[recordCount].AddressLine1 = txtAddress1.Text;
                ReqAddressCheck.Record[recordCount].AddressLine2 = txtAddress2.Text;
                ReqAddressCheck.Record[recordCount].Suite = txtSuite.Text;
                ReqAddressCheck.Record[recordCount].City = txtCity.Text;
                ReqAddressCheck.Record[recordCount].State = txtState.Text;
                ReqAddressCheck.Record[recordCount].Zip = txtZip.Text;
                ReqAddressCheck.Record[recordCount].Plus4 = txtPlus4.Text;
                ReqAddressCheck.Record[recordCount].Country = txtCountry.Text;
                ReqAddressCheck.Record[recordCount].LastName = txtLastName.Text;

                // Increment Record Count
                recordCount = recordCount + 1;

                // Output current record number
                txtRecordCount.Text = recordCount.ToString();

            }
        }


        // Function to Begin Address Verification Process for Single and Multiple Records
        private void btnLookUp_Click(object sender, EventArgs e)
        {
            // After Verifying Records, Maximum can now be Changed.
            btnChangeMax.Enabled = true;
            txtMaxRecords.Enabled = true;


            // Clear the XML Each Time
            webBrowser1.Navigate("about:blank");

            // If recordCount = 1 that means there are no records, then simply do the current user inputs
            if (recordCount == 0)
            {
                Initialize();

                // Set the input fields for current record
                ReqAddressCheck.Record[recordCount] = new dqwsAddressCheck.RequestArrayRecord();
                ReqAddressCheck.Record[recordCount].Company = txtCompany.Text;
                ReqAddressCheck.Record[recordCount].Urbanization = txtUrbanization.Text;
                ReqAddressCheck.Record[recordCount].AddressLine1 = txtAddress1.Text;
                ReqAddressCheck.Record[recordCount].AddressLine2 = txtAddress2.Text;
                ReqAddressCheck.Record[recordCount].Suite = txtSuite.Text;
                ReqAddressCheck.Record[recordCount].City = txtCity.Text;
                ReqAddressCheck.Record[recordCount].State = txtState.Text;
                ReqAddressCheck.Record[recordCount].Zip = txtZip.Text;
                ReqAddressCheck.Record[recordCount].Plus4 = txtPlus4.Text;
                ReqAddressCheck.Record[recordCount].Country = txtCountry.Text;
                ReqAddressCheck.Record[recordCount].LastName = txtLastName.Text;

                // Increment Record Count
                recordCount = recordCount + 1;
            }

            short Retry;
            bool ReqRet;

            Retry = 0;
            ReqRet = false;
            do
            {
                try
                {
                    // Perform AddressCheck Interface and store results to the Response
                    ResAddressCheck = AddressCheckClient.doAddressCheck(ReqAddressCheck);
                    ReqRet = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Retry++;
                }
            } while ((ReqRet == false) && (Retry < 5));



            // Counter set to 0 each time
            currentRecord = 0;


            // Perform Outputting first record onto the output fields
            // Must be initialized Correctly to continue
            isInitialized = true;
            PopulateFields();

            if (isInitialized)
            {

                btnNext.Enabled = true;
                btnPrevious.Enabled = true;

                // Create an XML Serializer
                XmlSer = new XmlSerializer(ResAddressCheck.GetType());

                // Read in XML filestream and then output it to the AxtiveX Web Browser
                fs = new FileStream((System.Environment.CurrentDirectory + "\\Response.xml"), FileMode.Create);
                XmlSer.Serialize(fs, ResAddressCheck);
                fs.Close();
                webBrowser1.Navigate(System.Environment.CurrentDirectory + "\\Response.xml");


                rootNode.Load("Response.xml");


                // Set the Number of Total Records
                TotalRecords = Convert.ToInt32(ResAddressCheck.TotalRecords);
                txtTotal.Text = TotalRecords.ToString();
                txtRecNo.Text = Convert.ToString(1);

                // Output current record number
                txtRecordCount.Text = recordCount.ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;

                // Set the Number of Total Records
                TotalRecords = 1;
                txtTotal.Text = Convert.ToString(0);
                txtRecNo.Text = Convert.ToString(0);

            }

            // Reset Record Counts
            recordCount = 0;
            txtRecordCount.Text = recordCount.ToString();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear AddressCheck Fields
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtPlus4.Text = "";
            txtZip.Text = "";
            txtState.Text = "";
            txtCompany.Text = "";
            txtSuite.Text = "";
            txtUrbanization.Text = "";
            txtCountry.Text = "";
            txtLastName.Text = "";
        }

        // Function to Clear Output Fields
        private void ClearResults()
        {
            cAddress1.Clear();
            cAddress2.Clear();
            cCompany.Clear();
            cCity.Clear();
            cState.Clear();
            cZip.Clear();
            cPlus4.Clear();
            cCountry.Clear();
            cRange.Clear();
            cStreetName.Clear();
            cSuffix.Clear();
            cPreDirection.Clear();
            cPostDirection.Clear();
            cSuiteName.Clear();
            cSuiteNumber.Clear();
            cPMBName.Clear();
            cPMBNumber.Clear();
            cUCode.Clear();
            cUName.Clear();
            cDPC.Clear();
            cDPCD.Clear();
            cCarrierRoute.Clear();
            cResultCode.Clear();
            cResultDescription.Clear();
            cInitErrCde.Clear();
            cInitErrDesc.Clear();
            cAddKey.Clear();
            cCongressDist.Clear();
        }

        // Functions to Populate The Output Fields
        private void PopulateFields()
        {
            String errorCodeString = ResAddressCheck.Results;
            String[] errorCodeList = null;

            // Clear Results Before Anything Else
            ClearResults();

            if (errorCodeString != " ")
            {

                // Block to Handle Different Error Codes in Initialization Results

                errorCodeList = errorCodeString.Split(',');

                foreach (String errorCode in errorCodeList)
                {
                    cInitErrCde.Text += errorCode + "; ";

                    if (errorCode == "SE01")
                        cInitErrDesc.Text += errorCode + ": Web Service Internal Error;  ";
                    else if (errorCode == "GE01")
                        cInitErrDesc.Text += errorCode + ": Empty XML Request Structure;  ";
                    else if (errorCode == "GE02")
                        cInitErrDesc.Text += errorCode + ": Empty XML Request Record Structure;  ";
                    else if (errorCode == "GE03")
                        cInitErrDesc.Text += errorCode + ": Counted records send more than number of records allowed per request;  ";
                    else if (errorCode == "GE04")
                    {
                        cInitErrDesc.Text += errorCode + ": CustomerID empty;  ";
                        MessageBox.Show("Please enter your Customer ID", "Invalid Customer ID");
                    }
                    else if (errorCode == "GE05")
                    {
                        cInitErrDesc.Text += errorCode + ": CustomerID not valid;  ";
                        MessageBox.Show("The Customer ID your entered is invalid. To retrieve a valid " +
                                  "Customer ID, please contact a Melissa Data Sales Representative " +
                                  "at 800-MELISSA ext. 3 (800-800-6245 ext. 3). ", "Invalid Customer ID");
                    }
                    else if (errorCode == "GE06")
                    {
                        cInitErrDesc.Text += errorCode + ": CustomerID disabled;  ";
                        MessageBox.Show("The Customer ID your entered has been disabled. " +
                                  "Please contact a Melissa Data Sales Representative " +
                                  "at 800-MELISSA ext. 3 (800-800-6245 ext. 3). ", "Disabled Customer ID");
                    }
                    else if (errorCode == "GE07")
                        cInitErrDesc.Text += errorCode + ": XML Request invalid;  ";
                }
                // Did not Initialize. Disable Buttons
                isInitialized = false;
                return;
            }
            else
            {
                cInitErrDesc.Text = "No Error";


                // Populate the Rest of the Output Fields
                cAddress1.Text = ResAddressCheck.Record[currentRecord].Address.Address1;
                cAddress2.Text = ResAddressCheck.Record[currentRecord].Address.Address2;
                cCompany.Text = ResAddressCheck.Record[currentRecord].Address.Company;
                cCity.Text = ResAddressCheck.Record[currentRecord].Address.City.Name;
                cState.Text = ResAddressCheck.Record[currentRecord].Address.State.Abbreviation;
                cZip.Text = ResAddressCheck.Record[currentRecord].Address.Zip;
                cPlus4.Text = ResAddressCheck.Record[currentRecord].Address.Plus4;
                cCountry.Text = ResAddressCheck.Record[currentRecord].Address.Country.Name;
                cRange.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.AddressRange;
                cStreetName.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.StreetName;
                cSuffix.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.Suffix;
                cPreDirection.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.Direction.Pre;
                cPostDirection.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.Direction.Post;
                cSuiteName.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.Suite.Name;
                cSuiteNumber.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.Suite.Range;
                cPMBName.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.PrivateMailbox.Name;
                cPMBNumber.Text = ResAddressCheck.Record[currentRecord].Address.Parsed.PrivateMailbox.Range;
                cUName.Text = ResAddressCheck.Record[currentRecord].Address.Urbanization.Name;
                cDPC.Text = ResAddressCheck.Record[currentRecord].Address.DeliveryPointCode;
                cDPCD.Text = ResAddressCheck.Record[currentRecord].Address.DeliveryPointCheckDigit;
                cCarrierRoute.Text = ResAddressCheck.Record[currentRecord].Address.CarrierRoute;
                cAddKey.Text = ResAddressCheck.Record[currentRecord].Address.AddressKey;
                cCongressDist.Text = ResAddressCheck.Record[currentRecord].Address.CongressionalDistrict;

                // Block to Handle Different Error Codes and Status Codes in each Record
                errorCodeString = ResAddressCheck.Record[currentRecord].Results;
                errorCodeList = null;

                if (errorCodeString != " ")
                {
                    errorCodeList = errorCodeString.Split(',');

                    foreach (String errorCode in errorCodeList)
                    {
                        cResultCode.Text += errorCode + "; ";

                        if (errorCode == "AE01")
                            cResultDescription.Text += errorCode + ": Zip Code Error;  ";
                        else if (errorCode == "AE02")
                            cResultDescription.Text += errorCode + ": Unknown Street;  ";
                        else if (errorCode == "AE03")
                            cResultDescription.Text += errorCode + ": Component Error;  ";
                        else if (errorCode == "AE04")
                            cResultDescription.Text += errorCode + ": Non-Deliverable Address;  ";
                        else if (errorCode == "AE05")
                            cResultDescription.Text += errorCode + ": Address Matched to Multiple Records;  ";
                        else if (errorCode == "AE06")
                            cResultDescription.Text += errorCode + ": Address Matched to Early Warning System;  ";
                        else if (errorCode == "AE07")
                            cResultDescription.Text += errorCode + ": Empty Address Input;  ";
                        else if (errorCode == "AE08")
                            cResultDescription.Text += errorCode + ": Suite Range Error;  ";
                        else if (errorCode == "AE09")
                            cResultDescription.Text += errorCode + ": Suite Range Missing;  ";
                        else if (errorCode == "AE10")
                            cResultDescription.Text += errorCode + ": Primary Range Error;  ";
                        else if (errorCode == "AE11")
                            cResultDescription.Text += errorCode + ": Primary Range Missing;  ";
                        else if (errorCode == "AE12")
                            cResultDescription.Text += errorCode + ": Box Number Error from PO Box or RR; ; ";
                        else if (errorCode == "AE13")
                            cResultDescription.Text += errorCode + ": PO Box Number Missing from PO Box or RR;  ";
                        else if (errorCode == "AE14")
                            cResultDescription.Text += errorCode + ": Input Address Matched to CMRA but secondary number not present;  ";
                        else if (errorCode == "AE17")
                            cResultDescription.Text += errorCode + ": A suite number was entered but no suite information found for primary address; ";
                        else if (errorCode == "AS01")
                            cResultDescription.Text += errorCode + ": Address matched to postal database;  ";
                        else if (errorCode == "AS02")
                            cResultDescription.Text += errorCode + ": Address matched to non-postal database;  ";
                        else if (errorCode == "AS09")
                            cResultDescription.Text += errorCode + ": Foreign Postal Code Detected;  ";
                        else if (errorCode == "AS10")
                            cResultDescription.Text += errorCode + ": Address matched to CMRA;  ";
                        else if (errorCode == "AS11")
                            cResultDescription.Text += errorCode + ": Address Vacant;  ";
                        else if (errorCode == "AS12")
                            cResultDescription.Text += errorCode + ": Address deliverable by non-USPS;  ";
                        else if (errorCode == "AS13")
                            cResultDescription.Text += errorCode + ": Address Updated By LACS;  ";
                        else if (errorCode == "AS14")
                            cResultDescription.Text += errorCode + ": Address Updated By Suite Link;  ";
                        else if (errorCode == "AS15")
                            cResultDescription.Text += errorCode + ": Address Updated By AddressPlus;  ";
                        else if (errorCode == "AS16")
                            cResultDescription.Text += errorCode + ": Address is vacan; ";
                        else if (errorCode == "AS17")
                            cResultDescription.Text += errorCode + ": Alternate deliver; ";
                        else if (errorCode == "AS18")
                            cResultDescription.Text += errorCode + ": Artificially created adresses detected,DPV processing terminated at this point; ";
                        else if (errorCode == "AS20")
                            cResultDescription.Text += errorCode + ": Address Deliverable by USPS only; ";
                        else if (errorCode == "AS23")
                            cResultDescription.Text += errorCode + ": Extraneous information found; ";
                        else if (errorCode == "AC01")
                            cResultDescription.Text += errorCode + ": ZIP Code Change; ";
                        else if (errorCode == "AC02")
                            cResultDescription.Text += errorCode + ": State Chang; ";
                        else if (errorCode == "AC03")
                            cResultDescription.Text += errorCode + ": City Change; ";
                        else if (errorCode == "AC04")
                            cResultDescription.Text += errorCode + ":  Base/Alternate Change; ";
                        else if (errorCode == "AC05")
                            cResultDescription.Text += errorCode + ":  Alias Name Change; ";
                        else if (errorCode == "AC06")
                            cResultDescription.Text += errorCode + ":  Address1/Address2 Swap; ";
                        else if (errorCode == "AC07")
                            cResultDescription.Text += errorCode + ":  Address1/Company Swap; ";
                        else if (errorCode == "AC08")
                            cResultDescription.Text += errorCode + ":  Plus4 Change; ";
                        else if (errorCode == "AC09")
                            cResultDescription.Text += errorCode + ":  Urbanization Change; ";
                        else if (errorCode == "AC010")
                            cResultDescription.Text += errorCode + ":  Street Name Change; ";
                        else if (errorCode == "AC11")
                            cResultDescription.Text += errorCode + ":  Street Suffix Change; ";
                        else if (errorCode == "AC12")
                            cResultDescription.Text += errorCode + ":  Street Directional Change; ";
                        else if (errorCode == "AC13")
                            cResultDescription.Text += errorCode + ":  Suite Name Change; ";
                    }

                    if (errorCodeString == "AS01,AS12")
                    {
                        cResultDescription.Clear();
                        cResultDescription.Text += "Input Address Matched to DPV;  ";
                    }
                }
            }
            // End of Error Handling
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRecord != 0)
            {
                // Decrement Then Repopulate
                currentRecord = currentRecord - 1;
            }
            else
            {
                currentRecord = TotalRecords - 1;
            }

            PopulateFields();

            txtRecNo.Text = Convert.ToString(currentRecord + 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRecord < TotalRecords - 1)
            {
                // Increment Then Repopulate
                currentRecord = currentRecord + 1;
            }
            else
            {
                currentRecord = 0;
            }

            PopulateFields();

            txtRecNo.Text = Convert.ToString(currentRecord + 1);
        }

        // Function to Handle Changing the Maximum number of records to put in.
        private void btnChangeMax_Click(object sender, EventArgs e)
        {
            int maxRecs;

            Boolean isValidInt = Int32.TryParse(txtMaxRecords.Text, out maxRecs);

            if (isValidInt)
            {
                if ((maxRecs <= 100) && (maxRecs > 0))
                {
                    MaxArraySize = maxRecs;
                    txtMaxArraySize.Text = maxRecs.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Range", "Range Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input. Please select a different value", "Set Max Error");
            }
        }

    }
}
