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

    public class MaterialInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒体基本信息。
        /// </summary>
        [JsonProperty("BasicInfo")]
        public MaterialBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 视频媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoMaterial")]
        public VideoMaterial VideoMaterial{ get; set; }

        /// <summary>
        /// 音频媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioMaterial")]
        public AudioMaterial AudioMaterial{ get; set; }

        /// <summary>
        /// 图片媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageMaterial")]
        public ImageMaterial ImageMaterial{ get; set; }

        /// <summary>
        /// 链接媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkMaterial")]
        public LinkMaterial LinkMaterial{ get; set; }

        /// <summary>
        /// 模板媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoEditTemplateMaterial")]
        public VideoEditTemplateMaterial VideoEditTemplateMaterial{ get; set; }

        /// <summary>
        /// 其他类型媒体信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherMaterial")]
        public OtherMaterial OtherMaterial{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "VideoMaterial.", this.VideoMaterial);
            this.SetParamObj(map, prefix + "AudioMaterial.", this.AudioMaterial);
            this.SetParamObj(map, prefix + "ImageMaterial.", this.ImageMaterial);
            this.SetParamObj(map, prefix + "LinkMaterial.", this.LinkMaterial);
            this.SetParamObj(map, prefix + "VideoEditTemplateMaterial.", this.VideoEditTemplateMaterial);
            this.SetParamObj(map, prefix + "OtherMaterial.", this.OtherMaterial);
        }
    }
}

