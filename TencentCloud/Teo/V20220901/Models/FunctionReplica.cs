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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionReplica : AbstractModel
    {
        
        /// <summary>
        /// 函数 ID。
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 边缘函数副本名称。
        /// </summary>
        [JsonProperty("ReplicaName")]
        public string ReplicaName{ get; set; }

        /// <summary>
        /// 边缘函数副本内容。格式为 JavaScript 代码。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 边缘函数副本描述。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 边缘函数副本创建时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 边缘函数副本更新时间。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "ReplicaName", this.ReplicaName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

