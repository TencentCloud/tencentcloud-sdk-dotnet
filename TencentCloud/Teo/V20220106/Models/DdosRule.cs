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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DdosRule : AbstractModel
    {
        
        /// <summary>
        /// DDoS防护等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosStatusInfo")]
        public DDoSStatusInfo DdosStatusInfo{ get; set; }

        /// <summary>
        /// DDoS地域封禁
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosGeoIp")]
        public DDoSGeoIp DdosGeoIp{ get; set; }

        /// <summary>
        /// DDoS黑白名单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosAllowBlock")]
        public DdosAllowBlock DdosAllowBlock{ get; set; }

        /// <summary>
        /// DDoS 协议封禁+连接防护
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosAntiPly")]
        public DDoSAntiPly DdosAntiPly{ get; set; }

        /// <summary>
        /// DDoS特征过滤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosPacketFilter")]
        public DdosPacketFilter DdosPacketFilter{ get; set; }

        /// <summary>
        /// DDoS端口过滤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdosAcl")]
        public DdosAcls DdosAcl{ get; set; }

        /// <summary>
        /// DDoS开关 on-开启；off-关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DdosStatusInfo.", this.DdosStatusInfo);
            this.SetParamObj(map, prefix + "DdosGeoIp.", this.DdosGeoIp);
            this.SetParamObj(map, prefix + "DdosAllowBlock.", this.DdosAllowBlock);
            this.SetParamObj(map, prefix + "DdosAntiPly.", this.DdosAntiPly);
            this.SetParamObj(map, prefix + "DdosPacketFilter.", this.DdosPacketFilter);
            this.SetParamObj(map, prefix + "DdosAcl.", this.DdosAcl);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

