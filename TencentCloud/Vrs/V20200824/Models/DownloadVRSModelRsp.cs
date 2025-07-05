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

    public class DownloadVRSModelRsp : AbstractModel
    {
        
        /// <summary>
        /// 模型cos地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 音色名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoiceName")]
        public string VoiceName{ get; set; }

        /// <summary>
        /// 音色性别:
        /// 1-male
        /// 2-female
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoiceGender")]
        public long? VoiceGender{ get; set; }

        /// <summary>
        /// 语言类型：
        /// 1-中文
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoiceLanguage")]
        public long? VoiceLanguage{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "VoiceName", this.VoiceName);
            this.SetParamSimple(map, prefix + "VoiceGender", this.VoiceGender);
            this.SetParamSimple(map, prefix + "VoiceLanguage", this.VoiceLanguage);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

