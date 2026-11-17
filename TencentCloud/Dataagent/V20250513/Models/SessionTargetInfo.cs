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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionTargetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>targetID</p>
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// <p>targetType</p>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>target名称</p>
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// <p>资源名称</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>最后活跃时间</p><p>参数格式：2026-11-05 14:30:00</p>
        /// </summary>
        [JsonProperty("LastInteractionTime")]
        public string LastInteractionTime{ get; set; }

        /// <summary>
        /// <p>上下文</p>
        /// </summary>
        [JsonProperty("SurfaceContext")]
        public SurfaceContext SurfaceContext{ get; set; }

        /// <summary>
        /// <p>是否保存</p>
        /// </summary>
        [JsonProperty("Saved")]
        public bool? Saved{ get; set; }

        /// <summary>
        /// <p>保存时间</p>
        /// </summary>
        [JsonProperty("SavedAt")]
        public string SavedAt{ get; set; }

        /// <summary>
        /// <p>是否删除</p>
        /// </summary>
        [JsonProperty("Deleted")]
        public bool? Deleted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "LastInteractionTime", this.LastInteractionTime);
            this.SetParamObj(map, prefix + "SurfaceContext.", this.SurfaceContext);
            this.SetParamSimple(map, prefix + "Saved", this.Saved);
            this.SetParamSimple(map, prefix + "SavedAt", this.SavedAt);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
        }
    }
}

