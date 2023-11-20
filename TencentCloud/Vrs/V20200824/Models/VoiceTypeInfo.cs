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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceTypeInfo : AbstractModel
    {
        
        /// <summary>
        /// 音色id
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 音色名称
        /// </summary>
        [JsonProperty("VoiceName")]
        public string VoiceName{ get; set; }

        /// <summary>
        /// 音色性别: 1-male 2-female
        /// </summary>
        [JsonProperty("VoiceGender")]
        public long? VoiceGender{ get; set; }

        /// <summary>
        /// 复刻类型: 0-轻量版复刻 1-基础版复刻
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 复刻任务 ID
        /// </summary>
        [JsonProperty("TaskID")]
        public string TaskID{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("DateCreated")]
        public string DateCreated{ get; set; }

        /// <summary>
        /// 部署状态。若已部署，则可通过语音合成接口调用该音色
        /// </summary>
        [JsonProperty("IsDeployed")]
        public bool? IsDeployed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "VoiceName", this.VoiceName);
            this.SetParamSimple(map, prefix + "VoiceGender", this.VoiceGender);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "DateCreated", this.DateCreated);
            this.SetParamSimple(map, prefix + "IsDeployed", this.IsDeployed);
        }
    }
}

