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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SuspectedDiagnosis : AbstractModel
    {
        
        /// <summary>
        /// 疾病名称
        /// </summary>
        [JsonProperty("DiseaseName")]
        public string DiseaseName{ get; set; }

        /// <summary>
        /// ICD代码
        /// </summary>
        [JsonProperty("IcdCode")]
        public string IcdCode{ get; set; }

        /// <summary>
        /// 症状
        /// </summary>
        [JsonProperty("Symptom")]
        public string Symptom{ get; set; }

        /// <summary>
        /// 体征
        /// </summary>
        [JsonProperty("Physi")]
        public string Physi{ get; set; }

        /// <summary>
        /// 检查
        /// </summary>
        [JsonProperty("Inspection")]
        public string Inspection{ get; set; }

        /// <summary>
        /// 疾病指南信息
        /// </summary>
        [JsonProperty("DiseaseGuideInfo")]
        public string DiseaseGuideInfo{ get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [JsonProperty("Probability")]
        public float? Probability{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiseaseName", this.DiseaseName);
            this.SetParamSimple(map, prefix + "IcdCode", this.IcdCode);
            this.SetParamSimple(map, prefix + "Symptom", this.Symptom);
            this.SetParamSimple(map, prefix + "Physi", this.Physi);
            this.SetParamSimple(map, prefix + "Inspection", this.Inspection);
            this.SetParamSimple(map, prefix + "DiseaseGuideInfo", this.DiseaseGuideInfo);
            this.SetParamSimple(map, prefix + "Probability", this.Probability);
        }
    }
}

