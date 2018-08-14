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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeechTranslateRequest : AbstractModel
    {
        
        /// <summary>
        /// 一段完整的语音对应一个SessionUuid
        /// </summary>
        [JsonProperty("SessionUuid")]
        public string SessionUuid{ get; set; }

        /// <summary>
        /// 音频中的语言类型，支持语言列表<li> zh : 中文 </li> <li> en : 英文 </li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 翻译目标语⾔言类型 ，支持的语言列表<li> zh : 中文 </li> <li> en : 英文 </li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// pcm : 146   amr : 33554432   mp3 : 83886080
        /// </summary>
        [JsonProperty("AudioFormat")]
        public long? AudioFormat{ get; set; }

        /// <summary>
        /// 语音分片后的第几片
        /// </summary>
        [JsonProperty("Seq")]
        public long? Seq{ get; set; }

        /// <summary>
        /// 是否最后一片
        /// </summary>
        [JsonProperty("IsEnd")]
        public long? IsEnd{ get; set; }

        /// <summary>
        /// 语音分片内容的base64字符串
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionUuid", this.SessionUuid);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

