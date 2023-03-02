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

    public class TreatmentRecordBlock : AbstractModel
    {
        
        /// <summary>
        /// 免疫组化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Immunohistochemistry")]
        public ImmunohistochemistryBlock Immunohistochemistry{ get; set; }

        /// <summary>
        /// 主诉
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChiefComplaint")]
        public ChiefComplaintBlock ChiefComplaint{ get; set; }

        /// <summary>
        /// 入院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionCondition")]
        public AdmissionConditionBlock AdmissionCondition{ get; set; }

        /// <summary>
        /// 查体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BodyExamination")]
        public BodyExaminationBlock BodyExamination{ get; set; }

        /// <summary>
        /// 入院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionDiagnosis")]
        public AdmissionDiagnosisBlock AdmissionDiagnosis{ get; set; }

        /// <summary>
        /// 入院中医诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionTraditionalDiagnosis")]
        public AdmissionDiagnosisBlock AdmissionTraditionalDiagnosis{ get; set; }

        /// <summary>
        /// 入院西医诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdmissionModernDiagnosis")]
        public AdmissionDiagnosisBlock AdmissionModernDiagnosis{ get; set; }

        /// <summary>
        /// 病理诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologicalDiagnosis")]
        public PathologicalDiagnosisBlock PathologicalDiagnosis{ get; set; }

        /// <summary>
        /// 现病史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseasePresent")]
        public DiseasePresentBlock DiseasePresent{ get; set; }

        /// <summary>
        /// 体征
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SymptomsAndSigns")]
        public DiseasePresentBlock SymptomsAndSigns{ get; set; }

        /// <summary>
        /// 辅助检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuxiliaryExamination")]
        public DiseasePresentBlock AuxiliaryExamination{ get; set; }

        /// <summary>
        /// 特殊检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialistExamination")]
        public DiseasePresentBlock SpecialistExamination{ get; set; }

        /// <summary>
        /// 精神检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MentalExamination")]
        public DiseasePresentBlock MentalExamination{ get; set; }

        /// <summary>
        /// 检查记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRecord")]
        public DiseasePresentBlock CheckRecord{ get; set; }

        /// <summary>
        /// 检查结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InspectResult")]
        public DiseasePresentBlock InspectResult{ get; set; }

        /// <summary>
        /// 治疗经过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckAndTreatmentProcess")]
        public DiseasePresentBlock CheckAndTreatmentProcess{ get; set; }

        /// <summary>
        /// 手术经过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SurgeryCondition")]
        public SurgeryConditionBlock SurgeryCondition{ get; set; }

        /// <summary>
        /// 切口愈合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncisionHealing")]
        public DiseasePresentBlock IncisionHealing{ get; set; }

        /// <summary>
        /// 出院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeDiagnosis")]
        public DischargeDiagnosisBlock DischargeDiagnosis{ get; set; }

        /// <summary>
        /// 出院中医诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeTraditionalDiagnosis")]
        public DiseasePresentBlock DischargeTraditionalDiagnosis{ get; set; }

        /// <summary>
        /// 出院西医诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeModernDiagnosis")]
        public DischargeDiagnosisBlock DischargeModernDiagnosis{ get; set; }

        /// <summary>
        /// 出院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeCondition")]
        public DischargeConditionBlock DischargeCondition{ get; set; }

        /// <summary>
        /// 出院医嘱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeInstructions")]
        public DiseasePresentBlock DischargeInstructions{ get; set; }

        /// <summary>
        /// 治疗建议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreatmentSuggestion")]
        public DiseasePresentBlock TreatmentSuggestion{ get; set; }

        /// <summary>
        /// 随访
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowUpRequirements")]
        public DiseasePresentBlock FollowUpRequirements{ get; set; }

        /// <summary>
        /// 治疗情况变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionChanges")]
        public DiseasePresentBlock ConditionChanges{ get; set; }

        /// <summary>
        /// 收缩压
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PulmonaryArterySystolicPressure")]
        public DiseasePresentBlock PulmonaryArterySystolicPressure{ get; set; }

        /// <summary>
        /// bclc分期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BCLC")]
        public DiseasePresentBlock BCLC{ get; set; }

        /// <summary>
        /// PTNM分期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNM")]
        public PTNMBlock PTNM{ get; set; }

        /// <summary>
        /// ECOG评分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ECOG")]
        public DiseasePresentBlock ECOG{ get; set; }

        /// <summary>
        /// NRS评分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NRS")]
        public DiseasePresentBlock NRS{ get; set; }

        /// <summary>
        /// kps评分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KPS")]
        public DiseasePresentBlock KPS{ get; set; }

        /// <summary>
        /// 癌症分期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cancerstaging")]
        public ClinicalStaging Cancerstaging{ get; set; }

        /// <summary>
        /// 死亡时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeathDate")]
        public DeathDateBlock DeathDate{ get; set; }

        /// <summary>
        /// 复发日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelapseDate")]
        public RelapseDateBlock RelapseDate{ get; set; }

        /// <summary>
        /// 观察日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObservationDays")]
        public DeathDateBlock ObservationDays{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Immunohistochemistry.", this.Immunohistochemistry);
            this.SetParamObj(map, prefix + "ChiefComplaint.", this.ChiefComplaint);
            this.SetParamObj(map, prefix + "AdmissionCondition.", this.AdmissionCondition);
            this.SetParamObj(map, prefix + "BodyExamination.", this.BodyExamination);
            this.SetParamObj(map, prefix + "AdmissionDiagnosis.", this.AdmissionDiagnosis);
            this.SetParamObj(map, prefix + "AdmissionTraditionalDiagnosis.", this.AdmissionTraditionalDiagnosis);
            this.SetParamObj(map, prefix + "AdmissionModernDiagnosis.", this.AdmissionModernDiagnosis);
            this.SetParamObj(map, prefix + "PathologicalDiagnosis.", this.PathologicalDiagnosis);
            this.SetParamObj(map, prefix + "DiseasePresent.", this.DiseasePresent);
            this.SetParamObj(map, prefix + "SymptomsAndSigns.", this.SymptomsAndSigns);
            this.SetParamObj(map, prefix + "AuxiliaryExamination.", this.AuxiliaryExamination);
            this.SetParamObj(map, prefix + "SpecialistExamination.", this.SpecialistExamination);
            this.SetParamObj(map, prefix + "MentalExamination.", this.MentalExamination);
            this.SetParamObj(map, prefix + "CheckRecord.", this.CheckRecord);
            this.SetParamObj(map, prefix + "InspectResult.", this.InspectResult);
            this.SetParamObj(map, prefix + "CheckAndTreatmentProcess.", this.CheckAndTreatmentProcess);
            this.SetParamObj(map, prefix + "SurgeryCondition.", this.SurgeryCondition);
            this.SetParamObj(map, prefix + "IncisionHealing.", this.IncisionHealing);
            this.SetParamObj(map, prefix + "DischargeDiagnosis.", this.DischargeDiagnosis);
            this.SetParamObj(map, prefix + "DischargeTraditionalDiagnosis.", this.DischargeTraditionalDiagnosis);
            this.SetParamObj(map, prefix + "DischargeModernDiagnosis.", this.DischargeModernDiagnosis);
            this.SetParamObj(map, prefix + "DischargeCondition.", this.DischargeCondition);
            this.SetParamObj(map, prefix + "DischargeInstructions.", this.DischargeInstructions);
            this.SetParamObj(map, prefix + "TreatmentSuggestion.", this.TreatmentSuggestion);
            this.SetParamObj(map, prefix + "FollowUpRequirements.", this.FollowUpRequirements);
            this.SetParamObj(map, prefix + "ConditionChanges.", this.ConditionChanges);
            this.SetParamObj(map, prefix + "PulmonaryArterySystolicPressure.", this.PulmonaryArterySystolicPressure);
            this.SetParamObj(map, prefix + "BCLC.", this.BCLC);
            this.SetParamObj(map, prefix + "PTNM.", this.PTNM);
            this.SetParamObj(map, prefix + "ECOG.", this.ECOG);
            this.SetParamObj(map, prefix + "NRS.", this.NRS);
            this.SetParamObj(map, prefix + "KPS.", this.KPS);
            this.SetParamObj(map, prefix + "Cancerstaging.", this.Cancerstaging);
            this.SetParamObj(map, prefix + "DeathDate.", this.DeathDate);
            this.SetParamObj(map, prefix + "RelapseDate.", this.RelapseDate);
            this.SetParamObj(map, prefix + "ObservationDays.", this.ObservationDays);
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
        }
    }
}

