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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitVideoTranslateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频地址URL。
        /// 格式要求：支持 mp4、mov 。
        /// 时长要求：【5-600】秒。
        /// fps 要求：【15-60】fps
        /// 分辨率要求：单边像素要求在 【360~4096】 之间。
        /// 大小要求：不超过500Mb
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 输入视频中音频语种
        /// 目前支持语种范围：zh(中文), en(英文)
        /// </summary>
        [JsonProperty("SrcLang")]
        public string SrcLang{ get; set; }

        /// <summary>
        /// 当音频 URL 不为空时，不经过语音AI处理，直接以视频为素材用音频内容做视频口型驱动。
        /// 格式要求：支持 mp3、m4a、acc、wav 格式。
        /// 时长要求：【5~600】秒，音频时长要匹配视频时长。
        /// 大小要求：不超过 100Mb。
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 输出视频中翻译语种
        /// 目前支持语种范围：zh(简体中文)、en(英语)、ar(阿拉伯语)、de(德语)、es(西班牙语)、fr(法语)、id(印尼语)、it(意大利语)、ja(日语)、ko(韩语)、ms(马来语)、pt(葡萄牙语)、ru(俄语)、th(泰语)、tr(土耳其语)、vi(越南语)
        /// </summary>
        [JsonProperty("DstLang")]
        public string DstLang{ get; set; }

        /// <summary>
        /// 翻译语种匹配音色种别，其他说明如下：
        /// 1）默认不填代表克隆输入视频中音频音色；
        /// 2）翻译语种非中英（即zh、en），该项必填；
        /// 
        /// 具体音色种别详见说明“支持音色种别列表”，每个音色都支持 15 个目标语种。
        /// </summary>
        [JsonProperty("VoiceType")]
        public string VoiceType{ get; set; }

        /// <summary>
        /// 是否需要纠正视频中音频识别与翻译内容，取值范围：0-不需要，1-需要，默认0。
        /// </summary>
        [JsonProperty("Confirm")]
        public long? Confirm{ get; set; }

        /// <summary>
        /// 是否需要去除VideoUrl或AudioUrl中背景音，取值范围：0-不需要，1-需要，默认0 。
        /// </summary>
        [JsonProperty("RemoveVocal")]
        public long? RemoveVocal{ get; set; }

        /// <summary>
        /// 是否开启口型驱动，0-不开启，1-开启。默认0。
        /// </summary>
        [JsonProperty("LipSync")]
        public long? LipSync{ get; set; }

        /// <summary>
        /// 当 AudioUrl 字段有输入音频时，如果输入音频时长大于输入视频时长，会拼接视频（ 0-正向拼接、1-反向拼接 ）对齐音频时长。默认 0。
        /// </summary>
        [JsonProperty("VideoLoop")]
        public long? VideoLoop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "SrcLang", this.SrcLang);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "DstLang", this.DstLang);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "Confirm", this.Confirm);
            this.SetParamSimple(map, prefix + "RemoveVocal", this.RemoveVocal);
            this.SetParamSimple(map, prefix + "LipSync", this.LipSync);
            this.SetParamSimple(map, prefix + "VideoLoop", this.VideoLoop);
        }
    }
}

