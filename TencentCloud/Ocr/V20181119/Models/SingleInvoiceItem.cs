/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SingleInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// 增值税专用发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatSpecialInvoice")]
        public VatInvoiceInfo VatSpecialInvoice{ get; set; }

        /// <summary>
        /// 增值税普通发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatCommonInvoice")]
        public VatInvoiceInfo VatCommonInvoice{ get; set; }

        /// <summary>
        /// 增值税电子普通发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicCommonInvoice")]
        public VatInvoiceInfo VatElectronicCommonInvoice{ get; set; }

        /// <summary>
        /// 增值税电子专用发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicSpecialInvoice")]
        public VatInvoiceInfo VatElectronicSpecialInvoice{ get; set; }

        /// <summary>
        /// 区块链电子发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicInvoiceBlockchain")]
        public VatInvoiceInfo VatElectronicInvoiceBlockchain{ get; set; }

        /// <summary>
        /// 增值税电子普通发票(通行费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicInvoiceToll")]
        public VatInvoiceInfo VatElectronicInvoiceToll{ get; set; }

        /// <summary>
        /// 电子发票(专用发票)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicSpecialInvoiceFull")]
        public VatElectronicInfo VatElectronicSpecialInvoiceFull{ get; set; }

        /// <summary>
        /// 电子发票(普通发票)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatElectronicInvoiceFull")]
        public VatElectronicInfo VatElectronicInvoiceFull{ get; set; }

        /// <summary>
        /// 通用机打发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachinePrintedInvoice")]
        public MachinePrintedInvoice MachinePrintedInvoice{ get; set; }

        /// <summary>
        /// 汽车票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusInvoice")]
        public BusInvoice BusInvoice{ get; set; }

        /// <summary>
        /// 轮船票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShippingInvoice")]
        public ShippingInvoice ShippingInvoice{ get; set; }

        /// <summary>
        /// 过路过桥费发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TollInvoice")]
        public TollInvoice TollInvoice{ get; set; }

        /// <summary>
        /// 其他发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherInvoice")]
        public OtherInvoice OtherInvoice{ get; set; }

        /// <summary>
        /// 机动车销售统一发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MotorVehicleSaleInvoice")]
        public MotorVehicleSaleInvoice MotorVehicleSaleInvoice{ get; set; }

        /// <summary>
        /// 二手车销售统一发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedCarPurchaseInvoice")]
        public UsedCarPurchaseInvoice UsedCarPurchaseInvoice{ get; set; }

        /// <summary>
        /// 增值税普通发票(卷票)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatInvoiceRoll")]
        public VatInvoiceRoll VatInvoiceRoll{ get; set; }

        /// <summary>
        /// 出租车发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxiTicket")]
        public TaxiTicket TaxiTicket{ get; set; }

        /// <summary>
        /// 定额发票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuotaInvoice")]
        public QuotaInvoice QuotaInvoice{ get; set; }

        /// <summary>
        /// 机票行程单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AirTransport")]
        public AirTransport AirTransport{ get; set; }

        /// <summary>
        /// 非税收入通用票据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonTaxIncomeGeneralBill")]
        public NonTaxIncomeBill NonTaxIncomeGeneralBill{ get; set; }

        /// <summary>
        /// 非税收入一般缴款书(电子)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonTaxIncomeElectronicBill")]
        public NonTaxIncomeBill NonTaxIncomeElectronicBill{ get; set; }

        /// <summary>
        /// 火车票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainTicket")]
        public TrainTicket TrainTicket{ get; set; }

        /// <summary>
        /// 医疗门诊收费票据（电子）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedicalOutpatientInvoice")]
        public MedicalInvoice MedicalOutpatientInvoice{ get; set; }

        /// <summary>
        /// 医疗住院收费票据（电子）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedicalHospitalizedInvoice")]
        public MedicalInvoice MedicalHospitalizedInvoice{ get; set; }

        /// <summary>
        /// 增值税销货清单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VatSalesList")]
        public VatInvoiceInfo VatSalesList{ get; set; }

        /// <summary>
        /// 电子发票（火车票）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElectronicTrainTicketFull")]
        public ElectronicTrainTicketFull ElectronicTrainTicketFull{ get; set; }

        /// <summary>
        /// 电子发票（机票行程单）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElectronicFlightTicketFull")]
        public ElectronicFlightTicketFull ElectronicFlightTicketFull{ get; set; }

        /// <summary>
        /// 完税凭证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxPayment")]
        public TaxPayment TaxPayment{ get; set; }

        /// <summary>
        /// 海关缴款
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomsPaymentReceipt")]
        public CustomsPaymentReceipt CustomsPaymentReceipt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VatSpecialInvoice.", this.VatSpecialInvoice);
            this.SetParamObj(map, prefix + "VatCommonInvoice.", this.VatCommonInvoice);
            this.SetParamObj(map, prefix + "VatElectronicCommonInvoice.", this.VatElectronicCommonInvoice);
            this.SetParamObj(map, prefix + "VatElectronicSpecialInvoice.", this.VatElectronicSpecialInvoice);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceBlockchain.", this.VatElectronicInvoiceBlockchain);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceToll.", this.VatElectronicInvoiceToll);
            this.SetParamObj(map, prefix + "VatElectronicSpecialInvoiceFull.", this.VatElectronicSpecialInvoiceFull);
            this.SetParamObj(map, prefix + "VatElectronicInvoiceFull.", this.VatElectronicInvoiceFull);
            this.SetParamObj(map, prefix + "MachinePrintedInvoice.", this.MachinePrintedInvoice);
            this.SetParamObj(map, prefix + "BusInvoice.", this.BusInvoice);
            this.SetParamObj(map, prefix + "ShippingInvoice.", this.ShippingInvoice);
            this.SetParamObj(map, prefix + "TollInvoice.", this.TollInvoice);
            this.SetParamObj(map, prefix + "OtherInvoice.", this.OtherInvoice);
            this.SetParamObj(map, prefix + "MotorVehicleSaleInvoice.", this.MotorVehicleSaleInvoice);
            this.SetParamObj(map, prefix + "UsedCarPurchaseInvoice.", this.UsedCarPurchaseInvoice);
            this.SetParamObj(map, prefix + "VatInvoiceRoll.", this.VatInvoiceRoll);
            this.SetParamObj(map, prefix + "TaxiTicket.", this.TaxiTicket);
            this.SetParamObj(map, prefix + "QuotaInvoice.", this.QuotaInvoice);
            this.SetParamObj(map, prefix + "AirTransport.", this.AirTransport);
            this.SetParamObj(map, prefix + "NonTaxIncomeGeneralBill.", this.NonTaxIncomeGeneralBill);
            this.SetParamObj(map, prefix + "NonTaxIncomeElectronicBill.", this.NonTaxIncomeElectronicBill);
            this.SetParamObj(map, prefix + "TrainTicket.", this.TrainTicket);
            this.SetParamObj(map, prefix + "MedicalOutpatientInvoice.", this.MedicalOutpatientInvoice);
            this.SetParamObj(map, prefix + "MedicalHospitalizedInvoice.", this.MedicalHospitalizedInvoice);
            this.SetParamObj(map, prefix + "VatSalesList.", this.VatSalesList);
            this.SetParamObj(map, prefix + "ElectronicTrainTicketFull.", this.ElectronicTrainTicketFull);
            this.SetParamObj(map, prefix + "ElectronicFlightTicketFull.", this.ElectronicFlightTicketFull);
            this.SetParamObj(map, prefix + "TaxPayment.", this.TaxPayment);
            this.SetParamObj(map, prefix + "CustomsPaymentReceipt.", this.CustomsPaymentReceipt);
        }
    }
}

