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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectThresholdRelation : AbstractModel
    {
        
        /// <summary>
        /// DDoS防护等级，取值[
        /// low(宽松)
        /// middle(适中)
        /// high(严格)
        /// ]
        /// </summary>
        [JsonProperty("DDoSLevel")]
        public string DDoSLevel{ get; set; }

        /// <summary>
        /// DDoS清洗阈值，单位Mbps
        /// </summary>
        [JsonProperty("DDoSThreshold")]
        public ulong? DDoSThreshold{ get; set; }

        /// <summary>
        /// DDoS的AI防护开关，取值[
        /// on(开启)
        /// off(关闭)
        /// ]
        /// </summary>
        [JsonProperty("DDoSAI")]
        public string DDoSAI{ get; set; }

        /// <summary>
        /// CC清洗开关，取值[
        /// 0(关闭)
        /// 1(开启)
        /// ]
        /// </summary>
        [JsonProperty("CCEnable")]
        public ulong? CCEnable{ get; set; }

        /// <summary>
        /// CC清洗阈值，单位QPS
        /// </summary>
        [JsonProperty("CCThreshold")]
        public ulong? CCThreshold{ get; set; }

        /// <summary>
        /// 所属的资源实例
        /// </summary>
        [JsonProperty("InstanceDetailList")]
        public InstanceRelation[] InstanceDetailList{ get; set; }

        /// <summary>
        /// 域名与协议纬度的防护阈值
        /// </summary>
        [JsonProperty("ListenerCcThresholdList")]
        public ListenerCcThreholdConfig[] ListenerCcThresholdList{ get; set; }

        /// <summary>
        /// SYN FLOOD流量阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SynFloodThreshold")]
        public ulong? SynFloodThreshold{ get; set; }

        /// <summary>
        /// SYN FLOOD包量阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SynFloodPktThreshold")]
        public ulong? SynFloodPktThreshold{ get; set; }

        /// <summary>
        /// UDP FLOOD流量阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UdpFloodThreshold")]
        public ulong? UdpFloodThreshold{ get; set; }

        /// <summary>
        /// UDP FLOOD包量阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UdpFloodPktThreshold")]
        public ulong? UdpFloodPktThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DDoSLevel", this.DDoSLevel);
            this.SetParamSimple(map, prefix + "DDoSThreshold", this.DDoSThreshold);
            this.SetParamSimple(map, prefix + "DDoSAI", this.DDoSAI);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
            this.SetParamSimple(map, prefix + "CCThreshold", this.CCThreshold);
            this.SetParamArrayObj(map, prefix + "InstanceDetailList.", this.InstanceDetailList);
            this.SetParamArrayObj(map, prefix + "ListenerCcThresholdList.", this.ListenerCcThresholdList);
            this.SetParamSimple(map, prefix + "SynFloodThreshold", this.SynFloodThreshold);
            this.SetParamSimple(map, prefix + "SynFloodPktThreshold", this.SynFloodPktThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodThreshold", this.UdpFloodThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodPktThreshold", this.UdpFloodPktThreshold);
        }
    }
}

