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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncProxyOrganizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 第三方平台子客企业名称，请确认该名称与企业营业执照中注册的名称一致。
        /// 注: `如果名称中包含英文括号()，请使用中文括号（）代替。`
        /// </summary>
        [JsonProperty("ProxyOrganizationName")]
        public string ProxyOrganizationName{ get; set; }

        /// <summary>
        /// 营业执照正面照(PNG或JPG) base64格式, 大小不超过5M
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// 第三方平台子客企业统一社会信用代码，最大长度200个字符
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 第三方平台子客企业法定代表人的名字
        /// </summary>
        [JsonProperty("ProxyLegalName")]
        public string ProxyLegalName{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 第三方平台子客企业法定代表人的证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证 (默认值)</li></ul>
        /// 注: `现在仅支持ID_CARD居民身份证类型`
        /// </summary>
        [JsonProperty("ProxyLegalIdCardType")]
        public string ProxyLegalIdCardType{ get; set; }

        /// <summary>
        /// 第三方平台子客企业法定代表人的证件号码, 应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li></ul>
        /// </summary>
        [JsonProperty("ProxyLegalIdCardNumber")]
        public string ProxyLegalIdCardNumber{ get; set; }

        /// <summary>
        /// 第三方平台子客企业详细住所，最大长度500个字符
        /// 
        /// 注：`需要符合省市区详情的格式例如： XX省XX市XX区街道具体地址`
        /// </summary>
        [JsonProperty("ProxyAddress")]
        public string ProxyAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ProxyOrganizationName", this.ProxyOrganizationName);
            this.SetParamSimple(map, prefix + "BusinessLicense", this.BusinessLicense);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "ProxyLegalName", this.ProxyLegalName);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ProxyLegalIdCardType", this.ProxyLegalIdCardType);
            this.SetParamSimple(map, prefix + "ProxyLegalIdCardNumber", this.ProxyLegalIdCardNumber);
            this.SetParamSimple(map, prefix + "ProxyAddress", this.ProxyAddress);
        }
    }
}

