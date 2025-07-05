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

    public class BiologicalProductInfo : AbstractModel
    {
        
        /// <summary>
        /// 药品名称，包括通用名和商品名
        /// </summary>
        [JsonProperty("Name")]
        public BiologicalProductInfoName Name{ get; set; }

        /// <summary>
        /// 成份和性状
        /// </summary>
        [JsonProperty("IngredientAndAppearance")]
        public BiologicalProductInfoIngredientAndAppearance IngredientAndAppearance{ get; set; }

        /// <summary>
        /// 接种对象
        /// </summary>
        [JsonProperty("VaccinationTarget")]
        public BiologicalProductInfoVaccinationTarget VaccinationTarget{ get; set; }

        /// <summary>
        /// 作用与用途
        /// </summary>
        [JsonProperty("Indications")]
        public BiologicalProductInfoIndications Indications{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Brochure")]
        public BiologicalProductInfoBrochure Brochure{ get; set; }

        /// <summary>
        /// 免疫程序和剂量
        /// </summary>
        [JsonProperty("Dosage")]
        public BiologicalProductInfoDosage Dosage{ get; set; }

        /// <summary>
        /// 不良反应
        /// </summary>
        [JsonProperty("AdverseReaction")]
        public BiologicalProductInfoAdverseReaction AdverseReaction{ get; set; }

        /// <summary>
        /// 禁忌情况
        /// </summary>
        [JsonProperty("Contraindications")]
        public BiologicalProductInfoContraindications Contraindications{ get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [JsonProperty("Precautions")]
        public BiologicalProductInfoPrecautions Precautions{ get; set; }

        /// <summary>
        /// 储存条件
        /// </summary>
        [JsonProperty("Storage")]
        public BiologicalProductInfoStorage Storage{ get; set; }

        /// <summary>
        /// 包装信息
        /// </summary>
        [JsonProperty("Packaging")]
        public BiologicalProductInfoPackaging Packaging{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public BiologicalProductInfoValidityPeriod ValidityPeriod{ get; set; }

        /// <summary>
        /// 执行标准
        /// </summary>
        [JsonProperty("ExecutiveStandards")]
        public BiologicalProductInfoExecutiveStandards ExecutiveStandards{ get; set; }

        /// <summary>
        /// 批准文号
        /// </summary>
        [JsonProperty("Approval")]
        public BiologicalProductInfoApproval Approval{ get; set; }

        /// <summary>
        /// 生产企业名称和地址
        /// </summary>
        [JsonProperty("Manufacturer")]
        public BiologicalProductInfoManufacturer Manufacturer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "IngredientAndAppearance.", this.IngredientAndAppearance);
            this.SetParamObj(map, prefix + "VaccinationTarget.", this.VaccinationTarget);
            this.SetParamObj(map, prefix + "Indications.", this.Indications);
            this.SetParamObj(map, prefix + "Brochure.", this.Brochure);
            this.SetParamObj(map, prefix + "Dosage.", this.Dosage);
            this.SetParamObj(map, prefix + "AdverseReaction.", this.AdverseReaction);
            this.SetParamObj(map, prefix + "Contraindications.", this.Contraindications);
            this.SetParamObj(map, prefix + "Precautions.", this.Precautions);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamObj(map, prefix + "Packaging.", this.Packaging);
            this.SetParamObj(map, prefix + "ValidityPeriod.", this.ValidityPeriod);
            this.SetParamObj(map, prefix + "ExecutiveStandards.", this.ExecutiveStandards);
            this.SetParamObj(map, prefix + "Approval.", this.Approval);
            this.SetParamObj(map, prefix + "Manufacturer.", this.Manufacturer);
        }
    }
}

