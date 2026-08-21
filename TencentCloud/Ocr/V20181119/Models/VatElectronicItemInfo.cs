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

    public class VatElectronicItemInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>项目名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数量</p>
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// <p>规格型号</p>
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// <p>单价</p>
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// <p>金额</p>
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// <p>税率</p>
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// <p>税额</p>
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// <p>单位</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>运输工具类型</p>
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// <p>运输工具牌号</p>
        /// </summary>
        [JsonProperty("VehicleBrand")]
        public string VehicleBrand{ get; set; }

        /// <summary>
        /// <p>起始地</p>
        /// </summary>
        [JsonProperty("DeparturePlace")]
        public string DeparturePlace{ get; set; }

        /// <summary>
        /// <p>到达地</p>
        /// </summary>
        [JsonProperty("ArrivalPlace")]
        public string ArrivalPlace{ get; set; }

        /// <summary>
        /// <p>运输货物名称，仅货物运输服务发票返回</p>
        /// </summary>
        [JsonProperty("TransportItemsName")]
        public string TransportItemsName{ get; set; }

        /// <summary>
        /// <p>建筑服务发生地，仅建筑发票返回</p>
        /// </summary>
        [JsonProperty("PlaceOfBuildingService")]
        public string PlaceOfBuildingService{ get; set; }

        /// <summary>
        /// <p>建筑项目名称，仅建筑发票返回</p>
        /// </summary>
        [JsonProperty("BuildingName")]
        public string BuildingName{ get; set; }

        /// <summary>
        /// <p>产权证书/不动产权证号，仅不动产经营租赁服务发票返回</p>
        /// </summary>
        [JsonProperty("EstateNumber")]
        public string EstateNumber{ get; set; }

        /// <summary>
        /// <p>面积单位，仅不动产经营租赁服务发票返回</p>
        /// </summary>
        [JsonProperty("AreaUnit")]
        public string AreaUnit{ get; set; }

        /// <summary>
        /// <p>出行人，仅旅客运输服务发票返回</p>
        /// </summary>
        [JsonProperty("Traveler")]
        public string Traveler{ get; set; }

        /// <summary>
        /// <p>有效身份证件号，仅旅客运输服务发票返回</p>
        /// </summary>
        [JsonProperty("TravelerID")]
        public string TravelerID{ get; set; }

        /// <summary>
        /// <p>出行日期，仅旅客运输服务发票返回</p>
        /// </summary>
        [JsonProperty("TravelDate")]
        public string TravelDate{ get; set; }

        /// <summary>
        /// <p>等级，仅旅客运输服务发票返回</p>
        /// </summary>
        [JsonProperty("TravelLevel")]
        public string TravelLevel{ get; set; }

        /// <summary>
        /// <p>通行日期起</p>
        /// </summary>
        [JsonProperty("DateStart")]
        public string DateStart{ get; set; }

        /// <summary>
        /// <p>通行日期止</p>
        /// </summary>
        [JsonProperty("DateEnd")]
        public string DateEnd{ get; set; }


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
            this.SetParamSimple(map, prefix + "Traveler", this.Traveler);
            this.SetParamSimple(map, prefix + "TravelerID", this.TravelerID);
            this.SetParamSimple(map, prefix + "TravelDate", this.TravelDate);
            this.SetParamSimple(map, prefix + "TravelLevel", this.TravelLevel);
            this.SetParamSimple(map, prefix + "DateStart", this.DateStart);
            this.SetParamSimple(map, prefix + "DateEnd", this.DateEnd);
        }
    }
}

