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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrafficPackagesResponse : AbstractModel
    {
        
        /// <summary>
        /// 流量包总个数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 流量包详情
        /// </summary>
        [JsonProperty("TrafficPackages")]
        public TrafficPackage[] TrafficPackages{ get; set; }

        /// <summary>
        /// 即将过期的流量包个数（7天内）
        /// </summary>
        [JsonProperty("ExpiringCount")]
        public long? ExpiringCount{ get; set; }

        /// <summary>
        /// 有效流量包个数
        /// </summary>
        [JsonProperty("EnabledCount")]
        public long? EnabledCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "TrafficPackages.", this.TrafficPackages);
            this.SetParamSimple(map, prefix + "ExpiringCount", this.ExpiringCount);
            this.SetParamSimple(map, prefix + "EnabledCount", this.EnabledCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

