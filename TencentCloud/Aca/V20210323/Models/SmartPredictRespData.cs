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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartPredictRespData : AbstractModel
    {
        
        /// <summary>
        /// 诊断辅助内容
        /// </summary>
        [JsonProperty("DiagnosisInfo")]
        public DiagnosisInfo DiagnosisInfo{ get; set; }

        /// <summary>
        /// 用药风险信息
        /// </summary>
        [JsonProperty("RationalDrugInfo")]
        public RationalDrugInfo RationalDrugInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DiagnosisInfo.", this.DiagnosisInfo);
            this.SetParamObj(map, prefix + "RationalDrugInfo.", this.RationalDrugInfo);
        }
    }
}

