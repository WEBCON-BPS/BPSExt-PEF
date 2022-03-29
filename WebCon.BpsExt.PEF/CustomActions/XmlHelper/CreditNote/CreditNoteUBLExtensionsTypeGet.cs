using System;
using System.Xml;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNoteUBLExtensions
{

public class CreditNoteUBLExtensionsTypeGet
{
        public void GetField(OriginalInvoiceData invoicetype, IXmlMapping xmlMapping)
        {
            var xmlNode = xmlMapping.GetXMLNode();

            switch (xmlNode)
            {
                case "UBLExtensions":
                    if (invoicetype.UBLExtensions == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingUBLExtensions)
                    {
                        foreach (var row in invoicetype.UBLExtensions)
                        {
                            collMappingUBLExtensions.SetNewRowContext();

                            foreach (var colMapp in collMappingUBLExtensions.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.UBLExtensions[0], xmlMapping);
                    }
                    break;
                case "UBLVersionID":
                    if (invoicetype.UBLVersionID == null) return;
                    GetField(invoicetype.UBLVersionID, xmlMapping);
                    break;
                case "CustomizationID":
                    if (invoicetype.CustomizationID == null) return;
                    GetField(invoicetype.CustomizationID, xmlMapping);
                    break;
                case "ProfileID":
                    if (invoicetype.ProfileID == null) return;
                    GetField(invoicetype.ProfileID, xmlMapping);
                    break;
                case "ProfileExecutionID":
                    if (invoicetype.ProfileExecutionID == null) return;
                    GetField(invoicetype.ProfileExecutionID, xmlMapping);
                    break;
                case "ID":
                    if (invoicetype.ID == null) return;
                    GetField(invoicetype.ID, xmlMapping);
                    break;
                case "CopyIndicator":
                    if (invoicetype.CopyIndicator == null) return;
                    GetField(invoicetype.CopyIndicator, xmlMapping);
                    break;
                case "UUID":
                    if (invoicetype.UUID == null) return;
                    GetField(invoicetype.UUID, xmlMapping);
                    break;
                case "IssueDate":
                    if (invoicetype.IssueDate == null) return;
                    GetField(invoicetype.IssueDate, xmlMapping);
                    break;
                case "IssueTime":
                    if (invoicetype.IssueTime == null) return;
                    GetField(invoicetype.IssueTime, xmlMapping);
                    break;
                case "DueDate":
                    if (invoicetype.DueDate == null) return;
                    GetField(invoicetype.DueDate, xmlMapping);
                    break;
                case "InvoiceTypeCode":
                    if (invoicetype.InvoiceTypeCode == null) return;
                    GetField(invoicetype.InvoiceTypeCode, xmlMapping);
                    break;
                case "Note":
                    if (invoicetype.Note == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingNote)
                    {
                        foreach (var row in invoicetype.Note)
                        {
                            collMappingNote.SetNewRowContext();

                            foreach (var colMapp in collMappingNote.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Note[0], xmlMapping);
                    }
                    break;
                case "TaxPointDate":
                    if (invoicetype.TaxPointDate == null) return;
                    GetField(invoicetype.TaxPointDate, xmlMapping);
                    break;
                case "DocumentCurrencyCode":
                    if (invoicetype.DocumentCurrencyCode == null) return;
                    GetField(invoicetype.DocumentCurrencyCode, xmlMapping);
                    break;
                case "TaxCurrencyCode":
                    if (invoicetype.TaxCurrencyCode == null) return;
                    GetField(invoicetype.TaxCurrencyCode, xmlMapping);
                    break;
                case "PricingCurrencyCode":
                    if (invoicetype.PricingCurrencyCode == null) return;
                    GetField(invoicetype.PricingCurrencyCode, xmlMapping);
                    break;
                case "PaymentCurrencyCode":
                    if (invoicetype.PaymentCurrencyCode == null) return;
                    GetField(invoicetype.PaymentCurrencyCode, xmlMapping);
                    break;
                case "PaymentAlternativeCurrencyCode":
                    if (invoicetype.PaymentAlternativeCurrencyCode == null) return;
                    GetField(invoicetype.PaymentAlternativeCurrencyCode, xmlMapping);
                    break;
                case "AccountingCostCode":
                    if (invoicetype.AccountingCostCode == null) return;
                    GetField(invoicetype.AccountingCostCode, xmlMapping);
                    break;
                case "AccountingCost":
                    if (invoicetype.AccountingCost == null) return;
                    GetField(invoicetype.AccountingCost, xmlMapping);
                    break;
                case "LineCountNumeric":
                    if (invoicetype.LineCountNumeric == null) return;
                    GetField(invoicetype.LineCountNumeric, xmlMapping);
                    break;
                case "BuyerReference":
                    if (invoicetype.BuyerReference == null) return;
                    GetField(invoicetype.BuyerReference, xmlMapping);
                    break;
                case "InvoicePeriod":
                    if (invoicetype.InvoicePeriod == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod)
                    {
                        foreach (var row in invoicetype.InvoicePeriod)
                        {
                            collMappingInvoicePeriod.SetNewRowContext();

                            foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.InvoicePeriod[0], xmlMapping);
                    }
                    break;
                case "OrderReference":
                    if (invoicetype.OrderReference == null) return;
                    GetField(invoicetype.OrderReference, xmlMapping);
                    break;
                case "BillingReference":
                    if (invoicetype.BillingReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingBillingReference)
                    {
                        foreach (var row in invoicetype.BillingReference)
                        {
                            collMappingBillingReference.SetNewRowContext();

                            foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.BillingReference[0], xmlMapping);
                    }
                    break;
                case "DespatchDocumentReference":
                    if (invoicetype.DespatchDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingDespatchDocumentReference)
                    {
                        foreach (var row in invoicetype.DespatchDocumentReference)
                        {
                            collMappingDespatchDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingDespatchDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.DespatchDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ReceiptDocumentReference":
                    if (invoicetype.ReceiptDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingReceiptDocumentReference)
                    {
                        foreach (var row in invoicetype.ReceiptDocumentReference)
                        {
                            collMappingReceiptDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingReceiptDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ReceiptDocumentReference[0], xmlMapping);
                    }
                    break;
                case "StatementDocumentReference":
                    if (invoicetype.StatementDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingStatementDocumentReference)
                    {
                        foreach (var row in invoicetype.StatementDocumentReference)
                        {
                            collMappingStatementDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingStatementDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.StatementDocumentReference[0], xmlMapping);
                    }
                    break;
                case "OriginatorDocumentReference":
                    if (invoicetype.OriginatorDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingOriginatorDocumentReference)
                    {
                        foreach (var row in invoicetype.OriginatorDocumentReference)
                        {
                            collMappingOriginatorDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingOriginatorDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.OriginatorDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ContractDocumentReference":
                    if (invoicetype.ContractDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference)
                    {
                        foreach (var row in invoicetype.ContractDocumentReference)
                        {
                            collMappingContractDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ContractDocumentReference[0], xmlMapping);
                    }
                    break;
                case "AdditionalDocumentReference":
                    if (invoicetype.AdditionalDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingAdditionalDocumentReference)
                    {
                        foreach (var row in invoicetype.AdditionalDocumentReference)
                        {
                            collMappingAdditionalDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingAdditionalDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.AdditionalDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ProjectReference":
                    if (invoicetype.ProjectReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingProjectReference)
                    {
                        foreach (var row in invoicetype.ProjectReference)
                        {
                            collMappingProjectReference.SetNewRowContext();

                            foreach (var colMapp in collMappingProjectReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ProjectReference[0], xmlMapping);
                    }
                    break;
                case "Signature":
                    if (invoicetype.Signature == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingSignature)
                    {
                        foreach (var row in invoicetype.Signature)
                        {
                            collMappingSignature.SetNewRowContext();

                            foreach (var colMapp in collMappingSignature.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Signature[0], xmlMapping);
                    }
                    break;
                case "AccountingSupplierParty":
                    if (invoicetype.AccountingSupplierParty == null) return;
                    GetField(invoicetype.AccountingSupplierParty, xmlMapping);
                    break;
                case "AccountingCustomerParty":
                    if (invoicetype.AccountingCustomerParty == null) return;
                    GetField(invoicetype.AccountingCustomerParty, xmlMapping);
                    break;
                case "PayeeParty":
                    if (invoicetype.PayeeParty == null) return;
                    GetField(invoicetype.PayeeParty, xmlMapping);
                    break;
                case "BuyerCustomerParty":
                    if (invoicetype.BuyerCustomerParty == null) return;
                    GetField(invoicetype.BuyerCustomerParty, xmlMapping);
                    break;
                case "SellerSupplierParty":
                    if (invoicetype.SellerSupplierParty == null) return;
                    GetField(invoicetype.SellerSupplierParty, xmlMapping);
                    break;
                case "TaxRepresentativeParty":
                    if (invoicetype.TaxRepresentativeParty == null) return;
                    GetField(invoicetype.TaxRepresentativeParty, xmlMapping);
                    break;
                case "Delivery":
                    if (invoicetype.Delivery == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingDelivery)
                    {
                        foreach (var row in invoicetype.Delivery)
                        {
                            collMappingDelivery.SetNewRowContext();

                            foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Delivery[0], xmlMapping);
                    }
                    break;
                case "DeliveryTerms":
                    if (invoicetype.DeliveryTerms == null) return;
                    GetField(invoicetype.DeliveryTerms, xmlMapping);
                    break;
                case "PaymentMeans":
                    if (invoicetype.PaymentMeans == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans)
                    {
                        foreach (var row in invoicetype.PaymentMeans)
                        {
                            collMappingPaymentMeans.SetNewRowContext();

                            foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PaymentMeans[0], xmlMapping);
                    }
                    break;
                case "PaymentTerms":
                    if (invoicetype.PaymentTerms == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms)
                    {
                        foreach (var row in invoicetype.PaymentTerms)
                        {
                            collMappingPaymentTerms.SetNewRowContext();

                            foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PaymentTerms[0], xmlMapping);
                    }
                    break;
                case "PrepaidPayment":
                    if (invoicetype.PrepaidPayment == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPrepaidPayment)
                    {
                        foreach (var row in invoicetype.PrepaidPayment)
                        {
                            collMappingPrepaidPayment.SetNewRowContext();

                            foreach (var colMapp in collMappingPrepaidPayment.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PrepaidPayment[0], xmlMapping);
                    }
                    break;
                case "AllowanceCharge":
                    if (invoicetype.AllowanceCharge == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                    {
                        foreach (var row in invoicetype.AllowanceCharge)
                        {
                            collMappingAllowanceCharge.SetNewRowContext();

                            foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.AllowanceCharge[0], xmlMapping);
                    }
                    break;
                case "TaxExchangeRate":
                    if (invoicetype.TaxExchangeRate == null) return;
                    GetField(invoicetype.TaxExchangeRate, xmlMapping);
                    break;
                case "PricingExchangeRate":
                    if (invoicetype.PricingExchangeRate == null) return;
                    GetField(invoicetype.PricingExchangeRate, xmlMapping);
                    break;
                case "PaymentExchangeRate":
                    if (invoicetype.PaymentExchangeRate == null) return;
                    GetField(invoicetype.PaymentExchangeRate, xmlMapping);
                    break;
                case "PaymentAlternativeExchangeRate":
                    if (invoicetype.PaymentAlternativeExchangeRate == null) return;
                    GetField(invoicetype.PaymentAlternativeExchangeRate, xmlMapping);
                    break;
                case "TaxTotal":
                    if (invoicetype.TaxTotal == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal)
                    {
                        foreach (var row in invoicetype.TaxTotal)
                        {
                            collMappingTaxTotal.SetNewRowContext();

                            foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.TaxTotal[0], xmlMapping);
                    }
                    break;
                case "WithholdingTaxTotal":
                    if (invoicetype.WithholdingTaxTotal == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal)
                    {
                        foreach (var row in invoicetype.WithholdingTaxTotal)
                        {
                            collMappingWithholdingTaxTotal.SetNewRowContext();

                            foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.WithholdingTaxTotal[0], xmlMapping);
                    }
                    break;
                case "LegalMonetaryTotal":
                    if (invoicetype.LegalMonetaryTotal == null) return;
                    GetField(invoicetype.LegalMonetaryTotal, xmlMapping);
                    break;
                case "InvoiceLine":
                    if (invoicetype.InvoiceLine == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine)
                    {
                        foreach (var row in invoicetype.InvoiceLine)
                        {
                            collMappingInvoiceLine.SetNewRowContext();

                            foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.InvoiceLine[0], xmlMapping);
                    }
                    break;

            }
        }

        public void GetField(InvoiceCorrection invoicetype, IXmlMapping xmlMapping)
        {
            var xmlNode = xmlMapping.GetXMLNode();

            switch (xmlNode)
            {
                case "UBLExtensions":
                    if (invoicetype.UBLExtensions == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingUBLExtensions)
                    {
                        foreach (var row in invoicetype.UBLExtensions)
                        {
                            collMappingUBLExtensions.SetNewRowContext();

                            foreach (var colMapp in collMappingUBLExtensions.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.UBLExtensions[0], xmlMapping);
                    }
                    break;
                case "UBLVersionID":
                    if (invoicetype.UBLVersionID == null) return;
                    GetField(invoicetype.UBLVersionID, xmlMapping);
                    break;
                case "CustomizationID":
                    if (invoicetype.CustomizationID == null) return;
                    GetField(invoicetype.CustomizationID, xmlMapping);
                    break;
                case "ProfileID":
                    if (invoicetype.ProfileID == null) return;
                    GetField(invoicetype.ProfileID, xmlMapping);
                    break;
                case "ProfileExecutionID":
                    if (invoicetype.ProfileExecutionID == null) return;
                    GetField(invoicetype.ProfileExecutionID, xmlMapping);
                    break;
                case "ID":
                    if (invoicetype.ID == null) return;
                    GetField(invoicetype.ID, xmlMapping);
                    break;
                case "CopyIndicator":
                    if (invoicetype.CopyIndicator == null) return;
                    GetField(invoicetype.CopyIndicator, xmlMapping);
                    break;
                case "UUID":
                    if (invoicetype.UUID == null) return;
                    GetField(invoicetype.UUID, xmlMapping);
                    break;
                case "IssueDate":
                    if (invoicetype.IssueDate == null) return;
                    GetField(invoicetype.IssueDate, xmlMapping);
                    break;
                case "IssueTime":
                    if (invoicetype.IssueTime == null) return;
                    GetField(invoicetype.IssueTime, xmlMapping);
                    break;
                case "DueDate":
                    if (invoicetype.DueDate == null) return;
                    GetField(invoicetype.DueDate, xmlMapping);
                    break;
                case "InvoiceTypeCode":
                    if (invoicetype.InvoiceTypeCode == null) return;
                    GetField(invoicetype.InvoiceTypeCode, xmlMapping);
                    break;
                case "Note":
                    if (invoicetype.Note == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingNote)
                    {
                        foreach (var row in invoicetype.Note)
                        {
                            collMappingNote.SetNewRowContext();

                            foreach (var colMapp in collMappingNote.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Note[0], xmlMapping);
                    }
                    break;
                case "TaxPointDate":
                    if (invoicetype.TaxPointDate == null) return;
                    GetField(invoicetype.TaxPointDate, xmlMapping);
                    break;
                case "DocumentCurrencyCode":
                    if (invoicetype.DocumentCurrencyCode == null) return;
                    GetField(invoicetype.DocumentCurrencyCode, xmlMapping);
                    break;
                case "TaxCurrencyCode":
                    if (invoicetype.TaxCurrencyCode == null) return;
                    GetField(invoicetype.TaxCurrencyCode, xmlMapping);
                    break;
                case "PricingCurrencyCode":
                    if (invoicetype.PricingCurrencyCode == null) return;
                    GetField(invoicetype.PricingCurrencyCode, xmlMapping);
                    break;
                case "PaymentCurrencyCode":
                    if (invoicetype.PaymentCurrencyCode == null) return;
                    GetField(invoicetype.PaymentCurrencyCode, xmlMapping);
                    break;
                case "PaymentAlternativeCurrencyCode":
                    if (invoicetype.PaymentAlternativeCurrencyCode == null) return;
                    GetField(invoicetype.PaymentAlternativeCurrencyCode, xmlMapping);
                    break;
                case "AccountingCostCode":
                    if (invoicetype.AccountingCostCode == null) return;
                    GetField(invoicetype.AccountingCostCode, xmlMapping);
                    break;
                case "AccountingCost":
                    if (invoicetype.AccountingCost == null) return;
                    GetField(invoicetype.AccountingCost, xmlMapping);
                    break;
                case "LineCountNumeric":
                    if (invoicetype.LineCountNumeric == null) return;
                    GetField(invoicetype.LineCountNumeric, xmlMapping);
                    break;
                case "BuyerReference":
                    if (invoicetype.BuyerReference == null) return;
                    GetField(invoicetype.BuyerReference, xmlMapping);
                    break;
                case "InvoicePeriod":
                    if (invoicetype.InvoicePeriod == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod)
                    {
                        foreach (var row in invoicetype.InvoicePeriod)
                        {
                            collMappingInvoicePeriod.SetNewRowContext();

                            foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.InvoicePeriod[0], xmlMapping);
                    }
                    break;
                case "OrderReference":
                    if (invoicetype.OrderReference == null) return;
                    GetField(invoicetype.OrderReference, xmlMapping);
                    break;
                case "BillingReference":
                    if (invoicetype.BillingReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingBillingReference)
                    {
                        foreach (var row in invoicetype.BillingReference)
                        {
                            collMappingBillingReference.SetNewRowContext();

                            foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.BillingReference[0], xmlMapping);
                    }
                    break;
                case "DespatchDocumentReference":
                    if (invoicetype.DespatchDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingDespatchDocumentReference)
                    {
                        foreach (var row in invoicetype.DespatchDocumentReference)
                        {
                            collMappingDespatchDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingDespatchDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.DespatchDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ReceiptDocumentReference":
                    if (invoicetype.ReceiptDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingReceiptDocumentReference)
                    {
                        foreach (var row in invoicetype.ReceiptDocumentReference)
                        {
                            collMappingReceiptDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingReceiptDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ReceiptDocumentReference[0], xmlMapping);
                    }
                    break;
                case "StatementDocumentReference":
                    if (invoicetype.StatementDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingStatementDocumentReference)
                    {
                        foreach (var row in invoicetype.StatementDocumentReference)
                        {
                            collMappingStatementDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingStatementDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.StatementDocumentReference[0], xmlMapping);
                    }
                    break;
                case "OriginatorDocumentReference":
                    if (invoicetype.OriginatorDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingOriginatorDocumentReference)
                    {
                        foreach (var row in invoicetype.OriginatorDocumentReference)
                        {
                            collMappingOriginatorDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingOriginatorDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.OriginatorDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ContractDocumentReference":
                    if (invoicetype.ContractDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference)
                    {
                        foreach (var row in invoicetype.ContractDocumentReference)
                        {
                            collMappingContractDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ContractDocumentReference[0], xmlMapping);
                    }
                    break;
                case "AdditionalDocumentReference":
                    if (invoicetype.AdditionalDocumentReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingAdditionalDocumentReference)
                    {
                        foreach (var row in invoicetype.AdditionalDocumentReference)
                        {
                            collMappingAdditionalDocumentReference.SetNewRowContext();

                            foreach (var colMapp in collMappingAdditionalDocumentReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.AdditionalDocumentReference[0], xmlMapping);
                    }
                    break;
                case "ProjectReference":
                    if (invoicetype.ProjectReference == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingProjectReference)
                    {
                        foreach (var row in invoicetype.ProjectReference)
                        {
                            collMappingProjectReference.SetNewRowContext();

                            foreach (var colMapp in collMappingProjectReference.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.ProjectReference[0], xmlMapping);
                    }
                    break;
                case "Signature":
                    if (invoicetype.Signature == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingSignature)
                    {
                        foreach (var row in invoicetype.Signature)
                        {
                            collMappingSignature.SetNewRowContext();

                            foreach (var colMapp in collMappingSignature.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Signature[0], xmlMapping);
                    }
                    break;
                case "AccountingSupplierParty":
                    if (invoicetype.AccountingSupplierParty == null) return;
                    GetField(invoicetype.AccountingSupplierParty, xmlMapping);
                    break;
                case "AccountingCustomerParty":
                    if (invoicetype.AccountingCustomerParty == null) return;
                    GetField(invoicetype.AccountingCustomerParty, xmlMapping);
                    break;
                case "PayeeParty":
                    if (invoicetype.PayeeParty == null) return;
                    GetField(invoicetype.PayeeParty, xmlMapping);
                    break;
                case "BuyerCustomerParty":
                    if (invoicetype.BuyerCustomerParty == null) return;
                    GetField(invoicetype.BuyerCustomerParty, xmlMapping);
                    break;
                case "SellerSupplierParty":
                    if (invoicetype.SellerSupplierParty == null) return;
                    GetField(invoicetype.SellerSupplierParty, xmlMapping);
                    break;
                case "TaxRepresentativeParty":
                    if (invoicetype.TaxRepresentativeParty == null) return;
                    GetField(invoicetype.TaxRepresentativeParty, xmlMapping);
                    break;
                case "Delivery":
                    if (invoicetype.Delivery == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingDelivery)
                    {
                        foreach (var row in invoicetype.Delivery)
                        {
                            collMappingDelivery.SetNewRowContext();

                            foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.Delivery[0], xmlMapping);
                    }
                    break;
                case "DeliveryTerms":
                    if (invoicetype.DeliveryTerms == null) return;
                    GetField(invoicetype.DeliveryTerms, xmlMapping);
                    break;
                case "PaymentMeans":
                    if (invoicetype.PaymentMeans == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans)
                    {
                        foreach (var row in invoicetype.PaymentMeans)
                        {
                            collMappingPaymentMeans.SetNewRowContext();

                            foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PaymentMeans[0], xmlMapping);
                    }
                    break;
                case "PaymentTerms":
                    if (invoicetype.PaymentTerms == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms)
                    {
                        foreach (var row in invoicetype.PaymentTerms)
                        {
                            collMappingPaymentTerms.SetNewRowContext();

                            foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PaymentTerms[0], xmlMapping);
                    }
                    break;
                case "PrepaidPayment":
                    if (invoicetype.PrepaidPayment == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingPrepaidPayment)
                    {
                        foreach (var row in invoicetype.PrepaidPayment)
                        {
                            collMappingPrepaidPayment.SetNewRowContext();

                            foreach (var colMapp in collMappingPrepaidPayment.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.PrepaidPayment[0], xmlMapping);
                    }
                    break;
                case "AllowanceCharge":
                    if (invoicetype.AllowanceCharge == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                    {
                        foreach (var row in invoicetype.AllowanceCharge)
                        {
                            collMappingAllowanceCharge.SetNewRowContext();

                            foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.AllowanceCharge[0], xmlMapping);
                    }
                    break;
                case "TaxExchangeRate":
                    if (invoicetype.TaxExchangeRate == null) return;
                    GetField(invoicetype.TaxExchangeRate, xmlMapping);
                    break;
                case "PricingExchangeRate":
                    if (invoicetype.PricingExchangeRate == null) return;
                    GetField(invoicetype.PricingExchangeRate, xmlMapping);
                    break;
                case "PaymentExchangeRate":
                    if (invoicetype.PaymentExchangeRate == null) return;
                    GetField(invoicetype.PaymentExchangeRate, xmlMapping);
                    break;
                case "PaymentAlternativeExchangeRate":
                    if (invoicetype.PaymentAlternativeExchangeRate == null) return;
                    GetField(invoicetype.PaymentAlternativeExchangeRate, xmlMapping);
                    break;
                case "TaxTotal":
                    if (invoicetype.TaxTotal == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal)
                    {
                        foreach (var row in invoicetype.TaxTotal)
                        {
                            collMappingTaxTotal.SetNewRowContext();

                            foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.TaxTotal[0], xmlMapping);
                    }
                    break;
                case "WithholdingTaxTotal":
                    if (invoicetype.WithholdingTaxTotal == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal)
                    {
                        foreach (var row in invoicetype.WithholdingTaxTotal)
                        {
                            collMappingWithholdingTaxTotal.SetNewRowContext();

                            foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.WithholdingTaxTotal[0], xmlMapping);
                    }
                    break;
                case "LegalMonetaryTotal":
                    if (invoicetype.LegalMonetaryTotal == null) return;
                    GetField(invoicetype.LegalMonetaryTotal, xmlMapping);
                    break;
                case "InvoiceLine":
                    if (invoicetype.InvoiceLine == null) return;
                    if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine)
                    {
                        foreach (var row in invoicetype.InvoiceLine)
                        {
                            collMappingInvoiceLine.SetNewRowContext();

                            foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                            {
                                GetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                    else
                    {
                        GetField(invoicetype.InvoiceLine[0], xmlMapping);
                    }
                    break;

            }
        }


        public void GetField(InvoiceType invoicetype, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "UBLExtensions":
                if (invoicetype.UBLExtensions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingUBLExtensions)
                {
                    foreach (var row in invoicetype.UBLExtensions)
                    {
                        collMappingUBLExtensions.SetNewRowContext();

                        foreach (var colMapp in collMappingUBLExtensions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.UBLExtensions[0], xmlMapping);
                }
                break;
            case "UBLVersionID":
                if (invoicetype.UBLVersionID == null) return;
                GetField(invoicetype.UBLVersionID, xmlMapping);
                break;
            case "CustomizationID":
                if (invoicetype.CustomizationID == null) return;
                GetField(invoicetype.CustomizationID, xmlMapping);
                break;
            case "ProfileID":
                if (invoicetype.ProfileID == null) return;
                GetField(invoicetype.ProfileID, xmlMapping);
                break;
            case "ProfileExecutionID":
                if (invoicetype.ProfileExecutionID == null) return;
                GetField(invoicetype.ProfileExecutionID, xmlMapping);
                break;
            case "ID":
                if (invoicetype.ID == null) return;
                GetField(invoicetype.ID, xmlMapping);
                break;
            case "CopyIndicator":
                if (invoicetype.CopyIndicator == null) return;
                GetField(invoicetype.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (invoicetype.UUID == null) return;
                GetField(invoicetype.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (invoicetype.IssueDate == null) return;
                GetField(invoicetype.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (invoicetype.IssueTime == null) return;
                GetField(invoicetype.IssueTime, xmlMapping);
                break;
            case "DueDate":
                if (invoicetype.DueDate == null) return;
                GetField(invoicetype.DueDate, xmlMapping);
                break;
            case "InvoiceTypeCode":
                if (invoicetype.InvoiceTypeCode == null) return;
                GetField(invoicetype.InvoiceTypeCode, xmlMapping);
                break;
            case "Note":
                if (invoicetype.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in invoicetype.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.Note[0], xmlMapping);
                }
                break;
            case "TaxPointDate":
                if (invoicetype.TaxPointDate == null) return;
                GetField(invoicetype.TaxPointDate, xmlMapping);
                break;
            case "DocumentCurrencyCode":
                if (invoicetype.DocumentCurrencyCode == null) return;
                GetField(invoicetype.DocumentCurrencyCode, xmlMapping);
                break;
            case "TaxCurrencyCode":
                if (invoicetype.TaxCurrencyCode == null) return;
                GetField(invoicetype.TaxCurrencyCode, xmlMapping);
                break;
            case "PricingCurrencyCode":
                if (invoicetype.PricingCurrencyCode == null) return;
                GetField(invoicetype.PricingCurrencyCode, xmlMapping);
                break;
            case "PaymentCurrencyCode":
                if (invoicetype.PaymentCurrencyCode == null) return;
                GetField(invoicetype.PaymentCurrencyCode, xmlMapping);
                break;
            case "PaymentAlternativeCurrencyCode":
                if (invoicetype.PaymentAlternativeCurrencyCode == null) return;
                GetField(invoicetype.PaymentAlternativeCurrencyCode, xmlMapping);
                break;
            case "AccountingCostCode":
                if (invoicetype.AccountingCostCode == null) return;
                GetField(invoicetype.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (invoicetype.AccountingCost == null) return;
                GetField(invoicetype.AccountingCost, xmlMapping);
                break;
            case "LineCountNumeric":
                if (invoicetype.LineCountNumeric == null) return;
                GetField(invoicetype.LineCountNumeric, xmlMapping);
                break;
            case "BuyerReference":
                if (invoicetype.BuyerReference == null) return;
                GetField(invoicetype.BuyerReference, xmlMapping);
                break;
            case "InvoicePeriod":
                if (invoicetype.InvoicePeriod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod)
                {
                    foreach (var row in invoicetype.InvoicePeriod)
                    {
                        collMappingInvoicePeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.InvoicePeriod[0], xmlMapping);
                }
                break;
            case "OrderReference":
                if (invoicetype.OrderReference == null) return;
                GetField(invoicetype.OrderReference, xmlMapping);
                break;
            case "BillingReference":
                if (invoicetype.BillingReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReference)
                {
                    foreach (var row in invoicetype.BillingReference)
                    {
                        collMappingBillingReference.SetNewRowContext();

                        foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.BillingReference[0], xmlMapping);
                }
                break;
            case "DespatchDocumentReference":
                if (invoicetype.DespatchDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchDocumentReference)
                {
                    foreach (var row in invoicetype.DespatchDocumentReference)
                    {
                        collMappingDespatchDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDespatchDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.DespatchDocumentReference[0], xmlMapping);
                }
                break;
            case "ReceiptDocumentReference":
                if (invoicetype.ReceiptDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingReceiptDocumentReference)
                {
                    foreach (var row in invoicetype.ReceiptDocumentReference)
                    {
                        collMappingReceiptDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingReceiptDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.ReceiptDocumentReference[0], xmlMapping);
                }
                break;
            case "StatementDocumentReference":
                if (invoicetype.StatementDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingStatementDocumentReference)
                {
                    foreach (var row in invoicetype.StatementDocumentReference)
                    {
                        collMappingStatementDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingStatementDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.StatementDocumentReference[0], xmlMapping);
                }
                break;
            case "OriginatorDocumentReference":
                if (invoicetype.OriginatorDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOriginatorDocumentReference)
                {
                    foreach (var row in invoicetype.OriginatorDocumentReference)
                    {
                        collMappingOriginatorDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingOriginatorDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.OriginatorDocumentReference[0], xmlMapping);
                }
                break;
            case "ContractDocumentReference":
                if (invoicetype.ContractDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference)
                {
                    foreach (var row in invoicetype.ContractDocumentReference)
                    {
                        collMappingContractDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.ContractDocumentReference[0], xmlMapping);
                }
                break;
            case "AdditionalDocumentReference":
                if (invoicetype.AdditionalDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalDocumentReference)
                {
                    foreach (var row in invoicetype.AdditionalDocumentReference)
                    {
                        collMappingAdditionalDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.AdditionalDocumentReference[0], xmlMapping);
                }
                break;
            case "ProjectReference":
                if (invoicetype.ProjectReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingProjectReference)
                {
                    foreach (var row in invoicetype.ProjectReference)
                    {
                        collMappingProjectReference.SetNewRowContext();

                        foreach (var colMapp in collMappingProjectReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.ProjectReference[0], xmlMapping);
                }
                break;
            case "Signature":
                if (invoicetype.Signature == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSignature)
                {
                    foreach (var row in invoicetype.Signature)
                    {
                        collMappingSignature.SetNewRowContext();

                        foreach (var colMapp in collMappingSignature.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.Signature[0], xmlMapping);
                }
                break;
            case "AccountingSupplierParty":
                if (invoicetype.AccountingSupplierParty == null) return;
                GetField(invoicetype.AccountingSupplierParty, xmlMapping);
                break;
            case "AccountingCustomerParty":
                if (invoicetype.AccountingCustomerParty == null) return;
                GetField(invoicetype.AccountingCustomerParty, xmlMapping);
                break;
            case "PayeeParty":
                if (invoicetype.PayeeParty == null) return;
                GetField(invoicetype.PayeeParty, xmlMapping);
                break;
            case "BuyerCustomerParty":
                if (invoicetype.BuyerCustomerParty == null) return;
                GetField(invoicetype.BuyerCustomerParty, xmlMapping);
                break;
            case "SellerSupplierParty":
                if (invoicetype.SellerSupplierParty == null) return;
                GetField(invoicetype.SellerSupplierParty, xmlMapping);
                break;
            case "TaxRepresentativeParty":
                if (invoicetype.TaxRepresentativeParty == null) return;
                GetField(invoicetype.TaxRepresentativeParty, xmlMapping);
                break;
            case "Delivery":
                if (invoicetype.Delivery == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDelivery)
                {
                    foreach (var row in invoicetype.Delivery)
                    {
                        collMappingDelivery.SetNewRowContext();

                        foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.Delivery[0], xmlMapping);
                }
                break;
            case "DeliveryTerms":
                if (invoicetype.DeliveryTerms == null) return;
                GetField(invoicetype.DeliveryTerms, xmlMapping);
                break;
            case "PaymentMeans":
                if (invoicetype.PaymentMeans == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans)
                {
                    foreach (var row in invoicetype.PaymentMeans)
                    {
                        collMappingPaymentMeans.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.PaymentMeans[0], xmlMapping);
                }
                break;
            case "PaymentTerms":
                if (invoicetype.PaymentTerms == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms)
                {
                    foreach (var row in invoicetype.PaymentTerms)
                    {
                        collMappingPaymentTerms.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.PaymentTerms[0], xmlMapping);
                }
                break;
            case "PrepaidPayment":
                if (invoicetype.PrepaidPayment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPrepaidPayment)
                {
                    foreach (var row in invoicetype.PrepaidPayment)
                    {
                        collMappingPrepaidPayment.SetNewRowContext();

                        foreach (var colMapp in collMappingPrepaidPayment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.PrepaidPayment[0], xmlMapping);
                }
                break;
            case "AllowanceCharge":
                if (invoicetype.AllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                {
                    foreach (var row in invoicetype.AllowanceCharge)
                    {
                        collMappingAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "TaxExchangeRate":
                if (invoicetype.TaxExchangeRate == null) return;
                GetField(invoicetype.TaxExchangeRate, xmlMapping);
                break;
            case "PricingExchangeRate":
                if (invoicetype.PricingExchangeRate == null) return;
                GetField(invoicetype.PricingExchangeRate, xmlMapping);
                break;
            case "PaymentExchangeRate":
                if (invoicetype.PaymentExchangeRate == null) return;
                GetField(invoicetype.PaymentExchangeRate, xmlMapping);
                break;
            case "PaymentAlternativeExchangeRate":
                if (invoicetype.PaymentAlternativeExchangeRate == null) return;
                GetField(invoicetype.PaymentAlternativeExchangeRate, xmlMapping);
                break;
            case "TaxTotal":
                if (invoicetype.TaxTotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal)
                {
                    foreach (var row in invoicetype.TaxTotal)
                    {
                        collMappingTaxTotal.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.TaxTotal[0], xmlMapping);
                }
                break;
            case "WithholdingTaxTotal":
                if (invoicetype.WithholdingTaxTotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal)
                {
                    foreach (var row in invoicetype.WithholdingTaxTotal)
                    {
                        collMappingWithholdingTaxTotal.SetNewRowContext();

                        foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.WithholdingTaxTotal[0], xmlMapping);
                }
                break;
            case "LegalMonetaryTotal":
                if (invoicetype.LegalMonetaryTotal == null) return;
                GetField(invoicetype.LegalMonetaryTotal, xmlMapping);
                break;
            case "InvoiceLine":
                if (invoicetype.InvoiceLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine)
                {
                    foreach (var row in invoicetype.InvoiceLine)
                    {
                        collMappingInvoiceLine.SetNewRowContext();

                        foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoicetype.InvoiceLine[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(UBLExtensionType ublextensions, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (ublextensions.ID == null) return;
                GetField(ublextensions.ID, xmlMapping);
                break;
            case "Name":
                if (ublextensions.Name == null) return;
                GetField(ublextensions.Name, xmlMapping);
                break;
            case "ExtensionAgencyID":
                if (ublextensions.ExtensionAgencyID == null) return;
                GetField(ublextensions.ExtensionAgencyID, xmlMapping);
                break;
            case "ExtensionAgencyName":
                if (ublextensions.ExtensionAgencyName == null) return;
                GetField(ublextensions.ExtensionAgencyName, xmlMapping);
                break;
            case "ExtensionVersionID":
                if (ublextensions.ExtensionVersionID == null) return;
                GetField(ublextensions.ExtensionVersionID, xmlMapping);
                break;
            case "ExtensionAgencyURI":
                if (ublextensions.ExtensionAgencyURI == null) return;
                GetField(ublextensions.ExtensionAgencyURI, xmlMapping);
                break;
            case "ExtensionURI":
                if (ublextensions.ExtensionURI == null) return;
                GetField(ublextensions.ExtensionURI, xmlMapping);
                break;
            case "ExtensionReasonCode":
                if (ublextensions.ExtensionReasonCode == null) return;
                GetField(ublextensions.ExtensionReasonCode, xmlMapping);
                break;
            case "ExtensionReason":
                if (ublextensions.ExtensionReason == null) return;
                GetField(ublextensions.ExtensionReason, xmlMapping);
                break;
            case "ExtensionContent":
                xmlMapping.Value = ublextensions.ExtensionContent;
                break;

        }
    }
    public void GetField(IdentifierType id, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetIdentifierTypeProperty(xmlNode, xmlMapping, id);
        else
            xmlMapping.Value = id.GetValue();
    }

    public void GetIdentifierTypeProperty(string xmlNode, IXmlMapping xmlMapping, IdentifierType id)
    {
        switch (xmlNode)
        {
            case "schemeID":
                xmlMapping.Value = id.schemeID;
                break;
            case "schemeName":
                xmlMapping.Value = id.schemeName;
                break;
            case "schemeAgencyID":
                xmlMapping.Value = id.schemeAgencyID;
                break;
            case "schemeAgencyName":
                xmlMapping.Value = id.schemeAgencyName;
                break;
            case "schemeVersionID":
                xmlMapping.Value = id.schemeVersionID;
                break;
            case "schemeDataURI":
                xmlMapping.Value = id.schemeDataURI;
                break;
            case "schemeURI":
                xmlMapping.Value = id.schemeURI;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(TextType name, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetTextTypeProperty(xmlNode, xmlMapping, name);
        else
            xmlMapping.Value = name.GetValue();
    }

    public void GetTextTypeProperty(string xmlNode, IXmlMapping xmlMapping, TextType name)
    {
        switch (xmlNode)
        {
            case "languageID":
                xmlMapping.Value = name.languageID;
                break;
            case "languageLocaleID":
                xmlMapping.Value = name.languageLocaleID;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(CodeType extensionreasoncode, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetCodeTypeProperty(xmlNode, xmlMapping, extensionreasoncode);
        else
            xmlMapping.Value = extensionreasoncode.GetValue();
    }

    public void GetCodeTypeProperty(string xmlNode, IXmlMapping xmlMapping, CodeType extensionreasoncode)
    {
        switch (xmlNode)
        {
            case "listID":
                xmlMapping.Value = extensionreasoncode.listID;
                break;
            case "listAgencyID":
                xmlMapping.Value = extensionreasoncode.listAgencyID;
                break;
            case "listAgencyName":
                xmlMapping.Value = extensionreasoncode.listAgencyName;
                break;
            case "listName":
                xmlMapping.Value = extensionreasoncode.listName;
                break;
            case "listVersionID":
                xmlMapping.Value = extensionreasoncode.listVersionID;
                break;
            case "name":
                xmlMapping.Value = extensionreasoncode.name;
                break;
            case "languageID":
                xmlMapping.Value = extensionreasoncode.languageID;
                break;
            case "listURI":
                xmlMapping.Value = extensionreasoncode.listURI;
                break;
            case "listSchemeURI":
                xmlMapping.Value = extensionreasoncode.listSchemeURI;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(IndicatorType copyindicator, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        xmlMapping.Value = copyindicator.GetValue();
    }
    public void GetField(DateType issuedate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        xmlMapping.Value = issuedate.GetValue();
    }
    public void GetField(TimeType issuetime, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        xmlMapping.Value = issuetime.GetValue();
    }
    public void GetField(NumericType linecountnumeric, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetNumericTypeProperty(xmlNode, xmlMapping, linecountnumeric);
        else
            xmlMapping.Value = linecountnumeric.GetValue();
    }

    public void GetNumericTypeProperty(string xmlNode, IXmlMapping xmlMapping, NumericType linecountnumeric)
    {
        switch (xmlNode)
        {
            case "format":
                xmlMapping.Value = linecountnumeric.format;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(PeriodType invoiceperiod, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "StartDate":
                if (invoiceperiod.StartDate == null) return;
                GetField(invoiceperiod.StartDate, xmlMapping);
                break;
            case "StartTime":
                if (invoiceperiod.StartTime == null) return;
                GetField(invoiceperiod.StartTime, xmlMapping);
                break;
            case "EndDate":
                if (invoiceperiod.EndDate == null) return;
                GetField(invoiceperiod.EndDate, xmlMapping);
                break;
            case "EndTime":
                if (invoiceperiod.EndTime == null) return;
                GetField(invoiceperiod.EndTime, xmlMapping);
                break;
            case "DurationMeasure":
                if (invoiceperiod.DurationMeasure == null) return;
                GetField(invoiceperiod.DurationMeasure, xmlMapping);
                break;
            case "DescriptionCode":
                if (invoiceperiod.DescriptionCode == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescriptionCode)
                {
                    foreach (var row in invoiceperiod.DescriptionCode)
                    {
                        collMappingDescriptionCode.SetNewRowContext();

                        foreach (var colMapp in collMappingDescriptionCode.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceperiod.DescriptionCode[0], xmlMapping);
                }
                break;
            case "Description":
                if (invoiceperiod.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in invoiceperiod.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceperiod.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(MeasureType durationmeasure, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetMeasureTypeProperty(xmlNode, xmlMapping, durationmeasure);
        else
            xmlMapping.Value = durationmeasure.GetValue();
    }

    public void GetMeasureTypeProperty(string xmlNode, IXmlMapping xmlMapping, MeasureType durationmeasure)
    {
        switch (xmlNode)
        {
            case "unitCode":
                xmlMapping.Value = durationmeasure.unitCode;
                break;
            case "unitCodeListVersionID":
                xmlMapping.Value = durationmeasure.unitCodeListVersionID;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(OrderReferenceType orderreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (orderreference.ID == null) return;
                GetField(orderreference.ID, xmlMapping);
                break;
            case "SalesOrderID":
                if (orderreference.SalesOrderID == null) return;
                GetField(orderreference.SalesOrderID, xmlMapping);
                break;
            case "CopyIndicator":
                if (orderreference.CopyIndicator == null) return;
                GetField(orderreference.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (orderreference.UUID == null) return;
                GetField(orderreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (orderreference.IssueDate == null) return;
                GetField(orderreference.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (orderreference.IssueTime == null) return;
                GetField(orderreference.IssueTime, xmlMapping);
                break;
            case "CustomerReference":
                if (orderreference.CustomerReference == null) return;
                GetField(orderreference.CustomerReference, xmlMapping);
                break;
            case "OrderTypeCode":
                if (orderreference.OrderTypeCode == null) return;
                GetField(orderreference.OrderTypeCode, xmlMapping);
                break;
            case "DocumentReference":
                if (orderreference.DocumentReference == null) return;
                GetField(orderreference.DocumentReference, xmlMapping);
                break;

        }
    }
    public void GetField(DocumentReferenceType documentreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (documentreference.ID == null) return;
                GetField(documentreference.ID, xmlMapping);
                break;
            case "CopyIndicator":
                if (documentreference.CopyIndicator == null) return;
                GetField(documentreference.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (documentreference.UUID == null) return;
                GetField(documentreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (documentreference.IssueDate == null) return;
                GetField(documentreference.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (documentreference.IssueTime == null) return;
                GetField(documentreference.IssueTime, xmlMapping);
                break;
            case "DocumentTypeCode":
                if (documentreference.DocumentTypeCode == null) return;
                GetField(documentreference.DocumentTypeCode, xmlMapping);
                break;
            case "DocumentType":
                if (documentreference.DocumentType == null) return;
                GetField(documentreference.DocumentType, xmlMapping);
                break;
            case "XPath":
                if (documentreference.XPath == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingXPath)
                {
                    foreach (var row in documentreference.XPath)
                    {
                        collMappingXPath.SetNewRowContext();

                        foreach (var colMapp in collMappingXPath.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(documentreference.XPath[0], xmlMapping);
                }
                break;
            case "LanguageID":
                if (documentreference.LanguageID == null) return;
                GetField(documentreference.LanguageID, xmlMapping);
                break;
            case "LocaleCode":
                if (documentreference.LocaleCode == null) return;
                GetField(documentreference.LocaleCode, xmlMapping);
                break;
            case "VersionID":
                if (documentreference.VersionID == null) return;
                GetField(documentreference.VersionID, xmlMapping);
                break;
            case "DocumentStatusCode":
                if (documentreference.DocumentStatusCode == null) return;
                GetField(documentreference.DocumentStatusCode, xmlMapping);
                break;
            case "DocumentDescription":
                if (documentreference.DocumentDescription == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentDescription)
                {
                    foreach (var row in documentreference.DocumentDescription)
                    {
                        collMappingDocumentDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(documentreference.DocumentDescription[0], xmlMapping);
                }
                break;
            case "Attachment":
                if (documentreference.Attachment == null) return;
                GetField(documentreference.Attachment, xmlMapping);
                break;
            case "ValidityPeriod":
                if (documentreference.ValidityPeriod == null) return;
                GetField(documentreference.ValidityPeriod, xmlMapping);
                break;
            case "IssuerParty":
                if (documentreference.IssuerParty == null) return;
                GetField(documentreference.IssuerParty, xmlMapping);
                break;
            case "ResultOfVerification":
                if (documentreference.ResultOfVerification == null) return;
                GetField(documentreference.ResultOfVerification, xmlMapping);
                break;

        }
    }
    public void GetField(AttachmentType attachment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "EmbeddedDocumentBinaryObject":
                if (attachment.EmbeddedDocumentBinaryObject == null) return;
                GetField(attachment.EmbeddedDocumentBinaryObject, xmlMapping);
                break;
            case "ExternalReference":
                if (attachment.ExternalReference == null) return;
                GetField(attachment.ExternalReference, xmlMapping);
                break;

        }
    }
    public void GetField(BinaryObjectType embeddeddocumentbinaryobject, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetBinaryObjectTypeProperty(xmlNode, xmlMapping, embeddeddocumentbinaryobject);
        else
            xmlMapping.Value = embeddeddocumentbinaryobject.GetValue();
    }

    public void GetBinaryObjectTypeProperty(string xmlNode, IXmlMapping xmlMapping, BinaryObjectType embeddeddocumentbinaryobject)
    {
        switch (xmlNode)
        {
            case "format":
                xmlMapping.Value = embeddeddocumentbinaryobject.format;
                break;
            case "mimeCode":
                xmlMapping.Value = embeddeddocumentbinaryobject.mimeCode;
                break;
            case "encodingCode":
                xmlMapping.Value = embeddeddocumentbinaryobject.encodingCode;
                break;
            case "characterSetCode":
                xmlMapping.Value = embeddeddocumentbinaryobject.characterSetCode;
                break;
            case "uri":
                xmlMapping.Value = embeddeddocumentbinaryobject.uri;
                break;
            case "filename":
                xmlMapping.Value = embeddeddocumentbinaryobject.filename;
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void GetField(ExternalReferenceType externalreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "URI":
                if (externalreference.URI == null) return;
                GetField(externalreference.URI, xmlMapping);
                break;
            case "DocumentHash":
                if (externalreference.DocumentHash == null) return;
                GetField(externalreference.DocumentHash, xmlMapping);
                break;
            case "HashAlgorithmMethod":
                if (externalreference.HashAlgorithmMethod == null) return;
                GetField(externalreference.HashAlgorithmMethod, xmlMapping);
                break;
            case "ExpiryDate":
                if (externalreference.ExpiryDate == null) return;
                GetField(externalreference.ExpiryDate, xmlMapping);
                break;
            case "ExpiryTime":
                if (externalreference.ExpiryTime == null) return;
                GetField(externalreference.ExpiryTime, xmlMapping);
                break;
            case "MimeCode":
                if (externalreference.MimeCode == null) return;
                GetField(externalreference.MimeCode, xmlMapping);
                break;
            case "FormatCode":
                if (externalreference.FormatCode == null) return;
                GetField(externalreference.FormatCode, xmlMapping);
                break;
            case "EncodingCode":
                if (externalreference.EncodingCode == null) return;
                GetField(externalreference.EncodingCode, xmlMapping);
                break;
            case "CharacterSetCode":
                if (externalreference.CharacterSetCode == null) return;
                GetField(externalreference.CharacterSetCode, xmlMapping);
                break;
            case "FileName":
                if (externalreference.FileName == null) return;
                GetField(externalreference.FileName, xmlMapping);
                break;
            case "Description":
                if (externalreference.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in externalreference.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(externalreference.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(PartyType issuerparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "MarkCareIndicator":
                if (issuerparty.MarkCareIndicator == null) return;
                GetField(issuerparty.MarkCareIndicator, xmlMapping);
                break;
            case "MarkAttentionIndicator":
                if (issuerparty.MarkAttentionIndicator == null) return;
                GetField(issuerparty.MarkAttentionIndicator, xmlMapping);
                break;
            case "WebsiteURI":
                if (issuerparty.WebsiteURI == null) return;
                GetField(issuerparty.WebsiteURI, xmlMapping);
                break;
            case "LogoReferenceID":
                if (issuerparty.LogoReferenceID == null) return;
                GetField(issuerparty.LogoReferenceID, xmlMapping);
                break;
            case "EndpointID":
                if (issuerparty.EndpointID == null) return;
                GetField(issuerparty.EndpointID, xmlMapping);
                break;
            case "IndustryClassificationCode":
                if (issuerparty.IndustryClassificationCode == null) return;
                GetField(issuerparty.IndustryClassificationCode, xmlMapping);
                break;
            case "PartyIdentification":
                if (issuerparty.PartyIdentification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPartyIdentification)
                {
                    foreach (var row in issuerparty.PartyIdentification)
                    {
                        collMappingPartyIdentification.SetNewRowContext();

                        foreach (var colMapp in collMappingPartyIdentification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.PartyIdentification[0], xmlMapping);
                }
                break;
            case "PartyName":
                if (issuerparty.PartyName == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPartyName)
                {
                    foreach (var row in issuerparty.PartyName)
                    {
                        collMappingPartyName.SetNewRowContext();

                        foreach (var colMapp in collMappingPartyName.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.PartyName[0], xmlMapping);
                }
                break;
            case "Language":
                if (issuerparty.Language == null) return;
                GetField(issuerparty.Language, xmlMapping);
                break;
            case "PostalAddress":
                if (issuerparty.PostalAddress == null) return;
                GetField(issuerparty.PostalAddress, xmlMapping);
                break;
            case "PhysicalLocation":
                if (issuerparty.PhysicalLocation == null) return;
                GetField(issuerparty.PhysicalLocation, xmlMapping);
                break;
            case "PartyTaxScheme":
                if (issuerparty.PartyTaxScheme == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPartyTaxScheme)
                {
                    foreach (var row in issuerparty.PartyTaxScheme)
                    {
                        collMappingPartyTaxScheme.SetNewRowContext();

                        foreach (var colMapp in collMappingPartyTaxScheme.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.PartyTaxScheme[0], xmlMapping);
                }
                break;
            case "PartyLegalEntity":
                if (issuerparty.PartyLegalEntity == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPartyLegalEntity)
                {
                    foreach (var row in issuerparty.PartyLegalEntity)
                    {
                        collMappingPartyLegalEntity.SetNewRowContext();

                        foreach (var colMapp in collMappingPartyLegalEntity.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.PartyLegalEntity[0], xmlMapping);
                }
                break;
            case "Contact":
                if (issuerparty.Contact == null) return;
                GetField(issuerparty.Contact, xmlMapping);
                break;
            case "Person":
                if (issuerparty.Person == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPerson)
                {
                    foreach (var row in issuerparty.Person)
                    {
                        collMappingPerson.SetNewRowContext();

                        foreach (var colMapp in collMappingPerson.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.Person[0], xmlMapping);
                }
                break;
            case "AgentParty":
                if (issuerparty.AgentParty == null) return;
                GetField(issuerparty.AgentParty, xmlMapping);
                break;
            case "ServiceProviderParty":
                if (issuerparty.ServiceProviderParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingServiceProviderParty)
                {
                    foreach (var row in issuerparty.ServiceProviderParty)
                    {
                        collMappingServiceProviderParty.SetNewRowContext();

                        foreach (var colMapp in collMappingServiceProviderParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.ServiceProviderParty[0], xmlMapping);
                }
                break;
            case "PowerOfAttorney":
                if (issuerparty.PowerOfAttorney == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPowerOfAttorney)
                {
                    foreach (var row in issuerparty.PowerOfAttorney)
                    {
                        collMappingPowerOfAttorney.SetNewRowContext();

                        foreach (var colMapp in collMappingPowerOfAttorney.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(issuerparty.PowerOfAttorney[0], xmlMapping);
                }
                break;
            case "FinancialAccount":
                if (issuerparty.FinancialAccount == null) return;
                GetField(issuerparty.FinancialAccount, xmlMapping);
                break;

        }
    }
    public void GetField(PartyIdentificationType partyidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (partyidentification.ID == null) return;
                GetField(partyidentification.ID, xmlMapping);
                break;

        }
    }
    public void GetField(PartyNameType partyname, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Name":
                if (partyname.Name == null) return;
                GetField(partyname.Name, xmlMapping);
                break;

        }
    }
    public void GetField(LanguageType language, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (language.ID == null) return;
                GetField(language.ID, xmlMapping);
                break;
            case "Name":
                if (language.Name == null) return;
                GetField(language.Name, xmlMapping);
                break;
            case "LocaleCode":
                if (language.LocaleCode == null) return;
                GetField(language.LocaleCode, xmlMapping);
                break;

        }
    }
    public void GetField(AddressType postaladdress, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (postaladdress.ID == null) return;
                GetField(postaladdress.ID, xmlMapping);
                break;
            case "AddressTypeCode":
                if (postaladdress.AddressTypeCode == null) return;
                GetField(postaladdress.AddressTypeCode, xmlMapping);
                break;
            case "AddressFormatCode":
                if (postaladdress.AddressFormatCode == null) return;
                GetField(postaladdress.AddressFormatCode, xmlMapping);
                break;
            case "Postbox":
                if (postaladdress.Postbox == null) return;
                GetField(postaladdress.Postbox, xmlMapping);
                break;
            case "Floor":
                if (postaladdress.Floor == null) return;
                GetField(postaladdress.Floor, xmlMapping);
                break;
            case "Room":
                if (postaladdress.Room == null) return;
                GetField(postaladdress.Room, xmlMapping);
                break;
            case "StreetName":
                if (postaladdress.StreetName == null) return;
                GetField(postaladdress.StreetName, xmlMapping);
                break;
            case "AdditionalStreetName":
                if (postaladdress.AdditionalStreetName == null) return;
                GetField(postaladdress.AdditionalStreetName, xmlMapping);
                break;
            case "BlockName":
                if (postaladdress.BlockName == null) return;
                GetField(postaladdress.BlockName, xmlMapping);
                break;
            case "BuildingName":
                if (postaladdress.BuildingName == null) return;
                GetField(postaladdress.BuildingName, xmlMapping);
                break;
            case "BuildingNumber":
                if (postaladdress.BuildingNumber == null) return;
                GetField(postaladdress.BuildingNumber, xmlMapping);
                break;
            case "InhouseMail":
                if (postaladdress.InhouseMail == null) return;
                GetField(postaladdress.InhouseMail, xmlMapping);
                break;
            case "Department":
                if (postaladdress.Department == null) return;
                GetField(postaladdress.Department, xmlMapping);
                break;
            case "MarkAttention":
                if (postaladdress.MarkAttention == null) return;
                GetField(postaladdress.MarkAttention, xmlMapping);
                break;
            case "MarkCare":
                if (postaladdress.MarkCare == null) return;
                GetField(postaladdress.MarkCare, xmlMapping);
                break;
            case "PlotIdentification":
                if (postaladdress.PlotIdentification == null) return;
                GetField(postaladdress.PlotIdentification, xmlMapping);
                break;
            case "CitySubdivisionName":
                if (postaladdress.CitySubdivisionName == null) return;
                GetField(postaladdress.CitySubdivisionName, xmlMapping);
                break;
            case "CityName":
                if (postaladdress.CityName == null) return;
                GetField(postaladdress.CityName, xmlMapping);
                break;
            case "PostalZone":
                if (postaladdress.PostalZone == null) return;
                GetField(postaladdress.PostalZone, xmlMapping);
                break;
            case "CountrySubentity":
                if (postaladdress.CountrySubentity == null) return;
                GetField(postaladdress.CountrySubentity, xmlMapping);
                break;
            case "CountrySubentityCode":
                if (postaladdress.CountrySubentityCode == null) return;
                GetField(postaladdress.CountrySubentityCode, xmlMapping);
                break;
            case "Region":
                if (postaladdress.Region == null) return;
                GetField(postaladdress.Region, xmlMapping);
                break;
            case "District":
                if (postaladdress.District == null) return;
                GetField(postaladdress.District, xmlMapping);
                break;
            case "TimezoneOffset":
                if (postaladdress.TimezoneOffset == null) return;
                GetField(postaladdress.TimezoneOffset, xmlMapping);
                break;
            case "AddressLine":
                if (postaladdress.AddressLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAddressLine)
                {
                    foreach (var row in postaladdress.AddressLine)
                    {
                        collMappingAddressLine.SetNewRowContext();

                        foreach (var colMapp in collMappingAddressLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(postaladdress.AddressLine[0], xmlMapping);
                }
                break;
            case "Country":
                if (postaladdress.Country == null) return;
                GetField(postaladdress.Country, xmlMapping);
                break;
            case "LocationCoordinate":
                if (postaladdress.LocationCoordinate == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingLocationCoordinate)
                {
                    foreach (var row in postaladdress.LocationCoordinate)
                    {
                        collMappingLocationCoordinate.SetNewRowContext();

                        foreach (var colMapp in collMappingLocationCoordinate.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(postaladdress.LocationCoordinate[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(AddressLineType addressline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Line":
                if (addressline.Line == null) return;
                GetField(addressline.Line, xmlMapping);
                break;

        }
    }
    public void GetField(CountryType country, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "IdentificationCode":
                if (country.IdentificationCode == null) return;
                GetField(country.IdentificationCode, xmlMapping);
                break;
            case "Name":
                if (country.Name == null) return;
                GetField(country.Name, xmlMapping);
                break;

        }
    }
    public void GetField(LocationCoordinateType locationcoordinate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CoordinateSystemCode":
                if (locationcoordinate.CoordinateSystemCode == null) return;
                GetField(locationcoordinate.CoordinateSystemCode, xmlMapping);
                break;
            case "LatitudeDegreesMeasure":
                if (locationcoordinate.LatitudeDegreesMeasure == null) return;
                GetField(locationcoordinate.LatitudeDegreesMeasure, xmlMapping);
                break;
            case "LatitudeMinutesMeasure":
                if (locationcoordinate.LatitudeMinutesMeasure == null) return;
                GetField(locationcoordinate.LatitudeMinutesMeasure, xmlMapping);
                break;
            case "LatitudeDirectionCode":
                if (locationcoordinate.LatitudeDirectionCode == null) return;
                GetField(locationcoordinate.LatitudeDirectionCode, xmlMapping);
                break;
            case "LongitudeDegreesMeasure":
                if (locationcoordinate.LongitudeDegreesMeasure == null) return;
                GetField(locationcoordinate.LongitudeDegreesMeasure, xmlMapping);
                break;
            case "LongitudeMinutesMeasure":
                if (locationcoordinate.LongitudeMinutesMeasure == null) return;
                GetField(locationcoordinate.LongitudeMinutesMeasure, xmlMapping);
                break;
            case "LongitudeDirectionCode":
                if (locationcoordinate.LongitudeDirectionCode == null) return;
                GetField(locationcoordinate.LongitudeDirectionCode, xmlMapping);
                break;
            case "AltitudeMeasure":
                if (locationcoordinate.AltitudeMeasure == null) return;
                GetField(locationcoordinate.AltitudeMeasure, xmlMapping);
                break;

        }
    }
    public void GetField(LocationType1 physicallocation, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (physicallocation.ID == null) return;
                GetField(physicallocation.ID, xmlMapping);
                break;
            case "Description":
                if (physicallocation.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in physicallocation.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicallocation.Description[0], xmlMapping);
                }
                break;
            case "Conditions":
                if (physicallocation.Conditions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingConditions)
                {
                    foreach (var row in physicallocation.Conditions)
                    {
                        collMappingConditions.SetNewRowContext();

                        foreach (var colMapp in collMappingConditions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicallocation.Conditions[0], xmlMapping);
                }
                break;
            case "CountrySubentity":
                if (physicallocation.CountrySubentity == null) return;
                GetField(physicallocation.CountrySubentity, xmlMapping);
                break;
            case "CountrySubentityCode":
                if (physicallocation.CountrySubentityCode == null) return;
                GetField(physicallocation.CountrySubentityCode, xmlMapping);
                break;
            case "LocationTypeCode":
                if (physicallocation.LocationTypeCode == null) return;
                GetField(physicallocation.LocationTypeCode, xmlMapping);
                break;
            case "InformationURI":
                if (physicallocation.InformationURI == null) return;
                GetField(physicallocation.InformationURI, xmlMapping);
                break;
            case "Name":
                if (physicallocation.Name == null) return;
                GetField(physicallocation.Name, xmlMapping);
                break;
            case "ValidityPeriod":
                if (physicallocation.ValidityPeriod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod)
                {
                    foreach (var row in physicallocation.ValidityPeriod)
                    {
                        collMappingValidityPeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicallocation.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "Address":
                if (physicallocation.Address == null) return;
                GetField(physicallocation.Address, xmlMapping);
                break;
            case "SubsidiaryLocation":
                if (physicallocation.SubsidiaryLocation == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSubsidiaryLocation)
                {
                    foreach (var row in physicallocation.SubsidiaryLocation)
                    {
                        collMappingSubsidiaryLocation.SetNewRowContext();

                        foreach (var colMapp in collMappingSubsidiaryLocation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicallocation.SubsidiaryLocation[0], xmlMapping);
                }
                break;
            case "LocationCoordinate":
                if (physicallocation.LocationCoordinate == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingLocationCoordinate)
                {
                    foreach (var row in physicallocation.LocationCoordinate)
                    {
                        collMappingLocationCoordinate.SetNewRowContext();

                        foreach (var colMapp in collMappingLocationCoordinate.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicallocation.LocationCoordinate[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(PartyTaxSchemeType partytaxscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "RegistrationName":
                if (partytaxscheme.RegistrationName == null) return;
                GetField(partytaxscheme.RegistrationName, xmlMapping);
                break;
            case "CompanyID":
                if (partytaxscheme.CompanyID == null) return;
                GetField(partytaxscheme.CompanyID, xmlMapping);
                break;
            case "TaxLevelCode":
                if (partytaxscheme.TaxLevelCode == null) return;
                GetField(partytaxscheme.TaxLevelCode, xmlMapping);
                break;
            case "ExemptionReasonCode":
                if (partytaxscheme.ExemptionReasonCode == null) return;
                GetField(partytaxscheme.ExemptionReasonCode, xmlMapping);
                break;
            case "ExemptionReason":
                if (partytaxscheme.ExemptionReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingExemptionReason)
                {
                    foreach (var row in partytaxscheme.ExemptionReason)
                    {
                        collMappingExemptionReason.SetNewRowContext();

                        foreach (var colMapp in collMappingExemptionReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(partytaxscheme.ExemptionReason[0], xmlMapping);
                }
                break;
            case "RegistrationAddress":
                if (partytaxscheme.RegistrationAddress == null) return;
                GetField(partytaxscheme.RegistrationAddress, xmlMapping);
                break;
            case "TaxScheme":
                if (partytaxscheme.TaxScheme == null) return;
                GetField(partytaxscheme.TaxScheme, xmlMapping);
                break;

        }
    }
    public void GetField(TaxSchemeType taxscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (taxscheme.ID == null) return;
                GetField(taxscheme.ID, xmlMapping);
                break;
            case "Name":
                if (taxscheme.Name == null) return;
                GetField(taxscheme.Name, xmlMapping);
                break;
            case "TaxTypeCode":
                if (taxscheme.TaxTypeCode == null) return;
                GetField(taxscheme.TaxTypeCode, xmlMapping);
                break;
            case "CurrencyCode":
                if (taxscheme.CurrencyCode == null) return;
                GetField(taxscheme.CurrencyCode, xmlMapping);
                break;
            case "JurisdictionRegionAddress":
                if (taxscheme.JurisdictionRegionAddress == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingJurisdictionRegionAddress)
                {
                    foreach (var row in taxscheme.JurisdictionRegionAddress)
                    {
                        collMappingJurisdictionRegionAddress.SetNewRowContext();

                        foreach (var colMapp in collMappingJurisdictionRegionAddress.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(taxscheme.JurisdictionRegionAddress[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(PartyLegalEntityType partylegalentity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "RegistrationName":
                if (partylegalentity.RegistrationName == null) return;
                GetField(partylegalentity.RegistrationName, xmlMapping);
                break;
            case "CompanyID":
                if (partylegalentity.CompanyID == null) return;
                GetField(partylegalentity.CompanyID, xmlMapping);
                break;
            case "RegistrationDate":
                if (partylegalentity.RegistrationDate == null) return;
                GetField(partylegalentity.RegistrationDate, xmlMapping);
                break;
            case "RegistrationExpirationDate":
                if (partylegalentity.RegistrationExpirationDate == null) return;
                GetField(partylegalentity.RegistrationExpirationDate, xmlMapping);
                break;
            case "CompanyLegalFormCode":
                if (partylegalentity.CompanyLegalFormCode == null) return;
                GetField(partylegalentity.CompanyLegalFormCode, xmlMapping);
                break;
            case "CompanyLegalForm":
                if (partylegalentity.CompanyLegalForm == null) return;
                GetField(partylegalentity.CompanyLegalForm, xmlMapping);
                break;
            case "SoleProprietorshipIndicator":
                if (partylegalentity.SoleProprietorshipIndicator == null) return;
                GetField(partylegalentity.SoleProprietorshipIndicator, xmlMapping);
                break;
            case "CompanyLiquidationStatusCode":
                if (partylegalentity.CompanyLiquidationStatusCode == null) return;
                GetField(partylegalentity.CompanyLiquidationStatusCode, xmlMapping);
                break;
            case "CorporateStockAmount":
                if (partylegalentity.CorporateStockAmount == null) return;
                GetField(partylegalentity.CorporateStockAmount, xmlMapping);
                break;
            case "FullyPaidSharesIndicator":
                if (partylegalentity.FullyPaidSharesIndicator == null) return;
                GetField(partylegalentity.FullyPaidSharesIndicator, xmlMapping);
                break;
            case "RegistrationAddress":
                if (partylegalentity.RegistrationAddress == null) return;
                GetField(partylegalentity.RegistrationAddress, xmlMapping);
                break;
            case "CorporateRegistrationScheme":
                if (partylegalentity.CorporateRegistrationScheme == null) return;
                GetField(partylegalentity.CorporateRegistrationScheme, xmlMapping);
                break;
            case "HeadOfficeParty":
                if (partylegalentity.HeadOfficeParty == null) return;
                GetField(partylegalentity.HeadOfficeParty, xmlMapping);
                break;
            case "ShareholderParty":
                if (partylegalentity.ShareholderParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShareholderParty)
                {
                    foreach (var row in partylegalentity.ShareholderParty)
                    {
                        collMappingShareholderParty.SetNewRowContext();

                        foreach (var colMapp in collMappingShareholderParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(partylegalentity.ShareholderParty[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(AmountType corporatestockamount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetAmountTypeProperty(xmlNode, xmlMapping, corporatestockamount);
        else
            xmlMapping.Value = corporatestockamount.GetValue();
    }

    public void GetAmountTypeProperty(string xmlNode, IXmlMapping xmlMapping, AmountType corporatestockamount)
    {
        switch (xmlNode)
        {
            case "currencyID":
                xmlMapping.Value = corporatestockamount.currencyID;
                break;
            case "currencyCodeListVersionID":
                xmlMapping.Value = corporatestockamount.currencyCodeListVersionID;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(CorporateRegistrationSchemeType corporateregistrationscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (corporateregistrationscheme.ID == null) return;
                GetField(corporateregistrationscheme.ID, xmlMapping);
                break;
            case "Name":
                if (corporateregistrationscheme.Name == null) return;
                GetField(corporateregistrationscheme.Name, xmlMapping);
                break;
            case "CorporateRegistrationTypeCode":
                if (corporateregistrationscheme.CorporateRegistrationTypeCode == null) return;
                GetField(corporateregistrationscheme.CorporateRegistrationTypeCode, xmlMapping);
                break;
            case "JurisdictionRegionAddress":
                if (corporateregistrationscheme.JurisdictionRegionAddress == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingJurisdictionRegionAddress)
                {
                    foreach (var row in corporateregistrationscheme.JurisdictionRegionAddress)
                    {
                        collMappingJurisdictionRegionAddress.SetNewRowContext();

                        foreach (var colMapp in collMappingJurisdictionRegionAddress.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(corporateregistrationscheme.JurisdictionRegionAddress[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ShareholderPartyType shareholderparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PartecipationPercent":
                if (shareholderparty.PartecipationPercent == null) return;
                GetField(shareholderparty.PartecipationPercent, xmlMapping);
                break;
            case "Party":
                if (shareholderparty.Party == null) return;
                GetField(shareholderparty.Party, xmlMapping);
                break;

        }
    }
    public void GetField(ContactType contact, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (contact.ID == null) return;
                GetField(contact.ID, xmlMapping);
                break;
            case "Name":
                if (contact.Name == null) return;
                GetField(contact.Name, xmlMapping);
                break;
            case "Telephone":
                if (contact.Telephone == null) return;
                GetField(contact.Telephone, xmlMapping);
                break;
            case "Telefax":
                if (contact.Telefax == null) return;
                GetField(contact.Telefax, xmlMapping);
                break;
            case "ElectronicMail":
                if (contact.ElectronicMail == null) return;
                GetField(contact.ElectronicMail, xmlMapping);
                break;
            case "Note":
                if (contact.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in contact.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(contact.Note[0], xmlMapping);
                }
                break;
            case "OtherCommunication":
                if (contact.OtherCommunication == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOtherCommunication)
                {
                    foreach (var row in contact.OtherCommunication)
                    {
                        collMappingOtherCommunication.SetNewRowContext();

                        foreach (var colMapp in collMappingOtherCommunication.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(contact.OtherCommunication[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(CommunicationType othercommunication, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ChannelCode":
                if (othercommunication.ChannelCode == null) return;
                GetField(othercommunication.ChannelCode, xmlMapping);
                break;
            case "Channel":
                if (othercommunication.Channel == null) return;
                GetField(othercommunication.Channel, xmlMapping);
                break;
            case "Value":
                if (othercommunication.Value == null) return;
                GetField(othercommunication.Value, xmlMapping);
                break;

        }
    }
    public void GetField(PersonType person, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (person.ID == null) return;
                GetField(person.ID, xmlMapping);
                break;
            case "FirstName":
                if (person.FirstName == null) return;
                GetField(person.FirstName, xmlMapping);
                break;
            case "FamilyName":
                if (person.FamilyName == null) return;
                GetField(person.FamilyName, xmlMapping);
                break;
            case "Title":
                if (person.Title == null) return;
                GetField(person.Title, xmlMapping);
                break;
            case "MiddleName":
                if (person.MiddleName == null) return;
                GetField(person.MiddleName, xmlMapping);
                break;
            case "OtherName":
                if (person.OtherName == null) return;
                GetField(person.OtherName, xmlMapping);
                break;
            case "NameSuffix":
                if (person.NameSuffix == null) return;
                GetField(person.NameSuffix, xmlMapping);
                break;
            case "JobTitle":
                if (person.JobTitle == null) return;
                GetField(person.JobTitle, xmlMapping);
                break;
            case "NationalityID":
                if (person.NationalityID == null) return;
                GetField(person.NationalityID, xmlMapping);
                break;
            case "GenderCode":
                if (person.GenderCode == null) return;
                GetField(person.GenderCode, xmlMapping);
                break;
            case "BirthDate":
                if (person.BirthDate == null) return;
                GetField(person.BirthDate, xmlMapping);
                break;
            case "BirthplaceName":
                if (person.BirthplaceName == null) return;
                GetField(person.BirthplaceName, xmlMapping);
                break;
            case "OrganizationDepartment":
                if (person.OrganizationDepartment == null) return;
                GetField(person.OrganizationDepartment, xmlMapping);
                break;
            case "Contact":
                if (person.Contact == null) return;
                GetField(person.Contact, xmlMapping);
                break;
            case "FinancialAccount":
                if (person.FinancialAccount == null) return;
                GetField(person.FinancialAccount, xmlMapping);
                break;
            case "IdentityDocumentReference":
                if (person.IdentityDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingIdentityDocumentReference)
                {
                    foreach (var row in person.IdentityDocumentReference)
                    {
                        collMappingIdentityDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingIdentityDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(person.IdentityDocumentReference[0], xmlMapping);
                }
                break;
            case "ResidenceAddress":
                if (person.ResidenceAddress == null) return;
                GetField(person.ResidenceAddress, xmlMapping);
                break;

        }
    }
    public void GetField(FinancialAccountType financialaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialaccount.ID == null) return;
                GetField(financialaccount.ID, xmlMapping);
                break;
            case "Name":
                if (financialaccount.Name == null) return;
                GetField(financialaccount.Name, xmlMapping);
                break;
            case "AliasName":
                if (financialaccount.AliasName == null) return;
                GetField(financialaccount.AliasName, xmlMapping);
                break;
            case "AccountTypeCode":
                if (financialaccount.AccountTypeCode == null) return;
                GetField(financialaccount.AccountTypeCode, xmlMapping);
                break;
            case "AccountFormatCode":
                if (financialaccount.AccountFormatCode == null) return;
                GetField(financialaccount.AccountFormatCode, xmlMapping);
                break;
            case "CurrencyCode":
                if (financialaccount.CurrencyCode == null) return;
                GetField(financialaccount.CurrencyCode, xmlMapping);
                break;
            case "PaymentNote":
                if (financialaccount.PaymentNote == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentNote)
                {
                    foreach (var row in financialaccount.PaymentNote)
                    {
                        collMappingPaymentNote.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(financialaccount.PaymentNote[0], xmlMapping);
                }
                break;
            case "FinancialInstitutionBranch":
                if (financialaccount.FinancialInstitutionBranch == null) return;
                GetField(financialaccount.FinancialInstitutionBranch, xmlMapping);
                break;
            case "Country":
                if (financialaccount.Country == null) return;
                GetField(financialaccount.Country, xmlMapping);
                break;

        }
    }
    public void GetField(BranchType financialinstitutionbranch, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialinstitutionbranch.ID == null) return;
                GetField(financialinstitutionbranch.ID, xmlMapping);
                break;
            case "Name":
                if (financialinstitutionbranch.Name == null) return;
                GetField(financialinstitutionbranch.Name, xmlMapping);
                break;
            case "FinancialInstitution":
                if (financialinstitutionbranch.FinancialInstitution == null) return;
                GetField(financialinstitutionbranch.FinancialInstitution, xmlMapping);
                break;
            case "Address":
                if (financialinstitutionbranch.Address == null) return;
                GetField(financialinstitutionbranch.Address, xmlMapping);
                break;

        }
    }
    public void GetField(FinancialInstitutionType financialinstitution, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialinstitution.ID == null) return;
                GetField(financialinstitution.ID, xmlMapping);
                break;
            case "Name":
                if (financialinstitution.Name == null) return;
                GetField(financialinstitution.Name, xmlMapping);
                break;
            case "Address":
                if (financialinstitution.Address == null) return;
                GetField(financialinstitution.Address, xmlMapping);
                break;

        }
    }
    public void GetField(ServiceProviderPartyType serviceproviderparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (serviceproviderparty.ID == null) return;
                GetField(serviceproviderparty.ID, xmlMapping);
                break;
            case "ServiceTypeCode":
                if (serviceproviderparty.ServiceTypeCode == null) return;
                GetField(serviceproviderparty.ServiceTypeCode, xmlMapping);
                break;
            case "ServiceType":
                if (serviceproviderparty.ServiceType == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingServiceType)
                {
                    foreach (var row in serviceproviderparty.ServiceType)
                    {
                        collMappingServiceType.SetNewRowContext();

                        foreach (var colMapp in collMappingServiceType.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(serviceproviderparty.ServiceType[0], xmlMapping);
                }
                break;
            case "Party":
                if (serviceproviderparty.Party == null) return;
                GetField(serviceproviderparty.Party, xmlMapping);
                break;
            case "SellerContact":
                if (serviceproviderparty.SellerContact == null) return;
                GetField(serviceproviderparty.SellerContact, xmlMapping);
                break;

        }
    }
    public void GetField(PowerOfAttorneyType powerofattorney, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (powerofattorney.ID == null) return;
                GetField(powerofattorney.ID, xmlMapping);
                break;
            case "IssueDate":
                if (powerofattorney.IssueDate == null) return;
                GetField(powerofattorney.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (powerofattorney.IssueTime == null) return;
                GetField(powerofattorney.IssueTime, xmlMapping);
                break;
            case "Description":
                if (powerofattorney.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in powerofattorney.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(powerofattorney.Description[0], xmlMapping);
                }
                break;
            case "NotaryParty":
                if (powerofattorney.NotaryParty == null) return;
                GetField(powerofattorney.NotaryParty, xmlMapping);
                break;
            case "AgentParty":
                if (powerofattorney.AgentParty == null) return;
                GetField(powerofattorney.AgentParty, xmlMapping);
                break;
            case "WitnessParty":
                if (powerofattorney.WitnessParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWitnessParty)
                {
                    foreach (var row in powerofattorney.WitnessParty)
                    {
                        collMappingWitnessParty.SetNewRowContext();

                        foreach (var colMapp in collMappingWitnessParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(powerofattorney.WitnessParty[0], xmlMapping);
                }
                break;
            case "MandateDocumentReference":
                if (powerofattorney.MandateDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMandateDocumentReference)
                {
                    foreach (var row in powerofattorney.MandateDocumentReference)
                    {
                        collMappingMandateDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingMandateDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(powerofattorney.MandateDocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ResultOfVerificationType resultofverification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ValidatorID":
                if (resultofverification.ValidatorID == null) return;
                GetField(resultofverification.ValidatorID, xmlMapping);
                break;
            case "ValidationResultCode":
                if (resultofverification.ValidationResultCode == null) return;
                GetField(resultofverification.ValidationResultCode, xmlMapping);
                break;
            case "ValidationDate":
                if (resultofverification.ValidationDate == null) return;
                GetField(resultofverification.ValidationDate, xmlMapping);
                break;
            case "ValidationTime":
                if (resultofverification.ValidationTime == null) return;
                GetField(resultofverification.ValidationTime, xmlMapping);
                break;
            case "ValidateProcess":
                if (resultofverification.ValidateProcess == null) return;
                GetField(resultofverification.ValidateProcess, xmlMapping);
                break;
            case "ValidateTool":
                if (resultofverification.ValidateTool == null) return;
                GetField(resultofverification.ValidateTool, xmlMapping);
                break;
            case "ValidateToolVersion":
                if (resultofverification.ValidateToolVersion == null) return;
                GetField(resultofverification.ValidateToolVersion, xmlMapping);
                break;
            case "SignatoryParty":
                if (resultofverification.SignatoryParty == null) return;
                GetField(resultofverification.SignatoryParty, xmlMapping);
                break;

        }
    }
    public void GetField(BillingReferenceType billingreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "InvoiceDocumentReference":
                if (billingreference.InvoiceDocumentReference == null) return;
                GetField(billingreference.InvoiceDocumentReference, xmlMapping);
                break;
            case "SelfBilledInvoiceDocumentReference":
                if (billingreference.SelfBilledInvoiceDocumentReference == null) return;
                GetField(billingreference.SelfBilledInvoiceDocumentReference, xmlMapping);
                break;
            case "CreditNoteDocumentReference":
                if (billingreference.CreditNoteDocumentReference == null) return;
                GetField(billingreference.CreditNoteDocumentReference, xmlMapping);
                break;
            case "SelfBilledCreditNoteDocumentReference":
                if (billingreference.SelfBilledCreditNoteDocumentReference == null) return;
                GetField(billingreference.SelfBilledCreditNoteDocumentReference, xmlMapping);
                break;
            case "DebitNoteDocumentReference":
                if (billingreference.DebitNoteDocumentReference == null) return;
                GetField(billingreference.DebitNoteDocumentReference, xmlMapping);
                break;
            case "ReminderDocumentReference":
                if (billingreference.ReminderDocumentReference == null) return;
                GetField(billingreference.ReminderDocumentReference, xmlMapping);
                break;
            case "AdditionalDocumentReference":
                if (billingreference.AdditionalDocumentReference == null) return;
                GetField(billingreference.AdditionalDocumentReference, xmlMapping);
                break;
            case "BillingReferenceLine":
                if (billingreference.BillingReferenceLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReferenceLine)
                {
                    foreach (var row in billingreference.BillingReferenceLine)
                    {
                        collMappingBillingReferenceLine.SetNewRowContext();

                        foreach (var colMapp in collMappingBillingReferenceLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(billingreference.BillingReferenceLine[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(BillingReferenceLineType billingreferenceline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (billingreferenceline.ID == null) return;
                GetField(billingreferenceline.ID, xmlMapping);
                break;
            case "Amount":
                if (billingreferenceline.Amount == null) return;
                GetField(billingreferenceline.Amount, xmlMapping);
                break;
            case "AllowanceCharge":
                if (billingreferenceline.AllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                {
                    foreach (var row in billingreferenceline.AllowanceCharge)
                    {
                        collMappingAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(billingreferenceline.AllowanceCharge[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(AllowanceChargeType allowancecharge, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (allowancecharge.ID == null) return;
                GetField(allowancecharge.ID, xmlMapping);
                break;
            case "ChargeIndicator":
                if (allowancecharge.ChargeIndicator == null) return;
                GetField(allowancecharge.ChargeIndicator, xmlMapping);
                break;
            case "AllowanceChargeReasonCode":
                if (allowancecharge.AllowanceChargeReasonCode == null) return;
                GetField(allowancecharge.AllowanceChargeReasonCode, xmlMapping);
                break;
            case "AllowanceChargeReason":
                if (allowancecharge.AllowanceChargeReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceChargeReason)
                {
                    foreach (var row in allowancecharge.AllowanceChargeReason)
                    {
                        collMappingAllowanceChargeReason.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceChargeReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(allowancecharge.AllowanceChargeReason[0], xmlMapping);
                }
                break;
            case "MultiplierFactorNumeric":
                if (allowancecharge.MultiplierFactorNumeric == null) return;
                GetField(allowancecharge.MultiplierFactorNumeric, xmlMapping);
                break;
            case "PrepaidIndicator":
                if (allowancecharge.PrepaidIndicator == null) return;
                GetField(allowancecharge.PrepaidIndicator, xmlMapping);
                break;
            case "SequenceNumeric":
                if (allowancecharge.SequenceNumeric == null) return;
                GetField(allowancecharge.SequenceNumeric, xmlMapping);
                break;
            case "Amount":
                if (allowancecharge.Amount == null) return;
                GetField(allowancecharge.Amount, xmlMapping);
                break;
            case "BaseAmount":
                if (allowancecharge.BaseAmount == null) return;
                GetField(allowancecharge.BaseAmount, xmlMapping);
                break;
            case "AccountingCostCode":
                if (allowancecharge.AccountingCostCode == null) return;
                GetField(allowancecharge.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (allowancecharge.AccountingCost == null) return;
                GetField(allowancecharge.AccountingCost, xmlMapping);
                break;
            case "PerUnitAmount":
                if (allowancecharge.PerUnitAmount == null) return;
                GetField(allowancecharge.PerUnitAmount, xmlMapping);
                break;
            case "TaxCategory":
                if (allowancecharge.TaxCategory == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxCategory)
                {
                    foreach (var row in allowancecharge.TaxCategory)
                    {
                        collMappingTaxCategory.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxCategory.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(allowancecharge.TaxCategory[0], xmlMapping);
                }
                break;
            case "TaxTotal":
                if (allowancecharge.TaxTotal == null) return;
                GetField(allowancecharge.TaxTotal, xmlMapping);
                break;
            case "PaymentMeans":
                if (allowancecharge.PaymentMeans == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans)
                {
                    foreach (var row in allowancecharge.PaymentMeans)
                    {
                        collMappingPaymentMeans.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(allowancecharge.PaymentMeans[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(TaxCategoryType taxcategory, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (taxcategory.ID == null) return;
                GetField(taxcategory.ID, xmlMapping);
                break;
            case "Name":
                if (taxcategory.Name == null) return;
                GetField(taxcategory.Name, xmlMapping);
                break;
            case "Percent":
                if (taxcategory.Percent == null) return;
                GetField(taxcategory.Percent, xmlMapping);
                break;
            case "BaseUnitMeasure":
                if (taxcategory.BaseUnitMeasure == null) return;
                GetField(taxcategory.BaseUnitMeasure, xmlMapping);
                break;
            case "PerUnitAmount":
                if (taxcategory.PerUnitAmount == null) return;
                GetField(taxcategory.PerUnitAmount, xmlMapping);
                break;
            case "TaxExemptionReasonCode":
                if (taxcategory.TaxExemptionReasonCode == null) return;
                GetField(taxcategory.TaxExemptionReasonCode, xmlMapping);
                break;
            case "TaxExemptionReason":
                if (taxcategory.TaxExemptionReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxExemptionReason)
                {
                    foreach (var row in taxcategory.TaxExemptionReason)
                    {
                        collMappingTaxExemptionReason.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxExemptionReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(taxcategory.TaxExemptionReason[0], xmlMapping);
                }
                break;
            case "TierRange":
                if (taxcategory.TierRange == null) return;
                GetField(taxcategory.TierRange, xmlMapping);
                break;
            case "TierRatePercent":
                if (taxcategory.TierRatePercent == null) return;
                GetField(taxcategory.TierRatePercent, xmlMapping);
                break;
            case "TaxScheme":
                if (taxcategory.TaxScheme == null) return;
                GetField(taxcategory.TaxScheme, xmlMapping);
                break;

        }
    }
    public void GetField(TaxTotalType taxtotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TaxAmount":
                if (taxtotal.TaxAmount == null) return;
                GetField(taxtotal.TaxAmount, xmlMapping);
                break;
            case "RoundingAmount":
                if (taxtotal.RoundingAmount == null) return;
                GetField(taxtotal.RoundingAmount, xmlMapping);
                break;
            case "TaxEvidenceIndicator":
                if (taxtotal.TaxEvidenceIndicator == null) return;
                GetField(taxtotal.TaxEvidenceIndicator, xmlMapping);
                break;
            case "TaxIncludedIndicator":
                if (taxtotal.TaxIncludedIndicator == null) return;
                GetField(taxtotal.TaxIncludedIndicator, xmlMapping);
                break;
            case "TaxSubtotal":
                if (taxtotal.TaxSubtotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxSubtotal)
                {
                    foreach (var row in taxtotal.TaxSubtotal)
                    {
                        collMappingTaxSubtotal.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxSubtotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(taxtotal.TaxSubtotal[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(TaxSubtotalType taxsubtotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TaxableAmount":
                if (taxsubtotal.TaxableAmount == null) return;
                GetField(taxsubtotal.TaxableAmount, xmlMapping);
                break;
            case "TaxAmount":
                if (taxsubtotal.TaxAmount == null) return;
                GetField(taxsubtotal.TaxAmount, xmlMapping);
                break;
            case "CalculationSequenceNumeric":
                if (taxsubtotal.CalculationSequenceNumeric == null) return;
                GetField(taxsubtotal.CalculationSequenceNumeric, xmlMapping);
                break;
            case "TransactionCurrencyTaxAmount":
                if (taxsubtotal.TransactionCurrencyTaxAmount == null) return;
                GetField(taxsubtotal.TransactionCurrencyTaxAmount, xmlMapping);
                break;
            case "Percent":
                if (taxsubtotal.Percent == null) return;
                GetField(taxsubtotal.Percent, xmlMapping);
                break;
            case "BaseUnitMeasure":
                if (taxsubtotal.BaseUnitMeasure == null) return;
                GetField(taxsubtotal.BaseUnitMeasure, xmlMapping);
                break;
            case "PerUnitAmount":
                if (taxsubtotal.PerUnitAmount == null) return;
                GetField(taxsubtotal.PerUnitAmount, xmlMapping);
                break;
            case "TierRange":
                if (taxsubtotal.TierRange == null) return;
                GetField(taxsubtotal.TierRange, xmlMapping);
                break;
            case "TierRatePercent":
                if (taxsubtotal.TierRatePercent == null) return;
                GetField(taxsubtotal.TierRatePercent, xmlMapping);
                break;
            case "TaxCategory":
                if (taxsubtotal.TaxCategory == null) return;
                GetField(taxsubtotal.TaxCategory, xmlMapping);
                break;

        }
    }
    public void GetField(PaymentMeansType paymentmeans, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentmeans.ID == null) return;
                GetField(paymentmeans.ID, xmlMapping);
                break;
            case "PaymentMeansCode":
                if (paymentmeans.PaymentMeansCode == null) return;
                GetField(paymentmeans.PaymentMeansCode, xmlMapping);
                break;
            case "PaymentDueDate":
                if (paymentmeans.PaymentDueDate == null) return;
                GetField(paymentmeans.PaymentDueDate, xmlMapping);
                break;
            case "PaymentChannelCode":
                if (paymentmeans.PaymentChannelCode == null) return;
                GetField(paymentmeans.PaymentChannelCode, xmlMapping);
                break;
            case "InstructionID":
                if (paymentmeans.InstructionID == null) return;
                GetField(paymentmeans.InstructionID, xmlMapping);
                break;
            case "InstructionNote":
                if (paymentmeans.InstructionNote == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInstructionNote)
                {
                    foreach (var row in paymentmeans.InstructionNote)
                    {
                        collMappingInstructionNote.SetNewRowContext();

                        foreach (var colMapp in collMappingInstructionNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(paymentmeans.InstructionNote[0], xmlMapping);
                }
                break;
            case "PaymentID":
                if (paymentmeans.PaymentID == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentID)
                {
                    foreach (var row in paymentmeans.PaymentID)
                    {
                        collMappingPaymentID.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentID.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(paymentmeans.PaymentID[0], xmlMapping);
                }
                break;
            case "CardAccount":
                if (paymentmeans.CardAccount == null) return;
                GetField(paymentmeans.CardAccount, xmlMapping);
                break;
            case "PayerFinancialAccount":
                if (paymentmeans.PayerFinancialAccount == null) return;
                GetField(paymentmeans.PayerFinancialAccount, xmlMapping);
                break;
            case "PayeeFinancialAccount":
                if (paymentmeans.PayeeFinancialAccount == null) return;
                GetField(paymentmeans.PayeeFinancialAccount, xmlMapping);
                break;
            case "CreditAccount":
                if (paymentmeans.CreditAccount == null) return;
                GetField(paymentmeans.CreditAccount, xmlMapping);
                break;
            case "PaymentMandate":
                if (paymentmeans.PaymentMandate == null) return;
                GetField(paymentmeans.PaymentMandate, xmlMapping);
                break;
            case "TradeFinancing":
                if (paymentmeans.TradeFinancing == null) return;
                GetField(paymentmeans.TradeFinancing, xmlMapping);
                break;

        }
    }
    public void GetField(CardAccountType cardaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PrimaryAccountNumberID":
                if (cardaccount.PrimaryAccountNumberID == null) return;
                GetField(cardaccount.PrimaryAccountNumberID, xmlMapping);
                break;
            case "NetworkID":
                if (cardaccount.NetworkID == null) return;
                GetField(cardaccount.NetworkID, xmlMapping);
                break;
            case "CardTypeCode":
                if (cardaccount.CardTypeCode == null) return;
                GetField(cardaccount.CardTypeCode, xmlMapping);
                break;
            case "ValidityStartDate":
                if (cardaccount.ValidityStartDate == null) return;
                GetField(cardaccount.ValidityStartDate, xmlMapping);
                break;
            case "ExpiryDate":
                if (cardaccount.ExpiryDate == null) return;
                GetField(cardaccount.ExpiryDate, xmlMapping);
                break;
            case "IssuerID":
                if (cardaccount.IssuerID == null) return;
                GetField(cardaccount.IssuerID, xmlMapping);
                break;
            case "IssueNumberID":
                if (cardaccount.IssueNumberID == null) return;
                GetField(cardaccount.IssueNumberID, xmlMapping);
                break;
            case "CV2ID":
                if (cardaccount.CV2ID == null) return;
                GetField(cardaccount.CV2ID, xmlMapping);
                break;
            case "CardChipCode":
                if (cardaccount.CardChipCode == null) return;
                GetField(cardaccount.CardChipCode, xmlMapping);
                break;
            case "ChipApplicationID":
                if (cardaccount.ChipApplicationID == null) return;
                GetField(cardaccount.ChipApplicationID, xmlMapping);
                break;
            case "HolderName":
                if (cardaccount.HolderName == null) return;
                GetField(cardaccount.HolderName, xmlMapping);
                break;

        }
    }
    public void GetField(CreditAccountType creditaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AccountID":
                if (creditaccount.AccountID == null) return;
                GetField(creditaccount.AccountID, xmlMapping);
                break;

        }
    }
    public void GetField(PaymentMandateType paymentmandate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentmandate.ID == null) return;
                GetField(paymentmandate.ID, xmlMapping);
                break;
            case "MandateTypeCode":
                if (paymentmandate.MandateTypeCode == null) return;
                GetField(paymentmandate.MandateTypeCode, xmlMapping);
                break;
            case "MaximumPaymentInstructionsNumeric":
                if (paymentmandate.MaximumPaymentInstructionsNumeric == null) return;
                GetField(paymentmandate.MaximumPaymentInstructionsNumeric, xmlMapping);
                break;
            case "MaximumPaidAmount":
                if (paymentmandate.MaximumPaidAmount == null) return;
                GetField(paymentmandate.MaximumPaidAmount, xmlMapping);
                break;
            case "SignatureID":
                if (paymentmandate.SignatureID == null) return;
                GetField(paymentmandate.SignatureID, xmlMapping);
                break;
            case "PayerParty":
                if (paymentmandate.PayerParty == null) return;
                GetField(paymentmandate.PayerParty, xmlMapping);
                break;
            case "PayerFinancialAccount":
                if (paymentmandate.PayerFinancialAccount == null) return;
                GetField(paymentmandate.PayerFinancialAccount, xmlMapping);
                break;
            case "ValidityPeriod":
                if (paymentmandate.ValidityPeriod == null) return;
                GetField(paymentmandate.ValidityPeriod, xmlMapping);
                break;
            case "PaymentReversalPeriod":
                if (paymentmandate.PaymentReversalPeriod == null) return;
                GetField(paymentmandate.PaymentReversalPeriod, xmlMapping);
                break;
            case "Clause":
                if (paymentmandate.Clause == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingClause)
                {
                    foreach (var row in paymentmandate.Clause)
                    {
                        collMappingClause.SetNewRowContext();

                        foreach (var colMapp in collMappingClause.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(paymentmandate.Clause[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ClauseType clause, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (clause.ID == null) return;
                GetField(clause.ID, xmlMapping);
                break;
            case "Content":
                if (clause.Content == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContent)
                {
                    foreach (var row in clause.Content)
                    {
                        collMappingContent.SetNewRowContext();

                        foreach (var colMapp in collMappingContent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(clause.Content[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(TradeFinancingType tradefinancing, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (tradefinancing.ID == null) return;
                GetField(tradefinancing.ID, xmlMapping);
                break;
            case "FinancingInstrumentCode":
                if (tradefinancing.FinancingInstrumentCode == null) return;
                GetField(tradefinancing.FinancingInstrumentCode, xmlMapping);
                break;
            case "ContractDocumentReference":
                if (tradefinancing.ContractDocumentReference == null) return;
                GetField(tradefinancing.ContractDocumentReference, xmlMapping);
                break;
            case "DocumentReference":
                if (tradefinancing.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in tradefinancing.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(tradefinancing.DocumentReference[0], xmlMapping);
                }
                break;
            case "FinancingParty":
                if (tradefinancing.FinancingParty == null) return;
                GetField(tradefinancing.FinancingParty, xmlMapping);
                break;
            case "FinancingFinancialAccount":
                if (tradefinancing.FinancingFinancialAccount == null) return;
                GetField(tradefinancing.FinancingFinancialAccount, xmlMapping);
                break;
            case "Clause":
                if (tradefinancing.Clause == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingClause)
                {
                    foreach (var row in tradefinancing.Clause)
                    {
                        collMappingClause.SetNewRowContext();

                        foreach (var colMapp in collMappingClause.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(tradefinancing.Clause[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ProjectReferenceType projectreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (projectreference.ID == null) return;
                GetField(projectreference.ID, xmlMapping);
                break;
            case "UUID":
                if (projectreference.UUID == null) return;
                GetField(projectreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (projectreference.IssueDate == null) return;
                GetField(projectreference.IssueDate, xmlMapping);
                break;
            case "WorkPhaseReference":
                if (projectreference.WorkPhaseReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWorkPhaseReference)
                {
                    foreach (var row in projectreference.WorkPhaseReference)
                    {
                        collMappingWorkPhaseReference.SetNewRowContext();

                        foreach (var colMapp in collMappingWorkPhaseReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(projectreference.WorkPhaseReference[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(WorkPhaseReferenceType workphasereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (workphasereference.ID == null) return;
                GetField(workphasereference.ID, xmlMapping);
                break;
            case "WorkPhaseCode":
                if (workphasereference.WorkPhaseCode == null) return;
                GetField(workphasereference.WorkPhaseCode, xmlMapping);
                break;
            case "WorkPhase":
                if (workphasereference.WorkPhase == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWorkPhase)
                {
                    foreach (var row in workphasereference.WorkPhase)
                    {
                        collMappingWorkPhase.SetNewRowContext();

                        foreach (var colMapp in collMappingWorkPhase.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(workphasereference.WorkPhase[0], xmlMapping);
                }
                break;
            case "ProgressPercent":
                if (workphasereference.ProgressPercent == null) return;
                GetField(workphasereference.ProgressPercent, xmlMapping);
                break;
            case "StartDate":
                if (workphasereference.StartDate == null) return;
                GetField(workphasereference.StartDate, xmlMapping);
                break;
            case "EndDate":
                if (workphasereference.EndDate == null) return;
                GetField(workphasereference.EndDate, xmlMapping);
                break;
            case "WorkOrderDocumentReference":
                if (workphasereference.WorkOrderDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWorkOrderDocumentReference)
                {
                    foreach (var row in workphasereference.WorkOrderDocumentReference)
                    {
                        collMappingWorkOrderDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingWorkOrderDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(workphasereference.WorkOrderDocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(SignatureType signature, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (signature.ID == null) return;
                GetField(signature.ID, xmlMapping);
                break;
            case "Note":
                if (signature.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in signature.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(signature.Note[0], xmlMapping);
                }
                break;
            case "ValidationDate":
                if (signature.ValidationDate == null) return;
                GetField(signature.ValidationDate, xmlMapping);
                break;
            case "ValidationTime":
                if (signature.ValidationTime == null) return;
                GetField(signature.ValidationTime, xmlMapping);
                break;
            case "ValidatorID":
                if (signature.ValidatorID == null) return;
                GetField(signature.ValidatorID, xmlMapping);
                break;
            case "CanonicalizationMethod":
                if (signature.CanonicalizationMethod == null) return;
                GetField(signature.CanonicalizationMethod, xmlMapping);
                break;
            case "SignatureMethod":
                if (signature.SignatureMethod == null) return;
                GetField(signature.SignatureMethod, xmlMapping);
                break;
            case "SignatoryParty":
                if (signature.SignatoryParty == null) return;
                GetField(signature.SignatoryParty, xmlMapping);
                break;
            case "DigitalSignatureAttachment":
                if (signature.DigitalSignatureAttachment == null) return;
                GetField(signature.DigitalSignatureAttachment, xmlMapping);
                break;
            case "OriginalDocumentReference":
                if (signature.OriginalDocumentReference == null) return;
                GetField(signature.OriginalDocumentReference, xmlMapping);
                break;

        }
    }
    public void GetField(SupplierPartyType accountingsupplierparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CustomerAssignedAccountID":
                if (accountingsupplierparty.CustomerAssignedAccountID == null) return;
                GetField(accountingsupplierparty.CustomerAssignedAccountID, xmlMapping);
                break;
            case "AdditionalAccountID":
                if (accountingsupplierparty.AdditionalAccountID == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalAccountID)
                {
                    foreach (var row in accountingsupplierparty.AdditionalAccountID)
                    {
                        collMappingAdditionalAccountID.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalAccountID.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(accountingsupplierparty.AdditionalAccountID[0], xmlMapping);
                }
                break;
            case "DataSendingCapability":
                if (accountingsupplierparty.DataSendingCapability == null) return;
                GetField(accountingsupplierparty.DataSendingCapability, xmlMapping);
                break;
            case "Party":
                if (accountingsupplierparty.Party == null) return;
                GetField(accountingsupplierparty.Party, xmlMapping);
                break;
            case "DespatchContact":
                if (accountingsupplierparty.DespatchContact == null) return;
                GetField(accountingsupplierparty.DespatchContact, xmlMapping);
                break;
            case "AccountingContact":
                if (accountingsupplierparty.AccountingContact == null) return;
                GetField(accountingsupplierparty.AccountingContact, xmlMapping);
                break;
            case "SellerContact":
                if (accountingsupplierparty.SellerContact == null) return;
                GetField(accountingsupplierparty.SellerContact, xmlMapping);
                break;

        }
    }
    public void GetField(CustomerPartyType accountingcustomerparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CustomerAssignedAccountID":
                if (accountingcustomerparty.CustomerAssignedAccountID == null) return;
                GetField(accountingcustomerparty.CustomerAssignedAccountID, xmlMapping);
                break;
            case "SupplierAssignedAccountID":
                if (accountingcustomerparty.SupplierAssignedAccountID == null) return;
                GetField(accountingcustomerparty.SupplierAssignedAccountID, xmlMapping);
                break;
            case "AdditionalAccountID":
                if (accountingcustomerparty.AdditionalAccountID == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalAccountID)
                {
                    foreach (var row in accountingcustomerparty.AdditionalAccountID)
                    {
                        collMappingAdditionalAccountID.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalAccountID.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(accountingcustomerparty.AdditionalAccountID[0], xmlMapping);
                }
                break;
            case "Party":
                if (accountingcustomerparty.Party == null) return;
                GetField(accountingcustomerparty.Party, xmlMapping);
                break;
            case "DeliveryContact":
                if (accountingcustomerparty.DeliveryContact == null) return;
                GetField(accountingcustomerparty.DeliveryContact, xmlMapping);
                break;
            case "AccountingContact":
                if (accountingcustomerparty.AccountingContact == null) return;
                GetField(accountingcustomerparty.AccountingContact, xmlMapping);
                break;
            case "BuyerContact":
                if (accountingcustomerparty.BuyerContact == null) return;
                GetField(accountingcustomerparty.BuyerContact, xmlMapping);
                break;

        }
    }
    public void GetField(DeliveryType delivery, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (delivery.ID == null) return;
                GetField(delivery.ID, xmlMapping);
                break;
            case "Quantity":
                if (delivery.Quantity == null) return;
                GetField(delivery.Quantity, xmlMapping);
                break;
            case "MinimumQuantity":
                if (delivery.MinimumQuantity == null) return;
                GetField(delivery.MinimumQuantity, xmlMapping);
                break;
            case "MaximumQuantity":
                if (delivery.MaximumQuantity == null) return;
                GetField(delivery.MaximumQuantity, xmlMapping);
                break;
            case "ActualDeliveryDate":
                if (delivery.ActualDeliveryDate == null) return;
                GetField(delivery.ActualDeliveryDate, xmlMapping);
                break;
            case "ActualDeliveryTime":
                if (delivery.ActualDeliveryTime == null) return;
                GetField(delivery.ActualDeliveryTime, xmlMapping);
                break;
            case "LatestDeliveryDate":
                if (delivery.LatestDeliveryDate == null) return;
                GetField(delivery.LatestDeliveryDate, xmlMapping);
                break;
            case "LatestDeliveryTime":
                if (delivery.LatestDeliveryTime == null) return;
                GetField(delivery.LatestDeliveryTime, xmlMapping);
                break;
            case "ReleaseID":
                if (delivery.ReleaseID == null) return;
                GetField(delivery.ReleaseID, xmlMapping);
                break;
            case "TrackingID":
                if (delivery.TrackingID == null) return;
                GetField(delivery.TrackingID, xmlMapping);
                break;
            case "DeliveryAddress":
                if (delivery.DeliveryAddress == null) return;
                GetField(delivery.DeliveryAddress, xmlMapping);
                break;
            case "DeliveryLocation":
                if (delivery.DeliveryLocation == null) return;
                GetField(delivery.DeliveryLocation, xmlMapping);
                break;
            case "AlternativeDeliveryLocation":
                if (delivery.AlternativeDeliveryLocation == null) return;
                GetField(delivery.AlternativeDeliveryLocation, xmlMapping);
                break;
            case "RequestedDeliveryPeriod":
                if (delivery.RequestedDeliveryPeriod == null) return;
                GetField(delivery.RequestedDeliveryPeriod, xmlMapping);
                break;
            case "PromisedDeliveryPeriod":
                if (delivery.PromisedDeliveryPeriod == null) return;
                GetField(delivery.PromisedDeliveryPeriod, xmlMapping);
                break;
            case "EstimatedDeliveryPeriod":
                if (delivery.EstimatedDeliveryPeriod == null) return;
                GetField(delivery.EstimatedDeliveryPeriod, xmlMapping);
                break;
            case "CarrierParty":
                if (delivery.CarrierParty == null) return;
                GetField(delivery.CarrierParty, xmlMapping);
                break;
            case "DeliveryParty":
                if (delivery.DeliveryParty == null) return;
                GetField(delivery.DeliveryParty, xmlMapping);
                break;
            case "NotifyParty":
                if (delivery.NotifyParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNotifyParty)
                {
                    foreach (var row in delivery.NotifyParty)
                    {
                        collMappingNotifyParty.SetNewRowContext();

                        foreach (var colMapp in collMappingNotifyParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(delivery.NotifyParty[0], xmlMapping);
                }
                break;
            case "Despatch":
                if (delivery.Despatch == null) return;
                GetField(delivery.Despatch, xmlMapping);
                break;
            case "DeliveryTerms":
                if (delivery.DeliveryTerms == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryTerms)
                {
                    foreach (var row in delivery.DeliveryTerms)
                    {
                        collMappingDeliveryTerms.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryTerms.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(delivery.DeliveryTerms[0], xmlMapping);
                }
                break;
            case "MinimumDeliveryUnit":
                if (delivery.MinimumDeliveryUnit == null) return;
                GetField(delivery.MinimumDeliveryUnit, xmlMapping);
                break;
            case "MaximumDeliveryUnit":
                if (delivery.MaximumDeliveryUnit == null) return;
                GetField(delivery.MaximumDeliveryUnit, xmlMapping);
                break;
            case "Shipment":
                if (delivery.Shipment == null) return;
                GetField(delivery.Shipment, xmlMapping);
                break;

        }
    }
    public void GetField(QuantityType quantity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            GetQuantityTypeProperty(xmlNode, xmlMapping, quantity);
        else
            xmlMapping.Value = quantity.GetValue();
    }

    public void GetQuantityTypeProperty(string xmlNode, IXmlMapping xmlMapping, QuantityType quantity)
    {
        switch (xmlNode)
        {
            case "unitCode":
                xmlMapping.Value = quantity.unitCode;
                break;
            case "unitCodeListID":
                xmlMapping.Value = quantity.unitCodeListID;
                break;
            case "unitCodeListAgencyID":
                xmlMapping.Value = quantity.unitCodeListAgencyID;
                break;
            case "unitCodeListAgencyName":
                xmlMapping.Value = quantity.unitCodeListAgencyName;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public void GetField(DespatchType despatch, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (despatch.ID == null) return;
                GetField(despatch.ID, xmlMapping);
                break;
            case "RequestedDespatchDate":
                if (despatch.RequestedDespatchDate == null) return;
                GetField(despatch.RequestedDespatchDate, xmlMapping);
                break;
            case "RequestedDespatchTime":
                if (despatch.RequestedDespatchTime == null) return;
                GetField(despatch.RequestedDespatchTime, xmlMapping);
                break;
            case "EstimatedDespatchDate":
                if (despatch.EstimatedDespatchDate == null) return;
                GetField(despatch.EstimatedDespatchDate, xmlMapping);
                break;
            case "EstimatedDespatchTime":
                if (despatch.EstimatedDespatchTime == null) return;
                GetField(despatch.EstimatedDespatchTime, xmlMapping);
                break;
            case "ActualDespatchDate":
                if (despatch.ActualDespatchDate == null) return;
                GetField(despatch.ActualDespatchDate, xmlMapping);
                break;
            case "ActualDespatchTime":
                if (despatch.ActualDespatchTime == null) return;
                GetField(despatch.ActualDespatchTime, xmlMapping);
                break;
            case "GuaranteedDespatchDate":
                if (despatch.GuaranteedDespatchDate == null) return;
                GetField(despatch.GuaranteedDespatchDate, xmlMapping);
                break;
            case "GuaranteedDespatchTime":
                if (despatch.GuaranteedDespatchTime == null) return;
                GetField(despatch.GuaranteedDespatchTime, xmlMapping);
                break;
            case "ReleaseID":
                if (despatch.ReleaseID == null) return;
                GetField(despatch.ReleaseID, xmlMapping);
                break;
            case "Instructions":
                if (despatch.Instructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInstructions)
                {
                    foreach (var row in despatch.Instructions)
                    {
                        collMappingInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(despatch.Instructions[0], xmlMapping);
                }
                break;
            case "DespatchAddress":
                if (despatch.DespatchAddress == null) return;
                GetField(despatch.DespatchAddress, xmlMapping);
                break;
            case "DespatchLocation":
                if (despatch.DespatchLocation == null) return;
                GetField(despatch.DespatchLocation, xmlMapping);
                break;
            case "DespatchParty":
                if (despatch.DespatchParty == null) return;
                GetField(despatch.DespatchParty, xmlMapping);
                break;
            case "CarrierParty":
                if (despatch.CarrierParty == null) return;
                GetField(despatch.CarrierParty, xmlMapping);
                break;
            case "NotifyParty":
                if (despatch.NotifyParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNotifyParty)
                {
                    foreach (var row in despatch.NotifyParty)
                    {
                        collMappingNotifyParty.SetNewRowContext();

                        foreach (var colMapp in collMappingNotifyParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(despatch.NotifyParty[0], xmlMapping);
                }
                break;
            case "Contact":
                if (despatch.Contact == null) return;
                GetField(despatch.Contact, xmlMapping);
                break;
            case "EstimatedDespatchPeriod":
                if (despatch.EstimatedDespatchPeriod == null) return;
                GetField(despatch.EstimatedDespatchPeriod, xmlMapping);
                break;
            case "RequestedDespatchPeriod":
                if (despatch.RequestedDespatchPeriod == null) return;
                GetField(despatch.RequestedDespatchPeriod, xmlMapping);
                break;

        }
    }
    public void GetField(DeliveryTermsType deliveryterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (deliveryterms.ID == null) return;
                GetField(deliveryterms.ID, xmlMapping);
                break;
            case "SpecialTerms":
                if (deliveryterms.SpecialTerms == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialTerms)
                {
                    foreach (var row in deliveryterms.SpecialTerms)
                    {
                        collMappingSpecialTerms.SetNewRowContext();

                        foreach (var colMapp in collMappingSpecialTerms.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(deliveryterms.SpecialTerms[0], xmlMapping);
                }
                break;
            case "LossRiskResponsibilityCode":
                if (deliveryterms.LossRiskResponsibilityCode == null) return;
                GetField(deliveryterms.LossRiskResponsibilityCode, xmlMapping);
                break;
            case "LossRisk":
                if (deliveryterms.LossRisk == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingLossRisk)
                {
                    foreach (var row in deliveryterms.LossRisk)
                    {
                        collMappingLossRisk.SetNewRowContext();

                        foreach (var colMapp in collMappingLossRisk.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(deliveryterms.LossRisk[0], xmlMapping);
                }
                break;
            case "Amount":
                if (deliveryterms.Amount == null) return;
                GetField(deliveryterms.Amount, xmlMapping);
                break;
            case "DeliveryLocation":
                if (deliveryterms.DeliveryLocation == null) return;
                GetField(deliveryterms.DeliveryLocation, xmlMapping);
                break;
            case "AllowanceCharge":
                if (deliveryterms.AllowanceCharge == null) return;
                GetField(deliveryterms.AllowanceCharge, xmlMapping);
                break;

        }
    }
    public void GetField(DeliveryUnitType minimumdeliveryunit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "BatchQuantity":
                if (minimumdeliveryunit.BatchQuantity == null) return;
                GetField(minimumdeliveryunit.BatchQuantity, xmlMapping);
                break;
            case "ConsumerUnitQuantity":
                if (minimumdeliveryunit.ConsumerUnitQuantity == null) return;
                GetField(minimumdeliveryunit.ConsumerUnitQuantity, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (minimumdeliveryunit.HazardousRiskIndicator == null) return;
                GetField(minimumdeliveryunit.HazardousRiskIndicator, xmlMapping);
                break;

        }
    }
    public void GetField(ShipmentType shipment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (shipment.ID == null) return;
                GetField(shipment.ID, xmlMapping);
                break;
            case "ShippingPriorityLevelCode":
                if (shipment.ShippingPriorityLevelCode == null) return;
                GetField(shipment.ShippingPriorityLevelCode, xmlMapping);
                break;
            case "HandlingCode":
                if (shipment.HandlingCode == null) return;
                GetField(shipment.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (shipment.HandlingInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions)
                {
                    foreach (var row in shipment.HandlingInstructions)
                    {
                        collMappingHandlingInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "Information":
                if (shipment.Information == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInformation)
                {
                    foreach (var row in shipment.Information)
                    {
                        collMappingInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.Information[0], xmlMapping);
                }
                break;
            case "GrossWeightMeasure":
                if (shipment.GrossWeightMeasure == null) return;
                GetField(shipment.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (shipment.NetWeightMeasure == null) return;
                GetField(shipment.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (shipment.NetNetWeightMeasure == null) return;
                GetField(shipment.NetNetWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (shipment.GrossVolumeMeasure == null) return;
                GetField(shipment.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (shipment.NetVolumeMeasure == null) return;
                GetField(shipment.NetVolumeMeasure, xmlMapping);
                break;
            case "TotalGoodsItemQuantity":
                if (shipment.TotalGoodsItemQuantity == null) return;
                GetField(shipment.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalTransportHandlingUnitQuantity":
                if (shipment.TotalTransportHandlingUnitQuantity == null) return;
                GetField(shipment.TotalTransportHandlingUnitQuantity, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (shipment.InsuranceValueAmount == null) return;
                GetField(shipment.InsuranceValueAmount, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (shipment.DeclaredCustomsValueAmount == null) return;
                GetField(shipment.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (shipment.DeclaredForCarriageValueAmount == null) return;
                GetField(shipment.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (shipment.DeclaredStatisticsValueAmount == null) return;
                GetField(shipment.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (shipment.FreeOnBoardValueAmount == null) return;
                GetField(shipment.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "SpecialInstructions":
                if (shipment.SpecialInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialInstructions)
                {
                    foreach (var row in shipment.SpecialInstructions)
                    {
                        collMappingSpecialInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingSpecialInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.SpecialInstructions[0], xmlMapping);
                }
                break;
            case "DeliveryInstructions":
                if (shipment.DeliveryInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryInstructions)
                {
                    foreach (var row in shipment.DeliveryInstructions)
                    {
                        collMappingDeliveryInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.DeliveryInstructions[0], xmlMapping);
                }
                break;
            case "SplitConsignmentIndicator":
                if (shipment.SplitConsignmentIndicator == null) return;
                GetField(shipment.SplitConsignmentIndicator, xmlMapping);
                break;
            case "ConsignmentQuantity":
                if (shipment.ConsignmentQuantity == null) return;
                GetField(shipment.ConsignmentQuantity, xmlMapping);
                break;
            case "Consignment":
                if (shipment.Consignment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingConsignment)
                {
                    foreach (var row in shipment.Consignment)
                    {
                        collMappingConsignment.SetNewRowContext();

                        foreach (var colMapp in collMappingConsignment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.Consignment[0], xmlMapping);
                }
                break;
            case "GoodsItem":
                if (shipment.GoodsItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem)
                {
                    foreach (var row in shipment.GoodsItem)
                    {
                        collMappingGoodsItem.SetNewRowContext();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.GoodsItem[0], xmlMapping);
                }
                break;
            case "ShipmentStage":
                if (shipment.ShipmentStage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentStage)
                {
                    foreach (var row in shipment.ShipmentStage)
                    {
                        collMappingShipmentStage.SetNewRowContext();

                        foreach (var colMapp in collMappingShipmentStage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.ShipmentStage[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (shipment.Delivery == null) return;
                GetField(shipment.Delivery, xmlMapping);
                break;
            case "TransportHandlingUnit":
                if (shipment.TransportHandlingUnit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportHandlingUnit)
                {
                    foreach (var row in shipment.TransportHandlingUnit)
                    {
                        collMappingTransportHandlingUnit.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportHandlingUnit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.TransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "ReturnAddress":
                if (shipment.ReturnAddress == null) return;
                GetField(shipment.ReturnAddress, xmlMapping);
                break;
            case "OriginAddress":
                if (shipment.OriginAddress == null) return;
                GetField(shipment.OriginAddress, xmlMapping);
                break;
            case "FirstArrivalPortLocation":
                if (shipment.FirstArrivalPortLocation == null) return;
                GetField(shipment.FirstArrivalPortLocation, xmlMapping);
                break;
            case "LastExitPortLocation":
                if (shipment.LastExitPortLocation == null) return;
                GetField(shipment.LastExitPortLocation, xmlMapping);
                break;
            case "ExportCountry":
                if (shipment.ExportCountry == null) return;
                GetField(shipment.ExportCountry, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (shipment.FreightAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge)
                {
                    foreach (var row in shipment.FreightAllowanceCharge)
                    {
                        collMappingFreightAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ConsignmentType consignment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (consignment.ID == null) return;
                GetField(consignment.ID, xmlMapping);
                break;
            case "CarrierAssignedID":
                if (consignment.CarrierAssignedID == null) return;
                GetField(consignment.CarrierAssignedID, xmlMapping);
                break;
            case "ConsigneeAssignedID":
                if (consignment.ConsigneeAssignedID == null) return;
                GetField(consignment.ConsigneeAssignedID, xmlMapping);
                break;
            case "ConsignorAssignedID":
                if (consignment.ConsignorAssignedID == null) return;
                GetField(consignment.ConsignorAssignedID, xmlMapping);
                break;
            case "FreightForwarderAssignedID":
                if (consignment.FreightForwarderAssignedID == null) return;
                GetField(consignment.FreightForwarderAssignedID, xmlMapping);
                break;
            case "BrokerAssignedID":
                if (consignment.BrokerAssignedID == null) return;
                GetField(consignment.BrokerAssignedID, xmlMapping);
                break;
            case "ContractedCarrierAssignedID":
                if (consignment.ContractedCarrierAssignedID == null) return;
                GetField(consignment.ContractedCarrierAssignedID, xmlMapping);
                break;
            case "PerformingCarrierAssignedID":
                if (consignment.PerformingCarrierAssignedID == null) return;
                GetField(consignment.PerformingCarrierAssignedID, xmlMapping);
                break;
            case "SummaryDescription":
                if (consignment.SummaryDescription == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSummaryDescription)
                {
                    foreach (var row in consignment.SummaryDescription)
                    {
                        collMappingSummaryDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingSummaryDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.SummaryDescription[0], xmlMapping);
                }
                break;
            case "TotalInvoiceAmount":
                if (consignment.TotalInvoiceAmount == null) return;
                GetField(consignment.TotalInvoiceAmount, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (consignment.DeclaredCustomsValueAmount == null) return;
                GetField(consignment.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "TariffDescription":
                if (consignment.TariffDescription == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTariffDescription)
                {
                    foreach (var row in consignment.TariffDescription)
                    {
                        collMappingTariffDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingTariffDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.TariffDescription[0], xmlMapping);
                }
                break;
            case "TariffCode":
                if (consignment.TariffCode == null) return;
                GetField(consignment.TariffCode, xmlMapping);
                break;
            case "InsurancePremiumAmount":
                if (consignment.InsurancePremiumAmount == null) return;
                GetField(consignment.InsurancePremiumAmount, xmlMapping);
                break;
            case "GrossWeightMeasure":
                if (consignment.GrossWeightMeasure == null) return;
                GetField(consignment.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (consignment.NetWeightMeasure == null) return;
                GetField(consignment.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (consignment.NetNetWeightMeasure == null) return;
                GetField(consignment.NetNetWeightMeasure, xmlMapping);
                break;
            case "ChargeableWeightMeasure":
                if (consignment.ChargeableWeightMeasure == null) return;
                GetField(consignment.ChargeableWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (consignment.GrossVolumeMeasure == null) return;
                GetField(consignment.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (consignment.NetVolumeMeasure == null) return;
                GetField(consignment.NetVolumeMeasure, xmlMapping);
                break;
            case "LoadingLengthMeasure":
                if (consignment.LoadingLengthMeasure == null) return;
                GetField(consignment.LoadingLengthMeasure, xmlMapping);
                break;
            case "Remarks":
                if (consignment.Remarks == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingRemarks)
                {
                    foreach (var row in consignment.Remarks)
                    {
                        collMappingRemarks.SetNewRowContext();

                        foreach (var colMapp in collMappingRemarks.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.Remarks[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (consignment.HazardousRiskIndicator == null) return;
                GetField(consignment.HazardousRiskIndicator, xmlMapping);
                break;
            case "AnimalFoodIndicator":
                if (consignment.AnimalFoodIndicator == null) return;
                GetField(consignment.AnimalFoodIndicator, xmlMapping);
                break;
            case "HumanFoodIndicator":
                if (consignment.HumanFoodIndicator == null) return;
                GetField(consignment.HumanFoodIndicator, xmlMapping);
                break;
            case "LivestockIndicator":
                if (consignment.LivestockIndicator == null) return;
                GetField(consignment.LivestockIndicator, xmlMapping);
                break;
            case "BulkCargoIndicator":
                if (consignment.BulkCargoIndicator == null) return;
                GetField(consignment.BulkCargoIndicator, xmlMapping);
                break;
            case "ContainerizedIndicator":
                if (consignment.ContainerizedIndicator == null) return;
                GetField(consignment.ContainerizedIndicator, xmlMapping);
                break;
            case "GeneralCargoIndicator":
                if (consignment.GeneralCargoIndicator == null) return;
                GetField(consignment.GeneralCargoIndicator, xmlMapping);
                break;
            case "SpecialSecurityIndicator":
                if (consignment.SpecialSecurityIndicator == null) return;
                GetField(consignment.SpecialSecurityIndicator, xmlMapping);
                break;
            case "ThirdPartyPayerIndicator":
                if (consignment.ThirdPartyPayerIndicator == null) return;
                GetField(consignment.ThirdPartyPayerIndicator, xmlMapping);
                break;
            case "CarrierServiceInstructions":
                if (consignment.CarrierServiceInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCarrierServiceInstructions)
                {
                    foreach (var row in consignment.CarrierServiceInstructions)
                    {
                        collMappingCarrierServiceInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingCarrierServiceInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.CarrierServiceInstructions[0], xmlMapping);
                }
                break;
            case "CustomsClearanceServiceInstructions":
                if (consignment.CustomsClearanceServiceInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsClearanceServiceInstructions)
                {
                    foreach (var row in consignment.CustomsClearanceServiceInstructions)
                    {
                        collMappingCustomsClearanceServiceInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingCustomsClearanceServiceInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.CustomsClearanceServiceInstructions[0], xmlMapping);
                }
                break;
            case "ForwarderServiceInstructions":
                if (consignment.ForwarderServiceInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingForwarderServiceInstructions)
                {
                    foreach (var row in consignment.ForwarderServiceInstructions)
                    {
                        collMappingForwarderServiceInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingForwarderServiceInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.ForwarderServiceInstructions[0], xmlMapping);
                }
                break;
            case "SpecialServiceInstructions":
                if (consignment.SpecialServiceInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialServiceInstructions)
                {
                    foreach (var row in consignment.SpecialServiceInstructions)
                    {
                        collMappingSpecialServiceInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingSpecialServiceInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.SpecialServiceInstructions[0], xmlMapping);
                }
                break;
            case "SequenceID":
                if (consignment.SequenceID == null) return;
                GetField(consignment.SequenceID, xmlMapping);
                break;
            case "ShippingPriorityLevelCode":
                if (consignment.ShippingPriorityLevelCode == null) return;
                GetField(consignment.ShippingPriorityLevelCode, xmlMapping);
                break;
            case "HandlingCode":
                if (consignment.HandlingCode == null) return;
                GetField(consignment.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (consignment.HandlingInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions)
                {
                    foreach (var row in consignment.HandlingInstructions)
                    {
                        collMappingHandlingInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "Information":
                if (consignment.Information == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInformation)
                {
                    foreach (var row in consignment.Information)
                    {
                        collMappingInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.Information[0], xmlMapping);
                }
                break;
            case "TotalGoodsItemQuantity":
                if (consignment.TotalGoodsItemQuantity == null) return;
                GetField(consignment.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalTransportHandlingUnitQuantity":
                if (consignment.TotalTransportHandlingUnitQuantity == null) return;
                GetField(consignment.TotalTransportHandlingUnitQuantity, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (consignment.InsuranceValueAmount == null) return;
                GetField(consignment.InsuranceValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (consignment.DeclaredForCarriageValueAmount == null) return;
                GetField(consignment.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (consignment.DeclaredStatisticsValueAmount == null) return;
                GetField(consignment.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (consignment.FreeOnBoardValueAmount == null) return;
                GetField(consignment.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "SpecialInstructions":
                if (consignment.SpecialInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialInstructions)
                {
                    foreach (var row in consignment.SpecialInstructions)
                    {
                        collMappingSpecialInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingSpecialInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.SpecialInstructions[0], xmlMapping);
                }
                break;
            case "SplitConsignmentIndicator":
                if (consignment.SplitConsignmentIndicator == null) return;
                GetField(consignment.SplitConsignmentIndicator, xmlMapping);
                break;
            case "DeliveryInstructions":
                if (consignment.DeliveryInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryInstructions)
                {
                    foreach (var row in consignment.DeliveryInstructions)
                    {
                        collMappingDeliveryInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.DeliveryInstructions[0], xmlMapping);
                }
                break;
            case "ConsignmentQuantity":
                if (consignment.ConsignmentQuantity == null) return;
                GetField(consignment.ConsignmentQuantity, xmlMapping);
                break;
            case "ConsolidatableIndicator":
                if (consignment.ConsolidatableIndicator == null) return;
                GetField(consignment.ConsolidatableIndicator, xmlMapping);
                break;
            case "HaulageInstructions":
                if (consignment.HaulageInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHaulageInstructions)
                {
                    foreach (var row in consignment.HaulageInstructions)
                    {
                        collMappingHaulageInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingHaulageInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.HaulageInstructions[0], xmlMapping);
                }
                break;
            case "LoadingSequenceID":
                if (consignment.LoadingSequenceID == null) return;
                GetField(consignment.LoadingSequenceID, xmlMapping);
                break;
            case "ChildConsignmentQuantity":
                if (consignment.ChildConsignmentQuantity == null) return;
                GetField(consignment.ChildConsignmentQuantity, xmlMapping);
                break;
            case "TotalPackagesQuantity":
                if (consignment.TotalPackagesQuantity == null) return;
                GetField(consignment.TotalPackagesQuantity, xmlMapping);
                break;
            case "ConsolidatedShipment":
                if (consignment.ConsolidatedShipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingConsolidatedShipment)
                {
                    foreach (var row in consignment.ConsolidatedShipment)
                    {
                        collMappingConsolidatedShipment.SetNewRowContext();

                        foreach (var colMapp in collMappingConsolidatedShipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.ConsolidatedShipment[0], xmlMapping);
                }
                break;
            case "CustomsDeclaration":
                if (consignment.CustomsDeclaration == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsDeclaration)
                {
                    foreach (var row in consignment.CustomsDeclaration)
                    {
                        collMappingCustomsDeclaration.SetNewRowContext();

                        foreach (var colMapp in collMappingCustomsDeclaration.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.CustomsDeclaration[0], xmlMapping);
                }
                break;
            case "RequestedPickupTransportEvent":
                if (consignment.RequestedPickupTransportEvent == null) return;
                GetField(consignment.RequestedPickupTransportEvent, xmlMapping);
                break;
            case "RequestedDeliveryTransportEvent":
                if (consignment.RequestedDeliveryTransportEvent == null) return;
                GetField(consignment.RequestedDeliveryTransportEvent, xmlMapping);
                break;
            case "PlannedPickupTransportEvent":
                if (consignment.PlannedPickupTransportEvent == null) return;
                GetField(consignment.PlannedPickupTransportEvent, xmlMapping);
                break;
            case "PlannedDeliveryTransportEvent":
                if (consignment.PlannedDeliveryTransportEvent == null) return;
                GetField(consignment.PlannedDeliveryTransportEvent, xmlMapping);
                break;
            case "Status":
                if (consignment.Status == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingStatus)
                {
                    foreach (var row in consignment.Status)
                    {
                        collMappingStatus.SetNewRowContext();

                        foreach (var colMapp in collMappingStatus.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.Status[0], xmlMapping);
                }
                break;
            case "ChildConsignment":
                if (consignment.ChildConsignment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingChildConsignment)
                {
                    foreach (var row in consignment.ChildConsignment)
                    {
                        collMappingChildConsignment.SetNewRowContext();

                        foreach (var colMapp in collMappingChildConsignment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.ChildConsignment[0], xmlMapping);
                }
                break;
            case "ConsigneeParty":
                if (consignment.ConsigneeParty == null) return;
                GetField(consignment.ConsigneeParty, xmlMapping);
                break;
            case "ExporterParty":
                if (consignment.ExporterParty == null) return;
                GetField(consignment.ExporterParty, xmlMapping);
                break;
            case "ConsignorParty":
                if (consignment.ConsignorParty == null) return;
                GetField(consignment.ConsignorParty, xmlMapping);
                break;
            case "ImporterParty":
                if (consignment.ImporterParty == null) return;
                GetField(consignment.ImporterParty, xmlMapping);
                break;
            case "CarrierParty":
                if (consignment.CarrierParty == null) return;
                GetField(consignment.CarrierParty, xmlMapping);
                break;
            case "FreightForwarderParty":
                if (consignment.FreightForwarderParty == null) return;
                GetField(consignment.FreightForwarderParty, xmlMapping);
                break;
            case "NotifyParty":
                if (consignment.NotifyParty == null) return;
                GetField(consignment.NotifyParty, xmlMapping);
                break;
            case "OriginalDespatchParty":
                if (consignment.OriginalDespatchParty == null) return;
                GetField(consignment.OriginalDespatchParty, xmlMapping);
                break;
            case "FinalDeliveryParty":
                if (consignment.FinalDeliveryParty == null) return;
                GetField(consignment.FinalDeliveryParty, xmlMapping);
                break;
            case "PerformingCarrierParty":
                if (consignment.PerformingCarrierParty == null) return;
                GetField(consignment.PerformingCarrierParty, xmlMapping);
                break;
            case "SubstituteCarrierParty":
                if (consignment.SubstituteCarrierParty == null) return;
                GetField(consignment.SubstituteCarrierParty, xmlMapping);
                break;
            case "LogisticsOperatorParty":
                if (consignment.LogisticsOperatorParty == null) return;
                GetField(consignment.LogisticsOperatorParty, xmlMapping);
                break;
            case "TransportAdvisorParty":
                if (consignment.TransportAdvisorParty == null) return;
                GetField(consignment.TransportAdvisorParty, xmlMapping);
                break;
            case "HazardousItemNotificationParty":
                if (consignment.HazardousItemNotificationParty == null) return;
                GetField(consignment.HazardousItemNotificationParty, xmlMapping);
                break;
            case "InsuranceParty":
                if (consignment.InsuranceParty == null) return;
                GetField(consignment.InsuranceParty, xmlMapping);
                break;
            case "MortgageHolderParty":
                if (consignment.MortgageHolderParty == null) return;
                GetField(consignment.MortgageHolderParty, xmlMapping);
                break;
            case "BillOfLadingHolderParty":
                if (consignment.BillOfLadingHolderParty == null) return;
                GetField(consignment.BillOfLadingHolderParty, xmlMapping);
                break;
            case "OriginalDepartureCountry":
                if (consignment.OriginalDepartureCountry == null) return;
                GetField(consignment.OriginalDepartureCountry, xmlMapping);
                break;
            case "FinalDestinationCountry":
                if (consignment.FinalDestinationCountry == null) return;
                GetField(consignment.FinalDestinationCountry, xmlMapping);
                break;
            case "TransitCountry":
                if (consignment.TransitCountry == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransitCountry)
                {
                    foreach (var row in consignment.TransitCountry)
                    {
                        collMappingTransitCountry.SetNewRowContext();

                        foreach (var colMapp in collMappingTransitCountry.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.TransitCountry[0], xmlMapping);
                }
                break;
            case "TransportContract":
                if (consignment.TransportContract == null) return;
                GetField(consignment.TransportContract, xmlMapping);
                break;
            case "TransportEvent":
                if (consignment.TransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent)
                {
                    foreach (var row in consignment.TransportEvent)
                    {
                        collMappingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.TransportEvent[0], xmlMapping);
                }
                break;
            case "OriginalDespatchTransportationService":
                if (consignment.OriginalDespatchTransportationService == null) return;
                GetField(consignment.OriginalDespatchTransportationService, xmlMapping);
                break;
            case "FinalDeliveryTransportationService":
                if (consignment.FinalDeliveryTransportationService == null) return;
                GetField(consignment.FinalDeliveryTransportationService, xmlMapping);
                break;
            case "DeliveryTerms":
                if (consignment.DeliveryTerms == null) return;
                GetField(consignment.DeliveryTerms, xmlMapping);
                break;
            case "PaymentTerms":
                if (consignment.PaymentTerms == null) return;
                GetField(consignment.PaymentTerms, xmlMapping);
                break;
            case "CollectPaymentTerms":
                if (consignment.CollectPaymentTerms == null) return;
                GetField(consignment.CollectPaymentTerms, xmlMapping);
                break;
            case "DisbursementPaymentTerms":
                if (consignment.DisbursementPaymentTerms == null) return;
                GetField(consignment.DisbursementPaymentTerms, xmlMapping);
                break;
            case "PrepaidPaymentTerms":
                if (consignment.PrepaidPaymentTerms == null) return;
                GetField(consignment.PrepaidPaymentTerms, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (consignment.FreightAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge)
                {
                    foreach (var row in consignment.FreightAllowanceCharge)
                    {
                        collMappingFreightAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "ExtraAllowanceCharge":
                if (consignment.ExtraAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingExtraAllowanceCharge)
                {
                    foreach (var row in consignment.ExtraAllowanceCharge)
                    {
                        collMappingExtraAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingExtraAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.ExtraAllowanceCharge[0], xmlMapping);
                }
                break;
            case "MainCarriageShipmentStage":
                if (consignment.MainCarriageShipmentStage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMainCarriageShipmentStage)
                {
                    foreach (var row in consignment.MainCarriageShipmentStage)
                    {
                        collMappingMainCarriageShipmentStage.SetNewRowContext();

                        foreach (var colMapp in collMappingMainCarriageShipmentStage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.MainCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "PreCarriageShipmentStage":
                if (consignment.PreCarriageShipmentStage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPreCarriageShipmentStage)
                {
                    foreach (var row in consignment.PreCarriageShipmentStage)
                    {
                        collMappingPreCarriageShipmentStage.SetNewRowContext();

                        foreach (var colMapp in collMappingPreCarriageShipmentStage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.PreCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "OnCarriageShipmentStage":
                if (consignment.OnCarriageShipmentStage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOnCarriageShipmentStage)
                {
                    foreach (var row in consignment.OnCarriageShipmentStage)
                    {
                        collMappingOnCarriageShipmentStage.SetNewRowContext();

                        foreach (var colMapp in collMappingOnCarriageShipmentStage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.OnCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "TransportHandlingUnit":
                if (consignment.TransportHandlingUnit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportHandlingUnit)
                {
                    foreach (var row in consignment.TransportHandlingUnit)
                    {
                        collMappingTransportHandlingUnit.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportHandlingUnit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(consignment.TransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "FirstArrivalPortLocation":
                if (consignment.FirstArrivalPortLocation == null) return;
                GetField(consignment.FirstArrivalPortLocation, xmlMapping);
                break;
            case "LastExitPortLocation":
                if (consignment.LastExitPortLocation == null) return;
                GetField(consignment.LastExitPortLocation, xmlMapping);
                break;

        }
    }
    public void GetField(CustomsDeclarationType customsdeclaration, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (customsdeclaration.ID == null) return;
                GetField(customsdeclaration.ID, xmlMapping);
                break;
            case "IssuerParty":
                if (customsdeclaration.IssuerParty == null) return;
                GetField(customsdeclaration.IssuerParty, xmlMapping);
                break;

        }
    }
    public void GetField(TransportEventType requestedpickuptransportevent, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "IdentificationID":
                if (requestedpickuptransportevent.IdentificationID == null) return;
                GetField(requestedpickuptransportevent.IdentificationID, xmlMapping);
                break;
            case "OccurrenceDate":
                if (requestedpickuptransportevent.OccurrenceDate == null) return;
                GetField(requestedpickuptransportevent.OccurrenceDate, xmlMapping);
                break;
            case "OccurrenceTime":
                if (requestedpickuptransportevent.OccurrenceTime == null) return;
                GetField(requestedpickuptransportevent.OccurrenceTime, xmlMapping);
                break;
            case "TransportEventTypeCode":
                if (requestedpickuptransportevent.TransportEventTypeCode == null) return;
                GetField(requestedpickuptransportevent.TransportEventTypeCode, xmlMapping);
                break;
            case "Description":
                if (requestedpickuptransportevent.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in requestedpickuptransportevent.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(requestedpickuptransportevent.Description[0], xmlMapping);
                }
                break;
            case "CompletionIndicator":
                if (requestedpickuptransportevent.CompletionIndicator == null) return;
                GetField(requestedpickuptransportevent.CompletionIndicator, xmlMapping);
                break;
            case "ReportedShipment":
                if (requestedpickuptransportevent.ReportedShipment == null) return;
                GetField(requestedpickuptransportevent.ReportedShipment, xmlMapping);
                break;
            case "CurrentStatus":
                if (requestedpickuptransportevent.CurrentStatus == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCurrentStatus)
                {
                    foreach (var row in requestedpickuptransportevent.CurrentStatus)
                    {
                        collMappingCurrentStatus.SetNewRowContext();

                        foreach (var colMapp in collMappingCurrentStatus.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(requestedpickuptransportevent.CurrentStatus[0], xmlMapping);
                }
                break;
            case "Contact":
                if (requestedpickuptransportevent.Contact == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContact)
                {
                    foreach (var row in requestedpickuptransportevent.Contact)
                    {
                        collMappingContact.SetNewRowContext();

                        foreach (var colMapp in collMappingContact.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(requestedpickuptransportevent.Contact[0], xmlMapping);
                }
                break;
            case "Location":
                if (requestedpickuptransportevent.Location == null) return;
                GetField(requestedpickuptransportevent.Location, xmlMapping);
                break;
            case "Signature":
                if (requestedpickuptransportevent.Signature == null) return;
                GetField(requestedpickuptransportevent.Signature, xmlMapping);
                break;
            case "Period":
                if (requestedpickuptransportevent.Period == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPeriod)
                {
                    foreach (var row in requestedpickuptransportevent.Period)
                    {
                        collMappingPeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingPeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(requestedpickuptransportevent.Period[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(StatusType currentstatus, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ConditionCode":
                if (currentstatus.ConditionCode == null) return;
                GetField(currentstatus.ConditionCode, xmlMapping);
                break;
            case "ReferenceDate":
                if (currentstatus.ReferenceDate == null) return;
                GetField(currentstatus.ReferenceDate, xmlMapping);
                break;
            case "ReferenceTime":
                if (currentstatus.ReferenceTime == null) return;
                GetField(currentstatus.ReferenceTime, xmlMapping);
                break;
            case "Description":
                if (currentstatus.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in currentstatus.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(currentstatus.Description[0], xmlMapping);
                }
                break;
            case "StatusReasonCode":
                if (currentstatus.StatusReasonCode == null) return;
                GetField(currentstatus.StatusReasonCode, xmlMapping);
                break;
            case "StatusReason":
                if (currentstatus.StatusReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingStatusReason)
                {
                    foreach (var row in currentstatus.StatusReason)
                    {
                        collMappingStatusReason.SetNewRowContext();

                        foreach (var colMapp in collMappingStatusReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(currentstatus.StatusReason[0], xmlMapping);
                }
                break;
            case "SequenceID":
                if (currentstatus.SequenceID == null) return;
                GetField(currentstatus.SequenceID, xmlMapping);
                break;
            case "Text":
                if (currentstatus.Text == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingText)
                {
                    foreach (var row in currentstatus.Text)
                    {
                        collMappingText.SetNewRowContext();

                        foreach (var colMapp in collMappingText.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(currentstatus.Text[0], xmlMapping);
                }
                break;
            case "IndicationIndicator":
                if (currentstatus.IndicationIndicator == null) return;
                GetField(currentstatus.IndicationIndicator, xmlMapping);
                break;
            case "Percent":
                if (currentstatus.Percent == null) return;
                GetField(currentstatus.Percent, xmlMapping);
                break;
            case "ReliabilityPercent":
                if (currentstatus.ReliabilityPercent == null) return;
                GetField(currentstatus.ReliabilityPercent, xmlMapping);
                break;
            case "Condition":
                if (currentstatus.Condition == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCondition)
                {
                    foreach (var row in currentstatus.Condition)
                    {
                        collMappingCondition.SetNewRowContext();

                        foreach (var colMapp in collMappingCondition.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(currentstatus.Condition[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ConditionType1 condition, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (condition.AttributeID == null) return;
                GetField(condition.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (condition.Measure == null) return;
                GetField(condition.Measure, xmlMapping);
                break;
            case "Description":
                if (condition.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in condition.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(condition.Description[0], xmlMapping);
                }
                break;
            case "MinimumMeasure":
                if (condition.MinimumMeasure == null) return;
                GetField(condition.MinimumMeasure, xmlMapping);
                break;
            case "MaximumMeasure":
                if (condition.MaximumMeasure == null) return;
                GetField(condition.MaximumMeasure, xmlMapping);
                break;

        }
    }
    public void GetField(ContractType transportcontract, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportcontract.ID == null) return;
                GetField(transportcontract.ID, xmlMapping);
                break;
            case "IssueDate":
                if (transportcontract.IssueDate == null) return;
                GetField(transportcontract.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (transportcontract.IssueTime == null) return;
                GetField(transportcontract.IssueTime, xmlMapping);
                break;
            case "NominationDate":
                if (transportcontract.NominationDate == null) return;
                GetField(transportcontract.NominationDate, xmlMapping);
                break;
            case "NominationTime":
                if (transportcontract.NominationTime == null) return;
                GetField(transportcontract.NominationTime, xmlMapping);
                break;
            case "ContractTypeCode":
                if (transportcontract.ContractTypeCode == null) return;
                GetField(transportcontract.ContractTypeCode, xmlMapping);
                break;
            case "ContractType1":
                if (transportcontract.ContractType1 == null) return;
                GetField(transportcontract.ContractType1, xmlMapping);
                break;
            case "Note":
                if (transportcontract.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in transportcontract.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportcontract.Note[0], xmlMapping);
                }
                break;
            case "VersionID":
                if (transportcontract.VersionID == null) return;
                GetField(transportcontract.VersionID, xmlMapping);
                break;
            case "Description":
                if (transportcontract.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in transportcontract.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportcontract.Description[0], xmlMapping);
                }
                break;
            case "ValidityPeriod":
                if (transportcontract.ValidityPeriod == null) return;
                GetField(transportcontract.ValidityPeriod, xmlMapping);
                break;
            case "ContractDocumentReference":
                if (transportcontract.ContractDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference)
                {
                    foreach (var row in transportcontract.ContractDocumentReference)
                    {
                        collMappingContractDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportcontract.ContractDocumentReference[0], xmlMapping);
                }
                break;
            case "NominationPeriod":
                if (transportcontract.NominationPeriod == null) return;
                GetField(transportcontract.NominationPeriod, xmlMapping);
                break;
            case "ContractualDelivery":
                if (transportcontract.ContractualDelivery == null) return;
                GetField(transportcontract.ContractualDelivery, xmlMapping);
                break;

        }
    }
    public void GetField(TransportationServiceType originaldespatchtransportationservice, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TransportServiceCode":
                if (originaldespatchtransportationservice.TransportServiceCode == null) return;
                GetField(originaldespatchtransportationservice.TransportServiceCode, xmlMapping);
                break;
            case "TariffClassCode":
                if (originaldespatchtransportationservice.TariffClassCode == null) return;
                GetField(originaldespatchtransportationservice.TariffClassCode, xmlMapping);
                break;
            case "Priority":
                if (originaldespatchtransportationservice.Priority == null) return;
                GetField(originaldespatchtransportationservice.Priority, xmlMapping);
                break;
            case "FreightRateClassCode":
                if (originaldespatchtransportationservice.FreightRateClassCode == null) return;
                GetField(originaldespatchtransportationservice.FreightRateClassCode, xmlMapping);
                break;
            case "TransportationServiceDescription":
                if (originaldespatchtransportationservice.TransportationServiceDescription == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportationServiceDescription)
                {
                    foreach (var row in originaldespatchtransportationservice.TransportationServiceDescription)
                    {
                        collMappingTransportationServiceDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportationServiceDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.TransportationServiceDescription[0], xmlMapping);
                }
                break;
            case "TransportationServiceDetailsURI":
                if (originaldespatchtransportationservice.TransportationServiceDetailsURI == null) return;
                GetField(originaldespatchtransportationservice.TransportationServiceDetailsURI, xmlMapping);
                break;
            case "NominationDate":
                if (originaldespatchtransportationservice.NominationDate == null) return;
                GetField(originaldespatchtransportationservice.NominationDate, xmlMapping);
                break;
            case "NominationTime":
                if (originaldespatchtransportationservice.NominationTime == null) return;
                GetField(originaldespatchtransportationservice.NominationTime, xmlMapping);
                break;
            case "Name":
                if (originaldespatchtransportationservice.Name == null) return;
                GetField(originaldespatchtransportationservice.Name, xmlMapping);
                break;
            case "SequenceNumeric":
                if (originaldespatchtransportationservice.SequenceNumeric == null) return;
                GetField(originaldespatchtransportationservice.SequenceNumeric, xmlMapping);
                break;
            case "TransportEquipment":
                if (originaldespatchtransportationservice.TransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment)
                {
                    foreach (var row in originaldespatchtransportationservice.TransportEquipment)
                    {
                        collMappingTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.TransportEquipment[0], xmlMapping);
                }
                break;
            case "SupportedTransportEquipment":
                if (originaldespatchtransportationservice.SupportedTransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSupportedTransportEquipment)
                {
                    foreach (var row in originaldespatchtransportationservice.SupportedTransportEquipment)
                    {
                        collMappingSupportedTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingSupportedTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.SupportedTransportEquipment[0], xmlMapping);
                }
                break;
            case "UnsupportedTransportEquipment":
                if (originaldespatchtransportationservice.UnsupportedTransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingUnsupportedTransportEquipment)
                {
                    foreach (var row in originaldespatchtransportationservice.UnsupportedTransportEquipment)
                    {
                        collMappingUnsupportedTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingUnsupportedTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.UnsupportedTransportEquipment[0], xmlMapping);
                }
                break;
            case "CommodityClassification":
                if (originaldespatchtransportationservice.CommodityClassification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCommodityClassification)
                {
                    foreach (var row in originaldespatchtransportationservice.CommodityClassification)
                    {
                        collMappingCommodityClassification.SetNewRowContext();

                        foreach (var colMapp in collMappingCommodityClassification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.CommodityClassification[0], xmlMapping);
                }
                break;
            case "SupportedCommodityClassification":
                if (originaldespatchtransportationservice.SupportedCommodityClassification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSupportedCommodityClassification)
                {
                    foreach (var row in originaldespatchtransportationservice.SupportedCommodityClassification)
                    {
                        collMappingSupportedCommodityClassification.SetNewRowContext();

                        foreach (var colMapp in collMappingSupportedCommodityClassification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.SupportedCommodityClassification[0], xmlMapping);
                }
                break;
            case "UnsupportedCommodityClassification":
                if (originaldespatchtransportationservice.UnsupportedCommodityClassification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingUnsupportedCommodityClassification)
                {
                    foreach (var row in originaldespatchtransportationservice.UnsupportedCommodityClassification)
                    {
                        collMappingUnsupportedCommodityClassification.SetNewRowContext();

                        foreach (var colMapp in collMappingUnsupportedCommodityClassification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.UnsupportedCommodityClassification[0], xmlMapping);
                }
                break;
            case "TotalCapacityDimension":
                if (originaldespatchtransportationservice.TotalCapacityDimension == null) return;
                GetField(originaldespatchtransportationservice.TotalCapacityDimension, xmlMapping);
                break;
            case "ShipmentStage":
                if (originaldespatchtransportationservice.ShipmentStage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentStage)
                {
                    foreach (var row in originaldespatchtransportationservice.ShipmentStage)
                    {
                        collMappingShipmentStage.SetNewRowContext();

                        foreach (var colMapp in collMappingShipmentStage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.ShipmentStage[0], xmlMapping);
                }
                break;
            case "TransportEvent":
                if (originaldespatchtransportationservice.TransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent)
                {
                    foreach (var row in originaldespatchtransportationservice.TransportEvent)
                    {
                        collMappingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.TransportEvent[0], xmlMapping);
                }
                break;
            case "ResponsibleTransportServiceProviderParty":
                if (originaldespatchtransportationservice.ResponsibleTransportServiceProviderParty == null) return;
                GetField(originaldespatchtransportationservice.ResponsibleTransportServiceProviderParty, xmlMapping);
                break;
            case "EnvironmentalEmission":
                if (originaldespatchtransportationservice.EnvironmentalEmission == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingEnvironmentalEmission)
                {
                    foreach (var row in originaldespatchtransportationservice.EnvironmentalEmission)
                    {
                        collMappingEnvironmentalEmission.SetNewRowContext();

                        foreach (var colMapp in collMappingEnvironmentalEmission.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.EnvironmentalEmission[0], xmlMapping);
                }
                break;
            case "EstimatedDurationPeriod":
                if (originaldespatchtransportationservice.EstimatedDurationPeriod == null) return;
                GetField(originaldespatchtransportationservice.EstimatedDurationPeriod, xmlMapping);
                break;
            case "ScheduledServiceFrequency":
                if (originaldespatchtransportationservice.ScheduledServiceFrequency == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingScheduledServiceFrequency)
                {
                    foreach (var row in originaldespatchtransportationservice.ScheduledServiceFrequency)
                    {
                        collMappingScheduledServiceFrequency.SetNewRowContext();

                        foreach (var colMapp in collMappingScheduledServiceFrequency.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originaldespatchtransportationservice.ScheduledServiceFrequency[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(TransportEquipmentType transportequipment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportequipment.ID == null) return;
                GetField(transportequipment.ID, xmlMapping);
                break;
            case "ReferencedConsignmentID":
                if (transportequipment.ReferencedConsignmentID == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingReferencedConsignmentID)
                {
                    foreach (var row in transportequipment.ReferencedConsignmentID)
                    {
                        collMappingReferencedConsignmentID.SetNewRowContext();

                        foreach (var colMapp in collMappingReferencedConsignmentID.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.ReferencedConsignmentID[0], xmlMapping);
                }
                break;
            case "TransportEquipmentTypeCode":
                if (transportequipment.TransportEquipmentTypeCode == null) return;
                GetField(transportequipment.TransportEquipmentTypeCode, xmlMapping);
                break;
            case "ProviderTypeCode":
                if (transportequipment.ProviderTypeCode == null) return;
                GetField(transportequipment.ProviderTypeCode, xmlMapping);
                break;
            case "OwnerTypeCode":
                if (transportequipment.OwnerTypeCode == null) return;
                GetField(transportequipment.OwnerTypeCode, xmlMapping);
                break;
            case "SizeTypeCode":
                if (transportequipment.SizeTypeCode == null) return;
                GetField(transportequipment.SizeTypeCode, xmlMapping);
                break;
            case "DispositionCode":
                if (transportequipment.DispositionCode == null) return;
                GetField(transportequipment.DispositionCode, xmlMapping);
                break;
            case "FullnessIndicationCode":
                if (transportequipment.FullnessIndicationCode == null) return;
                GetField(transportequipment.FullnessIndicationCode, xmlMapping);
                break;
            case "RefrigerationOnIndicator":
                if (transportequipment.RefrigerationOnIndicator == null) return;
                GetField(transportequipment.RefrigerationOnIndicator, xmlMapping);
                break;
            case "Information":
                if (transportequipment.Information == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInformation)
                {
                    foreach (var row in transportequipment.Information)
                    {
                        collMappingInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.Information[0], xmlMapping);
                }
                break;
            case "ReturnabilityIndicator":
                if (transportequipment.ReturnabilityIndicator == null) return;
                GetField(transportequipment.ReturnabilityIndicator, xmlMapping);
                break;
            case "LegalStatusIndicator":
                if (transportequipment.LegalStatusIndicator == null) return;
                GetField(transportequipment.LegalStatusIndicator, xmlMapping);
                break;
            case "AirFlowPercent":
                if (transportequipment.AirFlowPercent == null) return;
                GetField(transportequipment.AirFlowPercent, xmlMapping);
                break;
            case "HumidityPercent":
                if (transportequipment.HumidityPercent == null) return;
                GetField(transportequipment.HumidityPercent, xmlMapping);
                break;
            case "AnimalFoodApprovedIndicator":
                if (transportequipment.AnimalFoodApprovedIndicator == null) return;
                GetField(transportequipment.AnimalFoodApprovedIndicator, xmlMapping);
                break;
            case "HumanFoodApprovedIndicator":
                if (transportequipment.HumanFoodApprovedIndicator == null) return;
                GetField(transportequipment.HumanFoodApprovedIndicator, xmlMapping);
                break;
            case "DangerousGoodsApprovedIndicator":
                if (transportequipment.DangerousGoodsApprovedIndicator == null) return;
                GetField(transportequipment.DangerousGoodsApprovedIndicator, xmlMapping);
                break;
            case "RefrigeratedIndicator":
                if (transportequipment.RefrigeratedIndicator == null) return;
                GetField(transportequipment.RefrigeratedIndicator, xmlMapping);
                break;
            case "Characteristics":
                if (transportequipment.Characteristics == null) return;
                GetField(transportequipment.Characteristics, xmlMapping);
                break;
            case "DamageRemarks":
                if (transportequipment.DamageRemarks == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDamageRemarks)
                {
                    foreach (var row in transportequipment.DamageRemarks)
                    {
                        collMappingDamageRemarks.SetNewRowContext();

                        foreach (var colMapp in collMappingDamageRemarks.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.DamageRemarks[0], xmlMapping);
                }
                break;
            case "Description":
                if (transportequipment.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in transportequipment.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.Description[0], xmlMapping);
                }
                break;
            case "SpecialTransportRequirements":
                if (transportequipment.SpecialTransportRequirements == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialTransportRequirements)
                {
                    foreach (var row in transportequipment.SpecialTransportRequirements)
                    {
                        collMappingSpecialTransportRequirements.SetNewRowContext();

                        foreach (var colMapp in collMappingSpecialTransportRequirements.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.SpecialTransportRequirements[0], xmlMapping);
                }
                break;
            case "GrossWeightMeasure":
                if (transportequipment.GrossWeightMeasure == null) return;
                GetField(transportequipment.GrossWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (transportequipment.GrossVolumeMeasure == null) return;
                GetField(transportequipment.GrossVolumeMeasure, xmlMapping);
                break;
            case "TareWeightMeasure":
                if (transportequipment.TareWeightMeasure == null) return;
                GetField(transportequipment.TareWeightMeasure, xmlMapping);
                break;
            case "TrackingDeviceCode":
                if (transportequipment.TrackingDeviceCode == null) return;
                GetField(transportequipment.TrackingDeviceCode, xmlMapping);
                break;
            case "PowerIndicator":
                if (transportequipment.PowerIndicator == null) return;
                GetField(transportequipment.PowerIndicator, xmlMapping);
                break;
            case "TraceID":
                if (transportequipment.TraceID == null) return;
                GetField(transportequipment.TraceID, xmlMapping);
                break;
            case "MeasurementDimension":
                if (transportequipment.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in transportequipment.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "TransportEquipmentSeal":
                if (transportequipment.TransportEquipmentSeal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipmentSeal)
                {
                    foreach (var row in transportequipment.TransportEquipmentSeal)
                    {
                        collMappingTransportEquipmentSeal.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEquipmentSeal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.TransportEquipmentSeal[0], xmlMapping);
                }
                break;
            case "MinimumTemperature":
                if (transportequipment.MinimumTemperature == null) return;
                GetField(transportequipment.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (transportequipment.MaximumTemperature == null) return;
                GetField(transportequipment.MaximumTemperature, xmlMapping);
                break;
            case "ProviderParty":
                if (transportequipment.ProviderParty == null) return;
                GetField(transportequipment.ProviderParty, xmlMapping);
                break;
            case "LoadingProofParty":
                if (transportequipment.LoadingProofParty == null) return;
                GetField(transportequipment.LoadingProofParty, xmlMapping);
                break;
            case "SupplierParty":
                if (transportequipment.SupplierParty == null) return;
                GetField(transportequipment.SupplierParty, xmlMapping);
                break;
            case "OwnerParty":
                if (transportequipment.OwnerParty == null) return;
                GetField(transportequipment.OwnerParty, xmlMapping);
                break;
            case "OperatingParty":
                if (transportequipment.OperatingParty == null) return;
                GetField(transportequipment.OperatingParty, xmlMapping);
                break;
            case "LoadingLocation":
                if (transportequipment.LoadingLocation == null) return;
                GetField(transportequipment.LoadingLocation, xmlMapping);
                break;
            case "UnloadingLocation":
                if (transportequipment.UnloadingLocation == null) return;
                GetField(transportequipment.UnloadingLocation, xmlMapping);
                break;
            case "StorageLocation":
                if (transportequipment.StorageLocation == null) return;
                GetField(transportequipment.StorageLocation, xmlMapping);
                break;
            case "PositioningTransportEvent":
                if (transportequipment.PositioningTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPositioningTransportEvent)
                {
                    foreach (var row in transportequipment.PositioningTransportEvent)
                    {
                        collMappingPositioningTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingPositioningTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.PositioningTransportEvent[0], xmlMapping);
                }
                break;
            case "QuarantineTransportEvent":
                if (transportequipment.QuarantineTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingQuarantineTransportEvent)
                {
                    foreach (var row in transportequipment.QuarantineTransportEvent)
                    {
                        collMappingQuarantineTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingQuarantineTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.QuarantineTransportEvent[0], xmlMapping);
                }
                break;
            case "DeliveryTransportEvent":
                if (transportequipment.DeliveryTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryTransportEvent)
                {
                    foreach (var row in transportequipment.DeliveryTransportEvent)
                    {
                        collMappingDeliveryTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.DeliveryTransportEvent[0], xmlMapping);
                }
                break;
            case "PickupTransportEvent":
                if (transportequipment.PickupTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPickupTransportEvent)
                {
                    foreach (var row in transportequipment.PickupTransportEvent)
                    {
                        collMappingPickupTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingPickupTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.PickupTransportEvent[0], xmlMapping);
                }
                break;
            case "HandlingTransportEvent":
                if (transportequipment.HandlingTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingTransportEvent)
                {
                    foreach (var row in transportequipment.HandlingTransportEvent)
                    {
                        collMappingHandlingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingHandlingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.HandlingTransportEvent[0], xmlMapping);
                }
                break;
            case "LoadingTransportEvent":
                if (transportequipment.LoadingTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingLoadingTransportEvent)
                {
                    foreach (var row in transportequipment.LoadingTransportEvent)
                    {
                        collMappingLoadingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingLoadingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.LoadingTransportEvent[0], xmlMapping);
                }
                break;
            case "TransportEvent":
                if (transportequipment.TransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent)
                {
                    foreach (var row in transportequipment.TransportEvent)
                    {
                        collMappingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.TransportEvent[0], xmlMapping);
                }
                break;
            case "ApplicableTransportMeans":
                if (transportequipment.ApplicableTransportMeans == null) return;
                GetField(transportequipment.ApplicableTransportMeans, xmlMapping);
                break;
            case "HaulageTradingTerms":
                if (transportequipment.HaulageTradingTerms == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHaulageTradingTerms)
                {
                    foreach (var row in transportequipment.HaulageTradingTerms)
                    {
                        collMappingHaulageTradingTerms.SetNewRowContext();

                        foreach (var colMapp in collMappingHaulageTradingTerms.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.HaulageTradingTerms[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (transportequipment.HazardousGoodsTransit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit)
                {
                    foreach (var row in transportequipment.HazardousGoodsTransit)
                    {
                        collMappingHazardousGoodsTransit.SetNewRowContext();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "PackagedTransportHandlingUnit":
                if (transportequipment.PackagedTransportHandlingUnit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPackagedTransportHandlingUnit)
                {
                    foreach (var row in transportequipment.PackagedTransportHandlingUnit)
                    {
                        collMappingPackagedTransportHandlingUnit.SetNewRowContext();

                        foreach (var colMapp in collMappingPackagedTransportHandlingUnit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.PackagedTransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "ServiceAllowanceCharge":
                if (transportequipment.ServiceAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingServiceAllowanceCharge)
                {
                    foreach (var row in transportequipment.ServiceAllowanceCharge)
                    {
                        collMappingServiceAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingServiceAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.ServiceAllowanceCharge[0], xmlMapping);
                }
                break;
            case "FreightAllowanceCharge":
                if (transportequipment.FreightAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge)
                {
                    foreach (var row in transportequipment.FreightAllowanceCharge)
                    {
                        collMappingFreightAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "AttachedTransportEquipment":
                if (transportequipment.AttachedTransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAttachedTransportEquipment)
                {
                    foreach (var row in transportequipment.AttachedTransportEquipment)
                    {
                        collMappingAttachedTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingAttachedTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.AttachedTransportEquipment[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (transportequipment.Delivery == null) return;
                GetField(transportequipment.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (transportequipment.Pickup == null) return;
                GetField(transportequipment.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (transportequipment.Despatch == null) return;
                GetField(transportequipment.Despatch, xmlMapping);
                break;
            case "ShipmentDocumentReference":
                if (transportequipment.ShipmentDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentDocumentReference)
                {
                    foreach (var row in transportequipment.ShipmentDocumentReference)
                    {
                        collMappingShipmentDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingShipmentDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.ShipmentDocumentReference[0], xmlMapping);
                }
                break;
            case "ContainedInTransportEquipment":
                if (transportequipment.ContainedInTransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContainedInTransportEquipment)
                {
                    foreach (var row in transportequipment.ContainedInTransportEquipment)
                    {
                        collMappingContainedInTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingContainedInTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.ContainedInTransportEquipment[0], xmlMapping);
                }
                break;
            case "Package":
                if (transportequipment.Package == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPackage)
                {
                    foreach (var row in transportequipment.Package)
                    {
                        collMappingPackage.SetNewRowContext();

                        foreach (var colMapp in collMappingPackage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.Package[0], xmlMapping);
                }
                break;
            case "GoodsItem":
                if (transportequipment.GoodsItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem)
                {
                    foreach (var row in transportequipment.GoodsItem)
                    {
                        collMappingGoodsItem.SetNewRowContext();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transportequipment.GoodsItem[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(DimensionType measurementdimension, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (measurementdimension.AttributeID == null) return;
                GetField(measurementdimension.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (measurementdimension.Measure == null) return;
                GetField(measurementdimension.Measure, xmlMapping);
                break;
            case "Description":
                if (measurementdimension.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in measurementdimension.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(measurementdimension.Description[0], xmlMapping);
                }
                break;
            case "MinimumMeasure":
                if (measurementdimension.MinimumMeasure == null) return;
                GetField(measurementdimension.MinimumMeasure, xmlMapping);
                break;
            case "MaximumMeasure":
                if (measurementdimension.MaximumMeasure == null) return;
                GetField(measurementdimension.MaximumMeasure, xmlMapping);
                break;

        }
    }
    public void GetField(TransportEquipmentSealType transportequipmentseal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportequipmentseal.ID == null) return;
                GetField(transportequipmentseal.ID, xmlMapping);
                break;
            case "SealIssuerTypeCode":
                if (transportequipmentseal.SealIssuerTypeCode == null) return;
                GetField(transportequipmentseal.SealIssuerTypeCode, xmlMapping);
                break;
            case "Condition":
                if (transportequipmentseal.Condition == null) return;
                GetField(transportequipmentseal.Condition, xmlMapping);
                break;
            case "SealStatusCode":
                if (transportequipmentseal.SealStatusCode == null) return;
                GetField(transportequipmentseal.SealStatusCode, xmlMapping);
                break;
            case "SealingPartyType":
                if (transportequipmentseal.SealingPartyType == null) return;
                GetField(transportequipmentseal.SealingPartyType, xmlMapping);
                break;

        }
    }
    public void GetField(TemperatureType minimumtemperature, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (minimumtemperature.AttributeID == null) return;
                GetField(minimumtemperature.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (minimumtemperature.Measure == null) return;
                GetField(minimumtemperature.Measure, xmlMapping);
                break;
            case "Description":
                if (minimumtemperature.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in minimumtemperature.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(minimumtemperature.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(TransportMeansType applicabletransportmeans, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "JourneyID":
                if (applicabletransportmeans.JourneyID == null) return;
                GetField(applicabletransportmeans.JourneyID, xmlMapping);
                break;
            case "RegistrationNationalityID":
                if (applicabletransportmeans.RegistrationNationalityID == null) return;
                GetField(applicabletransportmeans.RegistrationNationalityID, xmlMapping);
                break;
            case "RegistrationNationality":
                if (applicabletransportmeans.RegistrationNationality == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingRegistrationNationality)
                {
                    foreach (var row in applicabletransportmeans.RegistrationNationality)
                    {
                        collMappingRegistrationNationality.SetNewRowContext();

                        foreach (var colMapp in collMappingRegistrationNationality.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(applicabletransportmeans.RegistrationNationality[0], xmlMapping);
                }
                break;
            case "DirectionCode":
                if (applicabletransportmeans.DirectionCode == null) return;
                GetField(applicabletransportmeans.DirectionCode, xmlMapping);
                break;
            case "TransportMeansTypeCode":
                if (applicabletransportmeans.TransportMeansTypeCode == null) return;
                GetField(applicabletransportmeans.TransportMeansTypeCode, xmlMapping);
                break;
            case "TradeServiceCode":
                if (applicabletransportmeans.TradeServiceCode == null) return;
                GetField(applicabletransportmeans.TradeServiceCode, xmlMapping);
                break;
            case "Stowage":
                if (applicabletransportmeans.Stowage == null) return;
                GetField(applicabletransportmeans.Stowage, xmlMapping);
                break;
            case "AirTransport":
                if (applicabletransportmeans.AirTransport == null) return;
                GetField(applicabletransportmeans.AirTransport, xmlMapping);
                break;
            case "RoadTransport":
                if (applicabletransportmeans.RoadTransport == null) return;
                GetField(applicabletransportmeans.RoadTransport, xmlMapping);
                break;
            case "RailTransport":
                if (applicabletransportmeans.RailTransport == null) return;
                GetField(applicabletransportmeans.RailTransport, xmlMapping);
                break;
            case "MaritimeTransport":
                if (applicabletransportmeans.MaritimeTransport == null) return;
                GetField(applicabletransportmeans.MaritimeTransport, xmlMapping);
                break;
            case "OwnerParty":
                if (applicabletransportmeans.OwnerParty == null) return;
                GetField(applicabletransportmeans.OwnerParty, xmlMapping);
                break;
            case "MeasurementDimension":
                if (applicabletransportmeans.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in applicabletransportmeans.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(applicabletransportmeans.MeasurementDimension[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(StowageType stowage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LocationID":
                if (stowage.LocationID == null) return;
                GetField(stowage.LocationID, xmlMapping);
                break;
            case "Location":
                if (stowage.Location == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingLocation)
                {
                    foreach (var row in stowage.Location)
                    {
                        collMappingLocation.SetNewRowContext();

                        foreach (var colMapp in collMappingLocation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(stowage.Location[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (stowage.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in stowage.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(stowage.MeasurementDimension[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(AirTransportType airtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AircraftID":
                if (airtransport.AircraftID == null) return;
                GetField(airtransport.AircraftID, xmlMapping);
                break;

        }
    }
    public void GetField(RoadTransportType roadtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LicensePlateID":
                if (roadtransport.LicensePlateID == null) return;
                GetField(roadtransport.LicensePlateID, xmlMapping);
                break;

        }
    }
    public void GetField(RailTransportType railtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TrainID":
                if (railtransport.TrainID == null) return;
                GetField(railtransport.TrainID, xmlMapping);
                break;
            case "RailCarID":
                if (railtransport.RailCarID == null) return;
                GetField(railtransport.RailCarID, xmlMapping);
                break;

        }
    }
    public void GetField(MaritimeTransportType maritimetransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "VesselID":
                if (maritimetransport.VesselID == null) return;
                GetField(maritimetransport.VesselID, xmlMapping);
                break;
            case "VesselName":
                if (maritimetransport.VesselName == null) return;
                GetField(maritimetransport.VesselName, xmlMapping);
                break;
            case "RadioCallSignID":
                if (maritimetransport.RadioCallSignID == null) return;
                GetField(maritimetransport.RadioCallSignID, xmlMapping);
                break;
            case "ShipsRequirements":
                if (maritimetransport.ShipsRequirements == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipsRequirements)
                {
                    foreach (var row in maritimetransport.ShipsRequirements)
                    {
                        collMappingShipsRequirements.SetNewRowContext();

                        foreach (var colMapp in collMappingShipsRequirements.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(maritimetransport.ShipsRequirements[0], xmlMapping);
                }
                break;
            case "GrossTonnageMeasure":
                if (maritimetransport.GrossTonnageMeasure == null) return;
                GetField(maritimetransport.GrossTonnageMeasure, xmlMapping);
                break;
            case "NetTonnageMeasure":
                if (maritimetransport.NetTonnageMeasure == null) return;
                GetField(maritimetransport.NetTonnageMeasure, xmlMapping);
                break;
            case "RegistryCertificateDocumentReference":
                if (maritimetransport.RegistryCertificateDocumentReference == null) return;
                GetField(maritimetransport.RegistryCertificateDocumentReference, xmlMapping);
                break;
            case "RegistryPortLocation":
                if (maritimetransport.RegistryPortLocation == null) return;
                GetField(maritimetransport.RegistryPortLocation, xmlMapping);
                break;

        }
    }
    public void GetField(TradingTermsType haulagetradingterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Information":
                if (haulagetradingterms.Information == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInformation)
                {
                    foreach (var row in haulagetradingterms.Information)
                    {
                        collMappingInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(haulagetradingterms.Information[0], xmlMapping);
                }
                break;
            case "Reference":
                if (haulagetradingterms.Reference == null) return;
                GetField(haulagetradingterms.Reference, xmlMapping);
                break;
            case "ApplicableAddress":
                if (haulagetradingterms.ApplicableAddress == null) return;
                GetField(haulagetradingterms.ApplicableAddress, xmlMapping);
                break;

        }
    }
    public void GetField(HazardousGoodsTransitType hazardousgoodstransit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TransportEmergencyCardCode":
                if (hazardousgoodstransit.TransportEmergencyCardCode == null) return;
                GetField(hazardousgoodstransit.TransportEmergencyCardCode, xmlMapping);
                break;
            case "PackingCriteriaCode":
                if (hazardousgoodstransit.PackingCriteriaCode == null) return;
                GetField(hazardousgoodstransit.PackingCriteriaCode, xmlMapping);
                break;
            case "HazardousRegulationCode":
                if (hazardousgoodstransit.HazardousRegulationCode == null) return;
                GetField(hazardousgoodstransit.HazardousRegulationCode, xmlMapping);
                break;
            case "InhalationToxicityZoneCode":
                if (hazardousgoodstransit.InhalationToxicityZoneCode == null) return;
                GetField(hazardousgoodstransit.InhalationToxicityZoneCode, xmlMapping);
                break;
            case "TransportAuthorizationCode":
                if (hazardousgoodstransit.TransportAuthorizationCode == null) return;
                GetField(hazardousgoodstransit.TransportAuthorizationCode, xmlMapping);
                break;
            case "MaximumTemperature":
                if (hazardousgoodstransit.MaximumTemperature == null) return;
                GetField(hazardousgoodstransit.MaximumTemperature, xmlMapping);
                break;
            case "MinimumTemperature":
                if (hazardousgoodstransit.MinimumTemperature == null) return;
                GetField(hazardousgoodstransit.MinimumTemperature, xmlMapping);
                break;

        }
    }
    public void GetField(TransportHandlingUnitType packagedtransporthandlingunit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (packagedtransporthandlingunit.ID == null) return;
                GetField(packagedtransporthandlingunit.ID, xmlMapping);
                break;
            case "TransportHandlingUnitTypeCode":
                if (packagedtransporthandlingunit.TransportHandlingUnitTypeCode == null) return;
                GetField(packagedtransporthandlingunit.TransportHandlingUnitTypeCode, xmlMapping);
                break;
            case "HandlingCode":
                if (packagedtransporthandlingunit.HandlingCode == null) return;
                GetField(packagedtransporthandlingunit.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (packagedtransporthandlingunit.HandlingInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions)
                {
                    foreach (var row in packagedtransporthandlingunit.HandlingInstructions)
                    {
                        collMappingHandlingInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (packagedtransporthandlingunit.HazardousRiskIndicator == null) return;
                GetField(packagedtransporthandlingunit.HazardousRiskIndicator, xmlMapping);
                break;
            case "TotalGoodsItemQuantity":
                if (packagedtransporthandlingunit.TotalGoodsItemQuantity == null) return;
                GetField(packagedtransporthandlingunit.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalPackageQuantity":
                if (packagedtransporthandlingunit.TotalPackageQuantity == null) return;
                GetField(packagedtransporthandlingunit.TotalPackageQuantity, xmlMapping);
                break;
            case "DamageRemarks":
                if (packagedtransporthandlingunit.DamageRemarks == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDamageRemarks)
                {
                    foreach (var row in packagedtransporthandlingunit.DamageRemarks)
                    {
                        collMappingDamageRemarks.SetNewRowContext();

                        foreach (var colMapp in collMappingDamageRemarks.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.DamageRemarks[0], xmlMapping);
                }
                break;
            case "ShippingMarks":
                if (packagedtransporthandlingunit.ShippingMarks == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShippingMarks)
                {
                    foreach (var row in packagedtransporthandlingunit.ShippingMarks)
                    {
                        collMappingShippingMarks.SetNewRowContext();

                        foreach (var colMapp in collMappingShippingMarks.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.ShippingMarks[0], xmlMapping);
                }
                break;
            case "TraceID":
                if (packagedtransporthandlingunit.TraceID == null) return;
                GetField(packagedtransporthandlingunit.TraceID, xmlMapping);
                break;
            case "HandlingUnitDespatchLine":
                if (packagedtransporthandlingunit.HandlingUnitDespatchLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingUnitDespatchLine)
                {
                    foreach (var row in packagedtransporthandlingunit.HandlingUnitDespatchLine)
                    {
                        collMappingHandlingUnitDespatchLine.SetNewRowContext();

                        foreach (var colMapp in collMappingHandlingUnitDespatchLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.HandlingUnitDespatchLine[0], xmlMapping);
                }
                break;
            case "ActualPackage":
                if (packagedtransporthandlingunit.ActualPackage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingActualPackage)
                {
                    foreach (var row in packagedtransporthandlingunit.ActualPackage)
                    {
                        collMappingActualPackage.SetNewRowContext();

                        foreach (var colMapp in collMappingActualPackage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.ActualPackage[0], xmlMapping);
                }
                break;
            case "ReceivedHandlingUnitReceiptLine":
                if (packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingReceivedHandlingUnitReceiptLine)
                {
                    foreach (var row in packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine)
                    {
                        collMappingReceivedHandlingUnitReceiptLine.SetNewRowContext();

                        foreach (var colMapp in collMappingReceivedHandlingUnitReceiptLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine[0], xmlMapping);
                }
                break;
            case "TransportEquipment":
                if (packagedtransporthandlingunit.TransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment)
                {
                    foreach (var row in packagedtransporthandlingunit.TransportEquipment)
                    {
                        collMappingTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.TransportEquipment[0], xmlMapping);
                }
                break;
            case "TransportMeans":
                if (packagedtransporthandlingunit.TransportMeans == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportMeans)
                {
                    foreach (var row in packagedtransporthandlingunit.TransportMeans)
                    {
                        collMappingTransportMeans.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportMeans.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.TransportMeans[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (packagedtransporthandlingunit.HazardousGoodsTransit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit)
                {
                    foreach (var row in packagedtransporthandlingunit.HazardousGoodsTransit)
                    {
                        collMappingHazardousGoodsTransit.SetNewRowContext();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (packagedtransporthandlingunit.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in packagedtransporthandlingunit.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "MinimumTemperature":
                if (packagedtransporthandlingunit.MinimumTemperature == null) return;
                GetField(packagedtransporthandlingunit.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (packagedtransporthandlingunit.MaximumTemperature == null) return;
                GetField(packagedtransporthandlingunit.MaximumTemperature, xmlMapping);
                break;
            case "GoodsItem":
                if (packagedtransporthandlingunit.GoodsItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem)
                {
                    foreach (var row in packagedtransporthandlingunit.GoodsItem)
                    {
                        collMappingGoodsItem.SetNewRowContext();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.GoodsItem[0], xmlMapping);
                }
                break;
            case "FloorSpaceMeasurementDimension":
                if (packagedtransporthandlingunit.FloorSpaceMeasurementDimension == null) return;
                GetField(packagedtransporthandlingunit.FloorSpaceMeasurementDimension, xmlMapping);
                break;
            case "PalletSpaceMeasurementDimension":
                if (packagedtransporthandlingunit.PalletSpaceMeasurementDimension == null) return;
                GetField(packagedtransporthandlingunit.PalletSpaceMeasurementDimension, xmlMapping);
                break;
            case "ShipmentDocumentReference":
                if (packagedtransporthandlingunit.ShipmentDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentDocumentReference)
                {
                    foreach (var row in packagedtransporthandlingunit.ShipmentDocumentReference)
                    {
                        collMappingShipmentDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingShipmentDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.ShipmentDocumentReference[0], xmlMapping);
                }
                break;
            case "Status":
                if (packagedtransporthandlingunit.Status == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingStatus)
                {
                    foreach (var row in packagedtransporthandlingunit.Status)
                    {
                        collMappingStatus.SetNewRowContext();

                        foreach (var colMapp in collMappingStatus.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.Status[0], xmlMapping);
                }
                break;
            case "CustomsDeclaration":
                if (packagedtransporthandlingunit.CustomsDeclaration == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsDeclaration)
                {
                    foreach (var row in packagedtransporthandlingunit.CustomsDeclaration)
                    {
                        collMappingCustomsDeclaration.SetNewRowContext();

                        foreach (var colMapp in collMappingCustomsDeclaration.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.CustomsDeclaration[0], xmlMapping);
                }
                break;
            case "ReferencedShipment":
                if (packagedtransporthandlingunit.ReferencedShipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingReferencedShipment)
                {
                    foreach (var row in packagedtransporthandlingunit.ReferencedShipment)
                    {
                        collMappingReferencedShipment.SetNewRowContext();

                        foreach (var colMapp in collMappingReferencedShipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.ReferencedShipment[0], xmlMapping);
                }
                break;
            case "Package":
                if (packagedtransporthandlingunit.Package == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPackage)
                {
                    foreach (var row in packagedtransporthandlingunit.Package)
                    {
                        collMappingPackage.SetNewRowContext();

                        foreach (var colMapp in collMappingPackage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(packagedtransporthandlingunit.Package[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(DespatchLineType handlingunitdespatchline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (handlingunitdespatchline.ID == null) return;
                GetField(handlingunitdespatchline.ID, xmlMapping);
                break;
            case "UUID":
                if (handlingunitdespatchline.UUID == null) return;
                GetField(handlingunitdespatchline.UUID, xmlMapping);
                break;
            case "Note":
                if (handlingunitdespatchline.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in handlingunitdespatchline.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.Note[0], xmlMapping);
                }
                break;
            case "LineStatusCode":
                if (handlingunitdespatchline.LineStatusCode == null) return;
                GetField(handlingunitdespatchline.LineStatusCode, xmlMapping);
                break;
            case "DeliveredQuantity":
                if (handlingunitdespatchline.DeliveredQuantity == null) return;
                GetField(handlingunitdespatchline.DeliveredQuantity, xmlMapping);
                break;
            case "BackorderQuantity":
                if (handlingunitdespatchline.BackorderQuantity == null) return;
                GetField(handlingunitdespatchline.BackorderQuantity, xmlMapping);
                break;
            case "BackorderReason":
                if (handlingunitdespatchline.BackorderReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingBackorderReason)
                {
                    foreach (var row in handlingunitdespatchline.BackorderReason)
                    {
                        collMappingBackorderReason.SetNewRowContext();

                        foreach (var colMapp in collMappingBackorderReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.BackorderReason[0], xmlMapping);
                }
                break;
            case "OutstandingQuantity":
                if (handlingunitdespatchline.OutstandingQuantity == null) return;
                GetField(handlingunitdespatchline.OutstandingQuantity, xmlMapping);
                break;
            case "OutstandingReason":
                if (handlingunitdespatchline.OutstandingReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOutstandingReason)
                {
                    foreach (var row in handlingunitdespatchline.OutstandingReason)
                    {
                        collMappingOutstandingReason.SetNewRowContext();

                        foreach (var colMapp in collMappingOutstandingReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.OutstandingReason[0], xmlMapping);
                }
                break;
            case "OversupplyQuantity":
                if (handlingunitdespatchline.OversupplyQuantity == null) return;
                GetField(handlingunitdespatchline.OversupplyQuantity, xmlMapping);
                break;
            case "OrderLineReference":
                if (handlingunitdespatchline.OrderLineReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOrderLineReference)
                {
                    foreach (var row in handlingunitdespatchline.OrderLineReference)
                    {
                        collMappingOrderLineReference.SetNewRowContext();

                        foreach (var colMapp in collMappingOrderLineReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.OrderLineReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (handlingunitdespatchline.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in handlingunitdespatchline.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.DocumentReference[0], xmlMapping);
                }
                break;
            case "Item":
                if (handlingunitdespatchline.Item == null) return;
                GetField(handlingunitdespatchline.Item, xmlMapping);
                break;
            case "Shipment":
                if (handlingunitdespatchline.Shipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipment)
                {
                    foreach (var row in handlingunitdespatchline.Shipment)
                    {
                        collMappingShipment.SetNewRowContext();

                        foreach (var colMapp in collMappingShipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(handlingunitdespatchline.Shipment[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(OrderLineReferenceType orderlinereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineID":
                if (orderlinereference.LineID == null) return;
                GetField(orderlinereference.LineID, xmlMapping);
                break;
            case "SalesOrderLineID":
                if (orderlinereference.SalesOrderLineID == null) return;
                GetField(orderlinereference.SalesOrderLineID, xmlMapping);
                break;
            case "UUID":
                if (orderlinereference.UUID == null) return;
                GetField(orderlinereference.UUID, xmlMapping);
                break;
            case "LineStatusCode":
                if (orderlinereference.LineStatusCode == null) return;
                GetField(orderlinereference.LineStatusCode, xmlMapping);
                break;
            case "OrderReference":
                if (orderlinereference.OrderReference == null) return;
                GetField(orderlinereference.OrderReference, xmlMapping);
                break;

        }
    }
    public void GetField(ItemType item, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Description":
                if (item.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in item.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.Description[0], xmlMapping);
                }
                break;
            case "PackQuantity":
                if (item.PackQuantity == null) return;
                GetField(item.PackQuantity, xmlMapping);
                break;
            case "PackSizeNumeric":
                if (item.PackSizeNumeric == null) return;
                GetField(item.PackSizeNumeric, xmlMapping);
                break;
            case "CatalogueIndicator":
                if (item.CatalogueIndicator == null) return;
                GetField(item.CatalogueIndicator, xmlMapping);
                break;
            case "Name":
                if (item.Name == null) return;
                GetField(item.Name, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (item.HazardousRiskIndicator == null) return;
                GetField(item.HazardousRiskIndicator, xmlMapping);
                break;
            case "AdditionalInformation":
                if (item.AdditionalInformation == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalInformation)
                {
                    foreach (var row in item.AdditionalInformation)
                    {
                        collMappingAdditionalInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.AdditionalInformation[0], xmlMapping);
                }
                break;
            case "Keyword":
                if (item.Keyword == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingKeyword)
                {
                    foreach (var row in item.Keyword)
                    {
                        collMappingKeyword.SetNewRowContext();

                        foreach (var colMapp in collMappingKeyword.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.Keyword[0], xmlMapping);
                }
                break;
            case "BrandName":
                if (item.BrandName == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingBrandName)
                {
                    foreach (var row in item.BrandName)
                    {
                        collMappingBrandName.SetNewRowContext();

                        foreach (var colMapp in collMappingBrandName.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.BrandName[0], xmlMapping);
                }
                break;
            case "ModelName":
                if (item.ModelName == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingModelName)
                {
                    foreach (var row in item.ModelName)
                    {
                        collMappingModelName.SetNewRowContext();

                        foreach (var colMapp in collMappingModelName.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ModelName[0], xmlMapping);
                }
                break;
            case "BuyersItemIdentification":
                if (item.BuyersItemIdentification == null) return;
                GetField(item.BuyersItemIdentification, xmlMapping);
                break;
            case "SellersItemIdentification":
                if (item.SellersItemIdentification == null) return;
                GetField(item.SellersItemIdentification, xmlMapping);
                break;
            case "ManufacturersItemIdentification":
                if (item.ManufacturersItemIdentification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingManufacturersItemIdentification)
                {
                    foreach (var row in item.ManufacturersItemIdentification)
                    {
                        collMappingManufacturersItemIdentification.SetNewRowContext();

                        foreach (var colMapp in collMappingManufacturersItemIdentification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ManufacturersItemIdentification[0], xmlMapping);
                }
                break;
            case "StandardItemIdentification":
                if (item.StandardItemIdentification == null) return;
                GetField(item.StandardItemIdentification, xmlMapping);
                break;
            case "CatalogueItemIdentification":
                if (item.CatalogueItemIdentification == null) return;
                GetField(item.CatalogueItemIdentification, xmlMapping);
                break;
            case "AdditionalItemIdentification":
                if (item.AdditionalItemIdentification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemIdentification)
                {
                    foreach (var row in item.AdditionalItemIdentification)
                    {
                        collMappingAdditionalItemIdentification.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalItemIdentification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.AdditionalItemIdentification[0], xmlMapping);
                }
                break;
            case "CatalogueDocumentReference":
                if (item.CatalogueDocumentReference == null) return;
                GetField(item.CatalogueDocumentReference, xmlMapping);
                break;
            case "ItemSpecificationDocumentReference":
                if (item.ItemSpecificationDocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingItemSpecificationDocumentReference)
                {
                    foreach (var row in item.ItemSpecificationDocumentReference)
                    {
                        collMappingItemSpecificationDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingItemSpecificationDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ItemSpecificationDocumentReference[0], xmlMapping);
                }
                break;
            case "OriginCountry":
                if (item.OriginCountry == null) return;
                GetField(item.OriginCountry, xmlMapping);
                break;
            case "CommodityClassification":
                if (item.CommodityClassification == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCommodityClassification)
                {
                    foreach (var row in item.CommodityClassification)
                    {
                        collMappingCommodityClassification.SetNewRowContext();

                        foreach (var colMapp in collMappingCommodityClassification.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.CommodityClassification[0], xmlMapping);
                }
                break;
            case "TransactionConditions":
                if (item.TransactionConditions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransactionConditions)
                {
                    foreach (var row in item.TransactionConditions)
                    {
                        collMappingTransactionConditions.SetNewRowContext();

                        foreach (var colMapp in collMappingTransactionConditions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.TransactionConditions[0], xmlMapping);
                }
                break;
            case "HazardousItem":
                if (item.HazardousItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousItem)
                {
                    foreach (var row in item.HazardousItem)
                    {
                        collMappingHazardousItem.SetNewRowContext();

                        foreach (var colMapp in collMappingHazardousItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.HazardousItem[0], xmlMapping);
                }
                break;
            case "ClassifiedTaxCategory":
                if (item.ClassifiedTaxCategory == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingClassifiedTaxCategory)
                {
                    foreach (var row in item.ClassifiedTaxCategory)
                    {
                        collMappingClassifiedTaxCategory.SetNewRowContext();

                        foreach (var colMapp in collMappingClassifiedTaxCategory.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ClassifiedTaxCategory[0], xmlMapping);
                }
                break;
            case "AdditionalItemProperty":
                if (item.AdditionalItemProperty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty)
                {
                    foreach (var row in item.AdditionalItemProperty)
                    {
                        collMappingAdditionalItemProperty.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.AdditionalItemProperty[0], xmlMapping);
                }
                break;
            case "ManufacturerParty":
                if (item.ManufacturerParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingManufacturerParty)
                {
                    foreach (var row in item.ManufacturerParty)
                    {
                        collMappingManufacturerParty.SetNewRowContext();

                        foreach (var colMapp in collMappingManufacturerParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ManufacturerParty[0], xmlMapping);
                }
                break;
            case "InformationContentProviderParty":
                if (item.InformationContentProviderParty == null) return;
                GetField(item.InformationContentProviderParty, xmlMapping);
                break;
            case "OriginAddress":
                if (item.OriginAddress == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOriginAddress)
                {
                    foreach (var row in item.OriginAddress)
                    {
                        collMappingOriginAddress.SetNewRowContext();

                        foreach (var colMapp in collMappingOriginAddress.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.OriginAddress[0], xmlMapping);
                }
                break;
            case "ItemInstance":
                if (item.ItemInstance == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingItemInstance)
                {
                    foreach (var row in item.ItemInstance)
                    {
                        collMappingItemInstance.SetNewRowContext();

                        foreach (var colMapp in collMappingItemInstance.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.ItemInstance[0], xmlMapping);
                }
                break;
            case "Certificate":
                if (item.Certificate == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCertificate)
                {
                    foreach (var row in item.Certificate)
                    {
                        collMappingCertificate.SetNewRowContext();

                        foreach (var colMapp in collMappingCertificate.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.Certificate[0], xmlMapping);
                }
                break;
            case "Dimension":
                if (item.Dimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDimension)
                {
                    foreach (var row in item.Dimension)
                    {
                        collMappingDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(item.Dimension[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ItemIdentificationType buyersitemidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (buyersitemidentification.ID == null) return;
                GetField(buyersitemidentification.ID, xmlMapping);
                break;
            case "ExtendedID":
                if (buyersitemidentification.ExtendedID == null) return;
                GetField(buyersitemidentification.ExtendedID, xmlMapping);
                break;
            case "BarcodeSymbologyID":
                if (buyersitemidentification.BarcodeSymbologyID == null) return;
                GetField(buyersitemidentification.BarcodeSymbologyID, xmlMapping);
                break;
            case "PhysicalAttribute":
                if (buyersitemidentification.PhysicalAttribute == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPhysicalAttribute)
                {
                    foreach (var row in buyersitemidentification.PhysicalAttribute)
                    {
                        collMappingPhysicalAttribute.SetNewRowContext();

                        foreach (var colMapp in collMappingPhysicalAttribute.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(buyersitemidentification.PhysicalAttribute[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (buyersitemidentification.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in buyersitemidentification.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(buyersitemidentification.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "IssuerParty":
                if (buyersitemidentification.IssuerParty == null) return;
                GetField(buyersitemidentification.IssuerParty, xmlMapping);
                break;

        }
    }
    public void GetField(PhysicalAttributeType physicalattribute, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (physicalattribute.AttributeID == null) return;
                GetField(physicalattribute.AttributeID, xmlMapping);
                break;
            case "PositionCode":
                if (physicalattribute.PositionCode == null) return;
                GetField(physicalattribute.PositionCode, xmlMapping);
                break;
            case "DescriptionCode":
                if (physicalattribute.DescriptionCode == null) return;
                GetField(physicalattribute.DescriptionCode, xmlMapping);
                break;
            case "Description":
                if (physicalattribute.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in physicalattribute.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(physicalattribute.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(CommodityClassificationType commodityclassification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "NatureCode":
                if (commodityclassification.NatureCode == null) return;
                GetField(commodityclassification.NatureCode, xmlMapping);
                break;
            case "CargoTypeCode":
                if (commodityclassification.CargoTypeCode == null) return;
                GetField(commodityclassification.CargoTypeCode, xmlMapping);
                break;
            case "CommodityCode":
                if (commodityclassification.CommodityCode == null) return;
                GetField(commodityclassification.CommodityCode, xmlMapping);
                break;
            case "ItemClassificationCode":
                if (commodityclassification.ItemClassificationCode == null) return;
                GetField(commodityclassification.ItemClassificationCode, xmlMapping);
                break;

        }
    }
    public void GetField(TransactionConditionsType transactionconditions, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transactionconditions.ID == null) return;
                GetField(transactionconditions.ID, xmlMapping);
                break;
            case "ActionCode":
                if (transactionconditions.ActionCode == null) return;
                GetField(transactionconditions.ActionCode, xmlMapping);
                break;
            case "Description":
                if (transactionconditions.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in transactionconditions.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transactionconditions.Description[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (transactionconditions.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in transactionconditions.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(transactionconditions.DocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(HazardousItemType hazardousitem, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (hazardousitem.ID == null) return;
                GetField(hazardousitem.ID, xmlMapping);
                break;
            case "PlacardNotation":
                if (hazardousitem.PlacardNotation == null) return;
                GetField(hazardousitem.PlacardNotation, xmlMapping);
                break;
            case "PlacardEndorsement":
                if (hazardousitem.PlacardEndorsement == null) return;
                GetField(hazardousitem.PlacardEndorsement, xmlMapping);
                break;
            case "AdditionalInformation":
                if (hazardousitem.AdditionalInformation == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalInformation)
                {
                    foreach (var row in hazardousitem.AdditionalInformation)
                    {
                        collMappingAdditionalInformation.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalInformation.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(hazardousitem.AdditionalInformation[0], xmlMapping);
                }
                break;
            case "UNDGCode":
                if (hazardousitem.UNDGCode == null) return;
                GetField(hazardousitem.UNDGCode, xmlMapping);
                break;
            case "EmergencyProceduresCode":
                if (hazardousitem.EmergencyProceduresCode == null) return;
                GetField(hazardousitem.EmergencyProceduresCode, xmlMapping);
                break;
            case "MedicalFirstAidGuideCode":
                if (hazardousitem.MedicalFirstAidGuideCode == null) return;
                GetField(hazardousitem.MedicalFirstAidGuideCode, xmlMapping);
                break;
            case "TechnicalName":
                if (hazardousitem.TechnicalName == null) return;
                GetField(hazardousitem.TechnicalName, xmlMapping);
                break;
            case "CategoryName":
                if (hazardousitem.CategoryName == null) return;
                GetField(hazardousitem.CategoryName, xmlMapping);
                break;
            case "HazardousCategoryCode":
                if (hazardousitem.HazardousCategoryCode == null) return;
                GetField(hazardousitem.HazardousCategoryCode, xmlMapping);
                break;
            case "UpperOrangeHazardPlacardID":
                if (hazardousitem.UpperOrangeHazardPlacardID == null) return;
                GetField(hazardousitem.UpperOrangeHazardPlacardID, xmlMapping);
                break;
            case "LowerOrangeHazardPlacardID":
                if (hazardousitem.LowerOrangeHazardPlacardID == null) return;
                GetField(hazardousitem.LowerOrangeHazardPlacardID, xmlMapping);
                break;
            case "MarkingID":
                if (hazardousitem.MarkingID == null) return;
                GetField(hazardousitem.MarkingID, xmlMapping);
                break;
            case "HazardClassID":
                if (hazardousitem.HazardClassID == null) return;
                GetField(hazardousitem.HazardClassID, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (hazardousitem.NetWeightMeasure == null) return;
                GetField(hazardousitem.NetWeightMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (hazardousitem.NetVolumeMeasure == null) return;
                GetField(hazardousitem.NetVolumeMeasure, xmlMapping);
                break;
            case "Quantity":
                if (hazardousitem.Quantity == null) return;
                GetField(hazardousitem.Quantity, xmlMapping);
                break;
            case "ContactParty":
                if (hazardousitem.ContactParty == null) return;
                GetField(hazardousitem.ContactParty, xmlMapping);
                break;
            case "SecondaryHazard":
                if (hazardousitem.SecondaryHazard == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSecondaryHazard)
                {
                    foreach (var row in hazardousitem.SecondaryHazard)
                    {
                        collMappingSecondaryHazard.SetNewRowContext();

                        foreach (var colMapp in collMappingSecondaryHazard.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(hazardousitem.SecondaryHazard[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (hazardousitem.HazardousGoodsTransit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit)
                {
                    foreach (var row in hazardousitem.HazardousGoodsTransit)
                    {
                        collMappingHazardousGoodsTransit.SetNewRowContext();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(hazardousitem.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "EmergencyTemperature":
                if (hazardousitem.EmergencyTemperature == null) return;
                GetField(hazardousitem.EmergencyTemperature, xmlMapping);
                break;
            case "FlashpointTemperature":
                if (hazardousitem.FlashpointTemperature == null) return;
                GetField(hazardousitem.FlashpointTemperature, xmlMapping);
                break;
            case "AdditionalTemperature":
                if (hazardousitem.AdditionalTemperature == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalTemperature)
                {
                    foreach (var row in hazardousitem.AdditionalTemperature)
                    {
                        collMappingAdditionalTemperature.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalTemperature.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(hazardousitem.AdditionalTemperature[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(SecondaryHazardType secondaryhazard, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (secondaryhazard.ID == null) return;
                GetField(secondaryhazard.ID, xmlMapping);
                break;
            case "PlacardNotation":
                if (secondaryhazard.PlacardNotation == null) return;
                GetField(secondaryhazard.PlacardNotation, xmlMapping);
                break;
            case "PlacardEndorsement":
                if (secondaryhazard.PlacardEndorsement == null) return;
                GetField(secondaryhazard.PlacardEndorsement, xmlMapping);
                break;
            case "EmergencyProceduresCode":
                if (secondaryhazard.EmergencyProceduresCode == null) return;
                GetField(secondaryhazard.EmergencyProceduresCode, xmlMapping);
                break;
            case "Extension":
                if (secondaryhazard.Extension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingExtension)
                {
                    foreach (var row in secondaryhazard.Extension)
                    {
                        collMappingExtension.SetNewRowContext();

                        foreach (var colMapp in collMappingExtension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(secondaryhazard.Extension[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ItemPropertyType additionalitemproperty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (additionalitemproperty.ID == null) return;
                GetField(additionalitemproperty.ID, xmlMapping);
                break;
            case "Name":
                if (additionalitemproperty.Name == null) return;
                GetField(additionalitemproperty.Name, xmlMapping);
                break;
            case "NameCode":
                if (additionalitemproperty.NameCode == null) return;
                GetField(additionalitemproperty.NameCode, xmlMapping);
                break;
            case "TestMethod":
                if (additionalitemproperty.TestMethod == null) return;
                GetField(additionalitemproperty.TestMethod, xmlMapping);
                break;
            case "Value":
                if (additionalitemproperty.Value == null) return;
                GetField(additionalitemproperty.Value, xmlMapping);
                break;
            case "ValueQuantity":
                if (additionalitemproperty.ValueQuantity == null) return;
                GetField(additionalitemproperty.ValueQuantity, xmlMapping);
                break;
            case "ValueQualifier":
                if (additionalitemproperty.ValueQualifier == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingValueQualifier)
                {
                    foreach (var row in additionalitemproperty.ValueQualifier)
                    {
                        collMappingValueQualifier.SetNewRowContext();

                        foreach (var colMapp in collMappingValueQualifier.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(additionalitemproperty.ValueQualifier[0], xmlMapping);
                }
                break;
            case "ImportanceCode":
                if (additionalitemproperty.ImportanceCode == null) return;
                GetField(additionalitemproperty.ImportanceCode, xmlMapping);
                break;
            case "ListValue":
                if (additionalitemproperty.ListValue == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingListValue)
                {
                    foreach (var row in additionalitemproperty.ListValue)
                    {
                        collMappingListValue.SetNewRowContext();

                        foreach (var colMapp in collMappingListValue.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(additionalitemproperty.ListValue[0], xmlMapping);
                }
                break;
            case "UsabilityPeriod":
                if (additionalitemproperty.UsabilityPeriod == null) return;
                GetField(additionalitemproperty.UsabilityPeriod, xmlMapping);
                break;
            case "ItemPropertyGroup":
                if (additionalitemproperty.ItemPropertyGroup == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingItemPropertyGroup)
                {
                    foreach (var row in additionalitemproperty.ItemPropertyGroup)
                    {
                        collMappingItemPropertyGroup.SetNewRowContext();

                        foreach (var colMapp in collMappingItemPropertyGroup.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(additionalitemproperty.ItemPropertyGroup[0], xmlMapping);
                }
                break;
            case "RangeDimension":
                if (additionalitemproperty.RangeDimension == null) return;
                GetField(additionalitemproperty.RangeDimension, xmlMapping);
                break;
            case "ItemPropertyRange":
                if (additionalitemproperty.ItemPropertyRange == null) return;
                GetField(additionalitemproperty.ItemPropertyRange, xmlMapping);
                break;

        }
    }
    public void GetField(ItemPropertyGroupType itempropertygroup, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (itempropertygroup.ID == null) return;
                GetField(itempropertygroup.ID, xmlMapping);
                break;
            case "Name":
                if (itempropertygroup.Name == null) return;
                GetField(itempropertygroup.Name, xmlMapping);
                break;
            case "ImportanceCode":
                if (itempropertygroup.ImportanceCode == null) return;
                GetField(itempropertygroup.ImportanceCode, xmlMapping);
                break;

        }
    }
    public void GetField(ItemPropertyRangeType itempropertyrange, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "MinimumValue":
                if (itempropertyrange.MinimumValue == null) return;
                GetField(itempropertyrange.MinimumValue, xmlMapping);
                break;
            case "MaximumValue":
                if (itempropertyrange.MaximumValue == null) return;
                GetField(itempropertyrange.MaximumValue, xmlMapping);
                break;

        }
    }
    public void GetField(ItemInstanceType iteminstance, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ProductTraceID":
                if (iteminstance.ProductTraceID == null) return;
                GetField(iteminstance.ProductTraceID, xmlMapping);
                break;
            case "ManufactureDate":
                if (iteminstance.ManufactureDate == null) return;
                GetField(iteminstance.ManufactureDate, xmlMapping);
                break;
            case "ManufactureTime":
                if (iteminstance.ManufactureTime == null) return;
                GetField(iteminstance.ManufactureTime, xmlMapping);
                break;
            case "BestBeforeDate":
                if (iteminstance.BestBeforeDate == null) return;
                GetField(iteminstance.BestBeforeDate, xmlMapping);
                break;
            case "RegistrationID":
                if (iteminstance.RegistrationID == null) return;
                GetField(iteminstance.RegistrationID, xmlMapping);
                break;
            case "SerialID":
                if (iteminstance.SerialID == null) return;
                GetField(iteminstance.SerialID, xmlMapping);
                break;
            case "AdditionalItemProperty":
                if (iteminstance.AdditionalItemProperty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty)
                {
                    foreach (var row in iteminstance.AdditionalItemProperty)
                    {
                        collMappingAdditionalItemProperty.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(iteminstance.AdditionalItemProperty[0], xmlMapping);
                }
                break;
            case "LotIdentification":
                if (iteminstance.LotIdentification == null) return;
                GetField(iteminstance.LotIdentification, xmlMapping);
                break;

        }
    }
    public void GetField(LotIdentificationType lotidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LotNumberID":
                if (lotidentification.LotNumberID == null) return;
                GetField(lotidentification.LotNumberID, xmlMapping);
                break;
            case "ExpiryDate":
                if (lotidentification.ExpiryDate == null) return;
                GetField(lotidentification.ExpiryDate, xmlMapping);
                break;
            case "AdditionalItemProperty":
                if (lotidentification.AdditionalItemProperty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty)
                {
                    foreach (var row in lotidentification.AdditionalItemProperty)
                    {
                        collMappingAdditionalItemProperty.SetNewRowContext();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(lotidentification.AdditionalItemProperty[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(CertificateType certificate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (certificate.ID == null) return;
                GetField(certificate.ID, xmlMapping);
                break;
            case "CertificateTypeCode":
                if (certificate.CertificateTypeCode == null) return;
                GetField(certificate.CertificateTypeCode, xmlMapping);
                break;
            case "CertificateType1":
                if (certificate.CertificateType1 == null) return;
                GetField(certificate.CertificateType1, xmlMapping);
                break;
            case "Remarks":
                if (certificate.Remarks == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingRemarks)
                {
                    foreach (var row in certificate.Remarks)
                    {
                        collMappingRemarks.SetNewRowContext();

                        foreach (var colMapp in collMappingRemarks.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(certificate.Remarks[0], xmlMapping);
                }
                break;
            case "IssuerParty":
                if (certificate.IssuerParty == null) return;
                GetField(certificate.IssuerParty, xmlMapping);
                break;
            case "DocumentReference":
                if (certificate.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in certificate.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(certificate.DocumentReference[0], xmlMapping);
                }
                break;
            case "Signature":
                if (certificate.Signature == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSignature)
                {
                    foreach (var row in certificate.Signature)
                    {
                        collMappingSignature.SetNewRowContext();

                        foreach (var colMapp in collMappingSignature.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(certificate.Signature[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(PackageType actualpackage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (actualpackage.ID == null) return;
                GetField(actualpackage.ID, xmlMapping);
                break;
            case "Quantity":
                if (actualpackage.Quantity == null) return;
                GetField(actualpackage.Quantity, xmlMapping);
                break;
            case "ReturnableMaterialIndicator":
                if (actualpackage.ReturnableMaterialIndicator == null) return;
                GetField(actualpackage.ReturnableMaterialIndicator, xmlMapping);
                break;
            case "PackageLevelCode":
                if (actualpackage.PackageLevelCode == null) return;
                GetField(actualpackage.PackageLevelCode, xmlMapping);
                break;
            case "PackagingTypeCode":
                if (actualpackage.PackagingTypeCode == null) return;
                GetField(actualpackage.PackagingTypeCode, xmlMapping);
                break;
            case "PackingMaterial":
                if (actualpackage.PackingMaterial == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPackingMaterial)
                {
                    foreach (var row in actualpackage.PackingMaterial)
                    {
                        collMappingPackingMaterial.SetNewRowContext();

                        foreach (var colMapp in collMappingPackingMaterial.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(actualpackage.PackingMaterial[0], xmlMapping);
                }
                break;
            case "TraceID":
                if (actualpackage.TraceID == null) return;
                GetField(actualpackage.TraceID, xmlMapping);
                break;
            case "ContainedPackage":
                if (actualpackage.ContainedPackage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContainedPackage)
                {
                    foreach (var row in actualpackage.ContainedPackage)
                    {
                        collMappingContainedPackage.SetNewRowContext();

                        foreach (var colMapp in collMappingContainedPackage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(actualpackage.ContainedPackage[0], xmlMapping);
                }
                break;
            case "ContainingTransportEquipment":
                if (actualpackage.ContainingTransportEquipment == null) return;
                GetField(actualpackage.ContainingTransportEquipment, xmlMapping);
                break;
            case "GoodsItem":
                if (actualpackage.GoodsItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem)
                {
                    foreach (var row in actualpackage.GoodsItem)
                    {
                        collMappingGoodsItem.SetNewRowContext();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(actualpackage.GoodsItem[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (actualpackage.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in actualpackage.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(actualpackage.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "DeliveryUnit":
                if (actualpackage.DeliveryUnit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryUnit)
                {
                    foreach (var row in actualpackage.DeliveryUnit)
                    {
                        collMappingDeliveryUnit.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryUnit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(actualpackage.DeliveryUnit[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (actualpackage.Delivery == null) return;
                GetField(actualpackage.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (actualpackage.Pickup == null) return;
                GetField(actualpackage.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (actualpackage.Despatch == null) return;
                GetField(actualpackage.Despatch, xmlMapping);
                break;

        }
    }
    public void GetField(GoodsItemType goodsitem, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (goodsitem.ID == null) return;
                GetField(goodsitem.ID, xmlMapping);
                break;
            case "SequenceNumberID":
                if (goodsitem.SequenceNumberID == null) return;
                GetField(goodsitem.SequenceNumberID, xmlMapping);
                break;
            case "Description":
                if (goodsitem.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in goodsitem.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.Description[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (goodsitem.HazardousRiskIndicator == null) return;
                GetField(goodsitem.HazardousRiskIndicator, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (goodsitem.DeclaredCustomsValueAmount == null) return;
                GetField(goodsitem.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (goodsitem.DeclaredForCarriageValueAmount == null) return;
                GetField(goodsitem.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (goodsitem.DeclaredStatisticsValueAmount == null) return;
                GetField(goodsitem.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (goodsitem.FreeOnBoardValueAmount == null) return;
                GetField(goodsitem.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (goodsitem.InsuranceValueAmount == null) return;
                GetField(goodsitem.InsuranceValueAmount, xmlMapping);
                break;
            case "ValueAmount":
                if (goodsitem.ValueAmount == null) return;
                GetField(goodsitem.ValueAmount, xmlMapping);
                break;
            case "GrossWeightMeasure":
                if (goodsitem.GrossWeightMeasure == null) return;
                GetField(goodsitem.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (goodsitem.NetWeightMeasure == null) return;
                GetField(goodsitem.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (goodsitem.NetNetWeightMeasure == null) return;
                GetField(goodsitem.NetNetWeightMeasure, xmlMapping);
                break;
            case "ChargeableWeightMeasure":
                if (goodsitem.ChargeableWeightMeasure == null) return;
                GetField(goodsitem.ChargeableWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (goodsitem.GrossVolumeMeasure == null) return;
                GetField(goodsitem.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (goodsitem.NetVolumeMeasure == null) return;
                GetField(goodsitem.NetVolumeMeasure, xmlMapping);
                break;
            case "Quantity":
                if (goodsitem.Quantity == null) return;
                GetField(goodsitem.Quantity, xmlMapping);
                break;
            case "PreferenceCriterionCode":
                if (goodsitem.PreferenceCriterionCode == null) return;
                GetField(goodsitem.PreferenceCriterionCode, xmlMapping);
                break;
            case "RequiredCustomsID":
                if (goodsitem.RequiredCustomsID == null) return;
                GetField(goodsitem.RequiredCustomsID, xmlMapping);
                break;
            case "CustomsStatusCode":
                if (goodsitem.CustomsStatusCode == null) return;
                GetField(goodsitem.CustomsStatusCode, xmlMapping);
                break;
            case "CustomsTariffQuantity":
                if (goodsitem.CustomsTariffQuantity == null) return;
                GetField(goodsitem.CustomsTariffQuantity, xmlMapping);
                break;
            case "CustomsImportClassifiedIndicator":
                if (goodsitem.CustomsImportClassifiedIndicator == null) return;
                GetField(goodsitem.CustomsImportClassifiedIndicator, xmlMapping);
                break;
            case "ChargeableQuantity":
                if (goodsitem.ChargeableQuantity == null) return;
                GetField(goodsitem.ChargeableQuantity, xmlMapping);
                break;
            case "ReturnableQuantity":
                if (goodsitem.ReturnableQuantity == null) return;
                GetField(goodsitem.ReturnableQuantity, xmlMapping);
                break;
            case "TraceID":
                if (goodsitem.TraceID == null) return;
                GetField(goodsitem.TraceID, xmlMapping);
                break;
            case "Item":
                if (goodsitem.Item == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingItem)
                {
                    foreach (var row in goodsitem.Item)
                    {
                        collMappingItem.SetNewRowContext();

                        foreach (var colMapp in collMappingItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.Item[0], xmlMapping);
                }
                break;
            case "GoodsItemContainer":
                if (goodsitem.GoodsItemContainer == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItemContainer)
                {
                    foreach (var row in goodsitem.GoodsItemContainer)
                    {
                        collMappingGoodsItemContainer.SetNewRowContext();

                        foreach (var colMapp in collMappingGoodsItemContainer.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.GoodsItemContainer[0], xmlMapping);
                }
                break;
            case "FreightAllowanceCharge":
                if (goodsitem.FreightAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge)
                {
                    foreach (var row in goodsitem.FreightAllowanceCharge)
                    {
                        collMappingFreightAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "InvoiceLine":
                if (goodsitem.InvoiceLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine)
                {
                    foreach (var row in goodsitem.InvoiceLine)
                    {
                        collMappingInvoiceLine.SetNewRowContext();

                        foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.InvoiceLine[0], xmlMapping);
                }
                break;
            case "Temperature":
                if (goodsitem.Temperature == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTemperature)
                {
                    foreach (var row in goodsitem.Temperature)
                    {
                        collMappingTemperature.SetNewRowContext();

                        foreach (var colMapp in collMappingTemperature.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.Temperature[0], xmlMapping);
                }
                break;
            case "ContainedGoodsItem":
                if (goodsitem.ContainedGoodsItem == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContainedGoodsItem)
                {
                    foreach (var row in goodsitem.ContainedGoodsItem)
                    {
                        collMappingContainedGoodsItem.SetNewRowContext();

                        foreach (var colMapp in collMappingContainedGoodsItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.ContainedGoodsItem[0], xmlMapping);
                }
                break;
            case "OriginAddress":
                if (goodsitem.OriginAddress == null) return;
                GetField(goodsitem.OriginAddress, xmlMapping);
                break;
            case "Delivery":
                if (goodsitem.Delivery == null) return;
                GetField(goodsitem.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (goodsitem.Pickup == null) return;
                GetField(goodsitem.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (goodsitem.Despatch == null) return;
                GetField(goodsitem.Despatch, xmlMapping);
                break;
            case "MeasurementDimension":
                if (goodsitem.MeasurementDimension == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension)
                {
                    foreach (var row in goodsitem.MeasurementDimension)
                    {
                        collMappingMeasurementDimension.SetNewRowContext();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "ContainingPackage":
                if (goodsitem.ContainingPackage == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingContainingPackage)
                {
                    foreach (var row in goodsitem.ContainingPackage)
                    {
                        collMappingContainingPackage.SetNewRowContext();

                        foreach (var colMapp in collMappingContainingPackage.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitem.ContainingPackage[0], xmlMapping);
                }
                break;
            case "ShipmentDocumentReference":
                if (goodsitem.ShipmentDocumentReference == null) return;
                GetField(goodsitem.ShipmentDocumentReference, xmlMapping);
                break;
            case "MinimumTemperature":
                if (goodsitem.MinimumTemperature == null) return;
                GetField(goodsitem.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (goodsitem.MaximumTemperature == null) return;
                GetField(goodsitem.MaximumTemperature, xmlMapping);
                break;

        }
    }
    public void GetField(GoodsItemContainerType goodsitemcontainer, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (goodsitemcontainer.ID == null) return;
                GetField(goodsitemcontainer.ID, xmlMapping);
                break;
            case "Quantity":
                if (goodsitemcontainer.Quantity == null) return;
                GetField(goodsitemcontainer.Quantity, xmlMapping);
                break;
            case "TransportEquipment":
                if (goodsitemcontainer.TransportEquipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment)
                {
                    foreach (var row in goodsitemcontainer.TransportEquipment)
                    {
                        collMappingTransportEquipment.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(goodsitemcontainer.TransportEquipment[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(InvoiceLineType invoiceline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (invoiceline.ID == null) return;
                GetField(invoiceline.ID, xmlMapping);
                break;
            case "UUID":
                if (invoiceline.UUID == null) return;
                GetField(invoiceline.UUID, xmlMapping);
                break;
            case "Note":
                if (invoiceline.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in invoiceline.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.Note[0], xmlMapping);
                }
                break;
            case "InvoicedQuantity":
                if (invoiceline.InvoicedQuantity == null) return;
                GetField(invoiceline.InvoicedQuantity, xmlMapping);
                break;
            case "LineExtensionAmount":
                if (invoiceline.LineExtensionAmount == null) return;
                GetField(invoiceline.LineExtensionAmount, xmlMapping);
                break;
            case "TaxPointDate":
                if (invoiceline.TaxPointDate == null) return;
                GetField(invoiceline.TaxPointDate, xmlMapping);
                break;
            case "AccountingCostCode":
                if (invoiceline.AccountingCostCode == null) return;
                GetField(invoiceline.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (invoiceline.AccountingCost == null) return;
                GetField(invoiceline.AccountingCost, xmlMapping);
                break;
            case "PaymentPurposeCode":
                if (invoiceline.PaymentPurposeCode == null) return;
                GetField(invoiceline.PaymentPurposeCode, xmlMapping);
                break;
            case "FreeOfChargeIndicator":
                if (invoiceline.FreeOfChargeIndicator == null) return;
                GetField(invoiceline.FreeOfChargeIndicator, xmlMapping);
                break;
            case "InvoicePeriod":
                if (invoiceline.InvoicePeriod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod)
                {
                    foreach (var row in invoiceline.InvoicePeriod)
                    {
                        collMappingInvoicePeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.InvoicePeriod[0], xmlMapping);
                }
                break;
            case "OrderLineReference":
                if (invoiceline.OrderLineReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingOrderLineReference)
                {
                    foreach (var row in invoiceline.OrderLineReference)
                    {
                        collMappingOrderLineReference.SetNewRowContext();

                        foreach (var colMapp in collMappingOrderLineReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.OrderLineReference[0], xmlMapping);
                }
                break;
            case "DespatchLineReference":
                if (invoiceline.DespatchLineReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchLineReference)
                {
                    foreach (var row in invoiceline.DespatchLineReference)
                    {
                        collMappingDespatchLineReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDespatchLineReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.DespatchLineReference[0], xmlMapping);
                }
                break;
            case "ReceiptLineReference":
                if (invoiceline.ReceiptLineReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingReceiptLineReference)
                {
                    foreach (var row in invoiceline.ReceiptLineReference)
                    {
                        collMappingReceiptLineReference.SetNewRowContext();

                        foreach (var colMapp in collMappingReceiptLineReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.ReceiptLineReference[0], xmlMapping);
                }
                break;
            case "BillingReference":
                if (invoiceline.BillingReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReference)
                {
                    foreach (var row in invoiceline.BillingReference)
                    {
                        collMappingBillingReference.SetNewRowContext();

                        foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.BillingReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (invoiceline.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in invoiceline.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.DocumentReference[0], xmlMapping);
                }
                break;
            case "PricingReference":
                if (invoiceline.PricingReference == null) return;
                GetField(invoiceline.PricingReference, xmlMapping);
                break;
            case "OriginatorParty":
                if (invoiceline.OriginatorParty == null) return;
                GetField(invoiceline.OriginatorParty, xmlMapping);
                break;
            case "Delivery":
                if (invoiceline.Delivery == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDelivery)
                {
                    foreach (var row in invoiceline.Delivery)
                    {
                        collMappingDelivery.SetNewRowContext();

                        foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.Delivery[0], xmlMapping);
                }
                break;
            case "PaymentTerms":
                if (invoiceline.PaymentTerms == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms)
                {
                    foreach (var row in invoiceline.PaymentTerms)
                    {
                        collMappingPaymentTerms.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.PaymentTerms[0], xmlMapping);
                }
                break;
            case "AllowanceCharge":
                if (invoiceline.AllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                {
                    foreach (var row in invoiceline.AllowanceCharge)
                    {
                        collMappingAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "TaxTotal":
                if (invoiceline.TaxTotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal)
                {
                    foreach (var row in invoiceline.TaxTotal)
                    {
                        collMappingTaxTotal.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.TaxTotal[0], xmlMapping);
                }
                break;
            case "WithholdingTaxTotal":
                if (invoiceline.WithholdingTaxTotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal)
                {
                    foreach (var row in invoiceline.WithholdingTaxTotal)
                    {
                        collMappingWithholdingTaxTotal.SetNewRowContext();

                        foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.WithholdingTaxTotal[0], xmlMapping);
                }
                break;
            case "Item":
                if (invoiceline.Item == null) return;
                GetField(invoiceline.Item, xmlMapping);
                break;
            case "Price":
                if (invoiceline.Price == null) return;
                GetField(invoiceline.Price, xmlMapping);
                break;
            case "DeliveryTerms":
                if (invoiceline.DeliveryTerms == null) return;
                GetField(invoiceline.DeliveryTerms, xmlMapping);
                break;
            case "SubInvoiceLine":
                if (invoiceline.SubInvoiceLine == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingSubInvoiceLine)
                {
                    foreach (var row in invoiceline.SubInvoiceLine)
                    {
                        collMappingSubInvoiceLine.SetNewRowContext();

                        foreach (var colMapp in collMappingSubInvoiceLine.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(invoiceline.SubInvoiceLine[0], xmlMapping);
                }
                break;
            case "ItemPriceExtension":
                if (invoiceline.ItemPriceExtension == null) return;
                GetField(invoiceline.ItemPriceExtension, xmlMapping);
                break;

        }
    }
    public void GetField(LineReferenceType despatchlinereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineID":
                if (despatchlinereference.LineID == null) return;
                GetField(despatchlinereference.LineID, xmlMapping);
                break;
            case "UUID":
                if (despatchlinereference.UUID == null) return;
                GetField(despatchlinereference.UUID, xmlMapping);
                break;
            case "LineStatusCode":
                if (despatchlinereference.LineStatusCode == null) return;
                GetField(despatchlinereference.LineStatusCode, xmlMapping);
                break;
            case "DocumentReference":
                if (despatchlinereference.DocumentReference == null) return;
                GetField(despatchlinereference.DocumentReference, xmlMapping);
                break;

        }
    }
    public void GetField(PricingReferenceType pricingreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "OriginalItemLocationQuantity":
                if (pricingreference.OriginalItemLocationQuantity == null) return;
                GetField(pricingreference.OriginalItemLocationQuantity, xmlMapping);
                break;
            case "AlternativeConditionPrice":
                if (pricingreference.AlternativeConditionPrice == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAlternativeConditionPrice)
                {
                    foreach (var row in pricingreference.AlternativeConditionPrice)
                    {
                        collMappingAlternativeConditionPrice.SetNewRowContext();

                        foreach (var colMapp in collMappingAlternativeConditionPrice.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(pricingreference.AlternativeConditionPrice[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ItemLocationQuantityType originalitemlocationquantity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LeadTimeMeasure":
                if (originalitemlocationquantity.LeadTimeMeasure == null) return;
                GetField(originalitemlocationquantity.LeadTimeMeasure, xmlMapping);
                break;
            case "MinimumQuantity":
                if (originalitemlocationquantity.MinimumQuantity == null) return;
                GetField(originalitemlocationquantity.MinimumQuantity, xmlMapping);
                break;
            case "MaximumQuantity":
                if (originalitemlocationquantity.MaximumQuantity == null) return;
                GetField(originalitemlocationquantity.MaximumQuantity, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (originalitemlocationquantity.HazardousRiskIndicator == null) return;
                GetField(originalitemlocationquantity.HazardousRiskIndicator, xmlMapping);
                break;
            case "TradingRestrictions":
                if (originalitemlocationquantity.TradingRestrictions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTradingRestrictions)
                {
                    foreach (var row in originalitemlocationquantity.TradingRestrictions)
                    {
                        collMappingTradingRestrictions.SetNewRowContext();

                        foreach (var colMapp in collMappingTradingRestrictions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originalitemlocationquantity.TradingRestrictions[0], xmlMapping);
                }
                break;
            case "ApplicableTerritoryAddress":
                if (originalitemlocationquantity.ApplicableTerritoryAddress == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingApplicableTerritoryAddress)
                {
                    foreach (var row in originalitemlocationquantity.ApplicableTerritoryAddress)
                    {
                        collMappingApplicableTerritoryAddress.SetNewRowContext();

                        foreach (var colMapp in collMappingApplicableTerritoryAddress.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originalitemlocationquantity.ApplicableTerritoryAddress[0], xmlMapping);
                }
                break;
            case "Price":
                if (originalitemlocationquantity.Price == null) return;
                GetField(originalitemlocationquantity.Price, xmlMapping);
                break;
            case "DeliveryUnit":
                if (originalitemlocationquantity.DeliveryUnit == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryUnit)
                {
                    foreach (var row in originalitemlocationquantity.DeliveryUnit)
                    {
                        collMappingDeliveryUnit.SetNewRowContext();

                        foreach (var colMapp in collMappingDeliveryUnit.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originalitemlocationquantity.DeliveryUnit[0], xmlMapping);
                }
                break;
            case "ApplicableTaxCategory":
                if (originalitemlocationquantity.ApplicableTaxCategory == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingApplicableTaxCategory)
                {
                    foreach (var row in originalitemlocationquantity.ApplicableTaxCategory)
                    {
                        collMappingApplicableTaxCategory.SetNewRowContext();

                        foreach (var colMapp in collMappingApplicableTaxCategory.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originalitemlocationquantity.ApplicableTaxCategory[0], xmlMapping);
                }
                break;
            case "Package":
                if (originalitemlocationquantity.Package == null) return;
                GetField(originalitemlocationquantity.Package, xmlMapping);
                break;
            case "AllowanceCharge":
                if (originalitemlocationquantity.AllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                {
                    foreach (var row in originalitemlocationquantity.AllowanceCharge)
                    {
                        collMappingAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(originalitemlocationquantity.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "DependentPriceReference":
                if (originalitemlocationquantity.DependentPriceReference == null) return;
                GetField(originalitemlocationquantity.DependentPriceReference, xmlMapping);
                break;

        }
    }
    public void GetField(PriceType price, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PriceAmount":
                if (price.PriceAmount == null) return;
                GetField(price.PriceAmount, xmlMapping);
                break;
            case "BaseQuantity":
                if (price.BaseQuantity == null) return;
                GetField(price.BaseQuantity, xmlMapping);
                break;
            case "PriceChangeReason":
                if (price.PriceChangeReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPriceChangeReason)
                {
                    foreach (var row in price.PriceChangeReason)
                    {
                        collMappingPriceChangeReason.SetNewRowContext();

                        foreach (var colMapp in collMappingPriceChangeReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(price.PriceChangeReason[0], xmlMapping);
                }
                break;
            case "PriceTypeCode":
                if (price.PriceTypeCode == null) return;
                GetField(price.PriceTypeCode, xmlMapping);
                break;
            case "PriceType1":
                if (price.PriceType1 == null) return;
                GetField(price.PriceType1, xmlMapping);
                break;
            case "OrderableUnitFactorRate":
                if (price.OrderableUnitFactorRate == null) return;
                GetField(price.OrderableUnitFactorRate, xmlMapping);
                break;
            case "ValidityPeriod":
                if (price.ValidityPeriod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod)
                {
                    foreach (var row in price.ValidityPeriod)
                    {
                        collMappingValidityPeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(price.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "PriceList":
                if (price.PriceList == null) return;
                GetField(price.PriceList, xmlMapping);
                break;
            case "AllowanceCharge":
                if (price.AllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge)
                {
                    foreach (var row in price.AllowanceCharge)
                    {
                        collMappingAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(price.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "PricingExchangeRate":
                if (price.PricingExchangeRate == null) return;
                GetField(price.PricingExchangeRate, xmlMapping);
                break;

        }
    }
    public void GetField(PriceListType pricelist, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (pricelist.ID == null) return;
                GetField(pricelist.ID, xmlMapping);
                break;
            case "StatusCode":
                if (pricelist.StatusCode == null) return;
                GetField(pricelist.StatusCode, xmlMapping);
                break;
            case "ValidityPeriod":
                if (pricelist.ValidityPeriod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod)
                {
                    foreach (var row in pricelist.ValidityPeriod)
                    {
                        collMappingValidityPeriod.SetNewRowContext();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(pricelist.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "PreviousPriceList":
                if (pricelist.PreviousPriceList == null) return;
                GetField(pricelist.PreviousPriceList, xmlMapping);
                break;

        }
    }
    public void GetField(ExchangeRateType pricingexchangerate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "SourceCurrencyCode":
                if (pricingexchangerate.SourceCurrencyCode == null) return;
                GetField(pricingexchangerate.SourceCurrencyCode, xmlMapping);
                break;
            case "SourceCurrencyBaseRate":
                if (pricingexchangerate.SourceCurrencyBaseRate == null) return;
                GetField(pricingexchangerate.SourceCurrencyBaseRate, xmlMapping);
                break;
            case "TargetCurrencyCode":
                if (pricingexchangerate.TargetCurrencyCode == null) return;
                GetField(pricingexchangerate.TargetCurrencyCode, xmlMapping);
                break;
            case "TargetCurrencyBaseRate":
                if (pricingexchangerate.TargetCurrencyBaseRate == null) return;
                GetField(pricingexchangerate.TargetCurrencyBaseRate, xmlMapping);
                break;
            case "ExchangeMarketID":
                if (pricingexchangerate.ExchangeMarketID == null) return;
                GetField(pricingexchangerate.ExchangeMarketID, xmlMapping);
                break;
            case "CalculationRate":
                if (pricingexchangerate.CalculationRate == null) return;
                GetField(pricingexchangerate.CalculationRate, xmlMapping);
                break;
            case "MathematicOperatorCode":
                if (pricingexchangerate.MathematicOperatorCode == null) return;
                GetField(pricingexchangerate.MathematicOperatorCode, xmlMapping);
                break;
            case "Date":
                if (pricingexchangerate.Date == null) return;
                GetField(pricingexchangerate.Date, xmlMapping);
                break;
            case "ForeignExchangeContract":
                if (pricingexchangerate.ForeignExchangeContract == null) return;
                GetField(pricingexchangerate.ForeignExchangeContract, xmlMapping);
                break;

        }
    }
    public void GetField(DependentPriceReferenceType dependentpricereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Percent":
                if (dependentpricereference.Percent == null) return;
                GetField(dependentpricereference.Percent, xmlMapping);
                break;
            case "LocationAddress":
                if (dependentpricereference.LocationAddress == null) return;
                GetField(dependentpricereference.LocationAddress, xmlMapping);
                break;
            case "DependentLineReference":
                if (dependentpricereference.DependentLineReference == null) return;
                GetField(dependentpricereference.DependentLineReference, xmlMapping);
                break;

        }
    }
    public void GetField(PaymentTermsType paymentterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentterms.ID == null) return;
                GetField(paymentterms.ID, xmlMapping);
                break;
            case "PaymentMeansID":
                if (paymentterms.PaymentMeansID == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeansID)
                {
                    foreach (var row in paymentterms.PaymentMeansID)
                    {
                        collMappingPaymentMeansID.SetNewRowContext();

                        foreach (var colMapp in collMappingPaymentMeansID.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(paymentterms.PaymentMeansID[0], xmlMapping);
                }
                break;
            case "PrepaidPaymentReferenceID":
                if (paymentterms.PrepaidPaymentReferenceID == null) return;
                GetField(paymentterms.PrepaidPaymentReferenceID, xmlMapping);
                break;
            case "Note":
                if (paymentterms.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in paymentterms.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(paymentterms.Note[0], xmlMapping);
                }
                break;
            case "ReferenceEventCode":
                if (paymentterms.ReferenceEventCode == null) return;
                GetField(paymentterms.ReferenceEventCode, xmlMapping);
                break;
            case "SettlementDiscountPercent":
                if (paymentterms.SettlementDiscountPercent == null) return;
                GetField(paymentterms.SettlementDiscountPercent, xmlMapping);
                break;
            case "PenaltySurchargePercent":
                if (paymentterms.PenaltySurchargePercent == null) return;
                GetField(paymentterms.PenaltySurchargePercent, xmlMapping);
                break;
            case "PaymentPercent":
                if (paymentterms.PaymentPercent == null) return;
                GetField(paymentterms.PaymentPercent, xmlMapping);
                break;
            case "Amount":
                if (paymentterms.Amount == null) return;
                GetField(paymentterms.Amount, xmlMapping);
                break;
            case "SettlementDiscountAmount":
                if (paymentterms.SettlementDiscountAmount == null) return;
                GetField(paymentterms.SettlementDiscountAmount, xmlMapping);
                break;
            case "PenaltyAmount":
                if (paymentterms.PenaltyAmount == null) return;
                GetField(paymentterms.PenaltyAmount, xmlMapping);
                break;
            case "PaymentTermsDetailsURI":
                if (paymentterms.PaymentTermsDetailsURI == null) return;
                GetField(paymentterms.PaymentTermsDetailsURI, xmlMapping);
                break;
            case "PaymentDueDate":
                if (paymentterms.PaymentDueDate == null) return;
                GetField(paymentterms.PaymentDueDate, xmlMapping);
                break;
            case "InstallmentDueDate":
                if (paymentterms.InstallmentDueDate == null) return;
                GetField(paymentterms.InstallmentDueDate, xmlMapping);
                break;
            case "InvoicingPartyReference":
                if (paymentterms.InvoicingPartyReference == null) return;
                GetField(paymentterms.InvoicingPartyReference, xmlMapping);
                break;
            case "SettlementPeriod":
                if (paymentterms.SettlementPeriod == null) return;
                GetField(paymentterms.SettlementPeriod, xmlMapping);
                break;
            case "PenaltyPeriod":
                if (paymentterms.PenaltyPeriod == null) return;
                GetField(paymentterms.PenaltyPeriod, xmlMapping);
                break;
            case "ExchangeRate":
                if (paymentterms.ExchangeRate == null) return;
                GetField(paymentterms.ExchangeRate, xmlMapping);
                break;
            case "ValidityPeriod":
                if (paymentterms.ValidityPeriod == null) return;
                GetField(paymentterms.ValidityPeriod, xmlMapping);
                break;

        }
    }
    public void GetField(PriceExtensionType itempriceextension, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Amount":
                if (itempriceextension.Amount == null) return;
                GetField(itempriceextension.Amount, xmlMapping);
                break;
            case "TaxTotal":
                if (itempriceextension.TaxTotal == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal)
                {
                    foreach (var row in itempriceextension.TaxTotal)
                    {
                        collMappingTaxTotal.SetNewRowContext();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(itempriceextension.TaxTotal[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(PickupType pickup, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (pickup.ID == null) return;
                GetField(pickup.ID, xmlMapping);
                break;
            case "ActualPickupDate":
                if (pickup.ActualPickupDate == null) return;
                GetField(pickup.ActualPickupDate, xmlMapping);
                break;
            case "ActualPickupTime":
                if (pickup.ActualPickupTime == null) return;
                GetField(pickup.ActualPickupTime, xmlMapping);
                break;
            case "EarliestPickupDate":
                if (pickup.EarliestPickupDate == null) return;
                GetField(pickup.EarliestPickupDate, xmlMapping);
                break;
            case "EarliestPickupTime":
                if (pickup.EarliestPickupTime == null) return;
                GetField(pickup.EarliestPickupTime, xmlMapping);
                break;
            case "LatestPickupDate":
                if (pickup.LatestPickupDate == null) return;
                GetField(pickup.LatestPickupDate, xmlMapping);
                break;
            case "LatestPickupTime":
                if (pickup.LatestPickupTime == null) return;
                GetField(pickup.LatestPickupTime, xmlMapping);
                break;
            case "PickupLocation":
                if (pickup.PickupLocation == null) return;
                GetField(pickup.PickupLocation, xmlMapping);
                break;
            case "PickupParty":
                if (pickup.PickupParty == null) return;
                GetField(pickup.PickupParty, xmlMapping);
                break;

        }
    }
    public void GetField(ReceiptLineType receivedhandlingunitreceiptline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (receivedhandlingunitreceiptline.ID == null) return;
                GetField(receivedhandlingunitreceiptline.ID, xmlMapping);
                break;
            case "UUID":
                if (receivedhandlingunitreceiptline.UUID == null) return;
                GetField(receivedhandlingunitreceiptline.UUID, xmlMapping);
                break;
            case "Note":
                if (receivedhandlingunitreceiptline.Note == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingNote)
                {
                    foreach (var row in receivedhandlingunitreceiptline.Note)
                    {
                        collMappingNote.SetNewRowContext();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.Note[0], xmlMapping);
                }
                break;
            case "ReceivedQuantity":
                if (receivedhandlingunitreceiptline.ReceivedQuantity == null) return;
                GetField(receivedhandlingunitreceiptline.ReceivedQuantity, xmlMapping);
                break;
            case "ShortQuantity":
                if (receivedhandlingunitreceiptline.ShortQuantity == null) return;
                GetField(receivedhandlingunitreceiptline.ShortQuantity, xmlMapping);
                break;
            case "ShortageActionCode":
                if (receivedhandlingunitreceiptline.ShortageActionCode == null) return;
                GetField(receivedhandlingunitreceiptline.ShortageActionCode, xmlMapping);
                break;
            case "RejectedQuantity":
                if (receivedhandlingunitreceiptline.RejectedQuantity == null) return;
                GetField(receivedhandlingunitreceiptline.RejectedQuantity, xmlMapping);
                break;
            case "RejectReasonCode":
                if (receivedhandlingunitreceiptline.RejectReasonCode == null) return;
                GetField(receivedhandlingunitreceiptline.RejectReasonCode, xmlMapping);
                break;
            case "RejectReason":
                if (receivedhandlingunitreceiptline.RejectReason == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingRejectReason)
                {
                    foreach (var row in receivedhandlingunitreceiptline.RejectReason)
                    {
                        collMappingRejectReason.SetNewRowContext();

                        foreach (var colMapp in collMappingRejectReason.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.RejectReason[0], xmlMapping);
                }
                break;
            case "RejectActionCode":
                if (receivedhandlingunitreceiptline.RejectActionCode == null) return;
                GetField(receivedhandlingunitreceiptline.RejectActionCode, xmlMapping);
                break;
            case "QuantityDiscrepancyCode":
                if (receivedhandlingunitreceiptline.QuantityDiscrepancyCode == null) return;
                GetField(receivedhandlingunitreceiptline.QuantityDiscrepancyCode, xmlMapping);
                break;
            case "OversupplyQuantity":
                if (receivedhandlingunitreceiptline.OversupplyQuantity == null) return;
                GetField(receivedhandlingunitreceiptline.OversupplyQuantity, xmlMapping);
                break;
            case "ReceivedDate":
                if (receivedhandlingunitreceiptline.ReceivedDate == null) return;
                GetField(receivedhandlingunitreceiptline.ReceivedDate, xmlMapping);
                break;
            case "TimingComplaintCode":
                if (receivedhandlingunitreceiptline.TimingComplaintCode == null) return;
                GetField(receivedhandlingunitreceiptline.TimingComplaintCode, xmlMapping);
                break;
            case "TimingComplaint":
                if (receivedhandlingunitreceiptline.TimingComplaint == null) return;
                GetField(receivedhandlingunitreceiptline.TimingComplaint, xmlMapping);
                break;
            case "OrderLineReference":
                if (receivedhandlingunitreceiptline.OrderLineReference == null) return;
                GetField(receivedhandlingunitreceiptline.OrderLineReference, xmlMapping);
                break;
            case "DespatchLineReference":
                if (receivedhandlingunitreceiptline.DespatchLineReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchLineReference)
                {
                    foreach (var row in receivedhandlingunitreceiptline.DespatchLineReference)
                    {
                        collMappingDespatchLineReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDespatchLineReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.DespatchLineReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (receivedhandlingunitreceiptline.DocumentReference == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference)
                {
                    foreach (var row in receivedhandlingunitreceiptline.DocumentReference)
                    {
                        collMappingDocumentReference.SetNewRowContext();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.DocumentReference[0], xmlMapping);
                }
                break;
            case "Item":
                if (receivedhandlingunitreceiptline.Item == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingItem)
                {
                    foreach (var row in receivedhandlingunitreceiptline.Item)
                    {
                        collMappingItem.SetNewRowContext();

                        foreach (var colMapp in collMappingItem.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.Item[0], xmlMapping);
                }
                break;
            case "Shipment":
                if (receivedhandlingunitreceiptline.Shipment == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingShipment)
                {
                    foreach (var row in receivedhandlingunitreceiptline.Shipment)
                    {
                        collMappingShipment.SetNewRowContext();

                        foreach (var colMapp in collMappingShipment.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(receivedhandlingunitreceiptline.Shipment[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(ShipmentStageType shipmentstage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (shipmentstage.ID == null) return;
                GetField(shipmentstage.ID, xmlMapping);
                break;
            case "TransportModeCode":
                if (shipmentstage.TransportModeCode == null) return;
                GetField(shipmentstage.TransportModeCode, xmlMapping);
                break;
            case "TransportMeansTypeCode":
                if (shipmentstage.TransportMeansTypeCode == null) return;
                GetField(shipmentstage.TransportMeansTypeCode, xmlMapping);
                break;
            case "TransitDirectionCode":
                if (shipmentstage.TransitDirectionCode == null) return;
                GetField(shipmentstage.TransitDirectionCode, xmlMapping);
                break;
            case "PreCarriageIndicator":
                if (shipmentstage.PreCarriageIndicator == null) return;
                GetField(shipmentstage.PreCarriageIndicator, xmlMapping);
                break;
            case "OnCarriageIndicator":
                if (shipmentstage.OnCarriageIndicator == null) return;
                GetField(shipmentstage.OnCarriageIndicator, xmlMapping);
                break;
            case "EstimatedDeliveryDate":
                if (shipmentstage.EstimatedDeliveryDate == null) return;
                GetField(shipmentstage.EstimatedDeliveryDate, xmlMapping);
                break;
            case "EstimatedDeliveryTime":
                if (shipmentstage.EstimatedDeliveryTime == null) return;
                GetField(shipmentstage.EstimatedDeliveryTime, xmlMapping);
                break;
            case "RequiredDeliveryDate":
                if (shipmentstage.RequiredDeliveryDate == null) return;
                GetField(shipmentstage.RequiredDeliveryDate, xmlMapping);
                break;
            case "RequiredDeliveryTime":
                if (shipmentstage.RequiredDeliveryTime == null) return;
                GetField(shipmentstage.RequiredDeliveryTime, xmlMapping);
                break;
            case "LoadingSequenceID":
                if (shipmentstage.LoadingSequenceID == null) return;
                GetField(shipmentstage.LoadingSequenceID, xmlMapping);
                break;
            case "SuccessiveSequenceID":
                if (shipmentstage.SuccessiveSequenceID == null) return;
                GetField(shipmentstage.SuccessiveSequenceID, xmlMapping);
                break;
            case "Instructions":
                if (shipmentstage.Instructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingInstructions)
                {
                    foreach (var row in shipmentstage.Instructions)
                    {
                        collMappingInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.Instructions[0], xmlMapping);
                }
                break;
            case "DemurrageInstructions":
                if (shipmentstage.DemurrageInstructions == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDemurrageInstructions)
                {
                    foreach (var row in shipmentstage.DemurrageInstructions)
                    {
                        collMappingDemurrageInstructions.SetNewRowContext();

                        foreach (var colMapp in collMappingDemurrageInstructions.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.DemurrageInstructions[0], xmlMapping);
                }
                break;
            case "CrewQuantity":
                if (shipmentstage.CrewQuantity == null) return;
                GetField(shipmentstage.CrewQuantity, xmlMapping);
                break;
            case "PassengerQuantity":
                if (shipmentstage.PassengerQuantity == null) return;
                GetField(shipmentstage.PassengerQuantity, xmlMapping);
                break;
            case "TransitPeriod":
                if (shipmentstage.TransitPeriod == null) return;
                GetField(shipmentstage.TransitPeriod, xmlMapping);
                break;
            case "CarrierParty":
                if (shipmentstage.CarrierParty == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCarrierParty)
                {
                    foreach (var row in shipmentstage.CarrierParty)
                    {
                        collMappingCarrierParty.SetNewRowContext();

                        foreach (var colMapp in collMappingCarrierParty.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.CarrierParty[0], xmlMapping);
                }
                break;
            case "TransportMeans":
                if (shipmentstage.TransportMeans == null) return;
                GetField(shipmentstage.TransportMeans, xmlMapping);
                break;
            case "LoadingPortLocation":
                if (shipmentstage.LoadingPortLocation == null) return;
                GetField(shipmentstage.LoadingPortLocation, xmlMapping);
                break;
            case "UnloadingPortLocation":
                if (shipmentstage.UnloadingPortLocation == null) return;
                GetField(shipmentstage.UnloadingPortLocation, xmlMapping);
                break;
            case "TransshipPortLocation":
                if (shipmentstage.TransshipPortLocation == null) return;
                GetField(shipmentstage.TransshipPortLocation, xmlMapping);
                break;
            case "LoadingTransportEvent":
                if (shipmentstage.LoadingTransportEvent == null) return;
                GetField(shipmentstage.LoadingTransportEvent, xmlMapping);
                break;
            case "ExaminationTransportEvent":
                if (shipmentstage.ExaminationTransportEvent == null) return;
                GetField(shipmentstage.ExaminationTransportEvent, xmlMapping);
                break;
            case "AvailabilityTransportEvent":
                if (shipmentstage.AvailabilityTransportEvent == null) return;
                GetField(shipmentstage.AvailabilityTransportEvent, xmlMapping);
                break;
            case "ExportationTransportEvent":
                if (shipmentstage.ExportationTransportEvent == null) return;
                GetField(shipmentstage.ExportationTransportEvent, xmlMapping);
                break;
            case "DischargeTransportEvent":
                if (shipmentstage.DischargeTransportEvent == null) return;
                GetField(shipmentstage.DischargeTransportEvent, xmlMapping);
                break;
            case "WarehousingTransportEvent":
                if (shipmentstage.WarehousingTransportEvent == null) return;
                GetField(shipmentstage.WarehousingTransportEvent, xmlMapping);
                break;
            case "TakeoverTransportEvent":
                if (shipmentstage.TakeoverTransportEvent == null) return;
                GetField(shipmentstage.TakeoverTransportEvent, xmlMapping);
                break;
            case "OptionalTakeoverTransportEvent":
                if (shipmentstage.OptionalTakeoverTransportEvent == null) return;
                GetField(shipmentstage.OptionalTakeoverTransportEvent, xmlMapping);
                break;
            case "DropoffTransportEvent":
                if (shipmentstage.DropoffTransportEvent == null) return;
                GetField(shipmentstage.DropoffTransportEvent, xmlMapping);
                break;
            case "ActualPickupTransportEvent":
                if (shipmentstage.ActualPickupTransportEvent == null) return;
                GetField(shipmentstage.ActualPickupTransportEvent, xmlMapping);
                break;
            case "DeliveryTransportEvent":
                if (shipmentstage.DeliveryTransportEvent == null) return;
                GetField(shipmentstage.DeliveryTransportEvent, xmlMapping);
                break;
            case "ReceiptTransportEvent":
                if (shipmentstage.ReceiptTransportEvent == null) return;
                GetField(shipmentstage.ReceiptTransportEvent, xmlMapping);
                break;
            case "StorageTransportEvent":
                if (shipmentstage.StorageTransportEvent == null) return;
                GetField(shipmentstage.StorageTransportEvent, xmlMapping);
                break;
            case "AcceptanceTransportEvent":
                if (shipmentstage.AcceptanceTransportEvent == null) return;
                GetField(shipmentstage.AcceptanceTransportEvent, xmlMapping);
                break;
            case "TerminalOperatorParty":
                if (shipmentstage.TerminalOperatorParty == null) return;
                GetField(shipmentstage.TerminalOperatorParty, xmlMapping);
                break;
            case "CustomsAgentParty":
                if (shipmentstage.CustomsAgentParty == null) return;
                GetField(shipmentstage.CustomsAgentParty, xmlMapping);
                break;
            case "EstimatedTransitPeriod":
                if (shipmentstage.EstimatedTransitPeriod == null) return;
                GetField(shipmentstage.EstimatedTransitPeriod, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (shipmentstage.FreightAllowanceCharge == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge)
                {
                    foreach (var row in shipmentstage.FreightAllowanceCharge)
                    {
                        collMappingFreightAllowanceCharge.SetNewRowContext();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "FreightChargeLocation":
                if (shipmentstage.FreightChargeLocation == null) return;
                GetField(shipmentstage.FreightChargeLocation, xmlMapping);
                break;
            case "DetentionTransportEvent":
                if (shipmentstage.DetentionTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDetentionTransportEvent)
                {
                    foreach (var row in shipmentstage.DetentionTransportEvent)
                    {
                        collMappingDetentionTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingDetentionTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.DetentionTransportEvent[0], xmlMapping);
                }
                break;
            case "RequestedDepartureTransportEvent":
                if (shipmentstage.RequestedDepartureTransportEvent == null) return;
                GetField(shipmentstage.RequestedDepartureTransportEvent, xmlMapping);
                break;
            case "RequestedArrivalTransportEvent":
                if (shipmentstage.RequestedArrivalTransportEvent == null) return;
                GetField(shipmentstage.RequestedArrivalTransportEvent, xmlMapping);
                break;
            case "RequestedWaypointTransportEvent":
                if (shipmentstage.RequestedWaypointTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingRequestedWaypointTransportEvent)
                {
                    foreach (var row in shipmentstage.RequestedWaypointTransportEvent)
                    {
                        collMappingRequestedWaypointTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingRequestedWaypointTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.RequestedWaypointTransportEvent[0], xmlMapping);
                }
                break;
            case "PlannedDepartureTransportEvent":
                if (shipmentstage.PlannedDepartureTransportEvent == null) return;
                GetField(shipmentstage.PlannedDepartureTransportEvent, xmlMapping);
                break;
            case "PlannedArrivalTransportEvent":
                if (shipmentstage.PlannedArrivalTransportEvent == null) return;
                GetField(shipmentstage.PlannedArrivalTransportEvent, xmlMapping);
                break;
            case "PlannedWaypointTransportEvent":
                if (shipmentstage.PlannedWaypointTransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPlannedWaypointTransportEvent)
                {
                    foreach (var row in shipmentstage.PlannedWaypointTransportEvent)
                    {
                        collMappingPlannedWaypointTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingPlannedWaypointTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.PlannedWaypointTransportEvent[0], xmlMapping);
                }
                break;
            case "ActualDepartureTransportEvent":
                if (shipmentstage.ActualDepartureTransportEvent == null) return;
                GetField(shipmentstage.ActualDepartureTransportEvent, xmlMapping);
                break;
            case "ActualWaypointTransportEvent":
                if (shipmentstage.ActualWaypointTransportEvent == null) return;
                GetField(shipmentstage.ActualWaypointTransportEvent, xmlMapping);
                break;
            case "ActualArrivalTransportEvent":
                if (shipmentstage.ActualArrivalTransportEvent == null) return;
                GetField(shipmentstage.ActualArrivalTransportEvent, xmlMapping);
                break;
            case "TransportEvent":
                if (shipmentstage.TransportEvent == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent)
                {
                    foreach (var row in shipmentstage.TransportEvent)
                    {
                        collMappingTransportEvent.SetNewRowContext();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.TransportEvent[0], xmlMapping);
                }
                break;
            case "EstimatedDepartureTransportEvent":
                if (shipmentstage.EstimatedDepartureTransportEvent == null) return;
                GetField(shipmentstage.EstimatedDepartureTransportEvent, xmlMapping);
                break;
            case "EstimatedArrivalTransportEvent":
                if (shipmentstage.EstimatedArrivalTransportEvent == null) return;
                GetField(shipmentstage.EstimatedArrivalTransportEvent, xmlMapping);
                break;
            case "PassengerPerson":
                if (shipmentstage.PassengerPerson == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingPassengerPerson)
                {
                    foreach (var row in shipmentstage.PassengerPerson)
                    {
                        collMappingPassengerPerson.SetNewRowContext();

                        foreach (var colMapp in collMappingPassengerPerson.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.PassengerPerson[0], xmlMapping);
                }
                break;
            case "DriverPerson":
                if (shipmentstage.DriverPerson == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDriverPerson)
                {
                    foreach (var row in shipmentstage.DriverPerson)
                    {
                        collMappingDriverPerson.SetNewRowContext();

                        foreach (var colMapp in collMappingDriverPerson.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.DriverPerson[0], xmlMapping);
                }
                break;
            case "ReportingPerson":
                if (shipmentstage.ReportingPerson == null) return;
                GetField(shipmentstage.ReportingPerson, xmlMapping);
                break;
            case "CrewMemberPerson":
                if (shipmentstage.CrewMemberPerson == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingCrewMemberPerson)
                {
                    foreach (var row in shipmentstage.CrewMemberPerson)
                    {
                        collMappingCrewMemberPerson.SetNewRowContext();

                        foreach (var colMapp in collMappingCrewMemberPerson.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(shipmentstage.CrewMemberPerson[0], xmlMapping);
                }
                break;
            case "SecurityOfficerPerson":
                if (shipmentstage.SecurityOfficerPerson == null) return;
                GetField(shipmentstage.SecurityOfficerPerson, xmlMapping);
                break;
            case "MasterPerson":
                if (shipmentstage.MasterPerson == null) return;
                GetField(shipmentstage.MasterPerson, xmlMapping);
                break;
            case "ShipsSurgeonPerson":
                if (shipmentstage.ShipsSurgeonPerson == null) return;
                GetField(shipmentstage.ShipsSurgeonPerson, xmlMapping);
                break;

        }
    }
    public void GetField(EnvironmentalEmissionType environmentalemission, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "EnvironmentalEmissionTypeCode":
                if (environmentalemission.EnvironmentalEmissionTypeCode == null) return;
                GetField(environmentalemission.EnvironmentalEmissionTypeCode, xmlMapping);
                break;
            case "ValueMeasure":
                if (environmentalemission.ValueMeasure == null) return;
                GetField(environmentalemission.ValueMeasure, xmlMapping);
                break;
            case "Description":
                if (environmentalemission.Description == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingDescription)
                {
                    foreach (var row in environmentalemission.Description)
                    {
                        collMappingDescription.SetNewRowContext();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(environmentalemission.Description[0], xmlMapping);
                }
                break;
            case "EmissionCalculationMethod":
                if (environmentalemission.EmissionCalculationMethod == null) return;
                if (xmlMapping is IXmlCollectionMapping collMappingEmissionCalculationMethod)
                {
                    foreach (var row in environmentalemission.EmissionCalculationMethod)
                    {
                        collMappingEmissionCalculationMethod.SetNewRowContext();

                        foreach (var colMapp in collMappingEmissionCalculationMethod.ColumnsMapping)
                        {
                            GetField(row, colMapp);
                            colMapp.ResetNodePath();
                        }
                    }
                }
                else
                {
                    GetField(environmentalemission.EmissionCalculationMethod[0], xmlMapping);
                }
                break;

        }
    }
    public void GetField(EmissionCalculationMethodType emissioncalculationmethod, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CalculationMethodCode":
                if (emissioncalculationmethod.CalculationMethodCode == null) return;
                GetField(emissioncalculationmethod.CalculationMethodCode, xmlMapping);
                break;
            case "FullnessIndicationCode":
                if (emissioncalculationmethod.FullnessIndicationCode == null) return;
                GetField(emissioncalculationmethod.FullnessIndicationCode, xmlMapping);
                break;
            case "MeasurementFromLocation":
                if (emissioncalculationmethod.MeasurementFromLocation == null) return;
                GetField(emissioncalculationmethod.MeasurementFromLocation, xmlMapping);
                break;
            case "MeasurementToLocation":
                if (emissioncalculationmethod.MeasurementToLocation == null) return;
                GetField(emissioncalculationmethod.MeasurementToLocation, xmlMapping);
                break;

        }
    }
    public void GetField(ServiceFrequencyType scheduledservicefrequency, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "WeekDayCode":
                if (scheduledservicefrequency.WeekDayCode == null) return;
                GetField(scheduledservicefrequency.WeekDayCode, xmlMapping);
                break;

        }
    }
    public void GetField(PaymentType prepaidpayment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (prepaidpayment.ID == null) return;
                GetField(prepaidpayment.ID, xmlMapping);
                break;
            case "PaidAmount":
                if (prepaidpayment.PaidAmount == null) return;
                GetField(prepaidpayment.PaidAmount, xmlMapping);
                break;
            case "ReceivedDate":
                if (prepaidpayment.ReceivedDate == null) return;
                GetField(prepaidpayment.ReceivedDate, xmlMapping);
                break;
            case "PaidDate":
                if (prepaidpayment.PaidDate == null) return;
                GetField(prepaidpayment.PaidDate, xmlMapping);
                break;
            case "PaidTime":
                if (prepaidpayment.PaidTime == null) return;
                GetField(prepaidpayment.PaidTime, xmlMapping);
                break;
            case "InstructionID":
                if (prepaidpayment.InstructionID == null) return;
                GetField(prepaidpayment.InstructionID, xmlMapping);
                break;

        }
    }
    public void GetField(MonetaryTotalType legalmonetarytotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineExtensionAmount":
                if (legalmonetarytotal.LineExtensionAmount == null) return;
                GetField(legalmonetarytotal.LineExtensionAmount, xmlMapping);
                break;
            case "TaxExclusiveAmount":
                if (legalmonetarytotal.TaxExclusiveAmount == null) return;
                GetField(legalmonetarytotal.TaxExclusiveAmount, xmlMapping);
                break;
            case "TaxInclusiveAmount":
                if (legalmonetarytotal.TaxInclusiveAmount == null) return;
                GetField(legalmonetarytotal.TaxInclusiveAmount, xmlMapping);
                break;
            case "AllowanceTotalAmount":
                if (legalmonetarytotal.AllowanceTotalAmount == null) return;
                GetField(legalmonetarytotal.AllowanceTotalAmount, xmlMapping);
                break;
            case "ChargeTotalAmount":
                if (legalmonetarytotal.ChargeTotalAmount == null) return;
                GetField(legalmonetarytotal.ChargeTotalAmount, xmlMapping);
                break;
            case "PrepaidAmount":
                if (legalmonetarytotal.PrepaidAmount == null) return;
                GetField(legalmonetarytotal.PrepaidAmount, xmlMapping);
                break;
            case "PayableRoundingAmount":
                if (legalmonetarytotal.PayableRoundingAmount == null) return;
                GetField(legalmonetarytotal.PayableRoundingAmount, xmlMapping);
                break;
            case "PayableAmount":
                if (legalmonetarytotal.PayableAmount == null) return;
                GetField(legalmonetarytotal.PayableAmount, xmlMapping);
                break;
            case "PayableAlternativeAmount":
                if (legalmonetarytotal.PayableAlternativeAmount == null) return;
                GetField(legalmonetarytotal.PayableAlternativeAmount, xmlMapping);
                break;

        }
    }
}
}
