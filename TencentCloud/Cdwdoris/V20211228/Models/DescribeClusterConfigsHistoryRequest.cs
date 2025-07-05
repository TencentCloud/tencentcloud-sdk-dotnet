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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterConfigsHistoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id名称
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 分页参数，第一页为0，第二页为10
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页参数，分页步长，默认为10
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 配置修改历史的时间范围开始
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 配置修改历史的时间范围结束
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 需要查询的配置文件名称数组，如果为空则查询全部历史记录。目前支持的配置文件名称有：
        /// apache_hdfs_broker.conf、be.conf、fe.conf、core-site.xml、hdfs-site.xml、odbcinst.ini
        /// </summary>
        [JsonProperty("ConfigFileNames")]
        public string[] ConfigFileNames{ get; set; }

        /// <summary>
        /// 需要查询的计算组列表
        /// </summary>
        [JsonProperty("ComputeGroupIds")]
        public string[] ComputeGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "ConfigFileNames.", this.ConfigFileNames);
            this.SetParamArraySimple(map, prefix + "ComputeGroupIds.", this.ComputeGroupIds);
        }
    }
}

