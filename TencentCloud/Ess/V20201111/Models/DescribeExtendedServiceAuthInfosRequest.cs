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

    public class DescribeExtendedServiceAuthInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 要查询的扩展服务类型。
        /// 默认为空，即查询当前支持的所有扩展服务信息。
        /// 若需查询单个扩展服务的开通情况，请传递相应的值，如下所示：
        /// <ul><li>OPEN_SERVER_SIGN：企业静默签署</li>
        /// <li>OVERSEA_SIGN：企业与港澳台居民签署合同</li>
        /// <li>MOBILE_CHECK_APPROVER：使用手机号验证签署方身份</li>
        /// <li>PAGING_SEAL：骑缝章</li>
        /// <li>BATCH_SIGN：批量签署</li>
        /// <li>AGE_LIMIT_EXPANSION：拓宽签署方年龄限制</li></ul>
        /// </summary>
        [JsonProperty("ExtendServiceType")]
        public string ExtendServiceType{ get; set; }

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
            this.SetParamSimple(map, prefix + "ExtendServiceType", this.ExtendServiceType);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

