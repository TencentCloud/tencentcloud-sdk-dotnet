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

    public class ChannelCreateMultiFlowSignQRCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。
        /// 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 签署流程名称，最大长度200个字符。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 最大可发起签署流程份数，默认5份；发起签署流程数量超过此上限后，二维码自动失效。
        /// </summary>
        [JsonProperty("MaxFlowNum")]
        public long? MaxFlowNum{ get; set; }

        /// <summary>
        /// 签署流程有效天数 默认7天 最高设置不超过30天
        /// </summary>
        [JsonProperty("FlowEffectiveDay")]
        public long? FlowEffectiveDay{ get; set; }

        /// <summary>
        /// 二维码有效天数 默认7天 最高设置不超过90天
        /// </summary>
        [JsonProperty("QrEffectiveDay")]
        public long? QrEffectiveDay{ get; set; }

        /// <summary>
        /// 限制二维码用户条件
        /// </summary>
        [JsonProperty("Restrictions")]
        public ApproverRestriction[] Restrictions{ get; set; }

        /// <summary>
        /// 回调地址，最大长度1000个字符
        /// 不传默认使用第三方应用号配置的回调地址
        /// 回调时机:用户通过签署二维码发起合同时，企业额度不足导致失败
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 限制二维码用户条件（已弃用）
        /// </summary>
        [JsonProperty("ApproverRestrictions")]
        [System.Obsolete]
        public ApproverRestriction ApproverRestrictions{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "MaxFlowNum", this.MaxFlowNum);
            this.SetParamSimple(map, prefix + "FlowEffectiveDay", this.FlowEffectiveDay);
            this.SetParamSimple(map, prefix + "QrEffectiveDay", this.QrEffectiveDay);
            this.SetParamArrayObj(map, prefix + "Restrictions.", this.Restrictions);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "ApproverRestrictions.", this.ApproverRestrictions);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

