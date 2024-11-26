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

    public class CasterInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 输入源Index。
        /// 范围[1, 20]
        /// </summary>
        [JsonProperty("InputIndex")]
        public long? InputIndex{ get; set; }

        /// <summary>
        /// 输入源类型。
        /// 范围[0,1,2,3,4]。
        /// 0：推流地址。
        /// 1：点播文件地址。
        /// 2：直播拉流地址。
        /// 3：图片地址。
        /// 4：webrtc协议推流地址。
        /// </summary>
        [JsonProperty("InputType")]
        public long? InputType{ get; set; }

        /// <summary>
        /// 输入源的源地址。
        /// 最大允许长度512。
        /// 当InputType为0（推流地址），2（直播拉流地址），3（图片地址）,4（webrtc推流地址）这几种类型时，URL需填入该字段。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// 输入源描述。
        /// 最大允许长度256字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 点播地址列表。仅当input type为1（点播地址）时，将一个或多个点播地址，填入该字段。
        /// 单个地址最大允许长度512字符。
        /// 最多允许同时填入5个地址。
        /// 注：此时需保持InputUrl字段为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputUrls")]
        public string[] InputUrls{ get; set; }

        /// <summary>
        /// 是否启用点播无限循环播放。
        /// 注：当前该字段未生效，默认为True。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoopEnable")]
        public bool? LoopEnable{ get; set; }

        /// <summary>
        /// 点播循环次数。
        /// 允许值-1或正整数。
        /// 当值为-1时，表示无限循环。
        /// 当值为其他正整数时，表示循环对应次数。
        /// 注：该字段暂未生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoopNumber")]
        public long? LoopNumber{ get; set; }

        /// <summary>
        /// 是否启用拉取到导播台。
        /// 注：该字段默认强制为true。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullPushEnable")]
        public bool? PullPushEnable{ get; set; }

        /// <summary>
        /// 输入源音量百分比。
        /// 默认为100。表示音量为原始大小。
        /// 允许值[0,200]。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputIndex", this.InputIndex);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "InputUrls.", this.InputUrls);
            this.SetParamSimple(map, prefix + "LoopEnable", this.LoopEnable);
            this.SetParamSimple(map, prefix + "LoopNumber", this.LoopNumber);
            this.SetParamSimple(map, prefix + "PullPushEnable", this.PullPushEnable);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

