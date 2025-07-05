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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Hospitalization : AbstractModel
    {
        
        /// <summary>
        /// 入院时间
        /// </summary>
        [JsonProperty("AdmissionTime")]
        public string AdmissionTime{ get; set; }

        /// <summary>
        /// 出院时间
        /// </summary>
        [JsonProperty("DischargeTime")]
        public string DischargeTime{ get; set; }

        /// <summary>
        /// 住院天数
        /// </summary>
        [JsonProperty("AdmissionDays")]
        public string AdmissionDays{ get; set; }

        /// <summary>
        /// 入院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionDignosis")]
        [System.Obsolete]
        public string AdmissionDignosis{ get; set; }

        /// <summary>
        /// 入院情况
        /// </summary>
        [JsonProperty("AdmissionCondition")]
        public string AdmissionCondition{ get; set; }

        /// <summary>
        /// 诊疗经过
        /// </summary>
        [JsonProperty("DiagnosisTreatment")]
        public string DiagnosisTreatment{ get; set; }

        /// <summary>
        /// 出院诊断
        /// </summary>
        [JsonProperty("DischargeDiagnosis")]
        public string DischargeDiagnosis{ get; set; }

        /// <summary>
        /// 出院医嘱
        /// </summary>
        [JsonProperty("DischargeInstruction")]
        public string DischargeInstruction{ get; set; }

        /// <summary>
        /// 入院诊断
        /// </summary>
        [JsonProperty("AdmissionDiagnosis")]
        public string AdmissionDiagnosis{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdmissionTime", this.AdmissionTime);
            this.SetParamSimple(map, prefix + "DischargeTime", this.DischargeTime);
            this.SetParamSimple(map, prefix + "AdmissionDays", this.AdmissionDays);
            this.SetParamSimple(map, prefix + "AdmissionDignosis", this.AdmissionDignosis);
            this.SetParamSimple(map, prefix + "AdmissionCondition", this.AdmissionCondition);
            this.SetParamSimple(map, prefix + "DiagnosisTreatment", this.DiagnosisTreatment);
            this.SetParamSimple(map, prefix + "DischargeDiagnosis", this.DischargeDiagnosis);
            this.SetParamSimple(map, prefix + "DischargeInstruction", this.DischargeInstruction);
            this.SetParamSimple(map, prefix + "AdmissionDiagnosis", this.AdmissionDiagnosis);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

