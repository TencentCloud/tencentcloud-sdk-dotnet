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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSealPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 印章授权编码数组。这个参数跟下面的SealId其中一个必填，另外一个可选填
        /// </summary>
        [JsonProperty("PolicyIds")]
        public string[] PolicyIds{ get; set; }

        /// <summary>
        /// 电子印章ID，为32位字符串。
        /// 建议开发者保留此印章ID，后续指定签署区印章或者操作印章需此印章ID。
        /// 可登录腾讯电子签控制台，在 "印章"->"印章中心"选择查看的印章，在"印章详情" 中查看某个印章的SealId(在页面中展示为印章ID)。
        /// 注：印章ID。这个参数跟上面的PolicyIds其中一个必填，另外一个可选填。
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 待授权的员工ID，员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 可登录腾讯电子签控制台，在 "更多能力"->"组织管理" 中查看某位员工的UserId(在页面中展示为用户ID)。
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

