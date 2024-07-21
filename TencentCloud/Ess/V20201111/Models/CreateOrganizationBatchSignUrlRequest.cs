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

    public class CreateOrganizationBatchSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写userId。
        /// 支持填入集团子公司经办人 userId 代发合同。
        /// 
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 请指定需执行批量签署的流程ID，数量范围为1-100。
        /// 您可登录腾讯电子签控制台，浏览 "合同"->"合同中心" 以查阅某一合同的FlowId（在页面中显示为合同ID）。
        /// 用户将利用链接对这些合同实施批量操作。
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 员工在腾讯电子签平台的独特身份标识，为32位字符串。
        /// 您可登录腾讯电子签控制台，在 "更多能力"->"组织管理" 中查阅某位员工的UserId（在页面中显示为用户ID）。
        /// UserId必须是传入合同（FlowId）中的签署人。
        /// 
        /// <ul>
        /// <li>1. 若UserId为空，Name和Mobile 必须提供。</li>
        /// <li>2. 若UserId 与 Name，Mobile均存在，将优先采用UserId对应的员工。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 员工姓名，必须与手机号码一起使用。
        /// 如果UserId为空，则此字段不能为空。同时，姓名和手机号码必须与传入合同（FlowId）中的签署人信息一致。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 员工手机号，必须与姓名一起使用。
        ///  如果UserId为空，则此字段不能为空。同时，姓名和手机号码必须与传入合同（FlowId）中的签署人信息一致。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 为签署方经办人在签署合同中的参与方ID，必须与参数FlowIds数组一一对应。
        /// 您可以通过查询合同接口（DescribeFlowInfo）查询此参数。
        /// 若传了此参数，则可以不传 UserId, Name, Mobile等参数
        /// </summary>
        [JsonProperty("RecipientIds")]
        public string[] RecipientIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamArraySimple(map, prefix + "RecipientIds.", this.RecipientIds);
        }
    }
}

