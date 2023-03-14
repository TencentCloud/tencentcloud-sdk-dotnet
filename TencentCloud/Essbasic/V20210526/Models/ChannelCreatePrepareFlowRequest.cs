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

    public class ChannelCreatePrepareFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源id，与ResourceType对应
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源类型，1：模板，目前仅支持模板，与ResourceId对应
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 合同流程基础信息
        /// </summary>
        [JsonProperty("FlowInfo")]
        public BaseFlowInfo FlowInfo{ get; set; }

        /// <summary>
        /// 合同签署人信息
        /// </summary>
        [JsonProperty("FlowApproverList")]
        public CommonFlowApprover[] FlowApproverList{ get; set; }

        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程配置信息
        /// </summary>
        [JsonProperty("FlowOption")]
        public CreateFlowOption FlowOption{ get; set; }

        /// <summary>
        /// 该参数不可用，请通过获取 web 可嵌入接口获取合同流程预览 URL
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 该参数不可用，请通过获取 web 可嵌入接口获取合同流程预览 URL
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 企业机构信息，不用传
        /// </summary>
        [JsonProperty("Organization")]
        public OrganizationInfo Organization{ get; set; }

        /// <summary>
        /// 操作人（用户）信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "FlowInfo.", this.FlowInfo);
            this.SetParamArrayObj(map, prefix + "FlowApproverList.", this.FlowApproverList);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "FlowOption.", this.FlowOption);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

