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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Scene : AbstractModel
    {
        
        /// <summary>
        /// 场景 ID 。
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 场景名称。
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 场景创建者。
        /// 
        /// - TAT：公共场景
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// 创建时间。格式为：YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间。格式为：YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

