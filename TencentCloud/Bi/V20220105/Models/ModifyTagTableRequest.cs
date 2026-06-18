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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTagTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 标签表名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 标签表关联的项目id
        /// </summary>
        [JsonProperty("AutoImportProjectId")]
        public long? AutoImportProjectId{ get; set; }

        /// <summary>
        /// 标签表关联的数据表id
        /// </summary>
        [JsonProperty("AutoImportTableId")]
        public long? AutoImportTableId{ get; set; }

        /// <summary>
        /// uin对应字段
        /// </summary>
        [JsonProperty("AutoImportUinField")]
        public string AutoImportUinField{ get; set; }

        /// <summary>
        /// 标签表id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AutoImportProjectId", this.AutoImportProjectId);
            this.SetParamSimple(map, prefix + "AutoImportTableId", this.AutoImportTableId);
            this.SetParamSimple(map, prefix + "AutoImportUinField", this.AutoImportUinField);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

