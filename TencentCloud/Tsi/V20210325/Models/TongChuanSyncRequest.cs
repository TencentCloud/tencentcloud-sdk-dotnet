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

namespace TencentCloud.Tsi.V20210325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TongChuanSyncRequest : AbstractModel
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
        /// 翻译目标语言类型，支持的语言列表<li> zh : 中文 </li> <li> en : 英文 </li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 语音编码类型，1-pcm
        /// </summary>
        [JsonProperty("AudioFormat")]
        public ulong? AudioFormat{ get; set; }

        /// <summary>
        /// 语音分片的序号，从0开始
        /// </summary>
        [JsonProperty("Seq")]
        public ulong? Seq{ get; set; }

        /// <summary>
        /// 语音开始的时间戳
        /// </summary>
        [JsonProperty("Utc")]
        public ulong? Utc{ get; set; }

        /// <summary>
        /// 是否最后一片语音分片，0-否，1-是
        /// </summary>
        [JsonProperty("IsEnd")]
        public ulong? IsEnd{ get; set; }

        /// <summary>
        /// 翻译时机，0 -不翻译 1 - 句子结束时翻译，2 - 句子实时翻译
        /// </summary>
        [JsonProperty("TranslateTime")]
        public ulong? TranslateTime{ get; set; }

        /// <summary>
        /// 语音分片内容进行 Base64 编码后的字符串。音频内容需包含有效并可识别的文本信息。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionUuid", this.SessionUuid);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "Utc", this.Utc);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "TranslateTime", this.TranslateTime);
            this.SetParamSimple(map, prefix + "Data", this.Data);
        }
    }
}

