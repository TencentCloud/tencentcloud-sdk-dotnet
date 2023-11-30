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

    public class DescribeChannelSealPolicyWorkflowUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// 
        /// 渠道应用标识: Agent.AppId
        /// 第三方平台子客企业标识: Agent.ProxyOrganizationOpenId
        /// 第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 用印审批单的ID，可通过用印申请回调获取。
        /// </summary>
        [JsonProperty("WorkflowInstanceId")]
        public string WorkflowInstanceId{ get; set; }

        /// <summary>
        /// 生成链接的类型：
        /// 生成链接的类型
        /// <ul><li>**LongLink**：(默认)长链接，H5跳转到电子签小程序链接，链接有效期为1年</li>
        /// <li>**ShortLink**：H5跳转到电子签小程序链接，一般用于发送短信中带的链接，打开后进入腾讯电子签小程序，链接有效期为7天</li>
        /// <li>**App**：第三方APP或小程序跳转电子签小程序链接，一般用于贵方小程序或者APP跳转过来，打开后进入腾讯电子签小程序，链接有效期为1年</li></ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "WorkflowInstanceId", this.WorkflowInstanceId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

