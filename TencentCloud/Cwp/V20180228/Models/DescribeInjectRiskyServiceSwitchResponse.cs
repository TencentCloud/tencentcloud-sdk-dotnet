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

    public class DescribeInjectRiskyServiceSwitchResponse : AbstractModel
    {
        
        /// <summary>
        /// 内存马是否注入风险服务配置，0: 用户没有操作过，默认不注入 1: 注入,2:用户指定不注入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JavaShellInjectRiskyServiceStatus")]
        public ulong? JavaShellInjectRiskyServiceStatus{ get; set; }

        /// <summary>
        /// 主机rasp是否注入风险服务配置，0: 用户没有操作过，默认不注入 1: 注入,2:用户指定不注入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RaspInjectRiskyServiceStatus")]
        public ulong? RaspInjectRiskyServiceStatus{ get; set; }

        /// <summary>
        /// 风险服务总条数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 风险服务列表
        /// </summary>
        [JsonProperty("List")]
        public RiskMainClass[] List{ get; set; }

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
            this.SetParamSimple(map, prefix + "JavaShellInjectRiskyServiceStatus", this.JavaShellInjectRiskyServiceStatus);
            this.SetParamSimple(map, prefix + "RaspInjectRiskyServiceStatus", this.RaspInjectRiskyServiceStatus);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

