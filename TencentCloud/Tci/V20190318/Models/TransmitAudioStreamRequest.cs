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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransmitAudioStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 功能开关列表，表示是否需要打开相应的功能，返回相应的信息
        /// </summary>
        [JsonProperty("Functions")]
        public Function Functions{ get; set; }

        /// <summary>
        /// 流式数据包的序号，从1开始，当IsEnd字段为1后后续序号无意义。
        /// </summary>
        [JsonProperty("SeqId")]
        public long? SeqId{ get; set; }

        /// <summary>
        /// 语音段唯一标识，一个完整语音一个SessionId。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 当前数据包数据, 流式模式下数据包大小可以按需设置，在网络良好的情况下，建议设置为0.5k，且必须保证分片帧完整（16bit的数据必须保证音频长度为偶数），编码格式要求为BASE64。
        /// </summary>
        [JsonProperty("UserVoiceData")]
        public string UserVoiceData{ get; set; }

        /// <summary>
        /// 语音编码类型 1:pcm。
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 语音文件类型 	1: raw, 2: wav, 3: mp3 (语言文件格式目前仅支持 16k 采样率 16bit 编码单声道，如有不一致可能导致评估不准确或失败)。
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public long? VoiceFileType{ get; set; }

        /// <summary>
        /// 是否传输完毕标志，若为0表示未完毕，若为1则传输完毕开始评估，非流式模式下无意义。
        /// </summary>
        [JsonProperty("IsEnd")]
        public long? IsEnd{ get; set; }

        /// <summary>
        /// 音频源的语言，默认0为英文，1为中文
        /// </summary>
        [JsonProperty("Lang")]
        public long? Lang{ get; set; }

        /// <summary>
        /// 是否临时保存 音频链接
        /// </summary>
        [JsonProperty("StorageMode")]
        public long? StorageMode{ get; set; }

        /// <summary>
        /// 识别词库名列表，评估过程使用这些词汇库中的词汇进行词汇使用行为分析
        /// </summary>
        [JsonProperty("VocabLibNameList")]
        public string[] VocabLibNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "SeqId", this.SeqId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "UserVoiceData", this.UserVoiceData);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamArraySimple(map, prefix + "VocabLibNameList.", this.VocabLibNameList);
        }
    }
}

