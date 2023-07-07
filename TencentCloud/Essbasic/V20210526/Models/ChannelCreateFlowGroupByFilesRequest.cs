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

    public class ChannelCreateFlowGroupByFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每个子合同的发起所需的信息，数量限制2-100
        /// </summary>
        [JsonProperty("FlowFileInfos")]
        public FlowFileInfo[] FlowFileInfos{ get; set; }

        /// <summary>
        /// 合同组名称，长度不超过200个字符
        /// </summary>
        [JsonProperty("FlowGroupName")]
        public string FlowGroupName{ get; set; }

        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 签署人校验方式
        /// VerifyCheck: 人脸识别（默认）
        /// MobileCheck：手机号验证
        /// 参数说明：若选择后者，未实名的个人签署方查看合同时，无需进行人脸识别实名认证（但签署合同时仍然需要人脸实名），该能力仅适用于个人签署方。
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }

        /// <summary>
        /// 操作者的信息，此参数不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FlowFileInfos.", this.FlowFileInfos);
            this.SetParamSimple(map, prefix + "FlowGroupName", this.FlowGroupName);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ApproverVerifyType", this.ApproverVerifyType);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

