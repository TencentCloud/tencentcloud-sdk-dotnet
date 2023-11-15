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

    public class FlowApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署方经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证  (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li>
        /// <li>OTHER_CARD_TYPE : 其他证件</li></ul>
        /// 
        /// 注: `其他证件类型为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 签署方经办人的证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>港澳居民来往内地通行证号码应为9位字符串，第1位为“C”，第2位为英文字母（但“I”、“O”除外），后7位为阿拉伯数字。</li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 签署方经办人手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)， 不支持海外手机号。
        /// 请确认手机号所有方为此合同签署方。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 组织机构名称。
        /// 请确认该名称与企业营业执照中注册的名称一致。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 指定签署人非第三方平台子客企业下员工还是SaaS平台企业，在ApproverType为ORGANIZATION时指定。
        /// <ul>
        /// <li>false: 默认值，第三方平台子客企业下员工</li>
        /// <li>true: SaaS平台企业下的员工</li>
        /// </ul>
        /// </summary>
        [JsonProperty("NotChannelOrganization")]
        public bool? NotChannelOrganization{ get; set; }

        /// <summary>
        /// 第三方平台子客企业员工的唯一标识，长度不能超过64，只能由字母和数字组成
        /// 
        /// 当签署方为同一第三方平台下的员工时，该字段若不指定，则发起【待领取】的流程
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 同应用下第三方平台子客企业的唯一标识，定义Agent中的ProxyOrganizationOpenId一样，签署方为非发起方企业场景下必传，最大长度64个字符
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 在指定签署方时，可选择企业B端或个人C端等不同的参与者类型，可选类型如下:
        /// <ul><li> **PERSON** :个人/自然人</li>
        /// <li> **PERSON_AUTO_SIGN** :个人/自然人自动签署，适用于个人自动签场景</li>
        /// <li> **ORGANIZATION** :企业/企业员工（企业签署方或模板发起时的企业静默签）</li>
        /// <li> **ENTERPRISESERVER** :企业/企业员工自动签（他方企业自动签署或文件发起时的本方企业自动签）</li></ul>
        /// 
        /// 注:  
        /// `1. 个人自动签场景(PERSON_AUTO_SIGN)为白名单功能, 使用前请联系对接的客户经理沟通。`
        /// `2. 若要实现他方企业（同一应用下）自动签，需要满足3个条件：`
        /// <ul><li>条件1：ApproverType 设置为ENTERPRISESERVER</li>
        /// <li>条件2：子客之间完成授权</li>
        /// <li>条件3：联系对接的客户经理沟通如何使用</li></ul>
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 签署流程签署人在模板中对应的签署人Id；在非单方签署、以及非B2C签署的场景下必传，用于指定当前签署方在签署流程中的位置；
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 本签署人在此合同流程的签署截止时间，格式为Unix标准时间戳（秒），如果未设置签署截止时间，则默认为合同流程创建后的365天时截止。
        /// 如果在签署截止时间前未完成签署，则合同状态会变为已过期，导致合同作废。
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署完回调url，最大长度1000个字符
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 使用PDF文件直接发起合同时，签署人指定的签署控件；<br/>使用模板发起合同时，指定本企业印章签署控件的印章ID: <br/>通过ComponentId或ComponenetName指定签署控件，ComponentValue为印章ID。
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 签署方控件类型为 SIGN_SIGNATURE时，可以指定签署方签名方式
        /// 	HANDWRITE – 手写签名
        /// 	OCR_ESIGN -- AI智能识别手写签名
        /// 	ESIGN -- 个人印章类型
        /// 	SYSTEM_ESIGN -- 系统签名（该类型可以在用户签署时根据用户姓名一键生成一个签名来进行签署）
        /// </summary>
        [JsonProperty("ComponentLimitType")]
        public string[] ComponentLimitType{ get; set; }

        /// <summary>
        /// 签署方在签署合同之前，需要强制阅读合同的时长，可指定为3秒至300秒之间的任意值。
        /// 
        /// 若未指定阅读时间，则会按照合同页数大小计算阅读时间，计算规则如下：
        /// <ul>
        /// <li>合同页数少于等于2页，阅读时间为3秒；</li>
        /// <li>合同页数为3到5页，阅读时间为5秒；</li>
        /// <li>合同页数大于等于6页，阅读时间为10秒。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 签署完前端跳转的url，此字段的用法场景请联系客户经理确认
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 可以控制签署方在签署合同时能否进行某些操作，例如拒签、转交他人等。
        /// 详细操作可以参考开发者中心的ApproverOption结构体。
        /// </summary>
        [JsonProperty("ApproverOption")]
        public ApproverOption ApproverOption{ get; set; }

        /// <summary>
        /// 当前签署方进行签署操作是否需要企业内部审批，true 则为需要
        /// </summary>
        [JsonProperty("ApproverNeedSignReview")]
        public bool? ApproverNeedSignReview{ get; set; }

        /// <summary>
        /// 指定个人签署方查看合同的校验方式,可以传值如下:
        /// <ul><li>  **1**   : （默认）人脸识别,人脸识别后才能合同内容</li>
        /// <li>  **2**  : 手机号验证, 用户手机号和参与方手机号(ApproverMobile)相同即可查看合同内容（当手写签名方式为OCR_ESIGN时，该校验方式无效，因为这种签名方式依赖实名认证）
        /// </li></ul>
        /// 注: 
        /// <ul><li>如果合同流程设置ApproverVerifyType查看合同的校验方式,    则忽略此签署人的查看合同的校验方式</li>
        /// <li>此字段可传多个校验方式</li></ul>
        /// </summary>
        [JsonProperty("ApproverVerifyTypes")]
        public long?[] ApproverVerifyTypes{ get; set; }

        /// <summary>
        /// 签署人签署合同时的认证方式
        /// <ul><li> **1** :人脸认证</li>
        /// <li> **2** :签署密码</li>
        /// <li> **3** :运营商三要素</li></ul>
        /// 
        /// 默认为1(人脸认证 ),2(签署密码)
        /// 
        /// 注: `用模版创建合同场景, 签署人的认证方式需要在配置模板的时候指定, 在此创建合同指定无效`
        /// </summary>
        [JsonProperty("ApproverSignTypes")]
        public long?[] ApproverSignTypes{ get; set; }

        /// <summary>
        /// 签署ID
        /// - 发起流程时系统自动补充
        /// - 创建签署链接时，可以通过查询详情接口获得签署人的SignId，然后可传入此值为该签署人创建签署链接，无需再传姓名、手机号、证件号等其他信息
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 通知签署方经办人的方式, 有以下途径:
        /// <ul><li> **SMS** :(默认)短信</li>
        /// <li> **NONE** : 不通知</li></ul>
        /// 
        /// 注: `签署方为第三方子客企业时会被置为NONE,   不会发短信通知`
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// [通过文件创建签署流程](https://qian.tencent.com/developers/partnerApis/startFlows/ChannelCreateFlowByFiles)时,如果设置了外层参数SignBeanTag=1(允许签署过程中添加签署控件),则可通过此参数明确规定合同所使用的签署控件类型（骑缝章、普通章法人章等）和具体的印章（印章ID）或签名方式。
        /// 
        /// 注：`限制印章控件或骑缝章控件情况下,仅本企业签署方可以指定具体印章（通过传递ComponentValue,支持多个），他方企业或个人只支持限制控件类型。`
        /// </summary>
        [JsonProperty("AddSignComponentsLimits")]
        public ComponentLimit[] AddSignComponentsLimits{ get; set; }

        /// <summary>
        /// 可以自定义签署人角色名：收款人、开具人、见证人等，长度不能超过20，只能由中文、字母、数字和下划线组成。
        /// 
        /// 注: `如果是用模板发起, 优先使用此处上传的, 如果不传则用模板的配置的`
        /// </summary>
        [JsonProperty("ApproverRoleName")]
        public string ApproverRoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "NotChannelOrganization", this.NotChannelOrganization);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamArraySimple(map, prefix + "ComponentLimitType.", this.ComponentLimitType);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "ApproverOption.", this.ApproverOption);
            this.SetParamSimple(map, prefix + "ApproverNeedSignReview", this.ApproverNeedSignReview);
            this.SetParamArraySimple(map, prefix + "ApproverVerifyTypes.", this.ApproverVerifyTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamArrayObj(map, prefix + "AddSignComponentsLimits.", this.AddSignComponentsLimits);
            this.SetParamSimple(map, prefix + "ApproverRoleName", this.ApproverRoleName);
        }
    }
}

