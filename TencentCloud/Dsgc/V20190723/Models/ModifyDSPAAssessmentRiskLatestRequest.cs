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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDSPAAssessmentRiskLatestRequest : AbstractModel
    {
        
        /// <summary>
        /// dspa实例id
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 风险状态（waiting:待处理，processing:处理中，finished:已处理，ignored:已忽略）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 最新风险项Id
        /// </summary>
        [JsonProperty("RiskLatestTableId")]
        [System.Obsolete]
        public ulong? RiskLatestTableId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 处置人
        /// </summary>
        [JsonProperty("ProcessPeople")]
        public string ProcessPeople{ get; set; }

        /// <summary>
        /// 批量处理的列表
        /// </summary>
        [JsonProperty("BathRiskIdList")]
        public long?[] BathRiskIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskLatestTableId", this.RiskLatestTableId);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "ProcessPeople", this.ProcessPeople);
            this.SetParamArraySimple(map, prefix + "BathRiskIdList.", this.BathRiskIdList);
        }
    }
}

