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

    public class CreateMultiFlowSignQRCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 签署流程名称，最大长度不超过200字符
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 应用信息
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 回调地址,最大长度1000字符串
        /// 回调时机：
        /// 用户通过签署二维码发起签署流程时，企业额度不足导致失败
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 最大可发起签署流程份数，默认5份 
        /// 发起流程数量超过此上限后二维码自动失效
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "MaxFlowNum", this.MaxFlowNum);
            this.SetParamSimple(map, prefix + "FlowEffectiveDay", this.FlowEffectiveDay);
            this.SetParamSimple(map, prefix + "QrEffectiveDay", this.QrEffectiveDay);
        }
    }
}

