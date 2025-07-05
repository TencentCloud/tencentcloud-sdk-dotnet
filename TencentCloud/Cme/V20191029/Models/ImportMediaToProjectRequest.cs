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

    public class ImportMediaToProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 项目 Id。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 导入媒资类型，取值：
        /// <li>VOD：云点播文件；</li>
        /// <li>EXTERNAL：媒资绑定。</li>
        /// 
        /// 注意：如果不填默认为云点播文件，如果媒体存储在非腾讯云点播中，都需要使用媒资绑定。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 云点播媒资文件 Id，当 SourceType 取值 VOD 或者缺省的时候必填。
        /// </summary>
        [JsonProperty("VodFileId")]
        public string VodFileId{ get; set; }

        /// <summary>
        /// 原始媒资文件信息，当 SourceType 取值 EXTERNAL 的时候必填。
        /// </summary>
        [JsonProperty("ExternalMediaInfo")]
        public ExternalMediaInfo ExternalMediaInfo{ get; set; }

        /// <summary>
        /// 媒体名称，不能超过30个字符。如果不填，则媒体名称为点播媒资文件名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 媒体预处理配置 ID，取值：
        /// <li>10：进行视频编辑预处理。</li>
        /// 
        /// 注意：如果填0或者不填则不进行处理，如果原始视频不可在浏览器直接播放将无法在编辑页面编辑。
        /// </summary>
        [JsonProperty("PreProcessDefinition")]
        public long? PreProcessDefinition{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以向所有视频编辑项目导入媒体；如果指定操作者，则操作者必须为项目所有者。
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
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "VodFileId", this.VodFileId);
            this.SetParamObj(map, prefix + "ExternalMediaInfo.", this.ExternalMediaInfo);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PreProcessDefinition", this.PreProcessDefinition);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

