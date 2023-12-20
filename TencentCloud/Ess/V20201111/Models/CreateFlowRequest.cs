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

    public class CreateFlowRequest : AbstractModel
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
        /// 合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// 
        /// 该名称还将用于合同签署完成后的下载文件名。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程的参与方列表，最多可支持50个参与方，可在列表中指定企业B端签署方和个人C端签署方的联系和认证方式等信息，具体定义可以参考开发者中心的ApproverInfo结构体。
        /// 
        /// 注:  `approver中的顺序需要和模板中的顺序保持一致， 否则会导致模板中配置的信息无效`
        /// </summary>
        [JsonProperty("Approvers")]
        public FlowCreateApprover[] Approvers{ get; set; }

        /// <summary>
        /// 合同流程描述信息(可自定义此描述)，最大长度1000个字符。
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同流程的类别分类（可自定义名称，如销售合同/入职合同等），最大长度为200个字符，仅限中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 已经废弃字段，客户端Token，保持接口幂等性,最大长度64个字符
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 合同流程的签署截止时间，格式为Unix标准时间戳（秒），如果未设置签署截止时间，则默认为合同流程创建后的365天时截止。
        /// 如果在签署截止时间前未完成签署，则合同状态会变为已过期，导致合同作废。
        /// </summary>
        [JsonProperty("DeadLine")]
        public long? DeadLine{ get; set; }

        /// <summary>
        /// 合同到期提醒时间，为Unix标准时间戳（秒）格式，支持的范围是从发起时间开始到后10年内。
        /// 
        /// 到达提醒时间后，腾讯电子签会短信通知发起方企业合同提醒，可用于处理合同到期事务，如合同续签等事宜。
        /// </summary>
        [JsonProperty("RemindedOn")]
        public long? RemindedOn{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 20480长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 合同流程的签署顺序类型：
        /// <ul><li> **false**：(默认)有序签署, 本合同多个参与人需要依次签署 </li>
        /// <li> **true**：无序签署, 本合同多个参与人没有先后签署限制</li></ul>
        /// 注：`请和模板中的配置保持一致`
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 您可以自定义腾讯电子签小程序合同列表页展示的合同内容模板，模板中支持以下变量：
        /// <ul><li>{合同名称}   </li>
        /// <li>{发起方企业} </li>
        /// <li>{发起方姓名} </li>
        /// <li>{签署方N企业}</li>
        /// <li>{签署方N姓名}</li></ul>
        /// 其中，N表示签署方的编号，从1开始，不能超过签署人的数量。
        /// 
        /// 例如，如果是腾讯公司张三发给李四名称为“租房合同”的合同，您可以将此字段设置为：`合同名称:{合同名称};发起方: {发起方企业}({发起方姓名});签署方:{签署方1姓名}`，则小程序中列表页展示此合同为以下样子
        /// 
        /// 合同名称：租房合同 
        /// 发起方：腾讯公司(张三) 
        /// 签署方：李四
        /// 
        /// </summary>
        [JsonProperty("CustomShowMap")]
        public string CustomShowMap{ get; set; }

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
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程的抄送人列表，最多可支持50个抄送人，抄送人可查看合同内容及签署进度，但无需参与合同签署。
        /// </summary>
        [JsonProperty("CcInfos")]
        public CcInfo[] CcInfos{ get; set; }

        /// <summary>
        /// 个人自动签名的使用场景包括以下, 个人自动签署(即ApproverType设置成个人自动签署时)业务此值必传：
        /// <ul><li> **E_PRESCRIPTION_AUTO_SIGN**：电子处方单（医疗自动签）  </li><li> **OTHER** :  通用场景</li></ul>
        /// 注: `个人自动签名场景是白名单功能，使用前请与对接的客户经理联系沟通。`
        /// </summary>
        [JsonProperty("AutoSignScene")]
        public string AutoSignScene{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("RelatedFlowId")]
        [System.Obsolete]
        public string RelatedFlowId{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "DeadLine", this.DeadLine);
            this.SetParamSimple(map, prefix + "RemindedOn", this.RemindedOn);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "CustomShowMap", this.CustomShowMap);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "AutoSignScene", this.AutoSignScene);
            this.SetParamSimple(map, prefix + "RelatedFlowId", this.RelatedFlowId);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

