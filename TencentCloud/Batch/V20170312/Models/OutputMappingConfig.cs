/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputMappingConfig : AbstractModel
    {
        
        /// <summary>
        /// 存储类型，仅支持COS
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 并行worker数量
        /// </summary>
        [JsonProperty("WorkerNum")]
        public long? WorkerNum{ get; set; }

        /// <summary>
        /// worker分块大小，单位MB
        /// </summary>
        [JsonProperty("WorkerPartSize")]
        public long? WorkerPartSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "WorkerNum", this.WorkerNum);
            this.SetParamSimple(map, prefix + "WorkerPartSize", this.WorkerPartSize);
        }
    }
}

