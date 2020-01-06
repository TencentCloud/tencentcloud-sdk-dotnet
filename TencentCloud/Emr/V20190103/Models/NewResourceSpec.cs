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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NewResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// 描述Master节点资源
        /// </summary>
        [JsonProperty("MasterResourceSpec")]
        public Resource MasterResourceSpec{ get; set; }

        /// <summary>
        /// 描述Core节点资源
        /// </summary>
        [JsonProperty("CoreResourceSpec")]
        public Resource CoreResourceSpec{ get; set; }

        /// <summary>
        /// 描述Task节点资源
        /// </summary>
        [JsonProperty("TaskResourceSpec")]
        public Resource TaskResourceSpec{ get; set; }

        /// <summary>
        /// Master节点数量
        /// </summary>
        [JsonProperty("MasterCount")]
        public long? MasterCount{ get; set; }

        /// <summary>
        /// Core节点数量
        /// </summary>
        [JsonProperty("CoreCount")]
        public long? CoreCount{ get; set; }

        /// <summary>
        /// Task节点数量
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// 描述Common节点资源
        /// </summary>
        [JsonProperty("CommonResourceSpec")]
        public Resource CommonResourceSpec{ get; set; }

        /// <summary>
        /// Common节点数量
        /// </summary>
        [JsonProperty("CommonCount")]
        public long? CommonCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MasterResourceSpec.", this.MasterResourceSpec);
            this.SetParamObj(map, prefix + "CoreResourceSpec.", this.CoreResourceSpec);
            this.SetParamObj(map, prefix + "TaskResourceSpec.", this.TaskResourceSpec);
            this.SetParamSimple(map, prefix + "MasterCount", this.MasterCount);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamObj(map, prefix + "CommonResourceSpec.", this.CommonResourceSpec);
            this.SetParamSimple(map, prefix + "CommonCount", this.CommonCount);
        }
    }
}

