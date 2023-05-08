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

    public class VatElectronicItemInfo : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

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
        /// 运输货物名称，仅货物运输服务发票返回
        /// </summary>
        [JsonProperty("TransportItemsName")]
        public string TransportItemsName{ get; set; }

        /// <summary>
        /// 建筑服务发生地，仅建筑发票返回
        /// </summary>
        [JsonProperty("PlaceOfBuildingService")]
        public string PlaceOfBuildingService{ get; set; }

        /// <summary>
        /// 建筑项目名称，仅建筑发票返回
        /// </summary>
        [JsonProperty("BuildingName")]
        public string BuildingName{ get; set; }

        /// <summary>
        /// 产权证书/不动产权证号，仅不动产经营租赁服务发票返回
        /// </summary>
        [JsonProperty("EstateNumber")]
        public string EstateNumber{ get; set; }

        /// <summary>
        /// 面积单位，仅不动产经营租赁服务发票返回
        /// </summary>
        [JsonProperty("AreaUnit")]
        public string AreaUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "VehicleBrand", this.VehicleBrand);
            this.SetParamSimple(map, prefix + "DeparturePlace", this.DeparturePlace);
            this.SetParamSimple(map, prefix + "ArrivalPlace", this.ArrivalPlace);
            this.SetParamSimple(map, prefix + "TransportItemsName", this.TransportItemsName);
            this.SetParamSimple(map, prefix + "PlaceOfBuildingService", this.PlaceOfBuildingService);
            this.SetParamSimple(map, prefix + "BuildingName", this.BuildingName);
            this.SetParamSimple(map, prefix + "EstateNumber", this.EstateNumber);
            this.SetParamSimple(map, prefix + "AreaUnit", this.AreaUnit);
        }
    }
}

