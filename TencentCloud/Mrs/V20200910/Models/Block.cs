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

    public class Block : AbstractModel
    {
        
        /// <summary>
        /// 诊断信息
        /// </summary>
        [JsonProperty("Check")]
        public Check[] Check{ get; set; }

        /// <summary>
        /// 病理报告
        /// </summary>
        [JsonProperty("Pathology")]
        public PathologyReport[] Pathology{ get; set; }

        /// <summary>
        /// 医学资料
        /// </summary>
        [JsonProperty("MedDoc")]
        public MedDoc[] MedDoc{ get; set; }

        /// <summary>
        /// 诊断证明
        /// </summary>
        [JsonProperty("DiagCert")]
        public DiagCert[] DiagCert{ get; set; }

        /// <summary>
        /// 病案首页
        /// </summary>
        [JsonProperty("FirstPage")]
        public FirstPage[] FirstPage{ get; set; }

        /// <summary>
        /// 检验报告
        /// </summary>
        [JsonProperty("Indicator")]
        public Indicator[] Indicator{ get; set; }

        /// <summary>
        /// 门诊病历信息
        /// </summary>
        [JsonProperty("MedicalRecordInfo")]
        public MedicalRecordInfo[] MedicalRecordInfo{ get; set; }

        /// <summary>
        /// 出入院信息
        /// </summary>
        [JsonProperty("Hospitalization")]
        public Hospitalization[] Hospitalization{ get; set; }

        /// <summary>
        /// 手术记录
        /// </summary>
        [JsonProperty("Surgery")]
        public Surgery[] Surgery{ get; set; }

        /// <summary>
        /// 处方单
        /// </summary>
        [JsonProperty("Prescription")]
        public Prescription[] Prescription{ get; set; }

        /// <summary>
        /// 免疫接种证明
        /// </summary>
        [JsonProperty("VaccineCertificate")]
        public VaccineCertificate[] VaccineCertificate{ get; set; }

        /// <summary>
        /// 心电图
        /// </summary>
        [JsonProperty("Electrocardiogram")]
        public Electrocardiogram[] Electrocardiogram{ get; set; }

        /// <summary>
        /// 病理报告v2
        /// </summary>
        [JsonProperty("PathologyV2")]
        public PathologyV2[] PathologyV2{ get; set; }

        /// <summary>
        /// 内窥镜报告
        /// </summary>
        [JsonProperty("Endoscopy")]
        public Endoscopy[] Endoscopy{ get; set; }

        /// <summary>
        /// C14检验报告
        /// </summary>
        [JsonProperty("C14")]
        public Indicator[] C14{ get; set; }

        /// <summary>
        /// 体检结论
        /// </summary>
        [JsonProperty("Exame")]
        public Exame[] Exame{ get; set; }

        /// <summary>
        /// 出入院结构体
        /// </summary>
        [JsonProperty("MedDocV2")]
        public DischargeInfoBlock[] MedDocV2{ get; set; }

        /// <summary>
        /// 检验报告v3
        /// </summary>
        [JsonProperty("IndicatorV3")]
        public IndicatorV3[] IndicatorV3{ get; set; }

        /// <summary>
        /// 孕产报告
        /// </summary>
        [JsonProperty("Maternity")]
        public Maternity[] Maternity{ get; set; }

        /// <summary>
        /// 时间轴
        /// </summary>
        [JsonProperty("Timeline")]
        public TimelineInformation[] Timeline{ get; set; }

        /// <summary>
        /// 核酸报告结论
        /// </summary>
        [JsonProperty("Covid")]
        public CovidItemsInfo[] Covid{ get; set; }

        /// <summary>
        /// 眼科报告结构体
        /// </summary>
        [JsonProperty("Eye")]
        public EyeItemsInfo[] Eye{ get; set; }

        /// <summary>
        /// 出生证明结构化信息
        /// </summary>
        [JsonProperty("BirthCert")]
        public BirthCert[] BirthCert{ get; set; }

        /// <summary>
        /// 文本类型列表
        /// </summary>
        [JsonProperty("TextTypeListBlocks")]
        public TextTypeListBlock[] TextTypeListBlocks{ get; set; }

        /// <summary>
        /// 体检报告信息
        /// </summary>
        [JsonProperty("PhysicalExamination")]
        public PhysicalExaminationV1 PhysicalExamination{ get; set; }

        /// <summary>
        /// 内窥镜报告V2
        /// </summary>
        [JsonProperty("EndoscopyV2")]
        public Check[] EndoscopyV2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Check.", this.Check);
            this.SetParamArrayObj(map, prefix + "Pathology.", this.Pathology);
            this.SetParamArrayObj(map, prefix + "MedDoc.", this.MedDoc);
            this.SetParamArrayObj(map, prefix + "DiagCert.", this.DiagCert);
            this.SetParamArrayObj(map, prefix + "FirstPage.", this.FirstPage);
            this.SetParamArrayObj(map, prefix + "Indicator.", this.Indicator);
            this.SetParamArrayObj(map, prefix + "MedicalRecordInfo.", this.MedicalRecordInfo);
            this.SetParamArrayObj(map, prefix + "Hospitalization.", this.Hospitalization);
            this.SetParamArrayObj(map, prefix + "Surgery.", this.Surgery);
            this.SetParamArrayObj(map, prefix + "Prescription.", this.Prescription);
            this.SetParamArrayObj(map, prefix + "VaccineCertificate.", this.VaccineCertificate);
            this.SetParamArrayObj(map, prefix + "Electrocardiogram.", this.Electrocardiogram);
            this.SetParamArrayObj(map, prefix + "PathologyV2.", this.PathologyV2);
            this.SetParamArrayObj(map, prefix + "Endoscopy.", this.Endoscopy);
            this.SetParamArrayObj(map, prefix + "C14.", this.C14);
            this.SetParamArrayObj(map, prefix + "Exame.", this.Exame);
            this.SetParamArrayObj(map, prefix + "MedDocV2.", this.MedDocV2);
            this.SetParamArrayObj(map, prefix + "IndicatorV3.", this.IndicatorV3);
            this.SetParamArrayObj(map, prefix + "Maternity.", this.Maternity);
            this.SetParamArrayObj(map, prefix + "Timeline.", this.Timeline);
            this.SetParamArrayObj(map, prefix + "Covid.", this.Covid);
            this.SetParamArrayObj(map, prefix + "Eye.", this.Eye);
            this.SetParamArrayObj(map, prefix + "BirthCert.", this.BirthCert);
            this.SetParamArrayObj(map, prefix + "TextTypeListBlocks.", this.TextTypeListBlocks);
            this.SetParamObj(map, prefix + "PhysicalExamination.", this.PhysicalExamination);
            this.SetParamArrayObj(map, prefix + "EndoscopyV2.", this.EndoscopyV2);
        }
    }
}

