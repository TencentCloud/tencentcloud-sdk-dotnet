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

    public class RegisterMeta : AbstractModel
    {
        
        /// <summary>
        /// <p>Checkpoint 子路径不能为空</p>
        /// </summary>
        [JsonProperty("CheckpointSubPath")]
        public string CheckpointSubPath{ get; set; }

        /// <summary>
        /// <p>来源训练实例标识（接入方自定义语义，可选）</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>接入方扩展键值列表（原样落库，平台不解释）</p>
        /// </summary>
        [JsonProperty("Extras")]
        public KVPair[] Extras{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckpointSubPath", this.CheckpointSubPath);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Extras.", this.Extras);
        }
    }
}

