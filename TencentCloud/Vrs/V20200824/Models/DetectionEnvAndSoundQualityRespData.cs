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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectionEnvAndSoundQualityRespData : AbstractModel
    {
        
        /// <summary>
        /// 音频ID （用于创建任务接口AudioIds）,环境检测该值为空，仅在音质检测情况下返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioId")]
        public string AudioId{ get; set; }

        /// <summary>
        /// 检测code 
        /// 
        /// 0 表示当前语音通过
        /// -1 表示检测失败，需要重试
        /// -2 表示语音检测不通过，提示用户再重新录制一下（通常漏读，错读，或多读）
        /// -3 表示语音中噪声较大，不通过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectionCode")]
        public long? DetectionCode{ get; set; }

        /// <summary>
        /// 检测提示信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectionMsg")]
        public string DetectionMsg{ get; set; }

        /// <summary>
        /// 检测提示信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectionTip")]
        public Words[] DetectionTip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioId", this.AudioId);
            this.SetParamSimple(map, prefix + "DetectionCode", this.DetectionCode);
            this.SetParamSimple(map, prefix + "DetectionMsg", this.DetectionMsg);
            this.SetParamArrayObj(map, prefix + "DetectionTip.", this.DetectionTip);
        }
    }
}

