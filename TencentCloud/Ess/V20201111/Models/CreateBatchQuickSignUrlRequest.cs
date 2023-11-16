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

    public class CreateBatchQuickSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量签署的合同流程ID数组。
        /// 注: `在调用此接口时，请确保合同流程均为本企业发起，且合同数量不超过100个。`
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 批量签署的流程签署人，其中姓名(ApproverName)、参与人类型(ApproverType)必传，手机号(ApproverMobile)和证件信息(ApproverIdCardType、ApproverIdCardNumber)可任选一种或全部传入。
        /// 注:
        /// `1. ApproverType目前只支持个人类型的签署人。`
        /// `2. 签署人只能有手写签名和时间类型的签署控件，其他类型的填写控件和签署控件暂时都未支持。`
        /// `3. 当需要通过短信验证码签署时，手机号ApproverMobile需要与发起合同时填写的用户手机号一致。`
        /// </summary>
        [JsonProperty("FlowApproverInfo")]
        public FlowCreateApprover FlowApproverInfo{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId(子企业的组织ID)为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 签署完之后的H5页面的跳转链接，此链接及支持http://和https://，最大长度1000个字符。(建议https协议)
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 指定批量签署合同的签名类型，可传递以下值：
        /// <ul><li>**0**：手写签名(默认)</li>
        /// <li>**1**：OCR楷体</li></ul>
        /// 注：
        /// <ul><li>默认情况下，签名类型为手写签名</li>
        /// <li>您可以传递多种值，表示可用多种签名类型。</li></ul>
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamObj(map, prefix + "FlowApproverInfo.", this.FlowApproverInfo);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamArraySimple(map, prefix + "SignatureTypes.", this.SignatureTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
        }
    }
}

