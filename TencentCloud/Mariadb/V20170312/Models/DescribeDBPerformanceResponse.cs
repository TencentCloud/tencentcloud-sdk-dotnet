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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBPerformanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 慢查询数
        /// </summary>
        [JsonProperty("LongQuery")]
        public MonitorData LongQuery{ get; set; }

        /// <summary>
        /// 查询操作数SELECT
        /// </summary>
        [JsonProperty("SelectTotal")]
        public MonitorData SelectTotal{ get; set; }

        /// <summary>
        /// 更新操作数UPDATE
        /// </summary>
        [JsonProperty("UpdateTotal")]
        public MonitorData UpdateTotal{ get; set; }

        /// <summary>
        /// 插入操作数INSERT
        /// </summary>
        [JsonProperty("InsertTotal")]
        public MonitorData InsertTotal{ get; set; }

        /// <summary>
        /// 删除操作数DELETE
        /// </summary>
        [JsonProperty("DeleteTotal")]
        public MonitorData DeleteTotal{ get; set; }

        /// <summary>
        /// 缓存命中率
        /// </summary>
        [JsonProperty("MemHitRate")]
        public MonitorData MemHitRate{ get; set; }

        /// <summary>
        /// 磁盘每秒IO次数
        /// </summary>
        [JsonProperty("DiskIops")]
        public MonitorData DiskIops{ get; set; }

        /// <summary>
        /// 活跃连接数
        /// </summary>
        [JsonProperty("ConnActive")]
        public MonitorData ConnActive{ get; set; }

        /// <summary>
        /// 是否发生主备切换，1为发生，0否
        /// </summary>
        [JsonProperty("IsMasterSwitched")]
        public MonitorData IsMasterSwitched{ get; set; }

        /// <summary>
        /// 主备延迟
        /// </summary>
        [JsonProperty("SlaveDelay")]
        public MonitorData SlaveDelay{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LongQuery.", this.LongQuery);
            this.SetParamObj(map, prefix + "SelectTotal.", this.SelectTotal);
            this.SetParamObj(map, prefix + "UpdateTotal.", this.UpdateTotal);
            this.SetParamObj(map, prefix + "InsertTotal.", this.InsertTotal);
            this.SetParamObj(map, prefix + "DeleteTotal.", this.DeleteTotal);
            this.SetParamObj(map, prefix + "MemHitRate.", this.MemHitRate);
            this.SetParamObj(map, prefix + "DiskIops.", this.DiskIops);
            this.SetParamObj(map, prefix + "ConnActive.", this.ConnActive);
            this.SetParamObj(map, prefix + "IsMasterSwitched.", this.IsMasterSwitched);
            this.SetParamObj(map, prefix + "SlaveDelay.", this.SlaveDelay);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

