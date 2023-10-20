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

    public class CreateFlowsByTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业标识: Agent. ProxyOperator.OpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent.AppId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 要创建的合同信息列表，最多支持一次创建20个合同
        /// </summary>
        [JsonProperty("FlowInfos")]
        public FlowInfo[] FlowInfos{ get; set; }

        /// <summary>
        /// 是否为预览模式，取值如下：
        /// <ul><li> **false**：非预览模式（默认），会产生合同流程并返回合同流程编号FlowId。</li>
        /// <li> **true**：预览模式，不产生合同流程，不返回合同流程编号FlowId，而是返回预览链接PreviewUrl，有效期为300秒，用于查看真实发起后合同的样子。</li></ul>
        /// 
        /// 注:
        /// 
        /// `如果预览的文件中指定了动态表格控件，此时此接口返回的是合成前的文档预览链接，合成完成后的文档预览链接需要通过回调通知的方式或使用返回的TaskInfo中的TaskId通过ChannelGetTaskResultApi接口查询得到`
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 预览模式下产生的预览链接类型 
        /// <ul><li> **0** :(默认) 文件流 ,点开后后下载预览的合同PDF文件 </li>
        /// <li> **1** :H5链接 ,点开后在浏览器中展示合同的样子</li></ul>
        /// 注: `此参数在NeedPreview 为true时有效`
        /// </summary>
        [JsonProperty("PreviewType")]
        public long? PreviewType{ get; set; }

        /// <summary>
        /// 操作者的信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "FlowInfos.", this.FlowInfos);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

