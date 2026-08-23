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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficSandboxACLDstRule : AbstractModel
    {
        
        /// <summary>
        /// 目标 IP 列表
        /// 入参限制：每项支持三种格式：单个 IP（如 10.0.0.1）、网段（如 10.0.0.1/24）、IP 范围（如 10.0.0.1-10.0.2.0）
        /// </summary>
        [JsonProperty("DstIP")]
        public string[] DstIP{ get; set; }

        /// <summary>
        /// 排除的目标 IP 列表
        /// 入参限制：格式同 DstIP
        /// </summary>
        [JsonProperty("DstIPExcept")]
        public string[] DstIPExcept{ get; set; }

        /// <summary>
        /// 目标端口或端口范围
        /// 入参限制：单端口如 80，端口范围如 8000-9000
        /// </summary>
        [JsonProperty("DstPort")]
        public string[] DstPort{ get; set; }

        /// <summary>
        /// 排除的目标端口列表
        /// 入参限制：格式同 DstPort
        /// </summary>
        [JsonProperty("DstPortExcept")]
        public string[] DstPortExcept{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DstIP.", this.DstIP);
            this.SetParamArraySimple(map, prefix + "DstIPExcept.", this.DstIPExcept);
            this.SetParamArraySimple(map, prefix + "DstPort.", this.DstPort);
            this.SetParamArraySimple(map, prefix + "DstPortExcept.", this.DstPortExcept);
        }
    }
}

