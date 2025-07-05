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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportVideoByTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 视频编辑模板  Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 导出视频预设配置 Id，推荐优先使用下面的默认预设配置 Id，有其他需求可通过接口定制预设配置。
        /// <li>10：分辨率为 480P，输出视频格式为 MP4；</li>
        /// <li>11：分辨率为 720P，输出视频格式为 MP4；</li>
        /// <li>12：分辨率为 1080P，输出视频格式为 MP4。</li>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 导出目标，指定导出视频的目标媒资库，可取值有：
        /// <li>CME：多媒体创作引擎，即导出为多媒体创作引擎媒资库，此导出目标在云点播媒资库依然可见；</li>
        /// <li>VOD：云点播，即导出为云点播媒资库，此导出目标在多媒体创作引擎媒资库将不可见。</li>
        /// </summary>
        [JsonProperty("ExportDestination")]
        public string ExportDestination{ get; set; }

        /// <summary>
        /// 需要替换的素材信息。
        /// </summary>
        [JsonProperty("SlotReplacements")]
        public SlotReplacementInfo[] SlotReplacements{ get; set; }

        /// <summary>
        /// 导出的多媒体创作引擎媒资信息。当导出目标为 CME 时必填。
        /// </summary>
        [JsonProperty("CMEExportInfo")]
        public CMEExportInfo CMEExportInfo{ get; set; }

        /// <summary>
        /// 导出的云点播媒资信息。当导出目标为 VOD 时必填。
        /// </summary>
        [JsonProperty("VODExportInfo")]
        public VODExportInfo VODExportInfo{ get; set; }

        /// <summary>
        /// 视频导出扩展参数。可以覆盖导出模板中的参数，灵活的指定导出规格及参数。
        /// </summary>
        [JsonProperty("ExportExtensionArgs")]
        public VideoExportExtensionArgs ExportExtensionArgs{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，无权限限制。如果指定操作者，则操作者需要有替换媒体及剪辑模板的权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExportDestination", this.ExportDestination);
            this.SetParamArrayObj(map, prefix + "SlotReplacements.", this.SlotReplacements);
            this.SetParamObj(map, prefix + "CMEExportInfo.", this.CMEExportInfo);
            this.SetParamObj(map, prefix + "VODExportInfo.", this.VODExportInfo);
            this.SetParamObj(map, prefix + "ExportExtensionArgs.", this.ExportExtensionArgs);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

