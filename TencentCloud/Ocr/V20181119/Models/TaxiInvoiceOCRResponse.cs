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

    public class TaxiInvoiceOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("InvoiceNum")]
        public string InvoiceNum{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("Fare")]
        public string Fare{ get; set; }

        /// <summary>
        /// 上车时间
        /// </summary>
        [JsonProperty("GetOnTime")]
        public string GetOnTime{ get; set; }

        /// <summary>
        /// 下车时间
        /// </summary>
        [JsonProperty("GetOffTime")]
        public string GetOffTime{ get; set; }

        /// <summary>
        /// 里程
        /// </summary>
        [JsonProperty("Distance")]
        public string Distance{ get; set; }

        /// <summary>
        /// 发票所在地
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("PlateNumber")]
        public string PlateNumber{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("InvoiceType")]
        public string InvoiceType{ get; set; }

        /// <summary>
        /// 省
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoiceNum", this.InvoiceNum);
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "GetOnTime", this.GetOnTime);
            this.SetParamSimple(map, prefix + "GetOffTime", this.GetOffTime);
            this.SetParamSimple(map, prefix + "Distance", this.Distance);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "PlateNumber", this.PlateNumber);
            this.SetParamSimple(map, prefix + "InvoiceType", this.InvoiceType);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

