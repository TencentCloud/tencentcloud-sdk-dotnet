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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckMigrateIndexMetaDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 索引 id
        /// </summary>
        [JsonProperty("ServerlessId")]
        public string ServerlessId{ get; set; }

        /// <summary>
        /// 快照名
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// Cos桶名
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// BasePath路径
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// 云上集群名
        /// </summary>
        [JsonProperty("ClusterInstanceId")]
        public string ClusterInstanceId{ get; set; }

        /// <summary>
        /// 普通索引名列表
        /// </summary>
        [JsonProperty("CommonIndexArr")]
        public string[] CommonIndexArr{ get; set; }

        /// <summary>
        /// 自治索引名列表
        /// </summary>
        [JsonProperty("DataStreamArr")]
        public string[] DataStreamArr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerlessId", this.ServerlessId);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamSimple(map, prefix + "ClusterInstanceId", this.ClusterInstanceId);
            this.SetParamArraySimple(map, prefix + "CommonIndexArr.", this.CommonIndexArr);
            this.SetParamArraySimple(map, prefix + "DataStreamArr.", this.DataStreamArr);
        }
    }
}

