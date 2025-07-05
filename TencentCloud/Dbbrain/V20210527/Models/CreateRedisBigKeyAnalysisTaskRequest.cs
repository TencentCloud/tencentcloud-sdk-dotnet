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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRedisBigKeyAnalysisTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括 "redis" - 云数据库 Redis。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 分片节点序号列表。当列表为空时，选择所有分片节点。
        /// </summary>
        [JsonProperty("ShardIds")]
        public long?[] ShardIds{ get; set; }

        /// <summary>
        /// Top Key前缀的分隔符列表。
        /// 目前仅支持以下分割符：[",", ";", ":", "_", "-", "+", "@", "=", "|", "#", "."]，当列表为空时，默认选择所有分隔符。
        /// </summary>
        [JsonProperty("KeyDelimiterList")]
        public string[] KeyDelimiterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "ShardIds.", this.ShardIds);
            this.SetParamArraySimple(map, prefix + "KeyDelimiterList.", this.KeyDelimiterList);
        }
    }
}

