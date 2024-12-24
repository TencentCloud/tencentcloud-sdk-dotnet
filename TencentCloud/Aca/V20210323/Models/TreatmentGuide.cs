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

    public class TreatmentGuide : AbstractModel
    {
        
        /// <summary>
        /// 医生诊断
        /// </summary>
        [JsonProperty("DoctorDiagnosis")]
        public string DoctorDiagnosis{ get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [JsonProperty("DiseaseName")]
        public string DiseaseName{ get; set; }

        /// <summary>
        /// 治疗详情链接
        /// </summary>
        [JsonProperty("TreatDetailUrl")]
        public string TreatDetailUrl{ get; set; }

        /// <summary>
        /// 治疗方案
        /// </summary>
        [JsonProperty("TreatPlan")]
        public string TreatPlan{ get; set; }

        /// <summary>
        /// 治疗原则
        /// </summary>
        [JsonProperty("TreatPrinciple")]
        public string TreatPrinciple{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DoctorDiagnosis", this.DoctorDiagnosis);
            this.SetParamSimple(map, prefix + "DiseaseName", this.DiseaseName);
            this.SetParamSimple(map, prefix + "TreatDetailUrl", this.TreatDetailUrl);
            this.SetParamSimple(map, prefix + "TreatPlan", this.TreatPlan);
            this.SetParamSimple(map, prefix + "TreatPrinciple", this.TreatPrinciple);
        }
    }
}

