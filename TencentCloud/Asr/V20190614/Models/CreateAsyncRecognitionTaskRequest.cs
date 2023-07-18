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

    public class CreateAsyncRecognitionTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎模型类型。
        /// • 16k_zh：中文普通话通用；
        /// • 16k_en：英语；
        /// • 16k_yue：粤语；
        /// • 16k_id：印度尼西亚语；
        /// • 16k_fil：菲律宾语；
        /// • 16k_th：泰语；
        /// • 16k_pt：葡萄牙语；
        /// • 16k_tr：土耳其语；
        /// • 16k_ar：阿拉伯语；
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 语音流地址，支持rtmp、rtsp等流媒体协议，以及各类基于http协议的直播流(不支持hls, m3u8)
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 支持HTTP和HTTPS协议，用于接收识别结果，您需要自行搭建公网可调用的服务。回调格式&内容详见：[语音流异步识别回调说明](https://cloud.tencent.com/document/product/1093/52633)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 用于生成回调通知中的签名
        /// </summary>
        [JsonProperty("SignToken")]
        public string SignToken{ get; set; }

        /// <summary>
        /// 是否过滤脏词（目前支持中文普通话引擎）。0：不过滤脏词；1：过滤脏词；2：将脏词替换为 * 。默认值为 0
        /// </summary>
        [JsonProperty("FilterDirty")]
        public long? FilterDirty{ get; set; }

        /// <summary>
        /// 是否过语气词（目前支持中文普通话引擎）。0：不过滤语气词；1：部分过滤；2：严格过滤 。默认值为 0
        /// </summary>
        [JsonProperty("FilterModal")]
        public long? FilterModal{ get; set; }

        /// <summary>
        /// 是否过滤标点符号（目前支持中文普通话引擎）。 0：不过滤，1：过滤句末标点，2：过滤所有标点。默认为0
        /// </summary>
        [JsonProperty("FilterPunc")]
        public long? FilterPunc{ get; set; }

        /// <summary>
        /// 是否进行阿拉伯数字智能转换。0：不转换，直接输出中文数字，1：根据场景智能转换为阿拉伯数字。默认值为1
        /// </summary>
        [JsonProperty("ConvertNumMode")]
        public long? ConvertNumMode{ get; set; }

        /// <summary>
        /// 是否显示词级别时间戳。0：不显示；1：显示，不包含标点时间戳，2：显示，包含标点时间戳。默认为0
        /// </summary>
        [JsonProperty("WordInfo")]
        public long? WordInfo{ get; set; }

        /// <summary>
        /// 热词id。用于调用对应的热词表，如果在调用语音识别服务时，不进行单独的热词id设置，自动生效默认热词；如果进行了单独的热词id设置，那么将生效单独设置的热词id。
        /// </summary>
        [JsonProperty("HotwordId")]
        public string HotwordId{ get; set; }

        /// <summary>
        /// 回调数据中，是否需要对应音频数据。
        /// </summary>
        [JsonProperty("AudioData")]
        public bool? AudioData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "SignToken", this.SignToken);
            this.SetParamSimple(map, prefix + "FilterDirty", this.FilterDirty);
            this.SetParamSimple(map, prefix + "FilterModal", this.FilterModal);
            this.SetParamSimple(map, prefix + "FilterPunc", this.FilterPunc);
            this.SetParamSimple(map, prefix + "ConvertNumMode", this.ConvertNumMode);
            this.SetParamSimple(map, prefix + "WordInfo", this.WordInfo);
            this.SetParamSimple(map, prefix + "HotwordId", this.HotwordId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
        }
    }
}

