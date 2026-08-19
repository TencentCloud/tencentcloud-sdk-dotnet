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

    public class DescribePreventUninstallGlobalConfResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启防卸载 0 否 1 是 9 未设置,和0一样是未开启</p>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// <p>开启范围 0 自选主机 1 全部主机</p>
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// <p>正选主机数</p>
        /// </summary>
        [JsonProperty("IncludeHostCount")]
        public ulong? IncludeHostCount{ get; set; }

        /// <summary>
        /// <p>反选主机数</p>
        /// </summary>
        [JsonProperty("ExcludeHostCount")]
        public ulong? ExcludeHostCount{ get; set; }

        /// <summary>
        /// <p>正选quuid列表</p>
        /// </summary>
        [JsonProperty("IncludeQuuid")]
        public string[] IncludeQuuid{ get; set; }

        /// <summary>
        /// <p>反选quuid列表</p>
        /// </summary>
        [JsonProperty("ExcludeQuuid")]
        public string[] ExcludeQuuid{ get; set; }

        /// <summary>
        /// <p>已经开启数</p>
        /// </summary>
        [JsonProperty("EnableCount")]
        public ulong? EnableCount{ get; set; }

        /// <summary>
        /// <p>未开启数</p>
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

