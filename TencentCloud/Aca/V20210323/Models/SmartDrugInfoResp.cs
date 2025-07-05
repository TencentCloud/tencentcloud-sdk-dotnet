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

    public class SmartDrugInfoResp : AbstractModel
    {
        
        /// <summary>
        /// 药品ID
        /// </summary>
        [JsonProperty("DrugId")]
        public string DrugId{ get; set; }

        /// <summary>
        /// 序列ID
        /// </summary>
        [JsonProperty("SequenceId")]
        public long? SequenceId{ get; set; }

        /// <summary>
        /// 药品哈希ID
        /// </summary>
        [JsonProperty("DrugHashId")]
        public string DrugHashId{ get; set; }

        /// <summary>
        /// 图片URL
        /// </summary>
        [JsonProperty("ImgUrl")]
        public string ImgUrl{ get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonProperty("EnglishName")]
        public string EnglishName{ get; set; }

        /// <summary>
        /// 英文商品名
        /// </summary>
        [JsonProperty("EnglishTradeName")]
        public string EnglishTradeName{ get; set; }

        /// <summary>
        /// 拼音
        /// </summary>
        [JsonProperty("Pinyin")]
        public string Pinyin{ get; set; }

        /// <summary>
        /// 其他名称
        /// </summary>
        [JsonProperty("OtherNames")]
        public string OtherNames{ get; set; }

        /// <summary>
        /// 化学名称
        /// </summary>
        [JsonProperty("ChemicalName")]
        public string ChemicalName{ get; set; }

        /// <summary>
        /// 英文化学名称
        /// </summary>
        [JsonProperty("EnglishChemicalName")]
        public string EnglishChemicalName{ get; set; }

        /// <summary>
        /// 批准文号
        /// </summary>
        [JsonProperty("ApprovalNumber")]
        public string ApprovalNumber{ get; set; }

        /// <summary>
        /// 药品属性标签 多个标签时 | 分隔，如抗菌药|抗生素|贵重药品
        /// </summary>
        [JsonProperty("Property")]
        public string Property{ get; set; }

        /// <summary>
        /// 药品成分
        /// </summary>
        [JsonProperty("Ingredients")]
        public string Ingredients{ get; set; }

        /// <summary>
        /// 药品性状
        /// </summary>
        [JsonProperty("PhenotypicTrait")]
        public string PhenotypicTrait{ get; set; }

        /// <summary>
        /// 适应症
        /// </summary>
        [JsonProperty("Indications")]
        public string Indications{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Specifications")]
        public string Specifications{ get; set; }

        /// <summary>
        /// 用法用量
        /// </summary>
        [JsonProperty("UsageAndDosage")]
        public string UsageAndDosage{ get; set; }

        /// <summary>
        /// 推荐用法
        /// </summary>
        [JsonProperty("RecommendedUsage")]
        public RecommendedUsage RecommendedUsage{ get; set; }

        /// <summary>
        /// 不良反应
        /// </summary>
        [JsonProperty("AdverseReaction")]
        public string AdverseReaction{ get; set; }

        /// <summary>
        /// 禁忌
        /// </summary>
        [JsonProperty("Contraindication")]
        public string Contraindication{ get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [JsonProperty("Attentions")]
        public string Attentions{ get; set; }

        /// <summary>
        /// 药物过量
        /// </summary>
        [JsonProperty("Overdose")]
        public string Overdose{ get; set; }

        /// <summary>
        /// 孕妇及哺乳期妇女用药
        /// </summary>
        [JsonProperty("PregnantAndLactatingWomen")]
        public string PregnantAndLactatingWomen{ get; set; }

        /// <summary>
        /// 老年患者用药
        /// </summary>
        [JsonProperty("ElderlyPatients")]
        public string ElderlyPatients{ get; set; }

        /// <summary>
        /// 儿童用药
        /// </summary>
        [JsonProperty("PediatricDrugs")]
        public string PediatricDrugs{ get; set; }

        /// <summary>
        /// 药物相互作用
        /// </summary>
        [JsonProperty("Interactions")]
        public string Interactions{ get; set; }

        /// <summary>
        /// 临床研究
        /// </summary>
        [JsonProperty("ClinicalResearch")]
        public string ClinicalResearch{ get; set; }

        /// <summary>
        /// 药理毒理
        /// </summary>
        [JsonProperty("PharmacologyToxicology")]
        public string PharmacologyToxicology{ get; set; }

        /// <summary>
        /// 药代动力学
        /// </summary>
        [JsonProperty("Pharmacokinetics")]
        public string Pharmacokinetics{ get; set; }

        /// <summary>
        /// 警告
        /// </summary>
        [JsonProperty("Warning")]
        public string Warning{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ExpireDate")]
        public string ExpireDate{ get; set; }

        /// <summary>
        /// 贮藏
        /// </summary>
        [JsonProperty("Storage")]
        public string Storage{ get; set; }

        /// <summary>
        /// 包装
        /// </summary>
        [JsonProperty("Pack")]
        public string Pack{ get; set; }

        /// <summary>
        /// 生产企业
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 生产企业地址
        /// </summary>
        [JsonProperty("ManufacturerAddress")]
        public string ManufacturerAddress{ get; set; }

        /// <summary>
        /// 生产企业电话
        /// </summary>
        [JsonProperty("ManufacturerPhone")]
        public string ManufacturerPhone{ get; set; }

        /// <summary>
        /// 生产企业邮箱
        /// </summary>
        [JsonProperty("ManufacturerEmail")]
        public string ManufacturerEmail{ get; set; }

        /// <summary>
        /// 生产企业网站
        /// </summary>
        [JsonProperty("ManufacturerWebsite")]
        public string ManufacturerWebsite{ get; set; }

        /// <summary>
        /// 说明书制定和修订时间
        /// </summary>
        [JsonProperty("DocRevisionTime")]
        public string DocRevisionTime{ get; set; }

        /// <summary>
        /// 参考文献
        /// </summary>
        [JsonProperty("References")]
        public string References{ get; set; }

        /// <summary>
        /// 剂型
        /// </summary>
        [JsonProperty("DrugDosageForm")]
        public string DrugDosageForm{ get; set; }

        /// <summary>
        /// 给药途径
        /// </summary>
        [JsonProperty("DrugRoute")]
        public string DrugRoute{ get; set; }

        /// <summary>
        /// 药品本位码
        /// </summary>
        [JsonProperty("DrugBasicCode")]
        public string DrugBasicCode{ get; set; }

        /// <summary>
        /// OTC标签
        /// </summary>
        [JsonProperty("OctTag")]
        public string OctTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugId", this.DrugId);
            this.SetParamSimple(map, prefix + "SequenceId", this.SequenceId);
            this.SetParamSimple(map, prefix + "DrugHashId", this.DrugHashId);
            this.SetParamSimple(map, prefix + "ImgUrl", this.ImgUrl);
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "TradeName", this.TradeName);
            this.SetParamSimple(map, prefix + "EnglishName", this.EnglishName);
            this.SetParamSimple(map, prefix + "EnglishTradeName", this.EnglishTradeName);
            this.SetParamSimple(map, prefix + "Pinyin", this.Pinyin);
            this.SetParamSimple(map, prefix + "OtherNames", this.OtherNames);
            this.SetParamSimple(map, prefix + "ChemicalName", this.ChemicalName);
            this.SetParamSimple(map, prefix + "EnglishChemicalName", this.EnglishChemicalName);
            this.SetParamSimple(map, prefix + "ApprovalNumber", this.ApprovalNumber);
            this.SetParamSimple(map, prefix + "Property", this.Property);
            this.SetParamSimple(map, prefix + "Ingredients", this.Ingredients);
            this.SetParamSimple(map, prefix + "PhenotypicTrait", this.PhenotypicTrait);
            this.SetParamSimple(map, prefix + "Indications", this.Indications);
            this.SetParamSimple(map, prefix + "Specifications", this.Specifications);
            this.SetParamSimple(map, prefix + "UsageAndDosage", this.UsageAndDosage);
            this.SetParamObj(map, prefix + "RecommendedUsage.", this.RecommendedUsage);
            this.SetParamSimple(map, prefix + "AdverseReaction", this.AdverseReaction);
            this.SetParamSimple(map, prefix + "Contraindication", this.Contraindication);
            this.SetParamSimple(map, prefix + "Attentions", this.Attentions);
            this.SetParamSimple(map, prefix + "Overdose", this.Overdose);
            this.SetParamSimple(map, prefix + "PregnantAndLactatingWomen", this.PregnantAndLactatingWomen);
            this.SetParamSimple(map, prefix + "ElderlyPatients", this.ElderlyPatients);
            this.SetParamSimple(map, prefix + "PediatricDrugs", this.PediatricDrugs);
            this.SetParamSimple(map, prefix + "Interactions", this.Interactions);
            this.SetParamSimple(map, prefix + "ClinicalResearch", this.ClinicalResearch);
            this.SetParamSimple(map, prefix + "PharmacologyToxicology", this.PharmacologyToxicology);
            this.SetParamSimple(map, prefix + "Pharmacokinetics", this.Pharmacokinetics);
            this.SetParamSimple(map, prefix + "Warning", this.Warning);
            this.SetParamSimple(map, prefix + "ExpireDate", this.ExpireDate);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Pack", this.Pack);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "ManufacturerAddress", this.ManufacturerAddress);
            this.SetParamSimple(map, prefix + "ManufacturerPhone", this.ManufacturerPhone);
            this.SetParamSimple(map, prefix + "ManufacturerEmail", this.ManufacturerEmail);
            this.SetParamSimple(map, prefix + "ManufacturerWebsite", this.ManufacturerWebsite);
            this.SetParamSimple(map, prefix + "DocRevisionTime", this.DocRevisionTime);
            this.SetParamSimple(map, prefix + "References", this.References);
            this.SetParamSimple(map, prefix + "DrugDosageForm", this.DrugDosageForm);
            this.SetParamSimple(map, prefix + "DrugRoute", this.DrugRoute);
            this.SetParamSimple(map, prefix + "DrugBasicCode", this.DrugBasicCode);
            this.SetParamSimple(map, prefix + "OctTag", this.OctTag);
        }
    }
}

