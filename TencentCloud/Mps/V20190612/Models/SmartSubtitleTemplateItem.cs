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
        /// <p>智能字幕模板唯一标识</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>智能字幕模板名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>智能字幕模板描述信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>模板类型，取值范围：</p><ul><li>Preset：系统预置模板；</li><li>Custom：用户自定义模板。</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>ASR热词库参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrHotWordsConfigure")]
        public AsrHotWordsConfigure AsrHotWordsConfigure{ get; set; }

        /// <summary>
        /// <p>模板关联热词库名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrHotWordsLibraryName")]
        public string AsrHotWordsLibraryName{ get; set; }

        /// <summary>
        /// <p>智能字幕视频源语言列表：</p><p><code>zh</code>：简体中文<br><code>yue</code>：中文粵语<br><code>zh-PY</code>：中英粤<br><code>zh_medical</code>：中文医疗<br><code>zh_dialect</code>：中文方言<br><code>prime_zh</code>：中英方言<br><code>zh_en</code>：中英<br><code>en</code>：英语<br><code>ja</code>：日语<br><code>ko</code>：韩语<br><code>fr</code>：法语<br><code>es</code>：西班牙语<br><code>it</code>：意大利语<br><code>de</code>：德语<br><code>tr</code>：土耳其语<br><code>ru</code>：俄语<br><code>pt</code>：葡萄牙语（巴西）<br><code>pt-PT</code>：葡萄牙语（葡萄牙）<br><code>vi</code>：越南语<br><code>id</code>：印度尼西亚语<br><code>ms</code>：马来语<br><code>th</code>：泰语<br><code>ar</code>：阿拉伯语<br><code>hi</code>：印地语<br><code>fil</code>：菲律宾语<br><code>auto</code>：自动识别（仅在纯字幕翻译中支持）</p>
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// <p>智能字幕文件格式</p><ul><li>vtt: WebVTT 格式</li><li>srt: SRT格式</li><li>original：与源字幕文件一致（用于纯字幕翻译模板）</li><li>不填或填空：不生成字幕文件</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// <p>智能字幕字幕语言类型<br>0: 源语言<br>1: 翻译语言<br>2: 源语言+翻译语言<br>当TranslateSwitch为OFF时仅支持取0<br>当TranslateSwitch为ON时仅支持取1或2</p>
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// <p>字幕翻译开关<br>ON: 开启翻译<br>OFF: 关闭翻译</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// <p>字幕翻译目标语言<br>当TranslateSwitch为ON的时候生效<br><code>zh</code>：简体中文<br><code>zh-TW</code>：繁体中文<br><code>en</code>：英语<br><code>ja</code>：日语<br><code>ko</code>：韩语<br><code>fr</code>：法语<br><code>es</code>：西班牙语<br><code>it</code>：意大利语<br><code>de</code>：德语<br><code>tr</code>：土耳其语<br><code>ru</code>：俄语<br><code>pt</code>：葡萄牙语（巴西）<br><code>pt-PT</code>：葡萄牙语（葡萄牙）<br><code>vi</code>：越南语<br><code>id</code>：印度尼西亚语<br><code>ms</code>：马来语<br><code>th</code>：泰语<br><code>ar</code>：阿拉伯语<br><code>hi</code>：印地语<br><code>fil</code>：菲律宾语</p><p><strong>注意</strong>：多语言方式，则使用 <code>/</code> 分割，如：<code>en/ja</code>，表示英语和日语。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// <p>模板创建时间，使用 <a href="https://cloud.tencent.com/document/product/862/37710#52">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>模板最后修改时间，使用 <a href="https://cloud.tencent.com/document/product/862/37710#52">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>智能字幕预设模板别名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// <p>字幕处理类型：</p><ul><li>0：ASR识别字幕</li><li>1：纯字幕翻译</li><li>2:  OCR识别字幕</li></ul>
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }

        /// <summary>
        /// <p>字幕OCR提取框选区域配置信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public SelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }

        /// <summary>
        /// <p>字幕压制模板id</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>说话人识别模式，可选值：<br>0：表示不开启说话人识别；<br>1：表示开启说话人识别；<br>默认值：0</p>
        /// </summary>
        [JsonProperty("SpeakerMode")]
        public long? SpeakerMode{ get; set; }

        /// <summary>
        /// <p>说话人识别输出到字幕文件，可选值：<br>0：表示不输出到字幕文件；<br>1：表示输出到vtt字幕文件<br>注意：使用此参数SpeakerMode的值不能为0；<br>默认值：0</p>
        /// </summary>
        [JsonProperty("SpeakerLabel")]
        public long? SpeakerLabel{ get; set; }


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
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "SpeakerMode", this.SpeakerMode);
            this.SetParamSimple(map, prefix + "SpeakerLabel", this.SpeakerLabel);
        }
    }
}

