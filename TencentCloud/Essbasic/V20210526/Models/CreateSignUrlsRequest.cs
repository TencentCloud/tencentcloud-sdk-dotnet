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

    public class CreateSignUrlsRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent.ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程ID数组，最多支持100个。
        /// 
        /// 注: 
        /// 1. 必须选择提供此参数或合同组编号中的一个。
        /// 2. 当生成类型（GenerateType）设为“ALL”时，不可提供多个流程ID。
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 合同组编号
        /// 注：`该参数和合同流程ID数组必须二选一`
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 签署链接类型,可以设置的参数如下
        /// <ul><li> **WEIXINAPP** :(默认)跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型 ，此时返回短链</li>
        /// <li> **CHANNEL** :带有H5引导页的跳转电子签小程序的链接</li>
        /// <li> **APP** :第三方App或小程序跳转电子签小程序的path, App或者小程序跳转适合此类型</li>
        /// <li> **LONGURL2WEIXINAPP** :跳转电子签小程序的链接, H5跳转适合此类型，此时返回长链</li></ul>
        /// 
        /// **注：**动态签署人场景，如果签署链接类型设置为`APP`，则仅支持跳转到封面页。
        /// 
        /// 详细使用场景可以参考接口描述说明中的 **主要使用场景EndPoint分类**
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 签署链接生成类型，可以选择的类型如下
        /// 
        /// <ul><li><strong>ALL</strong>：（默认）为所有签署方生成签署链接，但不包括自动签署（静默签署）的签署方。注意：<strong>此中类型不支持多个合同ID（FlowIds）</strong>。</li>
        /// <li><strong>CHANNEL</strong>：适用于第三方子企业的员工签署方。</li>
        /// <li><strong>NOT_CHANNEL</strong>：适用于SaaS平台企业的员工签署方。</li>
        /// <li><strong>PERSON</strong>：适用于个人或自然人签署方。</li>
        /// <li><strong>FOLLOWER</strong>：适用于关注方，目前指合同的抄送方。</li>
        /// <li><strong>RECIPIENT</strong>：根据RecipientId生成对应的签署链接，适用于动态添加签署人的情况。</li></ul>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// SaaS平台企业员工签署方的企业名称如果名称中包含英文括号()，请使用中文括号（）代替。  注:  `1.GenerateType为"NOT_CHANNEL"时必填` `2.获取B端动态签署人领取链接时,可指定此字段来预先设定签署人的企业,预设后只能以该企业身份去领取合同并完成签署`
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 合同流程里边参与方的姓名。
        /// 注: `GenerateType为"PERSON"(即个人签署方)时必填`
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 合同流程里边签署方经办人手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)。
        /// 注:  `GenerateType为"PERSON"或"FOLLOWER"时必填`
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 证件类型，支持以下类型
        /// <ul><li>ID_CARD : 居民身份证</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 证件号码，应符合以下规则
        /// <ul><li>居民身份证号码应为18位字符串，由数字和大写字母X组成(如存在X，请大写)。</li>
        /// <li>港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给香港居民，“M”字头签发给澳门居民；第2位至第11位为数字。</li>
        /// <li>港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的企业的标识, 即OrganizationOpenId。 注:  `1.GenerateType为"CHANNEL"时必填` `2.获取B端动态签署人领取链接时,可指定此字段来预先设定签署人的平台子客企业,预设后只能以该平台子客企业身份去领取合同并完成签署`
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业员工的标识OpenId，GenerateType为"CHANNEL"时可用，指定到具体参与人, 仅展示已经实名的经办人信息
        /// 
        /// 注： 
        /// 如果传进来的<font color="red">OpenId已经实名并且加入企业， 则忽略Name，IdCardType，IdCardNumber，Mobile这四个入参</font>（会用此OpenId实名的身份证和登录的手机号覆盖）
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 签署完成后是否自动回跳
        /// <ul><li>false：否, 签署完成不会自动跳转回来(默认)</li><li>true：是, 签署完成会自动跳转回来</li></ul>
        /// 
        /// 注: 
        /// 1. 该参数<font color="red">只针对APP类型（电子签小程序跳转贵方小程序）场景</font> 的签署链接有效
        /// 2. <font color="red">手机应用APP 或 微信小程序需要监控界面的返回走后序逻辑</font>, 微信小程序的文档可以参考[这个](https://developers.weixin.qq.com/miniprogram/dev/reference/api/App.html#onShow-Object-object)
        /// 3. <font color="red">电子签小程序跳转贵方APP，不支持自动跳转，必需用户手动点击完成按钮（微信的限制）</font> 
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }

        /// <summary>
        /// 签署完之后的H5页面的跳转链接，针对Endpoint为CHANNEL时有效，最大长度1000个字符。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 生成的签署链接在签署页面隐藏的按钮列表，可设置如下：
        /// 
        /// <ul><li> **0** :合同签署页面更多操作按钮</li>
        /// <li> **1** :合同签署页面更多操作的拒绝签署按钮</li>
        /// <li> **2** :合同签署页面更多操作的转他人处理按钮</li>
        /// <li> **3** :签署成功页的查看详情按钮</li></ul>
        /// 
        /// 注:  `字段为数组, 可以传值隐藏多个按钮`
        /// </summary>
        [JsonProperty("Hides")]
        public long?[] Hides{ get; set; }

        /// <summary>
        /// 参与方角色ID，用于生成动态签署人链接完成领取。
        /// 
        /// 注：`使用此参数需要与flow_ids数量一致并且一一对应, 表示在对应同序号的流程中的参与角色ID`，
        /// </summary>
        [JsonProperty("RecipientIds")]
        public string[] RecipientIds{ get; set; }

        /// <summary>
        /// 合同组相关信息，指定合同组子合同和签署方的信息，用于补充动态签署人。
        /// </summary>
        [JsonProperty("FlowGroupUrlInfo")]
        public FlowGroupUrlInfo FlowGroupUrlInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "Hides.", this.Hides);
            this.SetParamArraySimple(map, prefix + "RecipientIds.", this.RecipientIds);
            this.SetParamObj(map, prefix + "FlowGroupUrlInfo.", this.FlowGroupUrlInfo);
        }
    }
}

