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

    public class CreatePrepareFlowRequest : AbstractModel
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
        /// 资源id，与ResourceType相对应，取值范围：
        /// <ul>
        /// <li>文件Id（通过UploadFiles获取文件资源Id）</li>
        /// <li>模板Id（通过控制台创建模板后获取模板Id）</li>
        /// <li>草稿Id（通过嵌入页面保存草稿后获取草稿Id）</li>
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
        /// 资源类型，取值有：
        /// <ul><li> **1**：模板</li>
        /// <li> **2**：文件（默认值）</li>
        /// <li> **3**：草稿</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 合同流程的签署顺序类型：
        /// <ul><li> **false**：(默认)有序签署, 本合同多个参与人需要依次签署 </li>
        /// <li> **true**：无序签署, 本合同多个参与人没有先后签署限制</li></ul>
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 合同流程的签署截止时间，格式为Unix标准时间戳（秒），如果未设置签署截止时间，则默认为合同流程创建后的365天时截止。
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 用户自定义合同类型Id
        /// 
        /// 该id为电子签企业内的合同类型id， 可以在控制台-合同-自定义合同类型处获取
        /// 注: `该参数如果和FlowType同时传，以该参数优先生效`
        /// </summary>
        [JsonProperty("UserFlowTypeId")]
        public string UserFlowTypeId{ get; set; }

        /// <summary>
        /// 合同流程的类别分类（可自定义名称，如销售合同/入职合同等），最大长度为200个字符，仅限中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 合同流程的参与方列表，最多可支持50个参与方，可在列表中指定企业B端签署方和个人C端签署方的联系和认证方式等信息，具体定义可以参考开发者中心的ApproverInfo结构体。
        /// 
        /// 如果合同流程是有序签署，Approvers列表中参与人的顺序就是默认的签署顺序，请确保列表中参与人的顺序符合实际签署顺序。
        /// </summary>
        [JsonProperty("Approvers")]
        public FlowCreateApprover[] Approvers{ get; set; }

        /// <summary>
        /// 开启或者关闭智能添加填写区：
        /// <ul><li> **OPEN**：开启（默认值）</li>
        /// <li> **CLOSE**：关闭</li></ul>
        /// </summary>
        [JsonProperty("IntelligentStatus")]
        public string IntelligentStatus{ get; set; }

        /// <summary>
        /// 该字段已不再使用，请使用InitiatorComponents
        /// </summary>
        [JsonProperty("Components")]
        public Component Components{ get; set; }

        /// <summary>
        /// 发起合同个性化参数
        /// 用于满足创建及页面操作过程中的个性化要求
        /// 具体定制化内容详见数据接口说明
        /// </summary>
        [JsonProperty("FlowOption")]
        public CreateFlowOption FlowOption{ get; set; }

        /// <summary>
        /// 发起方企业的签署人进行签署操作前，是否需要企业内部走审批流程，取值如下：
        /// <ul><li> **false**：（默认）不需要审批，直接签署。</li>
        /// <li> **true**：需要走审批流程。当到对应参与人签署时，会阻塞其签署操作，等待企业内部审批完成。</li></ul>
        /// 企业可以通过CreateFlowSignReview审批接口通知腾讯电子签平台企业内部审批结果
        /// <ul><li> 如果企业通知腾讯电子签平台审核通过，签署方可继续签署动作。</li>
        /// <li> 如果企业通知腾讯电子签平台审核未通过，平台将继续阻塞签署方的签署动作，直到企业通知平台审核通过。</li></ul>
        /// 注：`此功能可用于与企业内部的审批流程进行关联，支持手动、静默签署合同`
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }

        /// <summary>
        /// 发起方企业的签署人进行发起操作是否需要企业内部审批。使用此功能需要发起方企业有参与签署。
        /// 
        /// 若设置为true，发起审核结果需通过接口 CreateFlowSignReview 通知电子签，审核通过后，发起方企业签署人方可进行发起操作，否则会阻塞其发起操作。
        /// 
        /// </summary>
        [JsonProperty("NeedCreateReview")]
        public bool? NeedCreateReview{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 20480长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 合同流程的抄送人列表，最多可支持50个抄送人，抄送人可查看合同内容及签署进度，但无需参与合同签署。
        /// </summary>
        [JsonProperty("CcInfos")]
        public CcInfo[] CcInfos{ get; set; }

        /// <summary>
        /// 合同Id：用于通过一个已发起的合同快速生成一个发起流程web链接
        /// 注: `该参数必须是一个待发起审核的合同id，并且还未审核通过`
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 模板或者合同中的填写控件列表，列表中可支持下列多种填写控件，控件的详细定义参考开发者中心的Component结构体
        /// </summary>
        [JsonProperty("InitiatorComponents")]
        public Component[] InitiatorComponents{ get; set; }

        /// <summary>
        /// 在短信通知、填写、签署流程中，若标题、按钮、合同详情等地方存在“合同”字样时，可根据此配置指定文案，可选文案如下：  <ul><li> <b>0</b> :合同（默认值）</li> <li> <b>1</b> :文件</li> <li> <b>2</b> :协议</li><li> <b>3</b> :文书</li></ul>效果如下:![FlowDisplayType](https://qcloudimg.tencent-cloud.cn/raw/e4a2c4d638717cc901d3dbd5137c9bbc.png)
        /// </summary>
        [JsonProperty("FlowDisplayType")]
        public long? FlowDisplayType{ get; set; }

        /// <summary>
        /// <font color="red">此字段已不再使用，请使用 CreateFlowOption 里面的 SignComponentConfig</font>
        /// 签署控件的配置信息，用在嵌入式发起的页面配置，
        /// 包括  
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
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UserFlowTypeId", this.UserFlowTypeId);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "IntelligentStatus", this.IntelligentStatus);
            this.SetParamObj(map, prefix + "Components.", this.Components);
            this.SetParamObj(map, prefix + "FlowOption.", this.FlowOption);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
            this.SetParamSimple(map, prefix + "NeedCreateReview", this.NeedCreateReview);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "InitiatorComponents.", this.InitiatorComponents);
            this.SetParamSimple(map, prefix + "FlowDisplayType", this.FlowDisplayType);
            this.SetParamObj(map, prefix + "SignComponentConfig.", this.SignComponentConfig);
        }
    }
}

