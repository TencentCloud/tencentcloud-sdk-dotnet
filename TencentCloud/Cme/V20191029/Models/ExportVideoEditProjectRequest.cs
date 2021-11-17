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

    public class ExportVideoEditProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 项目 Id。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 视频编码配置 ID，支持自定义创建，推荐优先使用系统预置的导出配置。
        /// <li>10：分辨率为 480P，输出视频格式为 MP4；</li>
        /// <li>11：分辨率为 720P，输出视频格式为 MP4；</li>
        /// <li>12：分辨率为 1080P，输出视频格式为 MP4。</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 导出目标。
        /// <li>CME：云剪，即导出为云剪媒体；</li>
        /// <li>VOD：云点播，即导出为云点播媒资。</li>
        /// </summary>
        [JsonProperty("ExportDestination")]
        public string ExportDestination{ get; set; }

        /// <summary>
        /// 视频封面图片文件（如 jpeg, png 等）进行 Base64 编码后的字符串，仅支持 gif、jpeg、png 三种图片格式，原图片文件不能超过2 M大 小。
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

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
        /// 视频导出扩展参数。可以覆盖导出模板中的参数，灵活的指定导出规格及参数。
        /// </summary>
        [JsonProperty("ExportExtensionArgs")]
        public VideoExportExtensionArgs ExportExtensionArgs{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExportDestination", this.ExportDestination);
            this.SetParamSimple(map, prefix + "CoverData", this.CoverData);
            this.SetParamObj(map, prefix + "CMEExportInfo.", this.CMEExportInfo);
            this.SetParamObj(map, prefix + "VODExportInfo.", this.VODExportInfo);
            this.SetParamObj(map, prefix + "ExportExtensionArgs.", this.ExportExtensionArgs);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

