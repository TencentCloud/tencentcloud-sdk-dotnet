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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetAttackTopInfo : AbstractModel
    {
        
        /// <summary>
        /// 网络攻击主机维度top统计数据
        /// </summary>
        [JsonProperty("Agent")]
        public TopInfo[] Agent{ get; set; }

        /// <summary>
        /// 网络攻击ip来源维度top统计数据
        /// </summary>
        [JsonProperty("SrcIp")]
        public TopInfo[] SrcIp{ get; set; }

        /// <summary>
        /// 网络攻击目标端口维度top统计数据
        /// </summary>
        [JsonProperty("DstPort")]
        public TopInfo[] DstPort{ get; set; }

        /// <summary>
        /// 网络攻击漏洞维度top统计数据
        /// </summary>
        [JsonProperty("Vul")]
        public TopInfo[] Vul{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "SrcIp.", this.SrcIp);
            this.SetParamArrayObj(map, prefix + "DstPort.", this.DstPort);
            this.SetParamArrayObj(map, prefix + "Vul.", this.Vul);
        }
    }
}

