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

    public class RequestCase : AbstractModel
    {
        
        /// <summary>
        /// 处方类型 0:门诊处方；1:住院医嘱；2:急诊处方 
        /// </summary>
        [JsonProperty("CaseType")]
        public long? CaseType{ get; set; }

        /// <summary>
        /// 主诉
        /// </summary>
        [JsonProperty("ChiefComplaint")]
        public string ChiefComplaint{ get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }

        /// <summary>
        /// 病历文书ID
        /// 医生每次书写病历文书的ID，文书内容包含主诉，病史，当前诊断等内容<br />门诊场景：门诊病历文书（带有主诉、病史、诊断及药品的）只有一份，这个编号只有一个。<br/>住院场景：假设住院3天，医生每天都会写一份病历文书（带有主诉、病史、诊断及医嘱药品的文书），那么有对应三个病历文书编号，每次调用预测接口都要传入不同的病历文书编号。注意：如两次调用预测接口，传相同的caseid，则在药师端管理平台的上一次审方记录中的诊断会被本次接口传入的诊断更新。
        /// </summary>
        [JsonProperty("CaseId")]
        public string CaseId{ get; set; }

        /// <summary>
        /// 病历更新时间
        /// </summary>
        [JsonProperty("CaseTime")]
        public string CaseTime{ get; set; }

        /// <summary>
        /// 就诊ID
        /// 门诊处方传门诊号，住院医嘱传住院号；备注：门诊场景：用户挂一次号，看一个医生，这时候会有一个代表变成就诊的编号，下一次挂号就诊，这个编号会变。<br/>住院场景：用户本次办理入院，会有一个住院编号，仅代表本次住院，如果下次再住院，这个编号会变。
        /// </summary>
        [JsonProperty("VisitId")]
        public string VisitId{ get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [JsonProperty("PatientBaseinfo")]
        public PatientBaseInfo PatientBaseinfo{ get; set; }

        /// <summary>
        /// 医生信息
        /// </summary>
        [JsonProperty("DoctorInfo")]
        public DoctorInfo DoctorInfo{ get; set; }

        /// <summary>
        /// 现病史
        /// </summary>
        [JsonProperty("PresentIllness")]
        public string PresentIllness{ get; set; }

        /// <summary>
        /// 患者其他信息，包含过敏史等
        /// </summary>
        [JsonProperty("PatientOther")]
        public string PatientOther{ get; set; }

        /// <summary>
        /// 患者过往病史
        /// </summary>
        [JsonProperty("PatientHistory")]
        public PatientHistory PatientHistory{ get; set; }

        /// <summary>
        /// 患者家族病史
        /// </summary>
        [JsonProperty("PatientFamilyHistory")]
        public PatientFamilyHistory PatientFamilyHistory{ get; set; }

        /// <summary>
        /// 体格检查
        /// </summary>
        [JsonProperty("PhysicalExam")]
        public PhysicalExam PhysicalExam{ get; set; }

        /// <summary>
        /// 诊断列表，第一个为首要诊断
        /// </summary>
        [JsonProperty("EmrDiagnosises")]
        public EmrDiagnosises[] EmrDiagnosises{ get; set; }

        /// <summary>
        /// 处方列表
        /// </summary>
        [JsonProperty("Prescriptions")]
        public DrugUsage[] Prescriptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaseType", this.CaseType);
            this.SetParamSimple(map, prefix + "ChiefComplaint", this.ChiefComplaint);
            this.SetParamSimple(map, prefix + "Department", this.Department);
            this.SetParamSimple(map, prefix + "CaseId", this.CaseId);
            this.SetParamSimple(map, prefix + "CaseTime", this.CaseTime);
            this.SetParamSimple(map, prefix + "VisitId", this.VisitId);
            this.SetParamObj(map, prefix + "PatientBaseinfo.", this.PatientBaseinfo);
            this.SetParamObj(map, prefix + "DoctorInfo.", this.DoctorInfo);
            this.SetParamSimple(map, prefix + "PresentIllness", this.PresentIllness);
            this.SetParamSimple(map, prefix + "PatientOther", this.PatientOther);
            this.SetParamObj(map, prefix + "PatientHistory.", this.PatientHistory);
            this.SetParamObj(map, prefix + "PatientFamilyHistory.", this.PatientFamilyHistory);
            this.SetParamObj(map, prefix + "PhysicalExam.", this.PhysicalExam);
            this.SetParamArrayObj(map, prefix + "EmrDiagnosises.", this.EmrDiagnosises);
            this.SetParamArrayObj(map, prefix + "Prescriptions.", this.Prescriptions);
        }
    }
}

