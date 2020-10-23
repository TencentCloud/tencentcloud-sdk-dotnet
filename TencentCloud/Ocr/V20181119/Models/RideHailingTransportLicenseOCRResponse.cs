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

    public class RideHailingTransportLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 交运管许可字号。
        /// </summary>
        [JsonProperty("OperationLicenseNumber")]
        public string OperationLicenseNumber{ get; set; }

        /// <summary>
        /// 车辆所有人，对应网约车运输证字段：车辆所有人/车主名称/业户名称。
        /// </summary>
        [JsonProperty("VehicleOwner")]
        public string VehicleOwner{ get; set; }

        /// <summary>
        /// 车牌号码，对应网约车运输证字段：车牌号码/车辆号牌。
        /// </summary>
        [JsonProperty("VehicleNumber")]
        public string VehicleNumber{ get; set; }

        /// <summary>
        /// 有效起始日期。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 有效期截止时间，对应网约车运输证字段：有效期至/营运期限止。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 初始发证日期，对应网约车运输证字段：初始领证日期/发证日期。
        /// </summary>
        [JsonProperty("ReleaseDate")]
        public string ReleaseDate{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationLicenseNumber", this.OperationLicenseNumber);
            this.SetParamSimple(map, prefix + "VehicleOwner", this.VehicleOwner);
            this.SetParamSimple(map, prefix + "VehicleNumber", this.VehicleNumber);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "ReleaseDate", this.ReleaseDate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

