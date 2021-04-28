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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResponse : AbstractModel
    {
        
        /// <summary>
        /// zone列表
        /// </summary>
        [JsonProperty("ZoneList")]
        public ZoneInfo[] ZoneList{ get; set; }

        /// <summary>
        /// 最大购买实例个数
        /// </summary>
        [JsonProperty("MaxBuyInstanceNum")]
        public long? MaxBuyInstanceNum{ get; set; }

        /// <summary>
        /// 最大购买带宽 单位Mb/s
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// 后付费单位价格
        /// </summary>
        [JsonProperty("UnitPrice")]
        public Price UnitPrice{ get; set; }

        /// <summary>
        /// 后付费消息单价
        /// </summary>
        [JsonProperty("MessagePrice")]
        public Price MessagePrice{ get; set; }

        /// <summary>
        /// 用户独占集群信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// 购买标准版配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// 购买标准版S2配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandardS2")]
        public string StandardS2{ get; set; }

        /// <summary>
        /// 购买专业版配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// 购买物理独占版配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Physical")]
        public string Physical{ get; set; }


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
        }
    }
}

