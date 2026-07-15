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

    public class CreateSealPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。<br>注: <code>在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</code></p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>用户在电子文件签署平台标识信息，具体参考UserInfo结构体。可跟下面的UserIds可叠加起作用,<br>同时也支持使用主企业的User进行授权， 当使用主企业的User时， 需要有集团角色。</p>
        /// </summary>
        [JsonProperty("Users")]
        public UserInfo[] Users{ get; set; }

        /// <summary>
        /// <p>电子印章ID，为32位字符串。<br>建议开发者保留此印章ID，后续指定签署区印章或者操作印章需此印章ID。<br>可登录腾讯电子签控制台，在 &quot;印章&quot;-&gt;&quot;印章中心&quot;选择查看的印章，在&quot;印章详情&quot; 中查看某个印章的SealId(在页面中展示为印章ID)。</p>
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// <p>授权有效期，时间戳秒级。可以传0，代表有效期到2099年12月12日23点59分59秒。</p>
        /// </summary>
        [JsonProperty("Expired")]
        public long? Expired{ get; set; }

        /// <summary>
        /// <p>需要授权的用户UserId集合。跟上面的SealId参数配合使用。选填，跟上面的Users同时起作用。<br>支持使用主企业的UserId进行授权， 当使用主企业的UserId时，该UserId 需要有集团角色。</p>
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// <p>印章授权内容，最多300 个字符。</p>
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// <p>代理企业和员工的信息。<br>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>个性化配置字段，默认不传。</p>
        /// </summary>
        [JsonProperty("Options")]
        public Option[] Options{ get; set; }

        /// <summary>
        /// <p>针对用印的合同/合同组授权。<br>当单次用印授权时，可以仅在指定合同获得印章授权。<br>此场景下不会触发印章授权回调。</p>
        /// </summary>
        [JsonProperty("AuthorizationFlows")]
        public SealPolicyAuthorizationFlows AuthorizationFlows{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArrayObj(map, prefix + "Users.", this.Users);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "Expired", this.Expired);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
            this.SetParamObj(map, prefix + "AuthorizationFlows.", this.AuthorizationFlows);
        }
    }
}

