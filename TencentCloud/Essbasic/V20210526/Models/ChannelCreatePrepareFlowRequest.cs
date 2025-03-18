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
        /// 资源类型，取值有：
        /// <ul><li> **1**：模板</li>
        /// <li> **2**：文件（默认值）</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 要创建的合同信息
        /// </summary>
        [JsonProperty("FlowInfo")]
        public BaseFlowInfo FlowInfo{ get; set; }

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
        /// 资源id，与ResourceType相对应，取值范围：
        /// <ul>
        /// <li>文件Id（通过UploadFiles获取文件资源Id）</li>
        /// <li>模板Id（通过控制台创建模板后获取模板Id）</li>
        /// </ul>
        /// 注意：需要同时设置 ResourceType 参数指定资源类型
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 合同流程配置信息，用于配置发起合同时定制化如是否允许修改，某些按钮的隐藏等逻辑
        /// </summary>
        [JsonProperty("FlowOption")]
        public CreateFlowOption FlowOption{ get; set; }

        /// <summary>
        /// 合同签署人信息
        /// </summary>
        [JsonProperty("FlowApproverList")]
        public CommonFlowApprover[] FlowApproverList{ get; set; }

        /// <summary>
        /// 合同Id：用于通过一个已发起的合同快速生成一个发起流程web链接
        /// 注: `该参数必须是一个待发起审核的合同id，并且还未审核通过`
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 该参数不可用，请通过获取 web 可嵌入接口获取合同流程预览 URL
        /// </summary>
        [JsonProperty("NeedPreview")]
        [System.Obsolete]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 企业机构信息，不用传
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }

        /// <summary>
        /// 操作人（用户）信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <font color="red">此参数已经废弃，请使用 CreateFlowOption 里面的 SignComponentConfig</font>
        /// 签署控件的配置信息，用在嵌入式发起的页面配置，包括
        /// 
        /// - 签署控件 是否默认展示日期.
        /// </summary>
        [JsonProperty("SignComponentConfig")]
        [System.Obsolete]
        public SignComponentConfig SignComponentConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "FlowInfo.", this.FlowInfo);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "FlowOption.", this.FlowOption);
            this.SetParamArrayObj(map, prefix + "FlowApproverList.", this.FlowApproverList);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "SignComponentConfig.", this.SignComponentConfig);
        }
    }
}

