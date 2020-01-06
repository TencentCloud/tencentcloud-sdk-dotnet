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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSPolicyPortLimit : AbstractModel
    {
        
        /// <summary>
        /// 协议，取值范围[tcp,udp,icmp,all]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 开始目的端口，取值范围[0,65535]
        /// </summary>
        [JsonProperty("DPortStart")]
        public ulong? DPortStart{ get; set; }

        /// <summary>
        /// 结束目的端口，取值范围[0,65535]，要求大于等于开始目的端口
        /// </summary>
        [JsonProperty("DPortEnd")]
        public ulong? DPortEnd{ get; set; }

        /// <summary>
        /// 开始源端口，取值范围[0,65535]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SPortStart")]
        public ulong? SPortStart{ get; set; }

        /// <summary>
        /// 结束源端口，取值范围[0,65535]，要求大于等于开始源端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SPortEnd")]
        public ulong? SPortEnd{ get; set; }

        /// <summary>
        /// 执行动作，取值[drop(丢弃) ，transmit(转发)]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 禁用端口类型，取值[0（目的端口范围禁用）， 1（源端口范围禁用）， 2（目的和源端口范围同时禁用）]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DPortStart", this.DPortStart);
            this.SetParamSimple(map, prefix + "DPortEnd", this.DPortEnd);
            this.SetParamSimple(map, prefix + "SPortStart", this.SPortStart);
            this.SetParamSimple(map, prefix + "SPortEnd", this.SPortEnd);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
        }
    }
}

