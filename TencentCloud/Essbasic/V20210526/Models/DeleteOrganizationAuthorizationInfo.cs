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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteOrganizationAuthorizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 认证流 Id 是指在企业认证过程中，当前操作人的认证流程的唯一标识。每个企业在认证过程中只能有一条认证流认证成功。这意味着在同一认证过程内，一个企业只能有一个认证流程处于成功状态，以确保认证的唯一性和有效性。	
        /// </summary>
        [JsonProperty("AuthorizationId")]
        public string AuthorizationId{ get; set; }

        /// <summary>
        /// 认证的企业名称	
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识，定义Agent中的ProxyOrganizationOpenId一样, 可以参考<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#agent" target="_blank">Agent结构体</a>
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 清除认证流产生的错误信息
        /// </summary>
        [JsonProperty("Errormessage")]
        public string Errormessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthorizationId", this.AuthorizationId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "Errormessage", this.Errormessage);
        }
    }
}

