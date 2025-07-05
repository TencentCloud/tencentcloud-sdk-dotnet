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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroupHealthStatusDetail : AbstractModel
    {
        
        /// <summary>
        /// 源站组 ID。
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// 根据所有探测区域的结果综合决策出来的源站组下各个源站的健康状态。超过一半的地域判定该源站不健康，则对应状态为不健康，否则为健康。
        /// </summary>
        [JsonProperty("OriginHealthStatus")]
        public OriginHealthStatus[] OriginHealthStatus{ get; set; }

        /// <summary>
        /// 各个健康检查区域下源站的健康状态。
        /// </summary>
        [JsonProperty("CheckRegionHealthStatus")]
        public CheckRegionHealthStatus[] CheckRegionHealthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamArrayObj(map, prefix + "OriginHealthStatus.", this.OriginHealthStatus);
            this.SetParamArrayObj(map, prefix + "CheckRegionHealthStatus.", this.CheckRegionHealthStatus);
        }
    }
}

