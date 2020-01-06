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
        /// 语音分片的序号，从0开始
        /// </summary>
        [JsonProperty("Seq")]
        public long? Seq{ get; set; }

        /// <summary>
        /// 是否最后一片语音分片，0-否，1-是
        /// </summary>
        [JsonProperty("IsEnd")]
        public long? IsEnd{ get; set; }

        /// <summary>
        /// 语音分片内容的base64字符串，音频内容应含有效并可识别的文本
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 项目ID，可以根据控制台-账号中心-项目管理中的配置填写，如无配置请填写默认项目ID:0
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 识别模式，该参数已废弃
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
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
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

