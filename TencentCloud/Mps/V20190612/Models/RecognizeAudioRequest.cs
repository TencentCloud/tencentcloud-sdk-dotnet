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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeAudioRequest : AbstractModel
    {
        
        /// <summary>
        /// base64编码的音频数据
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// 识别目标语言，为空默认 auto 自动识别语种。
        /// 注：如果自动识别语种识别效果不佳，可以指定语种提高准确率
        /// 
        /// 当前支持语言：
        /// auto: 自动识别
        /// zh: 简体中文
        /// en: 英语
        /// ja: 日语
        /// ko: 韩语
        /// vi: 越南语
        /// ms: 马来语
        /// id: 印度尼西亚语
        /// fil: 菲律宾语
        /// th: 泰语
        /// pt: 葡萄牙语
        /// tr: 土耳其语
        /// ar: 阿拉伯语
        /// es: 西班牙语
        /// hi: 印地语
        /// fr: 法语
        /// de: 德语
        /// it: 意大利语
        /// yue: 粤语
        /// ru: 俄语
        /// af: 南非荷兰语
        /// sq: 阿尔巴尼亚语
        /// am: 阿姆哈拉语
        /// hy: 亚美尼亚语
        /// az: 阿塞拜疆语
        /// eu: 巴斯克语
        /// bn: 孟加拉语
        /// bs: 波斯尼亚语
        /// bg: 保加利亚语
        /// my: 缅甸语
        /// ca: 加泰罗尼亚语
        /// hr: 克罗地亚语
        /// cs: 捷克语
        /// da: 丹麦语
        /// nl: 荷兰语
        /// et: 爱沙尼亚语
        /// fi: 芬兰语
        /// gl: 加利西亚语
        /// ka: 格鲁吉亚语
        /// el: 希腊语
        /// gu: 古吉拉特语
        /// iw: 希伯来语
        /// hu: 匈牙利语
        /// is: 冰岛语
        /// jv: 爪哇语
        /// kn: 卡纳达语
        /// kk: 哈萨克语
        /// km: 高棉语
        /// rw: 卢旺达语
        /// lo: 老挝语
        /// lv: 拉脱维亚语
        /// lt: 立陶宛语
        /// mk: 马其顿语
        /// ml: 马拉雅拉姆语
        /// mr: 马拉地语
        /// mn: 蒙古语
        /// ne: 尼泊尔语
        /// no: 博克马尔挪威语
        /// fa: 波斯语
        /// pl: 波兰语
        /// ro: 罗马尼亚语
        /// sr: 塞尔维亚语
        /// si: 僧伽罗语
        /// sk: 斯洛伐克语
        /// sl: 斯洛文尼亚语
        /// st: 南索托语
        /// su: 巽他语
        /// sw: 斯瓦希里语
        /// sv: 瑞典语
        /// ta: 泰米尔语
        /// te: 泰卢固语
        /// ts: 聪加语
        /// uk: 乌克兰语
        /// ur: 乌尔都语
        /// uz: 乌兹别克语
        /// ve: 文达语
        /// xh: 科萨语
        /// zu: 祖鲁语
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 音频数据格式，默认为 pcm
        /// 
        /// 支持的格式：
        /// pcm (16000 采样率的单声道 16 位采样 pcm 数据)
        /// ogg-opus (16000 / 24000 / 48000 采样率的单声道 opus 编码的 ogg 数据)
        /// </summary>
        [JsonProperty("AudioFormat")]
        public string AudioFormat{ get; set; }

        /// <summary>
        /// 音频的采样率
        /// 
        /// 支持的采样率：
        /// pcm 16000
        /// ogg-opus 16000 / 24000 / 48000
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 扩展参数，默认不填，特殊需求使用
        /// </summary>
        [JsonProperty("UserExtPara")]
        public string UserExtPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "UserExtPara", this.UserExtPara);
        }
    }
}

