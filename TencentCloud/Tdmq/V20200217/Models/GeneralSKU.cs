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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralSKU : AbstractModel
    {
        
        /// <summary>
        /// 规格标识
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 是否可售卖
        /// </summary>
        [JsonProperty("OnSale")]
        public bool? OnSale{ get; set; }

        /// <summary>
        /// TPS上限
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// 主题数免费额度
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// 主题数上限
        /// </summary>
        [JsonProperty("TopicNumUpperLimit")]
        public long? TopicNumUpperLimit{ get; set; }

        /// <summary>
        /// 计费项信息
        /// </summary>
        [JsonProperty("PriceTags")]
        public PriceTag[] PriceTags{ get; set; }

        /// <summary>
        /// 存储节点个数
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "OnSale", this.OnSale);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TopicNumUpperLimit", this.TopicNumUpperLimit);
            this.SetParamArrayObj(map, prefix + "PriceTags.", this.PriceTags);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
        }
    }
}

