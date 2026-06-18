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

    public class EditCorpTagRequest : AbstractModel
    {
        
        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 导入标签的模式(manual/auto)
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// 自动导入标签表的id
        /// </summary>
        [JsonProperty("AutoImportTagTableId")]
        public long? AutoImportTagTableId{ get; set; }

        /// <summary>
        /// 自动导入标签的关联字段
        /// </summary>
        [JsonProperty("AutoImportField")]
        public string AutoImportField{ get; set; }

        /// <summary>
        /// 是否异步请求
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// 自动导入标签表的表名
        /// </summary>
        [JsonProperty("AutoImportTagTableName")]
        public string AutoImportTagTableName{ get; set; }

        /// <summary>
        /// 事务id
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "AutoImportTagTableId", this.AutoImportTagTableId);
            this.SetParamSimple(map, prefix + "AutoImportField", this.AutoImportField);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "AutoImportTagTableName", this.AutoImportTagTableName);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
        }
    }
}

