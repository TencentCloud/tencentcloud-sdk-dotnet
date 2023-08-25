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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDSPAESTaskResultRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 字段扫描结果ID
        /// </summary>
        [JsonProperty("FieldResultId")]
        public long? FieldResultId{ get; set; }

        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }

        /// <summary>
        /// 是否设置为非敏感字段
        /// </summary>
        [JsonProperty("IsSetNonSensitiveField")]
        public bool? IsSetNonSensitiveField{ get; set; }

        /// <summary>
        /// 调整后新的规则ID
        /// </summary>
        [JsonProperty("DestRuleId")]
        public long? DestRuleId{ get; set; }

        /// <summary>
        /// 调整后新的分类ID
        /// </summary>
        [JsonProperty("DestCategoryId")]
        public long? DestCategoryId{ get; set; }

        /// <summary>
        /// 调整后新的分级ID
        /// </summary>
        [JsonProperty("DestLevelId")]
        public long? DestLevelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "FieldResultId", this.FieldResultId);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "IsSetNonSensitiveField", this.IsSetNonSensitiveField);
            this.SetParamSimple(map, prefix + "DestRuleId", this.DestRuleId);
            this.SetParamSimple(map, prefix + "DestCategoryId", this.DestCategoryId);
            this.SetParamSimple(map, prefix + "DestLevelId", this.DestLevelId);
        }
    }
}

