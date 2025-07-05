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

    public class CreateBatchInitOrganizationUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 初始化操作类型
        /// <ul>
        /// <li>CREATE_SEAL : 创建印章</li>
        /// <li>OPEN_AUTO_SIGN :开通企业自动签署</li>
        /// <li>PARTNER_AUTO_SIGN_AUTH :合作方企业或应用平台方授权自动签</li>
        /// </ul>
        /// </summary>
        [JsonProperty("OperateTypes")]
        public string[] OperateTypes{ get; set; }

        /// <summary>
        /// 批量操作的企业列表在第三方平台的企业Id列表，即ProxyOrganizationOpenId列表,最大支持50个
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenIds")]
        public string[] ProxyOrganizationOpenIds{ get; set; }

        /// <summary>
        /// 当操作类型包含 PARTNER_AUTO_SIGN_AUTH 且是给应用平台方授权自动签时传true。
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/f9aba7c999a6d79ada20b4384520e120.png)
        /// </summary>
        [JsonProperty("IsAuthorizePlatformApplication")]
        public bool? IsAuthorizePlatformApplication{ get; set; }

        /// <summary>
        /// 被授权的合作方企业在第三方平台子客企业标识，即ProxyOrganizationOpenId，当操作类型包含 PARTNER_AUTO_SIGN_AUTH 且要进行合作方企业授权自动签时必传。
        /// 
        /// 
        /// </summary>
        [JsonProperty("AuthorizedProxyOrganizationOpenId")]
        public string AuthorizedProxyOrganizationOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "OperateTypes.", this.OperateTypes);
            this.SetParamArraySimple(map, prefix + "ProxyOrganizationOpenIds.", this.ProxyOrganizationOpenIds);
            this.SetParamSimple(map, prefix + "IsAuthorizePlatformApplication", this.IsAuthorizePlatformApplication);
            this.SetParamSimple(map, prefix + "AuthorizedProxyOrganizationOpenId", this.AuthorizedProxyOrganizationOpenId);
        }
    }
}

