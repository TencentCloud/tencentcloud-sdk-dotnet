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

namespace TencentCloud.Asr.V20190614.Models
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
        /// 子服务类型。2： 一句话识别。
        /// </summary>
        [JsonProperty("SubServiceType")]
        public ulong? SubServiceType{ get; set; }

        /// <summary>
        /// 引擎模型类型。
        /// 电话场景：
        /// • 8k_en：电话 8k 英语；
        /// • 8k_zh：电话 8k 中文普通话通用；
        /// 非电话场景：
        /// • 16k_zh：16k 中文普通话通用；
        /// • 16k_en：16k 英语；
        /// • 16k_ca：16k 粤语；
        /// • 16k_ja：16k 日语；
        /// •16k_wuu-SH：16k 上海话方言。
        /// • 16k_ca：16k 粤语；
        /// • 16k_ja：16k 日语；
        /// •16k_wuu-SH：16k 上海话方言。
        /// </summary>
        [JsonProperty("EngSerViceType")]
        public string EngSerViceType{ get; set; }

        /// <summary>
        /// 语音数据来源。0：语音 URL；1：语音数据（post body）。
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 识别音频的音频格式。mp3、wav。
        /// </summary>
        [JsonProperty("VoiceFormat")]
        public string VoiceFormat{ get; set; }

        /// <summary>
        /// 用户端对此任务的唯一标识，用户自助生成，用于用户查找识别结果。
        /// </summary>
        [JsonProperty("UsrAudioKey")]
        public string UsrAudioKey{ get; set; }

        /// <summary>
        /// 语音 URL，公网可下载。当 SourceType 值为 0（语音 URL上传） 时须填写该字段，为 1 时不填；URL 的长度大于 0，小于 2048，需进行urlencode编码。音频时间长度要小于60s。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 语音数据，当SourceType 值为1（本地语音数据上传）时必须填写，当SourceType 值为0（语音 URL上传）可不写。要使用base64编码(采用python语言时注意读取文件应该为string而不是byte，以byte格式读取后要decode()。编码后的数据不可带有回车换行符)。数据长度要小于3MB（Base64后）。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度，单位为字节。当 SourceType 值为1（本地语音数据上传）时必须填写，当 SourceType 值为0（语音 URL上传）可不写（此数据长度为数据未进行base64编码时的数据长度）。
        /// </summary>
        [JsonProperty("DataLen")]
        public long? DataLen{ get; set; }

        /// <summary>
        /// 热词id。用于调用对应的热词表，如果在调用语音识别服务时，不进行单独的热词id设置，自动生效默认热词；如果进行了单独的热词id设置，那么将生效单独设置的热词id。
        /// </summary>
        [JsonProperty("HotwordId")]
        public string HotwordId{ get; set; }

        /// <summary>
        /// 是否过滤脏词（目前支持中文普通话引擎）。0：不过滤脏词；1：过滤脏词；2：将脏词替换为 * 。
        /// </summary>
        [JsonProperty("FilterDirty")]
        public long? FilterDirty{ get; set; }

        /// <summary>
        /// 是否过语气词（目前支持中文普通话引擎）。0：不过滤语气词；1：部分过滤；2：严格过滤 。
        /// </summary>
        [JsonProperty("FilterModal")]
        public long? FilterModal{ get; set; }

        /// <summary>
        /// 是否过滤标点符号（目前支持中文普通话引擎）。 0：不过滤，1：过滤句末标点，2：过滤所有标点。默认为0。
        /// </summary>
        [JsonProperty("FilterPunc")]
        public long? FilterPunc{ get; set; }

        /// <summary>
        /// 是否进行阿拉伯数字智能转换。0：不转换，直接输出中文数字，1：根据场景智能转换为阿拉伯数字。默认值为1
        /// </summary>
        [JsonProperty("ConvertNumMode")]
        public long? ConvertNumMode{ get; set; }

        /// <summary>
        /// 是否显示词级别时间戳。0：不显示；1：显示，不包含标点时间戳，2：显示，包含标点时间戳。支持引擎8k_zh，16k_zh，16k_en，16k_ca，16k_ja，16k_wuu-SH
        /// </summary>
        [JsonProperty("WordInfo")]
        public long? WordInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
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
            this.SetParamSimple(map, prefix + "HotwordId", this.HotwordId);
            this.SetParamSimple(map, prefix + "FilterDirty", this.FilterDirty);
            this.SetParamSimple(map, prefix + "FilterModal", this.FilterModal);
            this.SetParamSimple(map, prefix + "FilterPunc", this.FilterPunc);
            this.SetParamSimple(map, prefix + "ConvertNumMode", this.ConvertNumMode);
            this.SetParamSimple(map, prefix + "WordInfo", this.WordInfo);
        }
    }
}

