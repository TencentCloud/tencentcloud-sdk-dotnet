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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>sdkappid app账号</p>
        /// </summary>
        [JsonProperty("Sdkappid")]
        public long? Sdkappid{ get; set; }

        /// <summary>
        /// <p>BizType为策略的具体的编号, GME业务 2_2_3_sdkappid</p>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>据标识，可以由英文字母、数字、下划线、-、@#组成，不超过64个字符</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>音频格式，当FileUrl为空时，必填。音频文件资源格式，当前支持格式：wav、mp3、m4a，请按照实际文件格式填入。 示例值：mp3</p>
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// <p>文件名称，可以由英文字母、数字、下划线、-、@#组成，不超过64个字符 示例值：file_name</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>数据Base64编码，短音频同步接口仅传入可音频内容； 支持范围：文件大小不能超过5M，时长不可超过60s； 支持格式：wav (PCM编码)、mp3、m4a (采样率：16kHz~48kHz，位深：16bit 小端，声道数：单声道/双声道，建议格式：16kHz/16bit/单声道)。 示例值：1</p>
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// <p>音频资源访问链接，与FileContent参数必须二选一输入； 支持范围及格式：同FileContent；</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sdkappid", this.Sdkappid);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
        }
    }
}

