using System;
using System.Xml;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;

public class InvoiceTypeSet
{
    public void SetField(InvoiceType invoicetype, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "UBLExtensions":
                if (xmlMapping is IXmlCollectionMapping collMappingUBLExtensions && !collMappingUBLExtensions.HasNextNode)
                {
                    if (invoicetype.UBLExtensions == null)
                        invoicetype.UBLExtensions = new UBLExtensionType[collMappingUBLExtensions.Quantity];

                    for (int i = 0; i < collMappingUBLExtensions.Quantity; i++)
                    {
                        var row = invoicetype.UBLExtensions[i] = new UBLExtensionType();

                        foreach (var colMapp in collMappingUBLExtensions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.UBLExtensions == null)
                    {
                        invoicetype.UBLExtensions = new UBLExtensionType[1];
                        invoicetype.UBLExtensions[0] = new UBLExtensionType();
                    }
                    SetField(invoicetype.UBLExtensions[0], xmlMapping);
                }
                break;
            case "UBLVersionID":
                if (invoicetype.UBLVersionID == null)
                    invoicetype.UBLVersionID = new UBLVersionIDType();
                SetField(invoicetype.UBLVersionID, xmlMapping);
                break;
            case "CustomizationID":
                if (invoicetype.CustomizationID == null)
                    invoicetype.CustomizationID = new CustomizationIDType();
                SetField(invoicetype.CustomizationID, xmlMapping);
                break;
            case "ProfileID":
                if (invoicetype.ProfileID == null)
                    invoicetype.ProfileID = new ProfileIDType();
                SetField(invoicetype.ProfileID, xmlMapping);
                break;
            case "ProfileExecutionID":
                if (invoicetype.ProfileExecutionID == null)
                    invoicetype.ProfileExecutionID = new ProfileExecutionIDType();
                SetField(invoicetype.ProfileExecutionID, xmlMapping);
                break;
            case "ID":
                if (invoicetype.ID == null)
                    invoicetype.ID = new IDType();
                SetField(invoicetype.ID, xmlMapping);
                break;
            case "CopyIndicator":
                if (invoicetype.CopyIndicator == null)
                    invoicetype.CopyIndicator = new CopyIndicatorType();
                SetField(invoicetype.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (invoicetype.UUID == null)
                    invoicetype.UUID = new UUIDType();
                SetField(invoicetype.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (invoicetype.IssueDate == null)
                    invoicetype.IssueDate = new IssueDateType();
                SetField(invoicetype.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (invoicetype.IssueTime == null)
                    invoicetype.IssueTime = new IssueTimeType();
                SetField(invoicetype.IssueTime, xmlMapping);
                break;
            case "DueDate":
                if (invoicetype.DueDate == null)
                    invoicetype.DueDate = new DueDateType();
                SetField(invoicetype.DueDate, xmlMapping);
                break;
            case "InvoiceTypeCode":
                if (invoicetype.InvoiceTypeCode == null)
                    invoicetype.InvoiceTypeCode = new InvoiceTypeCodeType();
                SetField(invoicetype.InvoiceTypeCode, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (invoicetype.Note == null)
                        invoicetype.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = invoicetype.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.Note == null)
                    {
                        invoicetype.Note = new NoteType[1];
                        invoicetype.Note[0] = new NoteType();
                    }
                    SetField(invoicetype.Note[0], xmlMapping);
                }
                break;
            case "TaxPointDate":
                if (invoicetype.TaxPointDate == null)
                    invoicetype.TaxPointDate = new TaxPointDateType();
                SetField(invoicetype.TaxPointDate, xmlMapping);
                break;
            case "DocumentCurrencyCode":
                if (invoicetype.DocumentCurrencyCode == null)
                    invoicetype.DocumentCurrencyCode = new DocumentCurrencyCodeType();
                SetField(invoicetype.DocumentCurrencyCode, xmlMapping);
                break;
            case "TaxCurrencyCode":
                if (invoicetype.TaxCurrencyCode == null)
                    invoicetype.TaxCurrencyCode = new TaxCurrencyCodeType();
                SetField(invoicetype.TaxCurrencyCode, xmlMapping);
                break;
            case "PricingCurrencyCode":
                if (invoicetype.PricingCurrencyCode == null)
                    invoicetype.PricingCurrencyCode = new PricingCurrencyCodeType();
                SetField(invoicetype.PricingCurrencyCode, xmlMapping);
                break;
            case "PaymentCurrencyCode":
                if (invoicetype.PaymentCurrencyCode == null)
                    invoicetype.PaymentCurrencyCode = new PaymentCurrencyCodeType();
                SetField(invoicetype.PaymentCurrencyCode, xmlMapping);
                break;
            case "PaymentAlternativeCurrencyCode":
                if (invoicetype.PaymentAlternativeCurrencyCode == null)
                    invoicetype.PaymentAlternativeCurrencyCode = new PaymentAlternativeCurrencyCodeType();
                SetField(invoicetype.PaymentAlternativeCurrencyCode, xmlMapping);
                break;
            case "AccountingCostCode":
                if (invoicetype.AccountingCostCode == null)
                    invoicetype.AccountingCostCode = new AccountingCostCodeType();
                SetField(invoicetype.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (invoicetype.AccountingCost == null)
                    invoicetype.AccountingCost = new AccountingCostType();
                SetField(invoicetype.AccountingCost, xmlMapping);
                break;
            case "LineCountNumeric":
                if (invoicetype.LineCountNumeric == null)
                    invoicetype.LineCountNumeric = new LineCountNumericType();
                SetField(invoicetype.LineCountNumeric, xmlMapping);
                break;
            case "BuyerReference":
                if (invoicetype.BuyerReference == null)
                    invoicetype.BuyerReference = new BuyerReferenceType();
                SetField(invoicetype.BuyerReference, xmlMapping);
                break;
            case "InvoicePeriod":
                if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod && !collMappingInvoicePeriod.HasNextNode)
                {
                    if (invoicetype.InvoicePeriod == null)
                        invoicetype.InvoicePeriod = new PeriodType[collMappingInvoicePeriod.Quantity];

                    for (int i = 0; i < collMappingInvoicePeriod.Quantity; i++)
                    {
                        var row = invoicetype.InvoicePeriod[i] = new PeriodType();

                        foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.InvoicePeriod == null)
                    {
                        invoicetype.InvoicePeriod = new PeriodType[1];
                        invoicetype.InvoicePeriod[0] = new PeriodType();
                    }
                    SetField(invoicetype.InvoicePeriod[0], xmlMapping);
                }
                break;
            case "OrderReference":
                if (invoicetype.OrderReference == null)
                    invoicetype.OrderReference = new OrderReferenceType();
                SetField(invoicetype.OrderReference, xmlMapping);
                break;
            case "BillingReference":
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReference && !collMappingBillingReference.HasNextNode)
                {
                    if (invoicetype.BillingReference == null)
                        invoicetype.BillingReference = new BillingReferenceType[collMappingBillingReference.Quantity];

                    for (int i = 0; i < collMappingBillingReference.Quantity; i++)
                    {
                        var row = invoicetype.BillingReference[i] = new BillingReferenceType();

                        foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.BillingReference == null)
                    {
                        invoicetype.BillingReference = new BillingReferenceType[1];
                        invoicetype.BillingReference[0] = new BillingReferenceType();
                    }
                    SetField(invoicetype.BillingReference[0], xmlMapping);
                }
                break;
            case "DespatchDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchDocumentReference && !collMappingDespatchDocumentReference.HasNextNode)
                {
                    if (invoicetype.DespatchDocumentReference == null)
                        invoicetype.DespatchDocumentReference = new DocumentReferenceType[collMappingDespatchDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDespatchDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.DespatchDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDespatchDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.DespatchDocumentReference == null)
                    {
                        invoicetype.DespatchDocumentReference = new DocumentReferenceType[1];
                        invoicetype.DespatchDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.DespatchDocumentReference[0], xmlMapping);
                }
                break;
            case "ReceiptDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingReceiptDocumentReference && !collMappingReceiptDocumentReference.HasNextNode)
                {
                    if (invoicetype.ReceiptDocumentReference == null)
                        invoicetype.ReceiptDocumentReference = new DocumentReferenceType[collMappingReceiptDocumentReference.Quantity];

                    for (int i = 0; i < collMappingReceiptDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.ReceiptDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingReceiptDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.ReceiptDocumentReference == null)
                    {
                        invoicetype.ReceiptDocumentReference = new DocumentReferenceType[1];
                        invoicetype.ReceiptDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.ReceiptDocumentReference[0], xmlMapping);
                }
                break;
            case "StatementDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingStatementDocumentReference && !collMappingStatementDocumentReference.HasNextNode)
                {
                    if (invoicetype.StatementDocumentReference == null)
                        invoicetype.StatementDocumentReference = new DocumentReferenceType[collMappingStatementDocumentReference.Quantity];

                    for (int i = 0; i < collMappingStatementDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.StatementDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingStatementDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.StatementDocumentReference == null)
                    {
                        invoicetype.StatementDocumentReference = new DocumentReferenceType[1];
                        invoicetype.StatementDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.StatementDocumentReference[0], xmlMapping);
                }
                break;
            case "OriginatorDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingOriginatorDocumentReference && !collMappingOriginatorDocumentReference.HasNextNode)
                {
                    if (invoicetype.OriginatorDocumentReference == null)
                        invoicetype.OriginatorDocumentReference = new DocumentReferenceType[collMappingOriginatorDocumentReference.Quantity];

                    for (int i = 0; i < collMappingOriginatorDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.OriginatorDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingOriginatorDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.OriginatorDocumentReference == null)
                    {
                        invoicetype.OriginatorDocumentReference = new DocumentReferenceType[1];
                        invoicetype.OriginatorDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.OriginatorDocumentReference[0], xmlMapping);
                }
                break;
            case "ContractDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference && !collMappingContractDocumentReference.HasNextNode)
                {
                    if (invoicetype.ContractDocumentReference == null)
                        invoicetype.ContractDocumentReference = new DocumentReferenceType[collMappingContractDocumentReference.Quantity];

                    for (int i = 0; i < collMappingContractDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.ContractDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.ContractDocumentReference == null)
                    {
                        invoicetype.ContractDocumentReference = new DocumentReferenceType[1];
                        invoicetype.ContractDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.ContractDocumentReference[0], xmlMapping);
                }
                break;
            case "AdditionalDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalDocumentReference && !collMappingAdditionalDocumentReference.HasNextNode)
                {
                    if (invoicetype.AdditionalDocumentReference == null)
                        invoicetype.AdditionalDocumentReference = new DocumentReferenceType[collMappingAdditionalDocumentReference.Quantity];

                    for (int i = 0; i < collMappingAdditionalDocumentReference.Quantity; i++)
                    {
                        var row = invoicetype.AdditionalDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingAdditionalDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.AdditionalDocumentReference == null)
                    {
                        invoicetype.AdditionalDocumentReference = new DocumentReferenceType[1];
                        invoicetype.AdditionalDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoicetype.AdditionalDocumentReference[0], xmlMapping);
                }
                break;
            case "ProjectReference":
                if (xmlMapping is IXmlCollectionMapping collMappingProjectReference && !collMappingProjectReference.HasNextNode)
                {
                    if (invoicetype.ProjectReference == null)
                        invoicetype.ProjectReference = new ProjectReferenceType[collMappingProjectReference.Quantity];

                    for (int i = 0; i < collMappingProjectReference.Quantity; i++)
                    {
                        var row = invoicetype.ProjectReference[i] = new ProjectReferenceType();

                        foreach (var colMapp in collMappingProjectReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.ProjectReference == null)
                    {
                        invoicetype.ProjectReference = new ProjectReferenceType[1];
                        invoicetype.ProjectReference[0] = new ProjectReferenceType();
                    }
                    SetField(invoicetype.ProjectReference[0], xmlMapping);
                }
                break;
            case "Signature":
                if (xmlMapping is IXmlCollectionMapping collMappingSignature && !collMappingSignature.HasNextNode)
                {
                    if (invoicetype.Signature == null)
                        invoicetype.Signature = new SignatureType[collMappingSignature.Quantity];

                    for (int i = 0; i < collMappingSignature.Quantity; i++)
                    {
                        var row = invoicetype.Signature[i] = new SignatureType();

                        foreach (var colMapp in collMappingSignature.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.Signature == null)
                    {
                        invoicetype.Signature = new SignatureType[1];
                        invoicetype.Signature[0] = new SignatureType();
                    }
                    SetField(invoicetype.Signature[0], xmlMapping);
                }
                break;
            case "AccountingSupplierParty":
                if (invoicetype.AccountingSupplierParty == null)
                    invoicetype.AccountingSupplierParty = new SupplierPartyType();
                SetField(invoicetype.AccountingSupplierParty, xmlMapping);
                break;
            case "AccountingCustomerParty":
                if (invoicetype.AccountingCustomerParty == null)
                    invoicetype.AccountingCustomerParty = new CustomerPartyType();
                SetField(invoicetype.AccountingCustomerParty, xmlMapping);
                break;
            case "PayeeParty":
                if (invoicetype.PayeeParty == null)
                    invoicetype.PayeeParty = new PartyType();
                SetField(invoicetype.PayeeParty, xmlMapping);
                break;
            case "BuyerCustomerParty":
                if (invoicetype.BuyerCustomerParty == null)
                    invoicetype.BuyerCustomerParty = new CustomerPartyType();
                SetField(invoicetype.BuyerCustomerParty, xmlMapping);
                break;
            case "SellerSupplierParty":
                if (invoicetype.SellerSupplierParty == null)
                    invoicetype.SellerSupplierParty = new SupplierPartyType();
                SetField(invoicetype.SellerSupplierParty, xmlMapping);
                break;
            case "TaxRepresentativeParty":
                if (invoicetype.TaxRepresentativeParty == null)
                    invoicetype.TaxRepresentativeParty = new PartyType();
                SetField(invoicetype.TaxRepresentativeParty, xmlMapping);
                break;
            case "Delivery":
                if (xmlMapping is IXmlCollectionMapping collMappingDelivery && !collMappingDelivery.HasNextNode)
                {
                    if (invoicetype.Delivery == null)
                        invoicetype.Delivery = new DeliveryType[collMappingDelivery.Quantity];

                    for (int i = 0; i < collMappingDelivery.Quantity; i++)
                    {
                        var row = invoicetype.Delivery[i] = new DeliveryType();

                        foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.Delivery == null)
                    {
                        invoicetype.Delivery = new DeliveryType[1];
                        invoicetype.Delivery[0] = new DeliveryType();
                    }
                    SetField(invoicetype.Delivery[0], xmlMapping);
                }
                break;
            case "DeliveryTerms":
                if (invoicetype.DeliveryTerms == null)
                    invoicetype.DeliveryTerms = new DeliveryTermsType();
                SetField(invoicetype.DeliveryTerms, xmlMapping);
                break;
            case "PaymentMeans":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans && !collMappingPaymentMeans.HasNextNode)
                {
                    if (invoicetype.PaymentMeans == null)
                        invoicetype.PaymentMeans = new PaymentMeansType[collMappingPaymentMeans.Quantity];

                    for (int i = 0; i < collMappingPaymentMeans.Quantity; i++)
                    {
                        var row = invoicetype.PaymentMeans[i] = new PaymentMeansType();

                        foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.PaymentMeans == null)
                    {
                        invoicetype.PaymentMeans = new PaymentMeansType[1];
                        invoicetype.PaymentMeans[0] = new PaymentMeansType();
                    }
                    SetField(invoicetype.PaymentMeans[0], xmlMapping);
                }
                break;
            case "PaymentTerms":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms && !collMappingPaymentTerms.HasNextNode)
                {
                    if (invoicetype.PaymentTerms == null)
                        invoicetype.PaymentTerms = new PaymentTermsType[collMappingPaymentTerms.Quantity];

                    for (int i = 0; i < collMappingPaymentTerms.Quantity; i++)
                    {
                        var row = invoicetype.PaymentTerms[i] = new PaymentTermsType();

                        foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.PaymentTerms == null)
                    {
                        invoicetype.PaymentTerms = new PaymentTermsType[1];
                        invoicetype.PaymentTerms[0] = new PaymentTermsType();
                    }
                    SetField(invoicetype.PaymentTerms[0], xmlMapping);
                }
                break;
            case "PrepaidPayment":
                if (xmlMapping is IXmlCollectionMapping collMappingPrepaidPayment && !collMappingPrepaidPayment.HasNextNode)
                {
                    if (invoicetype.PrepaidPayment == null)
                        invoicetype.PrepaidPayment = new PaymentType[collMappingPrepaidPayment.Quantity];

                    for (int i = 0; i < collMappingPrepaidPayment.Quantity; i++)
                    {
                        var row = invoicetype.PrepaidPayment[i] = new PaymentType();

                        foreach (var colMapp in collMappingPrepaidPayment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.PrepaidPayment == null)
                    {
                        invoicetype.PrepaidPayment = new PaymentType[1];
                        invoicetype.PrepaidPayment[0] = new PaymentType();
                    }
                    SetField(invoicetype.PrepaidPayment[0], xmlMapping);
                }
                break;
            case "AllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge && !collMappingAllowanceCharge.HasNextNode)
                {
                    if (invoicetype.AllowanceCharge == null)
                        invoicetype.AllowanceCharge = new AllowanceChargeType[collMappingAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingAllowanceCharge.Quantity; i++)
                    {
                        var row = invoicetype.AllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.AllowanceCharge == null)
                    {
                        invoicetype.AllowanceCharge = new AllowanceChargeType[1];
                        invoicetype.AllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(invoicetype.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "TaxExchangeRate":
                if (invoicetype.TaxExchangeRate == null)
                    invoicetype.TaxExchangeRate = new ExchangeRateType();
                SetField(invoicetype.TaxExchangeRate, xmlMapping);
                break;
            case "PricingExchangeRate":
                if (invoicetype.PricingExchangeRate == null)
                    invoicetype.PricingExchangeRate = new ExchangeRateType();
                SetField(invoicetype.PricingExchangeRate, xmlMapping);
                break;
            case "PaymentExchangeRate":
                if (invoicetype.PaymentExchangeRate == null)
                    invoicetype.PaymentExchangeRate = new ExchangeRateType();
                SetField(invoicetype.PaymentExchangeRate, xmlMapping);
                break;
            case "PaymentAlternativeExchangeRate":
                if (invoicetype.PaymentAlternativeExchangeRate == null)
                    invoicetype.PaymentAlternativeExchangeRate = new ExchangeRateType();
                SetField(invoicetype.PaymentAlternativeExchangeRate, xmlMapping);
                break;
            case "TaxTotal":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal && !collMappingTaxTotal.HasNextNode)
                {
                    if (invoicetype.TaxTotal == null)
                        invoicetype.TaxTotal = new TaxTotalType[collMappingTaxTotal.Quantity];

                    for (int i = 0; i < collMappingTaxTotal.Quantity; i++)
                    {
                        var row = invoicetype.TaxTotal[i] = new TaxTotalType();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.TaxTotal == null)
                    {
                        invoicetype.TaxTotal = new TaxTotalType[1];
                        invoicetype.TaxTotal[0] = new TaxTotalType();
                    }
                    SetField(invoicetype.TaxTotal[0], xmlMapping);
                }
                break;
            case "WithholdingTaxTotal":
                if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal && !collMappingWithholdingTaxTotal.HasNextNode)
                {
                    if (invoicetype.WithholdingTaxTotal == null)
                        invoicetype.WithholdingTaxTotal = new TaxTotalType[collMappingWithholdingTaxTotal.Quantity];

                    for (int i = 0; i < collMappingWithholdingTaxTotal.Quantity; i++)
                    {
                        var row = invoicetype.WithholdingTaxTotal[i] = new TaxTotalType();

                        foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.WithholdingTaxTotal == null)
                    {
                        invoicetype.WithholdingTaxTotal = new TaxTotalType[1];
                        invoicetype.WithholdingTaxTotal[0] = new TaxTotalType();
                    }
                    SetField(invoicetype.WithholdingTaxTotal[0], xmlMapping);
                }
                break;
            case "LegalMonetaryTotal":
                if (invoicetype.LegalMonetaryTotal == null)
                    invoicetype.LegalMonetaryTotal = new MonetaryTotalType();
                SetField(invoicetype.LegalMonetaryTotal, xmlMapping);
                break;
            case "InvoiceLine":
                if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine && !collMappingInvoiceLine.HasNextNode)
                {
                    if (invoicetype.InvoiceLine == null)
                        invoicetype.InvoiceLine = new InvoiceLineType[collMappingInvoiceLine.Quantity];

                    for (int i = 0; i < collMappingInvoiceLine.Quantity; i++)
                    {
                        var row = invoicetype.InvoiceLine[i] = new InvoiceLineType();

                        foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoicetype.InvoiceLine == null)
                    {
                        invoicetype.InvoiceLine = new InvoiceLineType[1];
                        invoicetype.InvoiceLine[0] = new InvoiceLineType();
                    }
                    SetField(invoicetype.InvoiceLine[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(UBLExtensionType ublextensions, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (ublextensions.ID == null)
                    ublextensions.ID = new IDType();
                SetField(ublextensions.ID, xmlMapping);
                break;
            case "Name":
                if (ublextensions.Name == null)
                    ublextensions.Name = new NameType1();
                SetField(ublextensions.Name, xmlMapping);
                break;
            case "ExtensionAgencyID":
                if (ublextensions.ExtensionAgencyID == null)
                    ublextensions.ExtensionAgencyID = new ExtensionAgencyIDType();
                SetField(ublextensions.ExtensionAgencyID, xmlMapping);
                break;
            case "ExtensionAgencyName":
                if (ublextensions.ExtensionAgencyName == null)
                    ublextensions.ExtensionAgencyName = new ExtensionAgencyNameType();
                SetField(ublextensions.ExtensionAgencyName, xmlMapping);
                break;
            case "ExtensionVersionID":
                if (ublextensions.ExtensionVersionID == null)
                    ublextensions.ExtensionVersionID = new ExtensionVersionIDType();
                SetField(ublextensions.ExtensionVersionID, xmlMapping);
                break;
            case "ExtensionAgencyURI":
                if (ublextensions.ExtensionAgencyURI == null)
                    ublextensions.ExtensionAgencyURI = new ExtensionAgencyURIType();
                SetField(ublextensions.ExtensionAgencyURI, xmlMapping);
                break;
            case "ExtensionURI":
                if (ublextensions.ExtensionURI == null)
                    ublextensions.ExtensionURI = new ExtensionURIType();
                SetField(ublextensions.ExtensionURI, xmlMapping);
                break;
            case "ExtensionReasonCode":
                if (ublextensions.ExtensionReasonCode == null)
                    ublextensions.ExtensionReasonCode = new ExtensionReasonCodeType();
                SetField(ublextensions.ExtensionReasonCode, xmlMapping);
                break;
            case "ExtensionReason":
                if (ublextensions.ExtensionReason == null)
                    ublextensions.ExtensionReason = new ExtensionReasonType();
                SetField(ublextensions.ExtensionReason, xmlMapping);
                break;
            case "ExtensionContent":
                ublextensions.ExtensionContent = (XmlElement)xmlMapping.Value;
                break;

        }
    }
    public void SetField(IdentifierType id, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetIdentifierTypeProperty(xmlNode, xmlMapping, id);
        else
            id.SetValue(xmlMapping.Value);
    }

    public void SetIdentifierTypeProperty(string xmlNode, IXmlMapping xmlMapping, IdentifierType id)
    {
        switch (xmlNode)
        {
            case "schemeID":
                id.schemeID = xmlMapping.Value?.ToString();
                break;
            case "schemeName":
                id.schemeName = xmlMapping.Value?.ToString();
                break;
            case "schemeAgencyID":
                id.schemeAgencyID = xmlMapping.Value?.ToString();
                break;
            case "schemeAgencyName":
                id.schemeAgencyName = xmlMapping.Value?.ToString();
                break;
            case "schemeVersionID":
                id.schemeVersionID = xmlMapping.Value?.ToString();
                break;
            case "schemeDataURI":
                id.schemeDataURI = xmlMapping.Value?.ToString();
                break;
            case "schemeURI":
                id.schemeURI = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(TextType name, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetTextTypeProperty(xmlNode, xmlMapping, name);
        else
            name.SetValue(xmlMapping.Value);
    }

    public void SetTextTypeProperty(string xmlNode, IXmlMapping xmlMapping, TextType name)
    {
        switch (xmlNode)
        {
            case "languageID":
                name.languageID = xmlMapping.Value?.ToString();
                break;
            case "languageLocaleID":
                name.languageLocaleID = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(CodeType extensionreasoncode, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetCodeTypeProperty(xmlNode, xmlMapping, extensionreasoncode);
        else
            extensionreasoncode.SetValue(xmlMapping.Value);
    }

    public void SetCodeTypeProperty(string xmlNode, IXmlMapping xmlMapping, CodeType extensionreasoncode)
    {
        switch (xmlNode)
        {
            case "listID":
                extensionreasoncode.listID = xmlMapping.Value?.ToString();
                break;
            case "listAgencyID":
                extensionreasoncode.listAgencyID = xmlMapping.Value?.ToString();
                break;
            case "listAgencyName":
                extensionreasoncode.listAgencyName = xmlMapping.Value?.ToString();
                break;
            case "listName":
                extensionreasoncode.listName = xmlMapping.Value?.ToString();
                break;
            case "listVersionID":
                extensionreasoncode.listVersionID = xmlMapping.Value?.ToString();
                break;
            case "name":
                extensionreasoncode.name = xmlMapping.Value?.ToString();
                break;
            case "languageID":
                extensionreasoncode.languageID = xmlMapping.Value?.ToString();
                break;
            case "listURI":
                extensionreasoncode.listURI = xmlMapping.Value?.ToString();
                break;
            case "listSchemeURI":
                extensionreasoncode.listSchemeURI = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(IndicatorType copyindicator, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        copyindicator.SetValue(xmlMapping.Value);
    }

    public void SetField(DateType issuedate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        issuedate.SetValue(xmlMapping.Value);
    }

    public void SetField(TimeType issuetime, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            throw new InvalidOperationException();

        issuetime.SetValue(xmlMapping.Value);
    }

    public void SetField(NumericType linecountnumeric, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetNumericTypeProperty(xmlNode, xmlMapping, linecountnumeric);
        else
            linecountnumeric.SetValue(xmlMapping.Value);
    }

    public void SetNumericTypeProperty(string xmlNode, IXmlMapping xmlMapping, NumericType linecountnumeric)
    {
        switch (xmlNode)
        {
            case "format":
                linecountnumeric.format = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(PeriodType invoiceperiod, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "StartDate":
                if (invoiceperiod.StartDate == null)
                    invoiceperiod.StartDate = new StartDateType();
                SetField(invoiceperiod.StartDate, xmlMapping);
                break;
            case "StartTime":
                if (invoiceperiod.StartTime == null)
                    invoiceperiod.StartTime = new StartTimeType();
                SetField(invoiceperiod.StartTime, xmlMapping);
                break;
            case "EndDate":
                if (invoiceperiod.EndDate == null)
                    invoiceperiod.EndDate = new EndDateType();
                SetField(invoiceperiod.EndDate, xmlMapping);
                break;
            case "EndTime":
                if (invoiceperiod.EndTime == null)
                    invoiceperiod.EndTime = new EndTimeType();
                SetField(invoiceperiod.EndTime, xmlMapping);
                break;
            case "DurationMeasure":
                if (invoiceperiod.DurationMeasure == null)
                    invoiceperiod.DurationMeasure = new DurationMeasureType();
                SetField(invoiceperiod.DurationMeasure, xmlMapping);
                break;
            case "DescriptionCode":
                if (xmlMapping is IXmlCollectionMapping collMappingDescriptionCode && !collMappingDescriptionCode.HasNextNode)
                {
                    if (invoiceperiod.DescriptionCode == null)
                        invoiceperiod.DescriptionCode = new DescriptionCodeType[collMappingDescriptionCode.Quantity];

                    for (int i = 0; i < collMappingDescriptionCode.Quantity; i++)
                    {
                        var row = invoiceperiod.DescriptionCode[i] = new DescriptionCodeType();

                        foreach (var colMapp in collMappingDescriptionCode.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceperiod.DescriptionCode == null)
                    {
                        invoiceperiod.DescriptionCode = new DescriptionCodeType[1];
                        invoiceperiod.DescriptionCode[0] = new DescriptionCodeType();
                    }
                    SetField(invoiceperiod.DescriptionCode[0], xmlMapping);
                }
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (invoiceperiod.Description == null)
                        invoiceperiod.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = invoiceperiod.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceperiod.Description == null)
                    {
                        invoiceperiod.Description = new DescriptionType[1];
                        invoiceperiod.Description[0] = new DescriptionType();
                    }
                    SetField(invoiceperiod.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(MeasureType durationmeasure, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetMeasureTypeProperty(xmlNode, xmlMapping, durationmeasure);
        else
            durationmeasure.SetValue(xmlMapping.Value);
    }

    public void SetMeasureTypeProperty(string xmlNode, IXmlMapping xmlMapping, MeasureType durationmeasure)
    {
        switch (xmlNode)
        {
            case "unitCode":
                durationmeasure.unitCode = xmlMapping.Value?.ToString();
                break;
            case "unitCodeListVersionID":
                durationmeasure.unitCodeListVersionID = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(OrderReferenceType orderreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (orderreference.ID == null)
                    orderreference.ID = new IDType();
                SetField(orderreference.ID, xmlMapping);
                break;
            case "SalesOrderID":
                if (orderreference.SalesOrderID == null)
                    orderreference.SalesOrderID = new SalesOrderIDType();
                SetField(orderreference.SalesOrderID, xmlMapping);
                break;
            case "CopyIndicator":
                if (orderreference.CopyIndicator == null)
                    orderreference.CopyIndicator = new CopyIndicatorType();
                SetField(orderreference.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (orderreference.UUID == null)
                    orderreference.UUID = new UUIDType();
                SetField(orderreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (orderreference.IssueDate == null)
                    orderreference.IssueDate = new IssueDateType();
                SetField(orderreference.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (orderreference.IssueTime == null)
                    orderreference.IssueTime = new IssueTimeType();
                SetField(orderreference.IssueTime, xmlMapping);
                break;
            case "CustomerReference":
                if (orderreference.CustomerReference == null)
                    orderreference.CustomerReference = new CustomerReferenceType();
                SetField(orderreference.CustomerReference, xmlMapping);
                break;
            case "OrderTypeCode":
                if (orderreference.OrderTypeCode == null)
                    orderreference.OrderTypeCode = new OrderTypeCodeType();
                SetField(orderreference.OrderTypeCode, xmlMapping);
                break;
            case "DocumentReference":
                if (orderreference.DocumentReference == null)
                    orderreference.DocumentReference = new DocumentReferenceType();
                SetField(orderreference.DocumentReference, xmlMapping);
                break;

        }
    }
    public void SetField(DocumentReferenceType documentreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (documentreference.ID == null)
                    documentreference.ID = new IDType();
                SetField(documentreference.ID, xmlMapping);
                break;
            case "CopyIndicator":
                if (documentreference.CopyIndicator == null)
                    documentreference.CopyIndicator = new CopyIndicatorType();
                SetField(documentreference.CopyIndicator, xmlMapping);
                break;
            case "UUID":
                if (documentreference.UUID == null)
                    documentreference.UUID = new UUIDType();
                SetField(documentreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (documentreference.IssueDate == null)
                    documentreference.IssueDate = new IssueDateType();
                SetField(documentreference.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (documentreference.IssueTime == null)
                    documentreference.IssueTime = new IssueTimeType();
                SetField(documentreference.IssueTime, xmlMapping);
                break;
            case "DocumentTypeCode":
                if (documentreference.DocumentTypeCode == null)
                    documentreference.DocumentTypeCode = new DocumentTypeCodeType();
                SetField(documentreference.DocumentTypeCode, xmlMapping);
                break;
            case "DocumentType":
                if (documentreference.DocumentType == null)
                    documentreference.DocumentType = new DocumentTypeType();
                SetField(documentreference.DocumentType, xmlMapping);
                break;
            case "XPath":
                if (xmlMapping is IXmlCollectionMapping collMappingXPath && !collMappingXPath.HasNextNode)
                {
                    if (documentreference.XPath == null)
                        documentreference.XPath = new XPathType[collMappingXPath.Quantity];

                    for (int i = 0; i < collMappingXPath.Quantity; i++)
                    {
                        var row = documentreference.XPath[i] = new XPathType();

                        foreach (var colMapp in collMappingXPath.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (documentreference.XPath == null)
                    {
                        documentreference.XPath = new XPathType[1];
                        documentreference.XPath[0] = new XPathType();
                    }
                    SetField(documentreference.XPath[0], xmlMapping);
                }
                break;
            case "LanguageID":
                if (documentreference.LanguageID == null)
                    documentreference.LanguageID = new LanguageIDType();
                SetField(documentreference.LanguageID, xmlMapping);
                break;
            case "LocaleCode":
                if (documentreference.LocaleCode == null)
                    documentreference.LocaleCode = new LocaleCodeType();
                SetField(documentreference.LocaleCode, xmlMapping);
                break;
            case "VersionID":
                if (documentreference.VersionID == null)
                    documentreference.VersionID = new VersionIDType();
                SetField(documentreference.VersionID, xmlMapping);
                break;
            case "DocumentStatusCode":
                if (documentreference.DocumentStatusCode == null)
                    documentreference.DocumentStatusCode = new DocumentStatusCodeType();
                SetField(documentreference.DocumentStatusCode, xmlMapping);
                break;
            case "DocumentDescription":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentDescription && !collMappingDocumentDescription.HasNextNode)
                {
                    if (documentreference.DocumentDescription == null)
                        documentreference.DocumentDescription = new DocumentDescriptionType[collMappingDocumentDescription.Quantity];

                    for (int i = 0; i < collMappingDocumentDescription.Quantity; i++)
                    {
                        var row = documentreference.DocumentDescription[i] = new DocumentDescriptionType();

                        foreach (var colMapp in collMappingDocumentDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (documentreference.DocumentDescription == null)
                    {
                        documentreference.DocumentDescription = new DocumentDescriptionType[1];
                        documentreference.DocumentDescription[0] = new DocumentDescriptionType();
                    }
                    SetField(documentreference.DocumentDescription[0], xmlMapping);
                }
                break;
            case "Attachment":
                if (documentreference.Attachment == null)
                    documentreference.Attachment = new AttachmentType();
                SetField(documentreference.Attachment, xmlMapping);
                break;
            case "ValidityPeriod":
                if (documentreference.ValidityPeriod == null)
                    documentreference.ValidityPeriod = new PeriodType();
                SetField(documentreference.ValidityPeriod, xmlMapping);
                break;
            case "IssuerParty":
                if (documentreference.IssuerParty == null)
                    documentreference.IssuerParty = new PartyType();
                SetField(documentreference.IssuerParty, xmlMapping);
                break;
            case "ResultOfVerification":
                if (documentreference.ResultOfVerification == null)
                    documentreference.ResultOfVerification = new ResultOfVerificationType();
                SetField(documentreference.ResultOfVerification, xmlMapping);
                break;

        }
    }
    public void SetField(AttachmentType attachment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "EmbeddedDocumentBinaryObject":
                if (attachment.EmbeddedDocumentBinaryObject == null)
                    attachment.EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType();
                SetField(attachment.EmbeddedDocumentBinaryObject, xmlMapping);
                break;
            case "ExternalReference":
                if (attachment.ExternalReference == null)
                    attachment.ExternalReference = new ExternalReferenceType();
                SetField(attachment.ExternalReference, xmlMapping);
                break;

        }
    }
    public void SetField(BinaryObjectType embeddeddocumentbinaryobject, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetBinaryObjectTypeProperty(xmlNode, xmlMapping, embeddeddocumentbinaryobject);
        else
            embeddeddocumentbinaryobject.SetValue(xmlMapping.Value);
    }

    public void SetBinaryObjectTypeProperty(string xmlNode, IXmlMapping xmlMapping, BinaryObjectType embeddeddocumentbinaryobject)
    {
        switch (xmlNode)
        {
            case "format":
                embeddeddocumentbinaryobject.format = xmlMapping.Value?.ToString();
                break;
            case "mimeCode":
                embeddeddocumentbinaryobject.mimeCode = xmlMapping.Value?.ToString();
                break;
            case "encodingCode":
                embeddeddocumentbinaryobject.encodingCode = xmlMapping.Value?.ToString();
                break;
            case "characterSetCode":
                embeddeddocumentbinaryobject.characterSetCode = xmlMapping.Value?.ToString();
                break;
            case "uri":
                embeddeddocumentbinaryobject.uri = xmlMapping.Value?.ToString();
                break;
            case "filename":
                embeddeddocumentbinaryobject.filename = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(ExternalReferenceType externalreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "URI":
                if (externalreference.URI == null)
                    externalreference.URI = new URIType();
                SetField(externalreference.URI, xmlMapping);
                break;
            case "DocumentHash":
                if (externalreference.DocumentHash == null)
                    externalreference.DocumentHash = new DocumentHashType();
                SetField(externalreference.DocumentHash, xmlMapping);
                break;
            case "HashAlgorithmMethod":
                if (externalreference.HashAlgorithmMethod == null)
                    externalreference.HashAlgorithmMethod = new HashAlgorithmMethodType();
                SetField(externalreference.HashAlgorithmMethod, xmlMapping);
                break;
            case "ExpiryDate":
                if (externalreference.ExpiryDate == null)
                    externalreference.ExpiryDate = new ExpiryDateType();
                SetField(externalreference.ExpiryDate, xmlMapping);
                break;
            case "ExpiryTime":
                if (externalreference.ExpiryTime == null)
                    externalreference.ExpiryTime = new ExpiryTimeType();
                SetField(externalreference.ExpiryTime, xmlMapping);
                break;
            case "MimeCode":
                if (externalreference.MimeCode == null)
                    externalreference.MimeCode = new MimeCodeType();
                SetField(externalreference.MimeCode, xmlMapping);
                break;
            case "FormatCode":
                if (externalreference.FormatCode == null)
                    externalreference.FormatCode = new FormatCodeType();
                SetField(externalreference.FormatCode, xmlMapping);
                break;
            case "EncodingCode":
                if (externalreference.EncodingCode == null)
                    externalreference.EncodingCode = new EncodingCodeType();
                SetField(externalreference.EncodingCode, xmlMapping);
                break;
            case "CharacterSetCode":
                if (externalreference.CharacterSetCode == null)
                    externalreference.CharacterSetCode = new CharacterSetCodeType();
                SetField(externalreference.CharacterSetCode, xmlMapping);
                break;
            case "FileName":
                if (externalreference.FileName == null)
                    externalreference.FileName = new FileNameType();
                SetField(externalreference.FileName, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (externalreference.Description == null)
                        externalreference.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = externalreference.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (externalreference.Description == null)
                    {
                        externalreference.Description = new DescriptionType[1];
                        externalreference.Description[0] = new DescriptionType();
                    }
                    SetField(externalreference.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(PartyType issuerparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "MarkCareIndicator":
                if (issuerparty.MarkCareIndicator == null)
                    issuerparty.MarkCareIndicator = new MarkCareIndicatorType();
                SetField(issuerparty.MarkCareIndicator, xmlMapping);
                break;
            case "MarkAttentionIndicator":
                if (issuerparty.MarkAttentionIndicator == null)
                    issuerparty.MarkAttentionIndicator = new MarkAttentionIndicatorType();
                SetField(issuerparty.MarkAttentionIndicator, xmlMapping);
                break;
            case "WebsiteURI":
                if (issuerparty.WebsiteURI == null)
                    issuerparty.WebsiteURI = new WebsiteURIType();
                SetField(issuerparty.WebsiteURI, xmlMapping);
                break;
            case "LogoReferenceID":
                if (issuerparty.LogoReferenceID == null)
                    issuerparty.LogoReferenceID = new LogoReferenceIDType();
                SetField(issuerparty.LogoReferenceID, xmlMapping);
                break;
            case "EndpointID":
                if (issuerparty.EndpointID == null)
                    issuerparty.EndpointID = new EndpointIDType();
                SetField(issuerparty.EndpointID, xmlMapping);
                break;
            case "IndustryClassificationCode":
                if (issuerparty.IndustryClassificationCode == null)
                    issuerparty.IndustryClassificationCode = new IndustryClassificationCodeType();
                SetField(issuerparty.IndustryClassificationCode, xmlMapping);
                break;
            case "PartyIdentification":
                if (xmlMapping is IXmlCollectionMapping collMappingPartyIdentification && !collMappingPartyIdentification.HasNextNode)
                {
                    if (issuerparty.PartyIdentification == null)
                        issuerparty.PartyIdentification = new PartyIdentificationType[collMappingPartyIdentification.Quantity];

                    for (int i = 0; i < collMappingPartyIdentification.Quantity; i++)
                    {
                        var row = issuerparty.PartyIdentification[i] = new PartyIdentificationType();

                        foreach (var colMapp in collMappingPartyIdentification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.PartyIdentification == null)
                    {
                        issuerparty.PartyIdentification = new PartyIdentificationType[1];
                        issuerparty.PartyIdentification[0] = new PartyIdentificationType();
                    }
                    SetField(issuerparty.PartyIdentification[0], xmlMapping);
                }
                break;
            case "PartyName":
                if (xmlMapping is IXmlCollectionMapping collMappingPartyName && !collMappingPartyName.HasNextNode)
                {
                    if (issuerparty.PartyName == null)
                        issuerparty.PartyName = new PartyNameType[collMappingPartyName.Quantity];

                    for (int i = 0; i < collMappingPartyName.Quantity; i++)
                    {
                        var row = issuerparty.PartyName[i] = new PartyNameType();

                        foreach (var colMapp in collMappingPartyName.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.PartyName == null)
                    {
                        issuerparty.PartyName = new PartyNameType[1];
                        issuerparty.PartyName[0] = new PartyNameType();
                    }
                    SetField(issuerparty.PartyName[0], xmlMapping);
                }
                break;
            case "Language":
                if (issuerparty.Language == null)
                    issuerparty.Language = new LanguageType();
                SetField(issuerparty.Language, xmlMapping);
                break;
            case "PostalAddress":
                if (issuerparty.PostalAddress == null)
                    issuerparty.PostalAddress = new AddressType();
                SetField(issuerparty.PostalAddress, xmlMapping);
                break;
            case "PhysicalLocation":
                if (issuerparty.PhysicalLocation == null)
                    issuerparty.PhysicalLocation = new LocationType1();
                SetField(issuerparty.PhysicalLocation, xmlMapping);
                break;
            case "PartyTaxScheme":
                if (xmlMapping is IXmlCollectionMapping collMappingPartyTaxScheme && !collMappingPartyTaxScheme.HasNextNode)
                {
                    if (issuerparty.PartyTaxScheme == null)
                        issuerparty.PartyTaxScheme = new PartyTaxSchemeType[collMappingPartyTaxScheme.Quantity];

                    for (int i = 0; i < collMappingPartyTaxScheme.Quantity; i++)
                    {
                        var row = issuerparty.PartyTaxScheme[i] = new PartyTaxSchemeType();

                        foreach (var colMapp in collMappingPartyTaxScheme.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.PartyTaxScheme == null)
                    {
                        issuerparty.PartyTaxScheme = new PartyTaxSchemeType[1];
                        issuerparty.PartyTaxScheme[0] = new PartyTaxSchemeType();
                    }
                    SetField(issuerparty.PartyTaxScheme[0], xmlMapping);
                }
                break;
            case "PartyLegalEntity":
                if (xmlMapping is IXmlCollectionMapping collMappingPartyLegalEntity && !collMappingPartyLegalEntity.HasNextNode)
                {
                    if (issuerparty.PartyLegalEntity == null)
                        issuerparty.PartyLegalEntity = new PartyLegalEntityType[collMappingPartyLegalEntity.Quantity];

                    for (int i = 0; i < collMappingPartyLegalEntity.Quantity; i++)
                    {
                        var row = issuerparty.PartyLegalEntity[i] = new PartyLegalEntityType();

                        foreach (var colMapp in collMappingPartyLegalEntity.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.PartyLegalEntity == null)
                    {
                        issuerparty.PartyLegalEntity = new PartyLegalEntityType[1];
                        issuerparty.PartyLegalEntity[0] = new PartyLegalEntityType();
                    }
                    SetField(issuerparty.PartyLegalEntity[0], xmlMapping);
                }
                break;
            case "Contact":
                if (issuerparty.Contact == null)
                    issuerparty.Contact = new ContactType();
                SetField(issuerparty.Contact, xmlMapping);
                break;
            case "Person":
                if (xmlMapping is IXmlCollectionMapping collMappingPerson && !collMappingPerson.HasNextNode)
                {
                    if (issuerparty.Person == null)
                        issuerparty.Person = new PersonType[collMappingPerson.Quantity];

                    for (int i = 0; i < collMappingPerson.Quantity; i++)
                    {
                        var row = issuerparty.Person[i] = new PersonType();

                        foreach (var colMapp in collMappingPerson.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.Person == null)
                    {
                        issuerparty.Person = new PersonType[1];
                        issuerparty.Person[0] = new PersonType();
                    }
                    SetField(issuerparty.Person[0], xmlMapping);
                }
                break;
            case "AgentParty":
                if (issuerparty.AgentParty == null)
                    issuerparty.AgentParty = new PartyType();
                SetField(issuerparty.AgentParty, xmlMapping);
                break;
            case "ServiceProviderParty":
                if (xmlMapping is IXmlCollectionMapping collMappingServiceProviderParty && !collMappingServiceProviderParty.HasNextNode)
                {
                    if (issuerparty.ServiceProviderParty == null)
                        issuerparty.ServiceProviderParty = new ServiceProviderPartyType[collMappingServiceProviderParty.Quantity];

                    for (int i = 0; i < collMappingServiceProviderParty.Quantity; i++)
                    {
                        var row = issuerparty.ServiceProviderParty[i] = new ServiceProviderPartyType();

                        foreach (var colMapp in collMappingServiceProviderParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.ServiceProviderParty == null)
                    {
                        issuerparty.ServiceProviderParty = new ServiceProviderPartyType[1];
                        issuerparty.ServiceProviderParty[0] = new ServiceProviderPartyType();
                    }
                    SetField(issuerparty.ServiceProviderParty[0], xmlMapping);
                }
                break;
            case "PowerOfAttorney":
                if (xmlMapping is IXmlCollectionMapping collMappingPowerOfAttorney && !collMappingPowerOfAttorney.HasNextNode)
                {
                    if (issuerparty.PowerOfAttorney == null)
                        issuerparty.PowerOfAttorney = new PowerOfAttorneyType[collMappingPowerOfAttorney.Quantity];

                    for (int i = 0; i < collMappingPowerOfAttorney.Quantity; i++)
                    {
                        var row = issuerparty.PowerOfAttorney[i] = new PowerOfAttorneyType();

                        foreach (var colMapp in collMappingPowerOfAttorney.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (issuerparty.PowerOfAttorney == null)
                    {
                        issuerparty.PowerOfAttorney = new PowerOfAttorneyType[1];
                        issuerparty.PowerOfAttorney[0] = new PowerOfAttorneyType();
                    }
                    SetField(issuerparty.PowerOfAttorney[0], xmlMapping);
                }
                break;
            case "FinancialAccount":
                if (issuerparty.FinancialAccount == null)
                    issuerparty.FinancialAccount = new FinancialAccountType();
                SetField(issuerparty.FinancialAccount, xmlMapping);
                break;

        }
    }
    public void SetField(PartyIdentificationType partyidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (partyidentification.ID == null)
                    partyidentification.ID = new IDType();
                SetField(partyidentification.ID, xmlMapping);
                break;

        }
    }
    public void SetField(PartyNameType partyname, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Name":
                if (partyname.Name == null)
                    partyname.Name = new NameType1();
                SetField(partyname.Name, xmlMapping);
                break;

        }
    }
    public void SetField(LanguageType language, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (language.ID == null)
                    language.ID = new IDType();
                SetField(language.ID, xmlMapping);
                break;
            case "Name":
                if (language.Name == null)
                    language.Name = new NameType1();
                SetField(language.Name, xmlMapping);
                break;
            case "LocaleCode":
                if (language.LocaleCode == null)
                    language.LocaleCode = new LocaleCodeType();
                SetField(language.LocaleCode, xmlMapping);
                break;

        }
    }
    public void SetField(AddressType postaladdress, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (postaladdress.ID == null)
                    postaladdress.ID = new IDType();
                SetField(postaladdress.ID, xmlMapping);
                break;
            case "AddressTypeCode":
                if (postaladdress.AddressTypeCode == null)
                    postaladdress.AddressTypeCode = new AddressTypeCodeType();
                SetField(postaladdress.AddressTypeCode, xmlMapping);
                break;
            case "AddressFormatCode":
                if (postaladdress.AddressFormatCode == null)
                    postaladdress.AddressFormatCode = new AddressFormatCodeType();
                SetField(postaladdress.AddressFormatCode, xmlMapping);
                break;
            case "Postbox":
                if (postaladdress.Postbox == null)
                    postaladdress.Postbox = new PostboxType();
                SetField(postaladdress.Postbox, xmlMapping);
                break;
            case "Floor":
                if (postaladdress.Floor == null)
                    postaladdress.Floor = new FloorType();
                SetField(postaladdress.Floor, xmlMapping);
                break;
            case "Room":
                if (postaladdress.Room == null)
                    postaladdress.Room = new RoomType();
                SetField(postaladdress.Room, xmlMapping);
                break;
            case "StreetName":
                if (postaladdress.StreetName == null)
                    postaladdress.StreetName = new StreetNameType();
                SetField(postaladdress.StreetName, xmlMapping);
                break;
            case "AdditionalStreetName":
                if (postaladdress.AdditionalStreetName == null)
                    postaladdress.AdditionalStreetName = new AdditionalStreetNameType();
                SetField(postaladdress.AdditionalStreetName, xmlMapping);
                break;
            case "BlockName":
                if (postaladdress.BlockName == null)
                    postaladdress.BlockName = new BlockNameType();
                SetField(postaladdress.BlockName, xmlMapping);
                break;
            case "BuildingName":
                if (postaladdress.BuildingName == null)
                    postaladdress.BuildingName = new BuildingNameType();
                SetField(postaladdress.BuildingName, xmlMapping);
                break;
            case "BuildingNumber":
                if (postaladdress.BuildingNumber == null)
                    postaladdress.BuildingNumber = new BuildingNumberType();
                SetField(postaladdress.BuildingNumber, xmlMapping);
                break;
            case "InhouseMail":
                if (postaladdress.InhouseMail == null)
                    postaladdress.InhouseMail = new InhouseMailType();
                SetField(postaladdress.InhouseMail, xmlMapping);
                break;
            case "Department":
                if (postaladdress.Department == null)
                    postaladdress.Department = new DepartmentType();
                SetField(postaladdress.Department, xmlMapping);
                break;
            case "MarkAttention":
                if (postaladdress.MarkAttention == null)
                    postaladdress.MarkAttention = new MarkAttentionType();
                SetField(postaladdress.MarkAttention, xmlMapping);
                break;
            case "MarkCare":
                if (postaladdress.MarkCare == null)
                    postaladdress.MarkCare = new MarkCareType();
                SetField(postaladdress.MarkCare, xmlMapping);
                break;
            case "PlotIdentification":
                if (postaladdress.PlotIdentification == null)
                    postaladdress.PlotIdentification = new PlotIdentificationType();
                SetField(postaladdress.PlotIdentification, xmlMapping);
                break;
            case "CitySubdivisionName":
                if (postaladdress.CitySubdivisionName == null)
                    postaladdress.CitySubdivisionName = new CitySubdivisionNameType();
                SetField(postaladdress.CitySubdivisionName, xmlMapping);
                break;
            case "CityName":
                if (postaladdress.CityName == null)
                    postaladdress.CityName = new CityNameType();
                SetField(postaladdress.CityName, xmlMapping);
                break;
            case "PostalZone":
                if (postaladdress.PostalZone == null)
                    postaladdress.PostalZone = new PostalZoneType();
                SetField(postaladdress.PostalZone, xmlMapping);
                break;
            case "CountrySubentity":
                if (postaladdress.CountrySubentity == null)
                    postaladdress.CountrySubentity = new CountrySubentityType();
                SetField(postaladdress.CountrySubentity, xmlMapping);
                break;
            case "CountrySubentityCode":
                if (postaladdress.CountrySubentityCode == null)
                    postaladdress.CountrySubentityCode = new CountrySubentityCodeType();
                SetField(postaladdress.CountrySubentityCode, xmlMapping);
                break;
            case "Region":
                if (postaladdress.Region == null)
                    postaladdress.Region = new RegionType();
                SetField(postaladdress.Region, xmlMapping);
                break;
            case "District":
                if (postaladdress.District == null)
                    postaladdress.District = new DistrictType();
                SetField(postaladdress.District, xmlMapping);
                break;
            case "TimezoneOffset":
                if (postaladdress.TimezoneOffset == null)
                    postaladdress.TimezoneOffset = new TimezoneOffsetType();
                SetField(postaladdress.TimezoneOffset, xmlMapping);
                break;
            case "AddressLine":
                if (xmlMapping is IXmlCollectionMapping collMappingAddressLine && !collMappingAddressLine.HasNextNode)
                {
                    if (postaladdress.AddressLine == null)
                        postaladdress.AddressLine = new AddressLineType[collMappingAddressLine.Quantity];

                    for (int i = 0; i < collMappingAddressLine.Quantity; i++)
                    {
                        var row = postaladdress.AddressLine[i] = new AddressLineType();

                        foreach (var colMapp in collMappingAddressLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (postaladdress.AddressLine == null)
                    {
                        postaladdress.AddressLine = new AddressLineType[1];
                        postaladdress.AddressLine[0] = new AddressLineType();
                    }
                    SetField(postaladdress.AddressLine[0], xmlMapping);
                }
                break;
            case "Country":
                if (postaladdress.Country == null)
                    postaladdress.Country = new CountryType();
                SetField(postaladdress.Country, xmlMapping);
                break;
            case "LocationCoordinate":
                if (xmlMapping is IXmlCollectionMapping collMappingLocationCoordinate && !collMappingLocationCoordinate.HasNextNode)
                {
                    if (postaladdress.LocationCoordinate == null)
                        postaladdress.LocationCoordinate = new LocationCoordinateType[collMappingLocationCoordinate.Quantity];

                    for (int i = 0; i < collMappingLocationCoordinate.Quantity; i++)
                    {
                        var row = postaladdress.LocationCoordinate[i] = new LocationCoordinateType();

                        foreach (var colMapp in collMappingLocationCoordinate.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (postaladdress.LocationCoordinate == null)
                    {
                        postaladdress.LocationCoordinate = new LocationCoordinateType[1];
                        postaladdress.LocationCoordinate[0] = new LocationCoordinateType();
                    }
                    SetField(postaladdress.LocationCoordinate[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(AddressLineType addressline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Line":
                if (addressline.Line == null)
                    addressline.Line = new LineType();
                SetField(addressline.Line, xmlMapping);
                break;

        }
    }
    public void SetField(CountryType country, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "IdentificationCode":
                if (country.IdentificationCode == null)
                    country.IdentificationCode = new IdentificationCodeType();
                SetField(country.IdentificationCode, xmlMapping);
                break;
            case "Name":
                if (country.Name == null)
                    country.Name = new NameType1();
                SetField(country.Name, xmlMapping);
                break;

        }
    }
    public void SetField(LocationCoordinateType locationcoordinate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CoordinateSystemCode":
                if (locationcoordinate.CoordinateSystemCode == null)
                    locationcoordinate.CoordinateSystemCode = new CoordinateSystemCodeType();
                SetField(locationcoordinate.CoordinateSystemCode, xmlMapping);
                break;
            case "LatitudeDegreesMeasure":
                if (locationcoordinate.LatitudeDegreesMeasure == null)
                    locationcoordinate.LatitudeDegreesMeasure = new LatitudeDegreesMeasureType();
                SetField(locationcoordinate.LatitudeDegreesMeasure, xmlMapping);
                break;
            case "LatitudeMinutesMeasure":
                if (locationcoordinate.LatitudeMinutesMeasure == null)
                    locationcoordinate.LatitudeMinutesMeasure = new LatitudeMinutesMeasureType();
                SetField(locationcoordinate.LatitudeMinutesMeasure, xmlMapping);
                break;
            case "LatitudeDirectionCode":
                if (locationcoordinate.LatitudeDirectionCode == null)
                    locationcoordinate.LatitudeDirectionCode = new LatitudeDirectionCodeType();
                SetField(locationcoordinate.LatitudeDirectionCode, xmlMapping);
                break;
            case "LongitudeDegreesMeasure":
                if (locationcoordinate.LongitudeDegreesMeasure == null)
                    locationcoordinate.LongitudeDegreesMeasure = new LongitudeDegreesMeasureType();
                SetField(locationcoordinate.LongitudeDegreesMeasure, xmlMapping);
                break;
            case "LongitudeMinutesMeasure":
                if (locationcoordinate.LongitudeMinutesMeasure == null)
                    locationcoordinate.LongitudeMinutesMeasure = new LongitudeMinutesMeasureType();
                SetField(locationcoordinate.LongitudeMinutesMeasure, xmlMapping);
                break;
            case "LongitudeDirectionCode":
                if (locationcoordinate.LongitudeDirectionCode == null)
                    locationcoordinate.LongitudeDirectionCode = new LongitudeDirectionCodeType();
                SetField(locationcoordinate.LongitudeDirectionCode, xmlMapping);
                break;
            case "AltitudeMeasure":
                if (locationcoordinate.AltitudeMeasure == null)
                    locationcoordinate.AltitudeMeasure = new AltitudeMeasureType();
                SetField(locationcoordinate.AltitudeMeasure, xmlMapping);
                break;

        }
    }
    public void SetField(LocationType1 physicallocation, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (physicallocation.ID == null)
                    physicallocation.ID = new IDType();
                SetField(physicallocation.ID, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (physicallocation.Description == null)
                        physicallocation.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = physicallocation.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicallocation.Description == null)
                    {
                        physicallocation.Description = new DescriptionType[1];
                        physicallocation.Description[0] = new DescriptionType();
                    }
                    SetField(physicallocation.Description[0], xmlMapping);
                }
                break;
            case "Conditions":
                if (xmlMapping is IXmlCollectionMapping collMappingConditions && !collMappingConditions.HasNextNode)
                {
                    if (physicallocation.Conditions == null)
                        physicallocation.Conditions = new ConditionsType[collMappingConditions.Quantity];

                    for (int i = 0; i < collMappingConditions.Quantity; i++)
                    {
                        var row = physicallocation.Conditions[i] = new ConditionsType();

                        foreach (var colMapp in collMappingConditions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicallocation.Conditions == null)
                    {
                        physicallocation.Conditions = new ConditionsType[1];
                        physicallocation.Conditions[0] = new ConditionsType();
                    }
                    SetField(physicallocation.Conditions[0], xmlMapping);
                }
                break;
            case "CountrySubentity":
                if (physicallocation.CountrySubentity == null)
                    physicallocation.CountrySubentity = new CountrySubentityType();
                SetField(physicallocation.CountrySubentity, xmlMapping);
                break;
            case "CountrySubentityCode":
                if (physicallocation.CountrySubentityCode == null)
                    physicallocation.CountrySubentityCode = new CountrySubentityCodeType();
                SetField(physicallocation.CountrySubentityCode, xmlMapping);
                break;
            case "LocationTypeCode":
                if (physicallocation.LocationTypeCode == null)
                    physicallocation.LocationTypeCode = new LocationTypeCodeType();
                SetField(physicallocation.LocationTypeCode, xmlMapping);
                break;
            case "InformationURI":
                if (physicallocation.InformationURI == null)
                    physicallocation.InformationURI = new InformationURIType();
                SetField(physicallocation.InformationURI, xmlMapping);
                break;
            case "Name":
                if (physicallocation.Name == null)
                    physicallocation.Name = new NameType1();
                SetField(physicallocation.Name, xmlMapping);
                break;
            case "ValidityPeriod":
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod && !collMappingValidityPeriod.HasNextNode)
                {
                    if (physicallocation.ValidityPeriod == null)
                        physicallocation.ValidityPeriod = new PeriodType[collMappingValidityPeriod.Quantity];

                    for (int i = 0; i < collMappingValidityPeriod.Quantity; i++)
                    {
                        var row = physicallocation.ValidityPeriod[i] = new PeriodType();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicallocation.ValidityPeriod == null)
                    {
                        physicallocation.ValidityPeriod = new PeriodType[1];
                        physicallocation.ValidityPeriod[0] = new PeriodType();
                    }
                    SetField(physicallocation.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "Address":
                if (physicallocation.Address == null)
                    physicallocation.Address = new AddressType();
                SetField(physicallocation.Address, xmlMapping);
                break;
            case "SubsidiaryLocation":
                if (xmlMapping is IXmlCollectionMapping collMappingSubsidiaryLocation && !collMappingSubsidiaryLocation.HasNextNode)
                {
                    if (physicallocation.SubsidiaryLocation == null)
                        physicallocation.SubsidiaryLocation = new LocationType1[collMappingSubsidiaryLocation.Quantity];

                    for (int i = 0; i < collMappingSubsidiaryLocation.Quantity; i++)
                    {
                        var row = physicallocation.SubsidiaryLocation[i] = new LocationType1();

                        foreach (var colMapp in collMappingSubsidiaryLocation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicallocation.SubsidiaryLocation == null)
                    {
                        physicallocation.SubsidiaryLocation = new LocationType1[1];
                        physicallocation.SubsidiaryLocation[0] = new LocationType1();
                    }
                    SetField(physicallocation.SubsidiaryLocation[0], xmlMapping);
                }
                break;
            case "LocationCoordinate":
                if (xmlMapping is IXmlCollectionMapping collMappingLocationCoordinate && !collMappingLocationCoordinate.HasNextNode)
                {
                    if (physicallocation.LocationCoordinate == null)
                        physicallocation.LocationCoordinate = new LocationCoordinateType[collMappingLocationCoordinate.Quantity];

                    for (int i = 0; i < collMappingLocationCoordinate.Quantity; i++)
                    {
                        var row = physicallocation.LocationCoordinate[i] = new LocationCoordinateType();

                        foreach (var colMapp in collMappingLocationCoordinate.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicallocation.LocationCoordinate == null)
                    {
                        physicallocation.LocationCoordinate = new LocationCoordinateType[1];
                        physicallocation.LocationCoordinate[0] = new LocationCoordinateType();
                    }
                    SetField(physicallocation.LocationCoordinate[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(PartyTaxSchemeType partytaxscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "RegistrationName":
                if (partytaxscheme.RegistrationName == null)
                    partytaxscheme.RegistrationName = new RegistrationNameType();
                SetField(partytaxscheme.RegistrationName, xmlMapping);
                break;
            case "CompanyID":
                if (partytaxscheme.CompanyID == null)
                    partytaxscheme.CompanyID = new CompanyIDType();
                SetField(partytaxscheme.CompanyID, xmlMapping);
                break;
            case "TaxLevelCode":
                if (partytaxscheme.TaxLevelCode == null)
                    partytaxscheme.TaxLevelCode = new TaxLevelCodeType();
                SetField(partytaxscheme.TaxLevelCode, xmlMapping);
                break;
            case "ExemptionReasonCode":
                if (partytaxscheme.ExemptionReasonCode == null)
                    partytaxscheme.ExemptionReasonCode = new ExemptionReasonCodeType();
                SetField(partytaxscheme.ExemptionReasonCode, xmlMapping);
                break;
            case "ExemptionReason":
                if (xmlMapping is IXmlCollectionMapping collMappingExemptionReason && !collMappingExemptionReason.HasNextNode)
                {
                    if (partytaxscheme.ExemptionReason == null)
                        partytaxscheme.ExemptionReason = new ExemptionReasonType[collMappingExemptionReason.Quantity];

                    for (int i = 0; i < collMappingExemptionReason.Quantity; i++)
                    {
                        var row = partytaxscheme.ExemptionReason[i] = new ExemptionReasonType();

                        foreach (var colMapp in collMappingExemptionReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (partytaxscheme.ExemptionReason == null)
                    {
                        partytaxscheme.ExemptionReason = new ExemptionReasonType[1];
                        partytaxscheme.ExemptionReason[0] = new ExemptionReasonType();
                    }
                    SetField(partytaxscheme.ExemptionReason[0], xmlMapping);
                }
                break;
            case "RegistrationAddress":
                if (partytaxscheme.RegistrationAddress == null)
                    partytaxscheme.RegistrationAddress = new AddressType();
                SetField(partytaxscheme.RegistrationAddress, xmlMapping);
                break;
            case "TaxScheme":
                if (partytaxscheme.TaxScheme == null)
                    partytaxscheme.TaxScheme = new TaxSchemeType();
                SetField(partytaxscheme.TaxScheme, xmlMapping);
                break;

        }
    }
    public void SetField(TaxSchemeType taxscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (taxscheme.ID == null)
                    taxscheme.ID = new IDType();
                SetField(taxscheme.ID, xmlMapping);
                break;
            case "Name":
                if (taxscheme.Name == null)
                    taxscheme.Name = new NameType1();
                SetField(taxscheme.Name, xmlMapping);
                break;
            case "TaxTypeCode":
                if (taxscheme.TaxTypeCode == null)
                    taxscheme.TaxTypeCode = new TaxTypeCodeType();
                SetField(taxscheme.TaxTypeCode, xmlMapping);
                break;
            case "CurrencyCode":
                if (taxscheme.CurrencyCode == null)
                    taxscheme.CurrencyCode = new CurrencyCodeType();
                SetField(taxscheme.CurrencyCode, xmlMapping);
                break;
            case "JurisdictionRegionAddress":
                if (xmlMapping is IXmlCollectionMapping collMappingJurisdictionRegionAddress && !collMappingJurisdictionRegionAddress.HasNextNode)
                {
                    if (taxscheme.JurisdictionRegionAddress == null)
                        taxscheme.JurisdictionRegionAddress = new AddressType[collMappingJurisdictionRegionAddress.Quantity];

                    for (int i = 0; i < collMappingJurisdictionRegionAddress.Quantity; i++)
                    {
                        var row = taxscheme.JurisdictionRegionAddress[i] = new AddressType();

                        foreach (var colMapp in collMappingJurisdictionRegionAddress.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (taxscheme.JurisdictionRegionAddress == null)
                    {
                        taxscheme.JurisdictionRegionAddress = new AddressType[1];
                        taxscheme.JurisdictionRegionAddress[0] = new AddressType();
                    }
                    SetField(taxscheme.JurisdictionRegionAddress[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(PartyLegalEntityType partylegalentity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "RegistrationName":
                if (partylegalentity.RegistrationName == null)
                    partylegalentity.RegistrationName = new RegistrationNameType();
                SetField(partylegalentity.RegistrationName, xmlMapping);
                break;
            case "CompanyID":
                if (partylegalentity.CompanyID == null)
                    partylegalentity.CompanyID = new CompanyIDType();
                SetField(partylegalentity.CompanyID, xmlMapping);
                break;
            case "RegistrationDate":
                if (partylegalentity.RegistrationDate == null)
                    partylegalentity.RegistrationDate = new RegistrationDateType();
                SetField(partylegalentity.RegistrationDate, xmlMapping);
                break;
            case "RegistrationExpirationDate":
                if (partylegalentity.RegistrationExpirationDate == null)
                    partylegalentity.RegistrationExpirationDate = new RegistrationExpirationDateType();
                SetField(partylegalentity.RegistrationExpirationDate, xmlMapping);
                break;
            case "CompanyLegalFormCode":
                if (partylegalentity.CompanyLegalFormCode == null)
                    partylegalentity.CompanyLegalFormCode = new CompanyLegalFormCodeType();
                SetField(partylegalentity.CompanyLegalFormCode, xmlMapping);
                break;
            case "CompanyLegalForm":
                if (partylegalentity.CompanyLegalForm == null)
                    partylegalentity.CompanyLegalForm = new CompanyLegalFormType();
                SetField(partylegalentity.CompanyLegalForm, xmlMapping);
                break;
            case "SoleProprietorshipIndicator":
                if (partylegalentity.SoleProprietorshipIndicator == null)
                    partylegalentity.SoleProprietorshipIndicator = new SoleProprietorshipIndicatorType();
                SetField(partylegalentity.SoleProprietorshipIndicator, xmlMapping);
                break;
            case "CompanyLiquidationStatusCode":
                if (partylegalentity.CompanyLiquidationStatusCode == null)
                    partylegalentity.CompanyLiquidationStatusCode = new CompanyLiquidationStatusCodeType();
                SetField(partylegalentity.CompanyLiquidationStatusCode, xmlMapping);
                break;
            case "CorporateStockAmount":
                if (partylegalentity.CorporateStockAmount == null)
                    partylegalentity.CorporateStockAmount = new CorporateStockAmountType();
                SetField(partylegalentity.CorporateStockAmount, xmlMapping);
                break;
            case "FullyPaidSharesIndicator":
                if (partylegalentity.FullyPaidSharesIndicator == null)
                    partylegalentity.FullyPaidSharesIndicator = new FullyPaidSharesIndicatorType();
                SetField(partylegalentity.FullyPaidSharesIndicator, xmlMapping);
                break;
            case "RegistrationAddress":
                if (partylegalentity.RegistrationAddress == null)
                    partylegalentity.RegistrationAddress = new AddressType();
                SetField(partylegalentity.RegistrationAddress, xmlMapping);
                break;
            case "CorporateRegistrationScheme":
                if (partylegalentity.CorporateRegistrationScheme == null)
                    partylegalentity.CorporateRegistrationScheme = new CorporateRegistrationSchemeType();
                SetField(partylegalentity.CorporateRegistrationScheme, xmlMapping);
                break;
            case "HeadOfficeParty":
                if (partylegalentity.HeadOfficeParty == null)
                    partylegalentity.HeadOfficeParty = new PartyType();
                SetField(partylegalentity.HeadOfficeParty, xmlMapping);
                break;
            case "ShareholderParty":
                if (xmlMapping is IXmlCollectionMapping collMappingShareholderParty && !collMappingShareholderParty.HasNextNode)
                {
                    if (partylegalentity.ShareholderParty == null)
                        partylegalentity.ShareholderParty = new ShareholderPartyType[collMappingShareholderParty.Quantity];

                    for (int i = 0; i < collMappingShareholderParty.Quantity; i++)
                    {
                        var row = partylegalentity.ShareholderParty[i] = new ShareholderPartyType();

                        foreach (var colMapp in collMappingShareholderParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (partylegalentity.ShareholderParty == null)
                    {
                        partylegalentity.ShareholderParty = new ShareholderPartyType[1];
                        partylegalentity.ShareholderParty[0] = new ShareholderPartyType();
                    }
                    SetField(partylegalentity.ShareholderParty[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(AmountType corporatestockamount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetAmountTypeProperty(xmlNode, xmlMapping, corporatestockamount);
        else
            corporatestockamount.SetValue(xmlMapping.Value);
    }

    public void SetAmountTypeProperty(string xmlNode, IXmlMapping xmlMapping, AmountType corporatestockamount)
    {
        switch (xmlNode)
        {
            case "currencyID":
                corporatestockamount.currencyID = xmlMapping.Value?.ToString();
                break;
            case "currencyCodeListVersionID":
                corporatestockamount.currencyCodeListVersionID = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(CorporateRegistrationSchemeType corporateregistrationscheme, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (corporateregistrationscheme.ID == null)
                    corporateregistrationscheme.ID = new IDType();
                SetField(corporateregistrationscheme.ID, xmlMapping);
                break;
            case "Name":
                if (corporateregistrationscheme.Name == null)
                    corporateregistrationscheme.Name = new NameType1();
                SetField(corporateregistrationscheme.Name, xmlMapping);
                break;
            case "CorporateRegistrationTypeCode":
                if (corporateregistrationscheme.CorporateRegistrationTypeCode == null)
                    corporateregistrationscheme.CorporateRegistrationTypeCode = new CorporateRegistrationTypeCodeType();
                SetField(corporateregistrationscheme.CorporateRegistrationTypeCode, xmlMapping);
                break;
            case "JurisdictionRegionAddress":
                if (xmlMapping is IXmlCollectionMapping collMappingJurisdictionRegionAddress && !collMappingJurisdictionRegionAddress.HasNextNode)
                {
                    if (corporateregistrationscheme.JurisdictionRegionAddress == null)
                        corporateregistrationscheme.JurisdictionRegionAddress = new AddressType[collMappingJurisdictionRegionAddress.Quantity];

                    for (int i = 0; i < collMappingJurisdictionRegionAddress.Quantity; i++)
                    {
                        var row = corporateregistrationscheme.JurisdictionRegionAddress[i] = new AddressType();

                        foreach (var colMapp in collMappingJurisdictionRegionAddress.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (corporateregistrationscheme.JurisdictionRegionAddress == null)
                    {
                        corporateregistrationscheme.JurisdictionRegionAddress = new AddressType[1];
                        corporateregistrationscheme.JurisdictionRegionAddress[0] = new AddressType();
                    }
                    SetField(corporateregistrationscheme.JurisdictionRegionAddress[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ShareholderPartyType shareholderparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PartecipationPercent":
                if (shareholderparty.PartecipationPercent == null)
                    shareholderparty.PartecipationPercent = new PartecipationPercentType();
                SetField(shareholderparty.PartecipationPercent, xmlMapping);
                break;
            case "Party":
                if (shareholderparty.Party == null)
                    shareholderparty.Party = new PartyType();
                SetField(shareholderparty.Party, xmlMapping);
                break;

        }
    }
    public void SetField(ContactType contact, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (contact.ID == null)
                    contact.ID = new IDType();
                SetField(contact.ID, xmlMapping);
                break;
            case "Name":
                if (contact.Name == null)
                    contact.Name = new NameType1();
                SetField(contact.Name, xmlMapping);
                break;
            case "Telephone":
                if (contact.Telephone == null)
                    contact.Telephone = new TelephoneType();
                SetField(contact.Telephone, xmlMapping);
                break;
            case "Telefax":
                if (contact.Telefax == null)
                    contact.Telefax = new TelefaxType();
                SetField(contact.Telefax, xmlMapping);
                break;
            case "ElectronicMail":
                if (contact.ElectronicMail == null)
                    contact.ElectronicMail = new ElectronicMailType();
                SetField(contact.ElectronicMail, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (contact.Note == null)
                        contact.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = contact.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (contact.Note == null)
                    {
                        contact.Note = new NoteType[1];
                        contact.Note[0] = new NoteType();
                    }
                    SetField(contact.Note[0], xmlMapping);
                }
                break;
            case "OtherCommunication":
                if (xmlMapping is IXmlCollectionMapping collMappingOtherCommunication && !collMappingOtherCommunication.HasNextNode)
                {
                    if (contact.OtherCommunication == null)
                        contact.OtherCommunication = new CommunicationType[collMappingOtherCommunication.Quantity];

                    for (int i = 0; i < collMappingOtherCommunication.Quantity; i++)
                    {
                        var row = contact.OtherCommunication[i] = new CommunicationType();

                        foreach (var colMapp in collMappingOtherCommunication.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (contact.OtherCommunication == null)
                    {
                        contact.OtherCommunication = new CommunicationType[1];
                        contact.OtherCommunication[0] = new CommunicationType();
                    }
                    SetField(contact.OtherCommunication[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(CommunicationType othercommunication, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ChannelCode":
                if (othercommunication.ChannelCode == null)
                    othercommunication.ChannelCode = new ChannelCodeType();
                SetField(othercommunication.ChannelCode, xmlMapping);
                break;
            case "Channel":
                if (othercommunication.Channel == null)
                    othercommunication.Channel = new ChannelType();
                SetField(othercommunication.Channel, xmlMapping);
                break;
            case "Value":
                if (othercommunication.Value == null)
                    othercommunication.Value = new ValueType();
                SetField(othercommunication.Value, xmlMapping);
                break;

        }
    }
    public void SetField(PersonType person, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (person.ID == null)
                    person.ID = new IDType();
                SetField(person.ID, xmlMapping);
                break;
            case "FirstName":
                if (person.FirstName == null)
                    person.FirstName = new FirstNameType();
                SetField(person.FirstName, xmlMapping);
                break;
            case "FamilyName":
                if (person.FamilyName == null)
                    person.FamilyName = new FamilyNameType();
                SetField(person.FamilyName, xmlMapping);
                break;
            case "Title":
                if (person.Title == null)
                    person.Title = new TitleType();
                SetField(person.Title, xmlMapping);
                break;
            case "MiddleName":
                if (person.MiddleName == null)
                    person.MiddleName = new MiddleNameType();
                SetField(person.MiddleName, xmlMapping);
                break;
            case "OtherName":
                if (person.OtherName == null)
                    person.OtherName = new OtherNameType();
                SetField(person.OtherName, xmlMapping);
                break;
            case "NameSuffix":
                if (person.NameSuffix == null)
                    person.NameSuffix = new NameSuffixType();
                SetField(person.NameSuffix, xmlMapping);
                break;
            case "JobTitle":
                if (person.JobTitle == null)
                    person.JobTitle = new JobTitleType();
                SetField(person.JobTitle, xmlMapping);
                break;
            case "NationalityID":
                if (person.NationalityID == null)
                    person.NationalityID = new NationalityIDType();
                SetField(person.NationalityID, xmlMapping);
                break;
            case "GenderCode":
                if (person.GenderCode == null)
                    person.GenderCode = new GenderCodeType();
                SetField(person.GenderCode, xmlMapping);
                break;
            case "BirthDate":
                if (person.BirthDate == null)
                    person.BirthDate = new BirthDateType();
                SetField(person.BirthDate, xmlMapping);
                break;
            case "BirthplaceName":
                if (person.BirthplaceName == null)
                    person.BirthplaceName = new BirthplaceNameType();
                SetField(person.BirthplaceName, xmlMapping);
                break;
            case "OrganizationDepartment":
                if (person.OrganizationDepartment == null)
                    person.OrganizationDepartment = new OrganizationDepartmentType();
                SetField(person.OrganizationDepartment, xmlMapping);
                break;
            case "Contact":
                if (person.Contact == null)
                    person.Contact = new ContactType();
                SetField(person.Contact, xmlMapping);
                break;
            case "FinancialAccount":
                if (person.FinancialAccount == null)
                    person.FinancialAccount = new FinancialAccountType();
                SetField(person.FinancialAccount, xmlMapping);
                break;
            case "IdentityDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingIdentityDocumentReference && !collMappingIdentityDocumentReference.HasNextNode)
                {
                    if (person.IdentityDocumentReference == null)
                        person.IdentityDocumentReference = new DocumentReferenceType[collMappingIdentityDocumentReference.Quantity];

                    for (int i = 0; i < collMappingIdentityDocumentReference.Quantity; i++)
                    {
                        var row = person.IdentityDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingIdentityDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (person.IdentityDocumentReference == null)
                    {
                        person.IdentityDocumentReference = new DocumentReferenceType[1];
                        person.IdentityDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(person.IdentityDocumentReference[0], xmlMapping);
                }
                break;
            case "ResidenceAddress":
                if (person.ResidenceAddress == null)
                    person.ResidenceAddress = new AddressType();
                SetField(person.ResidenceAddress, xmlMapping);
                break;

        }
    }
    public void SetField(FinancialAccountType financialaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialaccount.ID == null)
                    financialaccount.ID = new IDType();
                SetField(financialaccount.ID, xmlMapping);
                break;
            case "Name":
                if (financialaccount.Name == null)
                    financialaccount.Name = new NameType1();
                SetField(financialaccount.Name, xmlMapping);
                break;
            case "AliasName":
                if (financialaccount.AliasName == null)
                    financialaccount.AliasName = new AliasNameType();
                SetField(financialaccount.AliasName, xmlMapping);
                break;
            case "AccountTypeCode":
                if (financialaccount.AccountTypeCode == null)
                    financialaccount.AccountTypeCode = new AccountTypeCodeType();
                SetField(financialaccount.AccountTypeCode, xmlMapping);
                break;
            case "AccountFormatCode":
                if (financialaccount.AccountFormatCode == null)
                    financialaccount.AccountFormatCode = new AccountFormatCodeType();
                SetField(financialaccount.AccountFormatCode, xmlMapping);
                break;
            case "CurrencyCode":
                if (financialaccount.CurrencyCode == null)
                    financialaccount.CurrencyCode = new CurrencyCodeType();
                SetField(financialaccount.CurrencyCode, xmlMapping);
                break;
            case "PaymentNote":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentNote && !collMappingPaymentNote.HasNextNode)
                {
                    if (financialaccount.PaymentNote == null)
                        financialaccount.PaymentNote = new PaymentNoteType[collMappingPaymentNote.Quantity];

                    for (int i = 0; i < collMappingPaymentNote.Quantity; i++)
                    {
                        var row = financialaccount.PaymentNote[i] = new PaymentNoteType();

                        foreach (var colMapp in collMappingPaymentNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (financialaccount.PaymentNote == null)
                    {
                        financialaccount.PaymentNote = new PaymentNoteType[1];
                        financialaccount.PaymentNote[0] = new PaymentNoteType();
                    }
                    SetField(financialaccount.PaymentNote[0], xmlMapping);
                }
                break;
            case "FinancialInstitutionBranch":
                if (financialaccount.FinancialInstitutionBranch == null)
                    financialaccount.FinancialInstitutionBranch = new BranchType();
                SetField(financialaccount.FinancialInstitutionBranch, xmlMapping);
                break;
            case "Country":
                if (financialaccount.Country == null)
                    financialaccount.Country = new CountryType();
                SetField(financialaccount.Country, xmlMapping);
                break;

        }
    }
    public void SetField(BranchType financialinstitutionbranch, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialinstitutionbranch.ID == null)
                    financialinstitutionbranch.ID = new IDType();
                SetField(financialinstitutionbranch.ID, xmlMapping);
                break;
            case "Name":
                if (financialinstitutionbranch.Name == null)
                    financialinstitutionbranch.Name = new NameType1();
                SetField(financialinstitutionbranch.Name, xmlMapping);
                break;
            case "FinancialInstitution":
                if (financialinstitutionbranch.FinancialInstitution == null)
                    financialinstitutionbranch.FinancialInstitution = new FinancialInstitutionType();
                SetField(financialinstitutionbranch.FinancialInstitution, xmlMapping);
                break;
            case "Address":
                if (financialinstitutionbranch.Address == null)
                    financialinstitutionbranch.Address = new AddressType();
                SetField(financialinstitutionbranch.Address, xmlMapping);
                break;

        }
    }
    public void SetField(FinancialInstitutionType financialinstitution, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (financialinstitution.ID == null)
                    financialinstitution.ID = new IDType();
                SetField(financialinstitution.ID, xmlMapping);
                break;
            case "Name":
                if (financialinstitution.Name == null)
                    financialinstitution.Name = new NameType1();
                SetField(financialinstitution.Name, xmlMapping);
                break;
            case "Address":
                if (financialinstitution.Address == null)
                    financialinstitution.Address = new AddressType();
                SetField(financialinstitution.Address, xmlMapping);
                break;

        }
    }
    public void SetField(ServiceProviderPartyType serviceproviderparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (serviceproviderparty.ID == null)
                    serviceproviderparty.ID = new IDType();
                SetField(serviceproviderparty.ID, xmlMapping);
                break;
            case "ServiceTypeCode":
                if (serviceproviderparty.ServiceTypeCode == null)
                    serviceproviderparty.ServiceTypeCode = new ServiceTypeCodeType();
                SetField(serviceproviderparty.ServiceTypeCode, xmlMapping);
                break;
            case "ServiceType":
                if (xmlMapping is IXmlCollectionMapping collMappingServiceType && !collMappingServiceType.HasNextNode)
                {
                    if (serviceproviderparty.ServiceType == null)
                        serviceproviderparty.ServiceType = new ServiceTypeType[collMappingServiceType.Quantity];

                    for (int i = 0; i < collMappingServiceType.Quantity; i++)
                    {
                        var row = serviceproviderparty.ServiceType[i] = new ServiceTypeType();

                        foreach (var colMapp in collMappingServiceType.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (serviceproviderparty.ServiceType == null)
                    {
                        serviceproviderparty.ServiceType = new ServiceTypeType[1];
                        serviceproviderparty.ServiceType[0] = new ServiceTypeType();
                    }
                    SetField(serviceproviderparty.ServiceType[0], xmlMapping);
                }
                break;
            case "Party":
                if (serviceproviderparty.Party == null)
                    serviceproviderparty.Party = new PartyType();
                SetField(serviceproviderparty.Party, xmlMapping);
                break;
            case "SellerContact":
                if (serviceproviderparty.SellerContact == null)
                    serviceproviderparty.SellerContact = new ContactType();
                SetField(serviceproviderparty.SellerContact, xmlMapping);
                break;

        }
    }
    public void SetField(PowerOfAttorneyType powerofattorney, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (powerofattorney.ID == null)
                    powerofattorney.ID = new IDType();
                SetField(powerofattorney.ID, xmlMapping);
                break;
            case "IssueDate":
                if (powerofattorney.IssueDate == null)
                    powerofattorney.IssueDate = new IssueDateType();
                SetField(powerofattorney.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (powerofattorney.IssueTime == null)
                    powerofattorney.IssueTime = new IssueTimeType();
                SetField(powerofattorney.IssueTime, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (powerofattorney.Description == null)
                        powerofattorney.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = powerofattorney.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (powerofattorney.Description == null)
                    {
                        powerofattorney.Description = new DescriptionType[1];
                        powerofattorney.Description[0] = new DescriptionType();
                    }
                    SetField(powerofattorney.Description[0], xmlMapping);
                }
                break;
            case "NotaryParty":
                if (powerofattorney.NotaryParty == null)
                    powerofattorney.NotaryParty = new PartyType();
                SetField(powerofattorney.NotaryParty, xmlMapping);
                break;
            case "AgentParty":
                if (powerofattorney.AgentParty == null)
                    powerofattorney.AgentParty = new PartyType();
                SetField(powerofattorney.AgentParty, xmlMapping);
                break;
            case "WitnessParty":
                if (xmlMapping is IXmlCollectionMapping collMappingWitnessParty && !collMappingWitnessParty.HasNextNode)
                {
                    if (powerofattorney.WitnessParty == null)
                        powerofattorney.WitnessParty = new PartyType[collMappingWitnessParty.Quantity];

                    for (int i = 0; i < collMappingWitnessParty.Quantity; i++)
                    {
                        var row = powerofattorney.WitnessParty[i] = new PartyType();

                        foreach (var colMapp in collMappingWitnessParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (powerofattorney.WitnessParty == null)
                    {
                        powerofattorney.WitnessParty = new PartyType[1];
                        powerofattorney.WitnessParty[0] = new PartyType();
                    }
                    SetField(powerofattorney.WitnessParty[0], xmlMapping);
                }
                break;
            case "MandateDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingMandateDocumentReference && !collMappingMandateDocumentReference.HasNextNode)
                {
                    if (powerofattorney.MandateDocumentReference == null)
                        powerofattorney.MandateDocumentReference = new DocumentReferenceType[collMappingMandateDocumentReference.Quantity];

                    for (int i = 0; i < collMappingMandateDocumentReference.Quantity; i++)
                    {
                        var row = powerofattorney.MandateDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingMandateDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (powerofattorney.MandateDocumentReference == null)
                    {
                        powerofattorney.MandateDocumentReference = new DocumentReferenceType[1];
                        powerofattorney.MandateDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(powerofattorney.MandateDocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ResultOfVerificationType resultofverification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ValidatorID":
                if (resultofverification.ValidatorID == null)
                    resultofverification.ValidatorID = new ValidatorIDType();
                SetField(resultofverification.ValidatorID, xmlMapping);
                break;
            case "ValidationResultCode":
                if (resultofverification.ValidationResultCode == null)
                    resultofverification.ValidationResultCode = new ValidationResultCodeType();
                SetField(resultofverification.ValidationResultCode, xmlMapping);
                break;
            case "ValidationDate":
                if (resultofverification.ValidationDate == null)
                    resultofverification.ValidationDate = new ValidationDateType();
                SetField(resultofverification.ValidationDate, xmlMapping);
                break;
            case "ValidationTime":
                if (resultofverification.ValidationTime == null)
                    resultofverification.ValidationTime = new ValidationTimeType();
                SetField(resultofverification.ValidationTime, xmlMapping);
                break;
            case "ValidateProcess":
                if (resultofverification.ValidateProcess == null)
                    resultofverification.ValidateProcess = new ValidateProcessType();
                SetField(resultofverification.ValidateProcess, xmlMapping);
                break;
            case "ValidateTool":
                if (resultofverification.ValidateTool == null)
                    resultofverification.ValidateTool = new ValidateToolType();
                SetField(resultofverification.ValidateTool, xmlMapping);
                break;
            case "ValidateToolVersion":
                if (resultofverification.ValidateToolVersion == null)
                    resultofverification.ValidateToolVersion = new ValidateToolVersionType();
                SetField(resultofverification.ValidateToolVersion, xmlMapping);
                break;
            case "SignatoryParty":
                if (resultofverification.SignatoryParty == null)
                    resultofverification.SignatoryParty = new PartyType();
                SetField(resultofverification.SignatoryParty, xmlMapping);
                break;

        }
    }
    public void SetField(BillingReferenceType billingreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "InvoiceDocumentReference":
                if (billingreference.InvoiceDocumentReference == null)
                    billingreference.InvoiceDocumentReference = new DocumentReferenceType();
                SetField(billingreference.InvoiceDocumentReference, xmlMapping);
                break;
            case "SelfBilledInvoiceDocumentReference":
                if (billingreference.SelfBilledInvoiceDocumentReference == null)
                    billingreference.SelfBilledInvoiceDocumentReference = new DocumentReferenceType();
                SetField(billingreference.SelfBilledInvoiceDocumentReference, xmlMapping);
                break;
            case "CreditNoteDocumentReference":
                if (billingreference.CreditNoteDocumentReference == null)
                    billingreference.CreditNoteDocumentReference = new DocumentReferenceType();
                SetField(billingreference.CreditNoteDocumentReference, xmlMapping);
                break;
            case "SelfBilledCreditNoteDocumentReference":
                if (billingreference.SelfBilledCreditNoteDocumentReference == null)
                    billingreference.SelfBilledCreditNoteDocumentReference = new DocumentReferenceType();
                SetField(billingreference.SelfBilledCreditNoteDocumentReference, xmlMapping);
                break;
            case "DebitNoteDocumentReference":
                if (billingreference.DebitNoteDocumentReference == null)
                    billingreference.DebitNoteDocumentReference = new DocumentReferenceType();
                SetField(billingreference.DebitNoteDocumentReference, xmlMapping);
                break;
            case "ReminderDocumentReference":
                if (billingreference.ReminderDocumentReference == null)
                    billingreference.ReminderDocumentReference = new DocumentReferenceType();
                SetField(billingreference.ReminderDocumentReference, xmlMapping);
                break;
            case "AdditionalDocumentReference":
                if (billingreference.AdditionalDocumentReference == null)
                    billingreference.AdditionalDocumentReference = new DocumentReferenceType();
                SetField(billingreference.AdditionalDocumentReference, xmlMapping);
                break;
            case "BillingReferenceLine":
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReferenceLine && !collMappingBillingReferenceLine.HasNextNode)
                {
                    if (billingreference.BillingReferenceLine == null)
                        billingreference.BillingReferenceLine = new BillingReferenceLineType[collMappingBillingReferenceLine.Quantity];

                    for (int i = 0; i < collMappingBillingReferenceLine.Quantity; i++)
                    {
                        var row = billingreference.BillingReferenceLine[i] = new BillingReferenceLineType();

                        foreach (var colMapp in collMappingBillingReferenceLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (billingreference.BillingReferenceLine == null)
                    {
                        billingreference.BillingReferenceLine = new BillingReferenceLineType[1];
                        billingreference.BillingReferenceLine[0] = new BillingReferenceLineType();
                    }
                    SetField(billingreference.BillingReferenceLine[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(BillingReferenceLineType billingreferenceline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (billingreferenceline.ID == null)
                    billingreferenceline.ID = new IDType();
                SetField(billingreferenceline.ID, xmlMapping);
                break;
            case "Amount":
                if (billingreferenceline.Amount == null)
                    billingreferenceline.Amount = new AmountType2();
                SetField(billingreferenceline.Amount, xmlMapping);
                break;
            case "AllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge && !collMappingAllowanceCharge.HasNextNode)
                {
                    if (billingreferenceline.AllowanceCharge == null)
                        billingreferenceline.AllowanceCharge = new AllowanceChargeType[collMappingAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingAllowanceCharge.Quantity; i++)
                    {
                        var row = billingreferenceline.AllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (billingreferenceline.AllowanceCharge == null)
                    {
                        billingreferenceline.AllowanceCharge = new AllowanceChargeType[1];
                        billingreferenceline.AllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(billingreferenceline.AllowanceCharge[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(AllowanceChargeType allowancecharge, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (allowancecharge.ID == null)
                    allowancecharge.ID = new IDType();
                SetField(allowancecharge.ID, xmlMapping);
                break;
            case "ChargeIndicator":
                if (allowancecharge.ChargeIndicator == null)
                    allowancecharge.ChargeIndicator = new ChargeIndicatorType();
                SetField(allowancecharge.ChargeIndicator, xmlMapping);
                break;
            case "AllowanceChargeReasonCode":
                if (allowancecharge.AllowanceChargeReasonCode == null)
                    allowancecharge.AllowanceChargeReasonCode = new AllowanceChargeReasonCodeType();
                SetField(allowancecharge.AllowanceChargeReasonCode, xmlMapping);
                break;
            case "AllowanceChargeReason":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceChargeReason && !collMappingAllowanceChargeReason.HasNextNode)
                {
                    if (allowancecharge.AllowanceChargeReason == null)
                        allowancecharge.AllowanceChargeReason = new AllowanceChargeReasonType[collMappingAllowanceChargeReason.Quantity];

                    for (int i = 0; i < collMappingAllowanceChargeReason.Quantity; i++)
                    {
                        var row = allowancecharge.AllowanceChargeReason[i] = new AllowanceChargeReasonType();

                        foreach (var colMapp in collMappingAllowanceChargeReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (allowancecharge.AllowanceChargeReason == null)
                    {
                        allowancecharge.AllowanceChargeReason = new AllowanceChargeReasonType[1];
                        allowancecharge.AllowanceChargeReason[0] = new AllowanceChargeReasonType();
                    }
                    SetField(allowancecharge.AllowanceChargeReason[0], xmlMapping);
                }
                break;
            case "MultiplierFactorNumeric":
                if (allowancecharge.MultiplierFactorNumeric == null)
                    allowancecharge.MultiplierFactorNumeric = new MultiplierFactorNumericType();
                SetField(allowancecharge.MultiplierFactorNumeric, xmlMapping);
                break;
            case "PrepaidIndicator":
                if (allowancecharge.PrepaidIndicator == null)
                    allowancecharge.PrepaidIndicator = new PrepaidIndicatorType();
                SetField(allowancecharge.PrepaidIndicator, xmlMapping);
                break;
            case "SequenceNumeric":
                if (allowancecharge.SequenceNumeric == null)
                    allowancecharge.SequenceNumeric = new SequenceNumericType();
                SetField(allowancecharge.SequenceNumeric, xmlMapping);
                break;
            case "Amount":
                if (allowancecharge.Amount == null)
                    allowancecharge.Amount = new AmountType2();
                SetField(allowancecharge.Amount, xmlMapping);
                break;
            case "BaseAmount":
                if (allowancecharge.BaseAmount == null)
                    allowancecharge.BaseAmount = new BaseAmountType();
                SetField(allowancecharge.BaseAmount, xmlMapping);
                break;
            case "AccountingCostCode":
                if (allowancecharge.AccountingCostCode == null)
                    allowancecharge.AccountingCostCode = new AccountingCostCodeType();
                SetField(allowancecharge.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (allowancecharge.AccountingCost == null)
                    allowancecharge.AccountingCost = new AccountingCostType();
                SetField(allowancecharge.AccountingCost, xmlMapping);
                break;
            case "PerUnitAmount":
                if (allowancecharge.PerUnitAmount == null)
                    allowancecharge.PerUnitAmount = new PerUnitAmountType();
                SetField(allowancecharge.PerUnitAmount, xmlMapping);
                break;
            case "TaxCategory":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxCategory && !collMappingTaxCategory.HasNextNode)
                {
                    if (allowancecharge.TaxCategory == null)
                        allowancecharge.TaxCategory = new TaxCategoryType[collMappingTaxCategory.Quantity];

                    for (int i = 0; i < collMappingTaxCategory.Quantity; i++)
                    {
                        var row = allowancecharge.TaxCategory[i] = new TaxCategoryType();

                        foreach (var colMapp in collMappingTaxCategory.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (allowancecharge.TaxCategory == null)
                    {
                        allowancecharge.TaxCategory = new TaxCategoryType[1];
                        allowancecharge.TaxCategory[0] = new TaxCategoryType();
                    }
                    SetField(allowancecharge.TaxCategory[0], xmlMapping);
                }
                break;
            case "TaxTotal":
                if (allowancecharge.TaxTotal == null)
                    allowancecharge.TaxTotal = new TaxTotalType();
                SetField(allowancecharge.TaxTotal, xmlMapping);
                break;
            case "PaymentMeans":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeans && !collMappingPaymentMeans.HasNextNode)
                {
                    if (allowancecharge.PaymentMeans == null)
                        allowancecharge.PaymentMeans = new PaymentMeansType[collMappingPaymentMeans.Quantity];

                    for (int i = 0; i < collMappingPaymentMeans.Quantity; i++)
                    {
                        var row = allowancecharge.PaymentMeans[i] = new PaymentMeansType();

                        foreach (var colMapp in collMappingPaymentMeans.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (allowancecharge.PaymentMeans == null)
                    {
                        allowancecharge.PaymentMeans = new PaymentMeansType[1];
                        allowancecharge.PaymentMeans[0] = new PaymentMeansType();
                    }
                    SetField(allowancecharge.PaymentMeans[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(TaxCategoryType taxcategory, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (taxcategory.ID == null)
                    taxcategory.ID = new IDType();
                SetField(taxcategory.ID, xmlMapping);
                break;
            case "Name":
                if (taxcategory.Name == null)
                    taxcategory.Name = new NameType1();
                SetField(taxcategory.Name, xmlMapping);
                break;
            case "Percent":
                if (taxcategory.Percent == null)
                    taxcategory.Percent = new PercentType1();
                SetField(taxcategory.Percent, xmlMapping);
                break;
            case "BaseUnitMeasure":
                if (taxcategory.BaseUnitMeasure == null)
                    taxcategory.BaseUnitMeasure = new BaseUnitMeasureType();
                SetField(taxcategory.BaseUnitMeasure, xmlMapping);
                break;
            case "PerUnitAmount":
                if (taxcategory.PerUnitAmount == null)
                    taxcategory.PerUnitAmount = new PerUnitAmountType();
                SetField(taxcategory.PerUnitAmount, xmlMapping);
                break;
            case "TaxExemptionReasonCode":
                if (taxcategory.TaxExemptionReasonCode == null)
                    taxcategory.TaxExemptionReasonCode = new TaxExemptionReasonCodeType();
                SetField(taxcategory.TaxExemptionReasonCode, xmlMapping);
                break;
            case "TaxExemptionReason":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxExemptionReason && !collMappingTaxExemptionReason.HasNextNode)
                {
                    if (taxcategory.TaxExemptionReason == null)
                        taxcategory.TaxExemptionReason = new TaxExemptionReasonType[collMappingTaxExemptionReason.Quantity];

                    for (int i = 0; i < collMappingTaxExemptionReason.Quantity; i++)
                    {
                        var row = taxcategory.TaxExemptionReason[i] = new TaxExemptionReasonType();

                        foreach (var colMapp in collMappingTaxExemptionReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (taxcategory.TaxExemptionReason == null)
                    {
                        taxcategory.TaxExemptionReason = new TaxExemptionReasonType[1];
                        taxcategory.TaxExemptionReason[0] = new TaxExemptionReasonType();
                    }
                    SetField(taxcategory.TaxExemptionReason[0], xmlMapping);
                }
                break;
            case "TierRange":
                if (taxcategory.TierRange == null)
                    taxcategory.TierRange = new TierRangeType();
                SetField(taxcategory.TierRange, xmlMapping);
                break;
            case "TierRatePercent":
                if (taxcategory.TierRatePercent == null)
                    taxcategory.TierRatePercent = new TierRatePercentType();
                SetField(taxcategory.TierRatePercent, xmlMapping);
                break;
            case "TaxScheme":
                if (taxcategory.TaxScheme == null)
                    taxcategory.TaxScheme = new TaxSchemeType();
                SetField(taxcategory.TaxScheme, xmlMapping);
                break;

        }
    }
    public void SetField(TaxTotalType taxtotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TaxAmount":
                if (taxtotal.TaxAmount == null)
                    taxtotal.TaxAmount = new TaxAmountType();
                SetField(taxtotal.TaxAmount, xmlMapping);
                break;
            case "RoundingAmount":
                if (taxtotal.RoundingAmount == null)
                    taxtotal.RoundingAmount = new RoundingAmountType();
                SetField(taxtotal.RoundingAmount, xmlMapping);
                break;
            case "TaxEvidenceIndicator":
                if (taxtotal.TaxEvidenceIndicator == null)
                    taxtotal.TaxEvidenceIndicator = new TaxEvidenceIndicatorType();
                SetField(taxtotal.TaxEvidenceIndicator, xmlMapping);
                break;
            case "TaxIncludedIndicator":
                if (taxtotal.TaxIncludedIndicator == null)
                    taxtotal.TaxIncludedIndicator = new TaxIncludedIndicatorType();
                SetField(taxtotal.TaxIncludedIndicator, xmlMapping);
                break;
            case "TaxSubtotal":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxSubtotal && !collMappingTaxSubtotal.HasNextNode)
                {
                    if (taxtotal.TaxSubtotal == null)
                        taxtotal.TaxSubtotal = new TaxSubtotalType[collMappingTaxSubtotal.Quantity];

                    for (int i = 0; i < collMappingTaxSubtotal.Quantity; i++)
                    {
                        var row = taxtotal.TaxSubtotal[i] = new TaxSubtotalType();

                        foreach (var colMapp in collMappingTaxSubtotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (taxtotal.TaxSubtotal == null)
                    {
                        taxtotal.TaxSubtotal = new TaxSubtotalType[1];
                        taxtotal.TaxSubtotal[0] = new TaxSubtotalType();
                    }
                    SetField(taxtotal.TaxSubtotal[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(TaxSubtotalType taxsubtotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TaxableAmount":
                if (taxsubtotal.TaxableAmount == null)
                    taxsubtotal.TaxableAmount = new TaxableAmountType();
                SetField(taxsubtotal.TaxableAmount, xmlMapping);
                break;
            case "TaxAmount":
                if (taxsubtotal.TaxAmount == null)
                    taxsubtotal.TaxAmount = new TaxAmountType();
                SetField(taxsubtotal.TaxAmount, xmlMapping);
                break;
            case "CalculationSequenceNumeric":
                if (taxsubtotal.CalculationSequenceNumeric == null)
                    taxsubtotal.CalculationSequenceNumeric = new CalculationSequenceNumericType();
                SetField(taxsubtotal.CalculationSequenceNumeric, xmlMapping);
                break;
            case "TransactionCurrencyTaxAmount":
                if (taxsubtotal.TransactionCurrencyTaxAmount == null)
                    taxsubtotal.TransactionCurrencyTaxAmount = new TransactionCurrencyTaxAmountType();
                SetField(taxsubtotal.TransactionCurrencyTaxAmount, xmlMapping);
                break;
            case "Percent":
                if (taxsubtotal.Percent == null)
                    taxsubtotal.Percent = new PercentType1();
                SetField(taxsubtotal.Percent, xmlMapping);
                break;
            case "BaseUnitMeasure":
                if (taxsubtotal.BaseUnitMeasure == null)
                    taxsubtotal.BaseUnitMeasure = new BaseUnitMeasureType();
                SetField(taxsubtotal.BaseUnitMeasure, xmlMapping);
                break;
            case "PerUnitAmount":
                if (taxsubtotal.PerUnitAmount == null)
                    taxsubtotal.PerUnitAmount = new PerUnitAmountType();
                SetField(taxsubtotal.PerUnitAmount, xmlMapping);
                break;
            case "TierRange":
                if (taxsubtotal.TierRange == null)
                    taxsubtotal.TierRange = new TierRangeType();
                SetField(taxsubtotal.TierRange, xmlMapping);
                break;
            case "TierRatePercent":
                if (taxsubtotal.TierRatePercent == null)
                    taxsubtotal.TierRatePercent = new TierRatePercentType();
                SetField(taxsubtotal.TierRatePercent, xmlMapping);
                break;
            case "TaxCategory":
                if (taxsubtotal.TaxCategory == null)
                    taxsubtotal.TaxCategory = new TaxCategoryType();
                SetField(taxsubtotal.TaxCategory, xmlMapping);
                break;

        }
    }
    public void SetField(PaymentMeansType paymentmeans, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentmeans.ID == null)
                    paymentmeans.ID = new IDType();
                SetField(paymentmeans.ID, xmlMapping);
                break;
            case "PaymentMeansCode":
                if (paymentmeans.PaymentMeansCode == null)
                    paymentmeans.PaymentMeansCode = new PaymentMeansCodeType();
                SetField(paymentmeans.PaymentMeansCode, xmlMapping);
                break;
            case "PaymentDueDate":
                if (paymentmeans.PaymentDueDate == null)
                    paymentmeans.PaymentDueDate = new PaymentDueDateType();
                SetField(paymentmeans.PaymentDueDate, xmlMapping);
                break;
            case "PaymentChannelCode":
                if (paymentmeans.PaymentChannelCode == null)
                    paymentmeans.PaymentChannelCode = new PaymentChannelCodeType();
                SetField(paymentmeans.PaymentChannelCode, xmlMapping);
                break;
            case "InstructionID":
                if (paymentmeans.InstructionID == null)
                    paymentmeans.InstructionID = new InstructionIDType();
                SetField(paymentmeans.InstructionID, xmlMapping);
                break;
            case "InstructionNote":
                if (xmlMapping is IXmlCollectionMapping collMappingInstructionNote && !collMappingInstructionNote.HasNextNode)
                {
                    if (paymentmeans.InstructionNote == null)
                        paymentmeans.InstructionNote = new InstructionNoteType[collMappingInstructionNote.Quantity];

                    for (int i = 0; i < collMappingInstructionNote.Quantity; i++)
                    {
                        var row = paymentmeans.InstructionNote[i] = new InstructionNoteType();

                        foreach (var colMapp in collMappingInstructionNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (paymentmeans.InstructionNote == null)
                    {
                        paymentmeans.InstructionNote = new InstructionNoteType[1];
                        paymentmeans.InstructionNote[0] = new InstructionNoteType();
                    }
                    SetField(paymentmeans.InstructionNote[0], xmlMapping);
                }
                break;
            case "PaymentID":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentID && !collMappingPaymentID.HasNextNode)
                {
                    if (paymentmeans.PaymentID == null)
                        paymentmeans.PaymentID = new PaymentIDType[collMappingPaymentID.Quantity];

                    for (int i = 0; i < collMappingPaymentID.Quantity; i++)
                    {
                        var row = paymentmeans.PaymentID[i] = new PaymentIDType();

                        foreach (var colMapp in collMappingPaymentID.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (paymentmeans.PaymentID == null)
                    {
                        paymentmeans.PaymentID = new PaymentIDType[1];
                        paymentmeans.PaymentID[0] = new PaymentIDType();
                    }
                    SetField(paymentmeans.PaymentID[0], xmlMapping);
                }
                break;
            case "CardAccount":
                if (paymentmeans.CardAccount == null)
                    paymentmeans.CardAccount = new CardAccountType();
                SetField(paymentmeans.CardAccount, xmlMapping);
                break;
            case "PayerFinancialAccount":
                if (paymentmeans.PayerFinancialAccount == null)
                    paymentmeans.PayerFinancialAccount = new FinancialAccountType();
                SetField(paymentmeans.PayerFinancialAccount, xmlMapping);
                break;
            case "PayeeFinancialAccount":
                if (paymentmeans.PayeeFinancialAccount == null)
                    paymentmeans.PayeeFinancialAccount = new FinancialAccountType();
                SetField(paymentmeans.PayeeFinancialAccount, xmlMapping);
                break;
            case "CreditAccount":
                if (paymentmeans.CreditAccount == null)
                    paymentmeans.CreditAccount = new CreditAccountType();
                SetField(paymentmeans.CreditAccount, xmlMapping);
                break;
            case "PaymentMandate":
                if (paymentmeans.PaymentMandate == null)
                    paymentmeans.PaymentMandate = new PaymentMandateType();
                SetField(paymentmeans.PaymentMandate, xmlMapping);
                break;
            case "TradeFinancing":
                if (paymentmeans.TradeFinancing == null)
                    paymentmeans.TradeFinancing = new TradeFinancingType();
                SetField(paymentmeans.TradeFinancing, xmlMapping);
                break;

        }
    }
    public void SetField(CardAccountType cardaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PrimaryAccountNumberID":
                if (cardaccount.PrimaryAccountNumberID == null)
                    cardaccount.PrimaryAccountNumberID = new PrimaryAccountNumberIDType();
                SetField(cardaccount.PrimaryAccountNumberID, xmlMapping);
                break;
            case "NetworkID":
                if (cardaccount.NetworkID == null)
                    cardaccount.NetworkID = new NetworkIDType();
                SetField(cardaccount.NetworkID, xmlMapping);
                break;
            case "CardTypeCode":
                if (cardaccount.CardTypeCode == null)
                    cardaccount.CardTypeCode = new CardTypeCodeType();
                SetField(cardaccount.CardTypeCode, xmlMapping);
                break;
            case "ValidityStartDate":
                if (cardaccount.ValidityStartDate == null)
                    cardaccount.ValidityStartDate = new ValidityStartDateType();
                SetField(cardaccount.ValidityStartDate, xmlMapping);
                break;
            case "ExpiryDate":
                if (cardaccount.ExpiryDate == null)
                    cardaccount.ExpiryDate = new ExpiryDateType();
                SetField(cardaccount.ExpiryDate, xmlMapping);
                break;
            case "IssuerID":
                if (cardaccount.IssuerID == null)
                    cardaccount.IssuerID = new IssuerIDType();
                SetField(cardaccount.IssuerID, xmlMapping);
                break;
            case "IssueNumberID":
                if (cardaccount.IssueNumberID == null)
                    cardaccount.IssueNumberID = new IssueNumberIDType();
                SetField(cardaccount.IssueNumberID, xmlMapping);
                break;
            case "CV2ID":
                if (cardaccount.CV2ID == null)
                    cardaccount.CV2ID = new CV2IDType();
                SetField(cardaccount.CV2ID, xmlMapping);
                break;
            case "CardChipCode":
                if (cardaccount.CardChipCode == null)
                    cardaccount.CardChipCode = new CardChipCodeType();
                SetField(cardaccount.CardChipCode, xmlMapping);
                break;
            case "ChipApplicationID":
                if (cardaccount.ChipApplicationID == null)
                    cardaccount.ChipApplicationID = new ChipApplicationIDType();
                SetField(cardaccount.ChipApplicationID, xmlMapping);
                break;
            case "HolderName":
                if (cardaccount.HolderName == null)
                    cardaccount.HolderName = new HolderNameType();
                SetField(cardaccount.HolderName, xmlMapping);
                break;

        }
    }
    public void SetField(CreditAccountType creditaccount, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AccountID":
                if (creditaccount.AccountID == null)
                    creditaccount.AccountID = new AccountIDType();
                SetField(creditaccount.AccountID, xmlMapping);
                break;

        }
    }
    public void SetField(PaymentMandateType paymentmandate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentmandate.ID == null)
                    paymentmandate.ID = new IDType();
                SetField(paymentmandate.ID, xmlMapping);
                break;
            case "MandateTypeCode":
                if (paymentmandate.MandateTypeCode == null)
                    paymentmandate.MandateTypeCode = new MandateTypeCodeType();
                SetField(paymentmandate.MandateTypeCode, xmlMapping);
                break;
            case "MaximumPaymentInstructionsNumeric":
                if (paymentmandate.MaximumPaymentInstructionsNumeric == null)
                    paymentmandate.MaximumPaymentInstructionsNumeric = new MaximumPaymentInstructionsNumericType();
                SetField(paymentmandate.MaximumPaymentInstructionsNumeric, xmlMapping);
                break;
            case "MaximumPaidAmount":
                if (paymentmandate.MaximumPaidAmount == null)
                    paymentmandate.MaximumPaidAmount = new MaximumPaidAmountType();
                SetField(paymentmandate.MaximumPaidAmount, xmlMapping);
                break;
            case "SignatureID":
                if (paymentmandate.SignatureID == null)
                    paymentmandate.SignatureID = new SignatureIDType();
                SetField(paymentmandate.SignatureID, xmlMapping);
                break;
            case "PayerParty":
                if (paymentmandate.PayerParty == null)
                    paymentmandate.PayerParty = new PartyType();
                SetField(paymentmandate.PayerParty, xmlMapping);
                break;
            case "PayerFinancialAccount":
                if (paymentmandate.PayerFinancialAccount == null)
                    paymentmandate.PayerFinancialAccount = new FinancialAccountType();
                SetField(paymentmandate.PayerFinancialAccount, xmlMapping);
                break;
            case "ValidityPeriod":
                if (paymentmandate.ValidityPeriod == null)
                    paymentmandate.ValidityPeriod = new PeriodType();
                SetField(paymentmandate.ValidityPeriod, xmlMapping);
                break;
            case "PaymentReversalPeriod":
                if (paymentmandate.PaymentReversalPeriod == null)
                    paymentmandate.PaymentReversalPeriod = new PeriodType();
                SetField(paymentmandate.PaymentReversalPeriod, xmlMapping);
                break;
            case "Clause":
                if (xmlMapping is IXmlCollectionMapping collMappingClause && !collMappingClause.HasNextNode)
                {
                    if (paymentmandate.Clause == null)
                        paymentmandate.Clause = new ClauseType[collMappingClause.Quantity];

                    for (int i = 0; i < collMappingClause.Quantity; i++)
                    {
                        var row = paymentmandate.Clause[i] = new ClauseType();

                        foreach (var colMapp in collMappingClause.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (paymentmandate.Clause == null)
                    {
                        paymentmandate.Clause = new ClauseType[1];
                        paymentmandate.Clause[0] = new ClauseType();
                    }
                    SetField(paymentmandate.Clause[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ClauseType clause, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (clause.ID == null)
                    clause.ID = new IDType();
                SetField(clause.ID, xmlMapping);
                break;
            case "Content":
                if (xmlMapping is IXmlCollectionMapping collMappingContent && !collMappingContent.HasNextNode)
                {
                    if (clause.Content == null)
                        clause.Content = new ContentType[collMappingContent.Quantity];

                    for (int i = 0; i < collMappingContent.Quantity; i++)
                    {
                        var row = clause.Content[i] = new ContentType();

                        foreach (var colMapp in collMappingContent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (clause.Content == null)
                    {
                        clause.Content = new ContentType[1];
                        clause.Content[0] = new ContentType();
                    }
                    SetField(clause.Content[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(TradeFinancingType tradefinancing, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (tradefinancing.ID == null)
                    tradefinancing.ID = new IDType();
                SetField(tradefinancing.ID, xmlMapping);
                break;
            case "FinancingInstrumentCode":
                if (tradefinancing.FinancingInstrumentCode == null)
                    tradefinancing.FinancingInstrumentCode = new FinancingInstrumentCodeType();
                SetField(tradefinancing.FinancingInstrumentCode, xmlMapping);
                break;
            case "ContractDocumentReference":
                if (tradefinancing.ContractDocumentReference == null)
                    tradefinancing.ContractDocumentReference = new DocumentReferenceType();
                SetField(tradefinancing.ContractDocumentReference, xmlMapping);
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (tradefinancing.DocumentReference == null)
                        tradefinancing.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = tradefinancing.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (tradefinancing.DocumentReference == null)
                    {
                        tradefinancing.DocumentReference = new DocumentReferenceType[1];
                        tradefinancing.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(tradefinancing.DocumentReference[0], xmlMapping);
                }
                break;
            case "FinancingParty":
                if (tradefinancing.FinancingParty == null)
                    tradefinancing.FinancingParty = new PartyType();
                SetField(tradefinancing.FinancingParty, xmlMapping);
                break;
            case "FinancingFinancialAccount":
                if (tradefinancing.FinancingFinancialAccount == null)
                    tradefinancing.FinancingFinancialAccount = new FinancialAccountType();
                SetField(tradefinancing.FinancingFinancialAccount, xmlMapping);
                break;
            case "Clause":
                if (xmlMapping is IXmlCollectionMapping collMappingClause && !collMappingClause.HasNextNode)
                {
                    if (tradefinancing.Clause == null)
                        tradefinancing.Clause = new ClauseType[collMappingClause.Quantity];

                    for (int i = 0; i < collMappingClause.Quantity; i++)
                    {
                        var row = tradefinancing.Clause[i] = new ClauseType();

                        foreach (var colMapp in collMappingClause.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (tradefinancing.Clause == null)
                    {
                        tradefinancing.Clause = new ClauseType[1];
                        tradefinancing.Clause[0] = new ClauseType();
                    }
                    SetField(tradefinancing.Clause[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ProjectReferenceType projectreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (projectreference.ID == null)
                    projectreference.ID = new IDType();
                SetField(projectreference.ID, xmlMapping);
                break;
            case "UUID":
                if (projectreference.UUID == null)
                    projectreference.UUID = new UUIDType();
                SetField(projectreference.UUID, xmlMapping);
                break;
            case "IssueDate":
                if (projectreference.IssueDate == null)
                    projectreference.IssueDate = new IssueDateType();
                SetField(projectreference.IssueDate, xmlMapping);
                break;
            case "WorkPhaseReference":
                if (xmlMapping is IXmlCollectionMapping collMappingWorkPhaseReference && !collMappingWorkPhaseReference.HasNextNode)
                {
                    if (projectreference.WorkPhaseReference == null)
                        projectreference.WorkPhaseReference = new WorkPhaseReferenceType[collMappingWorkPhaseReference.Quantity];

                    for (int i = 0; i < collMappingWorkPhaseReference.Quantity; i++)
                    {
                        var row = projectreference.WorkPhaseReference[i] = new WorkPhaseReferenceType();

                        foreach (var colMapp in collMappingWorkPhaseReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (projectreference.WorkPhaseReference == null)
                    {
                        projectreference.WorkPhaseReference = new WorkPhaseReferenceType[1];
                        projectreference.WorkPhaseReference[0] = new WorkPhaseReferenceType();
                    }
                    SetField(projectreference.WorkPhaseReference[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(WorkPhaseReferenceType workphasereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (workphasereference.ID == null)
                    workphasereference.ID = new IDType();
                SetField(workphasereference.ID, xmlMapping);
                break;
            case "WorkPhaseCode":
                if (workphasereference.WorkPhaseCode == null)
                    workphasereference.WorkPhaseCode = new WorkPhaseCodeType();
                SetField(workphasereference.WorkPhaseCode, xmlMapping);
                break;
            case "WorkPhase":
                if (xmlMapping is IXmlCollectionMapping collMappingWorkPhase && !collMappingWorkPhase.HasNextNode)
                {
                    if (workphasereference.WorkPhase == null)
                        workphasereference.WorkPhase = new WorkPhaseType[collMappingWorkPhase.Quantity];

                    for (int i = 0; i < collMappingWorkPhase.Quantity; i++)
                    {
                        var row = workphasereference.WorkPhase[i] = new WorkPhaseType();

                        foreach (var colMapp in collMappingWorkPhase.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (workphasereference.WorkPhase == null)
                    {
                        workphasereference.WorkPhase = new WorkPhaseType[1];
                        workphasereference.WorkPhase[0] = new WorkPhaseType();
                    }
                    SetField(workphasereference.WorkPhase[0], xmlMapping);
                }
                break;
            case "ProgressPercent":
                if (workphasereference.ProgressPercent == null)
                    workphasereference.ProgressPercent = new ProgressPercentType();
                SetField(workphasereference.ProgressPercent, xmlMapping);
                break;
            case "StartDate":
                if (workphasereference.StartDate == null)
                    workphasereference.StartDate = new StartDateType();
                SetField(workphasereference.StartDate, xmlMapping);
                break;
            case "EndDate":
                if (workphasereference.EndDate == null)
                    workphasereference.EndDate = new EndDateType();
                SetField(workphasereference.EndDate, xmlMapping);
                break;
            case "WorkOrderDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingWorkOrderDocumentReference && !collMappingWorkOrderDocumentReference.HasNextNode)
                {
                    if (workphasereference.WorkOrderDocumentReference == null)
                        workphasereference.WorkOrderDocumentReference = new DocumentReferenceType[collMappingWorkOrderDocumentReference.Quantity];

                    for (int i = 0; i < collMappingWorkOrderDocumentReference.Quantity; i++)
                    {
                        var row = workphasereference.WorkOrderDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingWorkOrderDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (workphasereference.WorkOrderDocumentReference == null)
                    {
                        workphasereference.WorkOrderDocumentReference = new DocumentReferenceType[1];
                        workphasereference.WorkOrderDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(workphasereference.WorkOrderDocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(SignatureType signature, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (signature.ID == null)
                    signature.ID = new IDType();
                SetField(signature.ID, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (signature.Note == null)
                        signature.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = signature.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (signature.Note == null)
                    {
                        signature.Note = new NoteType[1];
                        signature.Note[0] = new NoteType();
                    }
                    SetField(signature.Note[0], xmlMapping);
                }
                break;
            case "ValidationDate":
                if (signature.ValidationDate == null)
                    signature.ValidationDate = new ValidationDateType();
                SetField(signature.ValidationDate, xmlMapping);
                break;
            case "ValidationTime":
                if (signature.ValidationTime == null)
                    signature.ValidationTime = new ValidationTimeType();
                SetField(signature.ValidationTime, xmlMapping);
                break;
            case "ValidatorID":
                if (signature.ValidatorID == null)
                    signature.ValidatorID = new ValidatorIDType();
                SetField(signature.ValidatorID, xmlMapping);
                break;
            case "CanonicalizationMethod":
                if (signature.CanonicalizationMethod == null)
                    signature.CanonicalizationMethod = new CanonicalizationMethodType();
                SetField(signature.CanonicalizationMethod, xmlMapping);
                break;
            case "SignatureMethod":
                if (signature.SignatureMethod == null)
                    signature.SignatureMethod = new SignatureMethodType();
                SetField(signature.SignatureMethod, xmlMapping);
                break;
            case "SignatoryParty":
                if (signature.SignatoryParty == null)
                    signature.SignatoryParty = new PartyType();
                SetField(signature.SignatoryParty, xmlMapping);
                break;
            case "DigitalSignatureAttachment":
                if (signature.DigitalSignatureAttachment == null)
                    signature.DigitalSignatureAttachment = new AttachmentType();
                SetField(signature.DigitalSignatureAttachment, xmlMapping);
                break;
            case "OriginalDocumentReference":
                if (signature.OriginalDocumentReference == null)
                    signature.OriginalDocumentReference = new DocumentReferenceType();
                SetField(signature.OriginalDocumentReference, xmlMapping);
                break;

        }
    }
    public void SetField(SupplierPartyType accountingsupplierparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CustomerAssignedAccountID":
                if (accountingsupplierparty.CustomerAssignedAccountID == null)
                    accountingsupplierparty.CustomerAssignedAccountID = new CustomerAssignedAccountIDType();
                SetField(accountingsupplierparty.CustomerAssignedAccountID, xmlMapping);
                break;
            case "AdditionalAccountID":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalAccountID && !collMappingAdditionalAccountID.HasNextNode)
                {
                    if (accountingsupplierparty.AdditionalAccountID == null)
                        accountingsupplierparty.AdditionalAccountID = new AdditionalAccountIDType[collMappingAdditionalAccountID.Quantity];

                    for (int i = 0; i < collMappingAdditionalAccountID.Quantity; i++)
                    {
                        var row = accountingsupplierparty.AdditionalAccountID[i] = new AdditionalAccountIDType();

                        foreach (var colMapp in collMappingAdditionalAccountID.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (accountingsupplierparty.AdditionalAccountID == null)
                    {
                        accountingsupplierparty.AdditionalAccountID = new AdditionalAccountIDType[1];
                        accountingsupplierparty.AdditionalAccountID[0] = new AdditionalAccountIDType();
                    }
                    SetField(accountingsupplierparty.AdditionalAccountID[0], xmlMapping);
                }
                break;
            case "DataSendingCapability":
                if (accountingsupplierparty.DataSendingCapability == null)
                    accountingsupplierparty.DataSendingCapability = new DataSendingCapabilityType();
                SetField(accountingsupplierparty.DataSendingCapability, xmlMapping);
                break;
            case "Party":
                if (accountingsupplierparty.Party == null)
                    accountingsupplierparty.Party = new PartyType();
                SetField(accountingsupplierparty.Party, xmlMapping);
                break;
            case "DespatchContact":
                if (accountingsupplierparty.DespatchContact == null)
                    accountingsupplierparty.DespatchContact = new ContactType();
                SetField(accountingsupplierparty.DespatchContact, xmlMapping);
                break;
            case "AccountingContact":
                if (accountingsupplierparty.AccountingContact == null)
                    accountingsupplierparty.AccountingContact = new ContactType();
                SetField(accountingsupplierparty.AccountingContact, xmlMapping);
                break;
            case "SellerContact":
                if (accountingsupplierparty.SellerContact == null)
                    accountingsupplierparty.SellerContact = new ContactType();
                SetField(accountingsupplierparty.SellerContact, xmlMapping);
                break;

        }
    }
    public void SetField(CustomerPartyType accountingcustomerparty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CustomerAssignedAccountID":
                if (accountingcustomerparty.CustomerAssignedAccountID == null)
                    accountingcustomerparty.CustomerAssignedAccountID = new CustomerAssignedAccountIDType();
                SetField(accountingcustomerparty.CustomerAssignedAccountID, xmlMapping);
                break;
            case "SupplierAssignedAccountID":
                if (accountingcustomerparty.SupplierAssignedAccountID == null)
                    accountingcustomerparty.SupplierAssignedAccountID = new SupplierAssignedAccountIDType();
                SetField(accountingcustomerparty.SupplierAssignedAccountID, xmlMapping);
                break;
            case "AdditionalAccountID":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalAccountID && !collMappingAdditionalAccountID.HasNextNode)
                {
                    if (accountingcustomerparty.AdditionalAccountID == null)
                        accountingcustomerparty.AdditionalAccountID = new AdditionalAccountIDType[collMappingAdditionalAccountID.Quantity];

                    for (int i = 0; i < collMappingAdditionalAccountID.Quantity; i++)
                    {
                        var row = accountingcustomerparty.AdditionalAccountID[i] = new AdditionalAccountIDType();

                        foreach (var colMapp in collMappingAdditionalAccountID.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (accountingcustomerparty.AdditionalAccountID == null)
                    {
                        accountingcustomerparty.AdditionalAccountID = new AdditionalAccountIDType[1];
                        accountingcustomerparty.AdditionalAccountID[0] = new AdditionalAccountIDType();
                    }
                    SetField(accountingcustomerparty.AdditionalAccountID[0], xmlMapping);
                }
                break;
            case "Party":
                if (accountingcustomerparty.Party == null)
                    accountingcustomerparty.Party = new PartyType();
                SetField(accountingcustomerparty.Party, xmlMapping);
                break;
            case "DeliveryContact":
                if (accountingcustomerparty.DeliveryContact == null)
                    accountingcustomerparty.DeliveryContact = new ContactType();
                SetField(accountingcustomerparty.DeliveryContact, xmlMapping);
                break;
            case "AccountingContact":
                if (accountingcustomerparty.AccountingContact == null)
                    accountingcustomerparty.AccountingContact = new ContactType();
                SetField(accountingcustomerparty.AccountingContact, xmlMapping);
                break;
            case "BuyerContact":
                if (accountingcustomerparty.BuyerContact == null)
                    accountingcustomerparty.BuyerContact = new ContactType();
                SetField(accountingcustomerparty.BuyerContact, xmlMapping);
                break;

        }
    }
    public void SetField(DeliveryType delivery, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (delivery.ID == null)
                    delivery.ID = new IDType();
                SetField(delivery.ID, xmlMapping);
                break;
            case "Quantity":
                if (delivery.Quantity == null)
                    delivery.Quantity = new QuantityType2();
                SetField(delivery.Quantity, xmlMapping);
                break;
            case "MinimumQuantity":
                if (delivery.MinimumQuantity == null)
                    delivery.MinimumQuantity = new MinimumQuantityType();
                SetField(delivery.MinimumQuantity, xmlMapping);
                break;
            case "MaximumQuantity":
                if (delivery.MaximumQuantity == null)
                    delivery.MaximumQuantity = new MaximumQuantityType();
                SetField(delivery.MaximumQuantity, xmlMapping);
                break;
            case "ActualDeliveryDate":
                if (delivery.ActualDeliveryDate == null)
                    delivery.ActualDeliveryDate = new ActualDeliveryDateType();
                SetField(delivery.ActualDeliveryDate, xmlMapping);
                break;
            case "ActualDeliveryTime":
                if (delivery.ActualDeliveryTime == null)
                    delivery.ActualDeliveryTime = new ActualDeliveryTimeType();
                SetField(delivery.ActualDeliveryTime, xmlMapping);
                break;
            case "LatestDeliveryDate":
                if (delivery.LatestDeliveryDate == null)
                    delivery.LatestDeliveryDate = new LatestDeliveryDateType();
                SetField(delivery.LatestDeliveryDate, xmlMapping);
                break;
            case "LatestDeliveryTime":
                if (delivery.LatestDeliveryTime == null)
                    delivery.LatestDeliveryTime = new LatestDeliveryTimeType();
                SetField(delivery.LatestDeliveryTime, xmlMapping);
                break;
            case "ReleaseID":
                if (delivery.ReleaseID == null)
                    delivery.ReleaseID = new ReleaseIDType();
                SetField(delivery.ReleaseID, xmlMapping);
                break;
            case "TrackingID":
                if (delivery.TrackingID == null)
                    delivery.TrackingID = new TrackingIDType();
                SetField(delivery.TrackingID, xmlMapping);
                break;
            case "DeliveryAddress":
                if (delivery.DeliveryAddress == null)
                    delivery.DeliveryAddress = new AddressType();
                SetField(delivery.DeliveryAddress, xmlMapping);
                break;
            case "DeliveryLocation":
                if (delivery.DeliveryLocation == null)
                    delivery.DeliveryLocation = new LocationType1();
                SetField(delivery.DeliveryLocation, xmlMapping);
                break;
            case "AlternativeDeliveryLocation":
                if (delivery.AlternativeDeliveryLocation == null)
                    delivery.AlternativeDeliveryLocation = new LocationType1();
                SetField(delivery.AlternativeDeliveryLocation, xmlMapping);
                break;
            case "RequestedDeliveryPeriod":
                if (delivery.RequestedDeliveryPeriod == null)
                    delivery.RequestedDeliveryPeriod = new PeriodType();
                SetField(delivery.RequestedDeliveryPeriod, xmlMapping);
                break;
            case "PromisedDeliveryPeriod":
                if (delivery.PromisedDeliveryPeriod == null)
                    delivery.PromisedDeliveryPeriod = new PeriodType();
                SetField(delivery.PromisedDeliveryPeriod, xmlMapping);
                break;
            case "EstimatedDeliveryPeriod":
                if (delivery.EstimatedDeliveryPeriod == null)
                    delivery.EstimatedDeliveryPeriod = new PeriodType();
                SetField(delivery.EstimatedDeliveryPeriod, xmlMapping);
                break;
            case "CarrierParty":
                if (delivery.CarrierParty == null)
                    delivery.CarrierParty = new PartyType();
                SetField(delivery.CarrierParty, xmlMapping);
                break;
            case "DeliveryParty":
                if (delivery.DeliveryParty == null)
                    delivery.DeliveryParty = new PartyType();
                SetField(delivery.DeliveryParty, xmlMapping);
                break;
            case "NotifyParty":
                if (xmlMapping is IXmlCollectionMapping collMappingNotifyParty && !collMappingNotifyParty.HasNextNode)
                {
                    if (delivery.NotifyParty == null)
                        delivery.NotifyParty = new PartyType[collMappingNotifyParty.Quantity];

                    for (int i = 0; i < collMappingNotifyParty.Quantity; i++)
                    {
                        var row = delivery.NotifyParty[i] = new PartyType();

                        foreach (var colMapp in collMappingNotifyParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (delivery.NotifyParty == null)
                    {
                        delivery.NotifyParty = new PartyType[1];
                        delivery.NotifyParty[0] = new PartyType();
                    }
                    SetField(delivery.NotifyParty[0], xmlMapping);
                }
                break;
            case "Despatch":
                if (delivery.Despatch == null)
                    delivery.Despatch = new DespatchType();
                SetField(delivery.Despatch, xmlMapping);
                break;
            case "DeliveryTerms":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryTerms && !collMappingDeliveryTerms.HasNextNode)
                {
                    if (delivery.DeliveryTerms == null)
                        delivery.DeliveryTerms = new DeliveryTermsType[collMappingDeliveryTerms.Quantity];

                    for (int i = 0; i < collMappingDeliveryTerms.Quantity; i++)
                    {
                        var row = delivery.DeliveryTerms[i] = new DeliveryTermsType();

                        foreach (var colMapp in collMappingDeliveryTerms.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (delivery.DeliveryTerms == null)
                    {
                        delivery.DeliveryTerms = new DeliveryTermsType[1];
                        delivery.DeliveryTerms[0] = new DeliveryTermsType();
                    }
                    SetField(delivery.DeliveryTerms[0], xmlMapping);
                }
                break;
            case "MinimumDeliveryUnit":
                if (delivery.MinimumDeliveryUnit == null)
                    delivery.MinimumDeliveryUnit = new DeliveryUnitType();
                SetField(delivery.MinimumDeliveryUnit, xmlMapping);
                break;
            case "MaximumDeliveryUnit":
                if (delivery.MaximumDeliveryUnit == null)
                    delivery.MaximumDeliveryUnit = new DeliveryUnitType();
                SetField(delivery.MaximumDeliveryUnit, xmlMapping);
                break;
            case "Shipment":
                if (delivery.Shipment == null)
                    delivery.Shipment = new ShipmentType();
                SetField(delivery.Shipment, xmlMapping);
                break;

        }
    }
    public void SetField(QuantityType quantity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();
        if (!string.IsNullOrEmpty(xmlNode))
            SetQuantityTypeProperty(xmlNode, xmlMapping, quantity);
        else
            quantity.SetValue(xmlMapping.Value);
    }

    public void SetQuantityTypeProperty(string xmlNode, IXmlMapping xmlMapping, QuantityType quantity)
    {
        switch (xmlNode)
        {
            case "unitCode":
                quantity.unitCode = xmlMapping.Value?.ToString();
                break;
            case "unitCodeListID":
                quantity.unitCodeListID = xmlMapping.Value?.ToString();
                break;
            case "unitCodeListAgencyID":
                quantity.unitCodeListAgencyID = xmlMapping.Value?.ToString();
                break;
            case "unitCodeListAgencyName":
                quantity.unitCodeListAgencyName = xmlMapping.Value?.ToString();
                break;
            default:
                throw new InvalidOperationException();
        }
    }
    public void SetField(DespatchType despatch, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (despatch.ID == null)
                    despatch.ID = new IDType();
                SetField(despatch.ID, xmlMapping);
                break;
            case "RequestedDespatchDate":
                if (despatch.RequestedDespatchDate == null)
                    despatch.RequestedDespatchDate = new RequestedDespatchDateType();
                SetField(despatch.RequestedDespatchDate, xmlMapping);
                break;
            case "RequestedDespatchTime":
                if (despatch.RequestedDespatchTime == null)
                    despatch.RequestedDespatchTime = new RequestedDespatchTimeType();
                SetField(despatch.RequestedDespatchTime, xmlMapping);
                break;
            case "EstimatedDespatchDate":
                if (despatch.EstimatedDespatchDate == null)
                    despatch.EstimatedDespatchDate = new EstimatedDespatchDateType();
                SetField(despatch.EstimatedDespatchDate, xmlMapping);
                break;
            case "EstimatedDespatchTime":
                if (despatch.EstimatedDespatchTime == null)
                    despatch.EstimatedDespatchTime = new EstimatedDespatchTimeType();
                SetField(despatch.EstimatedDespatchTime, xmlMapping);
                break;
            case "ActualDespatchDate":
                if (despatch.ActualDespatchDate == null)
                    despatch.ActualDespatchDate = new ActualDespatchDateType();
                SetField(despatch.ActualDespatchDate, xmlMapping);
                break;
            case "ActualDespatchTime":
                if (despatch.ActualDespatchTime == null)
                    despatch.ActualDespatchTime = new ActualDespatchTimeType();
                SetField(despatch.ActualDespatchTime, xmlMapping);
                break;
            case "GuaranteedDespatchDate":
                if (despatch.GuaranteedDespatchDate == null)
                    despatch.GuaranteedDespatchDate = new GuaranteedDespatchDateType();
                SetField(despatch.GuaranteedDespatchDate, xmlMapping);
                break;
            case "GuaranteedDespatchTime":
                if (despatch.GuaranteedDespatchTime == null)
                    despatch.GuaranteedDespatchTime = new GuaranteedDespatchTimeType();
                SetField(despatch.GuaranteedDespatchTime, xmlMapping);
                break;
            case "ReleaseID":
                if (despatch.ReleaseID == null)
                    despatch.ReleaseID = new ReleaseIDType();
                SetField(despatch.ReleaseID, xmlMapping);
                break;
            case "Instructions":
                if (xmlMapping is IXmlCollectionMapping collMappingInstructions && !collMappingInstructions.HasNextNode)
                {
                    if (despatch.Instructions == null)
                        despatch.Instructions = new InstructionsType[collMappingInstructions.Quantity];

                    for (int i = 0; i < collMappingInstructions.Quantity; i++)
                    {
                        var row = despatch.Instructions[i] = new InstructionsType();

                        foreach (var colMapp in collMappingInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (despatch.Instructions == null)
                    {
                        despatch.Instructions = new InstructionsType[1];
                        despatch.Instructions[0] = new InstructionsType();
                    }
                    SetField(despatch.Instructions[0], xmlMapping);
                }
                break;
            case "DespatchAddress":
                if (despatch.DespatchAddress == null)
                    despatch.DespatchAddress = new AddressType();
                SetField(despatch.DespatchAddress, xmlMapping);
                break;
            case "DespatchLocation":
                if (despatch.DespatchLocation == null)
                    despatch.DespatchLocation = new LocationType1();
                SetField(despatch.DespatchLocation, xmlMapping);
                break;
            case "DespatchParty":
                if (despatch.DespatchParty == null)
                    despatch.DespatchParty = new PartyType();
                SetField(despatch.DespatchParty, xmlMapping);
                break;
            case "CarrierParty":
                if (despatch.CarrierParty == null)
                    despatch.CarrierParty = new PartyType();
                SetField(despatch.CarrierParty, xmlMapping);
                break;
            case "NotifyParty":
                if (xmlMapping is IXmlCollectionMapping collMappingNotifyParty && !collMappingNotifyParty.HasNextNode)
                {
                    if (despatch.NotifyParty == null)
                        despatch.NotifyParty = new PartyType[collMappingNotifyParty.Quantity];

                    for (int i = 0; i < collMappingNotifyParty.Quantity; i++)
                    {
                        var row = despatch.NotifyParty[i] = new PartyType();

                        foreach (var colMapp in collMappingNotifyParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (despatch.NotifyParty == null)
                    {
                        despatch.NotifyParty = new PartyType[1];
                        despatch.NotifyParty[0] = new PartyType();
                    }
                    SetField(despatch.NotifyParty[0], xmlMapping);
                }
                break;
            case "Contact":
                if (despatch.Contact == null)
                    despatch.Contact = new ContactType();
                SetField(despatch.Contact, xmlMapping);
                break;
            case "EstimatedDespatchPeriod":
                if (despatch.EstimatedDespatchPeriod == null)
                    despatch.EstimatedDespatchPeriod = new PeriodType();
                SetField(despatch.EstimatedDespatchPeriod, xmlMapping);
                break;
            case "RequestedDespatchPeriod":
                if (despatch.RequestedDespatchPeriod == null)
                    despatch.RequestedDespatchPeriod = new PeriodType();
                SetField(despatch.RequestedDespatchPeriod, xmlMapping);
                break;

        }
    }
    public void SetField(DeliveryTermsType deliveryterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (deliveryterms.ID == null)
                    deliveryterms.ID = new IDType();
                SetField(deliveryterms.ID, xmlMapping);
                break;
            case "SpecialTerms":
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialTerms && !collMappingSpecialTerms.HasNextNode)
                {
                    if (deliveryterms.SpecialTerms == null)
                        deliveryterms.SpecialTerms = new SpecialTermsType[collMappingSpecialTerms.Quantity];

                    for (int i = 0; i < collMappingSpecialTerms.Quantity; i++)
                    {
                        var row = deliveryterms.SpecialTerms[i] = new SpecialTermsType();

                        foreach (var colMapp in collMappingSpecialTerms.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (deliveryterms.SpecialTerms == null)
                    {
                        deliveryterms.SpecialTerms = new SpecialTermsType[1];
                        deliveryterms.SpecialTerms[0] = new SpecialTermsType();
                    }
                    SetField(deliveryterms.SpecialTerms[0], xmlMapping);
                }
                break;
            case "LossRiskResponsibilityCode":
                if (deliveryterms.LossRiskResponsibilityCode == null)
                    deliveryterms.LossRiskResponsibilityCode = new LossRiskResponsibilityCodeType();
                SetField(deliveryterms.LossRiskResponsibilityCode, xmlMapping);
                break;
            case "LossRisk":
                if (xmlMapping is IXmlCollectionMapping collMappingLossRisk && !collMappingLossRisk.HasNextNode)
                {
                    if (deliveryterms.LossRisk == null)
                        deliveryterms.LossRisk = new LossRiskType[collMappingLossRisk.Quantity];

                    for (int i = 0; i < collMappingLossRisk.Quantity; i++)
                    {
                        var row = deliveryterms.LossRisk[i] = new LossRiskType();

                        foreach (var colMapp in collMappingLossRisk.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (deliveryterms.LossRisk == null)
                    {
                        deliveryterms.LossRisk = new LossRiskType[1];
                        deliveryterms.LossRisk[0] = new LossRiskType();
                    }
                    SetField(deliveryterms.LossRisk[0], xmlMapping);
                }
                break;
            case "Amount":
                if (deliveryterms.Amount == null)
                    deliveryterms.Amount = new AmountType2();
                SetField(deliveryterms.Amount, xmlMapping);
                break;
            case "DeliveryLocation":
                if (deliveryterms.DeliveryLocation == null)
                    deliveryterms.DeliveryLocation = new LocationType1();
                SetField(deliveryterms.DeliveryLocation, xmlMapping);
                break;
            case "AllowanceCharge":
                if (deliveryterms.AllowanceCharge == null)
                    deliveryterms.AllowanceCharge = new AllowanceChargeType();
                SetField(deliveryterms.AllowanceCharge, xmlMapping);
                break;

        }
    }
    public void SetField(DeliveryUnitType minimumdeliveryunit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "BatchQuantity":
                if (minimumdeliveryunit.BatchQuantity == null)
                    minimumdeliveryunit.BatchQuantity = new BatchQuantityType();
                SetField(minimumdeliveryunit.BatchQuantity, xmlMapping);
                break;
            case "ConsumerUnitQuantity":
                if (minimumdeliveryunit.ConsumerUnitQuantity == null)
                    minimumdeliveryunit.ConsumerUnitQuantity = new ConsumerUnitQuantityType();
                SetField(minimumdeliveryunit.ConsumerUnitQuantity, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (minimumdeliveryunit.HazardousRiskIndicator == null)
                    minimumdeliveryunit.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(minimumdeliveryunit.HazardousRiskIndicator, xmlMapping);
                break;

        }
    }
    public void SetField(ShipmentType shipment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (shipment.ID == null)
                    shipment.ID = new IDType();
                SetField(shipment.ID, xmlMapping);
                break;
            case "ShippingPriorityLevelCode":
                if (shipment.ShippingPriorityLevelCode == null)
                    shipment.ShippingPriorityLevelCode = new ShippingPriorityLevelCodeType();
                SetField(shipment.ShippingPriorityLevelCode, xmlMapping);
                break;
            case "HandlingCode":
                if (shipment.HandlingCode == null)
                    shipment.HandlingCode = new HandlingCodeType();
                SetField(shipment.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions && !collMappingHandlingInstructions.HasNextNode)
                {
                    if (shipment.HandlingInstructions == null)
                        shipment.HandlingInstructions = new HandlingInstructionsType[collMappingHandlingInstructions.Quantity];

                    for (int i = 0; i < collMappingHandlingInstructions.Quantity; i++)
                    {
                        var row = shipment.HandlingInstructions[i] = new HandlingInstructionsType();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.HandlingInstructions == null)
                    {
                        shipment.HandlingInstructions = new HandlingInstructionsType[1];
                        shipment.HandlingInstructions[0] = new HandlingInstructionsType();
                    }
                    SetField(shipment.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "Information":
                if (xmlMapping is IXmlCollectionMapping collMappingInformation && !collMappingInformation.HasNextNode)
                {
                    if (shipment.Information == null)
                        shipment.Information = new InformationType[collMappingInformation.Quantity];

                    for (int i = 0; i < collMappingInformation.Quantity; i++)
                    {
                        var row = shipment.Information[i] = new InformationType();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.Information == null)
                    {
                        shipment.Information = new InformationType[1];
                        shipment.Information[0] = new InformationType();
                    }
                    SetField(shipment.Information[0], xmlMapping);
                }
                break;
            case "GrossWeightMeasure":
                if (shipment.GrossWeightMeasure == null)
                    shipment.GrossWeightMeasure = new GrossWeightMeasureType();
                SetField(shipment.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (shipment.NetWeightMeasure == null)
                    shipment.NetWeightMeasure = new NetWeightMeasureType();
                SetField(shipment.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (shipment.NetNetWeightMeasure == null)
                    shipment.NetNetWeightMeasure = new NetNetWeightMeasureType();
                SetField(shipment.NetNetWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (shipment.GrossVolumeMeasure == null)
                    shipment.GrossVolumeMeasure = new GrossVolumeMeasureType();
                SetField(shipment.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (shipment.NetVolumeMeasure == null)
                    shipment.NetVolumeMeasure = new NetVolumeMeasureType();
                SetField(shipment.NetVolumeMeasure, xmlMapping);
                break;
            case "TotalGoodsItemQuantity":
                if (shipment.TotalGoodsItemQuantity == null)
                    shipment.TotalGoodsItemQuantity = new TotalGoodsItemQuantityType();
                SetField(shipment.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalTransportHandlingUnitQuantity":
                if (shipment.TotalTransportHandlingUnitQuantity == null)
                    shipment.TotalTransportHandlingUnitQuantity = new TotalTransportHandlingUnitQuantityType();
                SetField(shipment.TotalTransportHandlingUnitQuantity, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (shipment.InsuranceValueAmount == null)
                    shipment.InsuranceValueAmount = new InsuranceValueAmountType();
                SetField(shipment.InsuranceValueAmount, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (shipment.DeclaredCustomsValueAmount == null)
                    shipment.DeclaredCustomsValueAmount = new DeclaredCustomsValueAmountType();
                SetField(shipment.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (shipment.DeclaredForCarriageValueAmount == null)
                    shipment.DeclaredForCarriageValueAmount = new DeclaredForCarriageValueAmountType();
                SetField(shipment.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (shipment.DeclaredStatisticsValueAmount == null)
                    shipment.DeclaredStatisticsValueAmount = new DeclaredStatisticsValueAmountType();
                SetField(shipment.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (shipment.FreeOnBoardValueAmount == null)
                    shipment.FreeOnBoardValueAmount = new FreeOnBoardValueAmountType();
                SetField(shipment.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "SpecialInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialInstructions && !collMappingSpecialInstructions.HasNextNode)
                {
                    if (shipment.SpecialInstructions == null)
                        shipment.SpecialInstructions = new SpecialInstructionsType[collMappingSpecialInstructions.Quantity];

                    for (int i = 0; i < collMappingSpecialInstructions.Quantity; i++)
                    {
                        var row = shipment.SpecialInstructions[i] = new SpecialInstructionsType();

                        foreach (var colMapp in collMappingSpecialInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.SpecialInstructions == null)
                    {
                        shipment.SpecialInstructions = new SpecialInstructionsType[1];
                        shipment.SpecialInstructions[0] = new SpecialInstructionsType();
                    }
                    SetField(shipment.SpecialInstructions[0], xmlMapping);
                }
                break;
            case "DeliveryInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryInstructions && !collMappingDeliveryInstructions.HasNextNode)
                {
                    if (shipment.DeliveryInstructions == null)
                        shipment.DeliveryInstructions = new DeliveryInstructionsType[collMappingDeliveryInstructions.Quantity];

                    for (int i = 0; i < collMappingDeliveryInstructions.Quantity; i++)
                    {
                        var row = shipment.DeliveryInstructions[i] = new DeliveryInstructionsType();

                        foreach (var colMapp in collMappingDeliveryInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.DeliveryInstructions == null)
                    {
                        shipment.DeliveryInstructions = new DeliveryInstructionsType[1];
                        shipment.DeliveryInstructions[0] = new DeliveryInstructionsType();
                    }
                    SetField(shipment.DeliveryInstructions[0], xmlMapping);
                }
                break;
            case "SplitConsignmentIndicator":
                if (shipment.SplitConsignmentIndicator == null)
                    shipment.SplitConsignmentIndicator = new SplitConsignmentIndicatorType();
                SetField(shipment.SplitConsignmentIndicator, xmlMapping);
                break;
            case "ConsignmentQuantity":
                if (shipment.ConsignmentQuantity == null)
                    shipment.ConsignmentQuantity = new ConsignmentQuantityType();
                SetField(shipment.ConsignmentQuantity, xmlMapping);
                break;
            case "Consignment":
                if (xmlMapping is IXmlCollectionMapping collMappingConsignment && !collMappingConsignment.HasNextNode)
                {
                    if (shipment.Consignment == null)
                        shipment.Consignment = new ConsignmentType[collMappingConsignment.Quantity];

                    for (int i = 0; i < collMappingConsignment.Quantity; i++)
                    {
                        var row = shipment.Consignment[i] = new ConsignmentType();

                        foreach (var colMapp in collMappingConsignment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.Consignment == null)
                    {
                        shipment.Consignment = new ConsignmentType[1];
                        shipment.Consignment[0] = new ConsignmentType();
                    }
                    SetField(shipment.Consignment[0], xmlMapping);
                }
                break;
            case "GoodsItem":
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem && !collMappingGoodsItem.HasNextNode)
                {
                    if (shipment.GoodsItem == null)
                        shipment.GoodsItem = new GoodsItemType[collMappingGoodsItem.Quantity];

                    for (int i = 0; i < collMappingGoodsItem.Quantity; i++)
                    {
                        var row = shipment.GoodsItem[i] = new GoodsItemType();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.GoodsItem == null)
                    {
                        shipment.GoodsItem = new GoodsItemType[1];
                        shipment.GoodsItem[0] = new GoodsItemType();
                    }
                    SetField(shipment.GoodsItem[0], xmlMapping);
                }
                break;
            case "ShipmentStage":
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentStage && !collMappingShipmentStage.HasNextNode)
                {
                    if (shipment.ShipmentStage == null)
                        shipment.ShipmentStage = new ShipmentStageType[collMappingShipmentStage.Quantity];

                    for (int i = 0; i < collMappingShipmentStage.Quantity; i++)
                    {
                        var row = shipment.ShipmentStage[i] = new ShipmentStageType();

                        foreach (var colMapp in collMappingShipmentStage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.ShipmentStage == null)
                    {
                        shipment.ShipmentStage = new ShipmentStageType[1];
                        shipment.ShipmentStage[0] = new ShipmentStageType();
                    }
                    SetField(shipment.ShipmentStage[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (shipment.Delivery == null)
                    shipment.Delivery = new DeliveryType();
                SetField(shipment.Delivery, xmlMapping);
                break;
            case "TransportHandlingUnit":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportHandlingUnit && !collMappingTransportHandlingUnit.HasNextNode)
                {
                    if (shipment.TransportHandlingUnit == null)
                        shipment.TransportHandlingUnit = new TransportHandlingUnitType[collMappingTransportHandlingUnit.Quantity];

                    for (int i = 0; i < collMappingTransportHandlingUnit.Quantity; i++)
                    {
                        var row = shipment.TransportHandlingUnit[i] = new TransportHandlingUnitType();

                        foreach (var colMapp in collMappingTransportHandlingUnit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.TransportHandlingUnit == null)
                    {
                        shipment.TransportHandlingUnit = new TransportHandlingUnitType[1];
                        shipment.TransportHandlingUnit[0] = new TransportHandlingUnitType();
                    }
                    SetField(shipment.TransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "ReturnAddress":
                if (shipment.ReturnAddress == null)
                    shipment.ReturnAddress = new AddressType();
                SetField(shipment.ReturnAddress, xmlMapping);
                break;
            case "OriginAddress":
                if (shipment.OriginAddress == null)
                    shipment.OriginAddress = new AddressType();
                SetField(shipment.OriginAddress, xmlMapping);
                break;
            case "FirstArrivalPortLocation":
                if (shipment.FirstArrivalPortLocation == null)
                    shipment.FirstArrivalPortLocation = new LocationType1();
                SetField(shipment.FirstArrivalPortLocation, xmlMapping);
                break;
            case "LastExitPortLocation":
                if (shipment.LastExitPortLocation == null)
                    shipment.LastExitPortLocation = new LocationType1();
                SetField(shipment.LastExitPortLocation, xmlMapping);
                break;
            case "ExportCountry":
                if (shipment.ExportCountry == null)
                    shipment.ExportCountry = new CountryType();
                SetField(shipment.ExportCountry, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge && !collMappingFreightAllowanceCharge.HasNextNode)
                {
                    if (shipment.FreightAllowanceCharge == null)
                        shipment.FreightAllowanceCharge = new AllowanceChargeType[collMappingFreightAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingFreightAllowanceCharge.Quantity; i++)
                    {
                        var row = shipment.FreightAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipment.FreightAllowanceCharge == null)
                    {
                        shipment.FreightAllowanceCharge = new AllowanceChargeType[1];
                        shipment.FreightAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(shipment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ConsignmentType consignment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (consignment.ID == null)
                    consignment.ID = new IDType();
                SetField(consignment.ID, xmlMapping);
                break;
            case "CarrierAssignedID":
                if (consignment.CarrierAssignedID == null)
                    consignment.CarrierAssignedID = new CarrierAssignedIDType();
                SetField(consignment.CarrierAssignedID, xmlMapping);
                break;
            case "ConsigneeAssignedID":
                if (consignment.ConsigneeAssignedID == null)
                    consignment.ConsigneeAssignedID = new ConsigneeAssignedIDType();
                SetField(consignment.ConsigneeAssignedID, xmlMapping);
                break;
            case "ConsignorAssignedID":
                if (consignment.ConsignorAssignedID == null)
                    consignment.ConsignorAssignedID = new ConsignorAssignedIDType();
                SetField(consignment.ConsignorAssignedID, xmlMapping);
                break;
            case "FreightForwarderAssignedID":
                if (consignment.FreightForwarderAssignedID == null)
                    consignment.FreightForwarderAssignedID = new FreightForwarderAssignedIDType();
                SetField(consignment.FreightForwarderAssignedID, xmlMapping);
                break;
            case "BrokerAssignedID":
                if (consignment.BrokerAssignedID == null)
                    consignment.BrokerAssignedID = new BrokerAssignedIDType();
                SetField(consignment.BrokerAssignedID, xmlMapping);
                break;
            case "ContractedCarrierAssignedID":
                if (consignment.ContractedCarrierAssignedID == null)
                    consignment.ContractedCarrierAssignedID = new ContractedCarrierAssignedIDType();
                SetField(consignment.ContractedCarrierAssignedID, xmlMapping);
                break;
            case "PerformingCarrierAssignedID":
                if (consignment.PerformingCarrierAssignedID == null)
                    consignment.PerformingCarrierAssignedID = new PerformingCarrierAssignedIDType();
                SetField(consignment.PerformingCarrierAssignedID, xmlMapping);
                break;
            case "SummaryDescription":
                if (xmlMapping is IXmlCollectionMapping collMappingSummaryDescription && !collMappingSummaryDescription.HasNextNode)
                {
                    if (consignment.SummaryDescription == null)
                        consignment.SummaryDescription = new SummaryDescriptionType[collMappingSummaryDescription.Quantity];

                    for (int i = 0; i < collMappingSummaryDescription.Quantity; i++)
                    {
                        var row = consignment.SummaryDescription[i] = new SummaryDescriptionType();

                        foreach (var colMapp in collMappingSummaryDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.SummaryDescription == null)
                    {
                        consignment.SummaryDescription = new SummaryDescriptionType[1];
                        consignment.SummaryDescription[0] = new SummaryDescriptionType();
                    }
                    SetField(consignment.SummaryDescription[0], xmlMapping);
                }
                break;
            case "TotalInvoiceAmount":
                if (consignment.TotalInvoiceAmount == null)
                    consignment.TotalInvoiceAmount = new TotalInvoiceAmountType();
                SetField(consignment.TotalInvoiceAmount, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (consignment.DeclaredCustomsValueAmount == null)
                    consignment.DeclaredCustomsValueAmount = new DeclaredCustomsValueAmountType();
                SetField(consignment.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "TariffDescription":
                if (xmlMapping is IXmlCollectionMapping collMappingTariffDescription && !collMappingTariffDescription.HasNextNode)
                {
                    if (consignment.TariffDescription == null)
                        consignment.TariffDescription = new TariffDescriptionType[collMappingTariffDescription.Quantity];

                    for (int i = 0; i < collMappingTariffDescription.Quantity; i++)
                    {
                        var row = consignment.TariffDescription[i] = new TariffDescriptionType();

                        foreach (var colMapp in collMappingTariffDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.TariffDescription == null)
                    {
                        consignment.TariffDescription = new TariffDescriptionType[1];
                        consignment.TariffDescription[0] = new TariffDescriptionType();
                    }
                    SetField(consignment.TariffDescription[0], xmlMapping);
                }
                break;
            case "TariffCode":
                if (consignment.TariffCode == null)
                    consignment.TariffCode = new TariffCodeType();
                SetField(consignment.TariffCode, xmlMapping);
                break;
            case "InsurancePremiumAmount":
                if (consignment.InsurancePremiumAmount == null)
                    consignment.InsurancePremiumAmount = new InsurancePremiumAmountType();
                SetField(consignment.InsurancePremiumAmount, xmlMapping);
                break;
            case "GrossWeightMeasure":
                if (consignment.GrossWeightMeasure == null)
                    consignment.GrossWeightMeasure = new GrossWeightMeasureType();
                SetField(consignment.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (consignment.NetWeightMeasure == null)
                    consignment.NetWeightMeasure = new NetWeightMeasureType();
                SetField(consignment.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (consignment.NetNetWeightMeasure == null)
                    consignment.NetNetWeightMeasure = new NetNetWeightMeasureType();
                SetField(consignment.NetNetWeightMeasure, xmlMapping);
                break;
            case "ChargeableWeightMeasure":
                if (consignment.ChargeableWeightMeasure == null)
                    consignment.ChargeableWeightMeasure = new ChargeableWeightMeasureType();
                SetField(consignment.ChargeableWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (consignment.GrossVolumeMeasure == null)
                    consignment.GrossVolumeMeasure = new GrossVolumeMeasureType();
                SetField(consignment.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (consignment.NetVolumeMeasure == null)
                    consignment.NetVolumeMeasure = new NetVolumeMeasureType();
                SetField(consignment.NetVolumeMeasure, xmlMapping);
                break;
            case "LoadingLengthMeasure":
                if (consignment.LoadingLengthMeasure == null)
                    consignment.LoadingLengthMeasure = new LoadingLengthMeasureType();
                SetField(consignment.LoadingLengthMeasure, xmlMapping);
                break;
            case "Remarks":
                if (xmlMapping is IXmlCollectionMapping collMappingRemarks && !collMappingRemarks.HasNextNode)
                {
                    if (consignment.Remarks == null)
                        consignment.Remarks = new RemarksType[collMappingRemarks.Quantity];

                    for (int i = 0; i < collMappingRemarks.Quantity; i++)
                    {
                        var row = consignment.Remarks[i] = new RemarksType();

                        foreach (var colMapp in collMappingRemarks.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.Remarks == null)
                    {
                        consignment.Remarks = new RemarksType[1];
                        consignment.Remarks[0] = new RemarksType();
                    }
                    SetField(consignment.Remarks[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (consignment.HazardousRiskIndicator == null)
                    consignment.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(consignment.HazardousRiskIndicator, xmlMapping);
                break;
            case "AnimalFoodIndicator":
                if (consignment.AnimalFoodIndicator == null)
                    consignment.AnimalFoodIndicator = new AnimalFoodIndicatorType();
                SetField(consignment.AnimalFoodIndicator, xmlMapping);
                break;
            case "HumanFoodIndicator":
                if (consignment.HumanFoodIndicator == null)
                    consignment.HumanFoodIndicator = new HumanFoodIndicatorType();
                SetField(consignment.HumanFoodIndicator, xmlMapping);
                break;
            case "LivestockIndicator":
                if (consignment.LivestockIndicator == null)
                    consignment.LivestockIndicator = new LivestockIndicatorType();
                SetField(consignment.LivestockIndicator, xmlMapping);
                break;
            case "BulkCargoIndicator":
                if (consignment.BulkCargoIndicator == null)
                    consignment.BulkCargoIndicator = new BulkCargoIndicatorType();
                SetField(consignment.BulkCargoIndicator, xmlMapping);
                break;
            case "ContainerizedIndicator":
                if (consignment.ContainerizedIndicator == null)
                    consignment.ContainerizedIndicator = new ContainerizedIndicatorType();
                SetField(consignment.ContainerizedIndicator, xmlMapping);
                break;
            case "GeneralCargoIndicator":
                if (consignment.GeneralCargoIndicator == null)
                    consignment.GeneralCargoIndicator = new GeneralCargoIndicatorType();
                SetField(consignment.GeneralCargoIndicator, xmlMapping);
                break;
            case "SpecialSecurityIndicator":
                if (consignment.SpecialSecurityIndicator == null)
                    consignment.SpecialSecurityIndicator = new SpecialSecurityIndicatorType();
                SetField(consignment.SpecialSecurityIndicator, xmlMapping);
                break;
            case "ThirdPartyPayerIndicator":
                if (consignment.ThirdPartyPayerIndicator == null)
                    consignment.ThirdPartyPayerIndicator = new ThirdPartyPayerIndicatorType();
                SetField(consignment.ThirdPartyPayerIndicator, xmlMapping);
                break;
            case "CarrierServiceInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingCarrierServiceInstructions && !collMappingCarrierServiceInstructions.HasNextNode)
                {
                    if (consignment.CarrierServiceInstructions == null)
                        consignment.CarrierServiceInstructions = new CarrierServiceInstructionsType[collMappingCarrierServiceInstructions.Quantity];

                    for (int i = 0; i < collMappingCarrierServiceInstructions.Quantity; i++)
                    {
                        var row = consignment.CarrierServiceInstructions[i] = new CarrierServiceInstructionsType();

                        foreach (var colMapp in collMappingCarrierServiceInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.CarrierServiceInstructions == null)
                    {
                        consignment.CarrierServiceInstructions = new CarrierServiceInstructionsType[1];
                        consignment.CarrierServiceInstructions[0] = new CarrierServiceInstructionsType();
                    }
                    SetField(consignment.CarrierServiceInstructions[0], xmlMapping);
                }
                break;
            case "CustomsClearanceServiceInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsClearanceServiceInstructions && !collMappingCustomsClearanceServiceInstructions.HasNextNode)
                {
                    if (consignment.CustomsClearanceServiceInstructions == null)
                        consignment.CustomsClearanceServiceInstructions = new CustomsClearanceServiceInstructionsType[collMappingCustomsClearanceServiceInstructions.Quantity];

                    for (int i = 0; i < collMappingCustomsClearanceServiceInstructions.Quantity; i++)
                    {
                        var row = consignment.CustomsClearanceServiceInstructions[i] = new CustomsClearanceServiceInstructionsType();

                        foreach (var colMapp in collMappingCustomsClearanceServiceInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.CustomsClearanceServiceInstructions == null)
                    {
                        consignment.CustomsClearanceServiceInstructions = new CustomsClearanceServiceInstructionsType[1];
                        consignment.CustomsClearanceServiceInstructions[0] = new CustomsClearanceServiceInstructionsType();
                    }
                    SetField(consignment.CustomsClearanceServiceInstructions[0], xmlMapping);
                }
                break;
            case "ForwarderServiceInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingForwarderServiceInstructions && !collMappingForwarderServiceInstructions.HasNextNode)
                {
                    if (consignment.ForwarderServiceInstructions == null)
                        consignment.ForwarderServiceInstructions = new ForwarderServiceInstructionsType[collMappingForwarderServiceInstructions.Quantity];

                    for (int i = 0; i < collMappingForwarderServiceInstructions.Quantity; i++)
                    {
                        var row = consignment.ForwarderServiceInstructions[i] = new ForwarderServiceInstructionsType();

                        foreach (var colMapp in collMappingForwarderServiceInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.ForwarderServiceInstructions == null)
                    {
                        consignment.ForwarderServiceInstructions = new ForwarderServiceInstructionsType[1];
                        consignment.ForwarderServiceInstructions[0] = new ForwarderServiceInstructionsType();
                    }
                    SetField(consignment.ForwarderServiceInstructions[0], xmlMapping);
                }
                break;
            case "SpecialServiceInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialServiceInstructions && !collMappingSpecialServiceInstructions.HasNextNode)
                {
                    if (consignment.SpecialServiceInstructions == null)
                        consignment.SpecialServiceInstructions = new SpecialServiceInstructionsType[collMappingSpecialServiceInstructions.Quantity];

                    for (int i = 0; i < collMappingSpecialServiceInstructions.Quantity; i++)
                    {
                        var row = consignment.SpecialServiceInstructions[i] = new SpecialServiceInstructionsType();

                        foreach (var colMapp in collMappingSpecialServiceInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.SpecialServiceInstructions == null)
                    {
                        consignment.SpecialServiceInstructions = new SpecialServiceInstructionsType[1];
                        consignment.SpecialServiceInstructions[0] = new SpecialServiceInstructionsType();
                    }
                    SetField(consignment.SpecialServiceInstructions[0], xmlMapping);
                }
                break;
            case "SequenceID":
                if (consignment.SequenceID == null)
                    consignment.SequenceID = new SequenceIDType();
                SetField(consignment.SequenceID, xmlMapping);
                break;
            case "ShippingPriorityLevelCode":
                if (consignment.ShippingPriorityLevelCode == null)
                    consignment.ShippingPriorityLevelCode = new ShippingPriorityLevelCodeType();
                SetField(consignment.ShippingPriorityLevelCode, xmlMapping);
                break;
            case "HandlingCode":
                if (consignment.HandlingCode == null)
                    consignment.HandlingCode = new HandlingCodeType();
                SetField(consignment.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions && !collMappingHandlingInstructions.HasNextNode)
                {
                    if (consignment.HandlingInstructions == null)
                        consignment.HandlingInstructions = new HandlingInstructionsType[collMappingHandlingInstructions.Quantity];

                    for (int i = 0; i < collMappingHandlingInstructions.Quantity; i++)
                    {
                        var row = consignment.HandlingInstructions[i] = new HandlingInstructionsType();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.HandlingInstructions == null)
                    {
                        consignment.HandlingInstructions = new HandlingInstructionsType[1];
                        consignment.HandlingInstructions[0] = new HandlingInstructionsType();
                    }
                    SetField(consignment.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "Information":
                if (xmlMapping is IXmlCollectionMapping collMappingInformation && !collMappingInformation.HasNextNode)
                {
                    if (consignment.Information == null)
                        consignment.Information = new InformationType[collMappingInformation.Quantity];

                    for (int i = 0; i < collMappingInformation.Quantity; i++)
                    {
                        var row = consignment.Information[i] = new InformationType();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.Information == null)
                    {
                        consignment.Information = new InformationType[1];
                        consignment.Information[0] = new InformationType();
                    }
                    SetField(consignment.Information[0], xmlMapping);
                }
                break;
            case "TotalGoodsItemQuantity":
                if (consignment.TotalGoodsItemQuantity == null)
                    consignment.TotalGoodsItemQuantity = new TotalGoodsItemQuantityType();
                SetField(consignment.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalTransportHandlingUnitQuantity":
                if (consignment.TotalTransportHandlingUnitQuantity == null)
                    consignment.TotalTransportHandlingUnitQuantity = new TotalTransportHandlingUnitQuantityType();
                SetField(consignment.TotalTransportHandlingUnitQuantity, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (consignment.InsuranceValueAmount == null)
                    consignment.InsuranceValueAmount = new InsuranceValueAmountType();
                SetField(consignment.InsuranceValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (consignment.DeclaredForCarriageValueAmount == null)
                    consignment.DeclaredForCarriageValueAmount = new DeclaredForCarriageValueAmountType();
                SetField(consignment.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (consignment.DeclaredStatisticsValueAmount == null)
                    consignment.DeclaredStatisticsValueAmount = new DeclaredStatisticsValueAmountType();
                SetField(consignment.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (consignment.FreeOnBoardValueAmount == null)
                    consignment.FreeOnBoardValueAmount = new FreeOnBoardValueAmountType();
                SetField(consignment.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "SpecialInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialInstructions && !collMappingSpecialInstructions.HasNextNode)
                {
                    if (consignment.SpecialInstructions == null)
                        consignment.SpecialInstructions = new SpecialInstructionsType[collMappingSpecialInstructions.Quantity];

                    for (int i = 0; i < collMappingSpecialInstructions.Quantity; i++)
                    {
                        var row = consignment.SpecialInstructions[i] = new SpecialInstructionsType();

                        foreach (var colMapp in collMappingSpecialInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.SpecialInstructions == null)
                    {
                        consignment.SpecialInstructions = new SpecialInstructionsType[1];
                        consignment.SpecialInstructions[0] = new SpecialInstructionsType();
                    }
                    SetField(consignment.SpecialInstructions[0], xmlMapping);
                }
                break;
            case "SplitConsignmentIndicator":
                if (consignment.SplitConsignmentIndicator == null)
                    consignment.SplitConsignmentIndicator = new SplitConsignmentIndicatorType();
                SetField(consignment.SplitConsignmentIndicator, xmlMapping);
                break;
            case "DeliveryInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryInstructions && !collMappingDeliveryInstructions.HasNextNode)
                {
                    if (consignment.DeliveryInstructions == null)
                        consignment.DeliveryInstructions = new DeliveryInstructionsType[collMappingDeliveryInstructions.Quantity];

                    for (int i = 0; i < collMappingDeliveryInstructions.Quantity; i++)
                    {
                        var row = consignment.DeliveryInstructions[i] = new DeliveryInstructionsType();

                        foreach (var colMapp in collMappingDeliveryInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.DeliveryInstructions == null)
                    {
                        consignment.DeliveryInstructions = new DeliveryInstructionsType[1];
                        consignment.DeliveryInstructions[0] = new DeliveryInstructionsType();
                    }
                    SetField(consignment.DeliveryInstructions[0], xmlMapping);
                }
                break;
            case "ConsignmentQuantity":
                if (consignment.ConsignmentQuantity == null)
                    consignment.ConsignmentQuantity = new ConsignmentQuantityType();
                SetField(consignment.ConsignmentQuantity, xmlMapping);
                break;
            case "ConsolidatableIndicator":
                if (consignment.ConsolidatableIndicator == null)
                    consignment.ConsolidatableIndicator = new ConsolidatableIndicatorType();
                SetField(consignment.ConsolidatableIndicator, xmlMapping);
                break;
            case "HaulageInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingHaulageInstructions && !collMappingHaulageInstructions.HasNextNode)
                {
                    if (consignment.HaulageInstructions == null)
                        consignment.HaulageInstructions = new HaulageInstructionsType[collMappingHaulageInstructions.Quantity];

                    for (int i = 0; i < collMappingHaulageInstructions.Quantity; i++)
                    {
                        var row = consignment.HaulageInstructions[i] = new HaulageInstructionsType();

                        foreach (var colMapp in collMappingHaulageInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.HaulageInstructions == null)
                    {
                        consignment.HaulageInstructions = new HaulageInstructionsType[1];
                        consignment.HaulageInstructions[0] = new HaulageInstructionsType();
                    }
                    SetField(consignment.HaulageInstructions[0], xmlMapping);
                }
                break;
            case "LoadingSequenceID":
                if (consignment.LoadingSequenceID == null)
                    consignment.LoadingSequenceID = new LoadingSequenceIDType();
                SetField(consignment.LoadingSequenceID, xmlMapping);
                break;
            case "ChildConsignmentQuantity":
                if (consignment.ChildConsignmentQuantity == null)
                    consignment.ChildConsignmentQuantity = new ChildConsignmentQuantityType();
                SetField(consignment.ChildConsignmentQuantity, xmlMapping);
                break;
            case "TotalPackagesQuantity":
                if (consignment.TotalPackagesQuantity == null)
                    consignment.TotalPackagesQuantity = new TotalPackagesQuantityType();
                SetField(consignment.TotalPackagesQuantity, xmlMapping);
                break;
            case "ConsolidatedShipment":
                if (xmlMapping is IXmlCollectionMapping collMappingConsolidatedShipment && !collMappingConsolidatedShipment.HasNextNode)
                {
                    if (consignment.ConsolidatedShipment == null)
                        consignment.ConsolidatedShipment = new ShipmentType[collMappingConsolidatedShipment.Quantity];

                    for (int i = 0; i < collMappingConsolidatedShipment.Quantity; i++)
                    {
                        var row = consignment.ConsolidatedShipment[i] = new ShipmentType();

                        foreach (var colMapp in collMappingConsolidatedShipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.ConsolidatedShipment == null)
                    {
                        consignment.ConsolidatedShipment = new ShipmentType[1];
                        consignment.ConsolidatedShipment[0] = new ShipmentType();
                    }
                    SetField(consignment.ConsolidatedShipment[0], xmlMapping);
                }
                break;
            case "CustomsDeclaration":
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsDeclaration && !collMappingCustomsDeclaration.HasNextNode)
                {
                    if (consignment.CustomsDeclaration == null)
                        consignment.CustomsDeclaration = new CustomsDeclarationType[collMappingCustomsDeclaration.Quantity];

                    for (int i = 0; i < collMappingCustomsDeclaration.Quantity; i++)
                    {
                        var row = consignment.CustomsDeclaration[i] = new CustomsDeclarationType();

                        foreach (var colMapp in collMappingCustomsDeclaration.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.CustomsDeclaration == null)
                    {
                        consignment.CustomsDeclaration = new CustomsDeclarationType[1];
                        consignment.CustomsDeclaration[0] = new CustomsDeclarationType();
                    }
                    SetField(consignment.CustomsDeclaration[0], xmlMapping);
                }
                break;
            case "RequestedPickupTransportEvent":
                if (consignment.RequestedPickupTransportEvent == null)
                    consignment.RequestedPickupTransportEvent = new TransportEventType();
                SetField(consignment.RequestedPickupTransportEvent, xmlMapping);
                break;
            case "RequestedDeliveryTransportEvent":
                if (consignment.RequestedDeliveryTransportEvent == null)
                    consignment.RequestedDeliveryTransportEvent = new TransportEventType();
                SetField(consignment.RequestedDeliveryTransportEvent, xmlMapping);
                break;
            case "PlannedPickupTransportEvent":
                if (consignment.PlannedPickupTransportEvent == null)
                    consignment.PlannedPickupTransportEvent = new TransportEventType();
                SetField(consignment.PlannedPickupTransportEvent, xmlMapping);
                break;
            case "PlannedDeliveryTransportEvent":
                if (consignment.PlannedDeliveryTransportEvent == null)
                    consignment.PlannedDeliveryTransportEvent = new TransportEventType();
                SetField(consignment.PlannedDeliveryTransportEvent, xmlMapping);
                break;
            case "Status":
                if (xmlMapping is IXmlCollectionMapping collMappingStatus && !collMappingStatus.HasNextNode)
                {
                    if (consignment.Status == null)
                        consignment.Status = new StatusType[collMappingStatus.Quantity];

                    for (int i = 0; i < collMappingStatus.Quantity; i++)
                    {
                        var row = consignment.Status[i] = new StatusType();

                        foreach (var colMapp in collMappingStatus.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.Status == null)
                    {
                        consignment.Status = new StatusType[1];
                        consignment.Status[0] = new StatusType();
                    }
                    SetField(consignment.Status[0], xmlMapping);
                }
                break;
            case "ChildConsignment":
                if (xmlMapping is IXmlCollectionMapping collMappingChildConsignment && !collMappingChildConsignment.HasNextNode)
                {
                    if (consignment.ChildConsignment == null)
                        consignment.ChildConsignment = new ConsignmentType[collMappingChildConsignment.Quantity];

                    for (int i = 0; i < collMappingChildConsignment.Quantity; i++)
                    {
                        var row = consignment.ChildConsignment[i] = new ConsignmentType();

                        foreach (var colMapp in collMappingChildConsignment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.ChildConsignment == null)
                    {
                        consignment.ChildConsignment = new ConsignmentType[1];
                        consignment.ChildConsignment[0] = new ConsignmentType();
                    }
                    SetField(consignment.ChildConsignment[0], xmlMapping);
                }
                break;
            case "ConsigneeParty":
                if (consignment.ConsigneeParty == null)
                    consignment.ConsigneeParty = new PartyType();
                SetField(consignment.ConsigneeParty, xmlMapping);
                break;
            case "ExporterParty":
                if (consignment.ExporterParty == null)
                    consignment.ExporterParty = new PartyType();
                SetField(consignment.ExporterParty, xmlMapping);
                break;
            case "ConsignorParty":
                if (consignment.ConsignorParty == null)
                    consignment.ConsignorParty = new PartyType();
                SetField(consignment.ConsignorParty, xmlMapping);
                break;
            case "ImporterParty":
                if (consignment.ImporterParty == null)
                    consignment.ImporterParty = new PartyType();
                SetField(consignment.ImporterParty, xmlMapping);
                break;
            case "CarrierParty":
                if (consignment.CarrierParty == null)
                    consignment.CarrierParty = new PartyType();
                SetField(consignment.CarrierParty, xmlMapping);
                break;
            case "FreightForwarderParty":
                if (consignment.FreightForwarderParty == null)
                    consignment.FreightForwarderParty = new PartyType();
                SetField(consignment.FreightForwarderParty, xmlMapping);
                break;
            case "NotifyParty":
                if (consignment.NotifyParty == null)
                    consignment.NotifyParty = new PartyType();
                SetField(consignment.NotifyParty, xmlMapping);
                break;
            case "OriginalDespatchParty":
                if (consignment.OriginalDespatchParty == null)
                    consignment.OriginalDespatchParty = new PartyType();
                SetField(consignment.OriginalDespatchParty, xmlMapping);
                break;
            case "FinalDeliveryParty":
                if (consignment.FinalDeliveryParty == null)
                    consignment.FinalDeliveryParty = new PartyType();
                SetField(consignment.FinalDeliveryParty, xmlMapping);
                break;
            case "PerformingCarrierParty":
                if (consignment.PerformingCarrierParty == null)
                    consignment.PerformingCarrierParty = new PartyType();
                SetField(consignment.PerformingCarrierParty, xmlMapping);
                break;
            case "SubstituteCarrierParty":
                if (consignment.SubstituteCarrierParty == null)
                    consignment.SubstituteCarrierParty = new PartyType();
                SetField(consignment.SubstituteCarrierParty, xmlMapping);
                break;
            case "LogisticsOperatorParty":
                if (consignment.LogisticsOperatorParty == null)
                    consignment.LogisticsOperatorParty = new PartyType();
                SetField(consignment.LogisticsOperatorParty, xmlMapping);
                break;
            case "TransportAdvisorParty":
                if (consignment.TransportAdvisorParty == null)
                    consignment.TransportAdvisorParty = new PartyType();
                SetField(consignment.TransportAdvisorParty, xmlMapping);
                break;
            case "HazardousItemNotificationParty":
                if (consignment.HazardousItemNotificationParty == null)
                    consignment.HazardousItemNotificationParty = new PartyType();
                SetField(consignment.HazardousItemNotificationParty, xmlMapping);
                break;
            case "InsuranceParty":
                if (consignment.InsuranceParty == null)
                    consignment.InsuranceParty = new PartyType();
                SetField(consignment.InsuranceParty, xmlMapping);
                break;
            case "MortgageHolderParty":
                if (consignment.MortgageHolderParty == null)
                    consignment.MortgageHolderParty = new PartyType();
                SetField(consignment.MortgageHolderParty, xmlMapping);
                break;
            case "BillOfLadingHolderParty":
                if (consignment.BillOfLadingHolderParty == null)
                    consignment.BillOfLadingHolderParty = new PartyType();
                SetField(consignment.BillOfLadingHolderParty, xmlMapping);
                break;
            case "OriginalDepartureCountry":
                if (consignment.OriginalDepartureCountry == null)
                    consignment.OriginalDepartureCountry = new CountryType();
                SetField(consignment.OriginalDepartureCountry, xmlMapping);
                break;
            case "FinalDestinationCountry":
                if (consignment.FinalDestinationCountry == null)
                    consignment.FinalDestinationCountry = new CountryType();
                SetField(consignment.FinalDestinationCountry, xmlMapping);
                break;
            case "TransitCountry":
                if (xmlMapping is IXmlCollectionMapping collMappingTransitCountry && !collMappingTransitCountry.HasNextNode)
                {
                    if (consignment.TransitCountry == null)
                        consignment.TransitCountry = new CountryType[collMappingTransitCountry.Quantity];

                    for (int i = 0; i < collMappingTransitCountry.Quantity; i++)
                    {
                        var row = consignment.TransitCountry[i] = new CountryType();

                        foreach (var colMapp in collMappingTransitCountry.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.TransitCountry == null)
                    {
                        consignment.TransitCountry = new CountryType[1];
                        consignment.TransitCountry[0] = new CountryType();
                    }
                    SetField(consignment.TransitCountry[0], xmlMapping);
                }
                break;
            case "TransportContract":
                if (consignment.TransportContract == null)
                    consignment.TransportContract = new ContractType();
                SetField(consignment.TransportContract, xmlMapping);
                break;
            case "TransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent && !collMappingTransportEvent.HasNextNode)
                {
                    if (consignment.TransportEvent == null)
                        consignment.TransportEvent = new TransportEventType[collMappingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingTransportEvent.Quantity; i++)
                    {
                        var row = consignment.TransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.TransportEvent == null)
                    {
                        consignment.TransportEvent = new TransportEventType[1];
                        consignment.TransportEvent[0] = new TransportEventType();
                    }
                    SetField(consignment.TransportEvent[0], xmlMapping);
                }
                break;
            case "OriginalDespatchTransportationService":
                if (consignment.OriginalDespatchTransportationService == null)
                    consignment.OriginalDespatchTransportationService = new TransportationServiceType();
                SetField(consignment.OriginalDespatchTransportationService, xmlMapping);
                break;
            case "FinalDeliveryTransportationService":
                if (consignment.FinalDeliveryTransportationService == null)
                    consignment.FinalDeliveryTransportationService = new TransportationServiceType();
                SetField(consignment.FinalDeliveryTransportationService, xmlMapping);
                break;
            case "DeliveryTerms":
                if (consignment.DeliveryTerms == null)
                    consignment.DeliveryTerms = new DeliveryTermsType();
                SetField(consignment.DeliveryTerms, xmlMapping);
                break;
            case "PaymentTerms":
                if (consignment.PaymentTerms == null)
                    consignment.PaymentTerms = new PaymentTermsType();
                SetField(consignment.PaymentTerms, xmlMapping);
                break;
            case "CollectPaymentTerms":
                if (consignment.CollectPaymentTerms == null)
                    consignment.CollectPaymentTerms = new PaymentTermsType();
                SetField(consignment.CollectPaymentTerms, xmlMapping);
                break;
            case "DisbursementPaymentTerms":
                if (consignment.DisbursementPaymentTerms == null)
                    consignment.DisbursementPaymentTerms = new PaymentTermsType();
                SetField(consignment.DisbursementPaymentTerms, xmlMapping);
                break;
            case "PrepaidPaymentTerms":
                if (consignment.PrepaidPaymentTerms == null)
                    consignment.PrepaidPaymentTerms = new PaymentTermsType();
                SetField(consignment.PrepaidPaymentTerms, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge && !collMappingFreightAllowanceCharge.HasNextNode)
                {
                    if (consignment.FreightAllowanceCharge == null)
                        consignment.FreightAllowanceCharge = new AllowanceChargeType[collMappingFreightAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingFreightAllowanceCharge.Quantity; i++)
                    {
                        var row = consignment.FreightAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.FreightAllowanceCharge == null)
                    {
                        consignment.FreightAllowanceCharge = new AllowanceChargeType[1];
                        consignment.FreightAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(consignment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "ExtraAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingExtraAllowanceCharge && !collMappingExtraAllowanceCharge.HasNextNode)
                {
                    if (consignment.ExtraAllowanceCharge == null)
                        consignment.ExtraAllowanceCharge = new AllowanceChargeType[collMappingExtraAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingExtraAllowanceCharge.Quantity; i++)
                    {
                        var row = consignment.ExtraAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingExtraAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.ExtraAllowanceCharge == null)
                    {
                        consignment.ExtraAllowanceCharge = new AllowanceChargeType[1];
                        consignment.ExtraAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(consignment.ExtraAllowanceCharge[0], xmlMapping);
                }
                break;
            case "MainCarriageShipmentStage":
                if (xmlMapping is IXmlCollectionMapping collMappingMainCarriageShipmentStage && !collMappingMainCarriageShipmentStage.HasNextNode)
                {
                    if (consignment.MainCarriageShipmentStage == null)
                        consignment.MainCarriageShipmentStage = new ShipmentStageType[collMappingMainCarriageShipmentStage.Quantity];

                    for (int i = 0; i < collMappingMainCarriageShipmentStage.Quantity; i++)
                    {
                        var row = consignment.MainCarriageShipmentStage[i] = new ShipmentStageType();

                        foreach (var colMapp in collMappingMainCarriageShipmentStage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.MainCarriageShipmentStage == null)
                    {
                        consignment.MainCarriageShipmentStage = new ShipmentStageType[1];
                        consignment.MainCarriageShipmentStage[0] = new ShipmentStageType();
                    }
                    SetField(consignment.MainCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "PreCarriageShipmentStage":
                if (xmlMapping is IXmlCollectionMapping collMappingPreCarriageShipmentStage && !collMappingPreCarriageShipmentStage.HasNextNode)
                {
                    if (consignment.PreCarriageShipmentStage == null)
                        consignment.PreCarriageShipmentStage = new ShipmentStageType[collMappingPreCarriageShipmentStage.Quantity];

                    for (int i = 0; i < collMappingPreCarriageShipmentStage.Quantity; i++)
                    {
                        var row = consignment.PreCarriageShipmentStage[i] = new ShipmentStageType();

                        foreach (var colMapp in collMappingPreCarriageShipmentStage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.PreCarriageShipmentStage == null)
                    {
                        consignment.PreCarriageShipmentStage = new ShipmentStageType[1];
                        consignment.PreCarriageShipmentStage[0] = new ShipmentStageType();
                    }
                    SetField(consignment.PreCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "OnCarriageShipmentStage":
                if (xmlMapping is IXmlCollectionMapping collMappingOnCarriageShipmentStage && !collMappingOnCarriageShipmentStage.HasNextNode)
                {
                    if (consignment.OnCarriageShipmentStage == null)
                        consignment.OnCarriageShipmentStage = new ShipmentStageType[collMappingOnCarriageShipmentStage.Quantity];

                    for (int i = 0; i < collMappingOnCarriageShipmentStage.Quantity; i++)
                    {
                        var row = consignment.OnCarriageShipmentStage[i] = new ShipmentStageType();

                        foreach (var colMapp in collMappingOnCarriageShipmentStage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.OnCarriageShipmentStage == null)
                    {
                        consignment.OnCarriageShipmentStage = new ShipmentStageType[1];
                        consignment.OnCarriageShipmentStage[0] = new ShipmentStageType();
                    }
                    SetField(consignment.OnCarriageShipmentStage[0], xmlMapping);
                }
                break;
            case "TransportHandlingUnit":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportHandlingUnit && !collMappingTransportHandlingUnit.HasNextNode)
                {
                    if (consignment.TransportHandlingUnit == null)
                        consignment.TransportHandlingUnit = new TransportHandlingUnitType[collMappingTransportHandlingUnit.Quantity];

                    for (int i = 0; i < collMappingTransportHandlingUnit.Quantity; i++)
                    {
                        var row = consignment.TransportHandlingUnit[i] = new TransportHandlingUnitType();

                        foreach (var colMapp in collMappingTransportHandlingUnit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (consignment.TransportHandlingUnit == null)
                    {
                        consignment.TransportHandlingUnit = new TransportHandlingUnitType[1];
                        consignment.TransportHandlingUnit[0] = new TransportHandlingUnitType();
                    }
                    SetField(consignment.TransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "FirstArrivalPortLocation":
                if (consignment.FirstArrivalPortLocation == null)
                    consignment.FirstArrivalPortLocation = new LocationType1();
                SetField(consignment.FirstArrivalPortLocation, xmlMapping);
                break;
            case "LastExitPortLocation":
                if (consignment.LastExitPortLocation == null)
                    consignment.LastExitPortLocation = new LocationType1();
                SetField(consignment.LastExitPortLocation, xmlMapping);
                break;

        }
    }
    public void SetField(CustomsDeclarationType customsdeclaration, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (customsdeclaration.ID == null)
                    customsdeclaration.ID = new IDType();
                SetField(customsdeclaration.ID, xmlMapping);
                break;
            case "IssuerParty":
                if (customsdeclaration.IssuerParty == null)
                    customsdeclaration.IssuerParty = new PartyType();
                SetField(customsdeclaration.IssuerParty, xmlMapping);
                break;

        }
    }
    public void SetField(TransportEventType requestedpickuptransportevent, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "IdentificationID":
                if (requestedpickuptransportevent.IdentificationID == null)
                    requestedpickuptransportevent.IdentificationID = new IdentificationIDType();
                SetField(requestedpickuptransportevent.IdentificationID, xmlMapping);
                break;
            case "OccurrenceDate":
                if (requestedpickuptransportevent.OccurrenceDate == null)
                    requestedpickuptransportevent.OccurrenceDate = new OccurrenceDateType();
                SetField(requestedpickuptransportevent.OccurrenceDate, xmlMapping);
                break;
            case "OccurrenceTime":
                if (requestedpickuptransportevent.OccurrenceTime == null)
                    requestedpickuptransportevent.OccurrenceTime = new OccurrenceTimeType();
                SetField(requestedpickuptransportevent.OccurrenceTime, xmlMapping);
                break;
            case "TransportEventTypeCode":
                if (requestedpickuptransportevent.TransportEventTypeCode == null)
                    requestedpickuptransportevent.TransportEventTypeCode = new TransportEventTypeCodeType();
                SetField(requestedpickuptransportevent.TransportEventTypeCode, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (requestedpickuptransportevent.Description == null)
                        requestedpickuptransportevent.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = requestedpickuptransportevent.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (requestedpickuptransportevent.Description == null)
                    {
                        requestedpickuptransportevent.Description = new DescriptionType[1];
                        requestedpickuptransportevent.Description[0] = new DescriptionType();
                    }
                    SetField(requestedpickuptransportevent.Description[0], xmlMapping);
                }
                break;
            case "CompletionIndicator":
                if (requestedpickuptransportevent.CompletionIndicator == null)
                    requestedpickuptransportevent.CompletionIndicator = new CompletionIndicatorType();
                SetField(requestedpickuptransportevent.CompletionIndicator, xmlMapping);
                break;
            case "ReportedShipment":
                if (requestedpickuptransportevent.ReportedShipment == null)
                    requestedpickuptransportevent.ReportedShipment = new ShipmentType();
                SetField(requestedpickuptransportevent.ReportedShipment, xmlMapping);
                break;
            case "CurrentStatus":
                if (xmlMapping is IXmlCollectionMapping collMappingCurrentStatus && !collMappingCurrentStatus.HasNextNode)
                {
                    if (requestedpickuptransportevent.CurrentStatus == null)
                        requestedpickuptransportevent.CurrentStatus = new StatusType[collMappingCurrentStatus.Quantity];

                    for (int i = 0; i < collMappingCurrentStatus.Quantity; i++)
                    {
                        var row = requestedpickuptransportevent.CurrentStatus[i] = new StatusType();

                        foreach (var colMapp in collMappingCurrentStatus.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (requestedpickuptransportevent.CurrentStatus == null)
                    {
                        requestedpickuptransportevent.CurrentStatus = new StatusType[1];
                        requestedpickuptransportevent.CurrentStatus[0] = new StatusType();
                    }
                    SetField(requestedpickuptransportevent.CurrentStatus[0], xmlMapping);
                }
                break;
            case "Contact":
                if (xmlMapping is IXmlCollectionMapping collMappingContact && !collMappingContact.HasNextNode)
                {
                    if (requestedpickuptransportevent.Contact == null)
                        requestedpickuptransportevent.Contact = new ContactType[collMappingContact.Quantity];

                    for (int i = 0; i < collMappingContact.Quantity; i++)
                    {
                        var row = requestedpickuptransportevent.Contact[i] = new ContactType();

                        foreach (var colMapp in collMappingContact.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (requestedpickuptransportevent.Contact == null)
                    {
                        requestedpickuptransportevent.Contact = new ContactType[1];
                        requestedpickuptransportevent.Contact[0] = new ContactType();
                    }
                    SetField(requestedpickuptransportevent.Contact[0], xmlMapping);
                }
                break;
            case "Location":
                if (requestedpickuptransportevent.Location == null)
                    requestedpickuptransportevent.Location = new LocationType1();
                SetField(requestedpickuptransportevent.Location, xmlMapping);
                break;
            case "Signature":
                if (requestedpickuptransportevent.Signature == null)
                    requestedpickuptransportevent.Signature = new SignatureType();
                SetField(requestedpickuptransportevent.Signature, xmlMapping);
                break;
            case "Period":
                if (xmlMapping is IXmlCollectionMapping collMappingPeriod && !collMappingPeriod.HasNextNode)
                {
                    if (requestedpickuptransportevent.Period == null)
                        requestedpickuptransportevent.Period = new PeriodType[collMappingPeriod.Quantity];

                    for (int i = 0; i < collMappingPeriod.Quantity; i++)
                    {
                        var row = requestedpickuptransportevent.Period[i] = new PeriodType();

                        foreach (var colMapp in collMappingPeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (requestedpickuptransportevent.Period == null)
                    {
                        requestedpickuptransportevent.Period = new PeriodType[1];
                        requestedpickuptransportevent.Period[0] = new PeriodType();
                    }
                    SetField(requestedpickuptransportevent.Period[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(StatusType currentstatus, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ConditionCode":
                if (currentstatus.ConditionCode == null)
                    currentstatus.ConditionCode = new ConditionCodeType();
                SetField(currentstatus.ConditionCode, xmlMapping);
                break;
            case "ReferenceDate":
                if (currentstatus.ReferenceDate == null)
                    currentstatus.ReferenceDate = new ReferenceDateType();
                SetField(currentstatus.ReferenceDate, xmlMapping);
                break;
            case "ReferenceTime":
                if (currentstatus.ReferenceTime == null)
                    currentstatus.ReferenceTime = new ReferenceTimeType();
                SetField(currentstatus.ReferenceTime, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (currentstatus.Description == null)
                        currentstatus.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = currentstatus.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (currentstatus.Description == null)
                    {
                        currentstatus.Description = new DescriptionType[1];
                        currentstatus.Description[0] = new DescriptionType();
                    }
                    SetField(currentstatus.Description[0], xmlMapping);
                }
                break;
            case "StatusReasonCode":
                if (currentstatus.StatusReasonCode == null)
                    currentstatus.StatusReasonCode = new StatusReasonCodeType();
                SetField(currentstatus.StatusReasonCode, xmlMapping);
                break;
            case "StatusReason":
                if (xmlMapping is IXmlCollectionMapping collMappingStatusReason && !collMappingStatusReason.HasNextNode)
                {
                    if (currentstatus.StatusReason == null)
                        currentstatus.StatusReason = new StatusReasonType[collMappingStatusReason.Quantity];

                    for (int i = 0; i < collMappingStatusReason.Quantity; i++)
                    {
                        var row = currentstatus.StatusReason[i] = new StatusReasonType();

                        foreach (var colMapp in collMappingStatusReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (currentstatus.StatusReason == null)
                    {
                        currentstatus.StatusReason = new StatusReasonType[1];
                        currentstatus.StatusReason[0] = new StatusReasonType();
                    }
                    SetField(currentstatus.StatusReason[0], xmlMapping);
                }
                break;
            case "SequenceID":
                if (currentstatus.SequenceID == null)
                    currentstatus.SequenceID = new SequenceIDType();
                SetField(currentstatus.SequenceID, xmlMapping);
                break;
            case "Text":
                if (xmlMapping is IXmlCollectionMapping collMappingText && !collMappingText.HasNextNode)
                {
                    if (currentstatus.Text == null)
                        currentstatus.Text = new TextType2[collMappingText.Quantity];

                    for (int i = 0; i < collMappingText.Quantity; i++)
                    {
                        var row = currentstatus.Text[i] = new TextType2();

                        foreach (var colMapp in collMappingText.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (currentstatus.Text == null)
                    {
                        currentstatus.Text = new TextType2[1];
                        currentstatus.Text[0] = new TextType2();
                    }
                    SetField(currentstatus.Text[0], xmlMapping);
                }
                break;
            case "IndicationIndicator":
                if (currentstatus.IndicationIndicator == null)
                    currentstatus.IndicationIndicator = new IndicationIndicatorType();
                SetField(currentstatus.IndicationIndicator, xmlMapping);
                break;
            case "Percent":
                if (currentstatus.Percent == null)
                    currentstatus.Percent = new PercentType1();
                SetField(currentstatus.Percent, xmlMapping);
                break;
            case "ReliabilityPercent":
                if (currentstatus.ReliabilityPercent == null)
                    currentstatus.ReliabilityPercent = new ReliabilityPercentType();
                SetField(currentstatus.ReliabilityPercent, xmlMapping);
                break;
            case "Condition":
                if (xmlMapping is IXmlCollectionMapping collMappingCondition && !collMappingCondition.HasNextNode)
                {
                    if (currentstatus.Condition == null)
                        currentstatus.Condition = new ConditionType1[collMappingCondition.Quantity];

                    for (int i = 0; i < collMappingCondition.Quantity; i++)
                    {
                        var row = currentstatus.Condition[i] = new ConditionType1();

                        foreach (var colMapp in collMappingCondition.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (currentstatus.Condition == null)
                    {
                        currentstatus.Condition = new ConditionType1[1];
                        currentstatus.Condition[0] = new ConditionType1();
                    }
                    SetField(currentstatus.Condition[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ConditionType1 condition, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (condition.AttributeID == null)
                    condition.AttributeID = new AttributeIDType();
                SetField(condition.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (condition.Measure == null)
                    condition.Measure = new MeasureType2();
                SetField(condition.Measure, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (condition.Description == null)
                        condition.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = condition.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (condition.Description == null)
                    {
                        condition.Description = new DescriptionType[1];
                        condition.Description[0] = new DescriptionType();
                    }
                    SetField(condition.Description[0], xmlMapping);
                }
                break;
            case "MinimumMeasure":
                if (condition.MinimumMeasure == null)
                    condition.MinimumMeasure = new MinimumMeasureType();
                SetField(condition.MinimumMeasure, xmlMapping);
                break;
            case "MaximumMeasure":
                if (condition.MaximumMeasure == null)
                    condition.MaximumMeasure = new MaximumMeasureType();
                SetField(condition.MaximumMeasure, xmlMapping);
                break;

        }
    }
    public void SetField(ContractType transportcontract, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportcontract.ID == null)
                    transportcontract.ID = new IDType();
                SetField(transportcontract.ID, xmlMapping);
                break;
            case "IssueDate":
                if (transportcontract.IssueDate == null)
                    transportcontract.IssueDate = new IssueDateType();
                SetField(transportcontract.IssueDate, xmlMapping);
                break;
            case "IssueTime":
                if (transportcontract.IssueTime == null)
                    transportcontract.IssueTime = new IssueTimeType();
                SetField(transportcontract.IssueTime, xmlMapping);
                break;
            case "NominationDate":
                if (transportcontract.NominationDate == null)
                    transportcontract.NominationDate = new NominationDateType();
                SetField(transportcontract.NominationDate, xmlMapping);
                break;
            case "NominationTime":
                if (transportcontract.NominationTime == null)
                    transportcontract.NominationTime = new NominationTimeType();
                SetField(transportcontract.NominationTime, xmlMapping);
                break;
            case "ContractTypeCode":
                if (transportcontract.ContractTypeCode == null)
                    transportcontract.ContractTypeCode = new ContractTypeCodeType();
                SetField(transportcontract.ContractTypeCode, xmlMapping);
                break;
            case "ContractType1":
                if (transportcontract.ContractType1 == null)
                    transportcontract.ContractType1 = new ContractTypeType();
                SetField(transportcontract.ContractType1, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (transportcontract.Note == null)
                        transportcontract.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = transportcontract.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportcontract.Note == null)
                    {
                        transportcontract.Note = new NoteType[1];
                        transportcontract.Note[0] = new NoteType();
                    }
                    SetField(transportcontract.Note[0], xmlMapping);
                }
                break;
            case "VersionID":
                if (transportcontract.VersionID == null)
                    transportcontract.VersionID = new VersionIDType();
                SetField(transportcontract.VersionID, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (transportcontract.Description == null)
                        transportcontract.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = transportcontract.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportcontract.Description == null)
                    {
                        transportcontract.Description = new DescriptionType[1];
                        transportcontract.Description[0] = new DescriptionType();
                    }
                    SetField(transportcontract.Description[0], xmlMapping);
                }
                break;
            case "ValidityPeriod":
                if (transportcontract.ValidityPeriod == null)
                    transportcontract.ValidityPeriod = new PeriodType();
                SetField(transportcontract.ValidityPeriod, xmlMapping);
                break;
            case "ContractDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingContractDocumentReference && !collMappingContractDocumentReference.HasNextNode)
                {
                    if (transportcontract.ContractDocumentReference == null)
                        transportcontract.ContractDocumentReference = new DocumentReferenceType[collMappingContractDocumentReference.Quantity];

                    for (int i = 0; i < collMappingContractDocumentReference.Quantity; i++)
                    {
                        var row = transportcontract.ContractDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingContractDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportcontract.ContractDocumentReference == null)
                    {
                        transportcontract.ContractDocumentReference = new DocumentReferenceType[1];
                        transportcontract.ContractDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(transportcontract.ContractDocumentReference[0], xmlMapping);
                }
                break;
            case "NominationPeriod":
                if (transportcontract.NominationPeriod == null)
                    transportcontract.NominationPeriod = new PeriodType();
                SetField(transportcontract.NominationPeriod, xmlMapping);
                break;
            case "ContractualDelivery":
                if (transportcontract.ContractualDelivery == null)
                    transportcontract.ContractualDelivery = new DeliveryType();
                SetField(transportcontract.ContractualDelivery, xmlMapping);
                break;

        }
    }
    public void SetField(TransportationServiceType originaldespatchtransportationservice, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TransportServiceCode":
                if (originaldespatchtransportationservice.TransportServiceCode == null)
                    originaldespatchtransportationservice.TransportServiceCode = new TransportServiceCodeType();
                SetField(originaldespatchtransportationservice.TransportServiceCode, xmlMapping);
                break;
            case "TariffClassCode":
                if (originaldespatchtransportationservice.TariffClassCode == null)
                    originaldespatchtransportationservice.TariffClassCode = new TariffClassCodeType();
                SetField(originaldespatchtransportationservice.TariffClassCode, xmlMapping);
                break;
            case "Priority":
                if (originaldespatchtransportationservice.Priority == null)
                    originaldespatchtransportationservice.Priority = new PriorityType();
                SetField(originaldespatchtransportationservice.Priority, xmlMapping);
                break;
            case "FreightRateClassCode":
                if (originaldespatchtransportationservice.FreightRateClassCode == null)
                    originaldespatchtransportationservice.FreightRateClassCode = new FreightRateClassCodeType();
                SetField(originaldespatchtransportationservice.FreightRateClassCode, xmlMapping);
                break;
            case "TransportationServiceDescription":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportationServiceDescription && !collMappingTransportationServiceDescription.HasNextNode)
                {
                    if (originaldespatchtransportationservice.TransportationServiceDescription == null)
                        originaldespatchtransportationservice.TransportationServiceDescription = new TransportationServiceDescriptionType[collMappingTransportationServiceDescription.Quantity];

                    for (int i = 0; i < collMappingTransportationServiceDescription.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.TransportationServiceDescription[i] = new TransportationServiceDescriptionType();

                        foreach (var colMapp in collMappingTransportationServiceDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.TransportationServiceDescription == null)
                    {
                        originaldespatchtransportationservice.TransportationServiceDescription = new TransportationServiceDescriptionType[1];
                        originaldespatchtransportationservice.TransportationServiceDescription[0] = new TransportationServiceDescriptionType();
                    }
                    SetField(originaldespatchtransportationservice.TransportationServiceDescription[0], xmlMapping);
                }
                break;
            case "TransportationServiceDetailsURI":
                if (originaldespatchtransportationservice.TransportationServiceDetailsURI == null)
                    originaldespatchtransportationservice.TransportationServiceDetailsURI = new TransportationServiceDetailsURIType();
                SetField(originaldespatchtransportationservice.TransportationServiceDetailsURI, xmlMapping);
                break;
            case "NominationDate":
                if (originaldespatchtransportationservice.NominationDate == null)
                    originaldespatchtransportationservice.NominationDate = new NominationDateType();
                SetField(originaldespatchtransportationservice.NominationDate, xmlMapping);
                break;
            case "NominationTime":
                if (originaldespatchtransportationservice.NominationTime == null)
                    originaldespatchtransportationservice.NominationTime = new NominationTimeType();
                SetField(originaldespatchtransportationservice.NominationTime, xmlMapping);
                break;
            case "Name":
                if (originaldespatchtransportationservice.Name == null)
                    originaldespatchtransportationservice.Name = new NameType1();
                SetField(originaldespatchtransportationservice.Name, xmlMapping);
                break;
            case "SequenceNumeric":
                if (originaldespatchtransportationservice.SequenceNumeric == null)
                    originaldespatchtransportationservice.SequenceNumeric = new SequenceNumericType();
                SetField(originaldespatchtransportationservice.SequenceNumeric, xmlMapping);
                break;
            case "TransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment && !collMappingTransportEquipment.HasNextNode)
                {
                    if (originaldespatchtransportationservice.TransportEquipment == null)
                        originaldespatchtransportationservice.TransportEquipment = new TransportEquipmentType[collMappingTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingTransportEquipment.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.TransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.TransportEquipment == null)
                    {
                        originaldespatchtransportationservice.TransportEquipment = new TransportEquipmentType[1];
                        originaldespatchtransportationservice.TransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(originaldespatchtransportationservice.TransportEquipment[0], xmlMapping);
                }
                break;
            case "SupportedTransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingSupportedTransportEquipment && !collMappingSupportedTransportEquipment.HasNextNode)
                {
                    if (originaldespatchtransportationservice.SupportedTransportEquipment == null)
                        originaldespatchtransportationservice.SupportedTransportEquipment = new TransportEquipmentType[collMappingSupportedTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingSupportedTransportEquipment.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.SupportedTransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingSupportedTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.SupportedTransportEquipment == null)
                    {
                        originaldespatchtransportationservice.SupportedTransportEquipment = new TransportEquipmentType[1];
                        originaldespatchtransportationservice.SupportedTransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(originaldespatchtransportationservice.SupportedTransportEquipment[0], xmlMapping);
                }
                break;
            case "UnsupportedTransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingUnsupportedTransportEquipment && !collMappingUnsupportedTransportEquipment.HasNextNode)
                {
                    if (originaldespatchtransportationservice.UnsupportedTransportEquipment == null)
                        originaldespatchtransportationservice.UnsupportedTransportEquipment = new TransportEquipmentType[collMappingUnsupportedTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingUnsupportedTransportEquipment.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.UnsupportedTransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingUnsupportedTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.UnsupportedTransportEquipment == null)
                    {
                        originaldespatchtransportationservice.UnsupportedTransportEquipment = new TransportEquipmentType[1];
                        originaldespatchtransportationservice.UnsupportedTransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(originaldespatchtransportationservice.UnsupportedTransportEquipment[0], xmlMapping);
                }
                break;
            case "CommodityClassification":
                if (xmlMapping is IXmlCollectionMapping collMappingCommodityClassification && !collMappingCommodityClassification.HasNextNode)
                {
                    if (originaldespatchtransportationservice.CommodityClassification == null)
                        originaldespatchtransportationservice.CommodityClassification = new CommodityClassificationType[collMappingCommodityClassification.Quantity];

                    for (int i = 0; i < collMappingCommodityClassification.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.CommodityClassification[i] = new CommodityClassificationType();

                        foreach (var colMapp in collMappingCommodityClassification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.CommodityClassification == null)
                    {
                        originaldespatchtransportationservice.CommodityClassification = new CommodityClassificationType[1];
                        originaldespatchtransportationservice.CommodityClassification[0] = new CommodityClassificationType();
                    }
                    SetField(originaldespatchtransportationservice.CommodityClassification[0], xmlMapping);
                }
                break;
            case "SupportedCommodityClassification":
                if (xmlMapping is IXmlCollectionMapping collMappingSupportedCommodityClassification && !collMappingSupportedCommodityClassification.HasNextNode)
                {
                    if (originaldespatchtransportationservice.SupportedCommodityClassification == null)
                        originaldespatchtransportationservice.SupportedCommodityClassification = new CommodityClassificationType[collMappingSupportedCommodityClassification.Quantity];

                    for (int i = 0; i < collMappingSupportedCommodityClassification.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.SupportedCommodityClassification[i] = new CommodityClassificationType();

                        foreach (var colMapp in collMappingSupportedCommodityClassification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.SupportedCommodityClassification == null)
                    {
                        originaldespatchtransportationservice.SupportedCommodityClassification = new CommodityClassificationType[1];
                        originaldespatchtransportationservice.SupportedCommodityClassification[0] = new CommodityClassificationType();
                    }
                    SetField(originaldespatchtransportationservice.SupportedCommodityClassification[0], xmlMapping);
                }
                break;
            case "UnsupportedCommodityClassification":
                if (xmlMapping is IXmlCollectionMapping collMappingUnsupportedCommodityClassification && !collMappingUnsupportedCommodityClassification.HasNextNode)
                {
                    if (originaldespatchtransportationservice.UnsupportedCommodityClassification == null)
                        originaldespatchtransportationservice.UnsupportedCommodityClassification = new CommodityClassificationType[collMappingUnsupportedCommodityClassification.Quantity];

                    for (int i = 0; i < collMappingUnsupportedCommodityClassification.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.UnsupportedCommodityClassification[i] = new CommodityClassificationType();

                        foreach (var colMapp in collMappingUnsupportedCommodityClassification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.UnsupportedCommodityClassification == null)
                    {
                        originaldespatchtransportationservice.UnsupportedCommodityClassification = new CommodityClassificationType[1];
                        originaldespatchtransportationservice.UnsupportedCommodityClassification[0] = new CommodityClassificationType();
                    }
                    SetField(originaldespatchtransportationservice.UnsupportedCommodityClassification[0], xmlMapping);
                }
                break;
            case "TotalCapacityDimension":
                if (originaldespatchtransportationservice.TotalCapacityDimension == null)
                    originaldespatchtransportationservice.TotalCapacityDimension = new DimensionType();
                SetField(originaldespatchtransportationservice.TotalCapacityDimension, xmlMapping);
                break;
            case "ShipmentStage":
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentStage && !collMappingShipmentStage.HasNextNode)
                {
                    if (originaldespatchtransportationservice.ShipmentStage == null)
                        originaldespatchtransportationservice.ShipmentStage = new ShipmentStageType[collMappingShipmentStage.Quantity];

                    for (int i = 0; i < collMappingShipmentStage.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.ShipmentStage[i] = new ShipmentStageType();

                        foreach (var colMapp in collMappingShipmentStage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.ShipmentStage == null)
                    {
                        originaldespatchtransportationservice.ShipmentStage = new ShipmentStageType[1];
                        originaldespatchtransportationservice.ShipmentStage[0] = new ShipmentStageType();
                    }
                    SetField(originaldespatchtransportationservice.ShipmentStage[0], xmlMapping);
                }
                break;
            case "TransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent && !collMappingTransportEvent.HasNextNode)
                {
                    if (originaldespatchtransportationservice.TransportEvent == null)
                        originaldespatchtransportationservice.TransportEvent = new TransportEventType[collMappingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingTransportEvent.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.TransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.TransportEvent == null)
                    {
                        originaldespatchtransportationservice.TransportEvent = new TransportEventType[1];
                        originaldespatchtransportationservice.TransportEvent[0] = new TransportEventType();
                    }
                    SetField(originaldespatchtransportationservice.TransportEvent[0], xmlMapping);
                }
                break;
            case "ResponsibleTransportServiceProviderParty":
                if (originaldespatchtransportationservice.ResponsibleTransportServiceProviderParty == null)
                    originaldespatchtransportationservice.ResponsibleTransportServiceProviderParty = new PartyType();
                SetField(originaldespatchtransportationservice.ResponsibleTransportServiceProviderParty, xmlMapping);
                break;
            case "EnvironmentalEmission":
                if (xmlMapping is IXmlCollectionMapping collMappingEnvironmentalEmission && !collMappingEnvironmentalEmission.HasNextNode)
                {
                    if (originaldespatchtransportationservice.EnvironmentalEmission == null)
                        originaldespatchtransportationservice.EnvironmentalEmission = new EnvironmentalEmissionType[collMappingEnvironmentalEmission.Quantity];

                    for (int i = 0; i < collMappingEnvironmentalEmission.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.EnvironmentalEmission[i] = new EnvironmentalEmissionType();

                        foreach (var colMapp in collMappingEnvironmentalEmission.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.EnvironmentalEmission == null)
                    {
                        originaldespatchtransportationservice.EnvironmentalEmission = new EnvironmentalEmissionType[1];
                        originaldespatchtransportationservice.EnvironmentalEmission[0] = new EnvironmentalEmissionType();
                    }
                    SetField(originaldespatchtransportationservice.EnvironmentalEmission[0], xmlMapping);
                }
                break;
            case "EstimatedDurationPeriod":
                if (originaldespatchtransportationservice.EstimatedDurationPeriod == null)
                    originaldespatchtransportationservice.EstimatedDurationPeriod = new PeriodType();
                SetField(originaldespatchtransportationservice.EstimatedDurationPeriod, xmlMapping);
                break;
            case "ScheduledServiceFrequency":
                if (xmlMapping is IXmlCollectionMapping collMappingScheduledServiceFrequency && !collMappingScheduledServiceFrequency.HasNextNode)
                {
                    if (originaldespatchtransportationservice.ScheduledServiceFrequency == null)
                        originaldespatchtransportationservice.ScheduledServiceFrequency = new ServiceFrequencyType[collMappingScheduledServiceFrequency.Quantity];

                    for (int i = 0; i < collMappingScheduledServiceFrequency.Quantity; i++)
                    {
                        var row = originaldespatchtransportationservice.ScheduledServiceFrequency[i] = new ServiceFrequencyType();

                        foreach (var colMapp in collMappingScheduledServiceFrequency.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originaldespatchtransportationservice.ScheduledServiceFrequency == null)
                    {
                        originaldespatchtransportationservice.ScheduledServiceFrequency = new ServiceFrequencyType[1];
                        originaldespatchtransportationservice.ScheduledServiceFrequency[0] = new ServiceFrequencyType();
                    }
                    SetField(originaldespatchtransportationservice.ScheduledServiceFrequency[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(TransportEquipmentType transportequipment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportequipment.ID == null)
                    transportequipment.ID = new IDType();
                SetField(transportequipment.ID, xmlMapping);
                break;
            case "ReferencedConsignmentID":
                if (xmlMapping is IXmlCollectionMapping collMappingReferencedConsignmentID && !collMappingReferencedConsignmentID.HasNextNode)
                {
                    if (transportequipment.ReferencedConsignmentID == null)
                        transportequipment.ReferencedConsignmentID = new ReferencedConsignmentIDType[collMappingReferencedConsignmentID.Quantity];

                    for (int i = 0; i < collMappingReferencedConsignmentID.Quantity; i++)
                    {
                        var row = transportequipment.ReferencedConsignmentID[i] = new ReferencedConsignmentIDType();

                        foreach (var colMapp in collMappingReferencedConsignmentID.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.ReferencedConsignmentID == null)
                    {
                        transportequipment.ReferencedConsignmentID = new ReferencedConsignmentIDType[1];
                        transportequipment.ReferencedConsignmentID[0] = new ReferencedConsignmentIDType();
                    }
                    SetField(transportequipment.ReferencedConsignmentID[0], xmlMapping);
                }
                break;
            case "TransportEquipmentTypeCode":
                if (transportequipment.TransportEquipmentTypeCode == null)
                    transportequipment.TransportEquipmentTypeCode = new TransportEquipmentTypeCodeType();
                SetField(transportequipment.TransportEquipmentTypeCode, xmlMapping);
                break;
            case "ProviderTypeCode":
                if (transportequipment.ProviderTypeCode == null)
                    transportequipment.ProviderTypeCode = new ProviderTypeCodeType();
                SetField(transportequipment.ProviderTypeCode, xmlMapping);
                break;
            case "OwnerTypeCode":
                if (transportequipment.OwnerTypeCode == null)
                    transportequipment.OwnerTypeCode = new OwnerTypeCodeType();
                SetField(transportequipment.OwnerTypeCode, xmlMapping);
                break;
            case "SizeTypeCode":
                if (transportequipment.SizeTypeCode == null)
                    transportequipment.SizeTypeCode = new SizeTypeCodeType();
                SetField(transportequipment.SizeTypeCode, xmlMapping);
                break;
            case "DispositionCode":
                if (transportequipment.DispositionCode == null)
                    transportequipment.DispositionCode = new DispositionCodeType();
                SetField(transportequipment.DispositionCode, xmlMapping);
                break;
            case "FullnessIndicationCode":
                if (transportequipment.FullnessIndicationCode == null)
                    transportequipment.FullnessIndicationCode = new FullnessIndicationCodeType();
                SetField(transportequipment.FullnessIndicationCode, xmlMapping);
                break;
            case "RefrigerationOnIndicator":
                if (transportequipment.RefrigerationOnIndicator == null)
                    transportequipment.RefrigerationOnIndicator = new RefrigerationOnIndicatorType();
                SetField(transportequipment.RefrigerationOnIndicator, xmlMapping);
                break;
            case "Information":
                if (xmlMapping is IXmlCollectionMapping collMappingInformation && !collMappingInformation.HasNextNode)
                {
                    if (transportequipment.Information == null)
                        transportequipment.Information = new InformationType[collMappingInformation.Quantity];

                    for (int i = 0; i < collMappingInformation.Quantity; i++)
                    {
                        var row = transportequipment.Information[i] = new InformationType();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.Information == null)
                    {
                        transportequipment.Information = new InformationType[1];
                        transportequipment.Information[0] = new InformationType();
                    }
                    SetField(transportequipment.Information[0], xmlMapping);
                }
                break;
            case "ReturnabilityIndicator":
                if (transportequipment.ReturnabilityIndicator == null)
                    transportequipment.ReturnabilityIndicator = new ReturnabilityIndicatorType();
                SetField(transportequipment.ReturnabilityIndicator, xmlMapping);
                break;
            case "LegalStatusIndicator":
                if (transportequipment.LegalStatusIndicator == null)
                    transportequipment.LegalStatusIndicator = new LegalStatusIndicatorType();
                SetField(transportequipment.LegalStatusIndicator, xmlMapping);
                break;
            case "AirFlowPercent":
                if (transportequipment.AirFlowPercent == null)
                    transportequipment.AirFlowPercent = new AirFlowPercentType();
                SetField(transportequipment.AirFlowPercent, xmlMapping);
                break;
            case "HumidityPercent":
                if (transportequipment.HumidityPercent == null)
                    transportequipment.HumidityPercent = new HumidityPercentType();
                SetField(transportequipment.HumidityPercent, xmlMapping);
                break;
            case "AnimalFoodApprovedIndicator":
                if (transportequipment.AnimalFoodApprovedIndicator == null)
                    transportequipment.AnimalFoodApprovedIndicator = new AnimalFoodApprovedIndicatorType();
                SetField(transportequipment.AnimalFoodApprovedIndicator, xmlMapping);
                break;
            case "HumanFoodApprovedIndicator":
                if (transportequipment.HumanFoodApprovedIndicator == null)
                    transportequipment.HumanFoodApprovedIndicator = new HumanFoodApprovedIndicatorType();
                SetField(transportequipment.HumanFoodApprovedIndicator, xmlMapping);
                break;
            case "DangerousGoodsApprovedIndicator":
                if (transportequipment.DangerousGoodsApprovedIndicator == null)
                    transportequipment.DangerousGoodsApprovedIndicator = new DangerousGoodsApprovedIndicatorType();
                SetField(transportequipment.DangerousGoodsApprovedIndicator, xmlMapping);
                break;
            case "RefrigeratedIndicator":
                if (transportequipment.RefrigeratedIndicator == null)
                    transportequipment.RefrigeratedIndicator = new RefrigeratedIndicatorType();
                SetField(transportequipment.RefrigeratedIndicator, xmlMapping);
                break;
            case "Characteristics":
                if (transportequipment.Characteristics == null)
                    transportequipment.Characteristics = new CharacteristicsType();
                SetField(transportequipment.Characteristics, xmlMapping);
                break;
            case "DamageRemarks":
                if (xmlMapping is IXmlCollectionMapping collMappingDamageRemarks && !collMappingDamageRemarks.HasNextNode)
                {
                    if (transportequipment.DamageRemarks == null)
                        transportequipment.DamageRemarks = new DamageRemarksType[collMappingDamageRemarks.Quantity];

                    for (int i = 0; i < collMappingDamageRemarks.Quantity; i++)
                    {
                        var row = transportequipment.DamageRemarks[i] = new DamageRemarksType();

                        foreach (var colMapp in collMappingDamageRemarks.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.DamageRemarks == null)
                    {
                        transportequipment.DamageRemarks = new DamageRemarksType[1];
                        transportequipment.DamageRemarks[0] = new DamageRemarksType();
                    }
                    SetField(transportequipment.DamageRemarks[0], xmlMapping);
                }
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (transportequipment.Description == null)
                        transportequipment.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = transportequipment.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.Description == null)
                    {
                        transportequipment.Description = new DescriptionType[1];
                        transportequipment.Description[0] = new DescriptionType();
                    }
                    SetField(transportequipment.Description[0], xmlMapping);
                }
                break;
            case "SpecialTransportRequirements":
                if (xmlMapping is IXmlCollectionMapping collMappingSpecialTransportRequirements && !collMappingSpecialTransportRequirements.HasNextNode)
                {
                    if (transportequipment.SpecialTransportRequirements == null)
                        transportequipment.SpecialTransportRequirements = new SpecialTransportRequirementsType[collMappingSpecialTransportRequirements.Quantity];

                    for (int i = 0; i < collMappingSpecialTransportRequirements.Quantity; i++)
                    {
                        var row = transportequipment.SpecialTransportRequirements[i] = new SpecialTransportRequirementsType();

                        foreach (var colMapp in collMappingSpecialTransportRequirements.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.SpecialTransportRequirements == null)
                    {
                        transportequipment.SpecialTransportRequirements = new SpecialTransportRequirementsType[1];
                        transportequipment.SpecialTransportRequirements[0] = new SpecialTransportRequirementsType();
                    }
                    SetField(transportequipment.SpecialTransportRequirements[0], xmlMapping);
                }
                break;
            case "GrossWeightMeasure":
                if (transportequipment.GrossWeightMeasure == null)
                    transportequipment.GrossWeightMeasure = new GrossWeightMeasureType();
                SetField(transportequipment.GrossWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (transportequipment.GrossVolumeMeasure == null)
                    transportequipment.GrossVolumeMeasure = new GrossVolumeMeasureType();
                SetField(transportequipment.GrossVolumeMeasure, xmlMapping);
                break;
            case "TareWeightMeasure":
                if (transportequipment.TareWeightMeasure == null)
                    transportequipment.TareWeightMeasure = new TareWeightMeasureType();
                SetField(transportequipment.TareWeightMeasure, xmlMapping);
                break;
            case "TrackingDeviceCode":
                if (transportequipment.TrackingDeviceCode == null)
                    transportequipment.TrackingDeviceCode = new TrackingDeviceCodeType();
                SetField(transportequipment.TrackingDeviceCode, xmlMapping);
                break;
            case "PowerIndicator":
                if (transportequipment.PowerIndicator == null)
                    transportequipment.PowerIndicator = new PowerIndicatorType();
                SetField(transportequipment.PowerIndicator, xmlMapping);
                break;
            case "TraceID":
                if (transportequipment.TraceID == null)
                    transportequipment.TraceID = new TraceIDType();
                SetField(transportequipment.TraceID, xmlMapping);
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (transportequipment.MeasurementDimension == null)
                        transportequipment.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = transportequipment.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.MeasurementDimension == null)
                    {
                        transportequipment.MeasurementDimension = new DimensionType[1];
                        transportequipment.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(transportequipment.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "TransportEquipmentSeal":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipmentSeal && !collMappingTransportEquipmentSeal.HasNextNode)
                {
                    if (transportequipment.TransportEquipmentSeal == null)
                        transportequipment.TransportEquipmentSeal = new TransportEquipmentSealType[collMappingTransportEquipmentSeal.Quantity];

                    for (int i = 0; i < collMappingTransportEquipmentSeal.Quantity; i++)
                    {
                        var row = transportequipment.TransportEquipmentSeal[i] = new TransportEquipmentSealType();

                        foreach (var colMapp in collMappingTransportEquipmentSeal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.TransportEquipmentSeal == null)
                    {
                        transportequipment.TransportEquipmentSeal = new TransportEquipmentSealType[1];
                        transportequipment.TransportEquipmentSeal[0] = new TransportEquipmentSealType();
                    }
                    SetField(transportequipment.TransportEquipmentSeal[0], xmlMapping);
                }
                break;
            case "MinimumTemperature":
                if (transportequipment.MinimumTemperature == null)
                    transportequipment.MinimumTemperature = new TemperatureType();
                SetField(transportequipment.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (transportequipment.MaximumTemperature == null)
                    transportequipment.MaximumTemperature = new TemperatureType();
                SetField(transportequipment.MaximumTemperature, xmlMapping);
                break;
            case "ProviderParty":
                if (transportequipment.ProviderParty == null)
                    transportequipment.ProviderParty = new PartyType();
                SetField(transportequipment.ProviderParty, xmlMapping);
                break;
            case "LoadingProofParty":
                if (transportequipment.LoadingProofParty == null)
                    transportequipment.LoadingProofParty = new PartyType();
                SetField(transportequipment.LoadingProofParty, xmlMapping);
                break;
            case "SupplierParty":
                if (transportequipment.SupplierParty == null)
                    transportequipment.SupplierParty = new SupplierPartyType();
                SetField(transportequipment.SupplierParty, xmlMapping);
                break;
            case "OwnerParty":
                if (transportequipment.OwnerParty == null)
                    transportequipment.OwnerParty = new PartyType();
                SetField(transportequipment.OwnerParty, xmlMapping);
                break;
            case "OperatingParty":
                if (transportequipment.OperatingParty == null)
                    transportequipment.OperatingParty = new PartyType();
                SetField(transportequipment.OperatingParty, xmlMapping);
                break;
            case "LoadingLocation":
                if (transportequipment.LoadingLocation == null)
                    transportequipment.LoadingLocation = new LocationType1();
                SetField(transportequipment.LoadingLocation, xmlMapping);
                break;
            case "UnloadingLocation":
                if (transportequipment.UnloadingLocation == null)
                    transportequipment.UnloadingLocation = new LocationType1();
                SetField(transportequipment.UnloadingLocation, xmlMapping);
                break;
            case "StorageLocation":
                if (transportequipment.StorageLocation == null)
                    transportequipment.StorageLocation = new LocationType1();
                SetField(transportequipment.StorageLocation, xmlMapping);
                break;
            case "PositioningTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingPositioningTransportEvent && !collMappingPositioningTransportEvent.HasNextNode)
                {
                    if (transportequipment.PositioningTransportEvent == null)
                        transportequipment.PositioningTransportEvent = new TransportEventType[collMappingPositioningTransportEvent.Quantity];

                    for (int i = 0; i < collMappingPositioningTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.PositioningTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingPositioningTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.PositioningTransportEvent == null)
                    {
                        transportequipment.PositioningTransportEvent = new TransportEventType[1];
                        transportequipment.PositioningTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.PositioningTransportEvent[0], xmlMapping);
                }
                break;
            case "QuarantineTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingQuarantineTransportEvent && !collMappingQuarantineTransportEvent.HasNextNode)
                {
                    if (transportequipment.QuarantineTransportEvent == null)
                        transportequipment.QuarantineTransportEvent = new TransportEventType[collMappingQuarantineTransportEvent.Quantity];

                    for (int i = 0; i < collMappingQuarantineTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.QuarantineTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingQuarantineTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.QuarantineTransportEvent == null)
                    {
                        transportequipment.QuarantineTransportEvent = new TransportEventType[1];
                        transportequipment.QuarantineTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.QuarantineTransportEvent[0], xmlMapping);
                }
                break;
            case "DeliveryTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryTransportEvent && !collMappingDeliveryTransportEvent.HasNextNode)
                {
                    if (transportequipment.DeliveryTransportEvent == null)
                        transportequipment.DeliveryTransportEvent = new TransportEventType[collMappingDeliveryTransportEvent.Quantity];

                    for (int i = 0; i < collMappingDeliveryTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.DeliveryTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingDeliveryTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.DeliveryTransportEvent == null)
                    {
                        transportequipment.DeliveryTransportEvent = new TransportEventType[1];
                        transportequipment.DeliveryTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.DeliveryTransportEvent[0], xmlMapping);
                }
                break;
            case "PickupTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingPickupTransportEvent && !collMappingPickupTransportEvent.HasNextNode)
                {
                    if (transportequipment.PickupTransportEvent == null)
                        transportequipment.PickupTransportEvent = new TransportEventType[collMappingPickupTransportEvent.Quantity];

                    for (int i = 0; i < collMappingPickupTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.PickupTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingPickupTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.PickupTransportEvent == null)
                    {
                        transportequipment.PickupTransportEvent = new TransportEventType[1];
                        transportequipment.PickupTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.PickupTransportEvent[0], xmlMapping);
                }
                break;
            case "HandlingTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingTransportEvent && !collMappingHandlingTransportEvent.HasNextNode)
                {
                    if (transportequipment.HandlingTransportEvent == null)
                        transportequipment.HandlingTransportEvent = new TransportEventType[collMappingHandlingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingHandlingTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.HandlingTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingHandlingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.HandlingTransportEvent == null)
                    {
                        transportequipment.HandlingTransportEvent = new TransportEventType[1];
                        transportequipment.HandlingTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.HandlingTransportEvent[0], xmlMapping);
                }
                break;
            case "LoadingTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingLoadingTransportEvent && !collMappingLoadingTransportEvent.HasNextNode)
                {
                    if (transportequipment.LoadingTransportEvent == null)
                        transportequipment.LoadingTransportEvent = new TransportEventType[collMappingLoadingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingLoadingTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.LoadingTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingLoadingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.LoadingTransportEvent == null)
                    {
                        transportequipment.LoadingTransportEvent = new TransportEventType[1];
                        transportequipment.LoadingTransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.LoadingTransportEvent[0], xmlMapping);
                }
                break;
            case "TransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent && !collMappingTransportEvent.HasNextNode)
                {
                    if (transportequipment.TransportEvent == null)
                        transportequipment.TransportEvent = new TransportEventType[collMappingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingTransportEvent.Quantity; i++)
                    {
                        var row = transportequipment.TransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.TransportEvent == null)
                    {
                        transportequipment.TransportEvent = new TransportEventType[1];
                        transportequipment.TransportEvent[0] = new TransportEventType();
                    }
                    SetField(transportequipment.TransportEvent[0], xmlMapping);
                }
                break;
            case "ApplicableTransportMeans":
                if (transportequipment.ApplicableTransportMeans == null)
                    transportequipment.ApplicableTransportMeans = new TransportMeansType();
                SetField(transportequipment.ApplicableTransportMeans, xmlMapping);
                break;
            case "HaulageTradingTerms":
                if (xmlMapping is IXmlCollectionMapping collMappingHaulageTradingTerms && !collMappingHaulageTradingTerms.HasNextNode)
                {
                    if (transportequipment.HaulageTradingTerms == null)
                        transportequipment.HaulageTradingTerms = new TradingTermsType[collMappingHaulageTradingTerms.Quantity];

                    for (int i = 0; i < collMappingHaulageTradingTerms.Quantity; i++)
                    {
                        var row = transportequipment.HaulageTradingTerms[i] = new TradingTermsType();

                        foreach (var colMapp in collMappingHaulageTradingTerms.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.HaulageTradingTerms == null)
                    {
                        transportequipment.HaulageTradingTerms = new TradingTermsType[1];
                        transportequipment.HaulageTradingTerms[0] = new TradingTermsType();
                    }
                    SetField(transportequipment.HaulageTradingTerms[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit && !collMappingHazardousGoodsTransit.HasNextNode)
                {
                    if (transportequipment.HazardousGoodsTransit == null)
                        transportequipment.HazardousGoodsTransit = new HazardousGoodsTransitType[collMappingHazardousGoodsTransit.Quantity];

                    for (int i = 0; i < collMappingHazardousGoodsTransit.Quantity; i++)
                    {
                        var row = transportequipment.HazardousGoodsTransit[i] = new HazardousGoodsTransitType();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.HazardousGoodsTransit == null)
                    {
                        transportequipment.HazardousGoodsTransit = new HazardousGoodsTransitType[1];
                        transportequipment.HazardousGoodsTransit[0] = new HazardousGoodsTransitType();
                    }
                    SetField(transportequipment.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "PackagedTransportHandlingUnit":
                if (xmlMapping is IXmlCollectionMapping collMappingPackagedTransportHandlingUnit && !collMappingPackagedTransportHandlingUnit.HasNextNode)
                {
                    if (transportequipment.PackagedTransportHandlingUnit == null)
                        transportequipment.PackagedTransportHandlingUnit = new TransportHandlingUnitType[collMappingPackagedTransportHandlingUnit.Quantity];

                    for (int i = 0; i < collMappingPackagedTransportHandlingUnit.Quantity; i++)
                    {
                        var row = transportequipment.PackagedTransportHandlingUnit[i] = new TransportHandlingUnitType();

                        foreach (var colMapp in collMappingPackagedTransportHandlingUnit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.PackagedTransportHandlingUnit == null)
                    {
                        transportequipment.PackagedTransportHandlingUnit = new TransportHandlingUnitType[1];
                        transportequipment.PackagedTransportHandlingUnit[0] = new TransportHandlingUnitType();
                    }
                    SetField(transportequipment.PackagedTransportHandlingUnit[0], xmlMapping);
                }
                break;
            case "ServiceAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingServiceAllowanceCharge && !collMappingServiceAllowanceCharge.HasNextNode)
                {
                    if (transportequipment.ServiceAllowanceCharge == null)
                        transportequipment.ServiceAllowanceCharge = new AllowanceChargeType[collMappingServiceAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingServiceAllowanceCharge.Quantity; i++)
                    {
                        var row = transportequipment.ServiceAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingServiceAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.ServiceAllowanceCharge == null)
                    {
                        transportequipment.ServiceAllowanceCharge = new AllowanceChargeType[1];
                        transportequipment.ServiceAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(transportequipment.ServiceAllowanceCharge[0], xmlMapping);
                }
                break;
            case "FreightAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge && !collMappingFreightAllowanceCharge.HasNextNode)
                {
                    if (transportequipment.FreightAllowanceCharge == null)
                        transportequipment.FreightAllowanceCharge = new AllowanceChargeType[collMappingFreightAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingFreightAllowanceCharge.Quantity; i++)
                    {
                        var row = transportequipment.FreightAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.FreightAllowanceCharge == null)
                    {
                        transportequipment.FreightAllowanceCharge = new AllowanceChargeType[1];
                        transportequipment.FreightAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(transportequipment.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "AttachedTransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingAttachedTransportEquipment && !collMappingAttachedTransportEquipment.HasNextNode)
                {
                    if (transportequipment.AttachedTransportEquipment == null)
                        transportequipment.AttachedTransportEquipment = new TransportEquipmentType[collMappingAttachedTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingAttachedTransportEquipment.Quantity; i++)
                    {
                        var row = transportequipment.AttachedTransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingAttachedTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.AttachedTransportEquipment == null)
                    {
                        transportequipment.AttachedTransportEquipment = new TransportEquipmentType[1];
                        transportequipment.AttachedTransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(transportequipment.AttachedTransportEquipment[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (transportequipment.Delivery == null)
                    transportequipment.Delivery = new DeliveryType();
                SetField(transportequipment.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (transportequipment.Pickup == null)
                    transportequipment.Pickup = new PickupType();
                SetField(transportequipment.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (transportequipment.Despatch == null)
                    transportequipment.Despatch = new DespatchType();
                SetField(transportequipment.Despatch, xmlMapping);
                break;
            case "ShipmentDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentDocumentReference && !collMappingShipmentDocumentReference.HasNextNode)
                {
                    if (transportequipment.ShipmentDocumentReference == null)
                        transportequipment.ShipmentDocumentReference = new DocumentReferenceType[collMappingShipmentDocumentReference.Quantity];

                    for (int i = 0; i < collMappingShipmentDocumentReference.Quantity; i++)
                    {
                        var row = transportequipment.ShipmentDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingShipmentDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.ShipmentDocumentReference == null)
                    {
                        transportequipment.ShipmentDocumentReference = new DocumentReferenceType[1];
                        transportequipment.ShipmentDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(transportequipment.ShipmentDocumentReference[0], xmlMapping);
                }
                break;
            case "ContainedInTransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingContainedInTransportEquipment && !collMappingContainedInTransportEquipment.HasNextNode)
                {
                    if (transportequipment.ContainedInTransportEquipment == null)
                        transportequipment.ContainedInTransportEquipment = new TransportEquipmentType[collMappingContainedInTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingContainedInTransportEquipment.Quantity; i++)
                    {
                        var row = transportequipment.ContainedInTransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingContainedInTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.ContainedInTransportEquipment == null)
                    {
                        transportequipment.ContainedInTransportEquipment = new TransportEquipmentType[1];
                        transportequipment.ContainedInTransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(transportequipment.ContainedInTransportEquipment[0], xmlMapping);
                }
                break;
            case "Package":
                if (xmlMapping is IXmlCollectionMapping collMappingPackage && !collMappingPackage.HasNextNode)
                {
                    if (transportequipment.Package == null)
                        transportequipment.Package = new PackageType[collMappingPackage.Quantity];

                    for (int i = 0; i < collMappingPackage.Quantity; i++)
                    {
                        var row = transportequipment.Package[i] = new PackageType();

                        foreach (var colMapp in collMappingPackage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.Package == null)
                    {
                        transportequipment.Package = new PackageType[1];
                        transportequipment.Package[0] = new PackageType();
                    }
                    SetField(transportequipment.Package[0], xmlMapping);
                }
                break;
            case "GoodsItem":
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem && !collMappingGoodsItem.HasNextNode)
                {
                    if (transportequipment.GoodsItem == null)
                        transportequipment.GoodsItem = new GoodsItemType[collMappingGoodsItem.Quantity];

                    for (int i = 0; i < collMappingGoodsItem.Quantity; i++)
                    {
                        var row = transportequipment.GoodsItem[i] = new GoodsItemType();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transportequipment.GoodsItem == null)
                    {
                        transportequipment.GoodsItem = new GoodsItemType[1];
                        transportequipment.GoodsItem[0] = new GoodsItemType();
                    }
                    SetField(transportequipment.GoodsItem[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(DimensionType measurementdimension, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (measurementdimension.AttributeID == null)
                    measurementdimension.AttributeID = new AttributeIDType();
                SetField(measurementdimension.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (measurementdimension.Measure == null)
                    measurementdimension.Measure = new MeasureType2();
                SetField(measurementdimension.Measure, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (measurementdimension.Description == null)
                        measurementdimension.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = measurementdimension.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (measurementdimension.Description == null)
                    {
                        measurementdimension.Description = new DescriptionType[1];
                        measurementdimension.Description[0] = new DescriptionType();
                    }
                    SetField(measurementdimension.Description[0], xmlMapping);
                }
                break;
            case "MinimumMeasure":
                if (measurementdimension.MinimumMeasure == null)
                    measurementdimension.MinimumMeasure = new MinimumMeasureType();
                SetField(measurementdimension.MinimumMeasure, xmlMapping);
                break;
            case "MaximumMeasure":
                if (measurementdimension.MaximumMeasure == null)
                    measurementdimension.MaximumMeasure = new MaximumMeasureType();
                SetField(measurementdimension.MaximumMeasure, xmlMapping);
                break;

        }
    }
    public void SetField(TransportEquipmentSealType transportequipmentseal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transportequipmentseal.ID == null)
                    transportequipmentseal.ID = new IDType();
                SetField(transportequipmentseal.ID, xmlMapping);
                break;
            case "SealIssuerTypeCode":
                if (transportequipmentseal.SealIssuerTypeCode == null)
                    transportequipmentseal.SealIssuerTypeCode = new SealIssuerTypeCodeType();
                SetField(transportequipmentseal.SealIssuerTypeCode, xmlMapping);
                break;
            case "Condition":
                if (transportequipmentseal.Condition == null)
                    transportequipmentseal.Condition = new ConditionType();
                SetField(transportequipmentseal.Condition, xmlMapping);
                break;
            case "SealStatusCode":
                if (transportequipmentseal.SealStatusCode == null)
                    transportequipmentseal.SealStatusCode = new SealStatusCodeType();
                SetField(transportequipmentseal.SealStatusCode, xmlMapping);
                break;
            case "SealingPartyType":
                if (transportequipmentseal.SealingPartyType == null)
                    transportequipmentseal.SealingPartyType = new SealingPartyTypeType();
                SetField(transportequipmentseal.SealingPartyType, xmlMapping);
                break;

        }
    }
    public void SetField(TemperatureType minimumtemperature, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (minimumtemperature.AttributeID == null)
                    minimumtemperature.AttributeID = new AttributeIDType();
                SetField(minimumtemperature.AttributeID, xmlMapping);
                break;
            case "Measure":
                if (minimumtemperature.Measure == null)
                    minimumtemperature.Measure = new MeasureType2();
                SetField(minimumtemperature.Measure, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (minimumtemperature.Description == null)
                        minimumtemperature.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = minimumtemperature.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (minimumtemperature.Description == null)
                    {
                        minimumtemperature.Description = new DescriptionType[1];
                        minimumtemperature.Description[0] = new DescriptionType();
                    }
                    SetField(minimumtemperature.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(TransportMeansType applicabletransportmeans, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "JourneyID":
                if (applicabletransportmeans.JourneyID == null)
                    applicabletransportmeans.JourneyID = new JourneyIDType();
                SetField(applicabletransportmeans.JourneyID, xmlMapping);
                break;
            case "RegistrationNationalityID":
                if (applicabletransportmeans.RegistrationNationalityID == null)
                    applicabletransportmeans.RegistrationNationalityID = new RegistrationNationalityIDType();
                SetField(applicabletransportmeans.RegistrationNationalityID, xmlMapping);
                break;
            case "RegistrationNationality":
                if (xmlMapping is IXmlCollectionMapping collMappingRegistrationNationality && !collMappingRegistrationNationality.HasNextNode)
                {
                    if (applicabletransportmeans.RegistrationNationality == null)
                        applicabletransportmeans.RegistrationNationality = new RegistrationNationalityType[collMappingRegistrationNationality.Quantity];

                    for (int i = 0; i < collMappingRegistrationNationality.Quantity; i++)
                    {
                        var row = applicabletransportmeans.RegistrationNationality[i] = new RegistrationNationalityType();

                        foreach (var colMapp in collMappingRegistrationNationality.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (applicabletransportmeans.RegistrationNationality == null)
                    {
                        applicabletransportmeans.RegistrationNationality = new RegistrationNationalityType[1];
                        applicabletransportmeans.RegistrationNationality[0] = new RegistrationNationalityType();
                    }
                    SetField(applicabletransportmeans.RegistrationNationality[0], xmlMapping);
                }
                break;
            case "DirectionCode":
                if (applicabletransportmeans.DirectionCode == null)
                    applicabletransportmeans.DirectionCode = new DirectionCodeType();
                SetField(applicabletransportmeans.DirectionCode, xmlMapping);
                break;
            case "TransportMeansTypeCode":
                if (applicabletransportmeans.TransportMeansTypeCode == null)
                    applicabletransportmeans.TransportMeansTypeCode = new TransportMeansTypeCodeType();
                SetField(applicabletransportmeans.TransportMeansTypeCode, xmlMapping);
                break;
            case "TradeServiceCode":
                if (applicabletransportmeans.TradeServiceCode == null)
                    applicabletransportmeans.TradeServiceCode = new TradeServiceCodeType();
                SetField(applicabletransportmeans.TradeServiceCode, xmlMapping);
                break;
            case "Stowage":
                if (applicabletransportmeans.Stowage == null)
                    applicabletransportmeans.Stowage = new StowageType();
                SetField(applicabletransportmeans.Stowage, xmlMapping);
                break;
            case "AirTransport":
                if (applicabletransportmeans.AirTransport == null)
                    applicabletransportmeans.AirTransport = new AirTransportType();
                SetField(applicabletransportmeans.AirTransport, xmlMapping);
                break;
            case "RoadTransport":
                if (applicabletransportmeans.RoadTransport == null)
                    applicabletransportmeans.RoadTransport = new RoadTransportType();
                SetField(applicabletransportmeans.RoadTransport, xmlMapping);
                break;
            case "RailTransport":
                if (applicabletransportmeans.RailTransport == null)
                    applicabletransportmeans.RailTransport = new RailTransportType();
                SetField(applicabletransportmeans.RailTransport, xmlMapping);
                break;
            case "MaritimeTransport":
                if (applicabletransportmeans.MaritimeTransport == null)
                    applicabletransportmeans.MaritimeTransport = new MaritimeTransportType();
                SetField(applicabletransportmeans.MaritimeTransport, xmlMapping);
                break;
            case "OwnerParty":
                if (applicabletransportmeans.OwnerParty == null)
                    applicabletransportmeans.OwnerParty = new PartyType();
                SetField(applicabletransportmeans.OwnerParty, xmlMapping);
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (applicabletransportmeans.MeasurementDimension == null)
                        applicabletransportmeans.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = applicabletransportmeans.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (applicabletransportmeans.MeasurementDimension == null)
                    {
                        applicabletransportmeans.MeasurementDimension = new DimensionType[1];
                        applicabletransportmeans.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(applicabletransportmeans.MeasurementDimension[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(StowageType stowage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LocationID":
                if (stowage.LocationID == null)
                    stowage.LocationID = new LocationIDType();
                SetField(stowage.LocationID, xmlMapping);
                break;
            case "Location":
                if (xmlMapping is IXmlCollectionMapping collMappingLocation && !collMappingLocation.HasNextNode)
                {
                    if (stowage.Location == null)
                        stowage.Location = new LocationType[collMappingLocation.Quantity];

                    for (int i = 0; i < collMappingLocation.Quantity; i++)
                    {
                        var row = stowage.Location[i] = new LocationType();

                        foreach (var colMapp in collMappingLocation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (stowage.Location == null)
                    {
                        stowage.Location = new LocationType[1];
                        stowage.Location[0] = new LocationType();
                    }
                    SetField(stowage.Location[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (stowage.MeasurementDimension == null)
                        stowage.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = stowage.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (stowage.MeasurementDimension == null)
                    {
                        stowage.MeasurementDimension = new DimensionType[1];
                        stowage.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(stowage.MeasurementDimension[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(AirTransportType airtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AircraftID":
                if (airtransport.AircraftID == null)
                    airtransport.AircraftID = new AircraftIDType();
                SetField(airtransport.AircraftID, xmlMapping);
                break;

        }
    }
    public void SetField(RoadTransportType roadtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LicensePlateID":
                if (roadtransport.LicensePlateID == null)
                    roadtransport.LicensePlateID = new LicensePlateIDType();
                SetField(roadtransport.LicensePlateID, xmlMapping);
                break;

        }
    }
    public void SetField(RailTransportType railtransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TrainID":
                if (railtransport.TrainID == null)
                    railtransport.TrainID = new TrainIDType();
                SetField(railtransport.TrainID, xmlMapping);
                break;
            case "RailCarID":
                if (railtransport.RailCarID == null)
                    railtransport.RailCarID = new RailCarIDType();
                SetField(railtransport.RailCarID, xmlMapping);
                break;

        }
    }
    public void SetField(MaritimeTransportType maritimetransport, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "VesselID":
                if (maritimetransport.VesselID == null)
                    maritimetransport.VesselID = new VesselIDType();
                SetField(maritimetransport.VesselID, xmlMapping);
                break;
            case "VesselName":
                if (maritimetransport.VesselName == null)
                    maritimetransport.VesselName = new VesselNameType();
                SetField(maritimetransport.VesselName, xmlMapping);
                break;
            case "RadioCallSignID":
                if (maritimetransport.RadioCallSignID == null)
                    maritimetransport.RadioCallSignID = new RadioCallSignIDType();
                SetField(maritimetransport.RadioCallSignID, xmlMapping);
                break;
            case "ShipsRequirements":
                if (xmlMapping is IXmlCollectionMapping collMappingShipsRequirements && !collMappingShipsRequirements.HasNextNode)
                {
                    if (maritimetransport.ShipsRequirements == null)
                        maritimetransport.ShipsRequirements = new ShipsRequirementsType[collMappingShipsRequirements.Quantity];

                    for (int i = 0; i < collMappingShipsRequirements.Quantity; i++)
                    {
                        var row = maritimetransport.ShipsRequirements[i] = new ShipsRequirementsType();

                        foreach (var colMapp in collMappingShipsRequirements.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (maritimetransport.ShipsRequirements == null)
                    {
                        maritimetransport.ShipsRequirements = new ShipsRequirementsType[1];
                        maritimetransport.ShipsRequirements[0] = new ShipsRequirementsType();
                    }
                    SetField(maritimetransport.ShipsRequirements[0], xmlMapping);
                }
                break;
            case "GrossTonnageMeasure":
                if (maritimetransport.GrossTonnageMeasure == null)
                    maritimetransport.GrossTonnageMeasure = new GrossTonnageMeasureType();
                SetField(maritimetransport.GrossTonnageMeasure, xmlMapping);
                break;
            case "NetTonnageMeasure":
                if (maritimetransport.NetTonnageMeasure == null)
                    maritimetransport.NetTonnageMeasure = new NetTonnageMeasureType();
                SetField(maritimetransport.NetTonnageMeasure, xmlMapping);
                break;
            case "RegistryCertificateDocumentReference":
                if (maritimetransport.RegistryCertificateDocumentReference == null)
                    maritimetransport.RegistryCertificateDocumentReference = new DocumentReferenceType();
                SetField(maritimetransport.RegistryCertificateDocumentReference, xmlMapping);
                break;
            case "RegistryPortLocation":
                if (maritimetransport.RegistryPortLocation == null)
                    maritimetransport.RegistryPortLocation = new LocationType1();
                SetField(maritimetransport.RegistryPortLocation, xmlMapping);
                break;

        }
    }
    public void SetField(TradingTermsType haulagetradingterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Information":
                if (xmlMapping is IXmlCollectionMapping collMappingInformation && !collMappingInformation.HasNextNode)
                {
                    if (haulagetradingterms.Information == null)
                        haulagetradingterms.Information = new InformationType[collMappingInformation.Quantity];

                    for (int i = 0; i < collMappingInformation.Quantity; i++)
                    {
                        var row = haulagetradingterms.Information[i] = new InformationType();

                        foreach (var colMapp in collMappingInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (haulagetradingterms.Information == null)
                    {
                        haulagetradingterms.Information = new InformationType[1];
                        haulagetradingterms.Information[0] = new InformationType();
                    }
                    SetField(haulagetradingterms.Information[0], xmlMapping);
                }
                break;
            case "Reference":
                if (haulagetradingterms.Reference == null)
                    haulagetradingterms.Reference = new ReferenceType();
                SetField(haulagetradingterms.Reference, xmlMapping);
                break;
            case "ApplicableAddress":
                if (haulagetradingterms.ApplicableAddress == null)
                    haulagetradingterms.ApplicableAddress = new AddressType();
                SetField(haulagetradingterms.ApplicableAddress, xmlMapping);
                break;

        }
    }
    public void SetField(HazardousGoodsTransitType hazardousgoodstransit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "TransportEmergencyCardCode":
                if (hazardousgoodstransit.TransportEmergencyCardCode == null)
                    hazardousgoodstransit.TransportEmergencyCardCode = new TransportEmergencyCardCodeType();
                SetField(hazardousgoodstransit.TransportEmergencyCardCode, xmlMapping);
                break;
            case "PackingCriteriaCode":
                if (hazardousgoodstransit.PackingCriteriaCode == null)
                    hazardousgoodstransit.PackingCriteriaCode = new PackingCriteriaCodeType();
                SetField(hazardousgoodstransit.PackingCriteriaCode, xmlMapping);
                break;
            case "HazardousRegulationCode":
                if (hazardousgoodstransit.HazardousRegulationCode == null)
                    hazardousgoodstransit.HazardousRegulationCode = new HazardousRegulationCodeType();
                SetField(hazardousgoodstransit.HazardousRegulationCode, xmlMapping);
                break;
            case "InhalationToxicityZoneCode":
                if (hazardousgoodstransit.InhalationToxicityZoneCode == null)
                    hazardousgoodstransit.InhalationToxicityZoneCode = new InhalationToxicityZoneCodeType();
                SetField(hazardousgoodstransit.InhalationToxicityZoneCode, xmlMapping);
                break;
            case "TransportAuthorizationCode":
                if (hazardousgoodstransit.TransportAuthorizationCode == null)
                    hazardousgoodstransit.TransportAuthorizationCode = new TransportAuthorizationCodeType();
                SetField(hazardousgoodstransit.TransportAuthorizationCode, xmlMapping);
                break;
            case "MaximumTemperature":
                if (hazardousgoodstransit.MaximumTemperature == null)
                    hazardousgoodstransit.MaximumTemperature = new TemperatureType();
                SetField(hazardousgoodstransit.MaximumTemperature, xmlMapping);
                break;
            case "MinimumTemperature":
                if (hazardousgoodstransit.MinimumTemperature == null)
                    hazardousgoodstransit.MinimumTemperature = new TemperatureType();
                SetField(hazardousgoodstransit.MinimumTemperature, xmlMapping);
                break;

        }
    }
    public void SetField(TransportHandlingUnitType packagedtransporthandlingunit, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (packagedtransporthandlingunit.ID == null)
                    packagedtransporthandlingunit.ID = new IDType();
                SetField(packagedtransporthandlingunit.ID, xmlMapping);
                break;
            case "TransportHandlingUnitTypeCode":
                if (packagedtransporthandlingunit.TransportHandlingUnitTypeCode == null)
                    packagedtransporthandlingunit.TransportHandlingUnitTypeCode = new TransportHandlingUnitTypeCodeType();
                SetField(packagedtransporthandlingunit.TransportHandlingUnitTypeCode, xmlMapping);
                break;
            case "HandlingCode":
                if (packagedtransporthandlingunit.HandlingCode == null)
                    packagedtransporthandlingunit.HandlingCode = new HandlingCodeType();
                SetField(packagedtransporthandlingunit.HandlingCode, xmlMapping);
                break;
            case "HandlingInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingInstructions && !collMappingHandlingInstructions.HasNextNode)
                {
                    if (packagedtransporthandlingunit.HandlingInstructions == null)
                        packagedtransporthandlingunit.HandlingInstructions = new HandlingInstructionsType[collMappingHandlingInstructions.Quantity];

                    for (int i = 0; i < collMappingHandlingInstructions.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.HandlingInstructions[i] = new HandlingInstructionsType();

                        foreach (var colMapp in collMappingHandlingInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.HandlingInstructions == null)
                    {
                        packagedtransporthandlingunit.HandlingInstructions = new HandlingInstructionsType[1];
                        packagedtransporthandlingunit.HandlingInstructions[0] = new HandlingInstructionsType();
                    }
                    SetField(packagedtransporthandlingunit.HandlingInstructions[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (packagedtransporthandlingunit.HazardousRiskIndicator == null)
                    packagedtransporthandlingunit.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(packagedtransporthandlingunit.HazardousRiskIndicator, xmlMapping);
                break;
            case "TotalGoodsItemQuantity":
                if (packagedtransporthandlingunit.TotalGoodsItemQuantity == null)
                    packagedtransporthandlingunit.TotalGoodsItemQuantity = new TotalGoodsItemQuantityType();
                SetField(packagedtransporthandlingunit.TotalGoodsItemQuantity, xmlMapping);
                break;
            case "TotalPackageQuantity":
                if (packagedtransporthandlingunit.TotalPackageQuantity == null)
                    packagedtransporthandlingunit.TotalPackageQuantity = new TotalPackageQuantityType();
                SetField(packagedtransporthandlingunit.TotalPackageQuantity, xmlMapping);
                break;
            case "DamageRemarks":
                if (xmlMapping is IXmlCollectionMapping collMappingDamageRemarks && !collMappingDamageRemarks.HasNextNode)
                {
                    if (packagedtransporthandlingunit.DamageRemarks == null)
                        packagedtransporthandlingunit.DamageRemarks = new DamageRemarksType[collMappingDamageRemarks.Quantity];

                    for (int i = 0; i < collMappingDamageRemarks.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.DamageRemarks[i] = new DamageRemarksType();

                        foreach (var colMapp in collMappingDamageRemarks.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.DamageRemarks == null)
                    {
                        packagedtransporthandlingunit.DamageRemarks = new DamageRemarksType[1];
                        packagedtransporthandlingunit.DamageRemarks[0] = new DamageRemarksType();
                    }
                    SetField(packagedtransporthandlingunit.DamageRemarks[0], xmlMapping);
                }
                break;
            case "ShippingMarks":
                if (xmlMapping is IXmlCollectionMapping collMappingShippingMarks && !collMappingShippingMarks.HasNextNode)
                {
                    if (packagedtransporthandlingunit.ShippingMarks == null)
                        packagedtransporthandlingunit.ShippingMarks = new ShippingMarksType[collMappingShippingMarks.Quantity];

                    for (int i = 0; i < collMappingShippingMarks.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.ShippingMarks[i] = new ShippingMarksType();

                        foreach (var colMapp in collMappingShippingMarks.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.ShippingMarks == null)
                    {
                        packagedtransporthandlingunit.ShippingMarks = new ShippingMarksType[1];
                        packagedtransporthandlingunit.ShippingMarks[0] = new ShippingMarksType();
                    }
                    SetField(packagedtransporthandlingunit.ShippingMarks[0], xmlMapping);
                }
                break;
            case "TraceID":
                if (packagedtransporthandlingunit.TraceID == null)
                    packagedtransporthandlingunit.TraceID = new TraceIDType();
                SetField(packagedtransporthandlingunit.TraceID, xmlMapping);
                break;
            case "HandlingUnitDespatchLine":
                if (xmlMapping is IXmlCollectionMapping collMappingHandlingUnitDespatchLine && !collMappingHandlingUnitDespatchLine.HasNextNode)
                {
                    if (packagedtransporthandlingunit.HandlingUnitDespatchLine == null)
                        packagedtransporthandlingunit.HandlingUnitDespatchLine = new DespatchLineType[collMappingHandlingUnitDespatchLine.Quantity];

                    for (int i = 0; i < collMappingHandlingUnitDespatchLine.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.HandlingUnitDespatchLine[i] = new DespatchLineType();

                        foreach (var colMapp in collMappingHandlingUnitDespatchLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.HandlingUnitDespatchLine == null)
                    {
                        packagedtransporthandlingunit.HandlingUnitDespatchLine = new DespatchLineType[1];
                        packagedtransporthandlingunit.HandlingUnitDespatchLine[0] = new DespatchLineType();
                    }
                    SetField(packagedtransporthandlingunit.HandlingUnitDespatchLine[0], xmlMapping);
                }
                break;
            case "ActualPackage":
                if (xmlMapping is IXmlCollectionMapping collMappingActualPackage && !collMappingActualPackage.HasNextNode)
                {
                    if (packagedtransporthandlingunit.ActualPackage == null)
                        packagedtransporthandlingunit.ActualPackage = new PackageType[collMappingActualPackage.Quantity];

                    for (int i = 0; i < collMappingActualPackage.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.ActualPackage[i] = new PackageType();

                        foreach (var colMapp in collMappingActualPackage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.ActualPackage == null)
                    {
                        packagedtransporthandlingunit.ActualPackage = new PackageType[1];
                        packagedtransporthandlingunit.ActualPackage[0] = new PackageType();
                    }
                    SetField(packagedtransporthandlingunit.ActualPackage[0], xmlMapping);
                }
                break;
            case "ReceivedHandlingUnitReceiptLine":
                if (xmlMapping is IXmlCollectionMapping collMappingReceivedHandlingUnitReceiptLine && !collMappingReceivedHandlingUnitReceiptLine.HasNextNode)
                {
                    if (packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine == null)
                        packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine = new ReceiptLineType[collMappingReceivedHandlingUnitReceiptLine.Quantity];

                    for (int i = 0; i < collMappingReceivedHandlingUnitReceiptLine.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine[i] = new ReceiptLineType();

                        foreach (var colMapp in collMappingReceivedHandlingUnitReceiptLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine == null)
                    {
                        packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine = new ReceiptLineType[1];
                        packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine[0] = new ReceiptLineType();
                    }
                    SetField(packagedtransporthandlingunit.ReceivedHandlingUnitReceiptLine[0], xmlMapping);
                }
                break;
            case "TransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment && !collMappingTransportEquipment.HasNextNode)
                {
                    if (packagedtransporthandlingunit.TransportEquipment == null)
                        packagedtransporthandlingunit.TransportEquipment = new TransportEquipmentType[collMappingTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingTransportEquipment.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.TransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.TransportEquipment == null)
                    {
                        packagedtransporthandlingunit.TransportEquipment = new TransportEquipmentType[1];
                        packagedtransporthandlingunit.TransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(packagedtransporthandlingunit.TransportEquipment[0], xmlMapping);
                }
                break;
            case "TransportMeans":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportMeans && !collMappingTransportMeans.HasNextNode)
                {
                    if (packagedtransporthandlingunit.TransportMeans == null)
                        packagedtransporthandlingunit.TransportMeans = new TransportMeansType[collMappingTransportMeans.Quantity];

                    for (int i = 0; i < collMappingTransportMeans.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.TransportMeans[i] = new TransportMeansType();

                        foreach (var colMapp in collMappingTransportMeans.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.TransportMeans == null)
                    {
                        packagedtransporthandlingunit.TransportMeans = new TransportMeansType[1];
                        packagedtransporthandlingunit.TransportMeans[0] = new TransportMeansType();
                    }
                    SetField(packagedtransporthandlingunit.TransportMeans[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit && !collMappingHazardousGoodsTransit.HasNextNode)
                {
                    if (packagedtransporthandlingunit.HazardousGoodsTransit == null)
                        packagedtransporthandlingunit.HazardousGoodsTransit = new HazardousGoodsTransitType[collMappingHazardousGoodsTransit.Quantity];

                    for (int i = 0; i < collMappingHazardousGoodsTransit.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.HazardousGoodsTransit[i] = new HazardousGoodsTransitType();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.HazardousGoodsTransit == null)
                    {
                        packagedtransporthandlingunit.HazardousGoodsTransit = new HazardousGoodsTransitType[1];
                        packagedtransporthandlingunit.HazardousGoodsTransit[0] = new HazardousGoodsTransitType();
                    }
                    SetField(packagedtransporthandlingunit.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (packagedtransporthandlingunit.MeasurementDimension == null)
                        packagedtransporthandlingunit.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.MeasurementDimension == null)
                    {
                        packagedtransporthandlingunit.MeasurementDimension = new DimensionType[1];
                        packagedtransporthandlingunit.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(packagedtransporthandlingunit.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "MinimumTemperature":
                if (packagedtransporthandlingunit.MinimumTemperature == null)
                    packagedtransporthandlingunit.MinimumTemperature = new TemperatureType();
                SetField(packagedtransporthandlingunit.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (packagedtransporthandlingunit.MaximumTemperature == null)
                    packagedtransporthandlingunit.MaximumTemperature = new TemperatureType();
                SetField(packagedtransporthandlingunit.MaximumTemperature, xmlMapping);
                break;
            case "GoodsItem":
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem && !collMappingGoodsItem.HasNextNode)
                {
                    if (packagedtransporthandlingunit.GoodsItem == null)
                        packagedtransporthandlingunit.GoodsItem = new GoodsItemType[collMappingGoodsItem.Quantity];

                    for (int i = 0; i < collMappingGoodsItem.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.GoodsItem[i] = new GoodsItemType();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.GoodsItem == null)
                    {
                        packagedtransporthandlingunit.GoodsItem = new GoodsItemType[1];
                        packagedtransporthandlingunit.GoodsItem[0] = new GoodsItemType();
                    }
                    SetField(packagedtransporthandlingunit.GoodsItem[0], xmlMapping);
                }
                break;
            case "FloorSpaceMeasurementDimension":
                if (packagedtransporthandlingunit.FloorSpaceMeasurementDimension == null)
                    packagedtransporthandlingunit.FloorSpaceMeasurementDimension = new DimensionType();
                SetField(packagedtransporthandlingunit.FloorSpaceMeasurementDimension, xmlMapping);
                break;
            case "PalletSpaceMeasurementDimension":
                if (packagedtransporthandlingunit.PalletSpaceMeasurementDimension == null)
                    packagedtransporthandlingunit.PalletSpaceMeasurementDimension = new DimensionType();
                SetField(packagedtransporthandlingunit.PalletSpaceMeasurementDimension, xmlMapping);
                break;
            case "ShipmentDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingShipmentDocumentReference && !collMappingShipmentDocumentReference.HasNextNode)
                {
                    if (packagedtransporthandlingunit.ShipmentDocumentReference == null)
                        packagedtransporthandlingunit.ShipmentDocumentReference = new DocumentReferenceType[collMappingShipmentDocumentReference.Quantity];

                    for (int i = 0; i < collMappingShipmentDocumentReference.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.ShipmentDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingShipmentDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.ShipmentDocumentReference == null)
                    {
                        packagedtransporthandlingunit.ShipmentDocumentReference = new DocumentReferenceType[1];
                        packagedtransporthandlingunit.ShipmentDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(packagedtransporthandlingunit.ShipmentDocumentReference[0], xmlMapping);
                }
                break;
            case "Status":
                if (xmlMapping is IXmlCollectionMapping collMappingStatus && !collMappingStatus.HasNextNode)
                {
                    if (packagedtransporthandlingunit.Status == null)
                        packagedtransporthandlingunit.Status = new StatusType[collMappingStatus.Quantity];

                    for (int i = 0; i < collMappingStatus.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.Status[i] = new StatusType();

                        foreach (var colMapp in collMappingStatus.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.Status == null)
                    {
                        packagedtransporthandlingunit.Status = new StatusType[1];
                        packagedtransporthandlingunit.Status[0] = new StatusType();
                    }
                    SetField(packagedtransporthandlingunit.Status[0], xmlMapping);
                }
                break;
            case "CustomsDeclaration":
                if (xmlMapping is IXmlCollectionMapping collMappingCustomsDeclaration && !collMappingCustomsDeclaration.HasNextNode)
                {
                    if (packagedtransporthandlingunit.CustomsDeclaration == null)
                        packagedtransporthandlingunit.CustomsDeclaration = new CustomsDeclarationType[collMappingCustomsDeclaration.Quantity];

                    for (int i = 0; i < collMappingCustomsDeclaration.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.CustomsDeclaration[i] = new CustomsDeclarationType();

                        foreach (var colMapp in collMappingCustomsDeclaration.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.CustomsDeclaration == null)
                    {
                        packagedtransporthandlingunit.CustomsDeclaration = new CustomsDeclarationType[1];
                        packagedtransporthandlingunit.CustomsDeclaration[0] = new CustomsDeclarationType();
                    }
                    SetField(packagedtransporthandlingunit.CustomsDeclaration[0], xmlMapping);
                }
                break;
            case "ReferencedShipment":
                if (xmlMapping is IXmlCollectionMapping collMappingReferencedShipment && !collMappingReferencedShipment.HasNextNode)
                {
                    if (packagedtransporthandlingunit.ReferencedShipment == null)
                        packagedtransporthandlingunit.ReferencedShipment = new ShipmentType[collMappingReferencedShipment.Quantity];

                    for (int i = 0; i < collMappingReferencedShipment.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.ReferencedShipment[i] = new ShipmentType();

                        foreach (var colMapp in collMappingReferencedShipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.ReferencedShipment == null)
                    {
                        packagedtransporthandlingunit.ReferencedShipment = new ShipmentType[1];
                        packagedtransporthandlingunit.ReferencedShipment[0] = new ShipmentType();
                    }
                    SetField(packagedtransporthandlingunit.ReferencedShipment[0], xmlMapping);
                }
                break;
            case "Package":
                if (xmlMapping is IXmlCollectionMapping collMappingPackage && !collMappingPackage.HasNextNode)
                {
                    if (packagedtransporthandlingunit.Package == null)
                        packagedtransporthandlingunit.Package = new PackageType[collMappingPackage.Quantity];

                    for (int i = 0; i < collMappingPackage.Quantity; i++)
                    {
                        var row = packagedtransporthandlingunit.Package[i] = new PackageType();

                        foreach (var colMapp in collMappingPackage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (packagedtransporthandlingunit.Package == null)
                    {
                        packagedtransporthandlingunit.Package = new PackageType[1];
                        packagedtransporthandlingunit.Package[0] = new PackageType();
                    }
                    SetField(packagedtransporthandlingunit.Package[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(DespatchLineType handlingunitdespatchline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (handlingunitdespatchline.ID == null)
                    handlingunitdespatchline.ID = new IDType();
                SetField(handlingunitdespatchline.ID, xmlMapping);
                break;
            case "UUID":
                if (handlingunitdespatchline.UUID == null)
                    handlingunitdespatchline.UUID = new UUIDType();
                SetField(handlingunitdespatchline.UUID, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (handlingunitdespatchline.Note == null)
                        handlingunitdespatchline.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.Note == null)
                    {
                        handlingunitdespatchline.Note = new NoteType[1];
                        handlingunitdespatchline.Note[0] = new NoteType();
                    }
                    SetField(handlingunitdespatchline.Note[0], xmlMapping);
                }
                break;
            case "LineStatusCode":
                if (handlingunitdespatchline.LineStatusCode == null)
                    handlingunitdespatchline.LineStatusCode = new LineStatusCodeType();
                SetField(handlingunitdespatchline.LineStatusCode, xmlMapping);
                break;
            case "DeliveredQuantity":
                if (handlingunitdespatchline.DeliveredQuantity == null)
                    handlingunitdespatchline.DeliveredQuantity = new DeliveredQuantityType();
                SetField(handlingunitdespatchline.DeliveredQuantity, xmlMapping);
                break;
            case "BackorderQuantity":
                if (handlingunitdespatchline.BackorderQuantity == null)
                    handlingunitdespatchline.BackorderQuantity = new BackorderQuantityType();
                SetField(handlingunitdespatchline.BackorderQuantity, xmlMapping);
                break;
            case "BackorderReason":
                if (xmlMapping is IXmlCollectionMapping collMappingBackorderReason && !collMappingBackorderReason.HasNextNode)
                {
                    if (handlingunitdespatchline.BackorderReason == null)
                        handlingunitdespatchline.BackorderReason = new BackorderReasonType[collMappingBackorderReason.Quantity];

                    for (int i = 0; i < collMappingBackorderReason.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.BackorderReason[i] = new BackorderReasonType();

                        foreach (var colMapp in collMappingBackorderReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.BackorderReason == null)
                    {
                        handlingunitdespatchline.BackorderReason = new BackorderReasonType[1];
                        handlingunitdespatchline.BackorderReason[0] = new BackorderReasonType();
                    }
                    SetField(handlingunitdespatchline.BackorderReason[0], xmlMapping);
                }
                break;
            case "OutstandingQuantity":
                if (handlingunitdespatchline.OutstandingQuantity == null)
                    handlingunitdespatchline.OutstandingQuantity = new OutstandingQuantityType();
                SetField(handlingunitdespatchline.OutstandingQuantity, xmlMapping);
                break;
            case "OutstandingReason":
                if (xmlMapping is IXmlCollectionMapping collMappingOutstandingReason && !collMappingOutstandingReason.HasNextNode)
                {
                    if (handlingunitdespatchline.OutstandingReason == null)
                        handlingunitdespatchline.OutstandingReason = new OutstandingReasonType[collMappingOutstandingReason.Quantity];

                    for (int i = 0; i < collMappingOutstandingReason.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.OutstandingReason[i] = new OutstandingReasonType();

                        foreach (var colMapp in collMappingOutstandingReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.OutstandingReason == null)
                    {
                        handlingunitdespatchline.OutstandingReason = new OutstandingReasonType[1];
                        handlingunitdespatchline.OutstandingReason[0] = new OutstandingReasonType();
                    }
                    SetField(handlingunitdespatchline.OutstandingReason[0], xmlMapping);
                }
                break;
            case "OversupplyQuantity":
                if (handlingunitdespatchline.OversupplyQuantity == null)
                    handlingunitdespatchline.OversupplyQuantity = new OversupplyQuantityType();
                SetField(handlingunitdespatchline.OversupplyQuantity, xmlMapping);
                break;
            case "OrderLineReference":
                if (xmlMapping is IXmlCollectionMapping collMappingOrderLineReference && !collMappingOrderLineReference.HasNextNode)
                {
                    if (handlingunitdespatchline.OrderLineReference == null)
                        handlingunitdespatchline.OrderLineReference = new OrderLineReferenceType[collMappingOrderLineReference.Quantity];

                    for (int i = 0; i < collMappingOrderLineReference.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.OrderLineReference[i] = new OrderLineReferenceType();

                        foreach (var colMapp in collMappingOrderLineReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.OrderLineReference == null)
                    {
                        handlingunitdespatchline.OrderLineReference = new OrderLineReferenceType[1];
                        handlingunitdespatchline.OrderLineReference[0] = new OrderLineReferenceType();
                    }
                    SetField(handlingunitdespatchline.OrderLineReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (handlingunitdespatchline.DocumentReference == null)
                        handlingunitdespatchline.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.DocumentReference == null)
                    {
                        handlingunitdespatchline.DocumentReference = new DocumentReferenceType[1];
                        handlingunitdespatchline.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(handlingunitdespatchline.DocumentReference[0], xmlMapping);
                }
                break;
            case "Item":
                if (handlingunitdespatchline.Item == null)
                    handlingunitdespatchline.Item = new ItemType();
                SetField(handlingunitdespatchline.Item, xmlMapping);
                break;
            case "Shipment":
                if (xmlMapping is IXmlCollectionMapping collMappingShipment && !collMappingShipment.HasNextNode)
                {
                    if (handlingunitdespatchline.Shipment == null)
                        handlingunitdespatchline.Shipment = new ShipmentType[collMappingShipment.Quantity];

                    for (int i = 0; i < collMappingShipment.Quantity; i++)
                    {
                        var row = handlingunitdespatchline.Shipment[i] = new ShipmentType();

                        foreach (var colMapp in collMappingShipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (handlingunitdespatchline.Shipment == null)
                    {
                        handlingunitdespatchline.Shipment = new ShipmentType[1];
                        handlingunitdespatchline.Shipment[0] = new ShipmentType();
                    }
                    SetField(handlingunitdespatchline.Shipment[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(OrderLineReferenceType orderlinereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineID":
                if (orderlinereference.LineID == null)
                    orderlinereference.LineID = new LineIDType();
                SetField(orderlinereference.LineID, xmlMapping);
                break;
            case "SalesOrderLineID":
                if (orderlinereference.SalesOrderLineID == null)
                    orderlinereference.SalesOrderLineID = new SalesOrderLineIDType();
                SetField(orderlinereference.SalesOrderLineID, xmlMapping);
                break;
            case "UUID":
                if (orderlinereference.UUID == null)
                    orderlinereference.UUID = new UUIDType();
                SetField(orderlinereference.UUID, xmlMapping);
                break;
            case "LineStatusCode":
                if (orderlinereference.LineStatusCode == null)
                    orderlinereference.LineStatusCode = new LineStatusCodeType();
                SetField(orderlinereference.LineStatusCode, xmlMapping);
                break;
            case "OrderReference":
                if (orderlinereference.OrderReference == null)
                    orderlinereference.OrderReference = new OrderReferenceType();
                SetField(orderlinereference.OrderReference, xmlMapping);
                break;

        }
    }
    public void SetField(ItemType item, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (item.Description == null)
                        item.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = item.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.Description == null)
                    {
                        item.Description = new DescriptionType[1];
                        item.Description[0] = new DescriptionType();
                    }
                    SetField(item.Description[0], xmlMapping);
                }
                break;
            case "PackQuantity":
                if (item.PackQuantity == null)
                    item.PackQuantity = new PackQuantityType();
                SetField(item.PackQuantity, xmlMapping);
                break;
            case "PackSizeNumeric":
                if (item.PackSizeNumeric == null)
                    item.PackSizeNumeric = new PackSizeNumericType();
                SetField(item.PackSizeNumeric, xmlMapping);
                break;
            case "CatalogueIndicator":
                if (item.CatalogueIndicator == null)
                    item.CatalogueIndicator = new CatalogueIndicatorType();
                SetField(item.CatalogueIndicator, xmlMapping);
                break;
            case "Name":
                if (item.Name == null)
                    item.Name = new NameType1();
                SetField(item.Name, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (item.HazardousRiskIndicator == null)
                    item.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(item.HazardousRiskIndicator, xmlMapping);
                break;
            case "AdditionalInformation":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalInformation && !collMappingAdditionalInformation.HasNextNode)
                {
                    if (item.AdditionalInformation == null)
                        item.AdditionalInformation = new AdditionalInformationType[collMappingAdditionalInformation.Quantity];

                    for (int i = 0; i < collMappingAdditionalInformation.Quantity; i++)
                    {
                        var row = item.AdditionalInformation[i] = new AdditionalInformationType();

                        foreach (var colMapp in collMappingAdditionalInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.AdditionalInformation == null)
                    {
                        item.AdditionalInformation = new AdditionalInformationType[1];
                        item.AdditionalInformation[0] = new AdditionalInformationType();
                    }
                    SetField(item.AdditionalInformation[0], xmlMapping);
                }
                break;
            case "Keyword":
                if (xmlMapping is IXmlCollectionMapping collMappingKeyword && !collMappingKeyword.HasNextNode)
                {
                    if (item.Keyword == null)
                        item.Keyword = new KeywordType[collMappingKeyword.Quantity];

                    for (int i = 0; i < collMappingKeyword.Quantity; i++)
                    {
                        var row = item.Keyword[i] = new KeywordType();

                        foreach (var colMapp in collMappingKeyword.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.Keyword == null)
                    {
                        item.Keyword = new KeywordType[1];
                        item.Keyword[0] = new KeywordType();
                    }
                    SetField(item.Keyword[0], xmlMapping);
                }
                break;
            case "BrandName":
                if (xmlMapping is IXmlCollectionMapping collMappingBrandName && !collMappingBrandName.HasNextNode)
                {
                    if (item.BrandName == null)
                        item.BrandName = new BrandNameType[collMappingBrandName.Quantity];

                    for (int i = 0; i < collMappingBrandName.Quantity; i++)
                    {
                        var row = item.BrandName[i] = new BrandNameType();

                        foreach (var colMapp in collMappingBrandName.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.BrandName == null)
                    {
                        item.BrandName = new BrandNameType[1];
                        item.BrandName[0] = new BrandNameType();
                    }
                    SetField(item.BrandName[0], xmlMapping);
                }
                break;
            case "ModelName":
                if (xmlMapping is IXmlCollectionMapping collMappingModelName && !collMappingModelName.HasNextNode)
                {
                    if (item.ModelName == null)
                        item.ModelName = new ModelNameType[collMappingModelName.Quantity];

                    for (int i = 0; i < collMappingModelName.Quantity; i++)
                    {
                        var row = item.ModelName[i] = new ModelNameType();

                        foreach (var colMapp in collMappingModelName.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ModelName == null)
                    {
                        item.ModelName = new ModelNameType[1];
                        item.ModelName[0] = new ModelNameType();
                    }
                    SetField(item.ModelName[0], xmlMapping);
                }
                break;
            case "BuyersItemIdentification":
                if (item.BuyersItemIdentification == null)
                    item.BuyersItemIdentification = new ItemIdentificationType();
                SetField(item.BuyersItemIdentification, xmlMapping);
                break;
            case "SellersItemIdentification":
                if (item.SellersItemIdentification == null)
                    item.SellersItemIdentification = new ItemIdentificationType();
                SetField(item.SellersItemIdentification, xmlMapping);
                break;
            case "ManufacturersItemIdentification":
                if (xmlMapping is IXmlCollectionMapping collMappingManufacturersItemIdentification && !collMappingManufacturersItemIdentification.HasNextNode)
                {
                    if (item.ManufacturersItemIdentification == null)
                        item.ManufacturersItemIdentification = new ItemIdentificationType[collMappingManufacturersItemIdentification.Quantity];

                    for (int i = 0; i < collMappingManufacturersItemIdentification.Quantity; i++)
                    {
                        var row = item.ManufacturersItemIdentification[i] = new ItemIdentificationType();

                        foreach (var colMapp in collMappingManufacturersItemIdentification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ManufacturersItemIdentification == null)
                    {
                        item.ManufacturersItemIdentification = new ItemIdentificationType[1];
                        item.ManufacturersItemIdentification[0] = new ItemIdentificationType();
                    }
                    SetField(item.ManufacturersItemIdentification[0], xmlMapping);
                }
                break;
            case "StandardItemIdentification":
                if (item.StandardItemIdentification == null)
                    item.StandardItemIdentification = new ItemIdentificationType();
                SetField(item.StandardItemIdentification, xmlMapping);
                break;
            case "CatalogueItemIdentification":
                if (item.CatalogueItemIdentification == null)
                    item.CatalogueItemIdentification = new ItemIdentificationType();
                SetField(item.CatalogueItemIdentification, xmlMapping);
                break;
            case "AdditionalItemIdentification":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemIdentification && !collMappingAdditionalItemIdentification.HasNextNode)
                {
                    if (item.AdditionalItemIdentification == null)
                        item.AdditionalItemIdentification = new ItemIdentificationType[collMappingAdditionalItemIdentification.Quantity];

                    for (int i = 0; i < collMappingAdditionalItemIdentification.Quantity; i++)
                    {
                        var row = item.AdditionalItemIdentification[i] = new ItemIdentificationType();

                        foreach (var colMapp in collMappingAdditionalItemIdentification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.AdditionalItemIdentification == null)
                    {
                        item.AdditionalItemIdentification = new ItemIdentificationType[1];
                        item.AdditionalItemIdentification[0] = new ItemIdentificationType();
                    }
                    SetField(item.AdditionalItemIdentification[0], xmlMapping);
                }
                break;
            case "CatalogueDocumentReference":
                if (item.CatalogueDocumentReference == null)
                    item.CatalogueDocumentReference = new DocumentReferenceType();
                SetField(item.CatalogueDocumentReference, xmlMapping);
                break;
            case "ItemSpecificationDocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingItemSpecificationDocumentReference && !collMappingItemSpecificationDocumentReference.HasNextNode)
                {
                    if (item.ItemSpecificationDocumentReference == null)
                        item.ItemSpecificationDocumentReference = new DocumentReferenceType[collMappingItemSpecificationDocumentReference.Quantity];

                    for (int i = 0; i < collMappingItemSpecificationDocumentReference.Quantity; i++)
                    {
                        var row = item.ItemSpecificationDocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingItemSpecificationDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ItemSpecificationDocumentReference == null)
                    {
                        item.ItemSpecificationDocumentReference = new DocumentReferenceType[1];
                        item.ItemSpecificationDocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(item.ItemSpecificationDocumentReference[0], xmlMapping);
                }
                break;
            case "OriginCountry":
                if (item.OriginCountry == null)
                    item.OriginCountry = new CountryType();
                SetField(item.OriginCountry, xmlMapping);
                break;
            case "CommodityClassification":
                if (xmlMapping is IXmlCollectionMapping collMappingCommodityClassification && !collMappingCommodityClassification.HasNextNode)
                {
                    if (item.CommodityClassification == null)
                        item.CommodityClassification = new CommodityClassificationType[collMappingCommodityClassification.Quantity];

                    for (int i = 0; i < collMappingCommodityClassification.Quantity; i++)
                    {
                        var row = item.CommodityClassification[i] = new CommodityClassificationType();

                        foreach (var colMapp in collMappingCommodityClassification.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.CommodityClassification == null)
                    {
                        item.CommodityClassification = new CommodityClassificationType[1];
                        item.CommodityClassification[0] = new CommodityClassificationType();
                    }
                    SetField(item.CommodityClassification[0], xmlMapping);
                }
                break;
            case "TransactionConditions":
                if (xmlMapping is IXmlCollectionMapping collMappingTransactionConditions && !collMappingTransactionConditions.HasNextNode)
                {
                    if (item.TransactionConditions == null)
                        item.TransactionConditions = new TransactionConditionsType[collMappingTransactionConditions.Quantity];

                    for (int i = 0; i < collMappingTransactionConditions.Quantity; i++)
                    {
                        var row = item.TransactionConditions[i] = new TransactionConditionsType();

                        foreach (var colMapp in collMappingTransactionConditions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.TransactionConditions == null)
                    {
                        item.TransactionConditions = new TransactionConditionsType[1];
                        item.TransactionConditions[0] = new TransactionConditionsType();
                    }
                    SetField(item.TransactionConditions[0], xmlMapping);
                }
                break;
            case "HazardousItem":
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousItem && !collMappingHazardousItem.HasNextNode)
                {
                    if (item.HazardousItem == null)
                        item.HazardousItem = new HazardousItemType[collMappingHazardousItem.Quantity];

                    for (int i = 0; i < collMappingHazardousItem.Quantity; i++)
                    {
                        var row = item.HazardousItem[i] = new HazardousItemType();

                        foreach (var colMapp in collMappingHazardousItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.HazardousItem == null)
                    {
                        item.HazardousItem = new HazardousItemType[1];
                        item.HazardousItem[0] = new HazardousItemType();
                    }
                    SetField(item.HazardousItem[0], xmlMapping);
                }
                break;
            case "ClassifiedTaxCategory":
                if (xmlMapping is IXmlCollectionMapping collMappingClassifiedTaxCategory && !collMappingClassifiedTaxCategory.HasNextNode)
                {
                    if (item.ClassifiedTaxCategory == null)
                        item.ClassifiedTaxCategory = new TaxCategoryType[collMappingClassifiedTaxCategory.Quantity];

                    for (int i = 0; i < collMappingClassifiedTaxCategory.Quantity; i++)
                    {
                        var row = item.ClassifiedTaxCategory[i] = new TaxCategoryType();

                        foreach (var colMapp in collMappingClassifiedTaxCategory.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ClassifiedTaxCategory == null)
                    {
                        item.ClassifiedTaxCategory = new TaxCategoryType[1];
                        item.ClassifiedTaxCategory[0] = new TaxCategoryType();
                    }
                    SetField(item.ClassifiedTaxCategory[0], xmlMapping);
                }
                break;
            case "AdditionalItemProperty":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty && !collMappingAdditionalItemProperty.HasNextNode)
                {
                    if (item.AdditionalItemProperty == null)
                        item.AdditionalItemProperty = new ItemPropertyType[collMappingAdditionalItemProperty.Quantity];

                    for (int i = 0; i < collMappingAdditionalItemProperty.Quantity; i++)
                    {
                        var row = item.AdditionalItemProperty[i] = new ItemPropertyType();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.AdditionalItemProperty == null)
                    {
                        item.AdditionalItemProperty = new ItemPropertyType[1];
                        item.AdditionalItemProperty[0] = new ItemPropertyType();
                    }
                    SetField(item.AdditionalItemProperty[0], xmlMapping);
                }
                break;
            case "ManufacturerParty":
                if (xmlMapping is IXmlCollectionMapping collMappingManufacturerParty && !collMappingManufacturerParty.HasNextNode)
                {
                    if (item.ManufacturerParty == null)
                        item.ManufacturerParty = new PartyType[collMappingManufacturerParty.Quantity];

                    for (int i = 0; i < collMappingManufacturerParty.Quantity; i++)
                    {
                        var row = item.ManufacturerParty[i] = new PartyType();

                        foreach (var colMapp in collMappingManufacturerParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ManufacturerParty == null)
                    {
                        item.ManufacturerParty = new PartyType[1];
                        item.ManufacturerParty[0] = new PartyType();
                    }
                    SetField(item.ManufacturerParty[0], xmlMapping);
                }
                break;
            case "InformationContentProviderParty":
                if (item.InformationContentProviderParty == null)
                    item.InformationContentProviderParty = new PartyType();
                SetField(item.InformationContentProviderParty, xmlMapping);
                break;
            case "OriginAddress":
                if (xmlMapping is IXmlCollectionMapping collMappingOriginAddress && !collMappingOriginAddress.HasNextNode)
                {
                    if (item.OriginAddress == null)
                        item.OriginAddress = new AddressType[collMappingOriginAddress.Quantity];

                    for (int i = 0; i < collMappingOriginAddress.Quantity; i++)
                    {
                        var row = item.OriginAddress[i] = new AddressType();

                        foreach (var colMapp in collMappingOriginAddress.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.OriginAddress == null)
                    {
                        item.OriginAddress = new AddressType[1];
                        item.OriginAddress[0] = new AddressType();
                    }
                    SetField(item.OriginAddress[0], xmlMapping);
                }
                break;
            case "ItemInstance":
                if (xmlMapping is IXmlCollectionMapping collMappingItemInstance && !collMappingItemInstance.HasNextNode)
                {
                    if (item.ItemInstance == null)
                        item.ItemInstance = new ItemInstanceType[collMappingItemInstance.Quantity];

                    for (int i = 0; i < collMappingItemInstance.Quantity; i++)
                    {
                        var row = item.ItemInstance[i] = new ItemInstanceType();

                        foreach (var colMapp in collMappingItemInstance.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.ItemInstance == null)
                    {
                        item.ItemInstance = new ItemInstanceType[1];
                        item.ItemInstance[0] = new ItemInstanceType();
                    }
                    SetField(item.ItemInstance[0], xmlMapping);
                }
                break;
            case "Certificate":
                if (xmlMapping is IXmlCollectionMapping collMappingCertificate && !collMappingCertificate.HasNextNode)
                {
                    if (item.Certificate == null)
                        item.Certificate = new CertificateType[collMappingCertificate.Quantity];

                    for (int i = 0; i < collMappingCertificate.Quantity; i++)
                    {
                        var row = item.Certificate[i] = new CertificateType();

                        foreach (var colMapp in collMappingCertificate.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.Certificate == null)
                    {
                        item.Certificate = new CertificateType[1];
                        item.Certificate[0] = new CertificateType();
                    }
                    SetField(item.Certificate[0], xmlMapping);
                }
                break;
            case "Dimension":
                if (xmlMapping is IXmlCollectionMapping collMappingDimension && !collMappingDimension.HasNextNode)
                {
                    if (item.Dimension == null)
                        item.Dimension = new DimensionType[collMappingDimension.Quantity];

                    for (int i = 0; i < collMappingDimension.Quantity; i++)
                    {
                        var row = item.Dimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (item.Dimension == null)
                    {
                        item.Dimension = new DimensionType[1];
                        item.Dimension[0] = new DimensionType();
                    }
                    SetField(item.Dimension[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ItemIdentificationType buyersitemidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (buyersitemidentification.ID == null)
                    buyersitemidentification.ID = new IDType();
                SetField(buyersitemidentification.ID, xmlMapping);
                break;
            case "ExtendedID":
                if (buyersitemidentification.ExtendedID == null)
                    buyersitemidentification.ExtendedID = new ExtendedIDType();
                SetField(buyersitemidentification.ExtendedID, xmlMapping);
                break;
            case "BarcodeSymbologyID":
                if (buyersitemidentification.BarcodeSymbologyID == null)
                    buyersitemidentification.BarcodeSymbologyID = new BarcodeSymbologyIDType();
                SetField(buyersitemidentification.BarcodeSymbologyID, xmlMapping);
                break;
            case "PhysicalAttribute":
                if (xmlMapping is IXmlCollectionMapping collMappingPhysicalAttribute && !collMappingPhysicalAttribute.HasNextNode)
                {
                    if (buyersitemidentification.PhysicalAttribute == null)
                        buyersitemidentification.PhysicalAttribute = new PhysicalAttributeType[collMappingPhysicalAttribute.Quantity];

                    for (int i = 0; i < collMappingPhysicalAttribute.Quantity; i++)
                    {
                        var row = buyersitemidentification.PhysicalAttribute[i] = new PhysicalAttributeType();

                        foreach (var colMapp in collMappingPhysicalAttribute.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (buyersitemidentification.PhysicalAttribute == null)
                    {
                        buyersitemidentification.PhysicalAttribute = new PhysicalAttributeType[1];
                        buyersitemidentification.PhysicalAttribute[0] = new PhysicalAttributeType();
                    }
                    SetField(buyersitemidentification.PhysicalAttribute[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (buyersitemidentification.MeasurementDimension == null)
                        buyersitemidentification.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = buyersitemidentification.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (buyersitemidentification.MeasurementDimension == null)
                    {
                        buyersitemidentification.MeasurementDimension = new DimensionType[1];
                        buyersitemidentification.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(buyersitemidentification.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "IssuerParty":
                if (buyersitemidentification.IssuerParty == null)
                    buyersitemidentification.IssuerParty = new PartyType();
                SetField(buyersitemidentification.IssuerParty, xmlMapping);
                break;

        }
    }
    public void SetField(PhysicalAttributeType physicalattribute, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "AttributeID":
                if (physicalattribute.AttributeID == null)
                    physicalattribute.AttributeID = new AttributeIDType();
                SetField(physicalattribute.AttributeID, xmlMapping);
                break;
            case "PositionCode":
                if (physicalattribute.PositionCode == null)
                    physicalattribute.PositionCode = new PositionCodeType();
                SetField(physicalattribute.PositionCode, xmlMapping);
                break;
            case "DescriptionCode":
                if (physicalattribute.DescriptionCode == null)
                    physicalattribute.DescriptionCode = new DescriptionCodeType();
                SetField(physicalattribute.DescriptionCode, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (physicalattribute.Description == null)
                        physicalattribute.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = physicalattribute.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (physicalattribute.Description == null)
                    {
                        physicalattribute.Description = new DescriptionType[1];
                        physicalattribute.Description[0] = new DescriptionType();
                    }
                    SetField(physicalattribute.Description[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(CommodityClassificationType commodityclassification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "NatureCode":
                if (commodityclassification.NatureCode == null)
                    commodityclassification.NatureCode = new NatureCodeType();
                SetField(commodityclassification.NatureCode, xmlMapping);
                break;
            case "CargoTypeCode":
                if (commodityclassification.CargoTypeCode == null)
                    commodityclassification.CargoTypeCode = new CargoTypeCodeType();
                SetField(commodityclassification.CargoTypeCode, xmlMapping);
                break;
            case "CommodityCode":
                if (commodityclassification.CommodityCode == null)
                    commodityclassification.CommodityCode = new CommodityCodeType();
                SetField(commodityclassification.CommodityCode, xmlMapping);
                break;
            case "ItemClassificationCode":
                if (commodityclassification.ItemClassificationCode == null)
                    commodityclassification.ItemClassificationCode = new ItemClassificationCodeType();
                SetField(commodityclassification.ItemClassificationCode, xmlMapping);
                break;

        }
    }
    public void SetField(TransactionConditionsType transactionconditions, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (transactionconditions.ID == null)
                    transactionconditions.ID = new IDType();
                SetField(transactionconditions.ID, xmlMapping);
                break;
            case "ActionCode":
                if (transactionconditions.ActionCode == null)
                    transactionconditions.ActionCode = new ActionCodeType();
                SetField(transactionconditions.ActionCode, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (transactionconditions.Description == null)
                        transactionconditions.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = transactionconditions.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transactionconditions.Description == null)
                    {
                        transactionconditions.Description = new DescriptionType[1];
                        transactionconditions.Description[0] = new DescriptionType();
                    }
                    SetField(transactionconditions.Description[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (transactionconditions.DocumentReference == null)
                        transactionconditions.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = transactionconditions.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (transactionconditions.DocumentReference == null)
                    {
                        transactionconditions.DocumentReference = new DocumentReferenceType[1];
                        transactionconditions.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(transactionconditions.DocumentReference[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(HazardousItemType hazardousitem, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (hazardousitem.ID == null)
                    hazardousitem.ID = new IDType();
                SetField(hazardousitem.ID, xmlMapping);
                break;
            case "PlacardNotation":
                if (hazardousitem.PlacardNotation == null)
                    hazardousitem.PlacardNotation = new PlacardNotationType();
                SetField(hazardousitem.PlacardNotation, xmlMapping);
                break;
            case "PlacardEndorsement":
                if (hazardousitem.PlacardEndorsement == null)
                    hazardousitem.PlacardEndorsement = new PlacardEndorsementType();
                SetField(hazardousitem.PlacardEndorsement, xmlMapping);
                break;
            case "AdditionalInformation":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalInformation && !collMappingAdditionalInformation.HasNextNode)
                {
                    if (hazardousitem.AdditionalInformation == null)
                        hazardousitem.AdditionalInformation = new AdditionalInformationType[collMappingAdditionalInformation.Quantity];

                    for (int i = 0; i < collMappingAdditionalInformation.Quantity; i++)
                    {
                        var row = hazardousitem.AdditionalInformation[i] = new AdditionalInformationType();

                        foreach (var colMapp in collMappingAdditionalInformation.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (hazardousitem.AdditionalInformation == null)
                    {
                        hazardousitem.AdditionalInformation = new AdditionalInformationType[1];
                        hazardousitem.AdditionalInformation[0] = new AdditionalInformationType();
                    }
                    SetField(hazardousitem.AdditionalInformation[0], xmlMapping);
                }
                break;
            case "UNDGCode":
                if (hazardousitem.UNDGCode == null)
                    hazardousitem.UNDGCode = new UNDGCodeType();
                SetField(hazardousitem.UNDGCode, xmlMapping);
                break;
            case "EmergencyProceduresCode":
                if (hazardousitem.EmergencyProceduresCode == null)
                    hazardousitem.EmergencyProceduresCode = new EmergencyProceduresCodeType();
                SetField(hazardousitem.EmergencyProceduresCode, xmlMapping);
                break;
            case "MedicalFirstAidGuideCode":
                if (hazardousitem.MedicalFirstAidGuideCode == null)
                    hazardousitem.MedicalFirstAidGuideCode = new MedicalFirstAidGuideCodeType();
                SetField(hazardousitem.MedicalFirstAidGuideCode, xmlMapping);
                break;
            case "TechnicalName":
                if (hazardousitem.TechnicalName == null)
                    hazardousitem.TechnicalName = new TechnicalNameType();
                SetField(hazardousitem.TechnicalName, xmlMapping);
                break;
            case "CategoryName":
                if (hazardousitem.CategoryName == null)
                    hazardousitem.CategoryName = new CategoryNameType();
                SetField(hazardousitem.CategoryName, xmlMapping);
                break;
            case "HazardousCategoryCode":
                if (hazardousitem.HazardousCategoryCode == null)
                    hazardousitem.HazardousCategoryCode = new HazardousCategoryCodeType();
                SetField(hazardousitem.HazardousCategoryCode, xmlMapping);
                break;
            case "UpperOrangeHazardPlacardID":
                if (hazardousitem.UpperOrangeHazardPlacardID == null)
                    hazardousitem.UpperOrangeHazardPlacardID = new UpperOrangeHazardPlacardIDType();
                SetField(hazardousitem.UpperOrangeHazardPlacardID, xmlMapping);
                break;
            case "LowerOrangeHazardPlacardID":
                if (hazardousitem.LowerOrangeHazardPlacardID == null)
                    hazardousitem.LowerOrangeHazardPlacardID = new LowerOrangeHazardPlacardIDType();
                SetField(hazardousitem.LowerOrangeHazardPlacardID, xmlMapping);
                break;
            case "MarkingID":
                if (hazardousitem.MarkingID == null)
                    hazardousitem.MarkingID = new MarkingIDType();
                SetField(hazardousitem.MarkingID, xmlMapping);
                break;
            case "HazardClassID":
                if (hazardousitem.HazardClassID == null)
                    hazardousitem.HazardClassID = new HazardClassIDType();
                SetField(hazardousitem.HazardClassID, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (hazardousitem.NetWeightMeasure == null)
                    hazardousitem.NetWeightMeasure = new NetWeightMeasureType();
                SetField(hazardousitem.NetWeightMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (hazardousitem.NetVolumeMeasure == null)
                    hazardousitem.NetVolumeMeasure = new NetVolumeMeasureType();
                SetField(hazardousitem.NetVolumeMeasure, xmlMapping);
                break;
            case "Quantity":
                if (hazardousitem.Quantity == null)
                    hazardousitem.Quantity = new QuantityType2();
                SetField(hazardousitem.Quantity, xmlMapping);
                break;
            case "ContactParty":
                if (hazardousitem.ContactParty == null)
                    hazardousitem.ContactParty = new PartyType();
                SetField(hazardousitem.ContactParty, xmlMapping);
                break;
            case "SecondaryHazard":
                if (xmlMapping is IXmlCollectionMapping collMappingSecondaryHazard && !collMappingSecondaryHazard.HasNextNode)
                {
                    if (hazardousitem.SecondaryHazard == null)
                        hazardousitem.SecondaryHazard = new SecondaryHazardType[collMappingSecondaryHazard.Quantity];

                    for (int i = 0; i < collMappingSecondaryHazard.Quantity; i++)
                    {
                        var row = hazardousitem.SecondaryHazard[i] = new SecondaryHazardType();

                        foreach (var colMapp in collMappingSecondaryHazard.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (hazardousitem.SecondaryHazard == null)
                    {
                        hazardousitem.SecondaryHazard = new SecondaryHazardType[1];
                        hazardousitem.SecondaryHazard[0] = new SecondaryHazardType();
                    }
                    SetField(hazardousitem.SecondaryHazard[0], xmlMapping);
                }
                break;
            case "HazardousGoodsTransit":
                if (xmlMapping is IXmlCollectionMapping collMappingHazardousGoodsTransit && !collMappingHazardousGoodsTransit.HasNextNode)
                {
                    if (hazardousitem.HazardousGoodsTransit == null)
                        hazardousitem.HazardousGoodsTransit = new HazardousGoodsTransitType[collMappingHazardousGoodsTransit.Quantity];

                    for (int i = 0; i < collMappingHazardousGoodsTransit.Quantity; i++)
                    {
                        var row = hazardousitem.HazardousGoodsTransit[i] = new HazardousGoodsTransitType();

                        foreach (var colMapp in collMappingHazardousGoodsTransit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (hazardousitem.HazardousGoodsTransit == null)
                    {
                        hazardousitem.HazardousGoodsTransit = new HazardousGoodsTransitType[1];
                        hazardousitem.HazardousGoodsTransit[0] = new HazardousGoodsTransitType();
                    }
                    SetField(hazardousitem.HazardousGoodsTransit[0], xmlMapping);
                }
                break;
            case "EmergencyTemperature":
                if (hazardousitem.EmergencyTemperature == null)
                    hazardousitem.EmergencyTemperature = new TemperatureType();
                SetField(hazardousitem.EmergencyTemperature, xmlMapping);
                break;
            case "FlashpointTemperature":
                if (hazardousitem.FlashpointTemperature == null)
                    hazardousitem.FlashpointTemperature = new TemperatureType();
                SetField(hazardousitem.FlashpointTemperature, xmlMapping);
                break;
            case "AdditionalTemperature":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalTemperature && !collMappingAdditionalTemperature.HasNextNode)
                {
                    if (hazardousitem.AdditionalTemperature == null)
                        hazardousitem.AdditionalTemperature = new TemperatureType[collMappingAdditionalTemperature.Quantity];

                    for (int i = 0; i < collMappingAdditionalTemperature.Quantity; i++)
                    {
                        var row = hazardousitem.AdditionalTemperature[i] = new TemperatureType();

                        foreach (var colMapp in collMappingAdditionalTemperature.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (hazardousitem.AdditionalTemperature == null)
                    {
                        hazardousitem.AdditionalTemperature = new TemperatureType[1];
                        hazardousitem.AdditionalTemperature[0] = new TemperatureType();
                    }
                    SetField(hazardousitem.AdditionalTemperature[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(SecondaryHazardType secondaryhazard, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (secondaryhazard.ID == null)
                    secondaryhazard.ID = new IDType();
                SetField(secondaryhazard.ID, xmlMapping);
                break;
            case "PlacardNotation":
                if (secondaryhazard.PlacardNotation == null)
                    secondaryhazard.PlacardNotation = new PlacardNotationType();
                SetField(secondaryhazard.PlacardNotation, xmlMapping);
                break;
            case "PlacardEndorsement":
                if (secondaryhazard.PlacardEndorsement == null)
                    secondaryhazard.PlacardEndorsement = new PlacardEndorsementType();
                SetField(secondaryhazard.PlacardEndorsement, xmlMapping);
                break;
            case "EmergencyProceduresCode":
                if (secondaryhazard.EmergencyProceduresCode == null)
                    secondaryhazard.EmergencyProceduresCode = new EmergencyProceduresCodeType();
                SetField(secondaryhazard.EmergencyProceduresCode, xmlMapping);
                break;
            case "Extension":
                if (xmlMapping is IXmlCollectionMapping collMappingExtension && !collMappingExtension.HasNextNode)
                {
                    if (secondaryhazard.Extension == null)
                        secondaryhazard.Extension = new ExtensionType[collMappingExtension.Quantity];

                    for (int i = 0; i < collMappingExtension.Quantity; i++)
                    {
                        var row = secondaryhazard.Extension[i] = new ExtensionType();

                        foreach (var colMapp in collMappingExtension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (secondaryhazard.Extension == null)
                    {
                        secondaryhazard.Extension = new ExtensionType[1];
                        secondaryhazard.Extension[0] = new ExtensionType();
                    }
                    SetField(secondaryhazard.Extension[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ItemPropertyType additionalitemproperty, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (additionalitemproperty.ID == null)
                    additionalitemproperty.ID = new IDType();
                SetField(additionalitemproperty.ID, xmlMapping);
                break;
            case "Name":
                if (additionalitemproperty.Name == null)
                    additionalitemproperty.Name = new NameType1();
                SetField(additionalitemproperty.Name, xmlMapping);
                break;
            case "NameCode":
                if (additionalitemproperty.NameCode == null)
                    additionalitemproperty.NameCode = new NameCodeType();
                SetField(additionalitemproperty.NameCode, xmlMapping);
                break;
            case "TestMethod":
                if (additionalitemproperty.TestMethod == null)
                    additionalitemproperty.TestMethod = new TestMethodType();
                SetField(additionalitemproperty.TestMethod, xmlMapping);
                break;
            case "Value":
                if (additionalitemproperty.Value == null)
                    additionalitemproperty.Value = new ValueType();
                SetField(additionalitemproperty.Value, xmlMapping);
                break;
            case "ValueQuantity":
                if (additionalitemproperty.ValueQuantity == null)
                    additionalitemproperty.ValueQuantity = new ValueQuantityType();
                SetField(additionalitemproperty.ValueQuantity, xmlMapping);
                break;
            case "ValueQualifier":
                if (xmlMapping is IXmlCollectionMapping collMappingValueQualifier && !collMappingValueQualifier.HasNextNode)
                {
                    if (additionalitemproperty.ValueQualifier == null)
                        additionalitemproperty.ValueQualifier = new ValueQualifierType[collMappingValueQualifier.Quantity];

                    for (int i = 0; i < collMappingValueQualifier.Quantity; i++)
                    {
                        var row = additionalitemproperty.ValueQualifier[i] = new ValueQualifierType();

                        foreach (var colMapp in collMappingValueQualifier.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (additionalitemproperty.ValueQualifier == null)
                    {
                        additionalitemproperty.ValueQualifier = new ValueQualifierType[1];
                        additionalitemproperty.ValueQualifier[0] = new ValueQualifierType();
                    }
                    SetField(additionalitemproperty.ValueQualifier[0], xmlMapping);
                }
                break;
            case "ImportanceCode":
                if (additionalitemproperty.ImportanceCode == null)
                    additionalitemproperty.ImportanceCode = new ImportanceCodeType();
                SetField(additionalitemproperty.ImportanceCode, xmlMapping);
                break;
            case "ListValue":
                if (xmlMapping is IXmlCollectionMapping collMappingListValue && !collMappingListValue.HasNextNode)
                {
                    if (additionalitemproperty.ListValue == null)
                        additionalitemproperty.ListValue = new ListValueType[collMappingListValue.Quantity];

                    for (int i = 0; i < collMappingListValue.Quantity; i++)
                    {
                        var row = additionalitemproperty.ListValue[i] = new ListValueType();

                        foreach (var colMapp in collMappingListValue.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (additionalitemproperty.ListValue == null)
                    {
                        additionalitemproperty.ListValue = new ListValueType[1];
                        additionalitemproperty.ListValue[0] = new ListValueType();
                    }
                    SetField(additionalitemproperty.ListValue[0], xmlMapping);
                }
                break;
            case "UsabilityPeriod":
                if (additionalitemproperty.UsabilityPeriod == null)
                    additionalitemproperty.UsabilityPeriod = new PeriodType();
                SetField(additionalitemproperty.UsabilityPeriod, xmlMapping);
                break;
            case "ItemPropertyGroup":
                if (xmlMapping is IXmlCollectionMapping collMappingItemPropertyGroup && !collMappingItemPropertyGroup.HasNextNode)
                {
                    if (additionalitemproperty.ItemPropertyGroup == null)
                        additionalitemproperty.ItemPropertyGroup = new ItemPropertyGroupType[collMappingItemPropertyGroup.Quantity];

                    for (int i = 0; i < collMappingItemPropertyGroup.Quantity; i++)
                    {
                        var row = additionalitemproperty.ItemPropertyGroup[i] = new ItemPropertyGroupType();

                        foreach (var colMapp in collMappingItemPropertyGroup.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (additionalitemproperty.ItemPropertyGroup == null)
                    {
                        additionalitemproperty.ItemPropertyGroup = new ItemPropertyGroupType[1];
                        additionalitemproperty.ItemPropertyGroup[0] = new ItemPropertyGroupType();
                    }
                    SetField(additionalitemproperty.ItemPropertyGroup[0], xmlMapping);
                }
                break;
            case "RangeDimension":
                if (additionalitemproperty.RangeDimension == null)
                    additionalitemproperty.RangeDimension = new DimensionType();
                SetField(additionalitemproperty.RangeDimension, xmlMapping);
                break;
            case "ItemPropertyRange":
                if (additionalitemproperty.ItemPropertyRange == null)
                    additionalitemproperty.ItemPropertyRange = new ItemPropertyRangeType();
                SetField(additionalitemproperty.ItemPropertyRange, xmlMapping);
                break;

        }
    }
    public void SetField(ItemPropertyGroupType itempropertygroup, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (itempropertygroup.ID == null)
                    itempropertygroup.ID = new IDType();
                SetField(itempropertygroup.ID, xmlMapping);
                break;
            case "Name":
                if (itempropertygroup.Name == null)
                    itempropertygroup.Name = new NameType1();
                SetField(itempropertygroup.Name, xmlMapping);
                break;
            case "ImportanceCode":
                if (itempropertygroup.ImportanceCode == null)
                    itempropertygroup.ImportanceCode = new ImportanceCodeType();
                SetField(itempropertygroup.ImportanceCode, xmlMapping);
                break;

        }
    }
    public void SetField(ItemPropertyRangeType itempropertyrange, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "MinimumValue":
                if (itempropertyrange.MinimumValue == null)
                    itempropertyrange.MinimumValue = new MinimumValueType();
                SetField(itempropertyrange.MinimumValue, xmlMapping);
                break;
            case "MaximumValue":
                if (itempropertyrange.MaximumValue == null)
                    itempropertyrange.MaximumValue = new MaximumValueType();
                SetField(itempropertyrange.MaximumValue, xmlMapping);
                break;

        }
    }
    public void SetField(ItemInstanceType iteminstance, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ProductTraceID":
                if (iteminstance.ProductTraceID == null)
                    iteminstance.ProductTraceID = new ProductTraceIDType();
                SetField(iteminstance.ProductTraceID, xmlMapping);
                break;
            case "ManufactureDate":
                if (iteminstance.ManufactureDate == null)
                    iteminstance.ManufactureDate = new ManufactureDateType();
                SetField(iteminstance.ManufactureDate, xmlMapping);
                break;
            case "ManufactureTime":
                if (iteminstance.ManufactureTime == null)
                    iteminstance.ManufactureTime = new ManufactureTimeType();
                SetField(iteminstance.ManufactureTime, xmlMapping);
                break;
            case "BestBeforeDate":
                if (iteminstance.BestBeforeDate == null)
                    iteminstance.BestBeforeDate = new BestBeforeDateType();
                SetField(iteminstance.BestBeforeDate, xmlMapping);
                break;
            case "RegistrationID":
                if (iteminstance.RegistrationID == null)
                    iteminstance.RegistrationID = new RegistrationIDType();
                SetField(iteminstance.RegistrationID, xmlMapping);
                break;
            case "SerialID":
                if (iteminstance.SerialID == null)
                    iteminstance.SerialID = new SerialIDType();
                SetField(iteminstance.SerialID, xmlMapping);
                break;
            case "AdditionalItemProperty":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty && !collMappingAdditionalItemProperty.HasNextNode)
                {
                    if (iteminstance.AdditionalItemProperty == null)
                        iteminstance.AdditionalItemProperty = new ItemPropertyType[collMappingAdditionalItemProperty.Quantity];

                    for (int i = 0; i < collMappingAdditionalItemProperty.Quantity; i++)
                    {
                        var row = iteminstance.AdditionalItemProperty[i] = new ItemPropertyType();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (iteminstance.AdditionalItemProperty == null)
                    {
                        iteminstance.AdditionalItemProperty = new ItemPropertyType[1];
                        iteminstance.AdditionalItemProperty[0] = new ItemPropertyType();
                    }
                    SetField(iteminstance.AdditionalItemProperty[0], xmlMapping);
                }
                break;
            case "LotIdentification":
                if (iteminstance.LotIdentification == null)
                    iteminstance.LotIdentification = new LotIdentificationType();
                SetField(iteminstance.LotIdentification, xmlMapping);
                break;

        }
    }
    public void SetField(LotIdentificationType lotidentification, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LotNumberID":
                if (lotidentification.LotNumberID == null)
                    lotidentification.LotNumberID = new LotNumberIDType();
                SetField(lotidentification.LotNumberID, xmlMapping);
                break;
            case "ExpiryDate":
                if (lotidentification.ExpiryDate == null)
                    lotidentification.ExpiryDate = new ExpiryDateType();
                SetField(lotidentification.ExpiryDate, xmlMapping);
                break;
            case "AdditionalItemProperty":
                if (xmlMapping is IXmlCollectionMapping collMappingAdditionalItemProperty && !collMappingAdditionalItemProperty.HasNextNode)
                {
                    if (lotidentification.AdditionalItemProperty == null)
                        lotidentification.AdditionalItemProperty = new ItemPropertyType[collMappingAdditionalItemProperty.Quantity];

                    for (int i = 0; i < collMappingAdditionalItemProperty.Quantity; i++)
                    {
                        var row = lotidentification.AdditionalItemProperty[i] = new ItemPropertyType();

                        foreach (var colMapp in collMappingAdditionalItemProperty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (lotidentification.AdditionalItemProperty == null)
                    {
                        lotidentification.AdditionalItemProperty = new ItemPropertyType[1];
                        lotidentification.AdditionalItemProperty[0] = new ItemPropertyType();
                    }
                    SetField(lotidentification.AdditionalItemProperty[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(CertificateType certificate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (certificate.ID == null)
                    certificate.ID = new IDType();
                SetField(certificate.ID, xmlMapping);
                break;
            case "CertificateTypeCode":
                if (certificate.CertificateTypeCode == null)
                    certificate.CertificateTypeCode = new CertificateTypeCodeType();
                SetField(certificate.CertificateTypeCode, xmlMapping);
                break;
            case "CertificateType1":
                if (certificate.CertificateType1 == null)
                    certificate.CertificateType1 = new CertificateTypeType();
                SetField(certificate.CertificateType1, xmlMapping);
                break;
            case "Remarks":
                if (xmlMapping is IXmlCollectionMapping collMappingRemarks && !collMappingRemarks.HasNextNode)
                {
                    if (certificate.Remarks == null)
                        certificate.Remarks = new RemarksType[collMappingRemarks.Quantity];

                    for (int i = 0; i < collMappingRemarks.Quantity; i++)
                    {
                        var row = certificate.Remarks[i] = new RemarksType();

                        foreach (var colMapp in collMappingRemarks.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (certificate.Remarks == null)
                    {
                        certificate.Remarks = new RemarksType[1];
                        certificate.Remarks[0] = new RemarksType();
                    }
                    SetField(certificate.Remarks[0], xmlMapping);
                }
                break;
            case "IssuerParty":
                if (certificate.IssuerParty == null)
                    certificate.IssuerParty = new PartyType();
                SetField(certificate.IssuerParty, xmlMapping);
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (certificate.DocumentReference == null)
                        certificate.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = certificate.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (certificate.DocumentReference == null)
                    {
                        certificate.DocumentReference = new DocumentReferenceType[1];
                        certificate.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(certificate.DocumentReference[0], xmlMapping);
                }
                break;
            case "Signature":
                if (xmlMapping is IXmlCollectionMapping collMappingSignature && !collMappingSignature.HasNextNode)
                {
                    if (certificate.Signature == null)
                        certificate.Signature = new SignatureType[collMappingSignature.Quantity];

                    for (int i = 0; i < collMappingSignature.Quantity; i++)
                    {
                        var row = certificate.Signature[i] = new SignatureType();

                        foreach (var colMapp in collMappingSignature.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (certificate.Signature == null)
                    {
                        certificate.Signature = new SignatureType[1];
                        certificate.Signature[0] = new SignatureType();
                    }
                    SetField(certificate.Signature[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(PackageType actualpackage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (actualpackage.ID == null)
                    actualpackage.ID = new IDType();
                SetField(actualpackage.ID, xmlMapping);
                break;
            case "Quantity":
                if (actualpackage.Quantity == null)
                    actualpackage.Quantity = new QuantityType2();
                SetField(actualpackage.Quantity, xmlMapping);
                break;
            case "ReturnableMaterialIndicator":
                if (actualpackage.ReturnableMaterialIndicator == null)
                    actualpackage.ReturnableMaterialIndicator = new ReturnableMaterialIndicatorType();
                SetField(actualpackage.ReturnableMaterialIndicator, xmlMapping);
                break;
            case "PackageLevelCode":
                if (actualpackage.PackageLevelCode == null)
                    actualpackage.PackageLevelCode = new PackageLevelCodeType();
                SetField(actualpackage.PackageLevelCode, xmlMapping);
                break;
            case "PackagingTypeCode":
                if (actualpackage.PackagingTypeCode == null)
                    actualpackage.PackagingTypeCode = new PackagingTypeCodeType();
                SetField(actualpackage.PackagingTypeCode, xmlMapping);
                break;
            case "PackingMaterial":
                if (xmlMapping is IXmlCollectionMapping collMappingPackingMaterial && !collMappingPackingMaterial.HasNextNode)
                {
                    if (actualpackage.PackingMaterial == null)
                        actualpackage.PackingMaterial = new PackingMaterialType[collMappingPackingMaterial.Quantity];

                    for (int i = 0; i < collMappingPackingMaterial.Quantity; i++)
                    {
                        var row = actualpackage.PackingMaterial[i] = new PackingMaterialType();

                        foreach (var colMapp in collMappingPackingMaterial.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (actualpackage.PackingMaterial == null)
                    {
                        actualpackage.PackingMaterial = new PackingMaterialType[1];
                        actualpackage.PackingMaterial[0] = new PackingMaterialType();
                    }
                    SetField(actualpackage.PackingMaterial[0], xmlMapping);
                }
                break;
            case "TraceID":
                if (actualpackage.TraceID == null)
                    actualpackage.TraceID = new TraceIDType();
                SetField(actualpackage.TraceID, xmlMapping);
                break;
            case "ContainedPackage":
                if (xmlMapping is IXmlCollectionMapping collMappingContainedPackage && !collMappingContainedPackage.HasNextNode)
                {
                    if (actualpackage.ContainedPackage == null)
                        actualpackage.ContainedPackage = new PackageType[collMappingContainedPackage.Quantity];

                    for (int i = 0; i < collMappingContainedPackage.Quantity; i++)
                    {
                        var row = actualpackage.ContainedPackage[i] = new PackageType();

                        foreach (var colMapp in collMappingContainedPackage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (actualpackage.ContainedPackage == null)
                    {
                        actualpackage.ContainedPackage = new PackageType[1];
                        actualpackage.ContainedPackage[0] = new PackageType();
                    }
                    SetField(actualpackage.ContainedPackage[0], xmlMapping);
                }
                break;
            case "ContainingTransportEquipment":
                if (actualpackage.ContainingTransportEquipment == null)
                    actualpackage.ContainingTransportEquipment = new TransportEquipmentType();
                SetField(actualpackage.ContainingTransportEquipment, xmlMapping);
                break;
            case "GoodsItem":
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItem && !collMappingGoodsItem.HasNextNode)
                {
                    if (actualpackage.GoodsItem == null)
                        actualpackage.GoodsItem = new GoodsItemType[collMappingGoodsItem.Quantity];

                    for (int i = 0; i < collMappingGoodsItem.Quantity; i++)
                    {
                        var row = actualpackage.GoodsItem[i] = new GoodsItemType();

                        foreach (var colMapp in collMappingGoodsItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (actualpackage.GoodsItem == null)
                    {
                        actualpackage.GoodsItem = new GoodsItemType[1];
                        actualpackage.GoodsItem[0] = new GoodsItemType();
                    }
                    SetField(actualpackage.GoodsItem[0], xmlMapping);
                }
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (actualpackage.MeasurementDimension == null)
                        actualpackage.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = actualpackage.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (actualpackage.MeasurementDimension == null)
                    {
                        actualpackage.MeasurementDimension = new DimensionType[1];
                        actualpackage.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(actualpackage.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "DeliveryUnit":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryUnit && !collMappingDeliveryUnit.HasNextNode)
                {
                    if (actualpackage.DeliveryUnit == null)
                        actualpackage.DeliveryUnit = new DeliveryUnitType[collMappingDeliveryUnit.Quantity];

                    for (int i = 0; i < collMappingDeliveryUnit.Quantity; i++)
                    {
                        var row = actualpackage.DeliveryUnit[i] = new DeliveryUnitType();

                        foreach (var colMapp in collMappingDeliveryUnit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (actualpackage.DeliveryUnit == null)
                    {
                        actualpackage.DeliveryUnit = new DeliveryUnitType[1];
                        actualpackage.DeliveryUnit[0] = new DeliveryUnitType();
                    }
                    SetField(actualpackage.DeliveryUnit[0], xmlMapping);
                }
                break;
            case "Delivery":
                if (actualpackage.Delivery == null)
                    actualpackage.Delivery = new DeliveryType();
                SetField(actualpackage.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (actualpackage.Pickup == null)
                    actualpackage.Pickup = new PickupType();
                SetField(actualpackage.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (actualpackage.Despatch == null)
                    actualpackage.Despatch = new DespatchType();
                SetField(actualpackage.Despatch, xmlMapping);
                break;

        }
    }
    public void SetField(GoodsItemType goodsitem, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (goodsitem.ID == null)
                    goodsitem.ID = new IDType();
                SetField(goodsitem.ID, xmlMapping);
                break;
            case "SequenceNumberID":
                if (goodsitem.SequenceNumberID == null)
                    goodsitem.SequenceNumberID = new SequenceNumberIDType();
                SetField(goodsitem.SequenceNumberID, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (goodsitem.Description == null)
                        goodsitem.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = goodsitem.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.Description == null)
                    {
                        goodsitem.Description = new DescriptionType[1];
                        goodsitem.Description[0] = new DescriptionType();
                    }
                    SetField(goodsitem.Description[0], xmlMapping);
                }
                break;
            case "HazardousRiskIndicator":
                if (goodsitem.HazardousRiskIndicator == null)
                    goodsitem.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(goodsitem.HazardousRiskIndicator, xmlMapping);
                break;
            case "DeclaredCustomsValueAmount":
                if (goodsitem.DeclaredCustomsValueAmount == null)
                    goodsitem.DeclaredCustomsValueAmount = new DeclaredCustomsValueAmountType();
                SetField(goodsitem.DeclaredCustomsValueAmount, xmlMapping);
                break;
            case "DeclaredForCarriageValueAmount":
                if (goodsitem.DeclaredForCarriageValueAmount == null)
                    goodsitem.DeclaredForCarriageValueAmount = new DeclaredForCarriageValueAmountType();
                SetField(goodsitem.DeclaredForCarriageValueAmount, xmlMapping);
                break;
            case "DeclaredStatisticsValueAmount":
                if (goodsitem.DeclaredStatisticsValueAmount == null)
                    goodsitem.DeclaredStatisticsValueAmount = new DeclaredStatisticsValueAmountType();
                SetField(goodsitem.DeclaredStatisticsValueAmount, xmlMapping);
                break;
            case "FreeOnBoardValueAmount":
                if (goodsitem.FreeOnBoardValueAmount == null)
                    goodsitem.FreeOnBoardValueAmount = new FreeOnBoardValueAmountType();
                SetField(goodsitem.FreeOnBoardValueAmount, xmlMapping);
                break;
            case "InsuranceValueAmount":
                if (goodsitem.InsuranceValueAmount == null)
                    goodsitem.InsuranceValueAmount = new InsuranceValueAmountType();
                SetField(goodsitem.InsuranceValueAmount, xmlMapping);
                break;
            case "ValueAmount":
                if (goodsitem.ValueAmount == null)
                    goodsitem.ValueAmount = new ValueAmountType();
                SetField(goodsitem.ValueAmount, xmlMapping);
                break;
            case "GrossWeightMeasure":
                if (goodsitem.GrossWeightMeasure == null)
                    goodsitem.GrossWeightMeasure = new GrossWeightMeasureType();
                SetField(goodsitem.GrossWeightMeasure, xmlMapping);
                break;
            case "NetWeightMeasure":
                if (goodsitem.NetWeightMeasure == null)
                    goodsitem.NetWeightMeasure = new NetWeightMeasureType();
                SetField(goodsitem.NetWeightMeasure, xmlMapping);
                break;
            case "NetNetWeightMeasure":
                if (goodsitem.NetNetWeightMeasure == null)
                    goodsitem.NetNetWeightMeasure = new NetNetWeightMeasureType();
                SetField(goodsitem.NetNetWeightMeasure, xmlMapping);
                break;
            case "ChargeableWeightMeasure":
                if (goodsitem.ChargeableWeightMeasure == null)
                    goodsitem.ChargeableWeightMeasure = new ChargeableWeightMeasureType();
                SetField(goodsitem.ChargeableWeightMeasure, xmlMapping);
                break;
            case "GrossVolumeMeasure":
                if (goodsitem.GrossVolumeMeasure == null)
                    goodsitem.GrossVolumeMeasure = new GrossVolumeMeasureType();
                SetField(goodsitem.GrossVolumeMeasure, xmlMapping);
                break;
            case "NetVolumeMeasure":
                if (goodsitem.NetVolumeMeasure == null)
                    goodsitem.NetVolumeMeasure = new NetVolumeMeasureType();
                SetField(goodsitem.NetVolumeMeasure, xmlMapping);
                break;
            case "Quantity":
                if (goodsitem.Quantity == null)
                    goodsitem.Quantity = new QuantityType2();
                SetField(goodsitem.Quantity, xmlMapping);
                break;
            case "PreferenceCriterionCode":
                if (goodsitem.PreferenceCriterionCode == null)
                    goodsitem.PreferenceCriterionCode = new PreferenceCriterionCodeType();
                SetField(goodsitem.PreferenceCriterionCode, xmlMapping);
                break;
            case "RequiredCustomsID":
                if (goodsitem.RequiredCustomsID == null)
                    goodsitem.RequiredCustomsID = new RequiredCustomsIDType();
                SetField(goodsitem.RequiredCustomsID, xmlMapping);
                break;
            case "CustomsStatusCode":
                if (goodsitem.CustomsStatusCode == null)
                    goodsitem.CustomsStatusCode = new CustomsStatusCodeType();
                SetField(goodsitem.CustomsStatusCode, xmlMapping);
                break;
            case "CustomsTariffQuantity":
                if (goodsitem.CustomsTariffQuantity == null)
                    goodsitem.CustomsTariffQuantity = new CustomsTariffQuantityType();
                SetField(goodsitem.CustomsTariffQuantity, xmlMapping);
                break;
            case "CustomsImportClassifiedIndicator":
                if (goodsitem.CustomsImportClassifiedIndicator == null)
                    goodsitem.CustomsImportClassifiedIndicator = new CustomsImportClassifiedIndicatorType();
                SetField(goodsitem.CustomsImportClassifiedIndicator, xmlMapping);
                break;
            case "ChargeableQuantity":
                if (goodsitem.ChargeableQuantity == null)
                    goodsitem.ChargeableQuantity = new ChargeableQuantityType();
                SetField(goodsitem.ChargeableQuantity, xmlMapping);
                break;
            case "ReturnableQuantity":
                if (goodsitem.ReturnableQuantity == null)
                    goodsitem.ReturnableQuantity = new ReturnableQuantityType();
                SetField(goodsitem.ReturnableQuantity, xmlMapping);
                break;
            case "TraceID":
                if (goodsitem.TraceID == null)
                    goodsitem.TraceID = new TraceIDType();
                SetField(goodsitem.TraceID, xmlMapping);
                break;
            case "Item":
                if (xmlMapping is IXmlCollectionMapping collMappingItem && !collMappingItem.HasNextNode)
                {
                    if (goodsitem.Item == null)
                        goodsitem.Item = new ItemType[collMappingItem.Quantity];

                    for (int i = 0; i < collMappingItem.Quantity; i++)
                    {
                        var row = goodsitem.Item[i] = new ItemType();

                        foreach (var colMapp in collMappingItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.Item == null)
                    {
                        goodsitem.Item = new ItemType[1];
                        goodsitem.Item[0] = new ItemType();
                    }
                    SetField(goodsitem.Item[0], xmlMapping);
                }
                break;
            case "GoodsItemContainer":
                if (xmlMapping is IXmlCollectionMapping collMappingGoodsItemContainer && !collMappingGoodsItemContainer.HasNextNode)
                {
                    if (goodsitem.GoodsItemContainer == null)
                        goodsitem.GoodsItemContainer = new GoodsItemContainerType[collMappingGoodsItemContainer.Quantity];

                    for (int i = 0; i < collMappingGoodsItemContainer.Quantity; i++)
                    {
                        var row = goodsitem.GoodsItemContainer[i] = new GoodsItemContainerType();

                        foreach (var colMapp in collMappingGoodsItemContainer.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.GoodsItemContainer == null)
                    {
                        goodsitem.GoodsItemContainer = new GoodsItemContainerType[1];
                        goodsitem.GoodsItemContainer[0] = new GoodsItemContainerType();
                    }
                    SetField(goodsitem.GoodsItemContainer[0], xmlMapping);
                }
                break;
            case "FreightAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge && !collMappingFreightAllowanceCharge.HasNextNode)
                {
                    if (goodsitem.FreightAllowanceCharge == null)
                        goodsitem.FreightAllowanceCharge = new AllowanceChargeType[collMappingFreightAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingFreightAllowanceCharge.Quantity; i++)
                    {
                        var row = goodsitem.FreightAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.FreightAllowanceCharge == null)
                    {
                        goodsitem.FreightAllowanceCharge = new AllowanceChargeType[1];
                        goodsitem.FreightAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(goodsitem.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "InvoiceLine":
                if (xmlMapping is IXmlCollectionMapping collMappingInvoiceLine && !collMappingInvoiceLine.HasNextNode)
                {
                    if (goodsitem.InvoiceLine == null)
                        goodsitem.InvoiceLine = new InvoiceLineType[collMappingInvoiceLine.Quantity];

                    for (int i = 0; i < collMappingInvoiceLine.Quantity; i++)
                    {
                        var row = goodsitem.InvoiceLine[i] = new InvoiceLineType();

                        foreach (var colMapp in collMappingInvoiceLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.InvoiceLine == null)
                    {
                        goodsitem.InvoiceLine = new InvoiceLineType[1];
                        goodsitem.InvoiceLine[0] = new InvoiceLineType();
                    }
                    SetField(goodsitem.InvoiceLine[0], xmlMapping);
                }
                break;
            case "Temperature":
                if (xmlMapping is IXmlCollectionMapping collMappingTemperature && !collMappingTemperature.HasNextNode)
                {
                    if (goodsitem.Temperature == null)
                        goodsitem.Temperature = new TemperatureType[collMappingTemperature.Quantity];

                    for (int i = 0; i < collMappingTemperature.Quantity; i++)
                    {
                        var row = goodsitem.Temperature[i] = new TemperatureType();

                        foreach (var colMapp in collMappingTemperature.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.Temperature == null)
                    {
                        goodsitem.Temperature = new TemperatureType[1];
                        goodsitem.Temperature[0] = new TemperatureType();
                    }
                    SetField(goodsitem.Temperature[0], xmlMapping);
                }
                break;
            case "ContainedGoodsItem":
                if (xmlMapping is IXmlCollectionMapping collMappingContainedGoodsItem && !collMappingContainedGoodsItem.HasNextNode)
                {
                    if (goodsitem.ContainedGoodsItem == null)
                        goodsitem.ContainedGoodsItem = new GoodsItemType[collMappingContainedGoodsItem.Quantity];

                    for (int i = 0; i < collMappingContainedGoodsItem.Quantity; i++)
                    {
                        var row = goodsitem.ContainedGoodsItem[i] = new GoodsItemType();

                        foreach (var colMapp in collMappingContainedGoodsItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.ContainedGoodsItem == null)
                    {
                        goodsitem.ContainedGoodsItem = new GoodsItemType[1];
                        goodsitem.ContainedGoodsItem[0] = new GoodsItemType();
                    }
                    SetField(goodsitem.ContainedGoodsItem[0], xmlMapping);
                }
                break;
            case "OriginAddress":
                if (goodsitem.OriginAddress == null)
                    goodsitem.OriginAddress = new AddressType();
                SetField(goodsitem.OriginAddress, xmlMapping);
                break;
            case "Delivery":
                if (goodsitem.Delivery == null)
                    goodsitem.Delivery = new DeliveryType();
                SetField(goodsitem.Delivery, xmlMapping);
                break;
            case "Pickup":
                if (goodsitem.Pickup == null)
                    goodsitem.Pickup = new PickupType();
                SetField(goodsitem.Pickup, xmlMapping);
                break;
            case "Despatch":
                if (goodsitem.Despatch == null)
                    goodsitem.Despatch = new DespatchType();
                SetField(goodsitem.Despatch, xmlMapping);
                break;
            case "MeasurementDimension":
                if (xmlMapping is IXmlCollectionMapping collMappingMeasurementDimension && !collMappingMeasurementDimension.HasNextNode)
                {
                    if (goodsitem.MeasurementDimension == null)
                        goodsitem.MeasurementDimension = new DimensionType[collMappingMeasurementDimension.Quantity];

                    for (int i = 0; i < collMappingMeasurementDimension.Quantity; i++)
                    {
                        var row = goodsitem.MeasurementDimension[i] = new DimensionType();

                        foreach (var colMapp in collMappingMeasurementDimension.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.MeasurementDimension == null)
                    {
                        goodsitem.MeasurementDimension = new DimensionType[1];
                        goodsitem.MeasurementDimension[0] = new DimensionType();
                    }
                    SetField(goodsitem.MeasurementDimension[0], xmlMapping);
                }
                break;
            case "ContainingPackage":
                if (xmlMapping is IXmlCollectionMapping collMappingContainingPackage && !collMappingContainingPackage.HasNextNode)
                {
                    if (goodsitem.ContainingPackage == null)
                        goodsitem.ContainingPackage = new PackageType[collMappingContainingPackage.Quantity];

                    for (int i = 0; i < collMappingContainingPackage.Quantity; i++)
                    {
                        var row = goodsitem.ContainingPackage[i] = new PackageType();

                        foreach (var colMapp in collMappingContainingPackage.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitem.ContainingPackage == null)
                    {
                        goodsitem.ContainingPackage = new PackageType[1];
                        goodsitem.ContainingPackage[0] = new PackageType();
                    }
                    SetField(goodsitem.ContainingPackage[0], xmlMapping);
                }
                break;
            case "ShipmentDocumentReference":
                if (goodsitem.ShipmentDocumentReference == null)
                    goodsitem.ShipmentDocumentReference = new DocumentReferenceType();
                SetField(goodsitem.ShipmentDocumentReference, xmlMapping);
                break;
            case "MinimumTemperature":
                if (goodsitem.MinimumTemperature == null)
                    goodsitem.MinimumTemperature = new TemperatureType();
                SetField(goodsitem.MinimumTemperature, xmlMapping);
                break;
            case "MaximumTemperature":
                if (goodsitem.MaximumTemperature == null)
                    goodsitem.MaximumTemperature = new TemperatureType();
                SetField(goodsitem.MaximumTemperature, xmlMapping);
                break;

        }
    }
    public void SetField(GoodsItemContainerType goodsitemcontainer, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (goodsitemcontainer.ID == null)
                    goodsitemcontainer.ID = new IDType();
                SetField(goodsitemcontainer.ID, xmlMapping);
                break;
            case "Quantity":
                if (goodsitemcontainer.Quantity == null)
                    goodsitemcontainer.Quantity = new QuantityType2();
                SetField(goodsitemcontainer.Quantity, xmlMapping);
                break;
            case "TransportEquipment":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEquipment && !collMappingTransportEquipment.HasNextNode)
                {
                    if (goodsitemcontainer.TransportEquipment == null)
                        goodsitemcontainer.TransportEquipment = new TransportEquipmentType[collMappingTransportEquipment.Quantity];

                    for (int i = 0; i < collMappingTransportEquipment.Quantity; i++)
                    {
                        var row = goodsitemcontainer.TransportEquipment[i] = new TransportEquipmentType();

                        foreach (var colMapp in collMappingTransportEquipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (goodsitemcontainer.TransportEquipment == null)
                    {
                        goodsitemcontainer.TransportEquipment = new TransportEquipmentType[1];
                        goodsitemcontainer.TransportEquipment[0] = new TransportEquipmentType();
                    }
                    SetField(goodsitemcontainer.TransportEquipment[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(InvoiceLineType invoiceline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (invoiceline.ID == null)
                    invoiceline.ID = new IDType();
                SetField(invoiceline.ID, xmlMapping);
                break;
            case "UUID":
                if (invoiceline.UUID == null)
                    invoiceline.UUID = new UUIDType();
                SetField(invoiceline.UUID, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (invoiceline.Note == null)
                        invoiceline.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = invoiceline.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.Note == null)
                    {
                        invoiceline.Note = new NoteType[1];
                        invoiceline.Note[0] = new NoteType();
                    }
                    SetField(invoiceline.Note[0], xmlMapping);
                }
                break;
            case "InvoicedQuantity":
                if (invoiceline.InvoicedQuantity == null)
                    invoiceline.InvoicedQuantity = new InvoicedQuantityType();
                SetField(invoiceline.InvoicedQuantity, xmlMapping);
                break;
            case "LineExtensionAmount":
                if (invoiceline.LineExtensionAmount == null)
                    invoiceline.LineExtensionAmount = new LineExtensionAmountType();
                SetField(invoiceline.LineExtensionAmount, xmlMapping);
                break;
            case "TaxPointDate":
                if (invoiceline.TaxPointDate == null)
                    invoiceline.TaxPointDate = new TaxPointDateType();
                SetField(invoiceline.TaxPointDate, xmlMapping);
                break;
            case "AccountingCostCode":
                if (invoiceline.AccountingCostCode == null)
                    invoiceline.AccountingCostCode = new AccountingCostCodeType();
                SetField(invoiceline.AccountingCostCode, xmlMapping);
                break;
            case "AccountingCost":
                if (invoiceline.AccountingCost == null)
                    invoiceline.AccountingCost = new AccountingCostType();
                SetField(invoiceline.AccountingCost, xmlMapping);
                break;
            case "PaymentPurposeCode":
                if (invoiceline.PaymentPurposeCode == null)
                    invoiceline.PaymentPurposeCode = new PaymentPurposeCodeType();
                SetField(invoiceline.PaymentPurposeCode, xmlMapping);
                break;
            case "FreeOfChargeIndicator":
                if (invoiceline.FreeOfChargeIndicator == null)
                    invoiceline.FreeOfChargeIndicator = new FreeOfChargeIndicatorType();
                SetField(invoiceline.FreeOfChargeIndicator, xmlMapping);
                break;
            case "InvoicePeriod":
                if (xmlMapping is IXmlCollectionMapping collMappingInvoicePeriod && !collMappingInvoicePeriod.HasNextNode)
                {
                    if (invoiceline.InvoicePeriod == null)
                        invoiceline.InvoicePeriod = new PeriodType[collMappingInvoicePeriod.Quantity];

                    for (int i = 0; i < collMappingInvoicePeriod.Quantity; i++)
                    {
                        var row = invoiceline.InvoicePeriod[i] = new PeriodType();

                        foreach (var colMapp in collMappingInvoicePeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.InvoicePeriod == null)
                    {
                        invoiceline.InvoicePeriod = new PeriodType[1];
                        invoiceline.InvoicePeriod[0] = new PeriodType();
                    }
                    SetField(invoiceline.InvoicePeriod[0], xmlMapping);
                }
                break;
            case "OrderLineReference":
                if (xmlMapping is IXmlCollectionMapping collMappingOrderLineReference && !collMappingOrderLineReference.HasNextNode)
                {
                    if (invoiceline.OrderLineReference == null)
                        invoiceline.OrderLineReference = new OrderLineReferenceType[collMappingOrderLineReference.Quantity];

                    for (int i = 0; i < collMappingOrderLineReference.Quantity; i++)
                    {
                        var row = invoiceline.OrderLineReference[i] = new OrderLineReferenceType();

                        foreach (var colMapp in collMappingOrderLineReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.OrderLineReference == null)
                    {
                        invoiceline.OrderLineReference = new OrderLineReferenceType[1];
                        invoiceline.OrderLineReference[0] = new OrderLineReferenceType();
                    }
                    SetField(invoiceline.OrderLineReference[0], xmlMapping);
                }
                break;
            case "DespatchLineReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchLineReference && !collMappingDespatchLineReference.HasNextNode)
                {
                    if (invoiceline.DespatchLineReference == null)
                        invoiceline.DespatchLineReference = new LineReferenceType[collMappingDespatchLineReference.Quantity];

                    for (int i = 0; i < collMappingDespatchLineReference.Quantity; i++)
                    {
                        var row = invoiceline.DespatchLineReference[i] = new LineReferenceType();

                        foreach (var colMapp in collMappingDespatchLineReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.DespatchLineReference == null)
                    {
                        invoiceline.DespatchLineReference = new LineReferenceType[1];
                        invoiceline.DespatchLineReference[0] = new LineReferenceType();
                    }
                    SetField(invoiceline.DespatchLineReference[0], xmlMapping);
                }
                break;
            case "ReceiptLineReference":
                if (xmlMapping is IXmlCollectionMapping collMappingReceiptLineReference && !collMappingReceiptLineReference.HasNextNode)
                {
                    if (invoiceline.ReceiptLineReference == null)
                        invoiceline.ReceiptLineReference = new LineReferenceType[collMappingReceiptLineReference.Quantity];

                    for (int i = 0; i < collMappingReceiptLineReference.Quantity; i++)
                    {
                        var row = invoiceline.ReceiptLineReference[i] = new LineReferenceType();

                        foreach (var colMapp in collMappingReceiptLineReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.ReceiptLineReference == null)
                    {
                        invoiceline.ReceiptLineReference = new LineReferenceType[1];
                        invoiceline.ReceiptLineReference[0] = new LineReferenceType();
                    }
                    SetField(invoiceline.ReceiptLineReference[0], xmlMapping);
                }
                break;
            case "BillingReference":
                if (xmlMapping is IXmlCollectionMapping collMappingBillingReference && !collMappingBillingReference.HasNextNode)
                {
                    if (invoiceline.BillingReference == null)
                        invoiceline.BillingReference = new BillingReferenceType[collMappingBillingReference.Quantity];

                    for (int i = 0; i < collMappingBillingReference.Quantity; i++)
                    {
                        var row = invoiceline.BillingReference[i] = new BillingReferenceType();

                        foreach (var colMapp in collMappingBillingReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.BillingReference == null)
                    {
                        invoiceline.BillingReference = new BillingReferenceType[1];
                        invoiceline.BillingReference[0] = new BillingReferenceType();
                    }
                    SetField(invoiceline.BillingReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (invoiceline.DocumentReference == null)
                        invoiceline.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = invoiceline.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.DocumentReference == null)
                    {
                        invoiceline.DocumentReference = new DocumentReferenceType[1];
                        invoiceline.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(invoiceline.DocumentReference[0], xmlMapping);
                }
                break;
            case "PricingReference":
                if (invoiceline.PricingReference == null)
                    invoiceline.PricingReference = new PricingReferenceType();
                SetField(invoiceline.PricingReference, xmlMapping);
                break;
            case "OriginatorParty":
                if (invoiceline.OriginatorParty == null)
                    invoiceline.OriginatorParty = new PartyType();
                SetField(invoiceline.OriginatorParty, xmlMapping);
                break;
            case "Delivery":
                if (xmlMapping is IXmlCollectionMapping collMappingDelivery && !collMappingDelivery.HasNextNode)
                {
                    if (invoiceline.Delivery == null)
                        invoiceline.Delivery = new DeliveryType[collMappingDelivery.Quantity];

                    for (int i = 0; i < collMappingDelivery.Quantity; i++)
                    {
                        var row = invoiceline.Delivery[i] = new DeliveryType();

                        foreach (var colMapp in collMappingDelivery.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.Delivery == null)
                    {
                        invoiceline.Delivery = new DeliveryType[1];
                        invoiceline.Delivery[0] = new DeliveryType();
                    }
                    SetField(invoiceline.Delivery[0], xmlMapping);
                }
                break;
            case "PaymentTerms":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentTerms && !collMappingPaymentTerms.HasNextNode)
                {
                    if (invoiceline.PaymentTerms == null)
                        invoiceline.PaymentTerms = new PaymentTermsType[collMappingPaymentTerms.Quantity];

                    for (int i = 0; i < collMappingPaymentTerms.Quantity; i++)
                    {
                        var row = invoiceline.PaymentTerms[i] = new PaymentTermsType();

                        foreach (var colMapp in collMappingPaymentTerms.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.PaymentTerms == null)
                    {
                        invoiceline.PaymentTerms = new PaymentTermsType[1];
                        invoiceline.PaymentTerms[0] = new PaymentTermsType();
                    }
                    SetField(invoiceline.PaymentTerms[0], xmlMapping);
                }
                break;
            case "AllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge && !collMappingAllowanceCharge.HasNextNode)
                {
                    if (invoiceline.AllowanceCharge == null)
                        invoiceline.AllowanceCharge = new AllowanceChargeType[collMappingAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingAllowanceCharge.Quantity; i++)
                    {
                        var row = invoiceline.AllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.AllowanceCharge == null)
                    {
                        invoiceline.AllowanceCharge = new AllowanceChargeType[1];
                        invoiceline.AllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(invoiceline.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "TaxTotal":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal && !collMappingTaxTotal.HasNextNode)
                {
                    if (invoiceline.TaxTotal == null)
                        invoiceline.TaxTotal = new TaxTotalType[collMappingTaxTotal.Quantity];

                    for (int i = 0; i < collMappingTaxTotal.Quantity; i++)
                    {
                        var row = invoiceline.TaxTotal[i] = new TaxTotalType();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.TaxTotal == null)
                    {
                        invoiceline.TaxTotal = new TaxTotalType[1];
                        invoiceline.TaxTotal[0] = new TaxTotalType();
                    }
                    SetField(invoiceline.TaxTotal[0], xmlMapping);
                }
                break;
            case "WithholdingTaxTotal":
                if (xmlMapping is IXmlCollectionMapping collMappingWithholdingTaxTotal && !collMappingWithholdingTaxTotal.HasNextNode)
                {
                    if (invoiceline.WithholdingTaxTotal == null)
                        invoiceline.WithholdingTaxTotal = new TaxTotalType[collMappingWithholdingTaxTotal.Quantity];

                    for (int i = 0; i < collMappingWithholdingTaxTotal.Quantity; i++)
                    {
                        var row = invoiceline.WithholdingTaxTotal[i] = new TaxTotalType();

                        foreach (var colMapp in collMappingWithholdingTaxTotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.WithholdingTaxTotal == null)
                    {
                        invoiceline.WithholdingTaxTotal = new TaxTotalType[1];
                        invoiceline.WithholdingTaxTotal[0] = new TaxTotalType();
                    }
                    SetField(invoiceline.WithholdingTaxTotal[0], xmlMapping);
                }
                break;
            case "Item":
                if (invoiceline.Item == null)
                    invoiceline.Item = new ItemType();
                SetField(invoiceline.Item, xmlMapping);
                break;
            case "Price":
                if (invoiceline.Price == null)
                    invoiceline.Price = new PriceType();
                SetField(invoiceline.Price, xmlMapping);
                break;
            case "DeliveryTerms":
                if (invoiceline.DeliveryTerms == null)
                    invoiceline.DeliveryTerms = new DeliveryTermsType();
                SetField(invoiceline.DeliveryTerms, xmlMapping);
                break;
            case "SubInvoiceLine":
                if (xmlMapping is IXmlCollectionMapping collMappingSubInvoiceLine && !collMappingSubInvoiceLine.HasNextNode)
                {
                    if (invoiceline.SubInvoiceLine == null)
                        invoiceline.SubInvoiceLine = new InvoiceLineType[collMappingSubInvoiceLine.Quantity];

                    for (int i = 0; i < collMappingSubInvoiceLine.Quantity; i++)
                    {
                        var row = invoiceline.SubInvoiceLine[i] = new InvoiceLineType();

                        foreach (var colMapp in collMappingSubInvoiceLine.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (invoiceline.SubInvoiceLine == null)
                    {
                        invoiceline.SubInvoiceLine = new InvoiceLineType[1];
                        invoiceline.SubInvoiceLine[0] = new InvoiceLineType();
                    }
                    SetField(invoiceline.SubInvoiceLine[0], xmlMapping);
                }
                break;
            case "ItemPriceExtension":
                if (invoiceline.ItemPriceExtension == null)
                    invoiceline.ItemPriceExtension = new PriceExtensionType();
                SetField(invoiceline.ItemPriceExtension, xmlMapping);
                break;

        }
    }
    public void SetField(LineReferenceType despatchlinereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineID":
                if (despatchlinereference.LineID == null)
                    despatchlinereference.LineID = new LineIDType();
                SetField(despatchlinereference.LineID, xmlMapping);
                break;
            case "UUID":
                if (despatchlinereference.UUID == null)
                    despatchlinereference.UUID = new UUIDType();
                SetField(despatchlinereference.UUID, xmlMapping);
                break;
            case "LineStatusCode":
                if (despatchlinereference.LineStatusCode == null)
                    despatchlinereference.LineStatusCode = new LineStatusCodeType();
                SetField(despatchlinereference.LineStatusCode, xmlMapping);
                break;
            case "DocumentReference":
                if (despatchlinereference.DocumentReference == null)
                    despatchlinereference.DocumentReference = new DocumentReferenceType();
                SetField(despatchlinereference.DocumentReference, xmlMapping);
                break;

        }
    }
    public void SetField(PricingReferenceType pricingreference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "OriginalItemLocationQuantity":
                if (pricingreference.OriginalItemLocationQuantity == null)
                    pricingreference.OriginalItemLocationQuantity = new ItemLocationQuantityType();
                SetField(pricingreference.OriginalItemLocationQuantity, xmlMapping);
                break;
            case "AlternativeConditionPrice":
                if (xmlMapping is IXmlCollectionMapping collMappingAlternativeConditionPrice && !collMappingAlternativeConditionPrice.HasNextNode)
                {
                    if (pricingreference.AlternativeConditionPrice == null)
                        pricingreference.AlternativeConditionPrice = new PriceType[collMappingAlternativeConditionPrice.Quantity];

                    for (int i = 0; i < collMappingAlternativeConditionPrice.Quantity; i++)
                    {
                        var row = pricingreference.AlternativeConditionPrice[i] = new PriceType();

                        foreach (var colMapp in collMappingAlternativeConditionPrice.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (pricingreference.AlternativeConditionPrice == null)
                    {
                        pricingreference.AlternativeConditionPrice = new PriceType[1];
                        pricingreference.AlternativeConditionPrice[0] = new PriceType();
                    }
                    SetField(pricingreference.AlternativeConditionPrice[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ItemLocationQuantityType originalitemlocationquantity, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LeadTimeMeasure":
                if (originalitemlocationquantity.LeadTimeMeasure == null)
                    originalitemlocationquantity.LeadTimeMeasure = new LeadTimeMeasureType();
                SetField(originalitemlocationquantity.LeadTimeMeasure, xmlMapping);
                break;
            case "MinimumQuantity":
                if (originalitemlocationquantity.MinimumQuantity == null)
                    originalitemlocationquantity.MinimumQuantity = new MinimumQuantityType();
                SetField(originalitemlocationquantity.MinimumQuantity, xmlMapping);
                break;
            case "MaximumQuantity":
                if (originalitemlocationquantity.MaximumQuantity == null)
                    originalitemlocationquantity.MaximumQuantity = new MaximumQuantityType();
                SetField(originalitemlocationquantity.MaximumQuantity, xmlMapping);
                break;
            case "HazardousRiskIndicator":
                if (originalitemlocationquantity.HazardousRiskIndicator == null)
                    originalitemlocationquantity.HazardousRiskIndicator = new HazardousRiskIndicatorType();
                SetField(originalitemlocationquantity.HazardousRiskIndicator, xmlMapping);
                break;
            case "TradingRestrictions":
                if (xmlMapping is IXmlCollectionMapping collMappingTradingRestrictions && !collMappingTradingRestrictions.HasNextNode)
                {
                    if (originalitemlocationquantity.TradingRestrictions == null)
                        originalitemlocationquantity.TradingRestrictions = new TradingRestrictionsType[collMappingTradingRestrictions.Quantity];

                    for (int i = 0; i < collMappingTradingRestrictions.Quantity; i++)
                    {
                        var row = originalitemlocationquantity.TradingRestrictions[i] = new TradingRestrictionsType();

                        foreach (var colMapp in collMappingTradingRestrictions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originalitemlocationquantity.TradingRestrictions == null)
                    {
                        originalitemlocationquantity.TradingRestrictions = new TradingRestrictionsType[1];
                        originalitemlocationquantity.TradingRestrictions[0] = new TradingRestrictionsType();
                    }
                    SetField(originalitemlocationquantity.TradingRestrictions[0], xmlMapping);
                }
                break;
            case "ApplicableTerritoryAddress":
                if (xmlMapping is IXmlCollectionMapping collMappingApplicableTerritoryAddress && !collMappingApplicableTerritoryAddress.HasNextNode)
                {
                    if (originalitemlocationquantity.ApplicableTerritoryAddress == null)
                        originalitemlocationquantity.ApplicableTerritoryAddress = new AddressType[collMappingApplicableTerritoryAddress.Quantity];

                    for (int i = 0; i < collMappingApplicableTerritoryAddress.Quantity; i++)
                    {
                        var row = originalitemlocationquantity.ApplicableTerritoryAddress[i] = new AddressType();

                        foreach (var colMapp in collMappingApplicableTerritoryAddress.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originalitemlocationquantity.ApplicableTerritoryAddress == null)
                    {
                        originalitemlocationquantity.ApplicableTerritoryAddress = new AddressType[1];
                        originalitemlocationquantity.ApplicableTerritoryAddress[0] = new AddressType();
                    }
                    SetField(originalitemlocationquantity.ApplicableTerritoryAddress[0], xmlMapping);
                }
                break;
            case "Price":
                if (originalitemlocationquantity.Price == null)
                    originalitemlocationquantity.Price = new PriceType();
                SetField(originalitemlocationquantity.Price, xmlMapping);
                break;
            case "DeliveryUnit":
                if (xmlMapping is IXmlCollectionMapping collMappingDeliveryUnit && !collMappingDeliveryUnit.HasNextNode)
                {
                    if (originalitemlocationquantity.DeliveryUnit == null)
                        originalitemlocationquantity.DeliveryUnit = new DeliveryUnitType[collMappingDeliveryUnit.Quantity];

                    for (int i = 0; i < collMappingDeliveryUnit.Quantity; i++)
                    {
                        var row = originalitemlocationquantity.DeliveryUnit[i] = new DeliveryUnitType();

                        foreach (var colMapp in collMappingDeliveryUnit.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originalitemlocationquantity.DeliveryUnit == null)
                    {
                        originalitemlocationquantity.DeliveryUnit = new DeliveryUnitType[1];
                        originalitemlocationquantity.DeliveryUnit[0] = new DeliveryUnitType();
                    }
                    SetField(originalitemlocationquantity.DeliveryUnit[0], xmlMapping);
                }
                break;
            case "ApplicableTaxCategory":
                if (xmlMapping is IXmlCollectionMapping collMappingApplicableTaxCategory && !collMappingApplicableTaxCategory.HasNextNode)
                {
                    if (originalitemlocationquantity.ApplicableTaxCategory == null)
                        originalitemlocationquantity.ApplicableTaxCategory = new TaxCategoryType[collMappingApplicableTaxCategory.Quantity];

                    for (int i = 0; i < collMappingApplicableTaxCategory.Quantity; i++)
                    {
                        var row = originalitemlocationquantity.ApplicableTaxCategory[i] = new TaxCategoryType();

                        foreach (var colMapp in collMappingApplicableTaxCategory.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originalitemlocationquantity.ApplicableTaxCategory == null)
                    {
                        originalitemlocationquantity.ApplicableTaxCategory = new TaxCategoryType[1];
                        originalitemlocationquantity.ApplicableTaxCategory[0] = new TaxCategoryType();
                    }
                    SetField(originalitemlocationquantity.ApplicableTaxCategory[0], xmlMapping);
                }
                break;
            case "Package":
                if (originalitemlocationquantity.Package == null)
                    originalitemlocationquantity.Package = new PackageType();
                SetField(originalitemlocationquantity.Package, xmlMapping);
                break;
            case "AllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge && !collMappingAllowanceCharge.HasNextNode)
                {
                    if (originalitemlocationquantity.AllowanceCharge == null)
                        originalitemlocationquantity.AllowanceCharge = new AllowanceChargeType[collMappingAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingAllowanceCharge.Quantity; i++)
                    {
                        var row = originalitemlocationquantity.AllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (originalitemlocationquantity.AllowanceCharge == null)
                    {
                        originalitemlocationquantity.AllowanceCharge = new AllowanceChargeType[1];
                        originalitemlocationquantity.AllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(originalitemlocationquantity.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "DependentPriceReference":
                if (originalitemlocationquantity.DependentPriceReference == null)
                    originalitemlocationquantity.DependentPriceReference = new DependentPriceReferenceType();
                SetField(originalitemlocationquantity.DependentPriceReference, xmlMapping);
                break;

        }
    }
    public void SetField(PriceType price, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "PriceAmount":
                if (price.PriceAmount == null)
                    price.PriceAmount = new PriceAmountType();
                SetField(price.PriceAmount, xmlMapping);
                break;
            case "BaseQuantity":
                if (price.BaseQuantity == null)
                    price.BaseQuantity = new BaseQuantityType();
                SetField(price.BaseQuantity, xmlMapping);
                break;
            case "PriceChangeReason":
                if (xmlMapping is IXmlCollectionMapping collMappingPriceChangeReason && !collMappingPriceChangeReason.HasNextNode)
                {
                    if (price.PriceChangeReason == null)
                        price.PriceChangeReason = new PriceChangeReasonType[collMappingPriceChangeReason.Quantity];

                    for (int i = 0; i < collMappingPriceChangeReason.Quantity; i++)
                    {
                        var row = price.PriceChangeReason[i] = new PriceChangeReasonType();

                        foreach (var colMapp in collMappingPriceChangeReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (price.PriceChangeReason == null)
                    {
                        price.PriceChangeReason = new PriceChangeReasonType[1];
                        price.PriceChangeReason[0] = new PriceChangeReasonType();
                    }
                    SetField(price.PriceChangeReason[0], xmlMapping);
                }
                break;
            case "PriceTypeCode":
                if (price.PriceTypeCode == null)
                    price.PriceTypeCode = new PriceTypeCodeType();
                SetField(price.PriceTypeCode, xmlMapping);
                break;
            case "PriceType1":
                if (price.PriceType1 == null)
                    price.PriceType1 = new PriceTypeType();
                SetField(price.PriceType1, xmlMapping);
                break;
            case "OrderableUnitFactorRate":
                if (price.OrderableUnitFactorRate == null)
                    price.OrderableUnitFactorRate = new OrderableUnitFactorRateType();
                SetField(price.OrderableUnitFactorRate, xmlMapping);
                break;
            case "ValidityPeriod":
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod && !collMappingValidityPeriod.HasNextNode)
                {
                    if (price.ValidityPeriod == null)
                        price.ValidityPeriod = new PeriodType[collMappingValidityPeriod.Quantity];

                    for (int i = 0; i < collMappingValidityPeriod.Quantity; i++)
                    {
                        var row = price.ValidityPeriod[i] = new PeriodType();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (price.ValidityPeriod == null)
                    {
                        price.ValidityPeriod = new PeriodType[1];
                        price.ValidityPeriod[0] = new PeriodType();
                    }
                    SetField(price.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "PriceList":
                if (price.PriceList == null)
                    price.PriceList = new PriceListType();
                SetField(price.PriceList, xmlMapping);
                break;
            case "AllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingAllowanceCharge && !collMappingAllowanceCharge.HasNextNode)
                {
                    if (price.AllowanceCharge == null)
                        price.AllowanceCharge = new AllowanceChargeType[collMappingAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingAllowanceCharge.Quantity; i++)
                    {
                        var row = price.AllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (price.AllowanceCharge == null)
                    {
                        price.AllowanceCharge = new AllowanceChargeType[1];
                        price.AllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(price.AllowanceCharge[0], xmlMapping);
                }
                break;
            case "PricingExchangeRate":
                if (price.PricingExchangeRate == null)
                    price.PricingExchangeRate = new ExchangeRateType();
                SetField(price.PricingExchangeRate, xmlMapping);
                break;

        }
    }
    public void SetField(PriceListType pricelist, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (pricelist.ID == null)
                    pricelist.ID = new IDType();
                SetField(pricelist.ID, xmlMapping);
                break;
            case "StatusCode":
                if (pricelist.StatusCode == null)
                    pricelist.StatusCode = new StatusCodeType();
                SetField(pricelist.StatusCode, xmlMapping);
                break;
            case "ValidityPeriod":
                if (xmlMapping is IXmlCollectionMapping collMappingValidityPeriod && !collMappingValidityPeriod.HasNextNode)
                {
                    if (pricelist.ValidityPeriod == null)
                        pricelist.ValidityPeriod = new PeriodType[collMappingValidityPeriod.Quantity];

                    for (int i = 0; i < collMappingValidityPeriod.Quantity; i++)
                    {
                        var row = pricelist.ValidityPeriod[i] = new PeriodType();

                        foreach (var colMapp in collMappingValidityPeriod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (pricelist.ValidityPeriod == null)
                    {
                        pricelist.ValidityPeriod = new PeriodType[1];
                        pricelist.ValidityPeriod[0] = new PeriodType();
                    }
                    SetField(pricelist.ValidityPeriod[0], xmlMapping);
                }
                break;
            case "PreviousPriceList":
                if (pricelist.PreviousPriceList == null)
                    pricelist.PreviousPriceList = new PriceListType();
                SetField(pricelist.PreviousPriceList, xmlMapping);
                break;

        }
    }
    public void SetField(ExchangeRateType pricingexchangerate, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "SourceCurrencyCode":
                if (pricingexchangerate.SourceCurrencyCode == null)
                    pricingexchangerate.SourceCurrencyCode = new SourceCurrencyCodeType();
                SetField(pricingexchangerate.SourceCurrencyCode, xmlMapping);
                break;
            case "SourceCurrencyBaseRate":
                if (pricingexchangerate.SourceCurrencyBaseRate == null)
                    pricingexchangerate.SourceCurrencyBaseRate = new SourceCurrencyBaseRateType();
                SetField(pricingexchangerate.SourceCurrencyBaseRate, xmlMapping);
                break;
            case "TargetCurrencyCode":
                if (pricingexchangerate.TargetCurrencyCode == null)
                    pricingexchangerate.TargetCurrencyCode = new TargetCurrencyCodeType();
                SetField(pricingexchangerate.TargetCurrencyCode, xmlMapping);
                break;
            case "TargetCurrencyBaseRate":
                if (pricingexchangerate.TargetCurrencyBaseRate == null)
                    pricingexchangerate.TargetCurrencyBaseRate = new TargetCurrencyBaseRateType();
                SetField(pricingexchangerate.TargetCurrencyBaseRate, xmlMapping);
                break;
            case "ExchangeMarketID":
                if (pricingexchangerate.ExchangeMarketID == null)
                    pricingexchangerate.ExchangeMarketID = new ExchangeMarketIDType();
                SetField(pricingexchangerate.ExchangeMarketID, xmlMapping);
                break;
            case "CalculationRate":
                if (pricingexchangerate.CalculationRate == null)
                    pricingexchangerate.CalculationRate = new CalculationRateType();
                SetField(pricingexchangerate.CalculationRate, xmlMapping);
                break;
            case "MathematicOperatorCode":
                if (pricingexchangerate.MathematicOperatorCode == null)
                    pricingexchangerate.MathematicOperatorCode = new MathematicOperatorCodeType();
                SetField(pricingexchangerate.MathematicOperatorCode, xmlMapping);
                break;
            case "Date":
                if (pricingexchangerate.Date == null)
                    pricingexchangerate.Date = new DateType1();
                SetField(pricingexchangerate.Date, xmlMapping);
                break;
            case "ForeignExchangeContract":
                if (pricingexchangerate.ForeignExchangeContract == null)
                    pricingexchangerate.ForeignExchangeContract = new ContractType();
                SetField(pricingexchangerate.ForeignExchangeContract, xmlMapping);
                break;

        }
    }
    public void SetField(DependentPriceReferenceType dependentpricereference, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Percent":
                if (dependentpricereference.Percent == null)
                    dependentpricereference.Percent = new PercentType1();
                SetField(dependentpricereference.Percent, xmlMapping);
                break;
            case "LocationAddress":
                if (dependentpricereference.LocationAddress == null)
                    dependentpricereference.LocationAddress = new AddressType();
                SetField(dependentpricereference.LocationAddress, xmlMapping);
                break;
            case "DependentLineReference":
                if (dependentpricereference.DependentLineReference == null)
                    dependentpricereference.DependentLineReference = new LineReferenceType();
                SetField(dependentpricereference.DependentLineReference, xmlMapping);
                break;

        }
    }
    public void SetField(PaymentTermsType paymentterms, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (paymentterms.ID == null)
                    paymentterms.ID = new IDType();
                SetField(paymentterms.ID, xmlMapping);
                break;
            case "PaymentMeansID":
                if (xmlMapping is IXmlCollectionMapping collMappingPaymentMeansID && !collMappingPaymentMeansID.HasNextNode)
                {
                    if (paymentterms.PaymentMeansID == null)
                        paymentterms.PaymentMeansID = new PaymentMeansIDType[collMappingPaymentMeansID.Quantity];

                    for (int i = 0; i < collMappingPaymentMeansID.Quantity; i++)
                    {
                        var row = paymentterms.PaymentMeansID[i] = new PaymentMeansIDType();

                        foreach (var colMapp in collMappingPaymentMeansID.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (paymentterms.PaymentMeansID == null)
                    {
                        paymentterms.PaymentMeansID = new PaymentMeansIDType[1];
                        paymentterms.PaymentMeansID[0] = new PaymentMeansIDType();
                    }
                    SetField(paymentterms.PaymentMeansID[0], xmlMapping);
                }
                break;
            case "PrepaidPaymentReferenceID":
                if (paymentterms.PrepaidPaymentReferenceID == null)
                    paymentterms.PrepaidPaymentReferenceID = new PrepaidPaymentReferenceIDType();
                SetField(paymentterms.PrepaidPaymentReferenceID, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (paymentterms.Note == null)
                        paymentterms.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = paymentterms.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (paymentterms.Note == null)
                    {
                        paymentterms.Note = new NoteType[1];
                        paymentterms.Note[0] = new NoteType();
                    }
                    SetField(paymentterms.Note[0], xmlMapping);
                }
                break;
            case "ReferenceEventCode":
                if (paymentterms.ReferenceEventCode == null)
                    paymentterms.ReferenceEventCode = new ReferenceEventCodeType();
                SetField(paymentterms.ReferenceEventCode, xmlMapping);
                break;
            case "SettlementDiscountPercent":
                if (paymentterms.SettlementDiscountPercent == null)
                    paymentterms.SettlementDiscountPercent = new SettlementDiscountPercentType();
                SetField(paymentterms.SettlementDiscountPercent, xmlMapping);
                break;
            case "PenaltySurchargePercent":
                if (paymentterms.PenaltySurchargePercent == null)
                    paymentterms.PenaltySurchargePercent = new PenaltySurchargePercentType();
                SetField(paymentterms.PenaltySurchargePercent, xmlMapping);
                break;
            case "PaymentPercent":
                if (paymentterms.PaymentPercent == null)
                    paymentterms.PaymentPercent = new PaymentPercentType();
                SetField(paymentterms.PaymentPercent, xmlMapping);
                break;
            case "Amount":
                if (paymentterms.Amount == null)
                    paymentterms.Amount = new AmountType2();
                SetField(paymentterms.Amount, xmlMapping);
                break;
            case "SettlementDiscountAmount":
                if (paymentterms.SettlementDiscountAmount == null)
                    paymentterms.SettlementDiscountAmount = new SettlementDiscountAmountType();
                SetField(paymentterms.SettlementDiscountAmount, xmlMapping);
                break;
            case "PenaltyAmount":
                if (paymentterms.PenaltyAmount == null)
                    paymentterms.PenaltyAmount = new PenaltyAmountType();
                SetField(paymentterms.PenaltyAmount, xmlMapping);
                break;
            case "PaymentTermsDetailsURI":
                if (paymentterms.PaymentTermsDetailsURI == null)
                    paymentterms.PaymentTermsDetailsURI = new PaymentTermsDetailsURIType();
                SetField(paymentterms.PaymentTermsDetailsURI, xmlMapping);
                break;
            case "PaymentDueDate":
                if (paymentterms.PaymentDueDate == null)
                    paymentterms.PaymentDueDate = new PaymentDueDateType();
                SetField(paymentterms.PaymentDueDate, xmlMapping);
                break;
            case "InstallmentDueDate":
                if (paymentterms.InstallmentDueDate == null)
                    paymentterms.InstallmentDueDate = new InstallmentDueDateType();
                SetField(paymentterms.InstallmentDueDate, xmlMapping);
                break;
            case "InvoicingPartyReference":
                if (paymentterms.InvoicingPartyReference == null)
                    paymentterms.InvoicingPartyReference = new InvoicingPartyReferenceType();
                SetField(paymentterms.InvoicingPartyReference, xmlMapping);
                break;
            case "SettlementPeriod":
                if (paymentterms.SettlementPeriod == null)
                    paymentterms.SettlementPeriod = new PeriodType();
                SetField(paymentterms.SettlementPeriod, xmlMapping);
                break;
            case "PenaltyPeriod":
                if (paymentterms.PenaltyPeriod == null)
                    paymentterms.PenaltyPeriod = new PeriodType();
                SetField(paymentterms.PenaltyPeriod, xmlMapping);
                break;
            case "ExchangeRate":
                if (paymentterms.ExchangeRate == null)
                    paymentterms.ExchangeRate = new ExchangeRateType();
                SetField(paymentterms.ExchangeRate, xmlMapping);
                break;
            case "ValidityPeriod":
                if (paymentterms.ValidityPeriod == null)
                    paymentterms.ValidityPeriod = new PeriodType();
                SetField(paymentterms.ValidityPeriod, xmlMapping);
                break;

        }
    }
    public void SetField(PriceExtensionType itempriceextension, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "Amount":
                if (itempriceextension.Amount == null)
                    itempriceextension.Amount = new AmountType2();
                SetField(itempriceextension.Amount, xmlMapping);
                break;
            case "TaxTotal":
                if (xmlMapping is IXmlCollectionMapping collMappingTaxTotal && !collMappingTaxTotal.HasNextNode)
                {
                    if (itempriceextension.TaxTotal == null)
                        itempriceextension.TaxTotal = new TaxTotalType[collMappingTaxTotal.Quantity];

                    for (int i = 0; i < collMappingTaxTotal.Quantity; i++)
                    {
                        var row = itempriceextension.TaxTotal[i] = new TaxTotalType();

                        foreach (var colMapp in collMappingTaxTotal.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (itempriceextension.TaxTotal == null)
                    {
                        itempriceextension.TaxTotal = new TaxTotalType[1];
                        itempriceextension.TaxTotal[0] = new TaxTotalType();
                    }
                    SetField(itempriceextension.TaxTotal[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(PickupType pickup, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (pickup.ID == null)
                    pickup.ID = new IDType();
                SetField(pickup.ID, xmlMapping);
                break;
            case "ActualPickupDate":
                if (pickup.ActualPickupDate == null)
                    pickup.ActualPickupDate = new ActualPickupDateType();
                SetField(pickup.ActualPickupDate, xmlMapping);
                break;
            case "ActualPickupTime":
                if (pickup.ActualPickupTime == null)
                    pickup.ActualPickupTime = new ActualPickupTimeType();
                SetField(pickup.ActualPickupTime, xmlMapping);
                break;
            case "EarliestPickupDate":
                if (pickup.EarliestPickupDate == null)
                    pickup.EarliestPickupDate = new EarliestPickupDateType();
                SetField(pickup.EarliestPickupDate, xmlMapping);
                break;
            case "EarliestPickupTime":
                if (pickup.EarliestPickupTime == null)
                    pickup.EarliestPickupTime = new EarliestPickupTimeType();
                SetField(pickup.EarliestPickupTime, xmlMapping);
                break;
            case "LatestPickupDate":
                if (pickup.LatestPickupDate == null)
                    pickup.LatestPickupDate = new LatestPickupDateType();
                SetField(pickup.LatestPickupDate, xmlMapping);
                break;
            case "LatestPickupTime":
                if (pickup.LatestPickupTime == null)
                    pickup.LatestPickupTime = new LatestPickupTimeType();
                SetField(pickup.LatestPickupTime, xmlMapping);
                break;
            case "PickupLocation":
                if (pickup.PickupLocation == null)
                    pickup.PickupLocation = new LocationType1();
                SetField(pickup.PickupLocation, xmlMapping);
                break;
            case "PickupParty":
                if (pickup.PickupParty == null)
                    pickup.PickupParty = new PartyType();
                SetField(pickup.PickupParty, xmlMapping);
                break;

        }
    }
    public void SetField(ReceiptLineType receivedhandlingunitreceiptline, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (receivedhandlingunitreceiptline.ID == null)
                    receivedhandlingunitreceiptline.ID = new IDType();
                SetField(receivedhandlingunitreceiptline.ID, xmlMapping);
                break;
            case "UUID":
                if (receivedhandlingunitreceiptline.UUID == null)
                    receivedhandlingunitreceiptline.UUID = new UUIDType();
                SetField(receivedhandlingunitreceiptline.UUID, xmlMapping);
                break;
            case "Note":
                if (xmlMapping is IXmlCollectionMapping collMappingNote && !collMappingNote.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.Note == null)
                        receivedhandlingunitreceiptline.Note = new NoteType[collMappingNote.Quantity];

                    for (int i = 0; i < collMappingNote.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.Note[i] = new NoteType();

                        foreach (var colMapp in collMappingNote.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.Note == null)
                    {
                        receivedhandlingunitreceiptline.Note = new NoteType[1];
                        receivedhandlingunitreceiptline.Note[0] = new NoteType();
                    }
                    SetField(receivedhandlingunitreceiptline.Note[0], xmlMapping);
                }
                break;
            case "ReceivedQuantity":
                if (receivedhandlingunitreceiptline.ReceivedQuantity == null)
                    receivedhandlingunitreceiptline.ReceivedQuantity = new ReceivedQuantityType();
                SetField(receivedhandlingunitreceiptline.ReceivedQuantity, xmlMapping);
                break;
            case "ShortQuantity":
                if (receivedhandlingunitreceiptline.ShortQuantity == null)
                    receivedhandlingunitreceiptline.ShortQuantity = new ShortQuantityType();
                SetField(receivedhandlingunitreceiptline.ShortQuantity, xmlMapping);
                break;
            case "ShortageActionCode":
                if (receivedhandlingunitreceiptline.ShortageActionCode == null)
                    receivedhandlingunitreceiptline.ShortageActionCode = new ShortageActionCodeType();
                SetField(receivedhandlingunitreceiptline.ShortageActionCode, xmlMapping);
                break;
            case "RejectedQuantity":
                if (receivedhandlingunitreceiptline.RejectedQuantity == null)
                    receivedhandlingunitreceiptline.RejectedQuantity = new RejectedQuantityType();
                SetField(receivedhandlingunitreceiptline.RejectedQuantity, xmlMapping);
                break;
            case "RejectReasonCode":
                if (receivedhandlingunitreceiptline.RejectReasonCode == null)
                    receivedhandlingunitreceiptline.RejectReasonCode = new RejectReasonCodeType();
                SetField(receivedhandlingunitreceiptline.RejectReasonCode, xmlMapping);
                break;
            case "RejectReason":
                if (xmlMapping is IXmlCollectionMapping collMappingRejectReason && !collMappingRejectReason.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.RejectReason == null)
                        receivedhandlingunitreceiptline.RejectReason = new RejectReasonType[collMappingRejectReason.Quantity];

                    for (int i = 0; i < collMappingRejectReason.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.RejectReason[i] = new RejectReasonType();

                        foreach (var colMapp in collMappingRejectReason.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.RejectReason == null)
                    {
                        receivedhandlingunitreceiptline.RejectReason = new RejectReasonType[1];
                        receivedhandlingunitreceiptline.RejectReason[0] = new RejectReasonType();
                    }
                    SetField(receivedhandlingunitreceiptline.RejectReason[0], xmlMapping);
                }
                break;
            case "RejectActionCode":
                if (receivedhandlingunitreceiptline.RejectActionCode == null)
                    receivedhandlingunitreceiptline.RejectActionCode = new RejectActionCodeType();
                SetField(receivedhandlingunitreceiptline.RejectActionCode, xmlMapping);
                break;
            case "QuantityDiscrepancyCode":
                if (receivedhandlingunitreceiptline.QuantityDiscrepancyCode == null)
                    receivedhandlingunitreceiptline.QuantityDiscrepancyCode = new QuantityDiscrepancyCodeType();
                SetField(receivedhandlingunitreceiptline.QuantityDiscrepancyCode, xmlMapping);
                break;
            case "OversupplyQuantity":
                if (receivedhandlingunitreceiptline.OversupplyQuantity == null)
                    receivedhandlingunitreceiptline.OversupplyQuantity = new OversupplyQuantityType();
                SetField(receivedhandlingunitreceiptline.OversupplyQuantity, xmlMapping);
                break;
            case "ReceivedDate":
                if (receivedhandlingunitreceiptline.ReceivedDate == null)
                    receivedhandlingunitreceiptline.ReceivedDate = new ReceivedDateType();
                SetField(receivedhandlingunitreceiptline.ReceivedDate, xmlMapping);
                break;
            case "TimingComplaintCode":
                if (receivedhandlingunitreceiptline.TimingComplaintCode == null)
                    receivedhandlingunitreceiptline.TimingComplaintCode = new TimingComplaintCodeType();
                SetField(receivedhandlingunitreceiptline.TimingComplaintCode, xmlMapping);
                break;
            case "TimingComplaint":
                if (receivedhandlingunitreceiptline.TimingComplaint == null)
                    receivedhandlingunitreceiptline.TimingComplaint = new TimingComplaintType();
                SetField(receivedhandlingunitreceiptline.TimingComplaint, xmlMapping);
                break;
            case "OrderLineReference":
                if (receivedhandlingunitreceiptline.OrderLineReference == null)
                    receivedhandlingunitreceiptline.OrderLineReference = new OrderLineReferenceType();
                SetField(receivedhandlingunitreceiptline.OrderLineReference, xmlMapping);
                break;
            case "DespatchLineReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDespatchLineReference && !collMappingDespatchLineReference.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.DespatchLineReference == null)
                        receivedhandlingunitreceiptline.DespatchLineReference = new LineReferenceType[collMappingDespatchLineReference.Quantity];

                    for (int i = 0; i < collMappingDespatchLineReference.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.DespatchLineReference[i] = new LineReferenceType();

                        foreach (var colMapp in collMappingDespatchLineReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.DespatchLineReference == null)
                    {
                        receivedhandlingunitreceiptline.DespatchLineReference = new LineReferenceType[1];
                        receivedhandlingunitreceiptline.DespatchLineReference[0] = new LineReferenceType();
                    }
                    SetField(receivedhandlingunitreceiptline.DespatchLineReference[0], xmlMapping);
                }
                break;
            case "DocumentReference":
                if (xmlMapping is IXmlCollectionMapping collMappingDocumentReference && !collMappingDocumentReference.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.DocumentReference == null)
                        receivedhandlingunitreceiptline.DocumentReference = new DocumentReferenceType[collMappingDocumentReference.Quantity];

                    for (int i = 0; i < collMappingDocumentReference.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.DocumentReference[i] = new DocumentReferenceType();

                        foreach (var colMapp in collMappingDocumentReference.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.DocumentReference == null)
                    {
                        receivedhandlingunitreceiptline.DocumentReference = new DocumentReferenceType[1];
                        receivedhandlingunitreceiptline.DocumentReference[0] = new DocumentReferenceType();
                    }
                    SetField(receivedhandlingunitreceiptline.DocumentReference[0], xmlMapping);
                }
                break;
            case "Item":
                if (xmlMapping is IXmlCollectionMapping collMappingItem && !collMappingItem.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.Item == null)
                        receivedhandlingunitreceiptline.Item = new ItemType[collMappingItem.Quantity];

                    for (int i = 0; i < collMappingItem.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.Item[i] = new ItemType();

                        foreach (var colMapp in collMappingItem.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.Item == null)
                    {
                        receivedhandlingunitreceiptline.Item = new ItemType[1];
                        receivedhandlingunitreceiptline.Item[0] = new ItemType();
                    }
                    SetField(receivedhandlingunitreceiptline.Item[0], xmlMapping);
                }
                break;
            case "Shipment":
                if (xmlMapping is IXmlCollectionMapping collMappingShipment && !collMappingShipment.HasNextNode)
                {
                    if (receivedhandlingunitreceiptline.Shipment == null)
                        receivedhandlingunitreceiptline.Shipment = new ShipmentType[collMappingShipment.Quantity];

                    for (int i = 0; i < collMappingShipment.Quantity; i++)
                    {
                        var row = receivedhandlingunitreceiptline.Shipment[i] = new ShipmentType();

                        foreach (var colMapp in collMappingShipment.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (receivedhandlingunitreceiptline.Shipment == null)
                    {
                        receivedhandlingunitreceiptline.Shipment = new ShipmentType[1];
                        receivedhandlingunitreceiptline.Shipment[0] = new ShipmentType();
                    }
                    SetField(receivedhandlingunitreceiptline.Shipment[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(ShipmentStageType shipmentstage, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (shipmentstage.ID == null)
                    shipmentstage.ID = new IDType();
                SetField(shipmentstage.ID, xmlMapping);
                break;
            case "TransportModeCode":
                if (shipmentstage.TransportModeCode == null)
                    shipmentstage.TransportModeCode = new TransportModeCodeType();
                SetField(shipmentstage.TransportModeCode, xmlMapping);
                break;
            case "TransportMeansTypeCode":
                if (shipmentstage.TransportMeansTypeCode == null)
                    shipmentstage.TransportMeansTypeCode = new TransportMeansTypeCodeType();
                SetField(shipmentstage.TransportMeansTypeCode, xmlMapping);
                break;
            case "TransitDirectionCode":
                if (shipmentstage.TransitDirectionCode == null)
                    shipmentstage.TransitDirectionCode = new TransitDirectionCodeType();
                SetField(shipmentstage.TransitDirectionCode, xmlMapping);
                break;
            case "PreCarriageIndicator":
                if (shipmentstage.PreCarriageIndicator == null)
                    shipmentstage.PreCarriageIndicator = new PreCarriageIndicatorType();
                SetField(shipmentstage.PreCarriageIndicator, xmlMapping);
                break;
            case "OnCarriageIndicator":
                if (shipmentstage.OnCarriageIndicator == null)
                    shipmentstage.OnCarriageIndicator = new OnCarriageIndicatorType();
                SetField(shipmentstage.OnCarriageIndicator, xmlMapping);
                break;
            case "EstimatedDeliveryDate":
                if (shipmentstage.EstimatedDeliveryDate == null)
                    shipmentstage.EstimatedDeliveryDate = new EstimatedDeliveryDateType();
                SetField(shipmentstage.EstimatedDeliveryDate, xmlMapping);
                break;
            case "EstimatedDeliveryTime":
                if (shipmentstage.EstimatedDeliveryTime == null)
                    shipmentstage.EstimatedDeliveryTime = new EstimatedDeliveryTimeType();
                SetField(shipmentstage.EstimatedDeliveryTime, xmlMapping);
                break;
            case "RequiredDeliveryDate":
                if (shipmentstage.RequiredDeliveryDate == null)
                    shipmentstage.RequiredDeliveryDate = new RequiredDeliveryDateType();
                SetField(shipmentstage.RequiredDeliveryDate, xmlMapping);
                break;
            case "RequiredDeliveryTime":
                if (shipmentstage.RequiredDeliveryTime == null)
                    shipmentstage.RequiredDeliveryTime = new RequiredDeliveryTimeType();
                SetField(shipmentstage.RequiredDeliveryTime, xmlMapping);
                break;
            case "LoadingSequenceID":
                if (shipmentstage.LoadingSequenceID == null)
                    shipmentstage.LoadingSequenceID = new LoadingSequenceIDType();
                SetField(shipmentstage.LoadingSequenceID, xmlMapping);
                break;
            case "SuccessiveSequenceID":
                if (shipmentstage.SuccessiveSequenceID == null)
                    shipmentstage.SuccessiveSequenceID = new SuccessiveSequenceIDType();
                SetField(shipmentstage.SuccessiveSequenceID, xmlMapping);
                break;
            case "Instructions":
                if (xmlMapping is IXmlCollectionMapping collMappingInstructions && !collMappingInstructions.HasNextNode)
                {
                    if (shipmentstage.Instructions == null)
                        shipmentstage.Instructions = new InstructionsType[collMappingInstructions.Quantity];

                    for (int i = 0; i < collMappingInstructions.Quantity; i++)
                    {
                        var row = shipmentstage.Instructions[i] = new InstructionsType();

                        foreach (var colMapp in collMappingInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.Instructions == null)
                    {
                        shipmentstage.Instructions = new InstructionsType[1];
                        shipmentstage.Instructions[0] = new InstructionsType();
                    }
                    SetField(shipmentstage.Instructions[0], xmlMapping);
                }
                break;
            case "DemurrageInstructions":
                if (xmlMapping is IXmlCollectionMapping collMappingDemurrageInstructions && !collMappingDemurrageInstructions.HasNextNode)
                {
                    if (shipmentstage.DemurrageInstructions == null)
                        shipmentstage.DemurrageInstructions = new DemurrageInstructionsType[collMappingDemurrageInstructions.Quantity];

                    for (int i = 0; i < collMappingDemurrageInstructions.Quantity; i++)
                    {
                        var row = shipmentstage.DemurrageInstructions[i] = new DemurrageInstructionsType();

                        foreach (var colMapp in collMappingDemurrageInstructions.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.DemurrageInstructions == null)
                    {
                        shipmentstage.DemurrageInstructions = new DemurrageInstructionsType[1];
                        shipmentstage.DemurrageInstructions[0] = new DemurrageInstructionsType();
                    }
                    SetField(shipmentstage.DemurrageInstructions[0], xmlMapping);
                }
                break;
            case "CrewQuantity":
                if (shipmentstage.CrewQuantity == null)
                    shipmentstage.CrewQuantity = new CrewQuantityType();
                SetField(shipmentstage.CrewQuantity, xmlMapping);
                break;
            case "PassengerQuantity":
                if (shipmentstage.PassengerQuantity == null)
                    shipmentstage.PassengerQuantity = new PassengerQuantityType();
                SetField(shipmentstage.PassengerQuantity, xmlMapping);
                break;
            case "TransitPeriod":
                if (shipmentstage.TransitPeriod == null)
                    shipmentstage.TransitPeriod = new PeriodType();
                SetField(shipmentstage.TransitPeriod, xmlMapping);
                break;
            case "CarrierParty":
                if (xmlMapping is IXmlCollectionMapping collMappingCarrierParty && !collMappingCarrierParty.HasNextNode)
                {
                    if (shipmentstage.CarrierParty == null)
                        shipmentstage.CarrierParty = new PartyType[collMappingCarrierParty.Quantity];

                    for (int i = 0; i < collMappingCarrierParty.Quantity; i++)
                    {
                        var row = shipmentstage.CarrierParty[i] = new PartyType();

                        foreach (var colMapp in collMappingCarrierParty.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.CarrierParty == null)
                    {
                        shipmentstage.CarrierParty = new PartyType[1];
                        shipmentstage.CarrierParty[0] = new PartyType();
                    }
                    SetField(shipmentstage.CarrierParty[0], xmlMapping);
                }
                break;
            case "TransportMeans":
                if (shipmentstage.TransportMeans == null)
                    shipmentstage.TransportMeans = new TransportMeansType();
                SetField(shipmentstage.TransportMeans, xmlMapping);
                break;
            case "LoadingPortLocation":
                if (shipmentstage.LoadingPortLocation == null)
                    shipmentstage.LoadingPortLocation = new LocationType1();
                SetField(shipmentstage.LoadingPortLocation, xmlMapping);
                break;
            case "UnloadingPortLocation":
                if (shipmentstage.UnloadingPortLocation == null)
                    shipmentstage.UnloadingPortLocation = new LocationType1();
                SetField(shipmentstage.UnloadingPortLocation, xmlMapping);
                break;
            case "TransshipPortLocation":
                if (shipmentstage.TransshipPortLocation == null)
                    shipmentstage.TransshipPortLocation = new LocationType1();
                SetField(shipmentstage.TransshipPortLocation, xmlMapping);
                break;
            case "LoadingTransportEvent":
                if (shipmentstage.LoadingTransportEvent == null)
                    shipmentstage.LoadingTransportEvent = new TransportEventType();
                SetField(shipmentstage.LoadingTransportEvent, xmlMapping);
                break;
            case "ExaminationTransportEvent":
                if (shipmentstage.ExaminationTransportEvent == null)
                    shipmentstage.ExaminationTransportEvent = new TransportEventType();
                SetField(shipmentstage.ExaminationTransportEvent, xmlMapping);
                break;
            case "AvailabilityTransportEvent":
                if (shipmentstage.AvailabilityTransportEvent == null)
                    shipmentstage.AvailabilityTransportEvent = new TransportEventType();
                SetField(shipmentstage.AvailabilityTransportEvent, xmlMapping);
                break;
            case "ExportationTransportEvent":
                if (shipmentstage.ExportationTransportEvent == null)
                    shipmentstage.ExportationTransportEvent = new TransportEventType();
                SetField(shipmentstage.ExportationTransportEvent, xmlMapping);
                break;
            case "DischargeTransportEvent":
                if (shipmentstage.DischargeTransportEvent == null)
                    shipmentstage.DischargeTransportEvent = new TransportEventType();
                SetField(shipmentstage.DischargeTransportEvent, xmlMapping);
                break;
            case "WarehousingTransportEvent":
                if (shipmentstage.WarehousingTransportEvent == null)
                    shipmentstage.WarehousingTransportEvent = new TransportEventType();
                SetField(shipmentstage.WarehousingTransportEvent, xmlMapping);
                break;
            case "TakeoverTransportEvent":
                if (shipmentstage.TakeoverTransportEvent == null)
                    shipmentstage.TakeoverTransportEvent = new TransportEventType();
                SetField(shipmentstage.TakeoverTransportEvent, xmlMapping);
                break;
            case "OptionalTakeoverTransportEvent":
                if (shipmentstage.OptionalTakeoverTransportEvent == null)
                    shipmentstage.OptionalTakeoverTransportEvent = new TransportEventType();
                SetField(shipmentstage.OptionalTakeoverTransportEvent, xmlMapping);
                break;
            case "DropoffTransportEvent":
                if (shipmentstage.DropoffTransportEvent == null)
                    shipmentstage.DropoffTransportEvent = new TransportEventType();
                SetField(shipmentstage.DropoffTransportEvent, xmlMapping);
                break;
            case "ActualPickupTransportEvent":
                if (shipmentstage.ActualPickupTransportEvent == null)
                    shipmentstage.ActualPickupTransportEvent = new TransportEventType();
                SetField(shipmentstage.ActualPickupTransportEvent, xmlMapping);
                break;
            case "DeliveryTransportEvent":
                if (shipmentstage.DeliveryTransportEvent == null)
                    shipmentstage.DeliveryTransportEvent = new TransportEventType();
                SetField(shipmentstage.DeliveryTransportEvent, xmlMapping);
                break;
            case "ReceiptTransportEvent":
                if (shipmentstage.ReceiptTransportEvent == null)
                    shipmentstage.ReceiptTransportEvent = new TransportEventType();
                SetField(shipmentstage.ReceiptTransportEvent, xmlMapping);
                break;
            case "StorageTransportEvent":
                if (shipmentstage.StorageTransportEvent == null)
                    shipmentstage.StorageTransportEvent = new TransportEventType();
                SetField(shipmentstage.StorageTransportEvent, xmlMapping);
                break;
            case "AcceptanceTransportEvent":
                if (shipmentstage.AcceptanceTransportEvent == null)
                    shipmentstage.AcceptanceTransportEvent = new TransportEventType();
                SetField(shipmentstage.AcceptanceTransportEvent, xmlMapping);
                break;
            case "TerminalOperatorParty":
                if (shipmentstage.TerminalOperatorParty == null)
                    shipmentstage.TerminalOperatorParty = new PartyType();
                SetField(shipmentstage.TerminalOperatorParty, xmlMapping);
                break;
            case "CustomsAgentParty":
                if (shipmentstage.CustomsAgentParty == null)
                    shipmentstage.CustomsAgentParty = new PartyType();
                SetField(shipmentstage.CustomsAgentParty, xmlMapping);
                break;
            case "EstimatedTransitPeriod":
                if (shipmentstage.EstimatedTransitPeriod == null)
                    shipmentstage.EstimatedTransitPeriod = new PeriodType();
                SetField(shipmentstage.EstimatedTransitPeriod, xmlMapping);
                break;
            case "FreightAllowanceCharge":
                if (xmlMapping is IXmlCollectionMapping collMappingFreightAllowanceCharge && !collMappingFreightAllowanceCharge.HasNextNode)
                {
                    if (shipmentstage.FreightAllowanceCharge == null)
                        shipmentstage.FreightAllowanceCharge = new AllowanceChargeType[collMappingFreightAllowanceCharge.Quantity];

                    for (int i = 0; i < collMappingFreightAllowanceCharge.Quantity; i++)
                    {
                        var row = shipmentstage.FreightAllowanceCharge[i] = new AllowanceChargeType();

                        foreach (var colMapp in collMappingFreightAllowanceCharge.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.FreightAllowanceCharge == null)
                    {
                        shipmentstage.FreightAllowanceCharge = new AllowanceChargeType[1];
                        shipmentstage.FreightAllowanceCharge[0] = new AllowanceChargeType();
                    }
                    SetField(shipmentstage.FreightAllowanceCharge[0], xmlMapping);
                }
                break;
            case "FreightChargeLocation":
                if (shipmentstage.FreightChargeLocation == null)
                    shipmentstage.FreightChargeLocation = new LocationType1();
                SetField(shipmentstage.FreightChargeLocation, xmlMapping);
                break;
            case "DetentionTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingDetentionTransportEvent && !collMappingDetentionTransportEvent.HasNextNode)
                {
                    if (shipmentstage.DetentionTransportEvent == null)
                        shipmentstage.DetentionTransportEvent = new TransportEventType[collMappingDetentionTransportEvent.Quantity];

                    for (int i = 0; i < collMappingDetentionTransportEvent.Quantity; i++)
                    {
                        var row = shipmentstage.DetentionTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingDetentionTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.DetentionTransportEvent == null)
                    {
                        shipmentstage.DetentionTransportEvent = new TransportEventType[1];
                        shipmentstage.DetentionTransportEvent[0] = new TransportEventType();
                    }
                    SetField(shipmentstage.DetentionTransportEvent[0], xmlMapping);
                }
                break;
            case "RequestedDepartureTransportEvent":
                if (shipmentstage.RequestedDepartureTransportEvent == null)
                    shipmentstage.RequestedDepartureTransportEvent = new TransportEventType();
                SetField(shipmentstage.RequestedDepartureTransportEvent, xmlMapping);
                break;
            case "RequestedArrivalTransportEvent":
                if (shipmentstage.RequestedArrivalTransportEvent == null)
                    shipmentstage.RequestedArrivalTransportEvent = new TransportEventType();
                SetField(shipmentstage.RequestedArrivalTransportEvent, xmlMapping);
                break;
            case "RequestedWaypointTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingRequestedWaypointTransportEvent && !collMappingRequestedWaypointTransportEvent.HasNextNode)
                {
                    if (shipmentstage.RequestedWaypointTransportEvent == null)
                        shipmentstage.RequestedWaypointTransportEvent = new TransportEventType[collMappingRequestedWaypointTransportEvent.Quantity];

                    for (int i = 0; i < collMappingRequestedWaypointTransportEvent.Quantity; i++)
                    {
                        var row = shipmentstage.RequestedWaypointTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingRequestedWaypointTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.RequestedWaypointTransportEvent == null)
                    {
                        shipmentstage.RequestedWaypointTransportEvent = new TransportEventType[1];
                        shipmentstage.RequestedWaypointTransportEvent[0] = new TransportEventType();
                    }
                    SetField(shipmentstage.RequestedWaypointTransportEvent[0], xmlMapping);
                }
                break;
            case "PlannedDepartureTransportEvent":
                if (shipmentstage.PlannedDepartureTransportEvent == null)
                    shipmentstage.PlannedDepartureTransportEvent = new TransportEventType();
                SetField(shipmentstage.PlannedDepartureTransportEvent, xmlMapping);
                break;
            case "PlannedArrivalTransportEvent":
                if (shipmentstage.PlannedArrivalTransportEvent == null)
                    shipmentstage.PlannedArrivalTransportEvent = new TransportEventType();
                SetField(shipmentstage.PlannedArrivalTransportEvent, xmlMapping);
                break;
            case "PlannedWaypointTransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingPlannedWaypointTransportEvent && !collMappingPlannedWaypointTransportEvent.HasNextNode)
                {
                    if (shipmentstage.PlannedWaypointTransportEvent == null)
                        shipmentstage.PlannedWaypointTransportEvent = new TransportEventType[collMappingPlannedWaypointTransportEvent.Quantity];

                    for (int i = 0; i < collMappingPlannedWaypointTransportEvent.Quantity; i++)
                    {
                        var row = shipmentstage.PlannedWaypointTransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingPlannedWaypointTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.PlannedWaypointTransportEvent == null)
                    {
                        shipmentstage.PlannedWaypointTransportEvent = new TransportEventType[1];
                        shipmentstage.PlannedWaypointTransportEvent[0] = new TransportEventType();
                    }
                    SetField(shipmentstage.PlannedWaypointTransportEvent[0], xmlMapping);
                }
                break;
            case "ActualDepartureTransportEvent":
                if (shipmentstage.ActualDepartureTransportEvent == null)
                    shipmentstage.ActualDepartureTransportEvent = new TransportEventType();
                SetField(shipmentstage.ActualDepartureTransportEvent, xmlMapping);
                break;
            case "ActualWaypointTransportEvent":
                if (shipmentstage.ActualWaypointTransportEvent == null)
                    shipmentstage.ActualWaypointTransportEvent = new TransportEventType();
                SetField(shipmentstage.ActualWaypointTransportEvent, xmlMapping);
                break;
            case "ActualArrivalTransportEvent":
                if (shipmentstage.ActualArrivalTransportEvent == null)
                    shipmentstage.ActualArrivalTransportEvent = new TransportEventType();
                SetField(shipmentstage.ActualArrivalTransportEvent, xmlMapping);
                break;
            case "TransportEvent":
                if (xmlMapping is IXmlCollectionMapping collMappingTransportEvent && !collMappingTransportEvent.HasNextNode)
                {
                    if (shipmentstage.TransportEvent == null)
                        shipmentstage.TransportEvent = new TransportEventType[collMappingTransportEvent.Quantity];

                    for (int i = 0; i < collMappingTransportEvent.Quantity; i++)
                    {
                        var row = shipmentstage.TransportEvent[i] = new TransportEventType();

                        foreach (var colMapp in collMappingTransportEvent.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.TransportEvent == null)
                    {
                        shipmentstage.TransportEvent = new TransportEventType[1];
                        shipmentstage.TransportEvent[0] = new TransportEventType();
                    }
                    SetField(shipmentstage.TransportEvent[0], xmlMapping);
                }
                break;
            case "EstimatedDepartureTransportEvent":
                if (shipmentstage.EstimatedDepartureTransportEvent == null)
                    shipmentstage.EstimatedDepartureTransportEvent = new TransportEventType();
                SetField(shipmentstage.EstimatedDepartureTransportEvent, xmlMapping);
                break;
            case "EstimatedArrivalTransportEvent":
                if (shipmentstage.EstimatedArrivalTransportEvent == null)
                    shipmentstage.EstimatedArrivalTransportEvent = new TransportEventType();
                SetField(shipmentstage.EstimatedArrivalTransportEvent, xmlMapping);
                break;
            case "PassengerPerson":
                if (xmlMapping is IXmlCollectionMapping collMappingPassengerPerson && !collMappingPassengerPerson.HasNextNode)
                {
                    if (shipmentstage.PassengerPerson == null)
                        shipmentstage.PassengerPerson = new PersonType[collMappingPassengerPerson.Quantity];

                    for (int i = 0; i < collMappingPassengerPerson.Quantity; i++)
                    {
                        var row = shipmentstage.PassengerPerson[i] = new PersonType();

                        foreach (var colMapp in collMappingPassengerPerson.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.PassengerPerson == null)
                    {
                        shipmentstage.PassengerPerson = new PersonType[1];
                        shipmentstage.PassengerPerson[0] = new PersonType();
                    }
                    SetField(shipmentstage.PassengerPerson[0], xmlMapping);
                }
                break;
            case "DriverPerson":
                if (xmlMapping is IXmlCollectionMapping collMappingDriverPerson && !collMappingDriverPerson.HasNextNode)
                {
                    if (shipmentstage.DriverPerson == null)
                        shipmentstage.DriverPerson = new PersonType[collMappingDriverPerson.Quantity];

                    for (int i = 0; i < collMappingDriverPerson.Quantity; i++)
                    {
                        var row = shipmentstage.DriverPerson[i] = new PersonType();

                        foreach (var colMapp in collMappingDriverPerson.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.DriverPerson == null)
                    {
                        shipmentstage.DriverPerson = new PersonType[1];
                        shipmentstage.DriverPerson[0] = new PersonType();
                    }
                    SetField(shipmentstage.DriverPerson[0], xmlMapping);
                }
                break;
            case "ReportingPerson":
                if (shipmentstage.ReportingPerson == null)
                    shipmentstage.ReportingPerson = new PersonType();
                SetField(shipmentstage.ReportingPerson, xmlMapping);
                break;
            case "CrewMemberPerson":
                if (xmlMapping is IXmlCollectionMapping collMappingCrewMemberPerson && !collMappingCrewMemberPerson.HasNextNode)
                {
                    if (shipmentstage.CrewMemberPerson == null)
                        shipmentstage.CrewMemberPerson = new PersonType[collMappingCrewMemberPerson.Quantity];

                    for (int i = 0; i < collMappingCrewMemberPerson.Quantity; i++)
                    {
                        var row = shipmentstage.CrewMemberPerson[i] = new PersonType();

                        foreach (var colMapp in collMappingCrewMemberPerson.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (shipmentstage.CrewMemberPerson == null)
                    {
                        shipmentstage.CrewMemberPerson = new PersonType[1];
                        shipmentstage.CrewMemberPerson[0] = new PersonType();
                    }
                    SetField(shipmentstage.CrewMemberPerson[0], xmlMapping);
                }
                break;
            case "SecurityOfficerPerson":
                if (shipmentstage.SecurityOfficerPerson == null)
                    shipmentstage.SecurityOfficerPerson = new PersonType();
                SetField(shipmentstage.SecurityOfficerPerson, xmlMapping);
                break;
            case "MasterPerson":
                if (shipmentstage.MasterPerson == null)
                    shipmentstage.MasterPerson = new PersonType();
                SetField(shipmentstage.MasterPerson, xmlMapping);
                break;
            case "ShipsSurgeonPerson":
                if (shipmentstage.ShipsSurgeonPerson == null)
                    shipmentstage.ShipsSurgeonPerson = new PersonType();
                SetField(shipmentstage.ShipsSurgeonPerson, xmlMapping);
                break;

        }
    }
    public void SetField(EnvironmentalEmissionType environmentalemission, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "EnvironmentalEmissionTypeCode":
                if (environmentalemission.EnvironmentalEmissionTypeCode == null)
                    environmentalemission.EnvironmentalEmissionTypeCode = new EnvironmentalEmissionTypeCodeType();
                SetField(environmentalemission.EnvironmentalEmissionTypeCode, xmlMapping);
                break;
            case "ValueMeasure":
                if (environmentalemission.ValueMeasure == null)
                    environmentalemission.ValueMeasure = new ValueMeasureType();
                SetField(environmentalemission.ValueMeasure, xmlMapping);
                break;
            case "Description":
                if (xmlMapping is IXmlCollectionMapping collMappingDescription && !collMappingDescription.HasNextNode)
                {
                    if (environmentalemission.Description == null)
                        environmentalemission.Description = new DescriptionType[collMappingDescription.Quantity];

                    for (int i = 0; i < collMappingDescription.Quantity; i++)
                    {
                        var row = environmentalemission.Description[i] = new DescriptionType();

                        foreach (var colMapp in collMappingDescription.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (environmentalemission.Description == null)
                    {
                        environmentalemission.Description = new DescriptionType[1];
                        environmentalemission.Description[0] = new DescriptionType();
                    }
                    SetField(environmentalemission.Description[0], xmlMapping);
                }
                break;
            case "EmissionCalculationMethod":
                if (xmlMapping is IXmlCollectionMapping collMappingEmissionCalculationMethod && !collMappingEmissionCalculationMethod.HasNextNode)
                {
                    if (environmentalemission.EmissionCalculationMethod == null)
                        environmentalemission.EmissionCalculationMethod = new EmissionCalculationMethodType[collMappingEmissionCalculationMethod.Quantity];

                    for (int i = 0; i < collMappingEmissionCalculationMethod.Quantity; i++)
                    {
                        var row = environmentalemission.EmissionCalculationMethod[i] = new EmissionCalculationMethodType();

                        foreach (var colMapp in collMappingEmissionCalculationMethod.ColumnsMapping)
                        {
                            colMapp.SetRowContext(((XmlCollectionMapping)xmlMapping).itemsList.Rows[i]);
                            if (colMapp.Value != null && !string.IsNullOrEmpty(colMapp.Value.ToString()))
                            {
                                SetField(row, colMapp);
                                colMapp.ResetNodePath();
                            }
                        }
                    }
                }
                else
                {
                    if (environmentalemission.EmissionCalculationMethod == null)
                    {
                        environmentalemission.EmissionCalculationMethod = new EmissionCalculationMethodType[1];
                        environmentalemission.EmissionCalculationMethod[0] = new EmissionCalculationMethodType();
                    }
                    SetField(environmentalemission.EmissionCalculationMethod[0], xmlMapping);
                }
                break;

        }
    }
    public void SetField(EmissionCalculationMethodType emissioncalculationmethod, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "CalculationMethodCode":
                if (emissioncalculationmethod.CalculationMethodCode == null)
                    emissioncalculationmethod.CalculationMethodCode = new CalculationMethodCodeType();
                SetField(emissioncalculationmethod.CalculationMethodCode, xmlMapping);
                break;
            case "FullnessIndicationCode":
                if (emissioncalculationmethod.FullnessIndicationCode == null)
                    emissioncalculationmethod.FullnessIndicationCode = new FullnessIndicationCodeType();
                SetField(emissioncalculationmethod.FullnessIndicationCode, xmlMapping);
                break;
            case "MeasurementFromLocation":
                if (emissioncalculationmethod.MeasurementFromLocation == null)
                    emissioncalculationmethod.MeasurementFromLocation = new LocationType1();
                SetField(emissioncalculationmethod.MeasurementFromLocation, xmlMapping);
                break;
            case "MeasurementToLocation":
                if (emissioncalculationmethod.MeasurementToLocation == null)
                    emissioncalculationmethod.MeasurementToLocation = new LocationType1();
                SetField(emissioncalculationmethod.MeasurementToLocation, xmlMapping);
                break;

        }
    }
    public void SetField(ServiceFrequencyType scheduledservicefrequency, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "WeekDayCode":
                if (scheduledservicefrequency.WeekDayCode == null)
                    scheduledservicefrequency.WeekDayCode = new WeekDayCodeType();
                SetField(scheduledservicefrequency.WeekDayCode, xmlMapping);
                break;

        }
    }
    public void SetField(PaymentType prepaidpayment, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "ID":
                if (prepaidpayment.ID == null)
                    prepaidpayment.ID = new IDType();
                SetField(prepaidpayment.ID, xmlMapping);
                break;
            case "PaidAmount":
                if (prepaidpayment.PaidAmount == null)
                    prepaidpayment.PaidAmount = new PaidAmountType();
                SetField(prepaidpayment.PaidAmount, xmlMapping);
                break;
            case "ReceivedDate":
                if (prepaidpayment.ReceivedDate == null)
                    prepaidpayment.ReceivedDate = new ReceivedDateType();
                SetField(prepaidpayment.ReceivedDate, xmlMapping);
                break;
            case "PaidDate":
                if (prepaidpayment.PaidDate == null)
                    prepaidpayment.PaidDate = new PaidDateType();
                SetField(prepaidpayment.PaidDate, xmlMapping);
                break;
            case "PaidTime":
                if (prepaidpayment.PaidTime == null)
                    prepaidpayment.PaidTime = new PaidTimeType();
                SetField(prepaidpayment.PaidTime, xmlMapping);
                break;
            case "InstructionID":
                if (prepaidpayment.InstructionID == null)
                    prepaidpayment.InstructionID = new InstructionIDType();
                SetField(prepaidpayment.InstructionID, xmlMapping);
                break;

        }
    }
    public void SetField(MonetaryTotalType legalmonetarytotal, IXmlMapping xmlMapping)
    {
        var xmlNode = xmlMapping.GetXMLNode();

        switch (xmlNode)
        {
            case "LineExtensionAmount":
                if (legalmonetarytotal.LineExtensionAmount == null)
                    legalmonetarytotal.LineExtensionAmount = new LineExtensionAmountType();
                SetField(legalmonetarytotal.LineExtensionAmount, xmlMapping);
                break;
            case "TaxExclusiveAmount":
                if (legalmonetarytotal.TaxExclusiveAmount == null)
                    legalmonetarytotal.TaxExclusiveAmount = new TaxExclusiveAmountType();
                SetField(legalmonetarytotal.TaxExclusiveAmount, xmlMapping);
                break;
            case "TaxInclusiveAmount":
                if (legalmonetarytotal.TaxInclusiveAmount == null)
                    legalmonetarytotal.TaxInclusiveAmount = new TaxInclusiveAmountType();
                SetField(legalmonetarytotal.TaxInclusiveAmount, xmlMapping);
                break;
            case "AllowanceTotalAmount":
                if (legalmonetarytotal.AllowanceTotalAmount == null)
                    legalmonetarytotal.AllowanceTotalAmount = new AllowanceTotalAmountType();
                SetField(legalmonetarytotal.AllowanceTotalAmount, xmlMapping);
                break;
            case "ChargeTotalAmount":
                if (legalmonetarytotal.ChargeTotalAmount == null)
                    legalmonetarytotal.ChargeTotalAmount = new ChargeTotalAmountType();
                SetField(legalmonetarytotal.ChargeTotalAmount, xmlMapping);
                break;
            case "PrepaidAmount":
                if (legalmonetarytotal.PrepaidAmount == null)
                    legalmonetarytotal.PrepaidAmount = new PrepaidAmountType();
                SetField(legalmonetarytotal.PrepaidAmount, xmlMapping);
                break;
            case "PayableRoundingAmount":
                if (legalmonetarytotal.PayableRoundingAmount == null)
                    legalmonetarytotal.PayableRoundingAmount = new PayableRoundingAmountType();
                SetField(legalmonetarytotal.PayableRoundingAmount, xmlMapping);
                break;
            case "PayableAmount":
                if (legalmonetarytotal.PayableAmount == null)
                    legalmonetarytotal.PayableAmount = new PayableAmountType();
                SetField(legalmonetarytotal.PayableAmount, xmlMapping);
                break;
            case "PayableAlternativeAmount":
                if (legalmonetarytotal.PayableAlternativeAmount == null)
                    legalmonetarytotal.PayableAlternativeAmount = new PayableAlternativeAmountType();
                SetField(legalmonetarytotal.PayableAlternativeAmount, xmlMapping);
                break;

        }
    }
}
                   
