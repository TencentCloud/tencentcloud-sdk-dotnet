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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulTrendResponse : AbstractModel
    {
        
        /// <summary>
        /// 近半年漏洞利用攻击事件数量
        /// </summary>
        [JsonProperty("VulEventCount")]
        public ulong? VulEventCount{ get; set; }

        /// <summary>
        /// 近半年新增漏洞利用攻击事件数量
        /// </summary>
        [JsonProperty("IncreaseVulEventCount")]
        public ulong? IncreaseVulEventCount{ get; set; }

        /// <summary>
        /// 近半年热点攻击漏洞
        /// </summary>
        [JsonProperty("HotVulCount")]
        public ulong? HotVulCount{ get; set; }

        /// <summary>
        /// 近半年新增热点攻击漏洞
        /// </summary>
        [JsonProperty("IncreaseHotVulCount")]
        public ulong? IncreaseHotVulCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "VulEventCount", this.VulEventCount);
            this.SetParamSimple(map, prefix + "IncreaseVulEventCount", this.IncreaseVulEventCount);
            this.SetParamSimple(map, prefix + "HotVulCount", this.HotVulCount);
            this.SetParamSimple(map, prefix + "IncreaseHotVulCount", this.IncreaseHotVulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

