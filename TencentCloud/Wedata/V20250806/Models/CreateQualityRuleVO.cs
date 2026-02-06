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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateQualityRuleVO : AbstractModel
    {
        
        /// <summary>
        /// 操作结果文案
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 单条数据新增结果对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Results")]
        public QualityRuleCreateResult[] Results{ get; set; }

        /// <summary>
        /// 总新增条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SumCount")]
        public ulong? SumCount{ get; set; }

        /// <summary>
        /// 新增成功条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// 新增失败条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedCount")]
        public ulong? FailedCount{ get; set; }

        /// <summary>
        /// 新增成功的 ruleId集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessRuleIds")]
        public ulong?[] SuccessRuleIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "SumCount", this.SumCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamArraySimple(map, prefix + "SuccessRuleIds.", this.SuccessRuleIds);
        }
    }
}

