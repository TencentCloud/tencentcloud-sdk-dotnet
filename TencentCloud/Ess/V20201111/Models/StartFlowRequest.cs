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

    public class StartFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// 此处需要传入[创建签署流程接口](https://qian.tencent.com/developers/companyApis/startFlows/CreateFlow)得到的FlowId。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 客户端Token，保持接口幂等性,最大长度64个字符
        /// </summary>
        [JsonProperty("ClientToken")]
        [System.Obsolete]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 若在创建签署流程时指定了关注人CcInfos，此参数可设定向关注人发送短信通知的类型：
        /// <ul><li> **0** :合同发起时通知通知对方来查看合同（默认）</li>
        /// <li> **1** : 签署完成后通知对方来查看合同</li></ul>
        /// </summary>
        [JsonProperty("CcNotifyType")]
        public long? CcNotifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "CcNotifyType", this.CcNotifyType);
        }
    }
}

