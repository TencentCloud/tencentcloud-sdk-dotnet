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

    public class SmartEraseSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// 字幕擦除方式。
        /// **自动擦除：**通过AI模型自动识别视频中的字幕文本内容，进行无痕化擦除，生成新的视频。但画面干扰、特殊字幕样式可能会带来一定漏擦误擦问题，可以通过指定区域擦除处理。
        /// 当使用自动擦除时，若您不指定AutoAreas，将对默认区域（画面中下部）进行自动擦除；若指定AutoAreas，将改为对您指定的区域进行自动擦除。
        /// **指定区域擦除：**若您的字幕位置较固定，建议您直接指定擦除区域，最大程度减少漏擦的情况。
        /// 当您选择指定区域擦除时，请在CustomAreas中至少传入一个指定区域。
        /// - auto 自动擦除
        /// - custom 指定区域擦除
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// 字幕擦除模型。
        /// **标准版（推荐）：**若您的字幕样式标准，通常建议选择该版本，细节无痕化效果更好。
        /// **区域版：**若您的字幕存在花体、阴影、动效等特殊样式，建议选择区域版，擦除面积更大，但细节效果不如标准版。
        /// - standard 标准模型
        /// - area 区域模型
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// 是否开启OCR字幕提取，默认取OFF。
        /// 当且仅当SubtitleEraseMethod取auto时支持开启OCR字幕提取，开启后将识别自动擦除区域内出现时间最长且最稳定的文字区域为字幕区域，对字幕区域中的文字进行提取和擦除。
        /// - ON 开启
        /// - OFF 关闭
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// 字幕语言，用于指导OCR识别，默认取zh_en；仅当OcrSwitch取"ON"时生效。
        /// - zh_en 中英文
        /// - multi 其他
        /// 其他具体支持识别如下语言：
        /// 中文、英文、日文、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语、印地语、阿拉伯语、印度-孟加拉语、印度-古吉拉特语、印度-卡纳达语 、印度-马拉亚拉姆语 、印度-泰米尔语、印度-泰卢固语、斯洛文尼亚语、波兰语、加泰罗尼亚语、波斯尼亚语、捷克语、爱沙尼亚语、克罗地亚语、旁遮普语、马拉地语、阿塞拜疆语、印尼语、卢森堡语 、立陶宛语、拉脱维亚语、马耳他语、斯洛伐克语、土耳其语、哈萨克语、希腊语、爱尔兰语、白俄罗斯语、高棉语、他加禄语、普什图语、波斯语、塔吉克斯坦语
        /// 
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// 字幕文件格式，默认取vtt；仅当OcrSwitch取"ON"时生效。
        /// - srt srt格式
        /// - vtt WebVTT格式
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// 是否开启字幕翻译，默认取OFF；仅当OcrSwitch取"ON"时生效。
        /// - ON 开启
        /// - OFF 关闭
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// 字幕翻译目标语言，默认取en；仅当TransSwitch取"ON"时生效。
        /// 当前支持以下语言：
        /// zh：简体中文
        /// en：英语
        /// ja：日语
        /// ko：韩语
        /// fr：法语
        /// es：西班牙语
        /// it：意大利语
        /// de：德语
        /// tr：土耳其语
        /// ru：俄语
        /// pt：葡萄牙语
        /// vi：越南语
        /// id：印度尼西亚语
        /// ms：马来语
        /// th：泰语
        /// ar：阿拉伯语
        /// hi：印地语
        /// </summary>
        [JsonProperty("TransDstLang")]
        public string TransDstLang{ get; set; }

        /// <summary>
        /// 自动擦除自定义区域。
        /// 对选定区域，利用AI模型自动检测其中存在的擦除目标并擦除。
        /// 注意：当擦除方式选择custom时，此参数将不会生效；修改模板时，清除区域请传入[]，不传时将保持模板区域信息不变。
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// 指定擦除自定义区域。
        /// 对选定区域，在选定时间段内不进行检测识别直接进行擦除。
        /// 注意：修改模板时，清除区域请传入[]，不传时将保持模板区域信息不变。
        /// </summary>
        [JsonProperty("CustomAreas")]
        public EraseTimeArea[] CustomAreas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleEraseMethod", this.SubtitleEraseMethod);
            this.SetParamSimple(map, prefix + "SubtitleModel", this.SubtitleModel);
            this.SetParamSimple(map, prefix + "OcrSwitch", this.OcrSwitch);
            this.SetParamSimple(map, prefix + "SubtitleLang", this.SubtitleLang);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "TransSwitch", this.TransSwitch);
            this.SetParamSimple(map, prefix + "TransDstLang", this.TransDstLang);
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamArrayObj(map, prefix + "CustomAreas.", this.CustomAreas);
        }
    }
}

