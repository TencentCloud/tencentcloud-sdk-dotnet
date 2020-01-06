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

namespace TencentCloud.Aai.V20180522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SimultaneousInterpretingRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云项目 ID，可填 0，总长度不超过 1024 字节。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 子服务类型。0：离线语音识别。1：实时流式识别，2，一句话识别。3：同传。
        /// </summary>
        [JsonProperty("SubServiceType")]
        public ulong? SubServiceType{ get; set; }

        /// <summary>
        /// 识别引擎类型。8k_zh： 8k 中文会场模型；16k_zh：16k 中文会场模型，8k_en： 8k 英文会场模型；16k_en：16k 英文会场模型。当前仅支持16K。
        /// </summary>
        [JsonProperty("RecEngineModelType")]
        public string RecEngineModelType{ get; set; }

        /// <summary>
        /// 语音数据，要base64编码。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度。
        /// </summary>
        [JsonProperty("DataLen")]
        public ulong? DataLen{ get; set; }

        /// <summary>
        /// 声音id，标识一句话。
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// 是否是一句话的结束。
        /// </summary>
        [JsonProperty("IsEnd")]
        public ulong? IsEnd{ get; set; }

        /// <summary>
        /// 声音编码的格式1:pcm，4:speex，6:silk，默认为1。
        /// </summary>
        [JsonProperty("VoiceFormat")]
        public ulong? VoiceFormat{ get; set; }

        /// <summary>
        /// 是否需要翻译结果，1表示需要翻译，0是不需要。
        /// </summary>
        [JsonProperty("OpenTranslate")]
        public ulong? OpenTranslate{ get; set; }

        /// <summary>
        /// 如果需要翻译，表示源语言类型，可取值：zh，en。
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// 如果需要翻译，表示目标语言类型，可取值：zh，en。
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// 表明当前语音分片的索引，从0开始
        /// </summary>
        [JsonProperty("Seq")]
        public ulong? Seq{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SubServiceType", this.SubServiceType);
            this.SetParamSimple(map, prefix + "RecEngineModelType", this.RecEngineModelType);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "DataLen", this.DataLen);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "VoiceFormat", this.VoiceFormat);
            this.SetParamSimple(map, prefix + "OpenTranslate", this.OpenTranslate);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
        }
    }
}

