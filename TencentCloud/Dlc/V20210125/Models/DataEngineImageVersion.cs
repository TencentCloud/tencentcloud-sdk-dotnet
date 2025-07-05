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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataEngineImageVersion : AbstractModel
    {
        
        /// <summary>
        /// 镜像大版本ID
        /// </summary>
        [JsonProperty("ImageVersionId")]
        public string ImageVersionId{ get; set; }

        /// <summary>
        /// 镜像大版本名称
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// 镜像大版本描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否为公共版本：1：公共；2：私有
        /// </summary>
        [JsonProperty("IsPublic")]
        public ulong? IsPublic{ get; set; }

        /// <summary>
        /// 集群类型：SparkSQL/PrestoSQL/SparkBatch
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 版本状态：1：初始化；2：上线；3：下线
        /// </summary>
        [JsonProperty("IsSharedEngine")]
        public ulong? IsSharedEngine{ get; set; }

        /// <summary>
        /// 版本状态：1：初始化；2：上线；3：下线
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// 插入时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageVersionId", this.ImageVersionId);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "IsSharedEngine", this.IsSharedEngine);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

