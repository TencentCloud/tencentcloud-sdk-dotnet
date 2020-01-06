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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindRealServer : AbstractModel
    {
        
        /// <summary>
        /// 源站ID
        /// </summary>
        [JsonProperty("RealServerId")]
        public string RealServerId{ get; set; }

        /// <summary>
        /// 源站IP或者域名
        /// </summary>
        [JsonProperty("RealServerIP")]
        public string RealServerIP{ get; set; }

        /// <summary>
        /// 该源站所占权重
        /// </summary>
        [JsonProperty("RealServerWeight")]
        public long? RealServerWeight{ get; set; }

        /// <summary>
        /// 源站健康检查状态，其中：
        /// 0，正常；
        /// 1，异常。
        /// 未开启健康检查状态时，该状态始终为正常。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerStatus")]
        public long? RealServerStatus{ get; set; }

        /// <summary>
        /// 源站的端口号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerPort")]
        public long? RealServerPort{ get; set; }

        /// <summary>
        /// 当源站为域名时，域名被解析成一个或者多个IP，该字段表示其中异常的IP列表。状态异常，但该字段为空时，表示域名解析异常。
        /// </summary>
        [JsonProperty("DownIPList")]
        public string[] DownIPList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServerId", this.RealServerId);
            this.SetParamSimple(map, prefix + "RealServerIP", this.RealServerIP);
            this.SetParamSimple(map, prefix + "RealServerWeight", this.RealServerWeight);
            this.SetParamSimple(map, prefix + "RealServerStatus", this.RealServerStatus);
            this.SetParamSimple(map, prefix + "RealServerPort", this.RealServerPort);
            this.SetParamArraySimple(map, prefix + "DownIPList.", this.DownIPList);
        }
    }
}

