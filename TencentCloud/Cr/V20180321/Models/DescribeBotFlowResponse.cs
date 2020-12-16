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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBotFlowResponse : AbstractModel
    {
        
        /// <summary>
        /// 机器人对话流列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotFlowList")]
        public BotFlow[] BotFlowList{ get; set; }

        /// <summary>
        /// 短信签名列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsSignList")]
        public SmsSign[] SmsSignList{ get; set; }

        /// <summary>
        /// 短信模板列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsTemplateList")]
        public SmsTemplate[] SmsTemplateList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BotFlowList.", this.BotFlowList);
            this.SetParamArrayObj(map, prefix + "SmsSignList.", this.SmsSignList);
            this.SetParamArrayObj(map, prefix + "SmsTemplateList.", this.SmsTemplateList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

