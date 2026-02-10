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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DistributedLoadAttrs : AbstractModel
    {
        
        /// <summary>
        /// 预热类型，枚举值 LoadByPath｜LoadByList
        /// </summary>
        [JsonProperty("LoadType")]
        public string LoadType{ get; set; }

        /// <summary>
        /// 是否跳过相同文件，默认为 true
        /// </summary>
        [JsonProperty("SkipIfExists")]
        public bool? SkipIfExists{ get; set; }

        /// <summary>
        /// 预热路径，入参单条挂载路径。入参数LoadType为LoadByPath，该参数不应为空
        /// </summary>
        [JsonProperty("LoadByPath")]
        public string LoadByPath{ get; set; }

        /// <summary>
        /// 通过文件列表批量预热，入参为 cos://bucket-appid/ 开头的 COS 路径，且仅支持 txt 格式文件，长度不能超过255个字符。入参数LoadType为LoadByList，该参数不应为空
        /// </summary>
        [JsonProperty("LoadByList")]
        public string LoadByList{ get; set; }

        /// <summary>
        /// 副本数配置，枚举值，可选值 SingleReplica（单副本，默认）｜MaxReplica（最大副本）
        /// </summary>
        [JsonProperty("Replica")]
        public string Replica{ get; set; }

        /// <summary>
        /// 同步执行元数据预热，并基于预热后的元数据执行 DistributedLoad。默认为 false
        /// </summary>
        [JsonProperty("MetadataSync")]
        public bool? MetadataSync{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadType", this.LoadType);
            this.SetParamSimple(map, prefix + "SkipIfExists", this.SkipIfExists);
            this.SetParamSimple(map, prefix + "LoadByPath", this.LoadByPath);
            this.SetParamSimple(map, prefix + "LoadByList", this.LoadByList);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamSimple(map, prefix + "MetadataSync", this.MetadataSync);
        }
    }
}

