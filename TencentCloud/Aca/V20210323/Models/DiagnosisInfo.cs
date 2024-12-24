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

    public class DiagnosisInfo : AbstractModel
    {
        
        /// <summary>
        /// 默认0，0:初诊-常规诊疗 1:复诊 2:检验检查/取药/咨询/疫苗 3:信息缺失 4:信息错误
        /// </summary>
        [JsonProperty("IntentType")]
        public long? IntentType{ get; set; }

        /// <summary>
        /// 诊断风险
        /// </summary>
        [JsonProperty("RiskInfo")]
        public string RiskInfo{ get; set; }

        /// <summary>
        /// 疑似诊断列表
        /// </summary>
        [JsonProperty("SuspectedDiagnosis")]
        public SuspectedDiagnosis[] SuspectedDiagnosis{ get; set; }

        /// <summary>
        /// 转诊提醒
        /// </summary>
        [JsonProperty("ReferralInfo")]
        public ReferralInfo ReferralInfo{ get; set; }

        /// <summary>
        /// 危急重症
        /// </summary>
        [JsonProperty("CriticalInfo")]
        public CriticalInfo[] CriticalInfo{ get; set; }

        /// <summary>
        /// 生命体征风险
        /// </summary>
        [JsonProperty("VitalSignsInfo")]
        public VitalSignsInfo VitalSignsInfo{ get; set; }

        /// <summary>
        /// 鉴别诊断
        /// </summary>
        [JsonProperty("DifferDiagnosis")]
        public DifferDiagnosis[] DifferDiagnosis{ get; set; }

        /// <summary>
        /// 病历质控
        /// </summary>
        [JsonProperty("RecordQuality")]
        public RecordQuality RecordQuality{ get; set; }

        /// <summary>
        /// 当前诊断
        /// </summary>
        [JsonProperty("CurrentDiagnosis")]
        public CurrentDiagnosis[] CurrentDiagnosis{ get; set; }

        /// <summary>
        /// 治疗方案
        /// </summary>
        [JsonProperty("TreatmentGuide")]
        public TreatmentGuide[] TreatmentGuide{ get; set; }

        /// <summary>
        /// 病历质控
        /// </summary>
        [JsonProperty("EmrQuality")]
        public EmrQuality EmrQuality{ get; set; }

        /// <summary>
        /// 健康处方
        /// </summary>
        [JsonProperty("HealthPrescriptions")]
        public HealthPrescriptions[] HealthPrescriptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentType", this.IntentType);
            this.SetParamSimple(map, prefix + "RiskInfo", this.RiskInfo);
            this.SetParamArrayObj(map, prefix + "SuspectedDiagnosis.", this.SuspectedDiagnosis);
            this.SetParamObj(map, prefix + "ReferralInfo.", this.ReferralInfo);
            this.SetParamArrayObj(map, prefix + "CriticalInfo.", this.CriticalInfo);
            this.SetParamObj(map, prefix + "VitalSignsInfo.", this.VitalSignsInfo);
            this.SetParamArrayObj(map, prefix + "DifferDiagnosis.", this.DifferDiagnosis);
            this.SetParamObj(map, prefix + "RecordQuality.", this.RecordQuality);
            this.SetParamArrayObj(map, prefix + "CurrentDiagnosis.", this.CurrentDiagnosis);
            this.SetParamArrayObj(map, prefix + "TreatmentGuide.", this.TreatmentGuide);
            this.SetParamObj(map, prefix + "EmrQuality.", this.EmrQuality);
            this.SetParamArrayObj(map, prefix + "HealthPrescriptions.", this.HealthPrescriptions);
        }
    }
}

