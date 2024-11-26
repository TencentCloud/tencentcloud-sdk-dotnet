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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CasterOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// 推流信息Index。
        /// 当OutputType为1（表示推流到腾讯云直播）时，该值固定为0。
        /// 范围[0,10]。
        /// </summary>
        [JsonProperty("OutputIndex")]
        public ulong? OutputIndex{ get; set; }

        /// <summary>
        /// rtmp协议推流地址。
        /// 最大允许长度512字符。
        /// </summary>
        [JsonProperty("OutputUrl")]
        public string OutputUrl{ get; set; }

        /// <summary>
        /// 描述信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 推流到腾讯云直播源站时，使用的流ID。
        /// 仅当OutputType为1时生效。
        /// 最大允许128字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStreamId")]
        public string OutputStreamId{ get; set; }

        /// <summary>
        /// 推流类型。
        /// 范围[1,2]
        /// 1. 推送到腾讯云直播源站。
        /// 2. 推送到第三方源站。
        /// </summary>
        [JsonProperty("OutputType")]
        public ulong? OutputType{ get; set; }

        /// <summary>
        /// 推到腾讯云直播源站时，使用的域名。
        /// 最大允许128字符，且域名需属于当前账号绑定的云直播推流域名。
        /// 仅在OutputType为1时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputDomainName")]
        public string OutputDomainName{ get; set; }

        /// <summary>
        /// 推到腾讯云直播源站时，使用的AppName。
        /// 最大允许64字符。
        /// 仅在OutputType为1时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputAppName")]
        public string OutputAppName{ get; set; }

        /// <summary>
        /// 推到腾讯云直播源站时需要添加的推流参数。
        /// 最大允许长度256字符。
        /// 仅在OutputType为1时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputParam")]
        public string OutputParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputIndex", this.OutputIndex);
            this.SetParamSimple(map, prefix + "OutputUrl", this.OutputUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OutputStreamId", this.OutputStreamId);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "OutputDomainName", this.OutputDomainName);
            this.SetParamSimple(map, prefix + "OutputAppName", this.OutputAppName);
            this.SetParamSimple(map, prefix + "OutputParam", this.OutputParam);
        }
    }
}

