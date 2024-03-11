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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceLocationSolveResponse : AbstractModel
    {
        
        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("Longitude")]
        public float? Longitude{ get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("Latitude")]
        public float? Latitude{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("LocationType")]
        public string LocationType{ get; set; }

        /// <summary>
        /// 误差精度预估，单位为米
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Accuracy")]
        public float? Accuracy{ get; set; }

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
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "LocationType", this.LocationType);
            this.SetParamSimple(map, prefix + "Accuracy", this.Accuracy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

