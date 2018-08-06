/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Aai.V20180522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 合成语音的源文本
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 一次请求对应一个SessionId，会原样返回，建议传入类似于uuid的字符串防止重复
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 模型类型，1-默认模型
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// 音量大小，暂仅支持默认值1
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// 语速，暂仅支持默认值1
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 用户自定义项目id，默认为0
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 音色，1-默认音色
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 主语言类型<li>1-中文(包括粤语)，最大300字符</li><li>2-英文，最大支持600字符</li>
        /// </summary>
        [JsonProperty("PrimaryLanguage")]
        public ulong? PrimaryLanguage{ get; set; }

        /// <summary>
        /// 音频采样率：暂仅支持16k
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "PrimaryLanguage", this.PrimaryLanguage);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
        }
    }
}

