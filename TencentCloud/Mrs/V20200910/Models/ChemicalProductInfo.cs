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

    public class ChemicalProductInfo : AbstractModel
    {
        
        /// <summary>
        /// 药品名称，包括通用名和商品名
        /// </summary>
        [JsonProperty("Name")]
        public ChemicalProductInfoName Name{ get; set; }

        /// <summary>
        /// 活性成份消息定义，如果是复方制剂，可以不列出每个活性成份的详细信息
        /// </summary>
        [JsonProperty("ActiveIngredient")]
        public ChemicalProductInfoActiveIngredient ActiveIngredient{ get; set; }

        /// <summary>
        /// 性状
        /// </summary>
        [JsonProperty("Appearance")]
        public ChemicalProductInfoAppearance Appearance{ get; set; }

        /// <summary>
        /// 适应症描述
        /// </summary>
        [JsonProperty("Indications")]
        public ChemicalProductInfoIndications Indications{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Brochure")]
        public ChemicalProductInfoBrochure Brochure{ get; set; }

        /// <summary>
        /// 用法用量
        /// </summary>
        [JsonProperty("Dosage")]
        public ChemicalProductInfoDosage Dosage{ get; set; }

        /// <summary>
        /// 不良反应
        /// </summary>
        [JsonProperty("AdverseReaction")]
        public ChemicalProductInfoAdverseReaction AdverseReaction{ get; set; }

        /// <summary>
        /// 禁忌情况
        /// </summary>
        [JsonProperty("Contraindications")]
        public ChemicalProductInfoContraindications Contraindications{ get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [JsonProperty("Precautions")]
        public ChemicalProductInfoPrecautions Precautions{ get; set; }

        /// <summary>
        /// 孕妇及哺乳期妇女用药
        /// </summary>
        [JsonProperty("PregnancyLactationUse")]
        public ChemicalProductInfoPregnancyLactationUse PregnancyLactationUse{ get; set; }

        /// <summary>
        /// 儿童用药
        /// </summary>
        [JsonProperty("PediatricUse")]
        public ChemicalProductInfoPediatricUse PediatricUse{ get; set; }

        /// <summary>
        /// 老年用药
        /// </summary>
        [JsonProperty("GeriatricUse")]
        public ChemicalProductInfoGeriatricUse GeriatricUse{ get; set; }

        /// <summary>
        /// 药品的药物相互作用
        /// </summary>
        [JsonProperty("Interactions")]
        public ChemicalProductInfoInteractions Interactions{ get; set; }

        /// <summary>
        /// 药物过量
        /// </summary>
        [JsonProperty("Overdose")]
        public ChemicalProductInfoOverdose Overdose{ get; set; }

        /// <summary>
        /// 临床试验
        /// </summary>
        [JsonProperty("ClinicalTrial")]
        public ChemicalProductInfoClinicalTrial ClinicalTrial{ get; set; }

        /// <summary>
        /// 药理毒理
        /// </summary>
        [JsonProperty("PharmacologyToxicology")]
        public ChemicalProductInfoPharmacologyToxicology PharmacologyToxicology{ get; set; }

        /// <summary>
        /// 药代动力学
        /// </summary>
        [JsonProperty("Pharmacokinetics")]
        public ChemicalProductInfoPharmacokinetics Pharmacokinetics{ get; set; }

        /// <summary>
        /// 储存条件
        /// </summary>
        [JsonProperty("Storage")]
        public ChemicalProductInfoStorage Storage{ get; set; }

        /// <summary>
        /// 包装信息
        /// </summary>
        [JsonProperty("Packaging")]
        public ChemicalProductInfoPackaging Packaging{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public ChemicalProductInfoValidityPeriod ValidityPeriod{ get; set; }

        /// <summary>
        /// 执行标准
        /// </summary>
        [JsonProperty("ExecutiveStandards")]
        public ChemicalProductInfoExecutiveStandards ExecutiveStandards{ get; set; }

        /// <summary>
        /// 批准文号
        /// </summary>
        [JsonProperty("Approval")]
        public ChemicalProductInfoApproval Approval{ get; set; }

        /// <summary>
        /// 生产企业名称和地址
        /// </summary>
        [JsonProperty("Manufacturer")]
        public ChemicalProductInfoManufacturer Manufacturer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "ActiveIngredient.", this.ActiveIngredient);
            this.SetParamObj(map, prefix + "Appearance.", this.Appearance);
            this.SetParamObj(map, prefix + "Indications.", this.Indications);
            this.SetParamObj(map, prefix + "Brochure.", this.Brochure);
            this.SetParamObj(map, prefix + "Dosage.", this.Dosage);
            this.SetParamObj(map, prefix + "AdverseReaction.", this.AdverseReaction);
            this.SetParamObj(map, prefix + "Contraindications.", this.Contraindications);
            this.SetParamObj(map, prefix + "Precautions.", this.Precautions);
            this.SetParamObj(map, prefix + "PregnancyLactationUse.", this.PregnancyLactationUse);
            this.SetParamObj(map, prefix + "PediatricUse.", this.PediatricUse);
            this.SetParamObj(map, prefix + "GeriatricUse.", this.GeriatricUse);
            this.SetParamObj(map, prefix + "Interactions.", this.Interactions);
            this.SetParamObj(map, prefix + "Overdose.", this.Overdose);
            this.SetParamObj(map, prefix + "ClinicalTrial.", this.ClinicalTrial);
            this.SetParamObj(map, prefix + "PharmacologyToxicology.", this.PharmacologyToxicology);
            this.SetParamObj(map, prefix + "Pharmacokinetics.", this.Pharmacokinetics);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamObj(map, prefix + "Packaging.", this.Packaging);
            this.SetParamObj(map, prefix + "ValidityPeriod.", this.ValidityPeriod);
            this.SetParamObj(map, prefix + "ExecutiveStandards.", this.ExecutiveStandards);
            this.SetParamObj(map, prefix + "Approval.", this.Approval);
            this.SetParamObj(map, prefix + "Manufacturer.", this.Manufacturer);
        }
    }
}

