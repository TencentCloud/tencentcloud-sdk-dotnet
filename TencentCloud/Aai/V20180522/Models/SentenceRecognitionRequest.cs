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

    public class SentenceRecognitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云项目 ID，可填 0，总长度不超过 1024 字节。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 子服务类型。0：离线语音识别。1：实时流式识别，2，一句话识别。
        /// </summary>
        [JsonProperty("SubServiceType")]
        public ulong? SubServiceType{ get; set; }

        /// <summary>
        /// 引擎类型。8k：电话 8k 通用模型；16k：16k 通用模型。
        /// </summary>
        [JsonProperty("EngSerViceType")]
        public string EngSerViceType{ get; set; }

        /// <summary>
        /// 语音数据来源。0：语音 URL；1：语音数据（post body）。
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 识别音频的音频格式（支持mp3,wav）。
        /// </summary>
        [JsonProperty("VoiceFormat")]
        public string VoiceFormat{ get; set; }

        /// <summary>
        /// 用户端对此任务的唯一标识，用户自助生成，用于用户查找识别结果。
        /// </summary>
        [JsonProperty("UsrAudioKey")]
        public string UsrAudioKey{ get; set; }

        /// <summary>
        /// 语音 URL，公网可下载。当 SourceType 值为 0 时须填写该字段，为 1 时不填；URL 的长度大于 0，小于 2048，需进行urlencode编码。音频时间长度要小于60s。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 语音数据，当SourceType 值为1时必须填写，为0可不写。要base64编码。音频数据要小于900k。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度，当 SourceType 值为1时必须填写，为0可不写。
        /// </summary>
        [JsonProperty("DataLen")]
        public long? DataLen{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SubServiceType", this.SubServiceType);
            this.SetParamSimple(map, prefix + "EngSerViceType", this.EngSerViceType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "VoiceFormat", this.VoiceFormat);
            this.SetParamSimple(map, prefix + "UsrAudioKey", this.UsrAudioKey);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "DataLen", this.DataLen);
        }
    }
}

