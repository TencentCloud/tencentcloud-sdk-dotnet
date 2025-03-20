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

    public class HasAuthOrganization : AbstractModel
    {
        
        /// <summary>
        /// 授权企业openid，
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 授权企业名称	
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 被授权企业openid，
        /// </summary>
        [JsonProperty("AuthorizedOrganizationOpenId")]
        public string AuthorizedOrganizationOpenId{ get; set; }

        /// <summary>
        /// 被授权企业名称	
        /// </summary>
        [JsonProperty("AuthorizedOrganizationName")]
        public string AuthorizedOrganizationName{ get; set; }

        /// <summary>
        /// 授权时间，格式为时间戳，单位s	
        /// </summary>
        [JsonProperty("AuthorizeTime")]
        public long? AuthorizeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationOpenId", this.AuthorizedOrganizationOpenId);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationName", this.AuthorizedOrganizationName);
            this.SetParamSimple(map, prefix + "AuthorizeTime", this.AuthorizeTime);
        }
    }
}

