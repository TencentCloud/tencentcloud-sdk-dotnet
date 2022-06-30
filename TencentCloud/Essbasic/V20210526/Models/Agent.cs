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

    public class Agent : AbstractModel
    {
        
        /// <summary>
        /// 腾讯电子签颁发给渠道的应用ID，32位字符串
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 渠道/平台合作企业的企业ID
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenId")]
        public string ProxyOrganizationOpenId{ get; set; }

        /// <summary>
        /// 渠道/平台合作企业经办人（操作员）
        /// </summary>
        [JsonProperty("ProxyOperator")]
        public UserInfo ProxyOperator{ get; set; }

        /// <summary>
        /// 腾讯电子签颁发给渠道侧合作企业的应用ID
        /// </summary>
        [JsonProperty("ProxyAppId")]
        public string ProxyAppId{ get; set; }

        /// <summary>
        /// 腾讯电子签颁发给渠道侧合作企业的企业ID
        /// </summary>
        [JsonProperty("ProxyOrganizationId")]
        public string ProxyOrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenId", this.ProxyOrganizationOpenId);
            this.SetParamObj(map, prefix + "ProxyOperator.", this.ProxyOperator);
            this.SetParamSimple(map, prefix + "ProxyAppId", this.ProxyAppId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationId", this.ProxyOrganizationId);
        }
    }
}

