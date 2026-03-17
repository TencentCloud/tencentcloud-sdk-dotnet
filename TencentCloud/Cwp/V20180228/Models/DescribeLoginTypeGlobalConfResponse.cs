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

    public class DescribeLoginTypeGlobalConfResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启防卸载 <li>0 否</li> <li>1 是</li> <li>9 未设置,和0一样是未开启</li>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 开启范围 <li>0 自选主机</li> <li>1 全部主机</li>
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// 正选主机配置数
        /// </summary>
        [JsonProperty("IncludeHostCount")]
        public ulong? IncludeHostCount{ get; set; }

        /// <summary>
        /// 反选主机配置数
        /// </summary>
        [JsonProperty("ExcludeHostCount")]
        public ulong? ExcludeHostCount{ get; set; }

        /// <summary>
        /// 正选quuid配置列表
        /// </summary>
        [JsonProperty("IncludeQuuid")]
        public string[] IncludeQuuid{ get; set; }

        /// <summary>
        /// 反选quuid配置列表
        /// </summary>
        [JsonProperty("ExcludeQuuid")]
        public string[] ExcludeQuuid{ get; set; }

        /// <summary>
        /// 已开启机器数
        /// </summary>
        [JsonProperty("EnableCount")]
        public ulong? EnableCount{ get; set; }

        /// <summary>
        /// 未启机器数
        /// </summary>
        [JsonProperty("DisableCount")]
        public ulong? DisableCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "IncludeHostCount", this.IncludeHostCount);
            this.SetParamSimple(map, prefix + "ExcludeHostCount", this.ExcludeHostCount);
            this.SetParamArraySimple(map, prefix + "IncludeQuuid.", this.IncludeQuuid);
            this.SetParamArraySimple(map, prefix + "ExcludeQuuid.", this.ExcludeQuuid);
            this.SetParamSimple(map, prefix + "EnableCount", this.EnableCount);
            this.SetParamSimple(map, prefix + "DisableCount", this.DisableCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

