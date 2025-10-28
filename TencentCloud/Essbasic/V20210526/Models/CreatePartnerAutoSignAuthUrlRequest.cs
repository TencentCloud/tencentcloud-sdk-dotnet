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

    public class CreatePartnerAutoSignAuthUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 被授企业id/授权方企业id（即OrganizationId），如果是企业之间授权和AuthorizedOrganizationName二选一传入。
        /// 
        /// 注：`被授权企业必须和当前企业在同一应用号下`
        /// </summary>
        [JsonProperty("AuthorizedOrganizationId")]
        [System.Obsolete]
        public string AuthorizedOrganizationId{ get; set; }

        /// <summary>
        /// 被授企业名称/授权方企业的名字，如果是企业之间授权和AuthorizedOrganizationId二选一传入即可。请确认该名称与企业营业执照中注册的名称一致。
        /// 
        /// 注: 
        /// 1. 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// 2. 被授权企业必须和当前企业在同一应用号下
        /// </summary>
        [JsonProperty("AuthorizedOrganizationName")]
        [System.Obsolete]
        public string AuthorizedOrganizationName{ get; set; }

        /// <summary>
        /// 是否给平台应用授权
        /// 
        /// <ul>
        /// <li><strong>true</strong>: 表示是，授权平台应用。在此情况下，无需设置<code>AuthorizedOrganizationIds</code>和<code>AuthorizedOrganizationNames</code>。</li>
        /// <li><strong>false</strong>: （默认）表示否，不是授权平台应用。</li>
        /// </ul>
        /// 
        ///  注：授权给平台应用需要开通【基于子客授权第三方应用可文件发起子客自动签署】白名单，请联系运营经理开通。
        /// </summary>
        [JsonProperty("PlatformAppAuthorization")]
        public bool? PlatformAppAuthorization{ get; set; }

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
        /// <li><strong>false</strong>（默认值）：表示我方授权他方。在这种情况下，<code>AuthorizedOrganizationNames</code> 代表的是【被授权方】的企业名称，即接收授权的企业。</li>
        /// <li><strong>true</strong>：表示他方授权我方。在这种情况下，<code>AuthorizedOrganizationNames</code> 代表的是【授权方】的企业名称，即提供授权的企业。此场景下不支持批量</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthToMe")]
        public bool? AuthToMe{ get; set; }

        /// <summary>
        /// 被授企业id/授权方企业id（即OrganizationId），如果是企业之间授权和AuthorizedOrganizationNames二选一传入，最大支持50个，注：`被授权企业必须和当前企业在同一应用号下`
        /// </summary>
        [JsonProperty("AuthorizedOrganizationIds")]
        public string[] AuthorizedOrganizationIds{ get; set; }

        /// <summary>
        /// 被授企业名称/授权方企业的名字，如果是企业之间授权和AuthorizedOrganizationIds二选一传入即可。请确认该名称与企业营业执照中注册的名称一致。注: 1. 如果名称中包含英文括号()，请使用中文括号（）代替。2. 被授权企业必须和当前企业在同一应用号下 3. 数组最大长度50
        /// </summary>
        [JsonProperty("AuthorizedOrganizationNames")]
        public string[] AuthorizedOrganizationNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationId", this.AuthorizedOrganizationId);
            this.SetParamSimple(map, prefix + "AuthorizedOrganizationName", this.AuthorizedOrganizationName);
            this.SetParamSimple(map, prefix + "PlatformAppAuthorization", this.PlatformAppAuthorization);
            this.SetParamArraySimple(map, prefix + "SealTypes.", this.SealTypes);
            this.SetParamSimple(map, prefix + "AuthToMe", this.AuthToMe);
            this.SetParamArraySimple(map, prefix + "AuthorizedOrganizationIds.", this.AuthorizedOrganizationIds);
            this.SetParamArraySimple(map, prefix + "AuthorizedOrganizationNames.", this.AuthorizedOrganizationNames);
        }
    }
}

