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

    public class ChannelCreateFlowSignReviewRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 签署流程编号
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 企业内部审核结果
        /// PASS: 通过
        /// REJECT: 拒绝
        /// SIGN_REJECT:拒签(流程结束)
        /// </summary>
        [JsonProperty("ReviewType")]
        public string ReviewType{ get; set; }

        /// <summary>
        /// 审核原因 
        /// 当ReviewType 是REJECT 时此字段必填,字符串长度不超过200
        /// </summary>
        [JsonProperty("ReviewMessage")]
        public string ReviewMessage{ get; set; }

        /// <summary>
        /// 签署节点审核时需要指定，给个人审核时必填。
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 操作类型，默认：SignReview；SignReview:签署审核，CreateReview：发起审核
        /// 注：接口通过该字段区分操作类型
        /// 该字段不传或者为空，则默认为SignReview签署审核，走签署审核流程
        /// 若想使用发起审核，请指定该字段为：CreateReview
        /// 若发起个人审核，则指定该字段为：SignReview（注意，给个人审核时，需联系客户经理开白使用）
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ReviewType", this.ReviewType);
            this.SetParamSimple(map, prefix + "ReviewMessage", this.ReviewMessage);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
        }
    }
}

