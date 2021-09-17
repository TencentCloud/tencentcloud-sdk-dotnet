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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportVideoByTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 视频编辑模板  Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 导出模板 Id，目前不支持自定义创建，只支持下面的预置模板 Id。
        /// <li>10：分辨率为 480P，输出视频格式为 MP4；</li>
        /// <li>11：分辨率为 720P，输出视频格式为 MP4；</li>
        /// <li>12：分辨率为 1080P，输出视频格式为 MP4。</li>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 导出目标，可取值为：
        /// <li>CME：云剪，即导出为云剪媒体；</li>
        /// <li>VOD：云点播，即导出为云点播媒资。</li>
        /// </summary>
        [JsonProperty("ExportDestination")]
        public string ExportDestination{ get; set; }

        /// <summary>
        /// 需要替换的素材信息。
        /// </summary>
        [JsonProperty("SlotReplacements")]
        public SlotReplacementInfo[] SlotReplacements{ get; set; }

        /// <summary>
        /// 导出的云剪媒体信息。当导出目标为 CME 时必填。
        /// </summary>
        [JsonProperty("CMEExportInfo")]
        public CMEExportInfo CMEExportInfo{ get; set; }

        /// <summary>
        /// 导出的云点播媒资信息。当导出目标为 VOD 时必填。
        /// </summary>
        [JsonProperty("VODExportInfo")]
        public VODExportInfo VODExportInfo{ get; set; }

        /// <summary>
        /// 操作者。填写用户的 Id，用于标识调用者及校验项目导出权限。
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
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

