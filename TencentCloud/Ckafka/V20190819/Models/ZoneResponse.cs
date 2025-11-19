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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>zone列表</p>
        /// </summary>
        [JsonProperty("ZoneList")]
        public ZoneInfo[] ZoneList{ get; set; }

        /// <summary>
        /// <p>最大购买实例个数</p>
        /// </summary>
        [JsonProperty("MaxBuyInstanceNum")]
        public long? MaxBuyInstanceNum{ get; set; }

        /// <summary>
        /// <p>最大购买带宽 单位Mb/s</p>
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// <p>后付费单位价格</p>
        /// </summary>
        [JsonProperty("UnitPrice")]
        public Price UnitPrice{ get; set; }

        /// <summary>
        /// <p>后付费消息单价</p>
        /// </summary>
        [JsonProperty("MessagePrice")]
        public Price MessagePrice{ get; set; }

        /// <summary>
        /// <p>用户独占集群信息</p>
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// <p>购买标准版配置</p>
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// <p>购买标准版S2配置</p>
        /// </summary>
        [JsonProperty("StandardS2")]
        public string StandardS2{ get; set; }

        /// <summary>
        /// <p>购买专业版配置</p>
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// <p>购买物理独占版配置</p>
        /// </summary>
        [JsonProperty("Physical")]
        public string Physical{ get; set; }

        /// <summary>
        /// <p>公网带宽 最小3Mbps  最大999Mbps 仅专业版支持填写   已废弃,无实际意义</p>
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public string PublicNetwork{ get; set; }

        /// <summary>
        /// <p>公网带宽配置</p>
        /// </summary>
        [JsonProperty("PublicNetworkLimit")]
        public string PublicNetworkLimit{ get; set; }

        /// <summary>
        /// <p>请求Id</p>
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// <p>分页offset</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>分页limit</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>是否必须录入tag</p>
        /// </summary>
        [JsonProperty("ForceCheckTag")]
        public bool? ForceCheckTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "MaxBuyInstanceNum", this.MaxBuyInstanceNum);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamObj(map, prefix + "UnitPrice.", this.UnitPrice);
            this.SetParamObj(map, prefix + "MessagePrice.", this.MessagePrice);
            this.SetParamArrayObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "Standard", this.Standard);
            this.SetParamSimple(map, prefix + "StandardS2", this.StandardS2);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "Physical", this.Physical);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "PublicNetworkLimit", this.PublicNetworkLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ForceCheckTag", this.ForceCheckTag);
        }
    }
}

