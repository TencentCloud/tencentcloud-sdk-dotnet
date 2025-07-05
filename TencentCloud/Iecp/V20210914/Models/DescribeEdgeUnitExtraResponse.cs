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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEdgeUnitExtraResponse : AbstractModel
    {
        
        /// <summary>
        /// APIServer类型
        /// </summary>
        [JsonProperty("APIServerType")]
        public string APIServerType{ get; set; }

        /// <summary>
        /// 域名URL
        /// </summary>
        [JsonProperty("APIServerURL")]
        public string APIServerURL{ get; set; }

        /// <summary>
        /// 域名URL对应的端口
        /// </summary>
        [JsonProperty("APIServerURLPort")]
        public string APIServerURLPort{ get; set; }

        /// <summary>
        /// 域名URL对应的端口
        /// </summary>
        [JsonProperty("APIServerResolveIP")]
        public string APIServerResolveIP{ get; set; }

        /// <summary>
        /// 对外可访问的IP
        /// </summary>
        [JsonProperty("APIServerExposeAddress")]
        public string APIServerExposeAddress{ get; set; }

        /// <summary>
        /// 是否开启监控
        /// </summary>
        [JsonProperty("IsCreatePrometheus")]
        public bool? IsCreatePrometheus{ get; set; }

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
            this.SetParamSimple(map, prefix + "APIServerType", this.APIServerType);
            this.SetParamSimple(map, prefix + "APIServerURL", this.APIServerURL);
            this.SetParamSimple(map, prefix + "APIServerURLPort", this.APIServerURLPort);
            this.SetParamSimple(map, prefix + "APIServerResolveIP", this.APIServerResolveIP);
            this.SetParamSimple(map, prefix + "APIServerExposeAddress", this.APIServerExposeAddress);
            this.SetParamSimple(map, prefix + "IsCreatePrometheus", this.IsCreatePrometheus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

