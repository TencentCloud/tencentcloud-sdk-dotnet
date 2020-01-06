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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSyncJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 灾备同步任务名
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 灾备同步任务配置选项
        /// </summary>
        [JsonProperty("SyncOption")]
        public SyncOption SyncOption{ get; set; }

        /// <summary>
        /// 源实例数据库类型，目前仅包括：mysql
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 源实例接入类型，目前仅包括：cdb(云上cdb实例)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源实例信息
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SyncInstanceInfo SrcInfo{ get; set; }

        /// <summary>
        /// 目标实例数据库类型，目前仅包括：mysql
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例接入类型，目前仅包括：cdb(云上cdb实例)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 目标实例信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public SyncInstanceInfo DstInfo{ get; set; }

        /// <summary>
        /// 需要同步的源数据库表信息，用json格式的字符串描述。
        /// 对于database-table两级结构的数据库：
        /// [{Database:db1,Table:[table1,table2]},{Database:db2}]
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "SyncOption.", this.SyncOption);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
        }
    }
}

