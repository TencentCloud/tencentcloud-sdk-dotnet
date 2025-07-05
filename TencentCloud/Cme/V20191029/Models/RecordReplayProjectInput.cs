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

    public class RecordReplayProjectInput : AbstractModel
    {
        
        /// <summary>
        /// 录制拉流地址。
        /// </summary>
        [JsonProperty("PullStreamUrl")]
        public string PullStreamUrl{ get; set; }

        /// <summary>
        /// 录制文件归属者。
        /// </summary>
        [JsonProperty("MaterialOwner")]
        public Entity MaterialOwner{ get; set; }

        /// <summary>
        /// 录制文件存储分类路径。
        /// </summary>
        [JsonProperty("MaterialClassPath")]
        public string MaterialClassPath{ get; set; }

        /// <summary>
        /// 回放推流地址。
        /// </summary>
        [JsonProperty("PushStreamUrl")]
        public string PushStreamUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PullStreamUrl", this.PullStreamUrl);
            this.SetParamObj(map, prefix + "MaterialOwner.", this.MaterialOwner);
            this.SetParamSimple(map, prefix + "MaterialClassPath", this.MaterialClassPath);
            this.SetParamSimple(map, prefix + "PushStreamUrl", this.PushStreamUrl);
        }
    }
}

