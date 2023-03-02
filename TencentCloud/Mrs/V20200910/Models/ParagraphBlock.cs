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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParagraphBlock : AbstractModel
    {
        
        /// <summary>
        /// 切口愈合情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncisionHealingText")]
        public string IncisionHealingText{ get; set; }

        /// <summary>
        /// 辅助检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuxiliaryExaminationText")]
        public string AuxiliaryExaminationText{ get; set; }

        /// <summary>
        /// 特殊检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialExamText")]
        public string SpecialExamText{ get; set; }

        /// <summary>
        /// 门诊诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutpatientDiagnosisText")]
        public string OutpatientDiagnosisText{ get; set; }

        /// <summary>
        /// 入院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionConditionText")]
        public string AdmissionConditionText{ get; set; }

        /// <summary>
        /// 诊疗经过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckAndTreatmentProcessText")]
        public string CheckAndTreatmentProcessText{ get; set; }

        /// <summary>
        /// 体征
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SymptomsAndSignsText")]
        public string SymptomsAndSignsText{ get; set; }

        /// <summary>
        /// 出院医嘱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeInstructionsText")]
        public string DischargeInstructionsText{ get; set; }

        /// <summary>
        /// 入院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionDiagnosisText")]
        public string AdmissionDiagnosisText{ get; set; }

        /// <summary>
        /// 手术情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SurgeryConditionText")]
        public string SurgeryConditionText{ get; set; }

        /// <summary>
        /// 病理诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologicalDiagnosisText")]
        public string PathologicalDiagnosisText{ get; set; }

        /// <summary>
        /// 出院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeConditionText")]
        public string DischargeConditionText{ get; set; }

        /// <summary>
        /// 检查记录
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRecordText")]
        public string CheckRecordText{ get; set; }

        /// <summary>
        /// 主诉
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChiefComplaintText")]
        public string ChiefComplaintText{ get; set; }

        /// <summary>
        /// 出院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeDiagnosisText")]
        public string DischargeDiagnosisText{ get; set; }

        /// <summary>
        /// 既往史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainDiseaseHistoryText")]
        public string MainDiseaseHistoryText{ get; set; }

        /// <summary>
        /// 现病史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseasePresentText")]
        public string DiseasePresentText{ get; set; }

        /// <summary>
        /// 个人史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalHistoryText")]
        public string PersonalHistoryText{ get; set; }

        /// <summary>
        /// 月经史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstruallHistoryText")]
        public string MenstruallHistoryText{ get; set; }

        /// <summary>
        /// 婚育史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObstericalHistoryText")]
        public string ObstericalHistoryText{ get; set; }

        /// <summary>
        /// 家族史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FamilyHistoryText")]
        public string FamilyHistoryText{ get; set; }

        /// <summary>
        /// 过敏史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllergyHistoryText")]
        public string AllergyHistoryText{ get; set; }

        /// <summary>
        /// 病史信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseaseHistoryText")]
        public string DiseaseHistoryText{ get; set; }

        /// <summary>
        /// 其它诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherDiagnosisText")]
        public string OtherDiagnosisText{ get; set; }

        /// <summary>
        /// 体格检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BodyExaminationText")]
        public string BodyExaminationText{ get; set; }

        /// <summary>
        /// 专科检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialistExaminationText")]
        public string SpecialistExaminationText{ get; set; }

        /// <summary>
        /// 治疗结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreatmentResultText")]
        public string TreatmentResultText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IncisionHealingText", this.IncisionHealingText);
            this.SetParamSimple(map, prefix + "AuxiliaryExaminationText", this.AuxiliaryExaminationText);
            this.SetParamSimple(map, prefix + "SpecialExamText", this.SpecialExamText);
            this.SetParamSimple(map, prefix + "OutpatientDiagnosisText", this.OutpatientDiagnosisText);
            this.SetParamSimple(map, prefix + "AdmissionConditionText", this.AdmissionConditionText);
            this.SetParamSimple(map, prefix + "CheckAndTreatmentProcessText", this.CheckAndTreatmentProcessText);
            this.SetParamSimple(map, prefix + "SymptomsAndSignsText", this.SymptomsAndSignsText);
            this.SetParamSimple(map, prefix + "DischargeInstructionsText", this.DischargeInstructionsText);
            this.SetParamSimple(map, prefix + "AdmissionDiagnosisText", this.AdmissionDiagnosisText);
            this.SetParamSimple(map, prefix + "SurgeryConditionText", this.SurgeryConditionText);
            this.SetParamSimple(map, prefix + "PathologicalDiagnosisText", this.PathologicalDiagnosisText);
            this.SetParamSimple(map, prefix + "DischargeConditionText", this.DischargeConditionText);
            this.SetParamSimple(map, prefix + "CheckRecordText", this.CheckRecordText);
            this.SetParamSimple(map, prefix + "ChiefComplaintText", this.ChiefComplaintText);
            this.SetParamSimple(map, prefix + "DischargeDiagnosisText", this.DischargeDiagnosisText);
            this.SetParamSimple(map, prefix + "MainDiseaseHistoryText", this.MainDiseaseHistoryText);
            this.SetParamSimple(map, prefix + "DiseasePresentText", this.DiseasePresentText);
            this.SetParamSimple(map, prefix + "PersonalHistoryText", this.PersonalHistoryText);
            this.SetParamSimple(map, prefix + "MenstruallHistoryText", this.MenstruallHistoryText);
            this.SetParamSimple(map, prefix + "ObstericalHistoryText", this.ObstericalHistoryText);
            this.SetParamSimple(map, prefix + "FamilyHistoryText", this.FamilyHistoryText);
            this.SetParamSimple(map, prefix + "AllergyHistoryText", this.AllergyHistoryText);
            this.SetParamSimple(map, prefix + "DiseaseHistoryText", this.DiseaseHistoryText);
            this.SetParamSimple(map, prefix + "OtherDiagnosisText", this.OtherDiagnosisText);
            this.SetParamSimple(map, prefix + "BodyExaminationText", this.BodyExaminationText);
            this.SetParamSimple(map, prefix + "SpecialistExaminationText", this.SpecialistExaminationText);
            this.SetParamSimple(map, prefix + "TreatmentResultText", this.TreatmentResultText);
        }
    }
}

