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

    public class ApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 在指定签署方时，可选择企业B端或个人C端等不同的参与者类型，可选类型如下:
        /// **0**：企业
        /// **1**：个人
        /// **3**：企业静默签署
        /// 注：`类型为3（企业静默签署）时，此接口会默认完成该签署方的签署。静默签署仅进行盖章操作，不能自动签名。`
        /// **7**: 个人自动签署，适用于个人自动签场景。
        /// 注: `个人自动签场景为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("ApproverType")]
        public long? ApproverType{ get; set; }

        /// <summary>
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 本企业的签署方经办人的员工UserId
        /// 可登录腾讯电子签控制台，在 "更多能力"->"组织管理" 中查看某位员工的UserId(在页面中展示为用户ID)。
        /// 
        /// 注: `若传该字段，则签署方经办人的其他信息（如签署方经办人的姓名、证件号码、手机号码等）将被忽略。`
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// 组织机构名称。
        /// 如果签署方是企业签署方(approverType = 1 或者 approverType = 3)， 则企业名称必填。
        /// 
        /// 注: `请确认该名称与企业营业执照中注册的名称一致 ; 如果名称中包含英文括号()，请使用中文括号（）代替。`
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 合同中的签署控件列表，列表中可支持下列多种签署控件,控件的详细定义参考开发者中心的Component结构体
        /// <ul><li> 个人签名/印章</li>
        /// <li> 企业印章</li>
        /// <li> 骑缝章等签署控件</li></ul>
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 签署方经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD 居民身份证  (默认值)</li>
        /// <li>HONGKONG_AND_MACAO 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证(格式同居民身份证)</li>
        /// <li>OTHER_CARD_TYPE 其他证件</li></ul>
        /// 
        /// 注: `其他证件类型为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("ApproverIdCardType")]
        public string ApproverIdCardType{ get; set; }

        /// <summary>
        /// 签署方经办人的证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>港澳居民来往内地通行证号码应为9位字符串，第1位为“C”，第2位为英文字母（但“I”、“O”除外），后7位为阿拉伯数字。</li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("ApproverIdCardNumber")]
        public string ApproverIdCardNumber{ get; set; }

        /// <summary>
        /// 通知签署方经办人的方式,  有以下途径:
        /// <ul><li>  **sms**  :  (默认)短信</li>
        /// <li>   **none**   : 不通知</li></ul>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 收据场景设置签署人角色类型, 可以设置如下****类型****:
        /// <ul><li> **1**  :收款人</li>
        /// <li>   **2**   :开具人</li>
        /// <li>   **3** :见证人</li></ul>
        /// 注: `收据场景为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("ApproverRole")]
        public long? ApproverRole{ get; set; }

        /// <summary>
        /// 签署意愿确认渠道，默认为WEIXINAPP:人脸识别
        /// 
        /// 注: 将要废弃, 用ApproverSignTypes签署人签署合同时的认证方式代替, 新客户可请用ApproverSignTypes来设置
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string[] VerifyChannel{ get; set; }

        /// <summary>
        /// 签署方在签署合同之前，需要强制阅读合同的时长，可指定为3秒至300秒之间的任意值。
        /// 
        /// 若未指定阅读时间，则会按照合同页数大小计算阅读时间，计算规则如下：
        /// <ul><li>合同页数少于等于2页，阅读时间为3秒；</li>
        /// <li>合同页数为3到5页，阅读时间为5秒；</li>
        /// <li>合同页数大于等于6页，阅读时间为10秒。</li></ul>
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 签署人userId，仅支持本企业的员工userid， 可在控制台组织管理处获得
        /// 
        /// 注: `若传此字段 则以userid的信息为主，会覆盖传递过来的签署人基本信息， 包括姓名，手机号，证件类型等信息`
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

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
        /// 可以控制签署方在签署合同时能否进行某些操作，例如拒签、转交他人等。
        /// 详细操作可以参考开发者中心的ApproverOption结构体。
        /// </summary>
        [JsonProperty("ApproverOption")]
        public ApproverOption ApproverOption{ get; set; }

        /// <summary>
        /// 指定个人签署方查看合同的校验方式,可以传值如下:
        /// <ul><li>  **1**   : （默认）人脸识别,人脸识别后才能合同内容</li>
        /// <li>  **2**  : 手机号验证, 用户手机号和参与方手机号(ApproverMobile)相同即可查看合同内容</li></ul>
        /// 注: 
        /// <ul><li>如果合同流程设置ApproverVerifyType查看合同的校验方式,    则忽略此签署人的查看合同的校验方式</li>
        /// <li>此字段不可传多个校验方式</li></ul>
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
        /// </summary>
        [JsonProperty("ApproverSignTypes")]
        public long?[] ApproverSignTypes{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamSimple(map, prefix + "ApproverIdCardType", this.ApproverIdCardType);
            this.SetParamSimple(map, prefix + "ApproverIdCardNumber", this.ApproverIdCardNumber);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "ApproverRole", this.ApproverRole);
            this.SetParamArraySimple(map, prefix + "VerifyChannel.", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "ApproverSource", this.ApproverSource);
            this.SetParamSimple(map, prefix + "CustomApproverTag", this.CustomApproverTag);
            this.SetParamObj(map, prefix + "ApproverOption.", this.ApproverOption);
            this.SetParamArraySimple(map, prefix + "ApproverVerifyTypes.", this.ApproverVerifyTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
            this.SetParamSimple(map, prefix + "ApproverNeedSignReview", this.ApproverNeedSignReview);
        }
    }
}

