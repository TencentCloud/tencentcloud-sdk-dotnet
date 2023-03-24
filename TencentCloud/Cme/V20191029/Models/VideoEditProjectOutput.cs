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

    public class VideoEditProjectOutput : AbstractModel
    {
        
        /// <summary>
        /// 导出的多媒体创作引擎媒体 Id，仅当导出目标为多媒体创作引擎媒体时有效。
        /// </summary>
        [JsonProperty("MaterialId")]
        public string MaterialId{ get; set; }

        /// <summary>
        /// 云点播媒资 FileId。
        /// </summary>
        [JsonProperty("VodFileId")]
        public string VodFileId{ get; set; }

        /// <summary>
        /// 导出的媒资 URL。
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// 元信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// 导出视频的封面图片 URL。
        /// </summary>
        [JsonProperty("CoverURL")]
        public string CoverURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "VodFileId", this.VodFileId);
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "CoverURL", this.CoverURL);
        }
    }
}

