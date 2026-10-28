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

    public class DescribeUserQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统id</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>QuotaId列表</p>
        /// </summary>
        [JsonProperty("QuotaIds")]
        public string[] QuotaIds{ get; set; }

        /// <summary>
        /// <p>配额类型</p>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>配额对象名称列表</p>
        /// </summary>
        [JsonProperty("QuotaObjectNames")]
        public string[] QuotaObjectNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamArraySimple(map, prefix + "QuotaIds.", this.QuotaIds);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamArraySimple(map, prefix + "QuotaObjectNames.", this.QuotaObjectNames);
        }
    }
}

