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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrugInstructionInfo : AbstractModel
    {
        
        /// <summary>
        /// 药品id
        /// </summary>
        [JsonProperty("DrugId")]
        public string DrugId{ get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// 生产企业
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 用法用量
        /// </summary>
        [JsonProperty("DrugUsage")]
        public string DrugUsage{ get; set; }

        /// <summary>
        /// 适应症
        /// </summary>
        [JsonProperty("Indication")]
        public string Indication{ get; set; }

        /// <summary>
        /// 不良反应
        /// </summary>
        [JsonProperty("AdverseReaction")]
        public string AdverseReaction{ get; set; }

        /// <summary>
        /// 是否处方药，0:非处方药，1:处方药
        /// </summary>
        [JsonProperty("DrugRxType")]
        public long? DrugRxType{ get; set; }

        /// <summary>
        /// 药品说明书URL
        /// </summary>
        [JsonProperty("DocUrl")]
        public string DocUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugId", this.DrugId);
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "TradeName", this.TradeName);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "DrugUsage", this.DrugUsage);
            this.SetParamSimple(map, prefix + "Indication", this.Indication);
            this.SetParamSimple(map, prefix + "AdverseReaction", this.AdverseReaction);
            this.SetParamSimple(map, prefix + "DrugRxType", this.DrugRxType);
            this.SetParamSimple(map, prefix + "DocUrl", this.DocUrl);
        }
    }
}

