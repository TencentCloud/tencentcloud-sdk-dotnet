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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTtsTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 合成语音的源文本，按UTF-8编码统一计算，最多支持10万字符
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 音量大小，范围[-10，10]，对应音量大小。默认为0，代表正常音量，值越大音量越高。
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// 语速，范围：[-2，6]，分别对应不同语速：<li>-2代表0.6倍</li><li>-1代表0.8倍</li><li>0代表1.0倍（默认）</li><li>1代表1.2倍</li><li>2代表1.5倍</li><li>6代表2.5倍</li>如果需要更细化的语速，可以保留小数点后 2 位，例如0.5/1.25/2.81等。<br>参数值与实际语速转换，可参考[代码示例](https://sdk-1300466766.cos.ap-shanghai.myqcloud.com/sample/speed_sample.tar.gz)
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 项目id，用户自定义，默认为0。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 模型类型，1-默认模型。
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// 音色 ID，价格请参见[购买指南](https://cloud.tencent.com/document/product/1073/34112)。完整的音色 ID 列表请参见[音色列表](https://cloud.tencent.com/document/product/1073/92668)。
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 主语言类型：<li>1-中文（默认）</li><li>2-英文</li>
        /// </summary>
        [JsonProperty("PrimaryLanguage")]
        public long? PrimaryLanguage{ get; set; }

        /// <summary>
        /// 音频采样率：<li>16000：16k（默认）</li><li>8000：8k</li>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 返回音频格式，可取值：mp3（默认），wav，pcm
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 回调 URL，用户自行搭建的用于接收识别结果的服务URL。如果用户使用轮询方式获取识别结果，则无需提交该参数。[回调说明](https://cloud.tencent.com/document/product/1073/55746)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 是否开启时间戳功能，默认为false。
        /// </summary>
        [JsonProperty("EnableSubtitle")]
        public bool? EnableSubtitle{ get; set; }

        /// <summary>
        /// 旁白与对白文本解析，分别合成相应风格（仅适用于旁对白音色10510000、100510000），默认 false
        /// </summary>
        [JsonProperty("VoiceoverDialogueSplit")]
        public bool? VoiceoverDialogueSplit{ get; set; }

        /// <summary>
        /// 控制合成音频的情感，仅支持多情感音色使用。取值: neutral(中性)、sad(悲伤)、happy(高兴)、angry(生气)、fear(恐惧)、news(新闻)、story(故事)、radio(广播)、poetry(诗歌)、call(客服)、sajiao(撒娇)、disgusted(厌恶)、amaze(震惊)、peaceful(平静)、exciting(兴奋)、aojiao(傲娇)、jieshuo(解说)
        /// </summary>
        [JsonProperty("EmotionCategory")]
        public string EmotionCategory{ get; set; }

        /// <summary>
        /// 控制合成音频情感程度，取值范围为[50,200],默认为100；只有EmotionCategory不为空时生效。
        /// </summary>
        [JsonProperty("EmotionIntensity")]
        public long? EmotionIntensity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "PrimaryLanguage", this.PrimaryLanguage);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "EnableSubtitle", this.EnableSubtitle);
            this.SetParamSimple(map, prefix + "VoiceoverDialogueSplit", this.VoiceoverDialogueSplit);
            this.SetParamSimple(map, prefix + "EmotionCategory", this.EmotionCategory);
            this.SetParamSimple(map, prefix + "EmotionIntensity", this.EmotionIntensity);
        }
    }
}

