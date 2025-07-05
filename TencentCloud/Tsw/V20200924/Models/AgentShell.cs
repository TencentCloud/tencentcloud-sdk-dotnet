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

namespace TencentCloud.Tsw.V20200924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentShell : AbstractModel
    {
        
        /// <summary>
        /// 鉴权token
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 数据接收Ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EtlIp")]
        public string EtlIp{ get; set; }

        /// <summary>
        /// 数据接收port
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EtlPort")]
        public string EtlPort{ get; set; }

        /// <summary>
        /// 手动接入脚本串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ByHandAccess")]
        public string ByHandAccess{ get; set; }

        /// <summary>
        /// 自动接入脚本串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ByShellAccess")]
        public string ByShellAccess{ get; set; }

        /// <summary>
        /// SkyWalking数据接收port
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkyWalkingPort")]
        public string SkyWalkingPort{ get; set; }

        /// <summary>
        /// Zipkin数据接收port
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZipkinPort")]
        public string ZipkinPort{ get; set; }

        /// <summary>
        /// Jaeger数据接收port
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JaegerPort")]
        public string JaegerPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "EtlIp", this.EtlIp);
            this.SetParamSimple(map, prefix + "EtlPort", this.EtlPort);
            this.SetParamSimple(map, prefix + "ByHandAccess", this.ByHandAccess);
            this.SetParamSimple(map, prefix + "ByShellAccess", this.ByShellAccess);
            this.SetParamSimple(map, prefix + "SkyWalkingPort", this.SkyWalkingPort);
            this.SetParamSimple(map, prefix + "ZipkinPort", this.ZipkinPort);
            this.SetParamSimple(map, prefix + "JaegerPort", this.JaegerPort);
        }
    }
}

