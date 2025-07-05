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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageData : AbstractModel
    {
        
        /// <summary>
        /// 图片中出现的可视文本识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrSet")]
        public ImageOcr[] OcrSet{ get; set; }

        /// <summary>
        /// 图片中出现的帧标签识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameTagSet")]
        public MultiLevelTag FrameTagSet{ get; set; }

        /// <summary>
        /// 图片中出现的层级人物识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiLevelPersonInfoSet")]
        public MultiLevelPersonInfo[] MultiLevelPersonInfoSet{ get; set; }

        /// <summary>
        /// 图片中出现的台标识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TvLogo")]
        public ImageLogo TvLogo{ get; set; }

        /// <summary>
        /// 图片中出现的来源信息识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceLogo")]
        public ImageLogo SourceLogo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "OcrSet.", this.OcrSet);
            this.SetParamObj(map, prefix + "FrameTagSet.", this.FrameTagSet);
            this.SetParamArrayObj(map, prefix + "MultiLevelPersonInfoSet.", this.MultiLevelPersonInfoSet);
            this.SetParamObj(map, prefix + "TvLogo.", this.TvLogo);
            this.SetParamObj(map, prefix + "SourceLogo.", this.SourceLogo);
        }
    }
}

