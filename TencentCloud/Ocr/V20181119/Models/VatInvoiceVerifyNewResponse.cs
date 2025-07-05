/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class VatInvoiceVerifyNewResponse : AbstractModel
    {
        
        /// <summary>
        /// 增值税发票、购车发票、全电发票的基础要素字段信息。
        /// </summary>
        [JsonProperty("Invoice")]
        public VatInvoice Invoice{ get; set; }

        /// <summary>
        /// 机动车销售统一发票详细字段信息。
        /// </summary>
        [JsonProperty("VehicleInvoiceInfo")]
        public VehicleInvoiceInfo VehicleInvoiceInfo{ get; set; }

        /// <summary>
        /// 二手车销售统一发票详细字段信息。
        /// </summary>
        [JsonProperty("UsedVehicleInvoiceInfo")]
        public UsedVehicleInvoiceInfo UsedVehicleInvoiceInfo{ get; set; }

        /// <summary>
        /// 通行费发票详细字段信息。
        /// </summary>
        [JsonProperty("PassInvoiceInfoList")]
        public PassInvoiceInfo[] PassInvoiceInfoList{ get; set; }

        /// <summary>
        /// 全电发票（铁路电子客票）详细字段信息。
        /// </summary>
        [JsonProperty("ElectronicTrainTicket")]
        public ElectronicTrainTicket ElectronicTrainTicket{ get; set; }

        /// <summary>
        /// 全电发票（航空运输电子客票行程单）详细字段信息。
        /// </summary>
        [JsonProperty("ElectronicAirTransport")]
        public ElectronicAirTransport ElectronicAirTransport{ get; set; }

        /// <summary>
        /// 财政发票详细字段信息
        /// </summary>
        [JsonProperty("FinancialBill")]
        public FinancialBill FinancialBill{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Invoice.", this.Invoice);
            this.SetParamObj(map, prefix + "VehicleInvoiceInfo.", this.VehicleInvoiceInfo);
            this.SetParamObj(map, prefix + "UsedVehicleInvoiceInfo.", this.UsedVehicleInvoiceInfo);
            this.SetParamArrayObj(map, prefix + "PassInvoiceInfoList.", this.PassInvoiceInfoList);
            this.SetParamObj(map, prefix + "ElectronicTrainTicket.", this.ElectronicTrainTicket);
            this.SetParamObj(map, prefix + "ElectronicAirTransport.", this.ElectronicAirTransport);
            this.SetParamObj(map, prefix + "FinancialBill.", this.FinancialBill);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

