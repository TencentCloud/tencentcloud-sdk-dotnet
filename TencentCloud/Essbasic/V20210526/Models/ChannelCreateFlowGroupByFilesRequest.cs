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

    public class ChannelCreateFlowGroupByFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 合同组中每个合同签署流程的信息，合同组中最少包含2个合同，不能超过50个合同。
        /// </summary>
        [JsonProperty("FlowFileInfos")]
        public FlowFileInfo[] FlowFileInfos{ get; set; }

        /// <summary>
        /// 合同组的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowGroupName")]
        public string FlowGroupName{ get; set; }

        /// <summary>
        /// 合同的发起企业和发起人信息，<a href="https://qcloudimg.tencent-cloud.cn/raw/b69f8aad306c40b7b78d096e39b2edbb.png" target="_blank">点击查看合同发起企业和人展示的位置</a>
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识: <a href="https://qcloudimg.tencent-cloud.cn/raw/a71872de3d540d55451e3e73a2ad1a6e.png" target="_blank">Agent.AppId</a></li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId（合同的发起企业）</li>
        /// <li>第三方平台子客企业中的员工标识: Agent.ProxyOperator.OpenId （合同的发起人）</li>
        /// </ul>
        /// 
        /// 合同的发起企业和发起人必需已经完成实名，并加入企业
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同组中签署人校验和认证的方式：
        /// <ul><li>**VerifyCheck**：人脸识别（默认）</li>
        /// <li>**MobileCheck**：手机号验证</li></ul>
        /// 注意：
        /// `1. MobileCheck 方式，未实名的个人/自然人签署方无需进行人脸识别实名认证即可查看合同（但签署合同时仍然需要人脸实名），企业签署方需经过人脸认证。`
        /// `2. 合同组的校验和认证的方式会优先使用，会覆盖合同组中单个合同和合同签署方认证方式的限制配置。`
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }

        /// <summary>
        /// 合同组的签署配置项信息，例如在合同组签署过程中，是否需要对每个子合同进行独立的意愿确认。
        /// </summary>
        [JsonProperty("FlowGroupOptions")]
        public FlowGroupOptions FlowGroupOptions{ get; set; }

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
            this.SetParamObj(map, prefix + "FlowGroupOptions.", this.FlowGroupOptions);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

