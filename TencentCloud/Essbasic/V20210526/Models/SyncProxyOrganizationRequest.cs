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
        /// 应用信息
        /// 此接口Agent.AppId、Agent.ProxyOrganizationOpenId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 第三方平台子客企业名称，最大长度64个字符
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
        /// 第三方平台子客企业法人/负责人姓名
        /// </summary>
        [JsonProperty("ProxyLegalName")]
        public string ProxyLegalName{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


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
        }
    }
}

