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

    public class CreateFlowApproversRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 补充签署环节签署候选人信息。
        /// 
        /// 注：` 如果发起方指定的补充签署人是企业微信签署人（ApproverSource=WEWORKAPP），则需要提供企业微信UserId进行补充； 如果不指定，则使用姓名和手机号进行补充。`
        /// </summary>
        [JsonProperty("Approvers")]
        public FillApproverInfo[] Approvers{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// - 建议开发者妥善保存此流程ID，以便于顺利进行后续操作。
        /// - 可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。
        /// - <font color="red">不建议继续使用</font>，请使用<a href="https://qian.tencent.com/developers/companyApis/dataTypes/#fillapproverinfo/" target="_blank">补充签署人结构体</a>中的FlowId来指定需要补充的合同id
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 签署人信息补充方式
        /// 
        /// <ul><li>**0**: <font color="red">或签合同</font>添加签署候选人，或签支持一个节点传多个签署人，不传值默认或签。
        /// 注: `或签只支持企业签署方`</li>
        /// <li>**1**: <font color="red">动态签署人合同</font>的添加签署候选人，支持企业或个人签署方。</li></ul>
        /// </summary>
        [JsonProperty("FillApproverType")]
        public long? FillApproverType{ get; set; }

        /// <summary>
        /// 在可定制的企业微信通知中，发起人可以根据具体需求进行自定义设置。
        /// </summary>
        [JsonProperty("Initiator")]
        public string Initiator{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程组的组ID, 在合同流程组场景下，生成合同流程组的签署链接时需要赋值
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FillApproverType", this.FillApproverType);
            this.SetParamSimple(map, prefix + "Initiator", this.Initiator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
        }
    }
}

