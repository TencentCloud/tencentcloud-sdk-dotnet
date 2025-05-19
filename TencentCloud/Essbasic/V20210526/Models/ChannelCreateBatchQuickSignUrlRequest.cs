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

    public class ChannelCreateBatchQuickSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量签署的流程签署人，其中姓名(ApproverName)、参与人类型(ApproverType)必传，手机号(ApproverMobile)和证件信息(ApproverIdCardType、ApproverIdCardNumber)可任选一种或全部传入。
        /// <ul>
        /// <li>若为个人参与方：ApproverType:"PERSON"</li>
        /// <li>若为企业参与方：ApproverType:"ORGANIZATION"。同时若签署方为saas企业员工， OrganizationName 参数需传入参与方企业名称。若签署方为渠道子客企业员工，除了 OrganizationName 还需要传 OpenId、OrganizationOpenId。（如果OrganizationOpenId对应子客企业已经认证激活，则可以省略OrganizationName参数）</li>
        /// </ul>
        /// 
        /// 注:
        /// `1. 暂不支持签署人拖动签署控件功能，以及签批控件。`
        /// `2. 当需要通过短信验证码签署时，手机号ApproverMobile需要与发起合同时填写的用户手机号一致。`
        /// </summary>
        [JsonProperty("FlowApproverInfo")]
        public FlowApproverInfo FlowApproverInfo{ get; set; }

        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 批量签署的合同流程ID数组。
        /// 注: `在调用此接口时，请确保合同流程均为本企业发起，且合同数量不超过100个。`
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
        /// 签署完之后的H5页面的跳转链接，此链接及支持http://和https://，最大长度1000个字符。(建议https协议)
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 指定批量签署合同的签名类型，可传递以下值：
        /// <ul><li>**0**：手写签名(默认)</li>
        /// <li>**1**：OCR楷体</li>
        /// <li>**2**：姓名印章</li>
        /// <li>**3**：图片印章</li>
        /// <li>**4**：系统签名</li></ul>
        /// 注：
        /// <ul><li>默认情况下，签名类型为手写签名</li>
        /// <li>您可以传递多种值，表示可用多种签名类型。</li>
        /// <li>该参数会覆盖您合同中的签名类型，若您在发起合同时限定了签名类型(赋值签名类型给ComponentTypeLimit)，请将这些签名类型赋予此参数</li>
        /// <li>若签署方为企业员工，此参数无效，签名方式将以合同中为准。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SignatureTypes")]
        public long?[] SignatureTypes{ get; set; }

        /// <summary>
        /// 指定批量签署合同的认证校验方式，可传递以下值：
        /// <ul><li>**1**：人脸认证(默认)，需进行人脸识别成功后才能签署合同</li>
        /// <li>**2**：密码认证(默认)，需输入与用户在腾讯电子签设置的密码一致才能校验成功进行合同签署</li>
        /// <li>**3**：运营商三要素，需到运营商处比对手机号实名信息(名字、手机号、证件号)校验一致才能成功进行合同签署。</li></ul>
        /// 注：
        /// <ul><li>默认情况下，认证校验方式为人脸和密码认证</li>
        /// <li>您可以传递多种值，表示可用多种认证校验方式。</li></ul>
        /// </summary>
        [JsonProperty("ApproverSignTypes")]
        public long?[] ApproverSignTypes{ get; set; }

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
        /// 批量签署合同相关信息，指定合同和签署方的信息，用于补充动态签署人。	
        /// 
        /// 注: `若签署方为企业员工，暂不支持通过H5端进行动态签署人的补充`
        /// </summary>
        [JsonProperty("FlowBatchUrlInfo")]
        public FlowBatchUrlInfo FlowBatchUrlInfo{ get; set; }

        /// <summary>
        /// <b>只有在生成H5签署链接的情形下</b>（ 如调用<a href="https://qian.tencent.com/developers/partnerApis/operateFlows/ChannelCreateFlowSignUrl" target="_blank">获取H5签署链接</a>、<a href="https://qian.tencent.com/developers/partnerApis/operateFlows/ChannelCreateBatchQuickSignUrl" target="_blank">获取H5批量签署链接</a>等接口），该配置才会生效。  您可以指定H5签署视频核身的意图配置，选择问答模式或点头模式的语音文本。  注意： 1. 视频认证为<b>白名单功能，使用前请联系对接的客户经理沟通</b>。 2. 使用视频认证时，<b>生成H5签署链接的时候必须将签署认证方式指定为人脸</b>（即ApproverSignTypes设置成人脸签署）。 3. 签署完成后，可以通过<a href="https://qian.tencent.com/developers/partnerApis/flows/ChannelDescribeSignFaceVideo" target="_blank">查询签署认证人脸视频</a>获取到当时的视频。
        /// </summary>
        [JsonProperty("Intention")]
        public Intention Intention{ get; set; }

        /// <summary>
        /// 缓存签署人信息。在H5签署链接动态领取场景，首次填写后，选择缓存签署人信息，在下次签署人点击领取链接时，会自动将个人信息（姓名、身份证号、手机号）填入，否则需要每次手动填写。
        /// 
        /// 注: `若参与方为企业员工时，暂不支持对参与方信息进行缓存`
        /// </summary>
        [JsonProperty("CacheApproverInfo")]
        public bool? CacheApproverInfo{ get; set; }

        /// <summary>
        /// 是否允许此链接中签署方批量拒签。 <ul><li>false (默认): 不允许批量拒签</li> <li>true : 允许批量拒签。</li></ul>注：`合同组暂不支持批量拒签功能。`
        /// </summary>
        [JsonProperty("CanBatchReject")]
        public bool? CanBatchReject{ get; set; }

        /// <summary>
        /// 预设的动态签署方的补充信息，仅匹配对应信息的签署方才能领取合同。暂时仅对个人参与方生效。
        /// </summary>
        [JsonProperty("PresetApproverInfo")]
        public PresetApproverInfo PresetApproverInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FlowApproverInfo.", this.FlowApproverInfo);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamArraySimple(map, prefix + "SignatureTypes.", this.SignatureTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
            this.SetParamSimple(map, prefix + "SignTypeSelector", this.SignTypeSelector);
            this.SetParamObj(map, prefix + "FlowBatchUrlInfo.", this.FlowBatchUrlInfo);
            this.SetParamObj(map, prefix + "Intention.", this.Intention);
            this.SetParamSimple(map, prefix + "CacheApproverInfo", this.CacheApproverInfo);
            this.SetParamSimple(map, prefix + "CanBatchReject", this.CanBatchReject);
            this.SetParamObj(map, prefix + "PresetApproverInfo.", this.PresetApproverInfo);
        }
    }
}

