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

    public class RuleContentProcessNetwork : AbstractModel
    {
        
        /// <summary>
        /// <p>当前进程</p>
        /// </summary>
        [JsonProperty("Process")]
        public RuleContentProcessInfo Process{ get; set; }

        /// <summary>
        /// <p>目标IP（必填）: 支持单个IP/IP范围/CIDR, 支持IPv4和IPv6</p>
        /// </summary>
        [JsonProperty("DstIP")]
        public string DstIP{ get; set; }

        /// <summary>
        /// <p>父进程</p>
        /// </summary>
        [JsonProperty("ParentProcess")]
        public RuleContentProcessInfo ParentProcess{ get; set; }

        /// <summary>
        /// <p>目标端口列表（可选）: 支持1-65535, 为空表示不限端口</p>
        /// </summary>
        [JsonProperty("DstPorts")]
        public ulong?[] DstPorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Process.", this.Process);
            this.SetParamSimple(map, prefix + "DstIP", this.DstIP);
            this.SetParamObj(map, prefix + "ParentProcess.", this.ParentProcess);
            this.SetParamArraySimple(map, prefix + "DstPorts.", this.DstPorts);
        }
    }
}

