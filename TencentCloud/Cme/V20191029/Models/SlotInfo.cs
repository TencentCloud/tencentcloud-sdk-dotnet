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

    public class SlotInfo : AbstractModel
    {
        
        /// <summary>
        /// 卡槽 Id。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 卡槽类型，可取值有：
        /// <li> AUDIO：音频卡槽，可替换素材类型为 AUDIO 的音频素材;</li>
        /// <li> VIDEO：视频卡槽，可替换素材类型为 VIDEO 的视频素材;</li>
        /// <li> IMAGE：图片卡槽，可替换素材类型为 IMAGE 的图片素材;</li>
        /// <li> TEXT：文本卡槽，可替换文本内容。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 默认素材ID。当卡槽类型为 AUDIO，VIDEO，或 IMAGE 中的一种时有效。
        /// </summary>
        [JsonProperty("DefaultMaterialId")]
        public string DefaultMaterialId{ get; set; }

        /// <summary>
        /// 默认文本卡槽信息。当卡槽类型为 TEXT 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultTextSlotInfo")]
        public TextSlotInfo DefaultTextSlotInfo{ get; set; }

        /// <summary>
        /// 素材时长，单位秒。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 卡槽起始时间，单位秒。
        /// </summary>
        [JsonProperty("StartTime")]
        public float? StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DefaultMaterialId", this.DefaultMaterialId);
            this.SetParamObj(map, prefix + "DefaultTextSlotInfo.", this.DefaultTextSlotInfo);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

