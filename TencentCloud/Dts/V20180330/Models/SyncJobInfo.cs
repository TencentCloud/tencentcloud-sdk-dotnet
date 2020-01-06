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

    public class SyncJobInfo : AbstractModel
    {
        
        /// <summary>
        /// 灾备任务id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 灾备任务名
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 任务同步
        /// </summary>
        [JsonProperty("SyncOption")]
        public SyncOption SyncOption{ get; set; }

        /// <summary>
        /// 源接入类型
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源数据类型
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 源实例信息
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SyncInstanceInfo SrcInfo{ get; set; }

        /// <summary>
        /// 灾备接入类型
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 灾备数据类型
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// 灾备实例信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public SyncInstanceInfo DstInfo{ get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        [JsonProperty("Detail")]
        public SyncDetailInfo Detail{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 迁移库表
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "SyncOption.", this.SyncOption);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

