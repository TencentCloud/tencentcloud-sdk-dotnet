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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWafProtectionResult : AbstractModel
    {
        
        /// <summary>
        /// 全局防护状态
        /// </summary>
        [JsonProperty("GlobalStatus")]
        public string GlobalStatus{ get; set; }

        /// <summary>
        /// 服务防护状态
        /// </summary>
        [JsonProperty("ServicesStatus")]
        public ServiceWafStatus[] ServicesStatus{ get; set; }

        /// <summary>
        /// 路由防护状态
        /// </summary>
        [JsonProperty("RouteStatus")]
        public RouteWafStatus[] RouteStatus{ get; set; }

        /// <summary>
        /// 对象防护状态
        /// </summary>
        [JsonProperty("ObjectStatus")]
        public string ObjectStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalStatus", this.GlobalStatus);
            this.SetParamArrayObj(map, prefix + "ServicesStatus.", this.ServicesStatus);
            this.SetParamArrayObj(map, prefix + "RouteStatus.", this.RouteStatus);
            this.SetParamSimple(map, prefix + "ObjectStatus", this.ObjectStatus);
        }
    }
}

