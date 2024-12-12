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

    public class ChannelCreateFlowByFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程描述信息(可自定义此描述)，最大长度1000个字符。
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同流程的参与方列表, 最多可支持50个参与方，可在列表中指定企业B端签署方和个人C端签署方的联系和认证方式等信息，不同类型的签署方传参方式可以参考文档 [签署方入参指引](https://qian.tencent.com/developers/partner/flow_approver)。
        /// 
        /// 如果合同流程是有序签署，Approvers列表中参与人的顺序就是默认的签署顺序, 请确保列表中参与人的顺序符合实际签署顺序。
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverInfo[] FlowApprovers{ get; set; }

        /// <summary>
        /// 本合同流程需包含的PDF文件资源编号列表，通过<a href="https://qian.tencent.com/developers/partnerApis/files/UploadFiles" target="_blank">UploadFiles</a>接口获取PDF文件资源编号。
        /// 
        /// 注: `目前，此接口仅支持单个文件发起。`
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 模板或者合同中的填写控件列表，列表中可支持下列多种填写控件，控件的详细定义参考开发者中心的Component结构体
        /// <ul><li>单行文本控件</li>
        /// <li>多行文本控件</li>
        /// <li>勾选框控件</li>
        /// <li>数字控件</li>
        /// <li>图片控件</li>
        /// <li>数据表格等填写控件</li></ul>
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// 合同流程的签署截止时间，格式为Unix标准时间戳（秒），如果未设置签署截止时间，则默认为合同流程创建后的365天时截止。
        /// 如果在签署截止时间前未完成签署，则合同状态会变为已过期，导致合同作废。
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 该字段已废弃，请使用【应用号配置】中的回调地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 合同流程的签署顺序类型：
        /// <ul><li> **false**：(默认)有序签署, 本合同多个参与人需要依次签署 </li>
        /// <li> **true**：无序签署, 本合同多个参与人没有先后签署限制</li></ul>
        /// **注**: `有序签署时以传入FlowApprovers数组的顺序作为签署顺序`
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 合同流程的类别分类（可自定义名称，如销售合同/入职合同等），最大长度为255个字符，仅限中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

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
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 1000长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/partner/callback_types_contracts_sign" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("CustomerData")]
        public string CustomerData{ get; set; }

        /// <summary>
        /// 发起方企业的签署人进行签署操作前，是否需要企业内部走审批流程，取值如下：
        /// <ul><li> **false**：（默认）不需要审批，直接签署。</li>
        /// <li> **true**：需要走审批流程。当到对应参与人签署时，会阻塞其签署操作，等待企业内部审批完成。</li></ul>
        /// 企业可以通过ChannelCreateFlowSignReview审批接口通知腾讯电子签平台企业内部审批结果
        /// <ul><li> 如果企业通知腾讯电子签平台审核通过，签署方可继续签署动作。</li>
        /// <li> 如果企业通知腾讯电子签平台审核未通过，平台将继续阻塞签署方的签署动作，直到企业通知平台审核通过。</li></ul>
        /// 注：`此功能可用于与企业内部的审批流程进行关联，支持手动、静默签署合同`
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }

        /// <summary>
        /// 签署人校验方式
        /// VerifyCheck: 人脸识别（默认）
        /// MobileCheck：手机号验证，用户手机号和参与方手机号（ApproverMobile）相同即可查看合同内容（当手写签名方式为OCR_ESIGN时，该校验方式无效，因为这种签名方式依赖实名认证）
        /// 参数说明：可选人脸识别或手机号验证两种方式，若选择后者，未实名个人签署方在签署合同时，无需经过实名认证和意愿确认两次人脸识别，该能力仅适用于个人签署方。
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }

        /// <summary>
        /// 签署方签署控件（印章/签名等）的生成方式：
        /// <ul><li> **0**：在合同流程发起时，由发起人指定签署方的签署控件的位置和数量。</li>
        /// <li> **1**：签署方在签署时自行添加签署控件，可以拖动位置和控制数量。</li></ul>
        /// **注**: `发起后添加控件功能不支持添加签批控件`
        /// </summary>
        [JsonProperty("SignBeanTag")]
        public long? SignBeanTag{ get; set; }

        /// <summary>
        /// 合同流程的抄送人列表，最多可支持50个抄送人，抄送人可查看合同内容及签署进度，但无需参与合同签署。
        /// 
        /// <b>注</b>
        /// 1. 抄送人名单中可以包括自然人以及本企业的员工（本企业员工必须已经完成认证并加入企业）。
        /// 2. 请确保抄送人列表中的成员不与任何签署人重复。
        /// </summary>
        [JsonProperty("CcInfos")]
        public CcInfo[] CcInfos{ get; set; }

        /// <summary>
        /// 可以设置以下时间节点来给抄送人发送短信通知来查看合同内容：
        /// <ul><li> **0**：合同发起时通知（默认值）</li>
        /// <li> **1**：签署完成后通知</li></ul>
        /// </summary>
        [JsonProperty("CcNotifyType")]
        public long? CcNotifyType{ get; set; }

        /// <summary>
        /// 个人自动签名的使用场景包括以下, 个人自动签署(即ApproverType设置成个人自动签署时)业务此值必传：
        /// <ul><li> **E_PRESCRIPTION_AUTO_SIGN**：电子处方单（医疗自动签）  </li><li> **OTHER** :  通用场景</li></ul>
        /// 注: `个人自动签名场景是白名单功能，使用前请与对接的客户经理联系沟通。`
        /// </summary>
        [JsonProperty("AutoSignScene")]
        public string AutoSignScene{ get; set; }

        /// <summary>
        /// 操作者的信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 在短信通知、填写、签署流程中，若标题、按钮、合同详情等地方存在“合同”字样时，可根据此配置指定文案，可选文案如下：  <ul><li> <b>0</b> :合同（默认值）</li> <li> <b>1</b> :文件</li> <li> <b>2</b> :协议</li></ul>效果如下:![FlowDisplayType](https://qcloudimg.tencent-cloud.cn/raw/e4a2c4d638717cc901d3dbd5137c9bbc.png)
        /// </summary>
        [JsonProperty("FlowDisplayType")]
        public long? FlowDisplayType{ get; set; }

        /// <summary>
        /// 是否为预览模式，取值如下： <ul><li> **false**：非预览模式（默认），会产生合同流程并返回合同流程编号FlowId。</li> <li> **true**：预览模式，不产生合同流程，不返回合同流程编号FlowId，而是返回预览链接PreviewUrl，有效期为300秒，用于查看真实发起后合同的样子。</li></ul>
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 预览模式下产生的预览链接类型 
        /// <ul><li> **0** :(默认) 文件流 ,点开后下载预览的合同PDF文件 </li>
        /// <li> **1** :H5链接 ,点开后在浏览器中展示合同的样子</li></ul>
        /// 注: `此参数在NeedPreview 为true时有效`
        /// </summary>
        [JsonProperty("PreviewType")]
        public long? PreviewType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamArrayObj(map, prefix + "FlowApprovers.", this.FlowApprovers);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "CustomShowMap", this.CustomShowMap);
            this.SetParamSimple(map, prefix + "CustomerData", this.CustomerData);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
            this.SetParamSimple(map, prefix + "ApproverVerifyType", this.ApproverVerifyType);
            this.SetParamSimple(map, prefix + "SignBeanTag", this.SignBeanTag);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "CcNotifyType", this.CcNotifyType);
            this.SetParamSimple(map, prefix + "AutoSignScene", this.AutoSignScene);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowDisplayType", this.FlowDisplayType);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
        }
    }
}

