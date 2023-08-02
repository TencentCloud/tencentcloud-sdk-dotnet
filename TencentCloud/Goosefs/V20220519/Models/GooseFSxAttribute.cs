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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GooseFSxAttribute : AbstractModel
    {
        
        /// <summary>
        /// GooseFSx的型号
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 容量单位是GB, 比如4608(4.5TB)
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// 要关联映射的bucket列表
        /// </summary>
        [JsonProperty("MappedBucketList")]
        public MappedBucket[] MappedBucketList{ get; set; }

        /// <summary>
        /// 客户侧管理节点信息
        /// </summary>
        [JsonProperty("ClientManagerNodeList")]
        public ClientClusterManagerNodeInfo[] ClientManagerNodeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamArrayObj(map, prefix + "MappedBucketList.", this.MappedBucketList);
            this.SetParamArrayObj(map, prefix + "ClientManagerNodeList.", this.ClientManagerNodeList);
        }
    }
}

