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

    public class ImageTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 图片编码配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncodeConfig")]
        public ImageEncodeConfig EncodeConfig{ get; set; }

        /// <summary>
        /// 图片增强配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnhanceConfig")]
        public ImageEnhanceConfig EnhanceConfig{ get; set; }

        /// <summary>
        /// 图片擦除配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EraseConfig")]
        public ImageEraseConfig EraseConfig{ get; set; }

        /// <summary>
        /// 盲水印配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlindWatermarkConfig")]
        public BlindWatermarkConfig BlindWatermarkConfig{ get; set; }

        /// <summary>
        /// 美颜配置。
        /// </summary>
        [JsonProperty("BeautyConfig")]
        public BeautyConfig BeautyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EncodeConfig.", this.EncodeConfig);
            this.SetParamObj(map, prefix + "EnhanceConfig.", this.EnhanceConfig);
            this.SetParamObj(map, prefix + "EraseConfig.", this.EraseConfig);
            this.SetParamObj(map, prefix + "BlindWatermarkConfig.", this.BlindWatermarkConfig);
            this.SetParamObj(map, prefix + "BeautyConfig.", this.BeautyConfig);
        }
    }
}

