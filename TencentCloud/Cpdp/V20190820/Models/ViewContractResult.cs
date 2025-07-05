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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ViewContractResult : AbstractModel
    {
        
        /// <summary>
        /// 支付标签（唯一性）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentTag")]
        public string PaymentTag{ get; set; }

        /// <summary>
        /// 城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 机构编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentNo")]
        public string AgentNo{ get; set; }

        /// <summary>
        /// 合同选项值4
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionFour")]
        public string ContractOptionFour{ get; set; }

        /// <summary>
        /// 合同选项值2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionTwo")]
        public string ContractOptionTwo{ get; set; }

        /// <summary>
        /// 合同状态（0未审核，1已审核，2审核未通过，3待审核，4已删除，5初审通过）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 支付方式编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentId")]
        public string PaymentId{ get; set; }

        /// <summary>
        /// 商户签约扣率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fee")]
        public string Fee{ get; set; }

        /// <summary>
        /// 合同选项名称5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionFive")]
        public string PaymentOptionFive{ get; set; }

        /// <summary>
        /// 机构合同主键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutContractId")]
        public string OutContractId{ get; set; }

        /// <summary>
        /// 不同的支付方式对于进件有不同的个性化需求，支付方式字段都是以双下划写开头的字段名称，请以支付方式规定的格式传值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelExtJson")]
        public string ChannelExtJson{ get; set; }

        /// <summary>
        /// 合同选项值5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionFive")]
        public string ContractOptionFive{ get; set; }

        /// <summary>
        /// 省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 生效日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 详细地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 过期日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 合同选项值6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionSix")]
        public string ContractOptionSix{ get; set; }

        /// <summary>
        /// 合同选项名称7
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionSeven")]
        public string PaymentOptionSeven{ get; set; }

        /// <summary>
        /// 合同照片补充【私密区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PictureTwo")]
        public string PictureTwo{ get; set; }

        /// <summary>
        /// 商户编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantNo")]
        public string MerchantNo{ get; set; }

        /// <summary>
        /// 机构名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// 合同选项值8
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionOther")]
        public string ContractOptionOther{ get; set; }

        /// <summary>
        /// 合同选项值3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionThree")]
        public string ContractOptionThree{ get; set; }

        /// <summary>
        /// 县/区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 合同关联的门店数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopCount")]
        public string ShopCount{ get; set; }

        /// <summary>
        /// 合同选项名称3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionThree")]
        public string PaymentOptionThree{ get; set; }

        /// <summary>
        /// 支付方式行业名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentClassificationName")]
        public string PaymentClassificationName{ get; set; }

        /// <summary>
        /// 合同选项值7
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionSeven")]
        public string ContractOptionSeven{ get; set; }

        /// <summary>
        /// 合同选项名称4
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionFour")]
        public string PaymentOptionFour{ get; set; }

        /// <summary>
        /// 商户签约扣率封顶值（分为单位）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentClassificationLimit")]
        public string PaymentClassificationLimit{ get; set; }

        /// <summary>
        /// 审核备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 合同选项名称6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionSix")]
        public string PaymentOptionSix{ get; set; }

        /// <summary>
        /// 品牌名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 合同选项值1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionOne")]
        public string ContractOptionOne{ get; set; }

        /// <summary>
        /// 合同选项名称8
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionOther")]
        public string PaymentOptionOther{ get; set; }

        /// <summary>
        /// 合同选项名称2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionTwo")]
        public string PaymentOptionTwo{ get; set; }

        /// <summary>
        /// 合同选项名称1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionOne")]
        public string PaymentOptionOne{ get; set; }

        /// <summary>
        /// 更新时间（yyyy-mm-dd hh:ii:ss）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 联系人电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContactTelephone")]
        public string ContactTelephone{ get; set; }

        /// <summary>
        /// 联系人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 签约日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignDate")]
        public string SignDate{ get; set; }

        /// <summary>
        /// 合同选项名称9
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionNine")]
        public string PaymentOptionNine{ get; set; }

        /// <summary>
        /// 付款方式名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentName")]
        public string PaymentName{ get; set; }

        /// <summary>
        /// 付款方式名称（内部名称）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentInternalName")]
        public string PaymentInternalName{ get; set; }

        /// <summary>
        /// 合同选项值10
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionTen")]
        public string ContractOptionTen{ get; set; }

        /// <summary>
        /// 合同编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 合同照片【私密区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PictureOne")]
        public string PictureOne{ get; set; }

        /// <summary>
        /// 签约人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignMan")]
        public string SignMan{ get; set; }

        /// <summary>
        /// 渠道号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelNo")]
        public string ChannelNo{ get; set; }

        /// <summary>
        /// 添加时间（yyyy-mm-dd hh:ii:ss）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 是否自动续签（1是，0否）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSign")]
        public string AutoSign{ get; set; }

        /// <summary>
        /// 合同选项值9
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractOptionNine")]
        public string ContractOptionNine{ get; set; }

        /// <summary>
        /// 城市编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CityId")]
        public string CityId{ get; set; }

        /// <summary>
        /// 交易类型（多个以小写逗号分开，0现金，1刷卡，2主扫，3被扫，4JSPAY，5预授权）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentType")]
        public string PaymentType{ get; set; }

        /// <summary>
        /// 支付方式行业编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentClassificationId")]
        public string PaymentClassificationId{ get; set; }

        /// <summary>
        /// 品牌名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 合同选项名称10
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentOptionTen")]
        public string PaymentOptionTen{ get; set; }

        /// <summary>
        /// 合同主键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractId")]
        public string ContractId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaymentTag", this.PaymentTag);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "AgentNo", this.AgentNo);
            this.SetParamSimple(map, prefix + "ContractOptionFour", this.ContractOptionFour);
            this.SetParamSimple(map, prefix + "ContractOptionTwo", this.ContractOptionTwo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PaymentId", this.PaymentId);
            this.SetParamSimple(map, prefix + "Fee", this.Fee);
            this.SetParamSimple(map, prefix + "PaymentOptionFive", this.PaymentOptionFive);
            this.SetParamSimple(map, prefix + "OutContractId", this.OutContractId);
            this.SetParamSimple(map, prefix + "ChannelExtJson", this.ChannelExtJson);
            this.SetParamSimple(map, prefix + "ContractOptionFive", this.ContractOptionFive);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "ContractOptionSix", this.ContractOptionSix);
            this.SetParamSimple(map, prefix + "PaymentOptionSeven", this.PaymentOptionSeven);
            this.SetParamSimple(map, prefix + "PictureTwo", this.PictureTwo);
            this.SetParamSimple(map, prefix + "MerchantNo", this.MerchantNo);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "ContractOptionOther", this.ContractOptionOther);
            this.SetParamSimple(map, prefix + "ContractOptionThree", this.ContractOptionThree);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "ShopCount", this.ShopCount);
            this.SetParamSimple(map, prefix + "PaymentOptionThree", this.PaymentOptionThree);
            this.SetParamSimple(map, prefix + "PaymentClassificationName", this.PaymentClassificationName);
            this.SetParamSimple(map, prefix + "ContractOptionSeven", this.ContractOptionSeven);
            this.SetParamSimple(map, prefix + "PaymentOptionFour", this.PaymentOptionFour);
            this.SetParamSimple(map, prefix + "PaymentClassificationLimit", this.PaymentClassificationLimit);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PaymentOptionSix", this.PaymentOptionSix);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "ContractOptionOne", this.ContractOptionOne);
            this.SetParamSimple(map, prefix + "PaymentOptionOther", this.PaymentOptionOther);
            this.SetParamSimple(map, prefix + "PaymentOptionTwo", this.PaymentOptionTwo);
            this.SetParamSimple(map, prefix + "PaymentOptionOne", this.PaymentOptionOne);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ContactTelephone", this.ContactTelephone);
            this.SetParamSimple(map, prefix + "Contact", this.Contact);
            this.SetParamSimple(map, prefix + "SignDate", this.SignDate);
            this.SetParamSimple(map, prefix + "PaymentOptionNine", this.PaymentOptionNine);
            this.SetParamSimple(map, prefix + "PaymentName", this.PaymentName);
            this.SetParamSimple(map, prefix + "PaymentInternalName", this.PaymentInternalName);
            this.SetParamSimple(map, prefix + "ContractOptionTen", this.ContractOptionTen);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "PictureOne", this.PictureOne);
            this.SetParamSimple(map, prefix + "SignMan", this.SignMan);
            this.SetParamSimple(map, prefix + "ChannelNo", this.ChannelNo);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "AutoSign", this.AutoSign);
            this.SetParamSimple(map, prefix + "ContractOptionNine", this.ContractOptionNine);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "PaymentType", this.PaymentType);
            this.SetParamSimple(map, prefix + "PaymentClassificationId", this.PaymentClassificationId);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "PaymentOptionTen", this.PaymentOptionTen);
            this.SetParamSimple(map, prefix + "ContractId", this.ContractId);
        }
    }
}

