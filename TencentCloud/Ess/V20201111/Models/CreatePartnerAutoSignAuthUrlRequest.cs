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

    public class CreatePartnerAutoSignAuthUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 代理企业和员工的信息。<br/>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。<br/>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 被授企业id/授权方企业id（即OrganizationId），和AuthorizedOrganizationName二选一传入
        /// </summary>
        [JsonProperty("AuthorizedOrganizationId")]
        public string AuthorizedOrganizationId{ get; set; }

        /// <summary>
        /// 被授企业名称/授权方企业的名字，和AuthorizedOrganizationId二选一传入即可。请确认该名称与企业营业执照中注册的名称一致。
        /// 注: `如果名称中包含英文括号()，请使用中文括号（）代替。`
        /// </summary>
        [JsonProperty("AuthorizedOrganizationName")]
        public string AuthorizedOrganizationName{ get; set; }

        /// <summary>
        /// 在设置印章授权时，可以指定特定的印章类型，以确保在授权过程中只使用相应类型的印章。支持的印章类型包括：
        /// 
        /// <ul>
        /// <li><strong>OFFICIAL</strong>：企业公章，用于代表企业对外的正式文件和重要事务的认证。</li>
        /// <li><strong>CONTRACT</strong>：合同专用章，专门用于签署各类合同。</li>
        /// <li><strong>FINANCE</strong>：财务专用章，用于企业的财务相关文件，如发票、收据等财务凭证的认证。</li>
        /// <li><strong>PERSONNEL</strong>：人事专用章，用于人事管理相关文件，如劳动合同、人事任命等。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SealTypes")]
        public string[] SealTypes{ get; set; }

        /// <summary>
        /// 在处理授权关系时，授权的方向
        /// <ul>
        /// <li><strong>false</strong>（默认值）：表示我方授权他方。在这种情况下，<code>AuthorizedOrganizationName</code> 代表的是【被授权方】的企业名称，即接收授权的企业。</li>
        /// <li><strong>true</strong>：表示他方授权我方。在这种情况下，<code>AuthorizedOrganizationName</code> 代表的是【授权方】的企业名称，即提供授权的企业。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthToMe")]
        public bool? AuthToMe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationId", this.AuthorizedOrganizationId);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationName", this.AuthorizedOrganizationName);
            this.SetParamArraySimple(map, prefix + "SealTypes.", this.SealTypes);
            this.SetParamSimple(map, prefix + "AuthToMe", this.AuthToMe);
        }
    }
}

