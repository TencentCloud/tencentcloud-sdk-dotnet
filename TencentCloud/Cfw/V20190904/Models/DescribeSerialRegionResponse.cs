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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSerialRegionResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>串行地域带宽分配</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialRegionLst")]
        public SerialRegionInfo[] SerialRegionLst{ get; set; }

        /// <summary>
        /// <p>剩余可分配通用带宽 单位M</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnUsedWidth")]
        public long? UnUsedWidth{ get; set; }

        /// <summary>
        /// <p>可配置实例个数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnUsedQuota")]
        public long? UnUsedQuota{ get; set; }

        /// <summary>
        /// <p>旁路带宽数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BypassWidth")]
        public long? BypassWidth{ get; set; }

        /// <summary>
        /// <p>赠送的旁路带宽数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendBypassWidth")]
        public long? SendBypassWidth{ get; set; }

        /// <summary>
        /// <p>互联网边界防火墙总带宽</p>
        /// </summary>
        [JsonProperty("EdgeWidth")]
        public long? EdgeWidth{ get; set; }

        /// <summary>
        /// <p>互联网边界弹性开关</p>
        /// </summary>
        [JsonProperty("EdgeElasticSwitch")]
        public long? EdgeElasticSwitch{ get; set; }

        /// <summary>
        /// <p>互联网边界弹性带宽值</p>
        /// </summary>
        [JsonProperty("EdgeElasticBandwidth")]
        public long? EdgeElasticBandwidth{ get; set; }

        /// <summary>
        /// <p>互联网边界弹性带宽上限</p>
        /// </summary>
        [JsonProperty("EdgeElasticBandwidthLimit")]
        public long? EdgeElasticBandwidthLimit{ get; set; }

        /// <summary>
        /// <p>互联网边界防火墙计量开关</p><p>枚举值：</p><ul><li>0： 关闭</li><li>1： 打开</li></ul>
        /// </summary>
        [JsonProperty("EdgeElasticTrafficSwitch")]
        public long? EdgeElasticTrafficSwitch{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "SerialRegionLst.", this.SerialRegionLst);
            this.SetParamSimple(map, prefix + "UnUsedWidth", this.UnUsedWidth);
            this.SetParamSimple(map, prefix + "UnUsedQuota", this.UnUsedQuota);
            this.SetParamSimple(map, prefix + "BypassWidth", this.BypassWidth);
            this.SetParamSimple(map, prefix + "SendBypassWidth", this.SendBypassWidth);
            this.SetParamSimple(map, prefix + "EdgeWidth", this.EdgeWidth);
            this.SetParamSimple(map, prefix + "EdgeElasticSwitch", this.EdgeElasticSwitch);
            this.SetParamSimple(map, prefix + "EdgeElasticBandwidth", this.EdgeElasticBandwidth);
            this.SetParamSimple(map, prefix + "EdgeElasticBandwidthLimit", this.EdgeElasticBandwidthLimit);
            this.SetParamSimple(map, prefix + "EdgeElasticTrafficSwitch", this.EdgeElasticTrafficSwitch);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

