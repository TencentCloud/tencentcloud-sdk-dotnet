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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 用户在电子文件签署平台标识信息，具体参考UserInfo结构体。可跟下面的UserIds可叠加起作用
        /// </summary>
        [JsonProperty("Users")]
        public UserInfo[] Users{ get; set; }

        /// <summary>
        /// 印章ID
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 授权有效期。时间戳秒级
        /// </summary>
        [JsonProperty("Expired")]
        public long? Expired{ get; set; }

        /// <summary>
        /// 需要授权的用户UserId集合。跟上面的SealId参数配合使用。选填，跟上面的Users同时起作用
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 印章授权内容
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


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
        }
    }
}

