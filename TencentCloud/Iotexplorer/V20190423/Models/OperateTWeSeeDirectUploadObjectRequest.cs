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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperateTWeSeeDirectUploadObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// TWeSee 直传对象或目录的 COS URI
        /// </summary>
        [JsonProperty("COSURI")]
        public string COSURI{ get; set; }

        /// <summary>
        /// 操作类型。可选值：
        /// 
        /// - `HeadObject`：查询对象元数据
        /// - `DeleteObject`：删除对象
        /// - `ListBucket`：列举对象
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 列举对象时使用的分页和目录选项
        /// </summary>
        [JsonProperty("ListOptions")]
        public SeeObjectListOptions ListOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "COSURI", this.COSURI);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamObj(map, prefix + "ListOptions.", this.ListOptions);
        }
    }
}

