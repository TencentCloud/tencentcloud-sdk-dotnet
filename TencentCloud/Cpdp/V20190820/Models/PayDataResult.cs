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

    public class PayDataResult : AbstractModel
    {
        
        /// <summary>
        /// 支付标签（唯一性）
        /// </summary>
        [JsonProperty("PaymentTag")]
        public string PaymentTag{ get; set; }

        /// <summary>
        /// 添加合同时需要隐藏的选项（多个以小写逗号分开）
        /// </summary>
        [JsonProperty("PaymentOptionHide")]
        public string PaymentOptionHide{ get; set; }

        /// <summary>
        /// 支付方式图片url路径
        /// </summary>
        [JsonProperty("PaymentIcon")]
        public string PaymentIcon{ get; set; }

        /// <summary>
        /// 合同选项名称6
        /// </summary>
        [JsonProperty("PaymentOptionSix")]
        public string PaymentOptionSix{ get; set; }

        /// <summary>
        /// 付款方式名称
        /// </summary>
        [JsonProperty("PaymentName")]
        public string PaymentName{ get; set; }

        /// <summary>
        /// 合同选项名称7
        /// </summary>
        [JsonProperty("PaymentOptionSeven")]
        public string PaymentOptionSeven{ get; set; }

        /// <summary>
        /// 合同选项名称8
        /// </summary>
        [JsonProperty("PaymentOptionOther")]
        public string PaymentOptionOther{ get; set; }

        /// <summary>
        /// 合同选项名称2
        /// </summary>
        [JsonProperty("PaymentOptionTwo")]
        public string PaymentOptionTwo{ get; set; }

        /// <summary>
        /// 合同选项名称1
        /// </summary>
        [JsonProperty("PaymentOptionOne")]
        public string PaymentOptionOne{ get; set; }

        /// <summary>
        /// 是否开启智能扣率（1是，0否）
        /// </summary>
        [JsonProperty("PaymentDiscountFee")]
        public string PaymentDiscountFee{ get; set; }

        /// <summary>
        /// 支持的交易类型（多个以小写逗号分开，0现金，1刷卡，2主扫，3被扫，4JSPAY，5预授权）
        /// </summary>
        [JsonProperty("PaymentType")]
        public string PaymentType{ get; set; }

        /// <summary>
        /// 合同选项名称5
        /// </summary>
        [JsonProperty("PaymentOptionFive")]
        public string PaymentOptionFive{ get; set; }

        /// <summary>
        /// 合同选项名称9
        /// </summary>
        [JsonProperty("PaymentOptionNine")]
        public string PaymentOptionNine{ get; set; }

        /// <summary>
        /// 支付方式编号
        /// </summary>
        [JsonProperty("PaymentId")]
        public string PaymentId{ get; set; }

        /// <summary>
        /// 合同选项名称3
        /// </summary>
        [JsonProperty("PaymentOptionThree")]
        public string PaymentOptionThree{ get; set; }

        /// <summary>
        /// 付款方式名称（内部名称）
        /// </summary>
        [JsonProperty("PaymentInternalName")]
        public string PaymentInternalName{ get; set; }

        /// <summary>
        /// 合同选项名称4
        /// </summary>
        [JsonProperty("PaymentOptionFour")]
        public string PaymentOptionFour{ get; set; }

        /// <summary>
        /// 合同选项名称10
        /// </summary>
        [JsonProperty("PaymentOptionTen")]
        public string PaymentOptionTen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaymentTag", this.PaymentTag);
            this.SetParamSimple(map, prefix + "PaymentOptionHide", this.PaymentOptionHide);
            this.SetParamSimple(map, prefix + "PaymentIcon", this.PaymentIcon);
            this.SetParamSimple(map, prefix + "PaymentOptionSix", this.PaymentOptionSix);
            this.SetParamSimple(map, prefix + "PaymentName", this.PaymentName);
            this.SetParamSimple(map, prefix + "PaymentOptionSeven", this.PaymentOptionSeven);
            this.SetParamSimple(map, prefix + "PaymentOptionOther", this.PaymentOptionOther);
            this.SetParamSimple(map, prefix + "PaymentOptionTwo", this.PaymentOptionTwo);
            this.SetParamSimple(map, prefix + "PaymentOptionOne", this.PaymentOptionOne);
            this.SetParamSimple(map, prefix + "PaymentDiscountFee", this.PaymentDiscountFee);
            this.SetParamSimple(map, prefix + "PaymentType", this.PaymentType);
            this.SetParamSimple(map, prefix + "PaymentOptionFive", this.PaymentOptionFive);
            this.SetParamSimple(map, prefix + "PaymentOptionNine", this.PaymentOptionNine);
            this.SetParamSimple(map, prefix + "PaymentId", this.PaymentId);
            this.SetParamSimple(map, prefix + "PaymentOptionThree", this.PaymentOptionThree);
            this.SetParamSimple(map, prefix + "PaymentInternalName", this.PaymentInternalName);
            this.SetParamSimple(map, prefix + "PaymentOptionFour", this.PaymentOptionFour);
            this.SetParamSimple(map, prefix + "PaymentOptionTen", this.PaymentOptionTen);
        }
    }
}

