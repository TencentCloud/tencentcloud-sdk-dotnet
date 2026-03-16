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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据源类型英文名
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据源权限，取值有RW RO
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }

        /// <summary>
        /// 存储实例ID
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// 数据源挂载配置
        /// </summary>
        [JsonProperty("MountConfigure")]
        public MountConfigureInfo MountConfigure{ get; set; }

        /// <summary>
        /// 标签配置
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamObj(map, prefix + "MountConfigure.", this.MountConfigure);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

