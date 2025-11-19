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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同流程ID，为32位字符串。 
        /// - FlowId 在通过[ChannelCreateFlowByFiles](https://qian.tencent.com/developers/partnerApis/startFlows/ChannelCreateFlowByFiles) 发起，可以在返回参数FlowId中获取。
        /// - 建议开发者妥善保存此流程ID，以便于顺利进行后续操作。 
        /// - 可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同流程的参与方列表, 最多可支持50个参与方，可在列表中指定企业B端签署方和个人C端签署方的联系和认证方式等信息，不同类型的签署方传参方式可以参考文档 [签署方入参指引](https://qian.tencent.com/developers/partner/flow_approver)。 如果合同流程是有序签署，Approvers列表中参与人的顺序就是默认的签署顺序, 请确保列表中参与人的顺序符合实际签署顺序。	
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverInfo[] FlowApprovers{ get; set; }

        /// <summary>
        /// 个人自动签名的使用场景包括以下, 个人自动签署(即ApproverType设置成个人自动签署时)业务此值必传： <ul><li> **E_PRESCRIPTION_AUTO_SIGN**：电子处方单（医疗自动签） </li><li> **OTHER** : 通用场景</li></ul> 注: `个人自动签名场景是白名单功能，使用前请与对接的客户经理联系沟通。`	
        /// </summary>
        [JsonProperty("AutoSignScene")]
        public string AutoSignScene{ get; set; }

        /// <summary>
        /// 签署人校验方式 VerifyCheck: 人脸识别（默认） MobileCheck：手机号验证，用户手机号和参与方手机号（ApproverMobile）相同即可查看合同内容（当手写签名方式为OCR_ESIGN时，该校验方式无效，因为这种签名方式依赖实名认证） 参数说明：可选人脸识别或手机号验证两种方式，若选择后者，未实名个人签署方在签署合同时，无需经过实名认证和意愿确认两次人脸识别，该能力仅适用于个人签署方。	
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamArrayObj(map, prefix + "FlowApprovers.", this.FlowApprovers);
            this.SetParamSimple(map, prefix + "AutoSignScene", this.AutoSignScene);
            this.SetParamSimple(map, prefix + "ApproverVerifyType", this.ApproverVerifyType);
        }
    }
}

