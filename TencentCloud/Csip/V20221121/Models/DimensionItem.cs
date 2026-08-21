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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DimensionItem : AbstractModel
    {
        
        /// <summary>
        /// 维度ID
        /// 枚举值：
        /// risk_governance：风险治理
        /// threat_detection：威胁检测
        /// protection_config：防护配置
        /// </summary>
        [JsonProperty("DimensionId")]
        public string DimensionId{ get; set; }

        /// <summary>
        /// 维度名称
        /// </summary>
        [JsonProperty("DimensionName")]
        public string DimensionName{ get; set; }

        /// <summary>
        /// 维度扣分上限
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// 维度实际扣分
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }

        /// <summary>
        /// 子项列表
        /// </summary>
        [JsonProperty("Categories")]
        public CategoryItem[] Categories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DimensionId", this.DimensionId);
            this.SetParamSimple(map, prefix + "DimensionName", this.DimensionName);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
            this.SetParamArrayObj(map, prefix + "Categories.", this.Categories);
        }
    }
}

