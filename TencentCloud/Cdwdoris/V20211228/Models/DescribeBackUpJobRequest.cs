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

    public class DescribeBackUpJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>任务类型：<br>0-不限制，或使用TypeFilters过滤；<br>1-备份恢复（包括周期备份和一次性备份）；<br>2-数据迁移（包括跨集群迁移和cos迁移）</p>
        /// </summary>
        [JsonProperty("ApplicationType")]
        public long? ApplicationType{ get; set; }

        /// <summary>
        /// <p>任务类型过滤器</p>
        /// </summary>
        [JsonProperty("TypeFilters")]
        public long?[] TypeFilters{ get; set; }

        /// <summary>
        /// <p>实例状态过滤器</p>
        /// </summary>
        [JsonProperty("StatusFilters")]
        public long?[] StatusFilters{ get; set; }

        /// <summary>
        /// <p>任务名称过滤器</p>
        /// </summary>
        [JsonProperty("ScheduleNameFilters")]
        public string ScheduleNameFilters{ get; set; }

        /// <summary>
        /// <p>按照快照生成时间排序，默认DESC：<br>ASC-升序<br>DESC-降序</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>分页大小</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>页号</p>
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>jobid的string类型</p>
        /// </summary>
        [JsonProperty("JobIdFiltersStr")]
        public string JobIdFiltersStr{ get; set; }

        /// <summary>
        /// <p>0-未加密；1-已加密</p>
        /// </summary>
        [JsonProperty("EncryptionFilters")]
        public long?[] EncryptionFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamArraySimple(map, prefix + "TypeFilters.", this.TypeFilters);
            this.SetParamArraySimple(map, prefix + "StatusFilters.", this.StatusFilters);
            this.SetParamSimple(map, prefix + "ScheduleNameFilters", this.ScheduleNameFilters);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "JobIdFiltersStr", this.JobIdFiltersStr);
            this.SetParamArraySimple(map, prefix + "EncryptionFilters.", this.EncryptionFilters);
        }
    }
}

