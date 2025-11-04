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

    public class SmartSubtitleTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// 智能字幕模板唯一标识
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 智能字幕模板名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 智能字幕模板描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 模板类型，取值范围：
        /// * Preset：系统预置模板；
        /// * Custom：用户自定义模板。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ASR热词库参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// 模板关联热词库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrHotWordsLibraryName")]
        public string AsrHotWordsLibraryName{ get; set; }

        /// <summary>
        /// 智能字幕视频源语言列表：
        /// 
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
        /// 智能字幕文件格式
        /// - vtt: WebVTT 格式
        /// - srt: SRT格式
        /// - original：与源字幕文件一致（用于纯字幕翻译模版）
        /// - 不填或填空：不生成字幕文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

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
        /// 字幕翻译开关
        /// ON: 开启翻译
        /// OFF: 关闭翻译
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// 字幕翻译目标语言
        /// 当TranslateSwitch为ON的时候生效
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
        /// 
        /// **注意**：多语言方式，则使用 `/` 分割，如：`en/ja`，表示英语和日语。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/862/37710#52)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/862/37710#52)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 智能字幕预设模板别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 字幕处理类型：
        /// - 0：ASR识别字幕
        /// - 1：纯字幕翻译
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AsrHotWordsConfigure.", this.AsrHotWordsConfigure);
            this.SetParamSimple(map, prefix + "AsrHotWordsLibraryName", this.AsrHotWordsLibraryName);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
        }
    }
}

