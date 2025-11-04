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

    public class CreateSmartSubtitleTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 智能字幕模板名称
        /// 长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 智能字幕视频源语言
        /// 当前支持以下语言：
        /// `zh`：简体中文
        /// `yue`：中文粵语
        /// `zh-PY`：中英粤
        /// `zh_medical`：中文医疗
        /// `zh_dialect`：中文方言
        /// `prime_zh`：中英方言
        /// `zh_en`：中英
        /// `en`：英语
        /// `ja`：日语
        /// `ko`：韩语
        /// `fr`：法语
        /// `es`：西班牙语
        /// `it`：意大利语
        /// `de`：德语
        /// `tr`：土耳其语
        /// `ru`：俄语
        /// `pt`：葡萄牙语（巴西）
        /// `pt-PT`：葡萄牙语（葡萄牙）
        /// `vi`：越南语
        /// `id`：印度尼西亚语
        /// `ms`：马来语
        /// `th`：泰语
        /// `ar`：阿拉伯语
        /// `hi`：印地语
        /// `fil`：菲律宾语
        /// `auto`：自动识别（仅在纯字幕翻译中支持）
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// 智能字幕字幕语言类型
        /// 0: 源语言
        /// 1: 翻译语言
        /// 2: 源语言+翻译语言
        /// 当TranslateSwitch为OFF时仅支持取0
        /// 当TranslateSwitch为ON时仅支持取1或2
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// 智能字幕模板描述信息
        /// 长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 智能字幕文件格式:
        /// - ASR识别翻译处理类型下：
        ///      - vtt: WebVTT 格式字幕
        ///      - srt: SRT 格式字幕
        ///      - 不填或填空：不生成字幕文件
        /// - 纯字幕翻译处理类型下：
        ///     - original：与源文件一致
        ///     - vtt: WebVTT 格式字幕
        ///     - srt: SRT 格式字幕
        /// 
        /// **注意**：
        /// - ASR识别方式下，翻译大于等于2种语言时不允许传空或不传；
        /// - 纯字幕翻译方式下，不允许传空或不传
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// ASR热词库参数
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// 字幕翻译开关
        /// `ON`: 开启翻译
        /// `OFF`: 关闭翻译
        /// 
        /// **注意**：纯字幕翻译方式下，不传默认是打开的，不允许传空或`OFF`；
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// 字幕翻译目标语言，当TranslateSwitch为`ON`的时候生效
        /// 当前支持以下语言：
        /// 
        /// `zh`：简体中文
        /// `zh-TW`：繁体中文
        /// `en`：英语
        /// `ja`：日语
        /// `ko`：韩语
        /// `fr`：法语
        /// `es`：西班牙语 
        /// `it`：意大利语
        /// `de`：德语
        /// `tr`：土耳其语
        /// `ru`：俄语
        /// `pt`：葡萄牙语（巴西）
        /// `pt-PT`：葡萄牙语（葡萄牙）
        /// `vi`：越南语
        /// `id`：印度尼西亚语 
        /// `ms`：马来语
        /// `th`：泰语
        /// `ar`：阿拉伯语
        /// `hi`：印地语
        /// `fil`：菲律宾语
        /// 
        /// **注意**：多语言方式，则使用 `/` 分割，如：`en/ja`，表示英语和日语。
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// 字幕处理类型：
        /// - 0：ASR识别字幕
        /// - 1：纯字幕翻译
        /// 
        /// **注意**：不传的情况下默认类型为 ASR识别字幕
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamObj(map, prefix + "AsrHotWordsConfigure.", this.AsrHotWordsConfigure);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
        }
    }
}

