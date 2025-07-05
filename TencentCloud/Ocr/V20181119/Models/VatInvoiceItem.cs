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

    public class VatInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// 行号
        /// </summary>
        [JsonProperty("LineNo")]
        public string LineNo{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("UnitPrice")]
        public string UnitPrice{ get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("AmountWithoutTax")]
        public string AmountWithoutTax{ get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [JsonProperty("TaxClassifyCode")]
        public string TaxClassifyCode{ get; set; }

        /// <summary>
        /// 运输工具类型
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// 运输工具牌号
        /// </summary>
        [JsonProperty("VehicleBrand")]
        public string VehicleBrand{ get; set; }

        /// <summary>
        /// 起始地
        /// </summary>
        [JsonProperty("DeparturePlace")]
        public string DeparturePlace{ get; set; }

        /// <summary>
        /// 到达地
        /// </summary>
        [JsonProperty("ArrivalPlace")]
        public string ArrivalPlace{ get; set; }

        /// <summary>
        /// 运输货物名称
        /// </summary>
        [JsonProperty("TransportItemsName")]
        public string TransportItemsName{ get; set; }

        /// <summary>
        /// 建筑服务发生地
        /// </summary>
        [JsonProperty("ConstructionPlace")]
        public string ConstructionPlace{ get; set; }

        /// <summary>
        /// 建筑项目名称
        /// </summary>
        [JsonProperty("ConstructionName")]
        public string ConstructionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LineNo", this.LineNo);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "TaxClassifyCode", this.TaxClassifyCode);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "VehicleBrand", this.VehicleBrand);
            this.SetParamSimple(map, prefix + "DeparturePlace", this.DeparturePlace);
            this.SetParamSimple(map, prefix + "ArrivalPlace", this.ArrivalPlace);
            this.SetParamSimple(map, prefix + "TransportItemsName", this.TransportItemsName);
            this.SetParamSimple(map, prefix + "ConstructionPlace", this.ConstructionPlace);
            this.SetParamSimple(map, prefix + "ConstructionName", this.ConstructionName);
        }
    }
}

