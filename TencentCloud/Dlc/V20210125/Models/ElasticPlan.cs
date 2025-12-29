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

    public class ElasticPlan : AbstractModel
    {
        
        /// <summary>
        /// 最小集群数
        /// </summary>
        [JsonProperty("MinElasticClusters")]
        public long? MinElasticClusters{ get; set; }

        /// <summary>
        /// 最大集群数
        /// </summary>
        [JsonProperty("MaxElasticClusters")]
        public long? MaxElasticClusters{ get; set; }

        /// <summary>
        /// 最大排队时间
        /// </summary>
        [JsonProperty("TolerableQueueTime")]
        public long? TolerableQueueTime{ get; set; }

        /// <summary>
        /// 开始时间，Once格式：yyyy-MM-dd HH:mm:ss; 非Once格式： HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，Once格式：yyyy-MM-dd HH:mm:ss; 非Once格式： HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分时弹性上限
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public long? ElasticLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinElasticClusters", this.MinElasticClusters);
            this.SetParamSimple(map, prefix + "MaxElasticClusters", this.MaxElasticClusters);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
        }
    }
}

