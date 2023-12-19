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

    public class FlowCreateApprover : AbstractModel
    {
        
        /// <summary>
        /// 在指定签署方时，可选择企业B端或个人C端等不同的参与者类型，可选类型如下:
        /// 0：企业
        /// 1：个人
        /// 3：企业静默签署
        /// 注：类型为3（企业静默签署）时，此接口会默认完成该签署方的签署。静默签署仅进行盖章操作，不能自动签名。
        /// 7: 个人自动签署，适用于个人自动签场景。
        /// 注: 个人自动签场景为白名单功能，使用前请联系对接的客户经理沟通。
        /// </summary>
        [JsonProperty("ApproverType")]
        public long? ApproverType{ get; set; }

        /// <summary>
        /// 组织机构名称。
        /// 请确认该名称与企业营业执照中注册的名称一致。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// 
        /// 注: `当approverType=0(企业签署方) 或 approverType=3(企业静默签署)时，必须指定`
        /// 
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// 
        /// 在未指定签署人电子签UserId情况下，为必填参数
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 签署方经办人手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)。
        /// 请确认手机号所有方为此合同签署方。
        /// 
        /// 在未指定签署人电子签UserId情况下，为必填参数
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// 证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证 (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("ApproverIdCardType")]
        public string ApproverIdCardType{ get; set; }

        /// <summary>
        /// 证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>港澳居民来往内地通行证号码应为9位字符串，第1位为“C”，第2位为英文字母（但“I”、“O”除外），后7位为阿拉伯数字。</li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("ApproverIdCardNumber")]
        public string ApproverIdCardNumber{ get; set; }

        /// <summary>
        /// 签署方经办人在模板中配置的参与方ID，与控件绑定，是控件的归属方，ID为32位字符串。
        /// 模板发起合同时，该参数为必填项。
        /// 文件发起合同时，该参数无需传值。
        /// 如果开发者后续用合同模板发起合同，建议保存此值，在用合同模板发起合同中需此值绑定对应的签署经办人 。
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 签署意愿确认渠道，默认为WEIXINAPP:人脸识别
        /// 
        /// 注: 将要废弃, 用ApproverSignTypes签署人签署合同时的认证方式代替, 新客户可请用ApproverSignTypes来设置
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string[] VerifyChannel{ get; set; }

        /// <summary>
        /// 通知签署方经办人的方式,  有以下途径:
        /// <ul><li>  **sms**  :  (默认)短信</li>
        /// <li>   **none**   : 不通知</li></ul>
        /// 
        /// 注: `发起方也是签署方时不给此签署方发送短信`
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 合同强制需要阅读全文，无需传此参数
        /// </summary>
        [JsonProperty("IsFullText")]
        public bool? IsFullText{ get; set; }

        /// <summary>
        /// 合同的强制预览时间：3~300s，未指定则按合同页数计算
        /// </summary>
        [JsonProperty("PreReadTime")]
        public ulong? PreReadTime{ get; set; }

        /// <summary>
        /// 签署人userId，仅支持本企业的员工userid， 可在控制台组织管理处获得
        /// 
        /// 注: `若传此字段 则以userid的信息为主，会覆盖传递过来的签署人基本信息， 包括姓名，手机号，证件类型等信息`
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 字段已经废弃，当前只支持true，默认为true
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// 在企微场景下使用，需设置参数为**WEWORKAPP**，以表明合同来源于企微。
        /// </summary>
        [JsonProperty("ApproverSource")]
        public string ApproverSource{ get; set; }

        /// <summary>
        /// 在企业微信场景下，表明该合同流程为或签，其最大长度为64位字符串。
        /// 所有参与或签的人员均需具备该标识。
        /// 注意，在合同中，不同的或签参与人必须保证其CustomApproverTag唯一。
        /// 如果或签签署人为本方企业微信参与人，则需要指定ApproverSource参数为WEWORKAPP。
        /// </summary>
        [JsonProperty("CustomApproverTag")]
        public string CustomApproverTag{ get; set; }

        /// <summary>
        /// 已经废弃, 快速注册相关信息
        /// </summary>
        [JsonProperty("RegisterInfo")]
        public RegisterInfo RegisterInfo{ get; set; }

        /// <summary>
        /// 签署人个性化能力值，如是否可以转发他人处理、是否可以拒签、是否为动态补充签署人等功能开关。
        /// </summary>
        [JsonProperty("ApproverOption")]
        public ApproverOption ApproverOption{ get; set; }

        /// <summary>
        /// 签署完前端跳转的url，暂未使用
        /// </summary>
        [JsonProperty("JumpUrl")]
        [System.Obsolete]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 签署ID
        /// - 发起流程时系统自动补充
        /// - 创建签署链接时，可以通过查询详情接口获得签署人的SignId，然后可传入此值为该签署人创建签署链接，无需再传姓名、手机号、证件号等其他信息
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 发起方企业的签署人进行签署操作前，是否需要企业内部走审批流程，取值如下：
        /// <ul><li>**false**：（默认）不需要审批，直接签署。</li>
        /// <li>**true**：需要走审批流程。当到对应参与人签署时，会阻塞其签署操作，等待企业内部审批完成。</li></ul>
        /// 企业可以通过CreateFlowSignReview审批接口通知腾讯电子签平台企业内部审批结果
        /// <ul><li>如果企业通知腾讯电子签平台审核通过，签署方可继续签署动作。</li>
        /// <li>如果企业通知腾讯电子签平台审核未通过，平台将继续阻塞签署方的签署动作，直到企业通知平台审核通过。</li></ul>
        /// 
        /// 注：`此功能可用于与企业内部的审批流程进行关联，支持手动、静默签署合同`
        /// </summary>
        [JsonProperty("ApproverNeedSignReview")]
        public bool? ApproverNeedSignReview{ get; set; }

        /// <summary>
        /// 签署人签署控件， 此参数仅针对文件发起（CreateFlowByFiles）生效
        /// 
        /// 合同中的签署控件列表，列表中可支持下列多种签署控件,控件的详细定义参考开发者中心的Component结构体
        /// <ul><li> 个人签名/印章</li>
        /// <li> 企业印章</li>
        /// <li> 骑缝章等签署控件</li></ul>
        /// 
        /// `此参数仅针对文件发起设置生效,模板发起合同签署流程, 请以模板配置为主`
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 签署人填写控件 此参数仅针对文件发起（CreateFlowByFiles）生效
        /// 
        /// 合同中的填写控件列表，列表中可支持下列多种填写控件，控件的详细定义参考开发者中心的Component结构体
        /// <ul><li>单行文本控件</li>
        /// <li>多行文本控件</li>
        /// <li>勾选框控件</li>
        /// <li>数字控件</li>
        /// <li>图片控件</li>
        /// <li>动态表格等填写控件</li></ul>
        /// 
        /// `此参数仅针对文件发起设置生效,模板发起合同签署流程, 请以模板配置为主`
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

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
        /// 指定个人签署方查看合同的校验方式,可以传值如下:
        /// <ul><li>  **1**   : （默认）人脸识别,人脸识别后才能合同内容</li>
        /// <li>  **2**  : 手机号验证, 用户手机号和参与方手机号(ApproverMobile)相同即可查看合同内容（当手写签名方式为OCR_ESIGN时，该校验方式无效，因为这种签名方式依赖实名认证）
        /// </li></ul>
        /// 注: 
        /// <ul><li>如果合同流程设置ApproverVerifyType查看合同的校验方式,    则忽略此签署人的查看合同的校验方式</li>
        /// <li>此字段可传多个校验方式</li></ul>
        /// 
        /// `此参数仅针对文件发起设置生效,模板发起合同签署流程, 请以模板配置为主`
        /// 
        /// .
        /// </summary>
        [JsonProperty("ApproverVerifyTypes")]
        public long?[] ApproverVerifyTypes{ get; set; }

        /// <summary>
        /// 您可以指定签署方签署合同的认证校验方式，可传递以下值：
        /// <ul><li>**1**：人脸认证，需进行人脸识别成功后才能签署合同；</li>
        /// <li>**2**：签署密码，需输入与用户在腾讯电子签设置的密码一致才能校验成功进行合同签署；</li>
        /// <li>**3**：运营商三要素，需到运营商处比对手机号实名信息（名字、手机号、证件号）校验一致才能成功进行合同签署。</li></ul>
        /// 注：
        /// <ul><li>默认情况下，认证校验方式为人脸认证和签署密码两种形式；</li>
        /// <li>您可以传递多种值，表示可用多种认证校验方式。</li></ul>
        /// 
        /// 注:
        /// `此参数仅针对文件发起设置生效,模板发起合同签署流程, 请以模板配置为主`
        /// </summary>
        [JsonProperty("ApproverSignTypes")]
        public ulong?[] ApproverSignTypes{ get; set; }

        /// <summary>
        /// 生成H5签署链接时，您可以指定签署方签署合同的认证校验方式的选择模式，可传递一下值：
        /// <ul><li>**0**：签署方自行选择，签署方可以从预先指定的认证方式中自由选择；</li>
        /// <li>**1**：自动按顺序首位推荐，签署方无需选择，系统会优先推荐使用第一种认证方式。</li></ul>
        /// 注：
        /// `不指定该值时，默认为签署方自行选择。`
        /// </summary>
        [JsonProperty("SignTypeSelector")]
        public ulong? SignTypeSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "ApproverIdCardType", this.ApproverIdCardType);
            this.SetParamSimple(map, prefix + "ApproverIdCardNumber", this.ApproverIdCardNumber);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamArraySimple(map, prefix + "VerifyChannel.", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "IsFullText", this.IsFullText);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "ApproverSource", this.ApproverSource);
            this.SetParamSimple(map, prefix + "CustomApproverTag", this.CustomApproverTag);
            this.SetParamObj(map, prefix + "RegisterInfo.", this.RegisterInfo);
            this.SetParamObj(map, prefix + "ApproverOption.", this.ApproverOption);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "ApproverNeedSignReview", this.ApproverNeedSignReview);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamArraySimple(map, prefix + "ComponentLimitType.", this.ComponentLimitType);
            this.SetParamArraySimple(map, prefix + "ApproverVerifyTypes.", this.ApproverVerifyTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
            this.SetParamSimple(map, prefix + "SignTypeSelector", this.SignTypeSelector);
        }
    }
}

