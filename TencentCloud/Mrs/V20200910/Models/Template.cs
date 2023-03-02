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

    public class Template : AbstractModel
    {
        
        /// <summary>
        /// 患者信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PatientInfo")]
        public PatientInfo PatientInfo{ get; set; }

        /// <summary>
        /// 报告信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportInfo")]
        public ReportInfo ReportInfo{ get; set; }

        /// <summary>
        /// 检查报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Check")]
        public Check Check{ get; set; }

        /// <summary>
        /// 病理报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pathology")]
        public PathologyReport Pathology{ get; set; }

        /// <summary>
        /// 出院报告，入院报告，门诊病历
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedDoc")]
        public MedDoc MedDoc{ get; set; }

        /// <summary>
        /// 诊断证明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiagCert")]
        public DiagCert DiagCert{ get; set; }

        /// <summary>
        /// 病案首页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstPage")]
        public FirstPage FirstPage{ get; set; }

        /// <summary>
        /// 检验报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Indicator")]
        public Indicator Indicator{ get; set; }

        /// <summary>
        /// 报告类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportType")]
        public string ReportType{ get; set; }

        /// <summary>
        /// 门诊病历信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedicalRecordInfo")]
        public MedicalRecordInfo MedicalRecordInfo{ get; set; }

        /// <summary>
        /// 出入院信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hospitalization")]
        public Hospitalization Hospitalization{ get; set; }

        /// <summary>
        /// 手术记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Surgery")]
        public Surgery Surgery{ get; set; }

        /// <summary>
        /// 心电图报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Electrocardiogram")]
        public Electrocardiogram Electrocardiogram{ get; set; }

        /// <summary>
        /// 内窥镜报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endoscopy")]
        public Endoscopy Endoscopy{ get; set; }

        /// <summary>
        /// 处方单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Prescription")]
        public Prescription Prescription{ get; set; }

        /// <summary>
        /// 疫苗接种凭证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VaccineCertificate")]
        public VaccineCertificate VaccineCertificate{ get; set; }

        /// <summary>
        /// OCR文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrText")]
        public string OcrText{ get; set; }

        /// <summary>
        /// OCR拼接后文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrResult")]
        public string OcrResult{ get; set; }

        /// <summary>
        /// 报告类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTypeDesc")]
        public string ReportTypeDesc{ get; set; }

        /// <summary>
        /// 病理报告v2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologyV2")]
        public PathologyV2 PathologyV2{ get; set; }

        /// <summary>
        /// 碳14尿素呼气试验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("C14")]
        public Indicator C14{ get; set; }

        /// <summary>
        /// 体检结论
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Exame")]
        public Exame Exame{ get; set; }

        /// <summary>
        /// 出院报告v2，入院报告v2，门诊病历v2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedDocV2")]
        public DischargeInfoBlock MedDocV2{ get; set; }

        /// <summary>
        /// 检验报告v3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorV3")]
        public IndicatorV3 IndicatorV3{ get; set; }

        /// <summary>
        /// 核酸报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Covid")]
        public CovidItemsInfo Covid{ get; set; }

        /// <summary>
        /// 孕产报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Maternity")]
        public Maternity Maternity{ get; set; }

        /// <summary>
        /// 眼科报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Eye")]
        public EyeItemsInfo Eye{ get; set; }

        /// <summary>
        /// 出生证明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BirthCert")]
        public BirthCert BirthCert{ get; set; }

        /// <summary>
        /// 时间轴
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeline")]
        public TimelineInformation Timeline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PatientInfo.", this.PatientInfo);
            this.SetParamObj(map, prefix + "ReportInfo.", this.ReportInfo);
            this.SetParamObj(map, prefix + "Check.", this.Check);
            this.SetParamObj(map, prefix + "Pathology.", this.Pathology);
            this.SetParamObj(map, prefix + "MedDoc.", this.MedDoc);
            this.SetParamObj(map, prefix + "DiagCert.", this.DiagCert);
            this.SetParamObj(map, prefix + "FirstPage.", this.FirstPage);
            this.SetParamObj(map, prefix + "Indicator.", this.Indicator);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamObj(map, prefix + "MedicalRecordInfo.", this.MedicalRecordInfo);
            this.SetParamObj(map, prefix + "Hospitalization.", this.Hospitalization);
            this.SetParamObj(map, prefix + "Surgery.", this.Surgery);
            this.SetParamObj(map, prefix + "Electrocardiogram.", this.Electrocardiogram);
            this.SetParamObj(map, prefix + "Endoscopy.", this.Endoscopy);
            this.SetParamObj(map, prefix + "Prescription.", this.Prescription);
            this.SetParamObj(map, prefix + "VaccineCertificate.", this.VaccineCertificate);
            this.SetParamSimple(map, prefix + "OcrText", this.OcrText);
            this.SetParamSimple(map, prefix + "OcrResult", this.OcrResult);
            this.SetParamSimple(map, prefix + "ReportTypeDesc", this.ReportTypeDesc);
            this.SetParamObj(map, prefix + "PathologyV2.", this.PathologyV2);
            this.SetParamObj(map, prefix + "C14.", this.C14);
            this.SetParamObj(map, prefix + "Exame.", this.Exame);
            this.SetParamObj(map, prefix + "MedDocV2.", this.MedDocV2);
            this.SetParamObj(map, prefix + "IndicatorV3.", this.IndicatorV3);
            this.SetParamObj(map, prefix + "Covid.", this.Covid);
            this.SetParamObj(map, prefix + "Maternity.", this.Maternity);
            this.SetParamObj(map, prefix + "Eye.", this.Eye);
            this.SetParamObj(map, prefix + "BirthCert.", this.BirthCert);
            this.SetParamObj(map, prefix + "Timeline.", this.Timeline);
        }
    }
}

