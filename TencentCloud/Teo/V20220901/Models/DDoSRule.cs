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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSRule : AbstractModel
    {
        
        /// <summary>
        /// DDoS防护等级。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSStatusInfo")]
        public DDoSStatusInfo DDoSStatusInfo{ get; set; }

        /// <summary>
        /// DDoS地域封禁。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSGeoIp")]
        public DDoSGeoIp DDoSGeoIp{ get; set; }

        /// <summary>
        /// DDoS黑白名单。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSAllowBlock")]
        public DDoSAllowBlock DDoSAllowBlock{ get; set; }

        /// <summary>
        /// DDoS 协议封禁+连接防护。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSAntiPly")]
        public DDoSAntiPly DDoSAntiPly{ get; set; }

        /// <summary>
        /// DDoS特征过滤。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSPacketFilter")]
        public DDoSPacketFilter DDoSPacketFilter{ get; set; }

        /// <summary>
        /// DDoS端口过滤。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSAcl")]
        public DDoSAcl DDoSAcl{ get; set; }

        /// <summary>
        /// DDoS开关，取值有:
        /// <li>on ：开启 ；</li>
        /// <li>off ：关闭 。</li>如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// UDP分片功能是否支持，取值有:
        /// <li>on ：支持 ；</li>
        /// <li>off ：不支持 。</li>仅出参字段，入参无需填写。
        /// </summary>
        [JsonProperty("UdpShardOpen")]
        public string UdpShardOpen{ get; set; }

        /// <summary>
        /// DDoS源站访问速率限制。如果为null，默认使用历史配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSSpeedLimit")]
        public DDoSSpeedLimit DDoSSpeedLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DDoSStatusInfo.", this.DDoSStatusInfo);
            this.SetParamObj(map, prefix + "DDoSGeoIp.", this.DDoSGeoIp);
            this.SetParamObj(map, prefix + "DDoSAllowBlock.", this.DDoSAllowBlock);
            this.SetParamObj(map, prefix + "DDoSAntiPly.", this.DDoSAntiPly);
            this.SetParamObj(map, prefix + "DDoSPacketFilter.", this.DDoSPacketFilter);
            this.SetParamObj(map, prefix + "DDoSAcl.", this.DDoSAcl);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "UdpShardOpen", this.UdpShardOpen);
            this.SetParamObj(map, prefix + "DDoSSpeedLimit.", this.DDoSSpeedLimit);
        }
    }
}

