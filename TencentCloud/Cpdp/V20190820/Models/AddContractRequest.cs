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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddContractRequest : AbstractModel
    {
        
        /// <summary>
        /// 签约扣率百分比（如：0.32）
        /// </summary>
        [JsonProperty("Fee")]
        public string Fee{ get; set; }

        /// <summary>
        /// 机构合同主键（系统有唯一性校验），建议使用合同表的主键ID，防止重复添加合同
        /// </summary>
        [JsonProperty("OutContractId")]
        public string OutContractId{ get; set; }

        /// <summary>
        /// 封顶值（分为单位，无封顶填0）
        /// </summary>
        [JsonProperty("PaymentClassificationLimit")]
        public string PaymentClassificationLimit{ get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("ContactTelephone")]
        public string ContactTelephone{ get; set; }

        /// <summary>
        /// 支付方式编号
        /// </summary>
        [JsonProperty("PaymentId")]
        public string PaymentId{ get; set; }

        /// <summary>
        /// 收单系统分配的密钥
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 合同生效日期（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 合同过期日期（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 合同签约人
        /// </summary>
        [JsonProperty("SignMan")]
        public string SignMan{ get; set; }

        /// <summary>
        /// 签购单名称，建议使用商户招牌名称
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// 收单系统分配的开放ID
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty("MerchantNo")]
        public string MerchantNo{ get; set; }

        /// <summary>
        /// 合同照片【私密区】
        /// </summary>
        [JsonProperty("PictureOne")]
        public string PictureOne{ get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 合同签署日期（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("SignDate")]
        public string SignDate{ get; set; }

        /// <summary>
        /// 合同编号（系统有唯一性校验）
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 是否自动续签（1是，0否）
        /// </summary>
        [JsonProperty("AutoSign")]
        public string AutoSign{ get; set; }

        /// <summary>
        /// 支付方式行业分类编号
        /// </summary>
        [JsonProperty("PaymentClassificationId")]
        public string PaymentClassificationId{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 合同照片【私密区】
        /// </summary>
        [JsonProperty("PictureTwo")]
        public string PictureTwo{ get; set; }

        /// <summary>
        /// 合同选项8
        /// </summary>
        [JsonProperty("PaymentOptionTen")]
        public string PaymentOptionTen{ get; set; }

        /// <summary>
        /// 合同选项7（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionNine")]
        public string PaymentOptionNine{ get; set; }

        /// <summary>
        /// 合同选项6（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionOther")]
        public string PaymentOptionOther{ get; set; }

        /// <summary>
        /// 合同证书选项1（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionFive")]
        public string PaymentOptionFive{ get; set; }

        /// <summary>
        /// 合同选项4（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionFour")]
        public string PaymentOptionFour{ get; set; }

        /// <summary>
        /// 合同选项5（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionSeven")]
        public string PaymentOptionSeven{ get; set; }

        /// <summary>
        /// 合同证书选项2（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionSix")]
        public string PaymentOptionSix{ get; set; }

        /// <summary>
        /// 合同选项1（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionOne")]
        public string PaymentOptionOne{ get; set; }

        /// <summary>
        /// 合同选项3（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionThree")]
        public string PaymentOptionThree{ get; set; }

        /// <summary>
        /// 合同选项2（不同支付方式规则不一样，请以支付方式规定的格式传值）
        /// </summary>
        [JsonProperty("PaymentOptionTwo")]
        public string PaymentOptionTwo{ get; set; }

        /// <summary>
        /// 渠道扩展字段，json格式
        /// </summary>
        [JsonProperty("ChannelExtJson")]
        public string ChannelExtJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Fee", this.Fee);
            this.SetParamSimple(map, prefix + "OutContractId", this.OutContractId);
            this.SetParamSimple(map, prefix + "PaymentClassificationLimit", this.PaymentClassificationLimit);
            this.SetParamSimple(map, prefix + "ContactTelephone", this.ContactTelephone);
            this.SetParamSimple(map, prefix + "PaymentId", this.PaymentId);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "SignMan", this.SignMan);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "MerchantNo", this.MerchantNo);
            this.SetParamSimple(map, prefix + "PictureOne", this.PictureOne);
            this.SetParamSimple(map, prefix + "Contact", this.Contact);
            this.SetParamSimple(map, prefix + "SignDate", this.SignDate);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "AutoSign", this.AutoSign);
            this.SetParamSimple(map, prefix + "PaymentClassificationId", this.PaymentClassificationId);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "PictureTwo", this.PictureTwo);
            this.SetParamSimple(map, prefix + "PaymentOptionTen", this.PaymentOptionTen);
            this.SetParamSimple(map, prefix + "PaymentOptionNine", this.PaymentOptionNine);
            this.SetParamSimple(map, prefix + "PaymentOptionOther", this.PaymentOptionOther);
            this.SetParamSimple(map, prefix + "PaymentOptionFive", this.PaymentOptionFive);
            this.SetParamSimple(map, prefix + "PaymentOptionFour", this.PaymentOptionFour);
            this.SetParamSimple(map, prefix + "PaymentOptionSeven", this.PaymentOptionSeven);
            this.SetParamSimple(map, prefix + "PaymentOptionSix", this.PaymentOptionSix);
            this.SetParamSimple(map, prefix + "PaymentOptionOne", this.PaymentOptionOne);
            this.SetParamSimple(map, prefix + "PaymentOptionThree", this.PaymentOptionThree);
            this.SetParamSimple(map, prefix + "PaymentOptionTwo", this.PaymentOptionTwo);
            this.SetParamSimple(map, prefix + "ChannelExtJson", this.ChannelExtJson);
        }
    }
}

