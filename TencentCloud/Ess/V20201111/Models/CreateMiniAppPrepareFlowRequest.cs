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

    public class CreateMiniAppPrepareFlowRequest : AbstractModel
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
        /// 资源类型，取值有：
        /// <ul><li> **1**：模板</li>
        /// <li> **2**：文件 </li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

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
        /// 自定义的合同流程的名称，长度不能超过200个字符，只能由中文汉字、中文标点、英文字母、阿拉伯数字、空格、小括号、中括号、中划线、下划线以及（,）、（;）、（.）、(&)、（+）组成。
        /// 
        /// 该名称还将用于合同签署完成后文件下载的默认文件名称。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程的参与方列表，最多可支持50个参与方，可在列表中指定企业B端签署方和个人C端签署方的联系和认证方式等信息。
        /// </summary>
        [JsonProperty("Approvers")]
        public MiniAppCreateApproverInfo[] Approvers{ get; set; }

        /// <summary>
        /// 合同流程的抄送人列表，最多可支持50个抄送人，抄送人可查看合同内容及签署进度，但无需参与合同签署。
        /// 
        /// **注：暂不支持通过NotifyType参数控制抄送人通知方式**
        /// </summary>
        [JsonProperty("CcInfos")]
        public CcInfo[] CcInfos{ get; set; }

        /// <summary>
        /// 合同流程的签署顺序类型：
        /// <ul><li> **false**：(默认)有序签署, 本合同多个参与人需要依次签署 </li>
        /// <li> **true**：无序签署, 本合同多个参与人没有先后签署限制</li></ul>
        /// 
        /// **注：仅在文件发起模式下设置有效，模板发起以模板配置为准**
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 合同发起后经过多少天截止（1-30天可选），默认7天
        /// </summary>
        [JsonProperty("DeadlineAfterStartDays")]
        public long? DeadlineAfterStartDays{ get; set; }

        /// <summary>
        /// 用户自定义合同类型Id  该id为电子签企业内的合同类型id， 可以在控制台-合同-自定义合同类型处获取
        /// </summary>
        [JsonProperty("UserFlowTypeId")]
        public string UserFlowTypeId{ get; set; }

        /// <summary>
        /// 发起合同个性化参数
        /// 用于满足小程序合同创建的个性化要求
        /// 具体定制化内容详见数据接口说明
        /// </summary>
        [JsonProperty("FlowOption")]
        public MiniAppCreateFlowOption FlowOption{ get; set; }

        /// <summary>
        /// 发起合同小程序页面个性化参数 
        /// 用于满足小程序合同创建页面的个性化要求 具体定制化内容详见数据接口说明
        /// </summary>
        [JsonProperty("PageOption")]
        public MiniAppCreateFlowPageOption PageOption{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 1000 长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "DeadlineAfterStartDays", this.DeadlineAfterStartDays);
            this.SetParamSimple(map, prefix + "UserFlowTypeId", this.UserFlowTypeId);
            this.SetParamObj(map, prefix + "FlowOption.", this.FlowOption);
            this.SetParamObj(map, prefix + "PageOption.", this.PageOption);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
        }
    }
}

